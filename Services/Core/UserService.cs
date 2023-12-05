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
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services.Core;

public interface IUserService
{
    Task<ResultModel> Login(LoginModel model);
    Task<ResultModel> Register(UserCreateModel model);
    Task<ResultModel> ActivateUser(string email);
    Task<ResultModel> GetAccountInfo(string email);
    Task<ResultModel> UpdateAccountInfo(UserUpdateModel model);
    Task<ResultModel> Delete(Guid id);
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, UserSearchModel searchModel);
    Task<ResultModel> GetDetail(string id);
}
public class UserService : IUserService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public UserService(AppDbContext dbContext, IMapper mapper, IConfiguration config, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _config = config;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<ResultModel> Login(LoginModel model)
    {
        var result = new ResultModel();

        var user = _dbContext.User.FirstOrDefault(x => x.UserName == model.Username);

        if (user != null)
        {
            var check = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (check.Succeeded)
            {
                var userRoles = _dbContext.UserRole.Where(ur => ur.UserId == user.Id).ToList();
                var roles = new List<string>();
                foreach (var userRole in userRoles)
                {
                    var role = await _dbContext.Role.FindAsync(userRole.RoleId);
                    if (role != null) roles.Add(role.Name);
                }
                var token = await GetAccessToken(user, roles);
                result.Succeed = true;
                result.Data = token;
            }
            else
            {
                result.Succeed = false;
                result.ErrorMessage = UserErrorMessage.ERROR_PASSWORD;
            }
        }
        else
        {
            result.ErrorMessage = UserErrorMessage.LOGIN_ERROR;
        }
        return result;
    }

    private async Task<Token> GetAccessToken(User user, List<string> roles)
    {
        List<Claim> claims = GetClaims(user, roles);
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
            UserID = user.Id.ToString(),
            UserName = user.UserName,
            PhoneNumber = user.PhoneNumber,
            CurrenNoticeCount = user.CurrenNoticeCount,
            //Role = user.Role
        };
    }

    private List<Claim> GetClaims(User user, List<string> roles)
    {
        IdentityOptions _options = new IdentityOptions();
        var claims = new List<Claim> {
            new Claim("UserId", user.Id.ToString()),
            new Claim("Email", user.Email),
            new Claim("FullName", user.Fullname),
            new Claim("UserName", user.UserName)
        };

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        if (!string.IsNullOrEmpty(user.PhoneNumber)) claims.Add(new Claim("PhoneNumber", user.PhoneNumber));
        return claims;
    }

    public async Task<ResultModel> GetAccountInfo(string email)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User.FirstOrDefault(x => x.Email == email && x.EmailConfirmed);

            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Succeed = true;
                result.Data = _mapper.Map<UserModel>(user);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> ChangePassword(UserChangePasswordModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _userManager.ResetPasswordAsync(user, token, model.Password);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;

    }

    public async Task<ResultModel> Register(UserCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            // Check for duplicate user by email or phonenumber
            var existingUser = _dbContext.User.FirstOrDefault(x => x.Email == model.Email || x.PhoneNumber == model.PhoneNumber);
            if (existingUser != null)
            {
                result.ErrorMessage = UserErrorMessage.EXISTED;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                // Not able to create a customer
                if (model.Roles.Exists(x => x == "Customer"))
                {
                    result.ErrorMessage = UserErrorMessage.CREATE_CUSTOMER;
                    validPrecondition = false;
                }
            }

            if (validPrecondition)
            {
                var roles = new List<Role>();
                foreach (string role in model.Roles)
                {
                    roles.Add(await _dbContext.Role.FirstOrDefaultAsync(r => r.Name == role));
                }

                var user = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Fullname = model.Fullname,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    IsDeleted = false,
                    NormalizedEmail = model.Email.ToLower(),
                    EmailConfirmed = true
                };
                var createUserResult = await _userManager.CreateAsync(user, model.Password);

                if (createUserResult.Succeeded)
                {
                    foreach (Role role in roles)
                    {
                        var userRole = new UserRole
                        {
                            RoleId = role.Id,
                            UserId = user.Id
                        };
                        _dbContext.UserRole.Add(userRole);
                        await _dbContext.SaveChangesAsync();
                    }

                    result.Succeed = true;
                    result.Data = _mapper.Map<UserModel>(user);
                }
                else
                {
                    result.Succeed = false;
                    result.ErrorMessage = UserErrorMessage.REGISTER_FAILED;
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> UpdateAccountInfo(UserUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User.FirstOrDefault(x => x.Id == model.Id);
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                user.Email = model.Email;
                user.Fullname = model.Fullname;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;
                user.NormalizedEmail = model.Email.ToLower();
                var updateUserResult = await _userManager.UpdateAsync(user);

                if (updateUserResult.Succeeded)
                {
                    result.Succeed = true;
                    result.Data = _mapper.Map<UserModel>(user);
                }
                else
                {
                    result.Succeed = false;
                    result.ErrorMessage = UserErrorMessage.UPDATE_FAILED;
                }
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
            var user = _dbContext.User.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                user.IsDeleted = true;
                var updateUserResult = await _userManager.UpdateAsync(user);

                if (updateUserResult.Succeeded)
                {
                    result.Succeed = true;
                    result.Data = _mapper.Map<UserModel>(user);
                }
                else
                {
                    result.Succeed = false;
                    result.ErrorMessage = UserErrorMessage.DELETE_FAILED;
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> ActivateUser(string email)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User.FirstOrDefault(x => x.Email == email && !x.EmailConfirmed);

            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                user.EmailConfirmed = true;
                _dbContext.SaveChanges();
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, UserSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var users = _dbContext.Users
                .Where(delegate (User x)
                {
                    return MatchString(searchModel.SearchValue, x.Email)
                    || MatchString(searchModel.SearchValue, x.UserName);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, users.Count());

            users = users.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            users = users.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<UserModel>>(users.ToList());

            result.Data = paging;
            result.Succeed = true;
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

    public async Task<ResultModel> GetDetail(string id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User
                .FirstOrDefault(x => x.Id == new Guid(id));
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<UserModel>(user);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAssignRequestExpand(string userId, PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User
                .FirstOrDefault(x => x.Id == new Guid(userId));
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestExpands = _dbContext.RequestExpands
                    .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location)
                    .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment)
                    .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                    .Include(x => x.RequestExpandUsers).ThenInclude(x => x.User)
                    .Where(x => x.RequestExpandUsers.Any(x => x.UserId == new Guid(userId) && x.Action == RequestUserAction.Execute))
                    .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                    .AsQueryable();

                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpands.Count());

                requestExpands = requestExpands.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                requestExpands = requestExpands.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

                paging.Data = _mapper.Map<List<RequestExpandModel>>(requestExpands.ToList());

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

    public async Task<ResultModel> GetAssignRequestUpgrade(string userId, PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User
                .FirstOrDefault(x => x.Id == new Guid(userId));
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestUpgrades = _dbContext.RequestUpgrades
                     .Include(x => x.Component)
                     .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                     .Include(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                     .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                     .Where(x => x.RequestUpgradeUsers.Any(x => x.UserId == new Guid(userId) && x.Action == RequestUserAction.Execute))
                     .Where(delegate (RequestUpgrade x)
                     {
                         return x.FilterRequestUpgrade(searchModel);
                     })
                     .AsQueryable();

                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgrades.Count());

                requestUpgrades = requestUpgrades.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                requestUpgrades = requestUpgrades.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

                paging.Data = _mapper.Map<List<RequestUpgradeModel>>(requestUpgrades.ToList());

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

    public async Task<ResultModel> GetCustomer(Guid userId, PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        var customers = _dbContext.Customers.Include(x => x.UserCustomers)
            .Where(x => x.UserCustomers.Any(x => x.UserId == userId))
            //.Where(delegate (Customer x)
            //{
            //    return MyFunction.MatchString(searchModel.CompanyName, x.CustomerName);
            //})
            .AsQueryable();

        var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, customers.Count());

        customers = customers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
        customers = customers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

        paging.Data = _mapper.Map<List<CustomerModel>>(customers.ToList());

        result.Data = paging;
        result.Succeed = true;

        return result;
    }
}
