using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;

namespace Services.Core;
public interface IRequestUpgradeService
{
    Task<ResultModel> Get(PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetAppointment(int requestUpgradeId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> Create(RequestUpgradeCreateModel model);
    Task<ResultModel> CreateBulk(RequestUpgradeCreateBulkModel model);
    Task<ResultModel> Initiate(RequestUpgradeCreateModel model);
    Task<ResultModel> InitiateBulk(RequestUpgradeCreateBulkModel model);
    Task<ResultModel> Delete(int requestUpgradeId);
    Task<ResultModel> Update(RequestUpgradeUpdateModel model);
    Task<ResultModel> Evaluate(int requestUpgradeId, RequestStatus status, UserAssignModel model);
    Task<ResultModel> EvaluateBulk(RequestUpgradeEvaluateBulkModel model, RequestStatus status);
    Task<ResultModel> Reject(int requestUpgradeId);
    Task<ResultModel> CheckCompletability(int requestUpgradeId);
    Task<ResultModel> Complete(int requestUpgradeId);
    Task<ResultModel> CompleteBulk(RequestUpgradeCompleteBulkModel model);

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
            var requestUpgrades = _dbContext.RequestUpgrades.Include(x => x.Component)
                .Where(delegate (RequestUpgrade x)
                {
                    return FilterServerHardwareConfig(x, searchModel);
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

    private bool FilterServerHardwareConfig(RequestUpgrade x, RequestUpgradeSearchModel model)
    {
        bool matchId = model.Id != null ? x.Id == model.Id : true;
        bool matchComponentId = model.ComponentId != null ? x.ComponentId == model.ComponentId : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;

        return matchId && matchComponentId && matchServerAllocationId;
    }

    public async Task<ResultModel> GetDetail(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<RequestUpgradeDetailModel>(requestUpgrade);
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

            var serverAllocation = _dbContext.ServerAllocations.Include(x => x.ServerHardwareConfigs).FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var serverHardwareConfig = serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.ComponentId == component.Id);
                validPrecondition = CheckValidCapacity(result, component, serverHardwareConfig, model.Capacity);
            }

            if (validPrecondition)
            {
                var requestUpgrade = _mapper.Map<RequestUpgrade>(model);
                requestUpgrade.Status = RequestStatus.Waiting;

                _dbContext.RequestUpgrades.Add(requestUpgrade);
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

    private bool CheckValidCapacity(ResultModel result, Data.Entities.Component component, ServerHardwareConfig serverHardwareConfig, int capacity)
    {
        bool validCapacity = true;
        if (component.Type == ComponentType.Change && capacity <= 0)
        {
            result.ErrorMessage = RequestUpgradeErrorMessage.CANNOT_DOWNGRADE;
            validCapacity = false;
        }

        if (serverHardwareConfig != null && (serverHardwareConfig.Capacity + capacity <= 0))
        {
            result.ErrorMessage = RequestUpgradeErrorMessage.CANNOT_DOWNGRADE;
            validCapacity = false;
        }
        else if (serverHardwareConfig == null && capacity <= 0)
        {
            result.ErrorMessage = RequestUpgradeErrorMessage.INITIATE_NON_POSITIVE_CAPACITY;
            validCapacity = false;
        }

        return validCapacity;
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

    public async Task<ResultModel> Initiate(RequestUpgradeCreateModel model)
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

            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var serverHardwareConfig = serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.ComponentId == component.Id);
                validPrecondition = CheckValidCapacity(result, component, serverHardwareConfig, model.Capacity);
            }

            if (validPrecondition)
            {
                var requestUpgrade = _mapper.Map<RequestUpgrade>(model);
                requestUpgrade.Status = RequestStatus.Accepted;

                _dbContext.RequestUpgrades.Add(requestUpgrade);
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

    public async Task<ResultModel> InitiateBulk(RequestUpgradeCreateBulkModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestUpgradeRequestModel in model.RequestUpgradeCreateModels)
            {
                results.Add(await Initiate(requestUpgradeRequestModel));
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
            var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == model.Id);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var component = _dbContext.Components.FirstOrDefault(x => x.Id == model.ComponentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = _dbContext.ServerAllocations.Include(x => x.ServerHardwareConfigs).FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (component == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var serverHardwareConfig = serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.ComponentId == component.Id);
                validPrecondition = CheckValidCapacity(result, component, serverHardwareConfig, model.Capacity);
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
            else
            {
                _dbContext.RequestUpgrades.Remove(requestUpgrade);
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

    public async Task<ResultModel> Evaluate(int requestUpgradeId, RequestStatus status, UserAssignModel model)
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

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
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
                    RequestUpgradeId = requestUpgrade.Id,
                    UserId = new Guid(model.UserId)
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

    public async Task<ResultModel> EvaluateBulk(RequestUpgradeEvaluateBulkModel model, RequestStatus status)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            var userAssignModel = new UserAssignModel
            {
                UserId = model.UserId
            };
            foreach (var requestUpgradeId in model.RequestUpgradeIds)
            {

                results.Add(await Evaluate(requestUpgradeId, status, userAssignModel));
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

    public async Task<ResultModel> Reject(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition && requestUpgrade.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_ACCEPTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                requestUpgrade.Status = RequestStatus.Failed;
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

    public async Task<ResultModel> Complete(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.Component).FirstOrDefault(x => x.Id == requestUpgradeId && x.Status == RequestStatus.Accepted);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (!IsCompletable(requestUpgradeId))
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_COMPLETABLE;
                validPrecondition = false;
            }

            ServerHardwareConfig serverHardwareConfig = requestUpgrade.ServerAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.ComponentId == requestUpgrade.ComponentId); ;
            if (validPrecondition)
            {
                validPrecondition = CheckValidCapacity(result, requestUpgrade.Component, serverHardwareConfig, requestUpgrade.Capacity);
            }


            if (validPrecondition)
            {
                if (serverHardwareConfig == null)
                {
                    _dbContext.ServerHardwareConfigs.Add(new ServerHardwareConfig
                    {
                        Information = requestUpgrade.Information,
                        Capacity = requestUpgrade.Capacity,
                        ServerAllocationId = requestUpgrade.ServerAllocationId,
                        ComponentId = requestUpgrade.ComponentId,
                    });
                }
                else
                {
                    if (requestUpgrade.Component.Type == ComponentType.Change)
                    {
                        serverHardwareConfig.Information = requestUpgrade.Information;
                        serverHardwareConfig.Capacity = requestUpgrade.Capacity;
                    }
                    else
                    {
                        serverHardwareConfig.Capacity += requestUpgrade.Capacity;
                    }
                }
                requestUpgrade.Status = RequestStatus.Success;

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

    public async Task<ResultModel> CompleteBulk(RequestUpgradeCompleteBulkModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestUpgradeId in model.RequestUpgradeIds)
            {

                results.Add(await Complete(requestUpgradeId));
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
