using AutoMapper;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;

namespace Services.Core;
public interface ILocationService
{
    Task<ResultModel> GetLocationService();
    Task<ResultModel> CreateLocationService(LocationServiceCreateModel model);
    Task<ResultModel> UpdateLocationService(LocationServiceUpdateModel model);
    Task<ResultModel> DeleteLocationService(int id);
}

public class LocationServiceService : ILocationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public LocationServiceService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> GetLocationService()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var locationService = _dbContext.LocationServices.ToList();

            result.Data = _mapper.Map<List<LocationServiceModel>>(locationService); 
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateLocationService(LocationServiceCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existingRack = _dbContext.Racks.FirstOrDefault(x => x.Id == model.RackId);
            if (existingRack == null)
            {
                result.ErrorMessage = LocationServiceErrorMessage.INVALID_RACK;
                validPrecondition = false;
            }

            var existingService = _dbContext.Services.FirstOrDefault(x => x.Id == model.ServiceId);
            if (existingRack == null)
            {
                result.ErrorMessage = LocationServiceErrorMessage.INVALID_SERVICE;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var locationService = new LocationService
                {
                    StartPosition = model.StartPosition,
                    Size = model.Size,
                    Power = model.Power,
                    RackId = model.RackId,
                    ServiceId = model.ServiceId,
                };

                _dbContext.LocationServices.Add(locationService);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<LocationServiceModel>(locationService);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> UpdateLocationService(LocationServiceUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existingRack = _dbContext.Racks.FirstOrDefault(x => x.Id == model.RackId);
            if (existingRack == null)
            {
                result.ErrorMessage = LocationServiceErrorMessage.INVALID_RACK;
                validPrecondition = false;
            }

            var existingService = _dbContext.Services.FirstOrDefault(x => x.Id == model.ServiceId);
            if (existingRack == null)
            {
                result.ErrorMessage = LocationServiceErrorMessage.INVALID_SERVICE;
                validPrecondition = false;
            }

            var locationService = _dbContext.LocationServices.FirstOrDefault(x => x.Id == model.Id);

            if (locationService == null)
            {
                result.ErrorMessage = LocationServiceErrorMessage.NOT_EXISTED;
            }
            else
            {
                if (!model.StartPosition.ToString().IsNullOrEmpty())
                {
                    locationService.StartPosition = model.StartPosition;
                }

                if (!model.Size.ToString().IsNullOrEmpty())
                {
                    locationService.Size = model.Size;
                }

                if (!model.Power.ToString().IsNullOrEmpty())
                {
                    locationService.Power = model.Power;
                }

                locationService.RackId = model.RackId;
                locationService.ServiceId = model.ServiceId;

                if (validPrecondition)
                {
                    locationService.DateUpdated = DateTime.Now;
                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<LocationServiceModel>(locationService);
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> DeleteLocationService(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var locationService = _dbContext.LocationServices.FirstOrDefault(x => x.Id == id);
            if (locationService == null)
            {
                result.ErrorMessage = LocationServiceErrorMessage.NOT_EXISTED;
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
    
