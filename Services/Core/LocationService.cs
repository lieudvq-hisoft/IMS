using AutoMapper;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Model;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface ILocationService
{
    Task<ResultModel> GetAreas();
    Task<ResultModel> GetRackDetail(int id);
    Task<ResultModel> GetRackAvailableLocationChoice(int rackId);
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

    public async Task<ResultModel> GetAreas()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var areas = _dbContext.Areas.Where(x => !x.IsDeleted).ToList();
            var mappedAreas = new List<AreaModel>();
            foreach (var area in areas)
            {
                var racks = _dbContext.Racks.Where(x => !x.IsDeleted && x.AreaId == area.Id).ToList();
                var mappedArea = _mapper.Map<AreaModel>(area);
                mappedArea.Racks = _mapper.Map<List<RackModel>>(racks);
                mappedAreas.Add(mappedArea);
            }

            result.Data = mappedAreas;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetRackDetail(int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.FirstOrDefault(x => !x.IsDeleted && x.Id == rackId);
            var rackLocations = _dbContext.Locations
                .Include(x => x.Device).ThenInclude(x => x.Server)
                .Where(x => !x.IsDeleted && x.RackId == rackId);
            var mappedRack = _mapper.Map<RackDetailModel>(rack);
            mappedRack.DeviceLocations = _mapper.Map<List<LocationModel>>(rackLocations);

            result.Data = mappedRack;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetRackAvailableLocationChoice(int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.FirstOrDefault(x => !x.IsDeleted && x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = "Rack " + ErrorMessage.NOT_EXISTED;
            }
            else
            {
                var locationChoices = new List<LocationChoiceModel>();
                for (int i = 1; i <= rack.Size; i++)
                {
                    locationChoices.Add(new LocationChoiceModel
                    {
                        RackId = rack.Id,
                        AreaId = rack.AreaId,
                        Position = i
                    });
                }

                var unavailableLocations = _dbContext.Locations.Include(x => x.Device).Where(x => !x.IsDeleted && !x.IsMoveout && x.RackId == rackId).ToList();
                foreach (Location location in unavailableLocations)
                {
                    var startPosition = location.StartPosition;
                    var endPosition = startPosition + location.Device.Size - 1;
                    for (int i = startPosition; i <= endPosition; i++)
                    {
                        locationChoices.RemoveAll(x => x.Position == i);
                    }
                }

                result.Data = locationChoices;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
