using AutoMapper;
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
    Task<ResultModel> GetDetail(int rackId);
    Task<ResultModel> GetLocation(int rackId);
    Task<ResultModel> GetServerAllocation(int rackId);
    Task<ResultModel> GetRackMap(int rackId);
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

            paging.Data = _mapper.ProjectTo<RackModel>(racks).ToList();

            result.Data = paging;
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

    public async Task<ResultModel> GetLocation(int rackId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.Include(x => x.Locations).FirstOrDefault(x => x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<List<LocationModel>>(rack.Locations);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetServerAllocation(int rackId)
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
                result.Data = _mapper.Map<List<ServerAllocation>>(serverAllocations);
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
            var rack = _dbContext.Racks.Include(x => x.Locations).ThenInclude(x => x.LocationAssignments).ThenInclude(x => x.ServerAllocation).FirstOrDefault(x => x.Id == rackId);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                var locationRackMap = new List<LocationRackMapModel>();
                foreach (var location in rack.Locations)
                {
                    locationRackMap.Add(new LocationRackMapModel
                    {
                        Id = location.Id,
                        Position = location.Position,
                        RackId = location.RackId,
                        ServerAllocationId = location.LocationAssignments.FirstOrDefault().ServerAllocationId
                    });
                }

                result.Data = _mapper.Map<List<ServerAllocation>>(locationRackMap);
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