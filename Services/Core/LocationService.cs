using AutoMapper;
using Data.DataAccess;
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
    //Task<ResultModel> GetRackDetail(int id);
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

            result.Data = _mapper.Map<List<AreaModel>>(areas);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    //public async Task<ResultModel> GetRackDetail(int id)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
    //        var location = _dbContext.DeviceLocations.Include(x => x.Device).Include(x => x.Location).Where(x => x.Location.RackId == id && !x.IsDeleted);

    //        result.Data = _mapper.Map<RackModel>(rack);
    //        result.Succeed = true;
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}
}
