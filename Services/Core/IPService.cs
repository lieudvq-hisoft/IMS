using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;

namespace Services.Core;
public interface IIpService
{
    Task<ResultModel> AttempAssignIp(int colocationId, int ipId, IDbContextTransaction transaction);
}

public class IpService : IIpService
{
    private readonly AppDbContext _dbContext;

    public IpService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResultModel> AttempAssignIp(int colocationId, int ipId, IDbContextTransaction transaction)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var colocation = _dbContext.Colocations.Include(x => x.Server).FirstOrDefault(x => x.Id == colocationId && x.Status == ColocationStatus.Pending);
            if (colocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ColocationErrorMessage.NOT_EXISTED;
            }
            if (colocation.Status != ColocationStatus.Pending)
            {
                validPrecondition = false;
                result.ErrorMessage = IpErrorMessage.ASSIGN_IP_TO_NON_PENDING_REQUEST;
            }
            if (colocation.ServerId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = IpErrorMessage.ASSIGN_IP_TO_REQUEST_WITHOUT_SERVER;
            }

            var ip = _dbContext.Ips.Include(x => x.IpAssignments).FirstOrDefault(x => x.Id == ipId);
            if (ip == null)
            {
                validPrecondition = false;
                result.ErrorMessage = IpErrorMessage.NOT_EXISTED;
            }
            if (ip.IpAssignments.Any(x => x.IsActive))
            {
                validPrecondition = false;
                result.ErrorMessage = IpErrorMessage.NOT_AVAILABLE;
            }

            if (validPrecondition)
            {
                var ipAssignment = new IpAssignment
                {
                    ServerId = colocation.ServerId.Value,
                    IpId = ip.Id,
                    DateAssign = DateTime.Now,
                    IsActive = true
                };
                _dbContext.IpAssignments.Add(ipAssignment);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = ipAssignment;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
