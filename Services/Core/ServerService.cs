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
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;

namespace Services.Core;
public interface IServerService
{
    Task<ResultModel> AttempCreateServer(ServerCreateModel model, IDbContextTransaction transaction);
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
                .ThenInclude(x => x.NetworkId)
                .Where(x => x.Colocation.Status == ColocationStatus.Ongoing || x.Colocation.Status == ColocationStatus.Stopped || x.Colocation.Status == ColocationStatus.Ended)
                .Where(delegate (Server x)
                {
                    return searchModel.Status != null ? x.Colocation.Status.ToString() == searchModel.Status.ToString() : true;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, servers.Count());

            servers = servers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            servers = servers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<ServerModel>(servers).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> AttempCreateServer(ServerCreateModel model, IDbContextTransaction transaction)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var existingServer = _dbContext.Servers.FirstOrDefault(x => x.SerialNumber == model.SerialNumber);
            if (existingServer != null)
            {
                result.ErrorMessage = "Server " + ErrorMessage.EXISTED;
            }
            else
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

                _dbContext.Servers.Add(new Server
                {
                    DeviceId = device.Id,
                    NumberOfPort = model.NumberOfPort,
                    AdditionalNumberOfPort = 0,
                    SerialNumber = model.SerialNumber,
                    Model = model.Model,
                });
                _dbContext.SaveChanges();

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
