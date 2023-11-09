using AutoMapper;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;

namespace Services.Core;
public interface IServiceService
{
    Task<ResultModel> Get();
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

    public async Task<ResultModel> Get()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var services = _dbContext.Services.ToList();

            result.Data = _mapper.Map<List<ServiceModel>>(services);
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
            var existingService = _dbContext.Services.FirstOrDefault(x => x.Name == model.Name);
            if (existingService != null)
            {
                result.ErrorMessage = ServiceErrorMessgae.EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                var service = new Service
                {
                    Name = model.Name,
                    Type = model.Type,

                };

                _dbContext.Services.Add(service);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<ServiceModel>(service);
            }
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
            var service = _dbContext.Services.FirstOrDefault(x => x.Id == model.Id);

            if (service == null)
            {
                result.ErrorMessage = ServiceErrorMessgae.NOT_EXISTED;
            }
            else
            {
                if (!model.Name.IsNullOrEmpty())
                {
                    var existingService = _dbContext.Services.FirstOrDefault(x => x.Name == model.Name && x.Id != model.Id);
                    if(existingService != null)
                    {
                        result.ErrorMessage = ServiceErrorMessgae.EXISTED;
                        validPrecondition = false;
                    }
                    service.Name = model.Name;
                }
                   
                if (!model.Type.IsNullOrEmpty())
                {
                    service.Type = model.Type;
                }


                if (validPrecondition)
                {
                    service.DateUpdated = DateTime.Now;
                    _dbContext.SaveChanges();
                    result.Succeed = true;
                    result.Data = _mapper.Map<ServiceModel>(service);
                }
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
