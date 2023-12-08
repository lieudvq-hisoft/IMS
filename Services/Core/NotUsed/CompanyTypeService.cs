//using AutoMapper;
//using Data.DataAccess;
//using Data.DataAccess.Constant;
//using Data.Models;
//using Services.Utilities;

//namespace Services.Core.NotUsed;
//public interface ICompanyTypeService
//{
//    Task<ResultModel> Get();
//    Task<ResultModel> GetDetail(int id);
//}

//public class CompanyTypeService : ICompanyTypeService
//{
//    private readonly AppDbContext _dbContext;
//    private readonly IMapper _mapper;

//    public CompanyTypeService(AppDbContext dbContext, IMapper mapper)
//    {
//        _dbContext = dbContext;
//        _mapper = mapper;
//    }

//    public async Task<ResultModel> Get()
//    {
//        var result = new ResultModel();
//        result.Succeed = false;

//        try
//        {
//            var companyTypes = _dbContext.CompanyTypes.ToList();

//            result.Data = _mapper.Map<List<CompanyTypeModel>>(companyTypes);
//            result.Succeed = true;
//        }
//        catch (Exception e)
//        {
//            result.ErrorMessage = MyFunction.GetErrorMessage(e);
//        }

//        return result;
//    }

//    public async Task<ResultModel> GetDetail(int id)
//    {
//        var result = new ResultModel();
//        result.Succeed = false;

//        try
//        {
//            var companyType = _dbContext.CompanyTypes.FirstOrDefault(x => x.Id == id);

//            if (companyType != null)
//            {
//                result.Succeed = true;
//                result.Data = _mapper.Map<CompanyTypeModel>(companyType);
//            }
//            else
//            {
//                result.ErrorMessage = CompanyTypeErrorMessgae.NOT_EXISTED;
//                result.Succeed = false;
//            }
//        }
//        catch (Exception e)
//        {
//            result.ErrorMessage = MyFunction.GetErrorMessage(e);
//        }
//        return result;
//    }
//}
