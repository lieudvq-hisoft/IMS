﻿using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;

namespace Services.Core;
public interface IServerService
{
    Task<ResultModel> AttempCreateServer(int colocationId, ServerCreateModel model, IDbContextTransaction transaction);
    Task<ResultModel> Get(PagingParam<ServerSortCriteria> paginationModel, ServerSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
}

public class ServerService : IServerService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public ServerService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<ServerSortCriteria> paginationModel, ServerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var servers = _dbContext.Servers
                .Include(x => x.Colocation)
                .ThenInclude(x => x.Customer)
                .ThenInclude(x => x.User)
                .Include(x => x.Device)
                .Include(x => x.IpAssignments)
                .ThenInclude(x => x.Ip)
                .ThenInclude(x => x.Network)
                .Where(x => x.Colocation.Status != ColocationStatus.Denied && x.Colocation.Status != ColocationStatus.Incomplete)
                .Where(delegate (Server x)
                {
                    return searchModel.Status != null ? x.Colocation.Status.ToString() == searchModel.Status.ToString() : true;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, servers.Count());

            servers = servers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            servers = servers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<ServerModel>>(servers);

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
            var server = _dbContext.Servers
                .Include(x => x.Colocation).ThenInclude(x => x.Customer).ThenInclude(x => x.User)
                .Include(x => x.Colocation).ThenInclude(x => x.ColocationHistories)
                .Include(x => x.Colocation).ThenInclude(x => x.AdditionalServices).ThenInclude(x => x.Approver).ThenInclude(x => x.User)
                .Include(x => x.Colocation).ThenInclude(x => x.AdditionalServices).ThenInclude(x => x.Executor).ThenInclude(x => x.User)
                .Include(x => x.IpAssignments).ThenInclude(x => x.Ip).ThenInclude(x => x.Network)
                .Include(x => x.Device).ThenInclude(x => x.Locations).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                .FirstOrDefault(x => x.Id == id && x.Colocation.Status != ColocationStatus.Denied && x.Colocation.Status != ColocationStatus.Incomplete);

            if (server == null)
            {
                result.ErrorMessage = ServerErrorMessgae.NOT_EXISTED;
            }
            else
            {
                var serverModel = _mapper.Map<ServerDetailModel>(server);
                serverModel.AdditionalServices = _mapper.Map<List<AdditionalServiceModel>>(server.Colocation.AdditionalServices);

                result.Data = serverModel;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AttempCreateServer(int colocationId, ServerCreateModel model, IDbContextTransaction transaction)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var colocation = _dbContext.Colocations.FirstOrDefault(x => x.Id == colocationId && x.Status == ColocationStatus.Incomplete);
            if (colocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ColocationErrorMessage.NOT_EXISTED;
            }

            var existingServer = _dbContext.Servers.FirstOrDefault(x => x.SerialNumber == model.SerialNumber);
            if (existingServer != null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerErrorMessgae.EXISTED;
            }

            if (validPrecondition)
            {
                var device = new Device
                {
                    Type = "Server",
                    Size = model.Size,
                    AdditionalSize = 0,
                    BasePower = model.BasePower,
                    AdditionalPower = 0
                };
                _dbContext.Devices.Add(device);
                _dbContext.SaveChanges();

                var server = new Server
                {
                    DeviceId = device.Id,
                    NumberOfPort = model.NumberOfPort,
                    AdditionalNumberOfPort = 0,
                    SerialNumber = model.SerialNumber,
                    Model = model.Model,
                };
                _dbContext.Servers.Add(server);
                _dbContext.SaveChanges();

                colocation.ServerId = server.Id;
                colocation.Status = ColocationStatus.Pending;

                result.Succeed = true;
                result.Data = device;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
