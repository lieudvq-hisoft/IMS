﻿using AutoMapper;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities.Pending;
using Data.Enums;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;

namespace Services.Core;
public interface IRequestHostService
{
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

    public async Task<ResultModel> AssignIp(int serverAllocationId, RequestHostIpAssignmentModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private async Task<ResultModel> AssignOneIp(int serverAllocationId, int ipAddressId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}