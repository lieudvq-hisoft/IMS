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
public interface ICompanyTypeService
{
    Task<ResultModel> Get();
}

public class CompanyTypeService : ICompanyTypeService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public CompanyTypeService(AppDbContext dbContext, IMapper mapper)
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
            var companyTypes = _dbContext.CompanyTypes.Where(x => !x.IsDeleted).ToList();

            result.Data = _mapper.Map<List<CompanyTypeModel>>(companyTypes);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
