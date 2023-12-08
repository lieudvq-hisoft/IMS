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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;
using System.Globalization;
using System.Text.Json;

namespace Services.Core;
public interface IRequestHostService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetIpAddress(int id, PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> Create(RequestHostCreateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Update(RequestHostUpdateModel model);
    Task<ResultModel> Accept(int requestHostId, Guid userId, UserAssignModel model);
    Task<ResultModel> Deny(int requestHostId, Guid userId, DenyModel model);
    //Task<ResultModel> EvaluateBulk(RequestHostEvaluateBulkModel model, RequestHostStatus status, Guid userId);
    Task<ResultModel> AssignAdditionalIp(int requestHostId, RequestHostIpAssignmentModel model);
    Task<ResultModel> AssignInspectionReport(int requestHostId, RequestHostDocumentFileUploadModel model);
    //Task<ResultModel> Process(int requestHostId, Guid userId);
    Task<ResultModel> Complete(int requestHostId, Guid userId, HostAndUpgradeCreateInspectionReportModel? model);
    Task<ResultModel> Reject(int requestHostId, RequestHostRejectModel modell);
    Task<ResultModel> DocumentConfirmTrue(int appointmentId);
}

public class RequestHostService : IRequestHostService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IHostingEnvironment _env;
    private readonly ICloudinaryHelper _cloudinaryHelper;
    private readonly UserManager<User> _userManager;

    public RequestHostService(AppDbContext dbContext, IMapper mapper, IHostingEnvironment env, ICloudinaryHelper cloudinaryHelper, UserManager<User> userManager)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _env = env;
        _cloudinaryHelper = cloudinaryHelper;
        _userManager = userManager;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHosts = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestHostUsers).ThenInclude(x => x.User)
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
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestHostUsers).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == id);

            if (requestHost != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostModel>(requestHost);
            }
            else
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetIpAddress(int id, PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .ThenInclude(x => x.IpAssignments).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);

            if (requestHost != null)
            {
                var ipAddresses = requestHost.RequestHostIps.Select(x => x.IpAddress)
                    .Where(delegate (IpAddress x)
                    {
                        return x.Filter(searchModel);
                    }).AsQueryable();
                var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, ipAddresses.Count());

                ipAddresses = ipAddresses.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
                ipAddresses = ipAddresses.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

                paging.Data = _mapper.Map<List<IpAddressModel>>(ipAddresses.ToList());

                result.Data = paging;
                result.Succeed = true;
            }
            else
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestHostCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (model.Type == IpAssignmentTypes.Master)
            {
                result.ErrorMessage = "Cannot request more master ip";
            }
            else if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (!serverAllocation.IpAssignments.Any(x => x.Type == IpAssignmentTypes.Master))
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_MASTER_IP;
            }
            else if (model.Type == IpAssignmentTypes.Master)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.HAVE_IP_MASTER_ALREADY;
            }
            else if (serverAllocation.Status != ServerAllocationStatus.Working)
            {
                result.ErrorMessage = "Server need to be working";
            }
            else
            {
                var requestHost = _mapper.Map<RequestHost>(model);
                requestHost.Status = RequestHostStatus.Waiting;
                _dbContext.RequestHosts.Add(requestHost);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostResultModel>(requestHost);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(RequestHostUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps)
                .Include(x => x.ServerAllocation)
                .ThenInclude(x => x.IpAssignments)
                .ThenInclude(x => x.IpAddress)
                .FirstOrDefault(x => x.Id == model.Id && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            var serverAllocation = requestHost.ServerAllocation;
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (!serverAllocation.IpAssignments.Any(x => x.Type == IpAssignmentTypes.Master))
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_MASTER_IP;
            }
            else if (model.Type == IpAssignmentTypes.Master)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.HAVE_IP_MASTER_ALREADY;
            }
            else if (requestHost.RequestHostIps.Any())
            {
                result.ErrorMessage = "Have ip choice already";
            }
            else
            {
                _mapper.Map<RequestHostUpdateModel, RequestHost>(model, requestHost);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostResultModel>(requestHost);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts.Include(x => x.RequestHostIps).FirstOrDefault(x => x.Id == id);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Status != RequestHostStatus.Waiting)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_WAITING;
            }
            else
            {
                requestHost.Status = RequestHostStatus.Failed;
                _dbContext.RequestHostIps.RemoveRange(requestHost.RequestHostIps);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestHost.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Accept(int requestHostId, Guid userId, UserAssignModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestHost = _dbContext.RequestHosts.Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress).FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestHost.Status != RequestHostStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_WAITING;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            User executor = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (executor == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                var roles = await _userManager.GetRolesAsync(executor);
                if (!roles.Contains(RoleType.Tech.ToString()))
                {
                    validPrecondition = false;
                    result.ErrorMessage = "User assigned is not a tech";
                }
            }

            if (validPrecondition)
            {
                requestHost.Status = RequestHostStatus.Accepted;
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestHostId = requestHost.Id,
                    UserId = userId
                });
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    Action = RequestUserAction.Execute,
                    RequestHostId = requestHostId,
                    UserId = executor.Id,
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

    public async Task<ResultModel> Deny(int requestHostId, Guid userId, DenyModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestHost = _dbContext.RequestHosts.FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestHost.Status != RequestHostStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_WAITING;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                requestHost.Status = RequestHostStatus.Denied;
                requestHost.SaleNote = model.SaleNote;
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestHostId = requestHost.Id,
                    UserId = userId
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

    public async Task<ResultModel> AssignAdditionalIp(int requestHostId, RequestHostIpAssignmentModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestHost = _dbContext.RequestHosts.Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress).FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Quantity != model.IpAddressIds.Count)
            {
                validPrecondition = false;
                result.ErrorMessage = "Number of assign ip not match requested";
            }
            else if (!requestHost.IsRemoval && requestHost.Status != RequestHostStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_ACCEPTED;
            }
            else if (requestHost.IsRemoval && requestHost.Status != RequestHostStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_WAITING;
            }

            if (validPrecondition)
            {
                foreach (int ipAddressId in model.IpAddressIds)
                {
                    var ipAddress = GetValidIpAddress(ipAddressId, requestHost.IsRemoval);
                    if (ipAddress == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = IpAddressErrorMessage.UNASSIGNABLE;
                    }
                    else if (requestHost.IsRemoval)
                    {
                        if (ipAddress.IpAssignments.FirstOrDefault().ServerAllocationId != requestHost.ServerAllocationId)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = "Can only removed owned ip address";
                        }

                        if (ipAddress.IpAssignments.FirstOrDefault().Type == IpAssignmentTypes.Master)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = "Cannot unassign master ip";
                        }
                    }
                    // validate ips for assignment
                    else if (ipAddress.Purpose != IpPurpose.Host)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Can only assign host ip";
                    }
                }
            }

            if (validPrecondition)
            {
                var requestHostIps = new List<RequestHostIp>();
                foreach (var ipAddressId in model.IpAddressIds)
                {
                    requestHostIps.Add(new RequestHostIp
                    {
                        IpAddressId = ipAddressId,
                        RequestHostId = requestHost.Id
                    });
                }
                _dbContext.RequestHostIps.RemoveRange(requestHost.RequestHostIps);
                _dbContext.RequestHostIps.AddRange(requestHostIps);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostResultModel>(requestHost);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private IpAddress GetValidIpAddress(int ipAddressId, bool isRemoval)
    {
        var ipAddress = _dbContext.IpAddresses.Include(x => x.IpAssignments)
            .Include(x => x.RequestHostIps).ThenInclude(x => x.RequestHost)
            .Where(x => !x.Blocked && !x.IsReserved && x.IpAssignments.Any() == isRemoval && !x.RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed))
            .FirstOrDefault(x => x.Id == ipAddressId);

        return ipAddress;
    }

    public async Task<ResultModel> AssignInspectionReport(int requestHostId, RequestHostDocumentFileUploadModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts.Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress).FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Status != RequestHostStatus.Success)
            {
                result.ErrorMessage = "Request host must be accept or success";
            }
            else if (requestHost.DocumentConfirm)
            {
                result.ErrorMessage = "Request host document confirm";
            }
            else if (!requestHost.RequestHostIps.Any())
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_IP_CHOICE;
            }
            else
            {
                string inspectionReportFileName = _cloudinaryHelper.UploadFile(model.InspectionReport);

                requestHost.InspectionReportFilePath = inspectionReportFileName;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = new RequestHostDocumentFileResultModel
                {
                    InspectionReport = inspectionReportFileName,
                };
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    //public async Task<ResultModel> Process(int requestHostId, Guid userId)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        var requestHost = _dbContext.RequestHosts.Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress).FirstOrDefault(x => x.Id == requestHostId);
    //        if (requestHost == null)
    //        {
    //            result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
    //        }
    //        else if (requestHost.Status != RequestHostStatus.Accepted)
    //        {
    //            result.ErrorMessage = RequestHostErrorMessage.NOT_ACCEPTED;
    //        }
    //        else if (!requestHost.RequestHostIps.Any())
    //        {
    //            result.ErrorMessage = RequestHostErrorMessage.NO_IP_CHOICE;
    //        }
    //        else if (requestHost.InspectionReportFilePath == null)
    //        {
    //            result.ErrorMessage = RequestHostErrorMessage.NOT_PROCESSABLE;
    //        }
    //        else
    //        {
    //            requestHost.Status = RequestHostStatus.Processed;
    //            _dbContext.RequestHostUsers.Add(new RequestHostUser
    //            {
    //                Action = RequestUserAction.Process,
    //                UserId = userId,
    //                RequestHostId = requestHostId,
    //            });
    //            _dbContext.SaveChanges();
    //            result.Succeed = true;
    //            result.Data = _mapper.Map<RequestHostResultModel>(requestHost);
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> Complete(int requestHostId, Guid userId, HostAndUpgradeCreateInspectionReportModel? model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Status != RequestHostStatus.Accepted)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
            }
            else if (!requestHost.RequestHostIps.Any())
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_IP_CHOICE;
            }
            else if (requestHost.InspectionReportFilePath == null && model == null)
            {
                result.ErrorMessage = "Need inspection report to complete";
            }
            else
            {
                var ipAddresses = requestHost.RequestHostIps.Select(x => x.IpAddress);
                var ipAssignments = new List<IpAssignment>();
                foreach (var ipAddress in ipAddresses)
                {
                    if (!requestHost.IsRemoval)
                    {
                        ipAssignments.Add(new IpAssignment
                        {
                            IpAddressId = ipAddress.Id,
                            ServerAllocationId = requestHost.ServerAllocationId,
                            Type = requestHost.Type
                        });
                    }
                    else
                    {
                        _dbContext.IpAssignments.RemoveRange(ipAddress.IpAssignments);
                    }
                }
                if (!requestHost.IsRemoval)
                {
                    _dbContext.IpAssignments.AddRange(ipAssignments);
                }
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    Action = RequestUserAction.Execute,
                    RequestHostId = requestHost.Id,
                    UserId = userId,
                });
                requestHost.Status = RequestHostStatus.Success;
                requestHost.ServerAllocation.DateUpdated = DateTime.UtcNow;
                _dbContext.SaveChanges();

                var createDocResult = await CreateUpgradeAndHostInspectionReport(requestHost.Id, model);
                if (!createDocResult.Succeed)
                {
                    transaction.Rollback();
                    result.ErrorMessage = createDocResult.ErrorMessage;
                }
                else
                {
                    requestHost.InspectionReportFilePath = createDocResult.Data as string;
                    _dbContext.SaveChanges();
                    transaction.Commit();
                    result.Succeed = true;
                    result.Data = _mapper.Map<List<IpAssignmentResultModel>>(ipAssignments);
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateUpgradeAndHostInspectionReport(int requestHostId, HostAndUpgradeCreateInspectionReportModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            string inputPath = Path.Combine(_env.WebRootPath, "Report", "UpgradeAndHostTemplate.docx");
            string outputPath = Path.Combine(_env.WebRootPath, "Report", "BBNT.docx");
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress).ThenInclude(x => x.IpSubnet)
                .FirstOrDefault(x => x.Id == requestHostId);
            var serverAllocation = _dbContext.ServerAllocations
               .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Include(x => x.Customer)
               .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
               .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
               .FirstOrDefault(x => x.Id == requestHost.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                File.Copy(inputPath, outputPath, true);
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
                    var now = DateTime.UtcNow;
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    document.RenderText("__Date__", $"{now.Day}/{now.Month}/{now.Year}");

                    document.RenderText("__Number__", textInfo.ToTitleCase(model.Number));

                    document.RenderText("__CustomerName__", textInfo.ToTitleCase(model.CustomerName));

                    document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());

                    document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(model.CustomerPosition));

                    document.RenderText("__CustomerAddress__", serverAllocation.Customer.Address);

                    document.RenderText("__CustomerPhoneNumber__", serverAllocation.Customer.PhoneNumber);

                    document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));

                    document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

                    document.RenderText("__Location__", textInfo.ToTitleCase(model.Location));

                    document.TickCheckBoxInDocx("Allocation");

                    document.RenderText("__ServerName__", serverAllocation.Name);

                    var cpus = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs?.FirstOrDefault(x => x.Component.Name == "CPU")?.Description);
                    var cpuString = "";
                    for (int i = 0; i < cpus.Count(); i++)
                    {
                        cpuString += cpus[i].Model;
                        if (i != cpus.Count() - 1)
                        {
                            cpuString += ", ";
                        }
                    }
                    document.RenderText("__CPUs__", cpuString);

                    var rams = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs?.FirstOrDefault(x => x.Component.Name == "RAM")?.Description);
                    var ramCapacity = 0;
                    for (int i = 0; i < rams.Count(); i++)
                    {
                        ramCapacity += rams[i].Capacity;
                    }
                    document.RenderText("__Ram__", ramCapacity + "Gb");

                    var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs?.FirstOrDefault(x => x.Component.Name == "Harddisk")?.Description);
                    var hardDiskCapacity = 0;
                    for (int i = 0; i < hardDisks.Count(); i++)
                    {
                        hardDiskCapacity += hardDisks[i].Capacity;
                    }
                    document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

                    document.RenderText("__ServerLocation__", serverAllocation.ServerLocation);

                    document.RenderText("__SerialNumber__", serverAllocation.SerialNumber);

                    document.RenderText("__Power__", serverAllocation.Power + "W");

                    document.RenderText("__MasterIp__", serverAllocation.MasterIpAddress);

                    document.RenderText("__Action__", requestHost.IsRemoval ? "Gỡ" : "Thêm");

                    document.RenderText("__RequestHostIpCount__", requestHost.Quantity.ToString());

                    var ipAddressString = "";
                    var ipAddresses = requestHost.RequestHostIps.Select(x => x.IpAddress).ToList();
                    for (int i = 0; i < ipAddresses.Count(); i++)
                    {
                        ipAddressString += ipAddresses[i].Address;
                        if (i < ipAddresses.Count - 1)
                        {
                            ipAddressString += ", ";
                        }
                    }
                    document.RenderText("__RequestHostIpAddreses__", ipAddressString);

                    document.RenderText("__Gateway__", serverAllocation?.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress?.IpSubnet?.IpAddresses?.FirstOrDefault(x => x.Purpose == IpPurpose.Gateway)?.Address);

                    document.RenderText("__SubnetMask__", IpAddress.GetDefaultSubnetMask(serverAllocation.MasterIpAddress));

                    if (model.Good)
                    {
                        document.TickCheckBoxInDocx("Evaluate");
                    }
                    document.RenderText("__Note__", model.Note);
                    document.MainDocumentPart.Document.Save();
                }
                string inspectionReportFileName = _cloudinaryHelper.UploadFile(outputPath);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = inspectionReportFileName;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Reject(int requestHostId, RequestHostRejectModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestHost = _dbContext.RequestHosts.FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Status != RequestHostStatus.Accepted)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_ACCEPTED;
            }
            else
            {
                requestHost.Status = RequestHostStatus.Failed;
                if (model.Note != null)
                {
                    requestHost.Note = model.Note;
                }
                if (model.SaleNote != null)
                {
                    requestHost.SaleNote = model.SaleNote;
                }
                if (model.TechNote != null)
                {
                    requestHost.TechNote = model.TechNote;
                }
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestHostId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> DocumentConfirmTrue(int requestHostId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

            var requestHost = _dbContext.RequestHosts
                .FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Status != RequestHostStatus.Success)
            {
                result.ErrorMessage = "Request host's status is not success";
            }
            else if (requestHost.DocumentConfirm == true)
            {
                result.ErrorMessage = RequestHostErrorMessage.ALREADY_CONFIRM;
            }
            else
            {

                requestHost.DocumentConfirm = true;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestHost.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}