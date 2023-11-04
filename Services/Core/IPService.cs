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
    Task<ResultModel> AttempAssignIp(int requestId, int ipId, IDbContextTransaction transaction);
}

public class IpService : IIpService
{
    private readonly AppDbContext _dbContext;

    public IpService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResultModel> AttempAssignIp(int requestId, int ipId, IDbContextTransaction transaction)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var request = _dbContext.Requests.Include(x => x.Server).FirstOrDefault(x => x.Id == requestId && x.Status == RequestStatus.Pending);
            if (request == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            if (request.Status != RequestStatus.Pending)
            {
                validPrecondition = false;
                result.ErrorMessage = IpErrorMessage.ASSIGN_IP_TO_NON_PENDING_REQUEST;
            }
            if (request.ServerId == null)
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
            if (ip.IpAssignments.Any(x => x.Status == IpAssignmentStatus.Ongoing || x.Status == IpAssignmentStatus.Pending))
            {
                validPrecondition = false;
                result.ErrorMessage = IpErrorMessage.NOT_AVAILABLE;
            }

            if (validPrecondition)
            {
                var ipAssignment = new IpAssignment
                {
                    ServerId = request.ServerId.Value,
                    IpId = ip.Id,
                    DateAssign = DateTime.Now,
                    Status = IpAssignmentStatus.Pending
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
