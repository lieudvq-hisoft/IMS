using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;

namespace Services.Core.NotUsed;
public interface IRequestExpandUserService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandUserSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
}

public class RequestExpandUserService : IRequestExpandUserService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestExpandUserService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandUserSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpandUsers = _dbContext.RequestExpandUsers
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpandUsers.Count());

            requestExpandUsers = requestExpandUsers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestExpandUsers = requestExpandUsers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestExpandUserModel>>(requestExpandUsers.ToList());

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
            var requestExpandUser = _dbContext.RequestExpandUsers
                .FirstOrDefault(x => x.Id == id);

            if (requestExpandUser != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandUserModel>(requestExpandUser);
            }
            else
            {
                result.ErrorMessage = RequestExpandUserErrorMessage.NOT_EXISTED;
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
