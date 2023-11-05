using AutoMapper;
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
    Task<ResultModel> Get(IpAssignmentSearchModel searchModel);
}

public class IpService : IIpService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public IpService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
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

    public async Task<ResultModel> Get(IpAssignmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAssignments = _dbContext.IpAssignments.Include(x => x.Ip).ThenInclude(x => x.Network)
                .Where(x => x.Status != IpAssignmentStatus.Denied)
                .Where(delegate (IpAssignment x)
                {
                    bool matchServer = searchModel.ServerId != null ? x.ServerId == searchModel.ServerId.Value : true;
                    bool matchType = x.Type == searchModel.Type;
                    return matchServer && matchType;
                })
                .ToList();

            result.Data = _mapper.Map<List<IpAssignmentModel>>(ipAssignments);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }
}
