using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;
using System.Text.Json;

namespace Services.Core;
public interface IRequestUpgradeService
{
    Task<ResultModel> Get(PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetAppointment(int requestUpgradeId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> Create(RequestUpgradeCreateModel model);
    Task<ResultModel> CreateBulk(RequestUpgradeCreateBulkModel model);
    Task<ResultModel> Delete(int requestUpgradeId);
    Task<ResultModel> Reject(int requestUpgradeId, RequestUpgradeRejectModel model);
    Task<ResultModel> Update(RequestUpgradeUpdateModel model);
    Task<ResultModel> Evaluate(int requestUpgradeId, RequestStatus status, Guid userId);
    Task<ResultModel> EvaluateBulk(RequestUpgradeEvaluateBulkModel model, RequestStatus status, Guid userId);
    Task<ResultModel> CheckCompletability(int requestUpgradeId);
    Task<ResultModel> Complete(int requestUpgradeId, Guid userId);
    Task<ResultModel> CompleteBulk(RequestUpgradeCompleteBulkModel model, Guid userId);
}

public class RequestUpgradeService : IRequestUpgradeService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestUpgradeService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrades = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Where(delegate (RequestUpgrade x)
                {
                    return x.FilterRequestUpgrade(searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgrades.Count());

            requestUpgrades = requestUpgrades.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestUpgrades = requestUpgrades.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestUpgradeModel>>(requestUpgrades.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAppointment(int requestUpgradeId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        var appointments = _dbContext.Appointments.Include(x => x.ServerAllocation).Include(x => x.RequestUpgradeAppointment)
            .Include(x => x.AppointmentUsers)
            .Where(x => x.RequestUpgradeAppointment.Any(x => x.RequestUpgradeId == requestUpgradeId))
            .Where(delegate (Appointment x)
            {
                return x.FilterAppointment(searchModel);
            }).AsQueryable();

        var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());

        appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
        appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

        paging.Data = _mapper.Map<List<AppointmentModel>>(appointments.ToList());

        result.Data = paging;
        result.Succeed = true;

        return result;
    }

    public async Task<ResultModel> Create(RequestUpgradeCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var component = _dbContext.Components.Include(x => x.ServerHardwareConfigs).FirstOrDefault(x => x.Id == model.ComponentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.LocationAssignments)
                .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (validPrecondition)
            {
                if (serverAllocation == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                }
                else if (!serverAllocation.LocationAssignments.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = "Cannot modify unallocated server";
                }
                else if (!serverAllocation.ServerHardwareConfigs.Select(x => x.Component).Any(x => x.Id == component.Id))
                {
                    validPrecondition = false;
                    result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
                }
            }

            if (validPrecondition)
            {
                var existedRequestUpgrade = _dbContext.RequestUpgrades
                    .Include(x => x.ServerAllocation).Include(x => x.Component)
                    .Any(x => x.ServerAllocationId == model.ServerAllocationId && x.ServerAllocation.Status != ServerAllocationStatus.Removed && x.ComponentId == model.ComponentId && (x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting));
                if (existedRequestUpgrade)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestUpgradeErrorMessage.EXISTED;
                }
            }

            if (validPrecondition && !CheckValidSerialNumber(model.Descriptions.Select(x => x.SerialNumber).ToList(), serverAllocation.Id))
            {
                validPrecondition = false;
                result.ErrorMessage = "Serial number existed";
            }

            if (validPrecondition)
            {
                var requestUpgrade = _mapper.Map<RequestUpgrade>(model);
                requestUpgrade.Status = RequestStatus.Waiting;

                _dbContext.RequestUpgrades.Add(requestUpgrade);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeResultModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool CheckValidSerialNumber(List<string> serialNumbers, int serverAllocationId)
    {
        var existedSerialNumber = _dbContext.ServerHardwareConfigs.Include(x => x.ServerAllocation)
            .Where(x => x.ServerAllocation.Status != ServerAllocationStatus.Removed)
            .Where(x => serverAllocationId != 0 ? x.ServerAllocationId != serverAllocationId : true)
            .ToList().SelectMany(x => JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(x.Description).Select(x => x.SerialNumber));
        return !serialNumbers.Any(x => existedSerialNumber.Contains(x)) && serialNumbers.Distinct().Count() == serialNumbers.Count();
    }

    public async Task<ResultModel> CreateBulk(RequestUpgradeCreateBulkModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestUpgradeRequestModel in model.RequestUpgradeCreateModels)
            {
                results.Add(await Create(requestUpgradeRequestModel));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(RequestUpgradeUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .FirstOrDefault(x => x.Id == model.Id);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestUpgrade.Status != RequestStatus.Waiting && requestUpgrade.Status != RequestStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING + " & " + RequestUpgradeErrorMessage.NOT_ACCEPTED;
            }

            var component = requestUpgrade?.Component;
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = requestUpgrade?.ServerAllocation;
            if (serverAllocation == null || serverAllocation.Status == ServerAllocationStatus.Removed)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (!serverAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot modify unallocated server";
            }

            if (validPrecondition && !CheckValidSerialNumber(model.Descriptions.Select(x => x.SerialNumber).ToList(), serverAllocation.Id))
            {
                validPrecondition = false;
                result.ErrorMessage = "Serial number existed";
            }

            if (validPrecondition)
            {
                _mapper.Map<RequestUpgradeUpdateModel, RequestUpgrade>(model, requestUpgrade);

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else if (requestUpgrade.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING;
            }
            else
            {
                requestUpgrade.Status = RequestStatus.Failed;
                requestUpgrade.Note = "Customer deleted";
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestUpgradeId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Reject(int requestUpgradeId, RequestUpgradeRejectModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else if (requestUpgrade.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_ACCEPTED;
            }
            else
            {
                requestUpgrade.Status = RequestStatus.Failed;
                requestUpgrade.TechNote = model.TechNote;
                requestUpgrade.SaleNote = model.SaleNote;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestUpgradeId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Evaluate(int requestUpgradeId, RequestStatus status, Guid userId)
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

            var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition && requestUpgrade.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                requestUpgrade.Status = status;
                _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestUpgradeId = requestUpgrade.Id,
                    UserId = userId
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> EvaluateBulk(RequestUpgradeEvaluateBulkModel model, RequestStatus status, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestUpgradeId in model.RequestUpgradeIds)
            {
                results.Add(await Evaluate(requestUpgradeId, status, userId));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CheckCompletability(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            result.Data = IsCompletable(requestUpgradeId);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IsCompletable(int requestUpgradeId)
    {
        var requestUpgrade = _dbContext.RequestUpgrades.Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment).FirstOrDefault(x => x.Id == requestUpgradeId);
        if (requestUpgrade == null)
        {
            return false;
        }

        return requestUpgrade.RequestUpgradeAppointments.Select(x => x.Appointment).Any(x => x.Status == RequestStatus.Success && !x.InspectionReportFilePath.IsNullOrEmpty() && !x.ReceiptOfRecipientFilePath.IsNullOrEmpty());
    }

    public async Task<ResultModel> Complete(int requestUpgradeId, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.Component).FirstOrDefault(x => x.Id == requestUpgradeId && x.Status == RequestStatus.Accepted);
            ServerHardwareConfig serverHardwareConfig = null;
            if (requestUpgrade == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else if (!requestUpgrade.ServerAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot modify unallocated server";
            }
            else
            {
                serverHardwareConfig = requestUpgrade.ServerAllocation?.ServerHardwareConfigs?.FirstOrDefault(x => x.ComponentId == requestUpgrade.ComponentId);
            }

            if (!IsCompletable(requestUpgradeId))
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_COMPLETABLE;
                validPrecondition = false;
            }


            if (validPrecondition)
            {
                if (serverHardwareConfig == null)
                {
                    _dbContext.ServerHardwareConfigs.Add(new ServerHardwareConfig
                    {
                        Description = requestUpgrade.Description,
                        ServerAllocationId = requestUpgrade.ServerAllocationId,
                        ComponentId = requestUpgrade.ComponentId
                    });
                }
                else
                {
                    serverHardwareConfig.Description = requestUpgrade.Description;
                }
                requestUpgrade.Status = RequestStatus.Success;
                _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                {
                    Action = RequestUserAction.Execute,
                    RequestUpgradeId = requestUpgrade.Id,
                    UserId = userId
                });
                requestUpgrade.ServerAllocation.DateUpdated = DateTime.UtcNow;
                _dbContext.SaveChanges();


                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CompleteBulk(RequestUpgradeCompleteBulkModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestUpgradeId in model.RequestUpgradeIds)
            {
                results.Add(await Complete(requestUpgradeId, userId));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
