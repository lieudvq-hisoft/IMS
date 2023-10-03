using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Model;
using Data.Models;
using Data.Utils.Paging;
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

    public CustomerService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<CustomerSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        try
        {
            var customers = _dbContext.Customer
                .Include(x => x.User)
                .Where(x => !x.IsDeleted)
                .Where(x => MatchString(searchModel, x.User.Email))
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
            .Contains(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase);
    }

    public async Task<ResultModel> Create(CustomerCreateModel model)
    {
        var result = new ResultModel();
        try
        {
            var user = _dbContext.User.Where(x => x.Id == model.UserId && !x.isDelete).FirstOrDefault();
            if (user == null)
            {
                result.Succeed = false;
                result.ErrorMessage = "UserId " + ErrorMessage.ID_NOT_EXISTED;
            }
            else
            {
                var existingCustomer = _dbContext.Customer.Where(x => x.UserId == model.UserId && !x.IsDeleted).FirstOrDefault();
                if (existingCustomer != null)
                {
                    result.Succeed = false;
                    result.ErrorMessage = "Customer with userId " + ErrorMessage.EXISTED;
                }
                else
                {
                    var customer = _mapper.Map<CustomerCreateModel, Customer>(model);
                    _dbContext.Customer.Add(customer);
                    _dbContext.SaveChanges();

                    result.Succeed = true;
                    result.Data = _mapper.Map<CustomerModel>(customer);
                }
            }
        }
        catch (Exception ex)
        {
            result.Succeed = false;
            result.ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }

        return result;
    }
}
