using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IRackService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RackSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(RackCreateModel model);
    Task<ResultModel> Update(RackUpdateModel model);
    Task<ResultModel> Delete(int id);
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

    public async Task<ResultModel> Create(RackCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var areaId = _dbContext.Areas.FirstOrDefault(x => x.Id == model.AreaId);
            if(areaId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RackErrorMessage.AREA_NOT_EXISTED;
            }

            if (model.Size <= 0)
            {
                validPrecondition = false;
                result.ErrorMessage = RackErrorMessage.SIZE_WRONG_INPUT;
            }

            if (model.MaxPower <= 0)
            {
                validPrecondition = false;
                result.ErrorMessage = RackErrorMessage.POWER_WRONG_INPUT;
            }

            if (model.CurrentPower <= 0)
            {
                validPrecondition = false;
                result.ErrorMessage = RackErrorMessage.POWER_WRONG_INPUT;
            }

            if (validPrecondition)
            {
                var Rack = new Rack
                {
                    MaxPower = model.MaxPower,
                    CurrentPower = model.CurrentPower,
                    Column = model.Column,
                    Row = model.Row,
                    Size = model.Size,
                    AreaId = model.AreaId,
                };
                _dbContext.Racks.Add(Rack);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RackModel>(Rack);
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
            var Rack = _dbContext.Racks.FirstOrDefault(x => x.Id == id);
            if (Rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                Rack.IsDeleted = true;
                Rack.DateUpdated = DateTime.Now;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = Rack.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RackSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var Racks = _dbContext.Racks
                .Where(x => searchModel.RackId != null ? x.Id == searchModel.RackId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, Racks.Count());

            Racks = Racks.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            Racks = Racks.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RackModel>(Racks).ToList();

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
            var Rack = _dbContext.Racks
                .Include(x => x.Area)
                .Include(x => x.Locations)
                .FirstOrDefault(x => x.Id == id);

            if (Rack != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RackDetailModel>(Rack);
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

    public async Task<ResultModel> Update(RackUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var Rack = _dbContext.Racks.FirstOrDefault(x => x.Id == model.Id);
            if (Rack == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                var areaId = _dbContext.Areas.FirstOrDefault(x => x.Id == model.AreaId);
                if (areaId == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RackErrorMessage.AREA_NOT_EXISTED;
                }

                if (model.Size <= 0)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RackErrorMessage.SIZE_WRONG_INPUT;
                }

                if (model.MaxPower <= 0)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RackErrorMessage.POWER_WRONG_INPUT;
                }

                if (model.CurrentPower <= 0)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RackErrorMessage.POWER_WRONG_INPUT;
                }
            }

            if (validPrecondition)
            {
                Rack.MaxPower = model.MaxPower;
                Rack.CurrentPower = model.CurrentPower;
                Rack.Column = model.Column;
                Rack.Row = model.Row;
                Rack.Size = model.Size;
                Rack.AreaId = model.AreaId;

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RackModel>(Rack);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}