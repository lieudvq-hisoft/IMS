using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;

namespace Services.Core;
public interface IServiceService
{
    Task<ResultModel> Get(PagingParam<ServiceSortCriteria> paginationModel);
    Task<ResultModel> Create(ServiceCreateModel model);
    Task<ResultModel> Update(ServiceUpdateModel model);
    Task<ResultModel> Delete(int id);
}

public class ServiceService : IServiceService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public ServiceService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<ServiceSortCriteria> paginationModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var services = _dbContext.Services.AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, services.Count());

            services = services.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            services = services.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<ServiceModel>(services).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Create(ServiceCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            //var existingService = _dbContext.Services.FirstOrDefault(x => x.Name == model.Name);
            //if (existingService != null)
            //{
            //    result.ErrorMessage = ServiceErrorMessgae.EXISTED;
            //    validPrecondition = false;
            //}

            //if (validPrecondition)
            //{
            //    var service = new Service
            //    {
            //        Name = model.Name,
            //        Type = model.Type,

            //    };

            //    _dbContext.Services.Add(service);
            //    _dbContext.SaveChanges();

            //    result.Succeed = true;
            //    result.Data = _mapper.Map<ServiceModel>(service);
            //}
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(ServiceUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            //var service = _dbContext.Services.FirstOrDefault(x => x.Id == model.Id);

            //if (service == null)
            //{
            //    result.ErrorMessage = ServiceErrorMessgae.NOT_EXISTED;
            //}
            //else
            //{
            //    if (!model.Name.IsNullOrEmpty())
            //    {
            //        var existingService = _dbContext.Services.FirstOrDefault(x => x.Name == model.Name && x.Id != model.Id);
            //        if (existingService != null)
            //        {
            //            result.ErrorMessage = ServiceErrorMessgae.EXISTED;
            //            validPrecondition = false;
            //        }
            //        service.Name = model.Name;
            //    }

            //    service.Type = model.Type;

            //    if (validPrecondition)
            //    {
            //        service.DateUpdated = DateTime.Now;
            //        _dbContext.SaveChanges();
            //        result.Succeed = true;
            //        result.Data = _mapper.Map<ServiceModel>(service);
            //    }
            //}
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
            var service = _dbContext.Services.FirstOrDefault(x => x.Id == id);
            if (service == null)
            {
                result.ErrorMessage = ServiceErrorMessgae.NOT_EXISTED;
            }
            else
            {
                service.IsDeleted = true;
                service.DateUpdated = DateTime.Now;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = service.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
