using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
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
                .Include(_ => _.User)
                .Where(_ => !_.IsDeleted)
                .Where(delegate (Customer c)
                {
                    if ((MyFunction.ConvertToUnSign(c.User.Email ?? "").IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0))
                        return true;
                    else
                        return false;
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
}
