using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Model;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;

public interface ICustomerService
{
    Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> Create(CustomerCreateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Import(string filename);
}

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly IHostingEnvironment _environment;

    public CustomerService(AppDbContext dbContext, IMapper mapper, UserManager<User> userManager, IHostingEnvironment environment)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _userManager = userManager;
        _environment = environment;
    }

    public async Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customers = _dbContext.Customer
                .Include(x => x.User)
                .Where(x => !x.IsDeleted)
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
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    private bool MatchString(CustomerSearchModel searchModel, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }

    public async Task<ResultModel> Import(string filename)
    {
        string filePath = Path.Combine(_environment.WebRootPath, "import/customer/" + filename);
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage(filePath);
        var worksheet = package.Workbook.Worksheets["Sheet1"];
        int rowCount = worksheet.Dimension.End.Row;     //get row count
        int successRow = 0;

        for (int row = 2; row <= rowCount; row++)
        {
            var model = new CustomerCreateModel()
            {
                Fullname = worksheet.Cells[row, 1].Value?.ToString().Trim(),
                Email = worksheet.Cells[row, 2].Value?.ToString().Trim(),
                UserName = worksheet.Cells[row, 3].Value?.ToString().Trim(),
                Address = worksheet.Cells[row, 4].Value?.ToString().Trim(),
                CompanyName = worksheet.Cells[row, 5].Value?.ToString().Trim(),
                PhoneNumber = worksheet.Cells[row, 6].Value?.ToString().Trim(),
                TaxNumber = worksheet.Cells[row, 7].Value?.ToString().Trim(),
            };

            var context = new ValidationContext(model, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            var resultCell = worksheet.Cells[row, 8];
            resultCell.Style.WrapText = true;
            resultCell.Style.VerticalAlignment = ExcelVerticalAlignment.Top;

            bool isValid = Validator.TryValidateObject(model, context, validationResults, true);

            if (!isValid)
            {
                foreach (ValidationResult validationError in validationResults)
                {
                    resultCell.RichText.Add(validationError.ErrorMessage+"\r\n");
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

        try
        {
            // Check for duplicate user by email or phonenumber
            var existingUser = _dbContext.User.Where(x => (x.Email == model.Email || x.PhoneNumber == model.PhoneNumber) && !x.IsDeleted).FirstOrDefault();
            if (existingUser != null)
            {
                result.ErrorMessage = "User " + ErrorMessage.EXISTED;
            }
            else
            {
                // Check for duplicate customer by tax number
                var existingCustomer = _dbContext.Customer.Where(x => x.TaxNumber == model.TaxNumber && !x.IsDeleted).FirstOrDefault();
                if (existingCustomer != null)
                {
                    result.ErrorMessage = "Customer with tax number " + ErrorMessage.EXISTED;
                }
                else
                {
                    // Create new user
                    var role = await _dbContext.Roles.FirstOrDefaultAsync(r => r.Name == "Customer");
                    var user = new User
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        Fullname = model.Fullname,
                        Address = model.Address,
                        PhoneNumber = model.PhoneNumber,
                        IsDeleted = false,
                        NormalizedEmail = model.Email.ToLower(),
                    };

                    var createUserResult = await _userManager.CreateAsync(user, model.UserName + "@123");
                    if (createUserResult.Succeeded)
                    {
                        var userRole = new UserRole
                        {
                            RoleId = role.Id,
                            UserId = user.Id
                        };
                        _dbContext.UserRoles.Add(userRole);
                        await _dbContext.SaveChangesAsync();

                        // Create associate customer
                        var customer = new Customer
                        {
                            CompanyName = model.CompanyName,
                            TaxNumber = model.TaxNumber,
                            UserId = user.Id
                        };
                        _dbContext.Customer.Add(customer);
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
        }
        catch (Exception ex)
        {
            result.ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }

        return result;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customer.Include(x => x.User).Where(x => x.Id == id && !x.IsDeleted).FirstOrDefault();
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
        catch (Exception ex)
        {
            result.ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }
        return result;
    }

    public async Task<ResultModel> Update(CustomerUpdateModel model)
    {
        var result = new ResultModel();
        try
        {
            var customer = _dbContext.Customer.Where(x => x.Id == model.Id && !x.IsDeleted).FirstOrDefault();
        }
        catch (Exception ex)
        {
            result.Succeed = false;
            result.ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }

        return result;
    }
}
