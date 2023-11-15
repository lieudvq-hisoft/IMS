using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core;
public interface ILocationService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, LocationSearchModel searchModel);
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

            paging.Data = _mapper.ProjectTo<LocationModel>(Locations).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }
}