using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IRequestExpandService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestExpandLocation(int id);
    Task<ResultModel> Create(RequestExpandCreateModel model);
    Task<ResultModel> Update(RequestExpandUpdateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Evaluate(int requestExpandId, RequestStatus status, UserAssignModel model);
    Task<ResultModel> DeleteRequestExpandLocation(int requestExpandId);
    Task<ResultModel> AssignLocation(int requestExpandId, RequestExpandAssignLocationModel model);
    Task<ResultModel> CheckCompletability(int requestExpandId);
    Task<ResultModel> Complete(int requestExpandId);
    Task<ResultModel> GetInspectionReport(int requestExpandId);
}

public class RequestExpandService : IRequestExpandService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestExpandService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpands = _dbContext.RequestExpands
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpands.Count());

            requestExpands = requestExpands.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestExpands = requestExpands.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestExpandModel>(requestExpands).ToList();

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
            var requestExpand = _dbContext.RequestExpands
                .FirstOrDefault(x => x.Id == id);

            if (requestExpand != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
            else
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestExpandCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestExpand = _mapper.Map<RequestExpand>(model);
                requestExpand.Status = RequestStatus.Waiting;
                _dbContext.RequestExpands.Add(requestExpand);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(RequestExpandUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == model.Id);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else
            {
                _mapper.Map<RequestExpandUpdateModel, RequestExpand>(model, requestExpand);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == id);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.RequestExpands.Remove(requestExpand);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestExpand.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetRequestExpandLocation(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.RequestExpandLocations)
                .FirstOrDefault(x => x.Id == id);

            if (requestExpand != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<RequestExpandLocationModel>>(requestExpand.RequestExpandLocations);
            }
            else
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Evaluate(int requestExpandId, RequestStatus status, UserAssignModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            if (status != RequestStatus.Accepted && status != RequestStatus.Denied)
            {
                throw new Exception(ErrorMessage.WRONG_PURPOSE);
            }

            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition && requestExpand.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                requestExpand.Status = status;
                _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                {
                    RequestExpandId = requestExpand.Id,
                    UserId = new Guid(model.UserId)
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> DeleteRequestExpandLocation(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandLocations).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_ACCEPTED;
            }
            else
            {
                var requestExpandLocations = requestExpand.RequestExpandLocations;
                _dbContext.RequestExpandLocations.RemoveRange(requestExpandLocations);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestExpandLocations.Select(x => x.Id);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignLocation(int requestExpandId, RequestExpandAssignLocationModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment).Include(x => x.RequestExpandLocations).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else
            {
                if (requestExpand.RequestExpandLocations.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestExpandLocationErrorMessage.EXISTED;
                }
            }

            if (validPrecondition)
            {
                var appointmentAccepted = requestExpand.RequestExpandAppointments.Select(x => x.Appointment).Any(x => x.Status == RequestStatus.Accepted);
                if (!appointmentAccepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_ACCEPTED;
                }
            }

            List<Location> locations = null;
            if (validPrecondition)
            {
                locations = _dbContext.Locations
                    .Include(x => x.LocationAssignments)
                    .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand)
                    .Where(x => x.RackId == model.RackId && x.Position >= model.StartPosition && x.Position < model.StartPosition + model.Size).ToList();
                if (locations.Count != model.Size)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestExpandLocationErrorMessage.INVALID_LOCATION;
                }
                else
                {
                    validPrecondition = CheckValidLocation(locations, requestExpandId, result);
                }
            }

            if (validPrecondition)
            {
                foreach (var location in locations)
                {
                    _dbContext.RequestExpandLocations.Add(new RequestExpandLocation
                    {
                        LocationId = location.Id,
                        RequestExpandId = requestExpandId,
                    });
                }
                _dbContext.SaveChanges();
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool CheckValidLocation(List<Location> locations, int requestExpandId, ResultModel result)
    {
        bool allValidLocation = true;
        foreach (var location in locations)
        {
            if (location.LocationAssignments.Any())
            {
                allValidLocation = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.EXISTED;
            }
            else if (location.RequestExpandLocations.Select(x => x.RequestExpand).Any(x => (x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted) && x.Id != requestExpandId))
            {
                allValidLocation = false;
                result.ErrorMessage = RequestExpandLocationErrorMessage.EXISTED;
            }
        }

        return allValidLocation;
    }

    public async Task<ResultModel> CheckCompletability(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            result.Data = IsCompletable(requestExpandId);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IsCompletable(int requestExpandId)
    {
        var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment).FirstOrDefault(x => x.Id == requestExpandId);
        if (requestExpand == null)
        {
            return false;
        }

        bool appointmentSucceeded = requestExpand.RequestExpandAppointments.Any(x => x.Appointment.Status == RequestStatus.Success);
        bool haveInspectionFile = requestExpand.InspectionReportFilePath != null;
        return appointmentSucceeded && haveInspectionFile;
    }

    public async Task<ResultModel> Complete(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == requestExpandId && x.Status == RequestStatus.Accepted);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (!IsCompletable(requestExpandId))
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_COMPLETABLE;
                validPrecondition = false;
            }

            List<Location> locations = null;
            if (validPrecondition)
            {
                locations = requestExpand.RequestExpandLocations.Select(x => x.Location).ToList();
                validPrecondition = CheckValidLocation(locations, requestExpandId, result);
            }

            if (validPrecondition)
            {
                var serverAllocation = requestExpand.ServerAllocation;
                bool haveLocation = serverAllocation.LocationAssignments.Any();
                var locationAssignments = new List<LocationAssignment>();
                foreach (var location in locations)
                {
                    locationAssignments.Add(new LocationAssignment
                    {
                        ServerAllocationId = requestExpand.ServerAllocationId,
                        LocationId = location.Id,
                        IsServer = !haveLocation
                    });
                }
                _dbContext.LocationAssignments.AddRange(locationAssignments);
                serverAllocation.Power += requestExpand.Power;
                requestExpand.Status = RequestStatus.Success;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetInspectionReport(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.InspectionReportFilePath == null)
            {
                result.ErrorMessage = ErrorMessage.FILE_NOT_EXISTED;
            }
            else
            {
                result.Succeed = true;
                result.Data = requestExpand.InspectionReportFilePath;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}