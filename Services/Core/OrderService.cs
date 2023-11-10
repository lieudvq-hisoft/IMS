using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Services.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Services.Core;
public interface IOrderService
{
    Task<ResultModel> Get(PagingParam<OrderSortCriteria> paginationModel, OrderSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(OrderCreateModel model);
    Task<ResultModel> Update(OrderUpdateModel model);
}

public class OrderService : IOrderService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public OrderService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<OrderSortCriteria> paginationModel, OrderSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var orders = _dbContext.Orders
                .Where(delegate (Order x)
                {
                    var matchStatus = searchModel.Status != null ? searchModel.Status.Contains(x.Status) : true;
                    var matchCustomerId = searchModel.CustomerId != null ? x.Id == searchModel.CustomerId : true;
                    return matchStatus;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, orders.Count());

            orders = orders.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            orders = orders.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<OrderModel>>(orders.ToList());

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
            var request = _dbContext.Orders
                .Include(x => x.Requests).ThenInclude(x => x.Service)
                .FirstOrDefault(x => x.Id == id);
            if (request == null)
            {
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<OrderModel>(request);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }


    public async Task<ResultModel> Create(OrderCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        var customerId = model.CustomerId;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer == null)
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
            }

            else
            {
                var order = new Order
                {
                    Status = OrderStatus.Incomplete,
                    ExpectedSize = model.ExpectedSize,
                    Note = model.Note,
                    CustomerId = customerId,
                    DateCreated = DateTime.Now,
                };

                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<OrderModel>(order);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(OrderUpdateModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var order = _dbContext.Orders.FirstOrDefault(x => x.Id == model.Id);
            if (order == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                order.ExpectedSize = model.ExpectedSize;
                order.Note = model.Note;
                order.InspectorNote = model.InspectorNote;
                order.DateCreated = DateTime.Now;

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
