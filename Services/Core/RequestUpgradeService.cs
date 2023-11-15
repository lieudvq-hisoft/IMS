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
public interface IRequestUpgradeService
{
    Task<ResultModel> Get(PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel);
    Task<ResultModel> Create(RequestUpgradeCreateModel model);
    Task<ResultModel> Delete(int requestUpgradeId);
    Task<ResultModel> Update(RequestUpgradeUpdateModel model);
    Task<ResultModel> ChangeStatus(int requestUpgradeId, RequestStatus status);
    Task<ResultModel> Complete(int requestUpgradeId);
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
                .Where(delegate (RequestUpgrade x)
                {
                    return FilterServerHardwareConfig(x, searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgrades.Count());

            requestUpgrades = requestUpgrades.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestUpgrades = requestUpgrades.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestUpgradeModel>(requestUpgrades).ToList();

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

    public async Task<ResultModel> Create(RequestUpgradeCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var component = _dbContext.Components.FirstOrDefault(x => x.Id == model.ComponentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (component == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
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

            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (component == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                _mapper.Map<RequestUpgradeUpdateModel, RequestUpgrade>(model, requestUpgrade);

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

    public async Task<ResultModel> ChangeStatus(int requestUpgradeId, RequestStatus status)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.Component).FirstOrDefault(x => x.Id == requestUpgradeId && x.Status == RequestStatus.Waiting);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else
            {
                requestUpgrade.Status = status;

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

    public async Task<ResultModel> Complete(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.Component).FirstOrDefault(x => x.Id == requestUpgradeId && x.Status == RequestStatus.Waiting);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            ServerHardwareConfig serverHardwareConfig = null;
            if (validPrecondition)
            {
                serverHardwareConfig = requestUpgrade.ServerAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.ComponentId == requestUpgrade.ComponentId);
                if (serverHardwareConfig == null)
                {
                    result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
                    validPrecondition = true;
                }
            }

            if (validPrecondition)
            {
                if (requestUpgrade.Component.Type == ComponentType.Change)
                {
                    serverHardwareConfig.Description = requestUpgrade.Description;
                    serverHardwareConfig.Capacity = requestUpgrade.Capacity;
                }
                else
                {
                    serverHardwareConfig.Capacity += requestUpgrade.Capacity;
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
}
