using AutoMapper;
using Data.DataAccess;
using Data.Models;
using Services.Utilities;

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
            var companyTypes = _dbContext.CompanyTypes.ToList();

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
