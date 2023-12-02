using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using EbookStore.Client.ExternalService.ImageHostService;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IRequestHostService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestHostSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetIpAddress(int id, PagingParam<BaseSortCriteria> paginationModel, IpAddressSearchModel searchModel);
    Task<ResultModel> Create(RequestHostCreateModel model);
    Task<ResultModel> Update(RequestHostUpdateModel model);
    Task<ResultModel> Evaluate(int requestHostId, RequestHostStatus status, UserAssignModel model);
    Task<ResultModel> EvaluateBulk(RequestHostEvaluateBulkModel model, RequestHostStatus status);
    Task<ResultModel> AssignAdditionalIp(int requestHostId, RequestHostIpAssignmentModel model);
    Task<ResultModel> AssignInspectionReport(int requestHostId, RequestHostDocumentFileUploadModel model);
    Task<ResultModel> Process(int requestHostId, Guid userId);
    Task<ResultModel> Complete(int requestHostId, Guid userId);
}

public class RequestHostService : IRequestHostService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;

    public RequestHostService(AppDbContext dbContext, IMapper mapper, ICloudinaryHelper cloudinaryHelper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _cloudinaryHelper = cloudinaryHelper;
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
                var ipAddresses = requestHost.RequestHostIps.Select(x => x.IpAddress).Where(x => searchModel.Address != null ? x.Address.Contains(searchModel.Address) : true).AsQueryable();
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
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
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

    public async Task<ResultModel> Evaluate(int requestHostId, RequestHostStatus status, UserAssignModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            if (status != RequestHostStatus.Accepted && status != RequestHostStatus.Denied)
            {
                throw new Exception(ErrorMessage.WRONG_PURPOSE);
            }

            var requestHost = _dbContext.RequestHosts.Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress).FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else
            {
                if (!requestHost.RequestHostIps.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestHostErrorMessage.NO_IP_CHOICE;
                }

                if (requestHost.Status != RequestHostStatus.Waiting)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestHostErrorMessage.NOT_WAITING;
                }
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                requestHost.Status = status;
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestHostId = requestHost.Id,
                    UserId = new Guid(model.UserId)
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

    public async Task<ResultModel> EvaluateBulk(RequestHostEvaluateBulkModel model, RequestHostStatus status)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            var userAssignModel = new UserAssignModel
            {
                UserId = model.UserId
            };
            foreach (var requestHostId in model.RequestHostIds)
            {

                results.Add(await Evaluate(requestHostId, status, userAssignModel));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
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
            else if (requestHost.Status != RequestHostStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_ACCEPTED;
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
                    else if (requestHost.IsRemoval && ipAddress.IpAssignments.FirstOrDefault().ServerAllocationId != requestHost.ServerAllocationId)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Can only removed owned ip address";
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
            else if (requestHost.Status != RequestHostStatus.Accepted)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
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

    public async Task<ResultModel> Process(int requestHostId, Guid userId)
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
            else if (requestHost.Status != RequestHostStatus.Accepted)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
            }
            else if (!requestHost.RequestHostIps.Any())
            {
                result.ErrorMessage = RequestHostErrorMessage.NO_IP_CHOICE;
            }
            else if (requestHost.InspectionReportFilePath == null)
            {
                result.ErrorMessage = RequestHostErrorMessage.NOT_PROCESSABLE;
            }
            else
            {
                requestHost.Status = RequestHostStatus.Processed;
                _dbContext.RequestHostUsers.Add(new RequestHostUser
                {
                    Action = RequestUserAction.Process,
                    UserId = userId,
                    RequestHostId = requestHostId,
                });
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

    public async Task<ResultModel> Complete(int requestHostId, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestHost = _dbContext.RequestHosts
                .Include(x => x.RequestHostIps).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments)
                .FirstOrDefault(x => x.Id == requestHostId);
            if (requestHost == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_EXISTED;
            }
            else if (requestHost.Status != RequestHostStatus.Processed)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestHostErrorMessage.NOT_PROCESSED;
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
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<IpAssignmentResultModel>>(ipAssignments);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}