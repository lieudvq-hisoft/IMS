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
using System.Text.Json;

namespace Services.Core;
public interface IRequestUpgradeService
{
    Task<ResultModel> Get(PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetAppointment(int requestUpgradeId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> Create(RequestUpgradeCreateModel model);
    Task<ResultModel> Delete(int requestUpgradeId);
    Task<ResultModel> Reject(int requestUpgradeId, RequestUpgradeRejectModel model);
    Task<ResultModel> Update(RequestUpgradeUpdateModel model);
    Task<ResultModel> Accept(int requestUpgradeId, Guid userId, EvaluateModel model);
    Task<ResultModel> Deny(int requestUpgradeId, Guid userId, EvaluateModel model);
}

public class RequestUpgradeService : IRequestUpgradeService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly INotificationService _notiService;

    public RequestUpgradeService(AppDbContext dbContext, IMapper mapper, INotificationService notiService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _notiService = notiService;
    }

    public async Task<ResultModel> Get(PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrades = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer).ThenInclude(x => x.UserCustomers)
                .Where(delegate (RequestUpgrade x)
                {
                    return x.FilterRequestUpgrade(searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgrades.Count());

            requestUpgrades = requestUpgrades.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestUpgrades = requestUpgrades.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestUpgradeModel>>(requestUpgrades.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else
            {
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAppointment(int requestUpgradeId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        var searchValue = searchModel.SearchValue?.ToLower() ?? "";
        var appointments = _dbContext.Appointments
            .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
            .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
            .Include(x => x.ServerAllocation).Include(x => x.RequestUpgradeAppointment)
            .Include(x => x.AppointmentUsers).ThenInclude(x => x.User)
            .Include(x => x.RequestExpandAppointments)
            .Include(x => x.RequestUpgradeAppointment)
            .Include(x => x.AppointmentUsers)
            .Where(x => x.RequestUpgradeAppointment.Any(x => x.RequestUpgradeId == requestUpgradeId))
            .Where(x => x.ServerAllocationId == searchModel.ServerAllocationId || searchModel.ServerAllocationId == null)
            .Where(x => searchModel.Statuses.Contains(x.Status) || searchModel.Statuses == null)
            .Where(x => searchModel.Reasons.Contains(x.Reason) || searchModel.Reasons == null)
            .Where(x => x.ServerAllocation.CustomerId == searchModel.CustomerId || searchModel.CustomerId == null)
            .Where(x => x.AppointmentUsers.Any(x => x.UserId == searchModel.UserId) || searchModel.UserId == null)
            .Where(x => x.AppointedCustomer.ToLower().Contains(searchValue) || x.ServerAllocation.Customer.CompanyName.Contains(searchValue))
            .AsQueryable();

        var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());

        appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
        appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

        paging.Data = _mapper.Map<List<AppointmentModel>>(appointments.ToList());

        result.Data = paging;
        result.Succeed = true;

        return result;
    }

    public async Task<ResultModel> Create(RequestUpgradeCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var component = _dbContext.Components.Include(x => x.ServerHardwareConfigs).FirstOrDefault(x => x.Id == model.ComponentId);
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.LocationAssignments)
                .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (validPrecondition)
            {
                if (serverAllocation == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                }
                else if (!serverAllocation.LocationAssignments.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = "Cannot modify unallocated server";
                }
            }

            if (validPrecondition)
            {
                var existedRequestUpgrade = _dbContext.RequestUpgrades
                    .Include(x => x.ServerAllocation).Include(x => x.Component)
                    .Any(x => x.ServerAllocationId == model.ServerAllocationId && x.ServerAllocation.Status != ServerAllocationStatus.Removed && x.ComponentId == model.ComponentId && (x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting));
                if (existedRequestUpgrade)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestUpgradeErrorMessage.EXISTED;
                }
            }

            if (validPrecondition)
            {
                var requestUpgrade = _mapper.Map<RequestUpgrade>(model);
                requestUpgrade.Status = RequestStatus.Waiting;
                if (requestUpgrade.Description == null)
                {
                    requestUpgrade.RequestType = RequestType.RemoveHardware;
                }

                _dbContext.RequestUpgrades.Add(requestUpgrade);
                _dbContext.SaveChanges();

                var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                var reuqestUpgradeModelString = JsonSerializer.Serialize(_mapper.Map<RequestUpgradeResultModel>(requestUpgrade));
                foreach (var sale in sales)
                {
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = sale.Id,
                        Action = "Created",
                        Title = "New hardware modify request",
                        Body = "There's a new hardware modify request just created",
                        Data = new NotificationData
                        {
                            Key = "RequestUpgrade",
                            Value = reuqestUpgradeModelString
                        }
                    });
                }

                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeResultModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    //private bool CheckValidSerialNumber(List<string> serialNumbers, int componentId, int serverAllocationId)
    //{
    //    var thisSerialNumber = _dbContext.ServerHardwareConfigs.Include(x => x.ServerAllocation)
    //        .FirstOrDefault(x => x.ServerAllocation.Status != ServerAllocationStatus.Removed && x.ServerAllocationId == serverAllocationId && x.ComponentId == componentId);
    //    var existingConfig = _dbContext.ServerHardwareConfigs.Include(x => x.ServerAllocation)
    //        .Where(x => x.ServerAllocation.Status != ServerAllocationStatus.Removed)
    //        .ToList();
    //    existingConfig.Remove(thisSerialNumber);
    //    var existedSerialNumber = existingConfig
    //        .SelectMany(x => JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(x.Description).Select(x => x.SerialNumber));
    //    return !serialNumbers.Any(x => existedSerialNumber.Contains(x)) && serialNumbers.Distinct().Count() == serialNumbers.Count();
    //}

    //public async Task<ResultModel> CreateBulk(RequestUpgradeCreateBulkModel model)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        using var transaction = _dbContext.Database.BeginTransaction();
    //        var results = new List<ResultModel>();
    //        foreach (var requestUpgradeRequestModel in model.RequestUpgradeCreateModels)
    //        {
    //            results.Add(await Create(requestUpgradeRequestModel));
    //        }

    //        if (results.Any(x => !x.Succeed))
    //        {
    //            result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
    //            transaction.Rollback();
    //        }
    //        else
    //        {
    //            transaction.Commit();
    //            result.Succeed = true;
    //            result.Data = results.Select(x => x.Data);
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> Update(RequestUpgradeUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.Component)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .FirstOrDefault(x => x.Id == model.Id);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestUpgrade.Status != RequestStatus.Waiting && requestUpgrade.Status != RequestStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING + " & " + RequestUpgradeErrorMessage.NOT_ACCEPTED;
            }

            var component = requestUpgrade?.Component;
            if (component == null)
            {
                result.ErrorMessage = ComponentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var serverAllocation = requestUpgrade?.ServerAllocation;
            if (serverAllocation == null || serverAllocation.Status == ServerAllocationStatus.Removed)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (!serverAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot modify unallocated server";
            }

            if (validPrecondition)
            {
                _mapper.Map<RequestUpgradeUpdateModel, RequestUpgrade>(model, requestUpgrade);

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades.Include(x => x.ServerAllocation).FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else if (requestUpgrade.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING;
            }
            else
            {
                requestUpgrade.Status = RequestStatus.Failed;
                requestUpgrade.Note = "Customer deleted";
                _dbContext.SaveChanges();

                var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                var requestModelString = JsonSerializer.Serialize(_mapper.Map<RequestUpgradeResultModel>(requestUpgrade));
                foreach (var sale in sales)
                {
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = sale.Id,
                        Action = "Canceled",
                        Title = "Upgrade request canceled",
                        Body = "There's an upgrade request just canceled by customer",
                        Data = new NotificationData
                        {
                            Key = "RequestUpgrade",
                            Value = requestModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = requestUpgradeId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Reject(int requestUpgradeId, RequestUpgradeRejectModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else if (requestUpgrade.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_ACCEPTED;
            }
            else
            {
                requestUpgrade.Status = RequestStatus.Failed;
                var appointment = requestUpgrade.RequestUpgradeAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted);
                if (appointment != null)
                {
                    appointment.Status = RequestStatus.Failed;
                }
                if (requestUpgrade.TechNote != null)
                {
                    requestUpgrade.TechNote = model.TechNote;
                }
                if (requestUpgrade.SaleNote != null)
                {
                    requestUpgrade.SaleNote = model.SaleNote;
                }
                _dbContext.SaveChanges();

                var reuqestUpgradeModelString = JsonSerializer.Serialize(_mapper.Map<RequestUpgradeResultModel>(requestUpgrade));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = requestUpgrade.ServerAllocation.CustomerId,
                    Action = "Failed",
                    Title = "Upgrade request failed",
                    Body = "There's an upgrade request just failed",
                    Data = new NotificationData
                    {
                        Key = "RequestUpgrade",
                        Value = reuqestUpgradeModelString
                    }
                });
                result.Succeed = true;
                result.Data = requestUpgradeId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Accept(int requestUpgradeId, Guid userId, EvaluateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades.Include(x => x.ServerAllocation).Include(x => x.Component).ThenInclude(x => x.ServerHardwareConfigs).FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestUpgrade.Status != RequestStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING;
            }

            if (validPrecondition)
            {
                requestUpgrade.Status = RequestStatus.Accepted;
                if (!string.IsNullOrEmpty(model.SaleNote))
                {
                    requestUpgrade.SaleNote = model.SaleNote;
                }
                _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                {
                    RequestUpgradeId = requestUpgrade.Id,
                    UserId = userId,
                    Action = RequestUserAction.Execute
                });
                requestUpgrade.DateEvaluated = DateTime.Now;
                _dbContext.SaveChanges();

                var requestModelString = JsonSerializer.Serialize(_mapper.Map<RequestUpgradeResultModel>(requestUpgrade));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = requestUpgrade.ServerAllocation.CustomerId,
                    Action = "Accepted",
                    Title = "Upgrade request accepted",
                    Body = "There's an upgrade request just accepted",
                    Data = new NotificationData
                    {
                        Key = "RequestUpgrade",
                        Value = requestModelString
                    }
                });
                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Deny(int requestUpgradeId, Guid userId, EvaluateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointments).ThenInclude(x => x.Appointment)
                .FirstOrDefault(x => x.Id == requestUpgradeId);
            if (requestUpgrade == null)
            {
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestUpgrade.Status != RequestStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_WAITING;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                requestUpgrade.Status = RequestStatus.Denied;
                requestUpgrade.SaleNote = model.SaleNote;
                requestUpgrade.DateEvaluated = DateTime.Now;
                var appointment = requestUpgrade.RequestUpgradeAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted);
                if (appointment != null)
                {
                    appointment.Status = RequestStatus.Failed;
                }
                _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestUpgradeId = requestUpgrade.Id,
                    UserId = userId
                });
                _dbContext.SaveChanges();

                var requestModelString = JsonSerializer.Serialize(_mapper.Map<RequestUpgradeResultModel>(requestUpgrade));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = requestUpgrade.ServerAllocation.CustomerId,
                    Action = "Denied",
                    Title = "Upgrade request denied",
                    Body = "There's an upgrade request just denied",
                    Data = new NotificationData
                    {
                        Key = "RequestUpgrade",
                        Value = requestModelString
                    }
                });
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostModel>(requestUpgrade);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
