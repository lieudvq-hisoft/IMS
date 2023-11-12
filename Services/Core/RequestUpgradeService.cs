using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess.Constant;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Utils.Paging;

namespace Services.Core;
public interface IRequestUpgradeService
{

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
        bool matchCustomerId = model.CustomerId != null ? x.CustomerId == model.CustomerId : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;

        return matchId && matchCustomerId && matchServerAllocationId;
    }

    public async Task<ResultModel> Create(RequestUpgradeCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == model.CustomerId);
            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverHardwareConfig = _dbContext.ServerHardwareConfigs.FirstOrDefault(x => x.Id == model.ServerHardwareConfigId);
            if (serverHardwareConfig == null)
            {
                result.ErrorMessage = ServerHardwareConfigErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverHardwareConfig == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var requestUpgrade = _mapper.Map<RequestUpgrade>(model);

                _dbContext.RequestUpgrades.Add(requestUpgrade);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<ServerHardwareConfigModel>(requestUpgrade);
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
