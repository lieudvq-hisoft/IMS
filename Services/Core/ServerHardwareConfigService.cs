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
public interface IServerHardwareConfigService
{
    Task<ResultModel> Get(PagingParam<ServerHardwareConfigSortCriteria> paginationModel, ServerHardwareConfigSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(ServerHardwareConfigCreateModel model);
    //Task<ResultModel> CreateBulk(ServerHardwareConfigCreateBulkModel model);
    //Task<ResultModel> Update(ServerHardwareConfigUpdateModel model);
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
                .Include(x => x.Component)
                .Include(x => x.ServerAllocation)
                .Where(delegate (ServerHardwareConfig x)
                {
                    return FilterServerHardwareConfig(x, searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, serverHardwareConfigs.Count());

            serverHardwareConfigs = serverHardwareConfigs.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            serverHardwareConfigs = serverHardwareConfigs.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<ServerHardwareConfigModel>>(serverHardwareConfigs.ToList());

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
            var serverHardwareConfig = _dbContext.ServerHardwareConfigs.Include(x => x.Component).FirstOrDefault(x => x.Id == id);

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
                .Include(x => x.LocationAssignments).ThenInclude(x => x.Location)
                .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
                .Include(x => x.RequestUpgrades)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot change config of allocated server";
            }

            var cpu = _dbContext.Components.FirstOrDefault(x => x.Name == "CPU");
            var ram = _dbContext.Components.FirstOrDefault(x => x.Name == "RAM");
            var harddisk = _dbContext.Components.FirstOrDefault(x => x.Name == "Harddisk");

            if (validPrecondition)
            {
                _dbContext.ServerHardwareConfigs.RemoveRange(serverAllocation.ServerHardwareConfigs);
                _dbContext.RequestUpgrades.RemoveRange(serverAllocation.RequestUpgrades);
                _dbContext.SaveChanges();
                _dbContext.ServerHardwareConfigs.Add(new ServerHardwareConfig
                {
                    Description = model.Cpu,
                    ServerAllocationId = model.ServerAllocationId,
                    ComponentId = cpu.Id,
                });
                _dbContext.RequestUpgrades.Add(new RequestUpgrade
                {
                    Description = model.Cpu,
                    ServerAllocationId = model.ServerAllocationId,
                    ComponentId = cpu.Id,
                    Status = RequestStatus.Success
                });
                _dbContext.ServerHardwareConfigs.Add(new ServerHardwareConfig
                {
                    Description = model.Ram,
                    ServerAllocationId = model.ServerAllocationId,
                    ComponentId = ram.Id,
                });
                _dbContext.RequestUpgrades.Add(new RequestUpgrade
                {
                    Description = model.Ram,
                    ServerAllocationId = model.ServerAllocationId,
                    ComponentId = ram.Id,
                    Status = RequestStatus.Success
                });
                _dbContext.ServerHardwareConfigs.Add(new ServerHardwareConfig
                {
                    Description = model.Harddisk,
                    ServerAllocationId = model.ServerAllocationId,
                    ComponentId = harddisk.Id,
                });
                _dbContext.RequestUpgrades.Add(new RequestUpgrade
                {
                    Description = model.Harddisk,
                    ServerAllocationId = model.ServerAllocationId,
                    ComponentId = harddisk.Id,
                    Status = RequestStatus.Success
                });
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

    //private bool CheckValidSerialNumber(List<string> serialNumbers, int serverAllocationId = 0)
    //{
    //    var existedSerialNumber = _dbContext.ServerHardwareConfigs.Include(x => x.ServerAllocation)
    //        .Where(x => x.ServerAllocation.Status != ServerAllocationStatus.Removed)
    //        .Where(x => serverAllocationId != 0 ? x.ServerAllocationId != serverAllocationId : true)
    //        .ToList().SelectMany(x => JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(x.Description).Select(x => x.SerialNumber));
    //    return !serialNumbers.Any(x => existedSerialNumber.Contains(x)) && serialNumbers.Distinct().Count() == serialNumbers.Count();
    //}

    //public async Task<ResultModel> CreateBulk(ServerHardwareConfigCreateBulkModel model)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        using var transaction = _dbContext.Database.BeginTransaction();
    //        var results = new List<ResultModel>();
    //        foreach (var serverHardwareConfigModel in model.ServerHardwareConfigCreateModels)
    //        {
    //            results.Add(await Create(serverHardwareConfigModel));
    //        }

    //        if (results.Any(x => !x.Succeed))
    //        {
    //            result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
    //            transaction.Rollback();
    //        }
    //        else
    //        {
    //            transaction.Commit();
    //            result.Succeed = true;
    //            result.Data = results.Select(x => x.Data);
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    //public async Task<ResultModel> Update(ServerHardwareConfigUpdateModel model)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;
    //    bool validPrecondition = true;

    //    try
    //    {
    //        var serverAllocation = _dbContext.ServerAllocations
    //            .Include(x => x.LocationAssignments)
    //            .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
    //            .FirstOrDefault(x => x.Id == model.ServerAllocationId);
    //        if (serverAllocation == null)
    //        {
    //            validPrecondition = false;
    //            result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
    //        }
    //        else if (serverAllocation.LocationAssignments.Any())
    //        {
    //            validPrecondition = false;
    //            result.ErrorMessage = "Cannot change config of allocated server";
    //        }

    //        var component = _dbContext.Components.FirstOrDefault(x => x.Id == model.ComponentId);
    //        if (component == null)
    //        {
    //            validPrecondition = false;
    //            result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
    //        }

    //        var serverHardwareConfig = _dbContext.ServerHardwareConfigs.FirstOrDefault(x => x.Id == model.Id);
    //        if (serverHardwareConfig == null)
    //        {
    //            validPrecondition = false;
    //            result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
    //        }

    //        if (validPrecondition)
    //        {
    //            _mapper.Map<ServerHardwareConfigUpdateModel, ServerHardwareConfig>(model, serverHardwareConfig);
    //            _dbContext.SaveChanges();
    //            result.Succeed = true;
    //            result.Data = _mapper.Map<ServerHardwareConfigModel>(serverHardwareConfig);
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> Delete(int serverHardwareConfigId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverHardwareConfig = _dbContext.ServerHardwareConfigs
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .FirstOrDefault(x => x.Id == serverHardwareConfigId);
            if (serverHardwareConfig == null)
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
            }
            else if (serverHardwareConfig.ServerAllocation.LocationAssignments.Any())
            {
                result.ErrorMessage = "Cannot change config of allocated server";
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
