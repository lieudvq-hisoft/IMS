using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using DocumentFormat.OpenXml.Packaging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;
using System.Globalization;
using System.Text.Json;

namespace Services.Core;
public interface IServerAllocationService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, ServerAllocationSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetHardwareConfig(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestUpgrade(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestExpand(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestHost(int id, PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel);
    Task<ResultModel> GetLocationAssignment(int id);
    Task<ResultModel> GetIpAddress(int id, PagingParam<SimpleSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> GetLocation(PagingParam<SimpleSortCriteria> paginationModel, int id);
    Task<ResultModel> GetAppointment(int id, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> Create(ServerAllocationCreateModel model, Guid customerId);
    Task<ResultModel> Update(ServerAllocationUpdateModel model);
    Task<ResultModel> AssignMasterIp(int serverAllocationId, ServerAllocationMasterIpAssignmentModel model);
    Task<ResultModel> Confirm(int serverAllocationId);
    Task<ResultModel> AssignInspectionRecordAndReceiptOfRecipientReport(int serverAllocationId, DocumentFileUploadModel model);
}

public class ServerAllocationService : IServerAllocationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;
    private readonly UserManager<User> _userManager;
    private readonly INotificationService _notiService;

    public ServerAllocationService(AppDbContext dbContext, IMapper mapper, ICloudinaryHelper cloudinaryHelper, UserManager<User> userManager, INotificationService notiService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _cloudinaryHelper = cloudinaryHelper;
        _userManager = userManager;
        _notiService = notiService;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, ServerAllocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocations = _dbContext.ServerAllocations
                .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.Customer)
                .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                .Where(delegate (ServerAllocation x)
                {
                    var matchStatus = searchModel.Status != null ? searchModel.Status.Contains(x.Status) : true;
                    var matchCustomerId = searchModel.CustomerId != null ? x.CustomerId == searchModel.CustomerId : true;
                    return matchStatus && matchCustomerId;
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
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.IpAssignments)
                .ThenInclude(x => x.IpAddress)
                .Include(x => x.Customer)
                .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
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
                .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
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
                .Include(x => x.RequestExpands).ThenInclude(x => x.RequestExpandLocations).ThenInclude(x => x.Location)
                .Include(x => x.RequestExpands).ThenInclude(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestExpands).ThenInclude(x => x.RequestExpandUsers).ThenInclude(x => x.User)
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

    public async Task<ResultModel> GetRequestHost(int id, PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestHosts = _dbContext.RequestHosts
                    .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                    .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                    .Include(x => x.RequestHostUsers).ThenInclude(x => x.User)
                    .Where(x => x.ServerAllocationId == id)
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

    public async Task<ResultModel> GetIpAddress(int id, PagingParam<SimpleSortCriteria> paginationModel, IpAddressSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.RequestHosts).ThenInclude(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var ipAddresses = _dbContext.IpAddresses
                    .Include(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                    .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
                    .Where(x => x.IpAssignments.Any(x => x.ServerAllocationId == id))
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
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetLocation(PagingParam<SimpleSortCriteria> paginationModel, int id)
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

    public async Task<ResultModel> GetAppointment(int id, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel)
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
                var appointments = _dbContext.Appointments
                    .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                    .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                    .Include(x => x.AppointmentUsers).ThenInclude(x => x.User)
                    .Include(x => x.RequestExpandAppointments)
                    .Include(x => x.RequestUpgradeAppointment)
                    .Where(x => x.ServerAllocationId == id)
                    .Where(delegate (Appointment x)
                    {
                        return x.FilterAppointment(searchModel);
                    })
                    .AsQueryable();
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

    public async Task<ResultModel> Create(ServerAllocationCreateModel model, Guid customerId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == customerId);
            var existingServerAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.SerialNumber == model.SerialNumber);
            if (existingServerAllocation != null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.EXISTED;
            }
            else
            {
                var serverAllocation = _mapper.Map<ServerAllocation>(model);
                serverAllocation.CustomerId = customerId;
                serverAllocation.Status = ServerAllocationStatus.Waiting;

                _dbContext.ServerAllocations.Add(serverAllocation);
                _dbContext.SaveChanges();
                var requestExpand = new RequestExpand
                {
                    Size = 0,
                    Note = model.Note,
                    ServerAllocationId = serverAllocation.Id
                };
                _dbContext.RequestExpands.Add(requestExpand);
                var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale"));
                var requestExpandModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
                foreach (var sale in sales)
                {
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = sale.Id,
                        Action = "Action",
                        Title = "Title",
                        Body = "Body",
                        Data = new NotificationData
                        {
                            Key = "Key",
                            Value = requestExpandModelString
                        }
                    });
                }
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

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.Id);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.Status != ServerAllocationStatus.Waiting)
            {
                result.ErrorMessage = "Can only update waiting server";
            }
            else if (_dbContext.ServerAllocations.Any(x => x.SerialNumber == model.SerialNumber && x.Id != model.Id))
            {
                result.ErrorMessage = ServerAllocationErrorMessage.EXISTED;
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

    //public async Task<ResultModel> Delete(int serverAllocationId)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        var serverAllocation = _dbContext.ServerAllocations
    //            .Include(x => x.RequestExpands)
    //            .Include(x => x.RequestUpgrades)
    //            .Include(x => x.LocationAssignments)
    //            .Include(x => x.Appointments)
    //            .Include(x => x.RequestHosts)
    //            .Include(x => x.IpAssignments)
    //            .FirstOrDefault(x => x.Id == serverAllocationId);
    //        var locations = _dbContext.LocationAssignments
    //            .IgnoreQueryFilters()
    //            .Where(x => x.ServerAllocationId == serverAllocationId);
    //        if (serverAllocation == null)
    //        {
    //            result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
    //        }
    //        else if (serverAllocation.LocationAssignments.Any())
    //        {
    //            result.ErrorMessage = "Must remove server from rack";
    //        }
    //        else if (locations.Any() && serverAllocation.RemovalFilePath == null)
    //        {
    //            result.ErrorMessage = "Need document for removal";
    //        }
    //        else
    //        {
    //            serverAllocation.Status = ServerAllocationStatus.Removed;
    //            foreach (var appointment in serverAllocation.Appointments.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
    //            {
    //                appointment.Status = RequestStatus.Failed;
    //            }
    //            foreach (var requestExpand in serverAllocation.RequestExpands.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
    //            {
    //                requestExpand.Status = RequestStatus.Failed;
    //            }
    //            foreach (var requestHost in serverAllocation.RequestHosts.Where(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed))
    //            {
    //                requestHost.Status = RequestHostStatus.Failed;
    //            }
    //            foreach (var requestUpgrade in serverAllocation.RequestUpgrades.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
    //            {
    //                requestUpgrade.Status = RequestStatus.Failed;
    //            }
    //            _dbContext.IpAssignments.RemoveRange(serverAllocation.IpAssignments);
    //            _dbContext.LocationAssignments.RemoveRange(serverAllocation.LocationAssignments);
    //            _dbContext.SaveChanges();
    //            result.Succeed = true;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> AssignMasterIp(int serverAllocationId, ServerAllocationMasterIpAssignmentModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.IpAssignments)
                .Include(x => x.LocationAssignments)
                .FirstOrDefault(x => x.Id == serverAllocationId && x.Status != ServerAllocationStatus.Removed);
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
                .FirstOrDefault(x => x.Id == model.IpAddressId);
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

                if (ipAddress.IpAssignments.Any() || ipAddress.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed))
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
                serverAllocation.MasterIpAddress = ipAddress.Address;
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

    //public async Task<ResultModel> AssignLocation(int serverAllocationId, ServerAllocationAssignLocationModel model)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;
    //    bool validPrecondition = true;

    //    try
    //    {
    //        var serverAllocation = _dbContext.ServerAllocations.Include(x => x.LocationAssignments).ThenInclude(x => x.Location).Include(x => x.RequestExpands).FirstOrDefault(x => x.Id == serverAllocationId);
    //        if (serverAllocation == null)
    //        {
    //            validPrecondition = false;
    //            result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
    //        }
    //        else
    //        {
    //            if (serverAllocation.LocationAssignments.Any())
    //            {
    //                validPrecondition = false;
    //                result.ErrorMessage = "Server have location already";
    //            }
    //        }

    //        List<Location> locations = null;
    //        if (validPrecondition)
    //        {
    //            locations = _dbContext.Locations
    //                .Include(x => x.LocationAssignments)
    //                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.RequestExpandLocations)
    //                .Where(delegate (Location x)
    //                {
    //                    return x.RackId == model.RackId && x.Position >= model.StartPosition && x.Position < model.StartPosition + model.Size && x.IsAvailable();
    //                })
    //                .ToList();
    //            if (locations.Count != model.Size)
    //            {
    //                validPrecondition = false;
    //                result.ErrorMessage = RequestExpandLocationErrorMessage.INVALID_LOCATION;
    //            }
    //        }

    //        if (validPrecondition)
    //        {
    //            foreach (var location in locations)
    //            {
    //                _dbContext.LocationAssignments.Add(new LocationAssignment
    //                {
    //                    IsServer = true,
    //                    LocationId = location.Id,
    //                    ServerAllocationId = serverAllocation.Id,
    //                });
    //            }
    //            _dbContext.SaveChanges();
    //            result.Succeed = true;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    //public async Task<ResultModel> CreateUpgradeAndHostInspectionReport(int serverAllocationId, HostAndUpgradeCreateInspectionReportModel model)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        string inputPath = Path.Combine(_env.WebRootPath, "Report", "UpgradeAndHostTemplate.docx");
    //        string outputPath = Path.Combine(_env.WebRootPath, "Report", "BBNT.docx");
    //        var serverAllocation = _dbContext.ServerAllocations
    //           .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
    //           .Include(x => x.Customer)
    //           .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
    //           .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
    //           .FirstOrDefault(x => x.Id == serverAllocationId);
    //        if (serverAllocation == null)
    //        {
    //            result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
    //        }
    //        else
    //        {
    //            File.Copy(inputPath, outputPath, true);
    //            using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
    //            {
    //                var now = DateTime.UtcNow;
    //                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
    //                document.RenderText("__Date__", $"{now.Day}/{now.Month}/{now.Year}");

    //                document.RenderText("__Number__", textInfo.ToTitleCase(model.Number));

    //                document.RenderText("__CustomerName__", textInfo.ToTitleCase(model.CustomerName));

    //                document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());

    //                document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(model.CustomerPosition));

    //                document.RenderText("__CustomerAddress__", serverAllocation.Customer.Address);

    //                document.RenderText("__CustomerPhoneNumber__", serverAllocation.Customer.PhoneNumber);

    //                document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));

    //                document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

    //                document.RenderText("__Location__", textInfo.ToTitleCase(model.Location));

    //                document.TickCheckBoxInDocx("Allocation");

    //                document.RenderText("__ServerName__", serverAllocation.Name);

    //                var cpus = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "CPU").Description);
    //                var cpuString = "";
    //                for (int i = 0; i < cpus.Count(); i++)
    //                {
    //                    cpuString += cpus[i].Model;
    //                    if (i != cpus.Count() - 1)
    //                    {
    //                        cpuString += ", ";
    //                    }
    //                }
    //                document.RenderText("__CPUs__", cpuString);

    //                var rams = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "RAM").Description);
    //                var ramCapacity = 0;
    //                for (int i = 0; i < rams.Count(); i++)
    //                {
    //                    ramCapacity += rams[i].Capacity;
    //                }
    //                document.RenderText("__Ram__", ramCapacity + "Gb");

    //                var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "Harddisk").Description);
    //                var hardDiskCapacity = 0;
    //                for (int i = 0; i < hardDisks.Count(); i++)
    //                {
    //                    hardDiskCapacity += hardDisks[i].Capacity;
    //                }
    //                document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

    //                document.RenderText("__ServerLocation__", serverAllocation.ServerLocation);

    //                document.RenderText("__SerialNumber__", serverAllocation.SerialNumber);

    //                document.RenderText("__Power__", serverAllocation.Power + "W");

    //                document.RenderText("__MasterIP__", serverAllocation.MasterIpAddress);

    //                document.RenderText("__Action__", "");

    //                document.RenderText("__RequestHostIpCount__", "");

    //                document.RenderText("__RequestHostIpAddreses__", "");

    //                document.RenderText("__Gateway__", serverAllocation?.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress?.IpSubnet?.IpAddresses?.FirstOrDefault(x => x.Purpose == IpPurpose.Gateway)?.Address);

    //                document.RenderText("__SubnetMask__", IpAddress.GetDefaultSubnetMask(serverAllocation.MasterIpAddress));

    //                if (model.Good)
    //                {
    //                    document.TickCheckBoxInDocx("Evaluate");
    //                }
    //                document.RenderText("__Note__", model.Note);
    //                document.MainDocumentPart.Document.Save();
    //            }
    //            string inspectionReportFileName = _cloudinaryHelper.UploadFile(outputPath);
    //            _dbContext.SaveChanges();

    //            result.Succeed = true;
    //            result.Data = inspectionReportFileName;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    //public async Task<ResultModel> CreateRequestExpandInspectionReport(int requestExpandId, ServerAllocationCreateRequestExpandInspectionReportModel model)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        string inputPath = Path.Combine(_env.WebRootPath, "Report", "ExpandTemplate.docx");
    //        string outputPath = Path.Combine(_env.WebRootPath, "Report", "BBNT.docx");
    //        var serverAllocation = _dbContext.ServerAllocations
    //           .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
    //           .Include(x => x.Customer)
    //           .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
    //           .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
    //           .FirstOrDefault(x => x.Id == requestExpandId);
    //        if (serverAllocation == null)
    //        {
    //            result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
    //        }
    //        else
    //        {
    //            File.Copy(inputPath, outputPath, true);
    //            using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
    //            {
    //                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

    //                document.RenderText("__Number__", textInfo.ToTitleCase(model.Number));

    //                var now = DateTime.UtcNow;
    //                document.RenderText("__Time__", $"{now.Day}/{now.Month}/{now.Year}");
    //                document.RenderText("__Time__", $"{now.Day}/{now.Month}/{now.Year}");

    //                document.RenderText("__CustomerName__", textInfo.ToTitleCase(model.CustomerName));

    //                document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());

    //                document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(model.CustomerPosition));

    //                document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));

    //                document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

    //                document.RenderText("__Location__", model.Location);

    //                document.RenderText("__Username__", model.Username);

    //                if (model.isSendMS)
    //                {
    //                    document.TickCheckBoxInDocx("Password");
    //                }

    //                document.TickCheckBoxInDocx("Allocation");

    //                var cpus = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "CPU").Description);
    //                var cpuString = "";
    //                for (int i = 0; i < cpus.Count(); i++)
    //                {
    //                    cpuString += cpus[i].Model;
    //                    if (i != cpus.Count() - 1)
    //                    {
    //                        cpuString += ", ";
    //                    }
    //                }
    //                document.RenderText("__Model__", cpuString);

    //                var cpuCpu = "";
    //                for (int i = 0; i < cpus.Count(); i++)
    //                {
    //                    cpuString += cpus[i].SerialNumber;
    //                    if (i != cpus.Count() - 1)
    //                    {
    //                        cpuString += ", ";
    //                    }
    //                }
    //                document.RenderText("__CPU__", cpuString);

    //                var rams = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "RAM").Description);
    //                var ramCapacity = 0;
    //                for (int i = 0; i < rams.Count(); i++)
    //                {
    //                    ramCapacity += rams[i].Capacity;
    //                }
    //                document.RenderText("__Memory__", ramCapacity + "Gb");

    //                var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "Harddisk").Description);
    //                var hardDiskCapacity = 0;
    //                for (int i = 0; i < hardDisks.Count(); i++)
    //                {
    //                    hardDiskCapacity += hardDisks[i].Capacity;
    //                }
    //                document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

    //                document.RenderText("__SerialNo__", serverAllocation.SerialNumber);

    //                document.RenderText("__Power__", serverAllocation.Power + "W");

    //                document.RenderText("__Rack__", serverAllocation.ServerLocation);

    //                document.RenderText("__Size__", serverAllocation.LocationAssignments.Count() + "U");

    //                document.RenderText("__MasterIP__", serverAllocation.MasterIpAddress);
    //                document.RenderText("__Action__", "");
    //                document.RenderText("__RequestHostIpCount__", "");
    //                document.RenderText("__RequestHostIpAddreses__", "");

    //                document.RenderText("__Gateway__", serverAllocation?.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress?.IpSubnet?.IpAddresses?.FirstOrDefault(x => x.Purpose == IpPurpose.Gateway)?.Address);

    //                if (model.Good)
    //                {
    //                    document.TickCheckBoxInDocx("Evaluate");
    //                }

    //                if (model.Guid)
    //                {
    //                    document.TickCheckBoxInDocx("Guided");
    //                }

    //                document.RenderText("__Note__", model.Note);
    //                document.MainDocumentPart.Document.Save();
    //            }
    //            string inspectionReportFileName = _cloudinaryHelper.UploadFile(outputPath);
    //            serverAllocation.InspectionRecordFilePath = inspectionReportFileName;
    //            _dbContext.SaveChanges();

    //            result.Succeed = true;
    //            result.Data = inspectionReportFileName;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> AssignInspectionRecordAndReceiptOfRecipientReport(int serverAllocationId, DocumentFileUploadModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .FirstOrDefault(x => x.Id == serverAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.InspectionRecordFilePath == null)
            {
                result.ErrorMessage = "Inspection Record File Path not existed";
            }
            else if (serverAllocation.ReceiptOfRecipientFilePath == null)
            {
                result.ErrorMessage = "Receipt Of Recipient File Path not existed";
            }
            else if (serverAllocation.Status != ServerAllocationStatus.Waiting)
            {
                result.ErrorMessage = "Server must be waiting";
            }
            else
            {
                string inspectionRecordFileName = _cloudinaryHelper.UploadFile(model.InspectionReport);
                string receiptOfRecipientFileName = _cloudinaryHelper.UploadFile(model.ReceiptOfRecipient);
                serverAllocation.InspectionRecordFilePath = inspectionRecordFileName;
                serverAllocation.ReceiptOfRecipientFilePath = receiptOfRecipientFileName;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = new DocumentFileResultModel
                {
                    InspectionReport = inspectionRecordFileName,
                    ReceiptOfRecipient = receiptOfRecipientFileName,
                };
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Confirm(int serverAllocationId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.Appointments)
                .FirstOrDefault(x => x.Id == serverAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.Status != ServerAllocationStatus.Waiting)
            {
                result.ErrorMessage = "Server need to be waiting";
            }
            else if (serverAllocation.ServerLocation == null || serverAllocation.MasterIpAddress == null)
            {
                result.ErrorMessage = "Server need master ip and location";
            }
            else if (serverAllocation.InspectionRecordFilePath == null || serverAllocation.ReceiptOfRecipientFilePath == null)
            {
                result.ErrorMessage = "Server need document";
            }
            else
            {
                serverAllocation.Status = ServerAllocationStatus.Working;
                serverAllocation.Appointments.FirstOrDefault(x => x.Status == RequestStatus.Success).DocumentConfirm = true;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = serverAllocationId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignRemovalReport(int serverAllocationId, ServerAllocationRemovalReportFileUploadModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

            var serverAllocation = _dbContext.ServerAllocations
                .FirstOrDefault(x => x.Id == serverAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.LocationAssignments.Any())
            {
                result.ErrorMessage = "Must remove server from rack";
            }
            else
            {
                string removalReportFilePath = _cloudinaryHelper.UploadFile(model.RemovalReport);
                serverAllocation.RemovalFilePath = removalReportFilePath;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = new DocumentFileResultModel
                {
                    ReceiptOfRecipient = removalReportFilePath,
                };
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
