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
public interface IServerHardwareConfigService
{
    Task<ResultModel> Get(PagingParam<ServerHardwareConfigSortCriteria> paginationModel, ServerHardwareConfigSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(ServerHardwareConfigCreateModel model);
    Task<ResultModel> Update(ServerHardwareConfigUpdateModel model);
    Task<ResultModel> Delete(int serverHardwareConfigId);
}

public class ServerHardwareConfigService : IServerHardwareConfigService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public ServerHardwareConfigService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<ServerHardwareConfigSortCriteria> paginationModel, ServerHardwareConfigSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverHardwareConfigs = _dbContext.ServerHardwareConfigs
                .Where(delegate (ServerHardwareConfig x)
                {
                    return FilterServerHardwareConfig(x, searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, serverHardwareConfigs.Count());

            serverHardwareConfigs = serverHardwareConfigs.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            serverHardwareConfigs = serverHardwareConfigs.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<ServerHardwareConfigModel>(serverHardwareConfigs).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private bool FilterServerHardwareConfig(ServerHardwareConfig x, ServerHardwareConfigSearchModel model)
    {
        bool matchId = model.Id != null ? x.Id == model.Id : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
        bool matchComponentId = model.ComponentId != null ? x.ComponentId == model.ComponentId : true;

        return matchId && matchServerAllocationId && matchComponentId;
    }

    public async Task<ResultModel> GetDetail(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverHardwareConfig = _dbContext.ServerHardwareConfigs.FirstOrDefault(x => x.Id == id);

            if (serverHardwareConfig != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<ServerHardwareConfigModel>(serverHardwareConfig);
            }
            else
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(ServerHardwareConfigCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var component = _dbContext.Components.FirstOrDefault(x => x.Id == model.ComponentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (serverAllocation.ServerHardwareConfigs.Any(x => x.Component.Name == component.Name))
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.CONFIG_FOR_COMPONENT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var serverHardwareConfig = _mapper.Map<ServerHardwareConfig>(model);

                _dbContext.ServerHardwareConfigs.Add(serverHardwareConfig);
                _dbContext.SaveChanges();

                if (component.Type == ComponentType.Change)
                {
                    _dbContext.RequestUpgrades.Add(new RequestUpgrade
                    {
                        Information = model.Information,
                        Capacity = model.Capacity,
                        ServerAllocationId = model.ServerAllocationId,
                        ComponentId = model.ComponentId,
                        Status = RequestStatus.Accepted
                    });
                    _dbContext.SaveChanges();
                }

                result.Succeed = true;
                result.Data = _mapper.Map<ServerHardwareConfigModel>(serverHardwareConfig);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(ServerHardwareConfigUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var component = _dbContext.Components.FirstOrDefault(x => x.Id == model.ComponentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverHardwareConfig = _dbContext.ServerHardwareConfigs.FirstOrDefault(x => x.Id == model.Id);
            if (serverHardwareConfig == null)
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (serverAllocation.ServerHardwareConfigs.Any(x => x.Component.Name == component.Name && x.Id != serverHardwareConfig.Id))
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.CONFIG_FOR_COMPONENT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                _mapper.Map<ServerHardwareConfigUpdateModel, ServerHardwareConfig>(model, serverHardwareConfig);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<ServerHardwareConfigModel>(serverHardwareConfig);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int serverHardwareConfigId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverHardwareConfig = _dbContext.ServerHardwareConfigs.FirstOrDefault(x => x.Id == serverHardwareConfigId);
            if (serverHardwareConfig == null)
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
            }
            else
            {
                serverHardwareConfig.IsDeleted = true;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = serverHardwareConfigId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
