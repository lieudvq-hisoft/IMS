using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IAreaService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AreaSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRack(int id);
    Task<ResultModel> Create(AreaCreateModel model);
    Task<ResultModel> Update(AreaUpdateModel model);
    Task<ResultModel> Delete(int id);
}

public class AreaService : IAreaService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public AreaService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AreaSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var areas = _dbContext.Areas
                .Where(x => searchModel.AreaId != null ? x.Id == searchModel.AreaId : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, areas.Count());

            areas = areas.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            areas = areas.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<AreaModel>(areas).ToList();

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
            var area = _dbContext.Areas
                .FirstOrDefault(x => x.Id == id);

            if (area != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<AreaModel>(area);
            }
            else
            {
                result.ErrorMessage = AreaErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRack(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var area = _dbContext.Areas
                .Include(x => x.Racks)
                .FirstOrDefault(x => x.Id == id);

            if (area != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<RackModel>>(area.Racks);
            }
            else
            {
                result.ErrorMessage = AreaErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(AreaCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var areaName = _dbContext.Areas.FirstOrDefault(x => x.Name.Trim() == model.Name.Trim());
            if (areaName != null)
            {
                result.ErrorMessage = AreaErrorMessage.EXISTED;
            }
            else
            {
                var area = _mapper.Map<Area>(model);
                _dbContext.Areas.Add(area);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<AreaModel>(area);
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
            var area = _dbContext.Areas.Include(x => x.Racks).ThenInclude(x => x.Locations).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == id);
            if (area == null)
            {
                result.ErrorMessage = AreaErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.Areas.Remove(area);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = area.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(AreaUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var area = _dbContext.Areas.FirstOrDefault(x => x.Id == model.Id);
            if (area == null)
            {
                result.ErrorMessage = AreaErrorMessage.NOT_EXISTED;
            }
            else
            {
                var areaName = _dbContext.Areas.FirstOrDefault(x => x.Name.Trim() == model.Name.Trim() && x.Name.Trim() != area.Name.Trim());
                if (areaName != null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AreaErrorMessage.EXISTED;
                }
            }

            if (validPrecondition)
            {
                area.Name = model.Name;
                area.RowCount = model.RowCount;
                area.ColumnCount = model.ColumnCount;

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<AreaModel>(area);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}