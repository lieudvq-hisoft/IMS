using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IRequestService
{
    Task<ResultModel> Get(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel);
    Task<ResultModel> Create(RequestCreateModel model);
    Task<ResultModel> Delete(int id);
}

public class RequestService : IRequestService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            //var requests = _dbContext.Requests
            //    .Include(x => x.Service)
            //    .Where(delegate (Request x)
            //    {
            //        return FilterRequest(x, searchModel);
            //    })
            //    .AsQueryable();

            //var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requests.Count());

            //requests = requests.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            //requests = requests.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            //paging.Data = _mapper.ProjectTo<RequestModel>(requests).ToList();

            //result.Data = paging;
            //result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private static bool FilterRequest(Request service, RequestSearchModel searchModel)
    {
        bool matchType = true;
        if (searchModel.Type != null)
        {
            matchType = service.Service.Type == searchModel.Type;
        }
        bool matchStatus = true;
        if (searchModel.Status != null)
        {
            matchStatus = service.Status == searchModel.Status;
        }
        bool matchRequest = true;
        if (searchModel.OrderId != null)
        {
            //matchRequest = service.OrderId == searchModel.OrderId;
        }
        return matchRequest && matchStatus && matchType;
    }

    public async Task<ResultModel> Create(RequestCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            //var order = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.OrderId);
            //if (order == null)
            //{
            //    result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            //}
            //else
            //{
            //    var service = new Request
            //    {
            //        Status = ServiceStatus.Incomplete,
            //        OrderId = model.OrderId,
            //        IsDelegated = model.IsDelegated,
            //    };

            //    _dbContext.Requests.Add(service);
            //    _dbContext.SaveChanges();

            //    result.Succeed = true;
            //    result.Data = _mapper.Map<RequestModel>(service);
            //}
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            //var request = _dbContext.Requests.FirstOrDefault(x => x.Id == id);
            //if (request == null)
            //{
            //    result.ErrorMessage = ServiceErrorMessage.NOT_EXISTED;
            //}
            //else
            //{
            //    request.IsDeleted = true;
            //    request.DateUpdated = DateTime.Now;
            //    _dbContext.SaveChanges();
            //    result.Succeed = true;
            //    result.Data = request.Id;
            //}
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
