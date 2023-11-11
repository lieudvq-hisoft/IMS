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
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Services.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Services.Core;

public interface ICustomerService
{
    Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    //Task<ResultModel> Import(string filePath);
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
    private readonly IEmailService _emailService;

    public CustomerService(AppDbContext dbContext, IMapper mapper, UserManager<User> userManager, IEmailService emailService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _userManager = userManager;
        _emailService = emailService;
    }

    public async Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customers = _dbContext.Customers
                .Include(x => x.CompanyType)
                .Where(delegate (Customer x)
                {
                    return MatchString(searchModel.CustomerName, x.CustomerName);
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

    private bool MatchString(string searchValue, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
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

        try
        {
            var companyType = _dbContext.CompanyTypes.FirstOrDefault(x => x.Id == model.CompanyTypeId);
            if (companyType == null)
            {
                result.ErrorMessage = CompanyTypeErrorMessage.NOT_EXISTED;
            }
            else
            {
                var customer = new Customer
                {
                    Username = GenerateUsername(model.CompanyName),
                    Password = MyFunction.ConvertToUnSign(model.CompanyName.Trim().Replace(" ", "")) + "@a123",
                    CompanyName = model.CompanyName,
                    Address = model.Address,
                    TaxNumber = model.TaxNumber,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    CustomerName = model.CustomerName,
                    CompanyTypeId = model.CompanyTypeId
                };
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
        var customerOfCompanyCount = _dbContext.Customers.IgnoreQueryFilters().Where(x => x.CustomerName.Contains(normalizedCompanyName)).ToList().Count();

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
                customer.IsDeleted = true;
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
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == model.Id);

            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.UPDATE_FAILED;
            }
            else
            {
                customer.Username = model.Username;
                customer.CompanyName = model.CompanyName;
                customer.Address = model.Address;
                customer.TaxNumber = model.TaxNumber;
                customer.Email = model.Email;
                customer.PhoneNumber = model.PhoneNumber;
                customer.CustomerName = model.CustomerName;

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
}
