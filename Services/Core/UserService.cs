using AutoMapper;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Services.Utilities;
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

        var user = _dbContext.User.FirstOrDefault(x => x.UserName == model.Username && x.EmailConfirmed);

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
            var user = _dbContext.User.FirstOrDefault(x => x.Email == model.Email || x.PhoneNumber == model.PhoneNumber);
            if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                user.UserName = model.UserName;
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
}
