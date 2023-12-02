using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IIpAddressService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> SuggestMasterIp();
}

public class IpAddressService : IIpAddressService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public IpAddressService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var IpAddresses = _dbContext.IpAddresses
                .Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Where(x => searchModel.Address != null ? x.Address.Contains(searchModel.Address) : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, IpAddresses.Count());

            IpAddresses = IpAddresses.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            IpAddresses = IpAddresses.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<IpAddressModel>>(IpAddresses.ToList());

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
            var ipAddress = _dbContext.IpAddresses.Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer).FirstOrDefault(x => x.Id == id);

            if (ipAddress != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpAddressModel>(ipAddress);
            }
            else
            {
                result.Succeed = false;
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> SuggestMasterIp()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var suggestedMasterIp = _dbContext.IpAddresses
                .Include(x => x.IpAssignments)
                .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                .Where(x => !x.IsReserved && !x.Blocked && !x.IpAssignments.Any())
                .FirstOrDefault(x => !x.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed));

            if (suggestedMasterIp == null)
            {
                result.ErrorMessage = IpAddressErrorMessage.NO_AVAILABLE;
            }
            else
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpAddressResultModel>(suggestedMasterIp);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
