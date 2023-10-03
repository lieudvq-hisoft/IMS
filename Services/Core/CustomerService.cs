using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;

public interface ICustomerService
{

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

    //public ResultModel Get(PagingParam<NotificationSortCriteria> paginationModel)
    //{
    //    var result = new ResultModel();
    //    try
    //    {
    //        var customers = _dbContext.Customer
    //            .Include(_ => _.User)
    //            .Where(_ => !_.IsDeleted);

    //        var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, customers.Count());

    //        customers = customers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
    //        customers = customers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

    //        var viewModels = _mapper.ProjectTo<NotificationModel>(customers).ToList();

    //        paging.Data = viewModels;

    //        result.Data = paging;
    //        result.Succeed = true;
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
    //    }
    //    return result;
    //}
}
