using AutoMapper;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Models;
using Services.Utilities;

namespace Services.Core;
public interface IComponentService
{
    Task<ResultModel> Get();
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

    public async Task<ResultModel> Get()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var components = _dbContext.Components.AsQueryable();

            result.Data = _mapper.ProjectTo<ComponentModel>(components);
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
