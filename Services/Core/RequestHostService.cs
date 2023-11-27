using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Entities.Pending;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;

namespace Services.Core;
public interface IRequestHostService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(RequestHostCreateModel model);
    Task<ResultModel> Update(RequestHostUpdateModel model);
    Task<ResultModel> Evaluate(int requestHostId, RequestStatus status, UserAssignModel model);
    Task<ResultModel> EvaluateBulk(RequestHostEvaluateBulkModel model, RequestStatus status);
}

public class RequestHostService : IRequestHostService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestHostService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHosts = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestHostUsers).ThenInclude(x => x.User)
                 .Where(delegate (RequestHost x)
                 {
                     return x.FilterRequestHost(searchModel);
                 })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestHosts.Count());

            requestHosts = requestHosts.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestHosts = requestHosts.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestHostModel>>(requestHosts.ToList());

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
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestHostUsers).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == id);

            if (requestHost != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostModel>(requestHost);
            }
            else
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestHostCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (!serverAllocation.IpAssignments.Any(x => x.Type == IpAssignmentTypes.Master))
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_MASTER_IP;
            }
            else if (model.Type == IpAssignmentTypes.Master)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.HAVE_IP_MASTER_ALREADY;
            }
            else
            {
                var requestHost = _mapper.Map<RequestHost>(model);
                requestHost.Status = RequestStatus.Waiting;
                _dbContext.RequestHosts.Add(requestHost);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostResultModel>(requestHost);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(RequestHostUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => IpAddress)
                .FirstOrDefault(x => x.Id == model.Id && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            var serverAllocation = requestHost.ServerAllocation;
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (!serverAllocation.IpAssignments.Any(x => x.Type == IpAssignmentTypes.Master))
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_MASTER_IP;
            }
            else if (model.Type == IpAssignmentTypes.Master)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.HAVE_IP_MASTER_ALREADY;
            }
            else
            {
                _mapper.Map<RequestHostUpdateModel, RequestHost>(model, requestHost);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostResultModel>(requestHost);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Evaluate(int requestHostId, RequestStatus status, UserAssignModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            if (status != RequestStatus.Accepted && status != RequestStatus.Denied)
            {
                throw new Exception(ErrorMessage.WRONG_PURPOSE);
            }

            var requestHost = _dbContext.RequestHosts.FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition && requestHost.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                requestHost.Status = status;
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    RequestHostId = requestHost.Id,
                    UserId = new Guid(model.UserId)
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostModel>(requestHost);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> EvaluateBulk(RequestHostEvaluateBulkModel model, RequestStatus status)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            var userAssignModel = new UserAssignModel
            {
                UserId = model.UserId
            };
            foreach (var requestHostId in model.RequestHostIds)
            {

                results.Add(await Evaluate(requestHostId, status, userAssignModel));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}