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
    Task<ResultModel> GetRackChoiceSuggestionBySize(int areaId, int size);
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
            var areas = _dbContext.Areas.ToList();
            var mappedAreas = new List<AreaModel>();
            foreach (var area in areas)
            {
                var racks = _dbContext.Racks.Where(x => x.AreaId == area.Id).ToList();
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
            var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == rackId);
            var rackLocations = _dbContext.Locations
                .Include(x => x.Device).ThenInclude(x => x.Server)
                .Where(x => x.RackId == rackId);
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

    public async Task<ResultModel> GetRackChoiceSuggestionBySize(int areaId, int size)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var racks = _dbContext.Racks.Where(x => x.AreaId == areaId).ToList();
            var suggestedRack = new List<Rack>();

            foreach (var rack in racks)
            {
                var spaces = new List<List<int>>();
                var availableLocation = GetAvailableLocationChoiceByRack(rack);
                int count = 0;
                var isEmpty = false;
                for (int i = 1; i <= rack.Size; i++)
                {
                    var location = availableLocation.FirstOrDefault(x => x.Position == i);
                    if (location != null)
                    {
                        if (spaces.Count < count + 1)
                        {
                            spaces.Add(new List<int>());
                        }
                        spaces[count].Add(location.Position);
                        isEmpty = false;
                    }
                    else
                    {
                        if (!isEmpty)
                        {
                            count++;
                            isEmpty = true;
                        }
                    }
                }

                if (spaces.Max(x => x.Count) >= size)
                {
                    suggestedRack.Add(rack);
                }
            }

            result.Data = _mapper.Map<List<RackModel>>(suggestedRack);
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
            var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = "Rack " + ErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = GetAvailableLocationChoiceByRack(rack);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private List<LocationChoiceModel> GetAvailableLocationChoiceByRack(Rack rack)
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

        var unavailableLocations = _dbContext.Locations.Include(x => x.Device).Where(x => !x.IsMoveout && x.RackId == rack.Id).ToList();
        foreach (Location location in unavailableLocations)
        {
            var startPosition = location.StartPosition;
            var endPosition = startPosition + location.Device.Size - 1;
            for (int i = startPosition; i <= endPosition; i++)
            {
                locationChoices.RemoveAll(x => x.Position == i);
            }
        }

        return locationChoices;
    }
}
