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
    Task<ResultModel> GetLocation(int id);
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

    public async Task<ResultModel> GetDetail(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks
                .FirstOrDefault(x => x.Id == id);

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

    public async Task<ResultModel> GetLocation(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var racks = _dbContext.Racks.Include(x => x.Locations).Where(x => x.AreaId == id);

            result.Data = _mapper.ProjectTo<List<RackModel>>(racks).ToList();
            result.Succeed = true;
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

            if (validPrecondition)
            {
                var rack = _mapper.Map<Rack>(model);
                _dbContext.Racks.Add(rack);
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

    public async Task<ResultModel> Update(RackUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var rack = _dbContext.Racks.FirstOrDefault(x => x.Id == model.Id);
            if (rack == null)
            {
                result.ErrorMessage = RackErrorMessage.NOT_EXISTED;
            }
            else
            {
                _mapper.Map<RackUpdateModel, Rack>(model, rack);
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