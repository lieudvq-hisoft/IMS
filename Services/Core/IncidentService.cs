using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Services.Core;
public interface IIncidentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IncidentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(IncidentCreateModel model, Guid userId);
    Task<ResultModel> Resolv(IncidentResolvModel model, Guid userId);
}

public class IncidentService : IIncidentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly INotificationService _notiService;

    public IncidentService(AppDbContext dbContext, IMapper mapper, INotificationService notiService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _notiService = notiService;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IncidentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var incidents = _dbContext.Incidents
                .Include(x => x.IncidentAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.IncidentUsers).ThenInclude(x => x.User)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, incidents.Count());

            incidents = incidents.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            incidents = incidents.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<IncidentModel>>(incidents.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var incident = _dbContext.Incidents
                .Include(x => x.IncidentAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.IncidentUsers).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == id);

            if (incident == null)
            {
                result.ErrorMessage = "Incident not exist";
            }
            else
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IncidentModel>(incident);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(IncidentCreateModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != Data.Enums.ServerAllocationStatus.Removed && x.Status != Data.Enums.ServerAllocationStatus.Waiting);
            if (serverAllocation == null)
            {
                result.ErrorMessage = IncidentErrorMessage.NOT_EXISTED;
            }
            else
            {
                var incident = _mapper.Map<IncidentCreateModel, Incident>(model);
                _dbContext.Incidents.Add(incident);
                _dbContext.SaveChanges();
                _dbContext.IncidentUsers.Add(new IncidentUser
                {
                    IncidentId = incident.Id,
                    UserId = userId,
                    Action = RequestUserAction.Evaluate
                });
                if (model.PausingRequired)
                {
                    serverAllocation.Status = Data.Enums.ServerAllocationStatus.Pausing;
                }
                _dbContext.SaveChanges();

                var incidentModelString = JsonSerializer.Serialize(_mapper.Map<IncidentResultModel>(incident));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = serverAllocation.CustomerId,
                    Action = "Incident",
                    Title = "Incident occured",
                    Body = "There's an incident just occured",
                    Data = new NotificationData
                    {
                        Key = "Incident",
                        Value = incidentModelString
                    }
                });
                result.Succeed = true;
                result.Data = _mapper.Map<IncidentResultModel>(incident);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Resolv(IncidentResolvModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var incident = _dbContext.Incidents
                .Include(x => x.IncidentAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.ServerAllocation)
                .Include(x => x.IncidentUsers).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == model.Id && !x.IsResolved);
            if (incident == null)
            {
                result.ErrorMessage = IncidentErrorMessage.NOT_EXISTED;
            }
            else if (incident.IsResolvByClient)
            {
                result.ErrorMessage = "Incident need an appointment from client to be resolved";
            }
            else
            {
                incident.Solution = model.Solution;
                incident.IsResolved = true;
                _dbContext.IncidentUsers.Add(new IncidentUser
                {
                    IncidentId = incident.Id,
                    UserId = userId,
                    Action = RequestUserAction.Execute
                });
                var serverAllocation = incident.ServerAllocation;
                bool stopPausing = serverAllocation.Status == ServerAllocationStatus.Pausing && !serverAllocation.Incidents.Any(x => !x.IsResolved && x.PausingRequired);
                if (stopPausing)
                {
                    serverAllocation.Status = ServerAllocationStatus.Working;
                }
                _dbContext.SaveChanges();

                var incidentModelString = JsonSerializer.Serialize(_mapper.Map<IncidentResultModel>(incident));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = serverAllocation.CustomerId,
                    Action = "Resolved",
                    Title = "Incident resolved",
                    Body = "There's an incident just resolved",
                    Data = new NotificationData
                    {
                        Key = "Incident",
                        Value = incidentModelString
                    }
                });
                if (stopPausing)
                {
                    var serverModelString = JsonSerializer.Serialize(_mapper.Map<ServerAllocationResultModel>(serverAllocation));
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = serverAllocation.CustomerId,
                        Action = "Resolved",
                        Title = "Incident resolved",
                        Body = "There's an incident just resolved",
                        Data = new NotificationData
                        {
                            Key = "ServerAllocation",
                            Value = serverModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = _mapper.Map<IncidentResultModel>(incident);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
