﻿using AutoMapper;
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
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;

public interface ICustomerService
{
    Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> Create(CustomerCreateModel model);
}

public class CustomerService : ICustomerService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<Role> _roleManager;

    public CustomerService(AppDbContext dbContext, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> roleManager)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
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
