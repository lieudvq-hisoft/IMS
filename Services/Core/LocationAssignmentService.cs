using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;

namespace Services.Core;
public interface ILocationAssignmentService
{
    Task<ResultModel> Get(PagingParam<LocationAssignmentSortingCriteria> paginationModel, LocationAssignmentSearchModel searchModel);
    Task<ResultModel> Create(LocationCreateModel model);
    Task<ResultModel> Update(LocationUpdateModel model);
    Task<ResultModel> Delete(int id);
}

public class LocationAssignmentService : ILocationAssignmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public LocationAssignmentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<LocationAssignmentSortingCriteria> paginationModel, LocationAssignmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var locationServices = _dbContext.Services
               .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                .Where(x => searchModel.ServiceId != null ? x.Id == searchModel.ServiceId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, locationServices.Count());

            locationServices = locationServices.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            locationServices = locationServices.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            var locationAssignments = new List<LocationAssignmentModel>();
            foreach (var locationService in locationServices)
            {
                var startLocation = locationService.LocationAssignments.Select(x => x.Location).MinBy(x => x.Position);
                locationAssignments.Add(new LocationAssignmentModel
                {
                    ServiceId = locationService.Id,
                    StartPosition = startLocation.Position,
                    Rack = startLocation.Rack.DisplayRack(),
                    Size = locationService.LocationAssignments.Count()
                });
            }
            paging.Data = locationAssignments;

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(LocationCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == model.RackId);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var service = _dbContext.Services.FirstOrDefault(x => x.Id == model.ServiceId && (x.Type == ServiceType.Location || x.Type == ServiceType.Expand));
            if (service == null)
            {
                result.ErrorMessage = ServiceErrorMessgae.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (service.LocationAssignments.Any())
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.HAVE_LOCATION_ALREADY;
                validPrecondition = false;
            }

            var locations = new List<Location>();
            for (int i = model.StartPosition; i <= model.Size; i++)
            {
                var location = _dbContext.Locations.FirstOrDefault(x => x.RackId == model.RackId && x.Position == i);
                if (location.LocationAssignments.Any())
                {
                    result.ErrorMessage = LocationAssignmentErrorMessage.CHOICE_NOT_AVAILABLE;
                    validPrecondition = false;
                }
                else
                {
                    locations.Add(location);
                }
            }

            if (validPrecondition)
            {
                foreach (var location in locations)
                {
                    _dbContext.LocationAssignments.Add(new LocationAssignment
                    {
                        ServiceId = model.ServiceId,
                        LocationId = location.Id,
                    });
                }

                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<LocationAssignmentModel>(service);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(LocationUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existingRack = _dbContext.Racks.FirstOrDefault(x => x.Id == model.RackId);
            if (existingRack == null)
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.INVALID_RACK;
                validPrecondition = false;
            }

            var existingService = _dbContext.Services.FirstOrDefault(x => x.Id == model.ServiceId);
            if (existingService == null)
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.INVALID_SERVICE;
                validPrecondition = false;
            }

            var coincideLocation = _dbContext.Locations.FirstOrDefault(x => x.RackId == model.RackId && x.StartPosition == model.StartPosition);
            if (coincideLocation != null)
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.CHOICE_NOT_AVAILABLE;
                validPrecondition = false;
            }

            var locationService = _dbContext.Locations.FirstOrDefault(x => x.Id == model.Id);
            if (locationService == null)
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                locationService.StartPosition = model.StartPosition;
                locationService.Size = model.Size;
                locationService.Power = model.Power;
                locationService.RackId = model.RackId;
                locationService.ServiceId = model.ServiceId;

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<LocationAssignmentModel>(locationService);
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
            var locationService = _dbContext.Locations.FirstOrDefault(x => x.Id == id);
            if (locationService == null)
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                locationService.IsDeleted = true;
                locationService.DateUpdated = DateTime.Now;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = locationService.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}