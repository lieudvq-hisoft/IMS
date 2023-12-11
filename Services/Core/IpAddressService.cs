using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;

namespace Services.Core;
public interface IIpAddressService
{
    Task<ResultModel> Get(PagingParam<SimpleSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetServerAllocation(int ipAddressId, PagingParam<BaseSortCriteria> paginationModel, ServerAllocationSearchModel searchModel);
    Task<ResultModel> GetIsBlockedCount();
    Task<ResultModel> GetIsReservedCount();
    Task<ResultModel> GetCustomer(int ipAddressId, PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel);
    Task<ResultModel> SuggestMasterIp();
    Task<ResultModel> ChangeBlockingStatus(IpAddressIdListModel model, bool isBlock);
    Task<ResultModel> ChangePurpose(IpAddressChangePurposeModel model);
}

public class IpAddressService : IIpAddressService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public IpAddressService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<SimpleSortCriteria> paginationModel, IpAddressSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAddresses = _dbContext.IpAddresses
                .Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                .Where(delegate (IpAddress x)
                {
                    return x.Filter(searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, ipAddresses.Count());

            ipAddresses = ipAddresses.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            ipAddresses = ipAddresses.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<IpAddressModel>>(ipAddresses.ToList());

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
            var ipAddress = _dbContext.IpAddresses.Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer).FirstOrDefault(x => x.Id == id);

            if (ipAddress != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpAddressModel>(ipAddress);
            }
            else
            {
                result.Succeed = false;
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetServerAllocation(int ipAddressId, PagingParam<BaseSortCriteria> paginationModel, ServerAllocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAddress = _dbContext.IpAddresses.FirstOrDefault(x => x.Id == ipAddressId);
            if (ipAddress == null)
            {
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
            }
            else
            {
                var serverAllocations = _dbContext.ServerAllocations
                    .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                    .Include(x => x.Customer)
                    .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                    .Where(x => x.IpAssignments.Any(x => x.IpAddressId == ipAddressId))
                    .Where(delegate (ServerAllocation x)
                    {
                        var matchStatus = searchModel.Status != null ? searchModel.Status.Contains(x.Status) : true;
                        var matchCustomerId = searchModel.CustomerId != null ? x.CustomerId == searchModel.CustomerId : true;
                        return matchStatus;
                    })
                    .AsQueryable();

                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, serverAllocations.Count());

                serverAllocations = serverAllocations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                serverAllocations = serverAllocations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

                paging.Data = _mapper.Map<List<ServerAllocationModel>>(serverAllocations.ToList());

                result.Data = paging;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetCustomer(int ipAddressId, PagingParam<BaseSortCriteria> paginationModel, CustomerSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAddress = _dbContext.IpAddresses.FirstOrDefault(x => x.Id == ipAddressId);
            if (ipAddress == null)
            {
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
            }
            else
            {
                var customers = _dbContext.Customers
                    .Include(x => x.ServerAllocations).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                    .Where(x => x.ServerAllocations.Any(x => x.IpAssignments.Any(x => x.IpAddressId == ipAddressId)))
                    //.Where(delegate (Customer x)
                    //{
                    //    return MyFunction.MatchString(searchModel.CompanyName, x.CustomerName);
                    //})
                    .AsQueryable();

                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, customers.Count());

                customers = customers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                customers = customers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

                paging.Data = _mapper.Map<List<CustomerModel>>(customers.ToList());

                result.Data = paging;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetIsReservedCount()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            result.Succeed = true;
            result.Data = _dbContext.IpAddresses.Where(x => x.IsReserved).Count();
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetIsBlockedCount()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            result.Succeed = true;
            result.Data = _dbContext.IpAddresses.Where(x => x.Blocked).Count();
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> SuggestMasterIp()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var suggestedMasterIp = _dbContext.IpAddresses
                .Include(x => x.IpAssignments)
                .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                .Where(x => !x.IsReserved && !x.Blocked && !x.IpAssignments.Any())
                .OrderBy(x => x.Address)
                .FirstOrDefault(x => !x.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed));

            if (suggestedMasterIp == null)
            {
                result.ErrorMessage = IpAddressErrorMessage.NO_AVAILABLE;
            }
            else
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpAddressResultModel>(suggestedMasterIp);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> ChangeBlockingStatus(IpAddressIdListModel model, bool isBlock)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAddresses = _dbContext.IpAddresses
                .Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation)
                .Where(x => model.IpAddressIds.Contains(x.Id) && x.Blocked == !isBlock)
                .ToList();
            if (ipAddresses.Count() != model.IpAddressIds.Count())
            {
                result.ErrorMessage = $"Not all ip valid to be {(isBlock ? "block" : "unblock")}";
            }
            else
            {
                ipAddresses.ForEach(x =>
                {
                    var masterIpServer = x.IpAssignments.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.ServerAllocation;
                    if (masterIpServer != null)
                    {
                        if (isBlock)
                        {
                            masterIpServer.Status = ServerAllocationStatus.Pausing;
                        }
                        else
                        {
                            masterIpServer.Status = ServerAllocationStatus.Working;
                        }
                    }
                    x.Blocked = isBlock;
                    x.Reason = model.Reason;
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<IpAddressResultModel>>(ipAddresses);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> ChangePurpose(IpAddressChangePurposeModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAddresses = _dbContext.IpAddresses
                .Where(x => model.IpAddressIds.Contains(x.Id) && !x.Blocked && !x.IsReserved)
                .ToList();
            if (ipAddresses.Count() != model.IpAddressIds.Count())
            {
                result.ErrorMessage = $"Not all ip valid";
            }
            else if (model.Purpose == IpPurpose.Network && model.Purpose == IpPurpose.Broadcast)
            {
                result.ErrorMessage = "Cannot change purpose to network or broadcast";
            }
            else if (ipAddresses.Any(x => x.IpAssignments.Any()))
            {
                result.ErrorMessage = "Cannot change purpose of assigned ip address";
            }
            else if (ipAddresses.Any(x => x.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed)))
            {
                result.ErrorMessage = "Cannot change purpose of requested ip address";
            }
            else
            {
                ipAddresses.ForEach(x =>
                {
                    x.Purpose = model.Purpose;
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<IpAddressResultModel>>(ipAddresses);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
