using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core;
public interface ILocationAssignmentService
{
    Task<ResultModel> Get(PagingParam<LocationAssignmentSortingCriteria> paginationModel, LocationAssignmentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
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
            var locationAssignments = _dbContext.LocationAssignments
                .Where(x => searchModel.ServerAllocationId != null ? x.Id == searchModel.ServerAllocationId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, locationAssignments.Count());

            locationAssignments = locationAssignments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            locationAssignments = locationAssignments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments.ToList());

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
}