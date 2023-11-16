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
public interface ILocationAssignmentService
{
    Task<ResultModel> Get(PagingParam<LocationAssignmentSortingCriteria> paginationModel, LocationAssignmentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(LocationAssignmentCreateModel model);
    ////Task<ResultModel> Update(LocationUpdateModel model);
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
            var locationAssignment = _dbContext.LocationAssignments
                .Where(x => searchModel.ServerAllocationId != null ? x.Id == searchModel.ServerAllocationId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, locationAssignment.Count());

            locationAssignment = locationAssignment.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            locationAssignment = locationAssignment.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<LocationAssignmentModel>(locationAssignment).ToList();

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
            var locationAssignments = _dbContext.LocationAssignments.FirstOrDefault(x => x.Id == id);

            if (locationAssignments != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<LocationAssignmentModel>(locationAssignments);
            }
            else
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(LocationAssignmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedLocationAssignment = _dbContext.LocationAssignments
                .FirstOrDefault(x => x.ServerAllocationId == model.ServerAllocationId 
                && x.LocationId == model.LocationId);
            if (existedLocationAssignment != null)
            {
                validPrecondition = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.EXISTED;
            }

            var serverAllocationId = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocationId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.INVALID_SERVER;
            }

            var locationId = _dbContext.Locations.FirstOrDefault(x => x.Id == model.LocationId);
            if (locationId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.INVALID_LOCATION;
            }

            if(validPrecondition)
            {
                var locationAssignment = _mapper.Map<LocationAssignment>(model);
                _dbContext.LocationAssignments.Add(locationAssignment);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<LocationAssignmentModel>(locationAssignment);
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
            var locationAssignment = _dbContext.LocationAssignments.FirstOrDefault(x => x.Id == id);
            if (locationAssignment == null)
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.LocationAssignments.Remove(locationAssignment);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = locationAssignment.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}