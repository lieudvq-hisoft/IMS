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
public interface ILocationService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, LocationSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestExpandLocation(int id);
    Task<ResultModel> GetLocationAssignment(int id);
}

public class LocationService : ILocationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public LocationService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, LocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var Locations = _dbContext.Locations
                .Where(x => searchModel.LocationId != null ? x.Id == searchModel.LocationId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, Locations.Count());

            Locations = Locations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            Locations = Locations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<LocationModel>>(Locations.ToList());

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
            var location = _dbContext.Locations.FirstOrDefault(x => x.Id == id);

            if (location != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<LocationModel>(location);
            }
            else
            {
                result.ErrorMessage = LocationErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRequestExpandLocation(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var location = _dbContext.Locations
                .Include(x => x.RequestExpandLocations)
                .FirstOrDefault(x => x.Id == id);

            if (location != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<RequestExpandLocationModel>>(location.RequestExpandLocations);
            }
            else
            {
                result.ErrorMessage = LocationErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetLocationAssignment(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var location = _dbContext.Locations
                .Include(x => x.LocationAssignments)
                .FirstOrDefault(x => x.Id == id);

            if (location != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(location.LocationAssignments);
            }
            else
            {
                result.ErrorMessage = LocationErrorMessgae.NOT_EXISTED;
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