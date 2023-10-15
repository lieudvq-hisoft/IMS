using AutoMapper;
using Data.DataAccess;
using Data.Model;
using Data.Models;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IServiceService
{
    Task<ResultModel> Get();
}

public class ServiceService: IServiceService
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
            var services = _dbContext.Services.Where(x => !x.IsDeleted).ToList();

            result.Data = _mapper.Map<List<ServiceModel>>(services);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
