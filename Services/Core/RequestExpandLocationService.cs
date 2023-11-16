using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess.Constant;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Services.Utilities;
using Data.Utils.Paging;

public interface IRequestExpandLocationService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandLocationSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(RequestExpandLocationCreateModel model);
    Task<ResultModel> Delete(int id);
}

public class RequestExpandLocationService : IRequestExpandLocationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestExpandLocationService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandLocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpandLocationn = _dbContext.RequestExpandLocations
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpandLocationn.Count());

            requestExpandLocationn = requestExpandLocationn.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestExpandLocationn = requestExpandLocationn.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestExpandLocationModel>(requestExpandLocationn).ToList();

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
            var requestExpandLocationns = _dbContext.RequestExpandLocations.FirstOrDefault(x => x.Id == id);

            if (requestExpandLocationns != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandLocationModel>(requestExpandLocationns);
            }
            else
            {
                result.ErrorMessage = RequestExpandLocationErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestExpandLocationCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedRequestExpandLocation = _dbContext.RequestExpandLocations
                .FirstOrDefault(x => x.RequestExpandId == model.RequestExpandId
                && x.LocationId == model.LocationId);
            if (existedRequestExpandLocation != null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandLocationErrorMessage.EXISTED;
            }

            var serverAllocationId = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == model.RequestExpandId);
            if (serverAllocationId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }

            var locationId = _dbContext.Locations.FirstOrDefault(x => x.Id == model.LocationId);
            if (locationId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandLocationErrorMessage.INVALID_LOCATION;
            }

            if (validPrecondition)
            {
                var requestExpandLocationn = _mapper.Map<RequestExpandLocation>(model);
                _dbContext.RequestExpandLocations.Add(requestExpandLocationn);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandLocationModel>(requestExpandLocationn);
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
            var requestExpandLocationn = _dbContext.RequestExpandLocations.FirstOrDefault(x => x.Id == id);
            if (requestExpandLocationn == null)
            {
                result.ErrorMessage = RequestExpandLocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.RequestExpandLocations.Remove(requestExpandLocationn);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestExpandLocationn.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}