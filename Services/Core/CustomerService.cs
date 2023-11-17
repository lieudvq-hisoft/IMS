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
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Services.Utilities;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services.Core;

public interface ICustomerService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetServerAllocation(int id);
    //Task<ResultModel> Import(string filePath);
    Task<ResultModel> Create(CustomerCreateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Update(CustomerUpdateModel model);
    Task<ResultModel> SendActivationEmail(List<int> customerIds);
    Task<ResultModel> Login(CustomerLoginModel model);
}

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IEmailService _emailService;
    private readonly IConfiguration _config;

    public CustomerService(
        AppDbContext dbContext,
        IMapper mapper,
        IEmailService emailService,
        IConfiguration config)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _emailService = emailService;
        _config = config;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customers = _dbContext.Customers
                .Include(x => x.CompanyType)
                .Where(delegate (Customer x)
                {
                    return MyFunction.MatchString(searchModel.CustomerName, x.CustomerName);
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
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);

            if (customer != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<CustomerModel>(customer);
            }
            else
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetServerAllocation(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.Include(x => x.ServerAllocations).FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
            else
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<ServerAllocationModel>>(customer.ServerAllocations);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Import(string filePath)
    {
        using var package = new ExcelPackage(new FileInfo(filePath));
        var worksheet = package.Workbook.Worksheets["Sheet1"];
        int rowCount = worksheet.Dimension.End.Row;
        int colCount = worksheet.Dimension.End.Column;
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
                    CustomerName = worksheet.Cells[row, 3].Value?.ToString().Trim(),
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

    public async Task<ResultModel> Create(CustomerCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var companyType = _dbContext.CompanyTypes.FirstOrDefault(x => x.Id == model.CompanyTypeId);
            if (companyType == null)
            {
                validPrecondition = false;
                result.ErrorMessage = CompanyTypeErrorMessage.NOT_EXISTED;
            }

            if (_dbContext.Customers.Any(x => (x.CompanyName == model.CompanyName && x.CompanyTypeId == model.CompanyTypeId) || x.Email == model.Email || x.TaxNumber == model.TaxNumber || x.PhoneNumber == model.PhoneNumber))
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.EXISTED;
            }

            if (validPrecondition)
            {
                var customer = _mapper.Map<Customer>(model);
                customer.Username = GenerateUsername(model.CompanyName);
                customer.Password = MyFunction.ConvertToUnSign(model.CompanyName.Trim().Replace(" ", "")) + "@a123";
                _dbContext.Customers.Add(customer);
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

    private string GenerateUsername(string companyName)
    {
        string username = "";
        var normalizedCompanyName = MyFunction.ConvertToUnSign(companyName.Trim().Replace(" ", ""));
        var customerOfCompanyCount = _dbContext.Customers.IgnoreQueryFilters().Where(x => x.Username.Contains(normalizedCompanyName)).ToList().Count();

        username = normalizedCompanyName + (customerOfCompanyCount + 1).ToString();

        return username;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.Customers.Remove(customer);
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
        bool validPrecondition = true;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == model.Id);
            if (customer == null)
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.UPDATE_FAILED;
            }

            var existingCustomer = _dbContext.Customers.FirstOrDefault(x => ((x.CompanyName == model.CompanyName && x.CompanyTypeId == model.CompanyTypeId) || x.Email == model.Email || x.TaxNumber == model.TaxNumber || x.PhoneNumber == model.PhoneNumber) && x.Id != model.Id);
            if (existingCustomer != null)
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.EXISTED;
            }

            if (validPrecondition)
            {
                _mapper.Map<CustomerUpdateModel, Customer>(model, customer);
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
        foreach (int customerId in customerIds)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer != null)
            {
                using var smtpClient = _emailService.GetClient();
                var email = customer.Email;
                var username = customer.Username;
                var password = username.Remove(username.Length - 1) + "@a123";
                var mailMessage = _emailService.GetActivationMessage(username, password, email);
                mailMessage.To.Add(email);
                smtpClient.SendMailAsync(mailMessage);
            }
        }

        return new ResultModel
        {
            Succeed = true
        };
    }

    public async Task<ResultModel> Login(CustomerLoginModel model)
    {
        var result = new ResultModel();

        var customer = _dbContext.Customers.FirstOrDefault(x => x.Username == model.Username);

        if (customer != null)
        {

            var token = await GetAccessToken(customer);
            result.Succeed = true;
            result.Data = token;
        }
        else
        {
            result.ErrorMessage = UserErrorMessage.LOGIN_ERROR;
        }
        return result;
    }

    private async Task<Token> GetAccessToken(Customer customer)
    {
        List<Claim> claims = GetClaims(customer);
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(_config["Jwt:Issuer"],
          _config["Jwt:Issuer"],
          claims,
          expires: DateTime.Now.AddDays(int.Parse(_config["Jwt:ExpireTimes"])),
          //int.Parse(_configuration["Jwt:ExpireTimes"]) * 3600
          signingCredentials: creds);

        var serializedToken = new JwtSecurityTokenHandler().WriteToken(token);

        return new Token
        {
            Access_token = serializedToken,
            Token_type = "Bearer",
            Expires_in = int.Parse(_config["Jwt:ExpireTimes"]) * 60,
            UserID = customer.Id.ToString(),
            UserName = customer.Username,
            PhoneNumber = customer.PhoneNumber,
        };
    }

    private List<Claim> GetClaims(Customer customer)
    {
        IdentityOptions _options = new IdentityOptions();
        var claims = new List<Claim>
        {
            new Claim("UserId", customer.Id.ToString()),
            new Claim("Email", customer.Email),
            new Claim("FullName", customer.CustomerName),
            new Claim("UserName", customer.Username),
            new Claim(ClaimTypes.Role, "Customer")
        };

        if (!string.IsNullOrEmpty(customer.PhoneNumber)) claims.Add(new Claim("PhoneNumber", customer.PhoneNumber));
        return claims;
    }
}
