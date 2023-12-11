using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services.Core;

public interface ICustomerService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> GetDetail(Guid id);
    Task<ResultModel> GetServerAllocation(PagingParam<BaseSortCriteria> paginationModel, Guid id);
    Task<ResultModel> Create(CustomerCreateModel model, Guid userId);
    Task<ResultModel> Delete(Guid id);
    Task<ResultModel> Update(CustomerUpdateModel model);
    Task<ResultModel> ChangePassword(CustomerChangePasswordModel model, Guid customerId);
    Task<ResultModel> Login(CustomerLoginModel model);
    Task<ResultModel> BindFcmtoken(BindFcmtokenModel model, Guid customerId);
    Task<ResultModel> DeleteFcmToken(string fcmToken, Guid customerId);
    Task<ResultModel> SeenCurrenNoticeCount(Guid customerId);
}

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IEmailHelper _emailService;
    private readonly IConfiguration _config;
    private readonly PasswordHasher<Customer> _passwordHasher;
    private readonly INotificationService _notiService;

    public CustomerService(
        AppDbContext dbContext,
        IMapper mapper,
        IEmailHelper emailService,
        IConfiguration config,
        INotificationService notiService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _emailService = emailService;
        _config = config;
        _passwordHasher = new PasswordHasher<Customer>();
        _notiService = notiService;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customers = _dbContext.Customers
                .IgnoreQueryFilters()
                .Where(delegate (Customer x)
                {
                    return x.Filter(searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, customers.Count());

            customers = customers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            customers = customers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<CustomerModel>>(customers.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(Guid id)
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

    public async Task<ResultModel> GetServerAllocation(PagingParam<BaseSortCriteria> paginationModel, Guid id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers
                .Include(x => x.ServerAllocations).ThenInclude(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                .Include(x => x.ServerAllocations).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .FirstOrDefault(x => x.Id == id);

            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
            else
            {
                var serverAllocations = customer.ServerAllocations.AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, serverAllocations.Count());
                serverAllocations = serverAllocations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                serverAllocations = serverAllocations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<ServerAllocationModel>>(serverAllocations.ToList());

                result.Data = paging;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(CustomerCreateModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (_dbContext.Customers.Any(x => (x.CompanyName == model.CompanyName) || x.Email == model.Email || x.TaxNumber == model.TaxNumber || x.PhoneNumber == model.PhoneNumber))
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.EXISTED;
            }

            if (validPrecondition)
            {
                var customer = _mapper.Map<Customer>(model);
                var password = "Password@123";
                customer.Password = _passwordHasher.HashPassword(customer, password);
                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();
                SendActivationEmail(customer);

                _dbContext.UserCustomers.Add(new UserCustomer
                {
                    UserId = userId,
                    CustomerId = customer.Id
                });
                _dbContext.SaveChanges();
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = customer.Id,
                    Action = "Action",
                    Title = "Title",
                    Body = "Body",
                    Data = new NotificationData
                    {
                        Key = "string",
                        Value = "string"
                    }
                });

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

    public async Task<ResultModel> Delete(Guid id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.Include(x => x.ServerAllocations).FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
            }
            else if (customer.ServerAllocations.Any(x => x.Status != ServerAllocationStatus.Removed))
            {
                result.ErrorMessage = "Cannot delete customer with working server allocation";
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
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == new Guid(model.Id));
            if (customer == null)
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.UPDATE_FAILED;
            }

            var existingCustomer = _dbContext.Customers.FirstOrDefault(x => ((x.CompanyName == model.CompanyName) || x.Email == model.Email || x.TaxNumber == model.TaxNumber || x.PhoneNumber == model.PhoneNumber) && x.Id != new Guid(model.Id));
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

    public async Task<ResultModel> ChangePassword(CustomerChangePasswordModel model, Guid customerId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer == null)
            {
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
            }
            else
            {
                var passwordVerifyResult = _passwordHasher.VerifyHashedPassword(customer, customer.Password, model.CurrentPassword);
                if (passwordVerifyResult != PasswordVerificationResult.Success && passwordVerifyResult != PasswordVerificationResult.SuccessRehashNeeded)
                {
                    result.ErrorMessage = "Old password not match";
                }
                else
                {
                    customer.Password = _passwordHasher.HashPassword(customer, model.Password);
                    _dbContext.SaveChanges();
                    await SendActivationEmail(customer);
                    result.Succeed = true;
                    result.Data = _mapper.Map<CustomerResultModel>(customer);
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private async Task SendActivationEmail(Customer customer)
    {
        using var smtpClient = _emailService.GetClient();
        var email = customer.Email;
        var password = "Password@123";
        var mailMessage = _emailService.GetActivationMessage(password, email);
        mailMessage.To.Add(email);
        await smtpClient.SendMailAsync(mailMessage);
    }

    public async Task<ResultModel> Login(CustomerLoginModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        var customer = _dbContext.Customers.FirstOrDefault(x => x.Email == model.Email);

        if (customer != null)
        {
            var passwordVerifyResult = _passwordHasher.VerifyHashedPassword(customer, customer.Password, model.Password);
            if (passwordVerifyResult != PasswordVerificationResult.Success && passwordVerifyResult != PasswordVerificationResult.SuccessRehashNeeded)
            {
                result.ErrorMessage = UserErrorMessage.LOGIN_ERROR;
            }
            else
            {
                var token = await GetAccessToken(customer);
                result.Succeed = true;
                result.Data = token;
            }
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
            new Claim("FullName", customer.CompanyName),
            new Claim(ClaimTypes.Role, "Customer")
        };

        if (!string.IsNullOrEmpty(customer.PhoneNumber)) claims.Add(new Claim("PhoneNumber", customer.PhoneNumber));
        return claims;
    }
    public async Task<ResultModel> BindFcmtoken(BindFcmtokenModel model, Guid customerId)
    {
        var result = new ResultModel();
        try
        {
            var customer = _dbContext.Customers.Where(_ => _.Id == customerId).FirstOrDefault();
            if (customer == null)
            {
                result.Succeed = false;
                result.ErrorMessage = "User not found";
                return result;
            }
            if (!customer.FcmTokens!.Contains(model.FcmToken))
            {
                customer.FcmTokens.Add(model.FcmToken);
                customer.DateUpdated = DateTime.Now;
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
            }
            result.Data = model.FcmToken;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    public async Task<ResultModel> DeleteFcmToken(string fcmToken, Guid customerId)
    {
        var result = new ResultModel();
        try
        {
            var customer = _dbContext.Customers.Where(x => x.Id == customerId).FirstOrDefault();
            if (customer != null && customer.FcmTokens!.Contains(fcmToken))
            {
                customer.FcmTokens.Remove(fcmToken);
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                result.Data = "Delete successful!";
            }
            if (result.Data == null)
            {
                result.Data = "Delete failed!";
            }
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    public async Task<ResultModel> SeenCurrenNoticeCount(Guid customerId)
    {
        var result = new ResultModel();
        try
        {
            var customer = _dbContext.Customers.Where(_ => _.Id == customerId).FirstOrDefault();
            if (customer == null)
            {
                result.Succeed = false;
                result.ErrorMessage = "User not found";
                return result;
            }
            customer.CurrenNoticeCount = 0;
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
            result.Data = customer.Id;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }
}
