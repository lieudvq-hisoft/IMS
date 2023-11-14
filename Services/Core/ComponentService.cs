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
public interface IComponentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, ComponentSearchModel searchModel);
    Task<ResultModel> Create(ComponentCreateModel model);
    Task<ResultModel> Update(ComponentUpdateModel model);
    Task<ResultModel> Delete(int componentId);
}

public class ComponentService : IComponentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public ComponentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, ComponentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var components = _dbContext.Components
                .Where(delegate (Component x)
                {
                    return MyFunction.MatchString(searchModel.Name, x.Name);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, components.Count());

            components = components.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            components = components.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<ComponentModel>(components).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(ComponentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var existingComponent = _dbContext.Components.FirstOrDefault(x => x.Name == model.Name && x.Type == model.Type);
            if (existingComponent != null)
            {
                result.ErrorMessage = ComponentErrorMessage.EXISTED;
            }
            else
            {
                var component = _mapper.Map<Component>(model);

                _dbContext.Components.Add(component);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<ComponentModel>(component);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(ComponentUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var existingComponent = _dbContext.Components.FirstOrDefault(x => x.Name == model.Name && x.Type == model.Type);
            var component = _dbContext.Components.FirstOrDefault(x => x.Id == model.Id);
            if (existingComponent != null)
            {
                result.ErrorMessage = ComponentErrorMessage.EXISTED;
            }
            else if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
            }
            else
            {
                _mapper.Map<ComponentUpdateModel, Component>(model, component);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<ComponentModel>(component);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int componentId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var component = _dbContext.Components.FirstOrDefault(x => x.Id == componentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
            }
            else
            {
                component.IsDeleted = true;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = componentId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
