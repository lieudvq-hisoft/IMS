using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core;
public interface IRequestExpandService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(RequestExpandCreateModel model);
    Task<ResultModel> Delete(int id);
}

public class RequestExpandService : IRequestExpandService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestExpandService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpands = _dbContext.RequestExpands
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpands.Count());

            requestExpands = requestExpands.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestExpands = requestExpands.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestExpandModel>(requestExpands).ToList();

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
            var requestExpand = _dbContext.RequestExpands
                .FirstOrDefault(x => x.Id == id);

            if (requestExpand != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
            else
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestExpandCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestExpand = _mapper.Map<RequestExpand>(model);
                _dbContext.RequestExpands.Add(requestExpand);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == id);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.RequestExpands.Remove(requestExpand);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestExpand.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}