﻿using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IRackService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RackSearchModel searchModel);
    Task<ResultModel> GetAll();
    Task<ResultModel> GetDetail(int rackId);
    Task<ResultModel> GetServerAllocation(PagingParam<BaseSortCriteria> paginationModel, int rackId);
    Task<ResultModel> GetRackMap(int rackId);
    Task<ResultModel> GetPower(int rackId);
    Task<ResultModel> Create(RackCreateModel model);
    Task<ResultModel> Delete(int rackId);
}

public class RackService : IRackService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RackService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RackSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var racks = _dbContext.Racks
                .Where(x => searchModel.RackId != null ? x.Id == searchModel.RackId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, racks.Count());

            racks = racks.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            racks = racks.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RackModel>>(racks.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAll()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var racks = _dbContext.Racks.AsQueryable();

            result.Data = _mapper.Map<List<RackModel>>(racks.ToList());
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks
                .FirstOrDefault(x => x.Id == rackId);

            if (rack != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RackModel>(rack);
            }
            else
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetServerAllocation(PagingParam<BaseSortCriteria> paginationModel, int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.Include(x => x.Locations).ThenInclude(x => x.LocationAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.Locations).ThenInclude(x => x.LocationAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .FirstOrDefault(x => x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                var serverAllocations = rack.Locations.Where(x => x.LocationAssignments.Any()).Select(x => x.LocationAssignments.FirstOrDefault()).Select(x => x.ServerAllocation).AsQueryable();

                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, serverAllocations.Count());
                serverAllocations = serverAllocations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                serverAllocations = serverAllocations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<ServerAllocationModel>>(serverAllocations.ToList());

                result.Data = paging;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetPower(int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.Include(x => x.Locations).ThenInclude(x => x.LocationAssignments).ThenInclude(x => x.ServerAllocation).FirstOrDefault(x => x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                var serverAllocations = rack.Locations.Where(x => x.LocationAssignments.Any()).Select(x => x.LocationAssignments.FirstOrDefault()).Select(x => x.ServerAllocation);
                result.Data = serverAllocations.Sum(x => x.Power);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRackMap(int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                var locations = _dbContext.Locations
               .Include(x => x.LocationAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
               .Include(x => x.LocationAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
               .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Where(x => x.RackId == rackId);

                var locationRackMap = new List<LocationRackMapModel>();
                foreach (var location in locations)
                {
                    var requestExpand = location.RequestExpandLocations.Select(x => x.RequestExpand).FirstOrDefault(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted);
                    locationRackMap.Add(new LocationRackMapModel
                    {
                        Id = location.Id,
                        Position = location.Position,
                        RackId = location.RackId,
                        IsServer = location.LocationAssignments.FirstOrDefault()?.IsServer,
                        IsReserved = location.IsReserved,
                        ServerAllocation = _mapper.Map<ServerAllocationModel>(location.LocationAssignments.FirstOrDefault()?.ServerAllocation),
                        RequestedServerAllocation = _mapper.Map<ServerAllocationModel>(requestExpand?.ServerAllocation),
                        RequestExpand = _mapper.Map<RequestExpandResultModel>(requestExpand),
                    });
                }

                result.Data = _mapper.Map<List<LocationRackMapModel>>(locationRackMap);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RackCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var area = _dbContext.Areas.Include(x => x.Racks).FirstOrDefault(x => x.Id == model.AreaId);
            if (area == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AreaErrorMessage.NOT_EXISTED;
            }
            else
            {
                var existingRack = area.Racks.FirstOrDefault(x => x.Column == model.Column && x.Row == model.Row);
                if (existingRack != null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RackErrorMessage.EXISTED;
                }

                if (model.Column > area.ColumnCount || model.Row > area.ColumnCount)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RackErrorMessage.POSITION_INVALID;
                }
            }


            if (validPrecondition)
            {
                var rack = _mapper.Map<Rack>(model);
                _dbContext.Racks.Add(rack);
                _dbContext.SaveChanges();

                for (int i = 0; i < rack.Size; i++)
                {
                    _dbContext.Locations.Add(new Location
                    {
                        RackId = rack.Id,
                        Position = i
                    });
                }
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RackModel>(rack);
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
            var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == id);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.Racks.Remove(rack);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = rack.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}