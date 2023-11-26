using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IServerAllocationService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, ServerAllocationSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetHardwareConfig(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestUpgrade(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetLocationAssignment(int id);
    Task<ResultModel> GetIpAssignment(int id);
    Task<ResultModel> GetLocation(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetAppointment(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> Create(ServerAllocationCreateModel model);
    Task<ResultModel> Update(ServerAllocationUpdateModel model);
    Task<ResultModel> Delete(int serverAllocationId);
}

public class ServerAllocationService : IServerAllocationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public ServerAllocationService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, ServerAllocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocations = _dbContext.ServerAllocations.Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress).Include(x => x.Customer)
                .Where(delegate (ServerAllocation x)
                {
                    var matchStatus = searchModel.Status != null ? searchModel.Status.Contains(x.Status) : true;
                    var matchCustomerId = searchModel.CustomerId != null ? x.Id == searchModel.CustomerId : true;
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
            var serverAllocation = _dbContext.ServerAllocations.Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress).Include(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<ServerAllocationModel>(serverAllocation);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetHardwareConfig(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.ServerHardwareConfigs)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var serverHardwareConfigs = serverAllocation.ServerHardwareConfigs.AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, serverHardwareConfigs.Count());
                serverHardwareConfigs = serverHardwareConfigs.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                serverHardwareConfigs = serverHardwareConfigs.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<ServerHardwareConfigModel>>(serverHardwareConfigs.ToList());

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

    public async Task<ResultModel> GetRequestUpgrade(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.Customer)
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.Component)
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestUpgrades).ThenInclude(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestUpgrades = serverAllocation.RequestUpgrades.AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgrades.Count());
                requestUpgrades = requestUpgrades.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                requestUpgrades = requestUpgrades.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<RequestUpgradeModel>>(requestUpgrades.ToList());

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

    public async Task<ResultModel> GetRequestExpand(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.Customer)
                .Include(x => x.RequestExpands).ThenInclude(x => x.RequestExpandLocations)
                .Include(x => x.RequestExpands).ThenInclude(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestExpands).ThenInclude(x => x.RequestExpandUsers).ThenInclude(x => x.User)
                .Include(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestExpands = serverAllocation.RequestExpands.AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpands.Count());
                requestExpands = requestExpands.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                requestExpands = requestExpands.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<RequestExpandModel>>(requestExpands.ToList());

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

    public async Task<ResultModel> GetLocationAssignment(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.Include(x => x.LocationAssignments).FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(serverAllocation.LocationAssignments);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetIpAssignment(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.Include(x => x.IpAssignments).FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(serverAllocation.LocationAssignments);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetLocation(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.LocationAssignments)
                .ThenInclude(x => x.Location)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var locations = serverAllocation.LocationAssignments.Select(x => x.Location).AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, locations.Count());
                locations = locations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                locations = locations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<LocationModel>>(locations.ToList());

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

    public async Task<ResultModel> GetAppointment(PagingParam<BaseSortCriteria> paginationModel, int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.Customer).Include(x => x.Appointments)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var appointments = serverAllocation.Appointments.AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());
                appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);
                paging.Data = _mapper.Map<List<AppointmentModel>>(appointments.ToList());

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

    public async Task<ResultModel> Create(ServerAllocationCreateModel model)
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

            var existingServerAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.SerialNumber == model.SerialNumber);
            if (existingServerAllocation != null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.EXISTED;
            }

            if (validPrecondition)
            {
                var serverAllocation = _mapper.Map<ServerAllocation>(model);
                serverAllocation.Status = ServerAllocationStatus.Working;

                _dbContext.ServerAllocations.Add(serverAllocation);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<ServerAllocationModel>(serverAllocation);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(ServerAllocationUpdateModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.Id);
            if (serverAllocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                _mapper.Map<ServerAllocationUpdateModel, ServerAllocation>(model, serverAllocation);

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

    public async Task<ResultModel> Delete(int serverAllocationId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.RequestExpands)
                .Include(x => x.RequestUpgrades)
                .Include(x => x.LocationAssignments)
                .Include(x => x.Appointments)
                .Include(x => x.RequestHosts)
                .Include(x => x.IpAssignments)
                .FirstOrDefault(x => x.Id == serverAllocationId);
            if (serverAllocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                serverAllocation.Status = ServerAllocationStatus.Removed;
                foreach (var appointment in serverAllocation.Appointments.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    appointment.Status = RequestStatus.Failed;
                }
                foreach (var requestExpand in serverAllocation.RequestExpands.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    requestExpand.Status = RequestStatus.Failed;
                }
                foreach (var requestHost in serverAllocation.RequestHosts.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    requestHost.Status = RequestStatus.Failed;
                }
                foreach (var requestUpgrade in serverAllocation.RequestUpgrades.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    requestUpgrade.Status = RequestStatus.Failed;
                }
                _dbContext.IpAssignments.RemoveRange(serverAllocation.IpAssignments);
                _dbContext.LocationAssignments.RemoveRange(serverAllocation.LocationAssignments);
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

    public async Task<ResultModel> AssignMasterIp(int serverAllocationId, int ipAddressId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.Include(x => x.IpAssignments).FirstOrDefault(x => x.Id == serverAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.IpAssignments.Any(x => x.Type == IpAssignmentTypes.Master))
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.HAVE_IP_MASTER_ALREADY;
            }

            var ipAddress = _dbContext.IpAddresses.Include(x => x.IpAssignments)
                .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                .FirstOrDefault(x => x.Id == ipAddressId);
            if (ipAddress == null)
            {
                validPrecondition = false;
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
            }
            else
            {
                if (ipAddress.IsReserved || ipAddress.Blocked)
                {
                    validPrecondition = false;
                    result.ErrorMessage = IpAddressErrorMessage.UNASSIGNABLE;
                }

                if (ipAddress.IpAssignments.Any() || ipAddress.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    validPrecondition = false;
                    result.ErrorMessage = IpAddressErrorMessage.UNAVAILABLE;
                }
            }

            if (validPrecondition)
            {
                var ipAssignment = new IpAssignment
                {
                    Type = IpAssignmentTypes.Master,
                    ServerAllocationId = serverAllocation.Id,
                    IpAddressId = ipAddress.Id,
                };
                _dbContext.IpAssignments.Add(ipAssignment);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<IpAssignmentResultModel>(ipAssignment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
