using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Model;
using Data.Models;
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

    public ServerService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
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
                    NumberOfPort = model.NumberOfPort,
                    Status = Data.Enums.DeviceStatus.Pending,
                    Size = model.Size,
                    BasePower = model.BasePower
                };
                _dbContext.Devices.Add(device);

                _dbContext.Servers.Add(new Server
                {
                    DeviceId = device.Id,
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
