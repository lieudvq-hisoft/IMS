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
    Task<ResultModel> GetServerHardwareConfig(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestUpgrade(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetAll();
    Task<ResultModel> GetDetail(int id);
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

            paging.Data = _mapper.Map<List<ComponentModel>>(components.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAll()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var components = _dbContext.Components.AsQueryable();

            result.Data = _mapper.Map<List<ComponentModel>>(components.ToList());
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
            var component = _dbContext.Components.FirstOrDefault(x => x.Id == id);

            if (component != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<ComponentModel>(component);
            }
            else
            {
                result.ErrorMessage = ComponentErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
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
            var existingComponent = _dbContext.Components.FirstOrDefault(x => x.Name == model.Name && x.Type == model.Type && x.Id != model.Id);
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
                _dbContext.Components.Remove(component);
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

    public async Task<ResultModel> GetServerHardwareConfig(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var hardwareConfig = _dbContext.Components
                .Include(x => x.ServerHardwareConfigs).FirstOrDefault(x => x.Id == id).ServerHardwareConfigs.AsQueryable();

            if (hardwareConfig != null)
            {
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, hardwareConfig.Count());
                hardwareConfig = hardwareConfig.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                hardwareConfig = hardwareConfig.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<ServerHardwareConfigModel>>(hardwareConfig.ToList());

                result.Data = paging;
                result.Succeed = true;
            }
            else
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRequestUpgrade(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.Components
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.Component)
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .FirstOrDefault(x => x.Id == id).RequestUpgrades.AsQueryable();

            if (requestUpgrade != null)
            {
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgrade.Count());
                requestUpgrade = requestUpgrade.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                requestUpgrade = requestUpgrade.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<RequestUpgradeModel>>(requestUpgrade.ToList());

                result.Data = paging;
                result.Succeed = true;            }
            else
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
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
