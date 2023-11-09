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

namespace Services.Core;
public interface IRequestService
{
    Task<ResultModel> Get(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> CreateRequest(RequestCreateModel model);
    Task<ResultModel> UpdateRequest(RequestUpdateModel model);
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
            var requests = _dbContext.Requests
                .Include(x => x.ServiceRequests.Where(x => searchModel.Status != null ? searchModel.Status.Contains(x.Request.Status) : true)).ThenInclude(x => x.Service)
                .Where(x => ((x.Status != RequestStatus.Pending &&
                    x.Status != RequestStatus.Stopped) || x.ServiceRequests.Any(_ => _.Status != ServiceRequestStatus.Accepted)) && x.Status != RequestStatus.Ended)
                .Where(delegate (Request x)
                {
                    var matchStatus = searchModel.Status != null ? searchModel.Status.Contains(x.Status) : true;
                    var matchCustomerId = searchModel.CustomerId != null ? x.Id == searchModel.CustomerId : true;
                    return matchStatus;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requests.Count());

            requests = requests.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requests = requests.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestModel>>(requests.ToList());

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
            var request = _dbContext.Requests
                .Include(x => x.ServiceRequests).ThenInclude(x => x.Service)
                .FirstOrDefault(x => x.Id == id);
            if (request == null)
            {
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<RequestModel>(request);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    
    public async Task<ResultModel> CreateRequest(RequestCreateModel model)
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
                var request = new Request
                {
                    Status = RequestStatus.Incomplete,
                    ExpectedSize = model.ExpectedSize,
                    Note = model.Note,
                    CustomerId = customerId,
                    DateCreated = DateTime.Now,
                };

                _dbContext.Requests.Add(request);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestModel>(request);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> UpdateRequest(RequestUpdateModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var request = _dbContext.Requests.FirstOrDefault(x => x.Id == model.Id);
            if (request == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }

            //if (validPrecondition && request.Status != RequestStatus.Pending)
            //{
            //    validPrecondition = false;
            //    result.ErrorMessage = RequestErrorMessage.UPDATE_NON_PENDING;
            //}

            if (validPrecondition)
            {
                request.ExpectedSize = model.ExpectedSize;
                request.Note = model.Note;
                request.InspectorNote = model.InspectorNote;
                request.DateCreated = DateTime.Now;

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
