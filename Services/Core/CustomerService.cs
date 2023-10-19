using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Model;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Services.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Services.Core;

public interface ICustomerService
{
    Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Import(string filePath);
    Task<ResultModel> Create(CustomerCreateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Update(CustomerUpdateModel model);
    Task<ResultModel> SendActivationEmail(List<int> customerIds);

}

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly EmailHelper _emailHelper;

    public CustomerService(AppDbContext dbContext, IMapper mapper, UserManager<User> userManager, EmailHelper emailHelper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _userManager = userManager;
        _emailHelper = emailHelper;
    }

    public async Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customers = _dbContext.Customers
                .Include(x => x.User)
                .Include(x => x.CompanyType)
                .Where(delegate (Customer x)
                {
                    return MatchString(searchModel, x.User.Email);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, customers.Count());

            customers = customers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            customers = customers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<CustomerModel>(customers).ToList();

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
            var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == id);

            if (customer != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<CustomerModel>(customer);
            }
            else
            {
                result.ErrorMessage = "Customer with id " + ErrorMessage.ID_NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private bool MatchString(CustomerSearchModel searchModel, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }

    public async Task<ResultModel> Import(string filePath)
    {
        //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage(new FileInfo(filePath));
        var worksheet = package.Workbook.Worksheets["Sheet1"];
        int rowCount = worksheet.Dimension.End.Row;     //get row count
        int colCount = worksheet.Dimension.End.Column;     //get col count
        int successRow = 0;

        for (int row = 2; row <= rowCount; row++)
        {
            var resultCell = worksheet.Cells[row, colCount];
            resultCell.Style.WrapText = true;
            resultCell.Style.VerticalAlignment = ExcelVerticalAlignment.Top;
            string companyName = worksheet.Cells[row, 2].Value?.ToString().Trim();
            var company = _dbContext.CompanyTypes.FirstOrDefault(x => x.Name == companyName);

            if (company == null)
            {
                resultCell.Value = "Company " + ErrorMessage.NOT_EXISTED;
            }
            else
            {
                var model = new CustomerCreateModel()
                {
                    CompanyName = worksheet.Cells[row, 1].Value?.ToString().Trim(),
                    CompanyTypeId = company.Id,
                    Fullname = worksheet.Cells[row, 3].Value?.ToString().Trim(),
                    TaxNumber = worksheet.Cells[row, 4].Value?.ToString().Trim(),
                    Address = worksheet.Cells[row, 5].Value?.ToString().Trim(),
                    Email = worksheet.Cells[row, 6].Value?.ToString().Trim(),
                    PhoneNumber = worksheet.Cells[row, 7].Value?.ToString().Trim(),
                };

                var context = new ValidationContext(model, serviceProvider: null, items: null);
                var validationResults = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(model, context, validationResults, true);

                if (!isValid)
                {
                    foreach (ValidationResult validationError in validationResults)
                    {
                        resultCell.Value = validationError.ErrorMessage + "\r\n";
                    }
                }
                else
                {
                    var result = await Create(model);
                    if (!result.Succeed)
                    {
                        resultCell.Value = result.ErrorMessage;
                    }
                    else
                    {
                        resultCell.Value = "Ok";
                        successRow++;
                    }
                }
            }
        }

        package.Save();

        return new ResultModel
        {
            Succeed = true,
            Data = successRow
        };
    }

    /// <summary>
    /// Create a new customer and its associate user. Check for duplicate of email or phone number of user. Check for duplicate of tax number of customer.
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The result model contain the new customer</returns>
    public async Task<ResultModel> Create(CustomerCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        CompanyType companyType = null;

        try
        {
            // Check for duplicate user by email or phonenumber
            var existingUser = _dbContext.User.FirstOrDefault(x => x.Email == model.Email || x.PhoneNumber == model.PhoneNumber);
            if (existingUser != null)
            {
                result.ErrorMessage = "User " + ErrorMessage.EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                // Check for duplicate customer by tax number
                var existingCustomer = _dbContext.Customers.FirstOrDefault(x => x.TaxNumber == model.TaxNumber);
                if (existingCustomer != null)
                {
                    result.ErrorMessage = "Customer with tax number " + ErrorMessage.EXISTED;
                    validPrecondition = false;
                }
            }

            if (validPrecondition)
            {
                // Find company type
                companyType = _dbContext.CompanyTypes.FirstOrDefault(x => x.Id == model.CompanyTypeId);

                if (companyType == null)
                {
                    result.ErrorMessage = "Company type " + ErrorMessage.NOT_EXISTED;
                    validPrecondition = false;
                }
            }

            if (validPrecondition)
            {
                // Create new user
                var role = _dbContext.Role.FirstOrDefault(x => !x.isDeactive && x.Name == "Customer");
                var user = new User
                {
                    UserName = GenerateUsername(model.CompanyName),
                    Email = model.Email,
                    Fullname = model.Fullname,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    IsDeleted = false,
                    NormalizedEmail = model.Email.ToLower(),
                };

                var createUserResult = await _userManager.CreateAsync(user, MyFunction.ConvertToUnSign(model.CompanyName.Trim().Replace(" ", "")) + "@123");
                if (createUserResult.Succeeded)
                {
                    var userRole = new UserRole
                    {
                        RoleId = role.Id,
                        UserId = user.Id
                    };
                    _dbContext.UserRole.Add(userRole);
                    await _dbContext.SaveChangesAsync();

                    // Create associate customer
                    var customer = new Customer
                    {
                        CompanyName = model.CompanyName,
                        TaxNumber = model.TaxNumber,
                        UserId = user.Id,
                        CompanyTypeId = companyType.Id
                    };
                    _dbContext.Customers.Add(customer);
                    _dbContext.SaveChanges();

                    result.Succeed = true;
                    result.Data = _mapper.Map<CustomerModel>(customer);
                }
                else
                {
                    result.Succeed = false;
                    result.ErrorMessage = "REGISTER_USER_ERROR";
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private string GenerateUsername(string companyName)
    {
        string username = "";
        var normalizedCompanyName = MyFunction.ConvertToUnSign(companyName.Trim().Replace(" ", ""));
        var customerOfCompanyCount = _dbContext.Customers.IgnoreQueryFilters().Include(x => x.User).Where(x => x.User.UserName.Contains(normalizedCompanyName)).ToList().Count();

        username = normalizedCompanyName + (customerOfCompanyCount + 1).ToString();

        return username;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                result.ErrorMessage = "Delete customer fail";
            }
            else
            {
                customer.IsDeleted = true;
                customer.User.IsDeleted = true;
                customer.DateUpdated = DateTime.Now;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = customer.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(CustomerUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == model.Id);

            if (customer == null)
            {
                result.ErrorMessage = "Update customer failed";
            }
            else
            {
                if (!model.CompanyName.IsNullOrEmpty())
                {
                    customer.CompanyName = model.CompanyName;
                }
                if (!model.TaxNumber.IsNullOrEmpty())
                {
                    customer.TaxNumber = model.TaxNumber;
                }
                if (!model.Fullname.IsNullOrEmpty())
                {
                    customer.User.Fullname = model.Fullname;
                }
                if (!model.Address.IsNullOrEmpty())
                {
                    customer.User.Address = model.Address;
                }
                if (!model.Email.IsNullOrEmpty())
                {
                    customer.User.Email = model.Email;
                }
                if (!model.PhoneNumber.IsNullOrEmpty())
                {
                    customer.User.PhoneNumber = model.PhoneNumber;
                }
                customer.DateUpdated = DateTime.Now;

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<CustomerModel>(customer);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> SendActivationEmail(List<int> customerIds)
    {
        var smtpClient = _emailHelper.GetClient();

        foreach (int customerId in customerIds)
        {
            var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == customerId);
            if (customer != null)
            {
                var email = customer.User.Email;
                var username = customer.User.UserName;
                var password = username.Remove(username.Length - 1) + "@123";
                var mailMessage = _emailHelper.GetActivationMessage(username, password, email);
                mailMessage.To.Add(email);
                smtpClient.Send(mailMessage);
            }
        }

        return new ResultModel
        {
            Succeed = true
        };
    }
}
