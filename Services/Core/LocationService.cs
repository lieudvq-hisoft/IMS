﻿using AutoMapper;
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
}

public class LocationService: ILocationService
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
}
