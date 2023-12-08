﻿using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;

namespace Services.Core;
public interface ILocationService
{
    Task<ResultModel> Get(PagingParam<SimpleSortCriteria> paginationModel, LocationSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestExpandLocation(int id);
    Task<ResultModel> GetLocationAssignment(int id);
    Task<ResultModel> ReservceLocation(LocationReserveModel model);
    Task<ResultModel> UnreservceLocation(LocationReserveModel model);
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

    public async Task<ResultModel> Get(PagingParam<SimpleSortCriteria> paginationModel, LocationSearchModel searchModel)
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

    public async Task<ResultModel> ReservceLocation(LocationReserveModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var locations = _dbContext.Locations
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand)
                .Include(x => x.LocationAssignments)
                .Where(delegate (Location x)
                {
                    return x.IsAvailable() && model.LocationIds.Contains(x.Id);
                });

            if (locations.Count() != model.LocationIds.Count())
            {
                result.ErrorMessage = "Location not available";
            }
            else
            {
                foreach (var location in locations)
                {
                    location.IsReserved = true;
                }
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<LocationResultModel>(locations);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> UnreservceLocation(LocationReserveModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var locations = _dbContext.Locations
                .Where(delegate (Location x)
                {
                    return x.IsReserved && model.LocationIds.Contains(x.Id);
                });

            if (locations.Count() != model.LocationIds.Count())
            {
                result.ErrorMessage = "Location not reserved";
            }
            else
            {
                foreach (var location in locations)
                {
                    location.IsReserved = false;
                }
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<LocationResultModel>(locations);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}