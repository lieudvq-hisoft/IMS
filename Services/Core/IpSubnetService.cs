using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core;
public interface IIpSubnetService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
}

public class IpSubnetService : IIpSubnetService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public IpSubnetService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpSubnetSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var IpSubnets = _dbContext.IpSubnets
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, IpSubnets.Count());

            IpSubnets = IpSubnets.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            IpSubnets = IpSubnets.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<IpSubnetModel>(IpSubnets).ToList();

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
            var ipSubnet = _dbContext.IpSubnets.FirstOrDefault(x => x.Id == id);

            if (ipSubnet != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpSubnetModel>(ipSubnet);
            }
            else
            {
                result.ErrorMessage = IpSubnetErrorMessage.NOT_EXISTED;
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
