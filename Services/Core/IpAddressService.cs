using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core;
public interface IIpAddressService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
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
            var IpAddresss = _dbContext.IpAddresses
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, IpAddresss.Count());

            IpAddresss = IpAddresss.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            IpAddresss = IpAddresss.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<IpAddressModel>(IpAddresss).ToList();

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
            var ipAddress = _dbContext.IpAddresses.FirstOrDefault(x => x.Id == id);

            if (ipAddress != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpAddressModel>(ipAddress);
            }
            else
            {
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }
}
