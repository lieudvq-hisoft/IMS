using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IDeviceService
{
    Task<ResultModel> Get(PagingParam<DeviceSortCriteria> paginationModel, DeviceSearchModel searchModel);
}

public class DeviceService : IDeviceService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public DeviceService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<DeviceSortCriteria> paginationModel, DeviceSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var devices = _dbContext.Devices.Include(x => x.Server)
                .Where(x => x.Server == null)
                .Where(delegate (Device x)
                {
                    return searchModel.Status != null ? x.Status.ToString() == searchModel.Status.ToString() : true;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, devices.Count());

            devices = devices.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            devices = devices.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<DeviceModel>>(devices);

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
