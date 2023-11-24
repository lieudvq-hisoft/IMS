using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core.NotUsed;
public interface IRequestUpgradeUserService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestUpgradeUserSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
}

public class RequestUpgradeUserService : IRequestUpgradeUserService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestUpgradeUserService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestUpgradeUserSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgradeUsers = _dbContext.RequestUpgradeUsers
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgradeUsers.Count());

            requestUpgradeUsers = requestUpgradeUsers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestUpgradeUsers = requestUpgradeUsers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestUpgradeUserModel>>(requestUpgradeUsers.ToList());

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
            var requestUpgradeUser = _dbContext.RequestUpgradeUsers
                .FirstOrDefault(x => x.Id == id);

            if (requestUpgradeUser != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeUserModel>(requestUpgradeUser);
            }
            else
            {
                result.ErrorMessage = RequestUpgradeUserErrorMessage.NOT_EXISTED;
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