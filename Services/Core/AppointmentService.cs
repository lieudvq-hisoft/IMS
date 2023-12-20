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
public interface IAppointmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> GetByMonth(AppointmentSearchModel searchModel, int month);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestExpand(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestUpgrade(int id, PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel);
    Task<ResultModel> Create(AppointmentCreateModel model);
    Task<ResultModel> CreateIncident(AppointmentIncidentCreateModel model, Guid userId);
    Task<ResultModel> CreateRequestAppointment(int appointmentId, RequestAppointmentCreateModel model);
    Task<ResultModel> Update(AppointmentUpdateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Accept(int appointmentId, Guid userId, UserAssignModel model);
    Task<ResultModel> Deny(int appointmentId, Guid userId, DenyModel model);
    Task<ResultModel> AssignTech(int appointmentId, UserAssignModel model);
    Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model, Guid userId);
    Task<ResultModel> Resolv(int appointmentId, AppointmentResolvModel model, Guid userId);
    Task<ResultModel> Fail(int appointmentId, AppointmentFailModel model);
    Task<ResultModel> AssignInspectionReport(int appointmentId, DocumentFileUploadModel model);
    Task<ResultModel> DocumentConfirmTrue(int appointmentId);
}

public class AppointmentService : IAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly IHostingEnvironment _env;
    private readonly ICloudinaryHelper _cloudinaryHelper;
    private readonly UserManager<User> _userManager;
    private readonly INotificationService _notiService;

    public AppointmentService(AppDbContext dbContext, IMapper mapper, IHostingEnvironment env, ICloudinaryHelper cloudinaryHelper, UserManager<User> userManage, INotificationService notiService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _env = env;
        _cloudinaryHelper = cloudinaryHelper;
        _userManager = userManage;
        _notiService = notiService;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointments = _dbContext.Appointments
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.AppointmentUsers).ThenInclude(x => x.User)
                .Include(x => x.RequestExpandAppointments)
                .Include(x => x.RequestUpgradeAppointment)
                .Where(delegate (Appointment x)
                {
                    return x.FilterAppointment(searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());

            appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<AppointmentModel>>(appointments);

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetByMonth(AppointmentSearchModel searchModel, int month)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointments = _dbContext.Appointments
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.AppointmentUsers).ThenInclude(x => x.User)
                .Include(x => x.RequestExpandAppointments)
                .Include(x => x.RequestUpgradeAppointment)
                .Where(x => x.DateAppointed.Month == month)
                .Where(delegate (Appointment x)
                {
                    return x.FilterAppointment(searchModel);
                })
                .AsQueryable();

            result.Data = _mapper.Map<List<AppointmentModel>>(appointments);
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
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.AppointmentUsers).ThenInclude(x => x.User)
                .Include(x => x.RequestExpandAppointments)
                .Include(x => x.RequestUpgradeAppointment)
                .FirstOrDefault(x => x.Id == id);

            if (appointment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentModel>(appointment);
            }
            else
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
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
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.RequestExpandUsers).ThenInclude(x => x.User)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.RequestExpandLocations).ThenInclude(x => x.Location)
                .FirstOrDefault(x => x.Id == id);

            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
            else
            {
                var requestExpands = appointment.RequestExpandAppointments.Select(x => x.RequestExpand).AsQueryable();

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

    public async Task<ResultModel> GetRequestUpgrade(int id, PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade).ThenInclude(x => x.Component)
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade).ThenInclude(x => x.RequestUpgradeUsers).ThenInclude(x => x.User)
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade).ThenInclude(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .FirstOrDefault(x => x.Id == id);

            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
            else
            {
                var requestUpgrades = appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade)
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
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(AppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        using var transaction = _dbContext.Database.BeginTransaction();

        if (model.RequestUpgradeIds != null && model.RequestExpandId != null)
        {
            result.ErrorMessage = "Cannot have both upgrade and expand request";
            return result;
        }

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                RequestExpand requestExpand = null;
                if (model.RequestExpandId != null)
                {
                    requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == model.RequestExpandId.Value);
                }

                switch (model.Reason)
                {
                    case AppointmentReason.Install:
                        if (requestExpand == null)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                        }
                        else if (requestExpand.ForRemoval)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = "Cannot create install appointment for uninstall appointment";
                        }
                        break;
                    case AppointmentReason.Uninstall:
                        if (requestExpand == null)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                        }
                        else if (!requestExpand.ForRemoval)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = "Cannot create uninstall appointment for install appointment";
                        }
                        break;
                    case AppointmentReason.Upgrade:
                        if (!model.RequestUpgradeIds.Any())
                        {
                            validPrecondition = false;
                            result.ErrorMessage = "Cannot create upgrade appointment without upgrade request";
                        }
                        break;
                    case AppointmentReason.Support:
                        break;
                    case AppointmentReason.Incident:
                        validPrecondition = false;
                        result.ErrorMessage = "Cannot create incident appointment";
                        break;
                }
            }

            if (validPrecondition)
            {
                var appointment = _mapper.Map<Appointment>(model);
                _dbContext.Appointments.Add(appointment);
                _dbContext.SaveChanges();

                var createRequestUpgradeAppointmentResults = new List<ResultModel>();
                if (model.RequestUpgradeIds != null)
                {
                    foreach (var requestUpgradeId in model.RequestUpgradeIds)
                    {
                        createRequestUpgradeAppointmentResults.Add(await CreateOneRequestUpgradeAppointment(appointment.Id, requestUpgradeId));
                    }

                    if (createRequestUpgradeAppointmentResults.Any(x => !x.Succeed))
                    {
                        result.ErrorMessage = createRequestUpgradeAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                        transaction.Rollback();
                        validPrecondition = false;
                    }
                }

                var createRequestExpandAppointmentResult = new ResultModel();
                if (validPrecondition && model.RequestExpandId != null)
                {
                    createRequestExpandAppointmentResult = await CreateOneRequestExpandAppointment(appointment.Id, model.RequestExpandId.Value);

                    if (!createRequestExpandAppointmentResult.Succeed)
                    {
                        result.ErrorMessage = createRequestExpandAppointmentResult.ErrorMessage;
                        transaction.Rollback();
                        validPrecondition = false;
                    }
                }

                if (validPrecondition)
                {
                    transaction.Commit();

                    var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                    var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                    foreach (var sale in sales)
                    {
                        await _notiService.Add(new NotificationCreateModel
                        {
                            UserId = sale.Id,
                            Action = "Created",
                            Title = "New appointment",
                            Body = "There's a new appointment just created",
                            Data = new NotificationData
                            {
                                Key = "Appointment",
                                Value = appointmentModelString
                            }
                        });
                    }
                    result.Succeed = true;
                    result.Data = new AppointmentCreateResultModel
                    {
                        RequestUpgradeAppointments = createRequestUpgradeAppointmentResults.Select(x => x.Data),
                        RequestExpandAppointment = createRequestExpandAppointmentResult.Data,
                        Appointment = _mapper.Map<AppointmentResultModel>(appointment)
                    };
                }
            }
        }
        catch (Exception e)
        {
            transaction.Rollback();
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateIncident(AppointmentIncidentCreateModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        using var transaction = _dbContext.Database.BeginTransaction();

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var appointment = _mapper.Map<Appointment>(model);
                appointment.Status = RequestStatus.Accepted;
                appointment.Reason = AppointmentReason.Incident;
                _dbContext.Appointments.Add(appointment);
                _dbContext.SaveChanges();
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    Action = RequestUserAction.Execute,
                    AppointmentId = appointment.Id,
                    UserId = userId
                });
                _dbContext.SaveChanges();

                var createIncidentAppointmentResult = await CreateOneIncidentAppointment(appointment.Id, model.IncidentId, userId);


                if (!createIncidentAppointmentResult.Succeed)
                {
                    result.ErrorMessage = createIncidentAppointmentResult.ErrorMessage;
                    transaction.Rollback();
                }
                else
                {
                    transaction.Commit();
                    var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                    var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                    foreach (var sale in sales)
                    {
                        await _notiService.Add(new NotificationCreateModel
                        {
                            UserId = sale.Id,
                            Action = "Created",
                            Title = "New appointment",
                            Body = "There's a new appointment just created",
                            Data = new NotificationData
                            {
                                Key = "Appointment",
                                Value = appointmentModelString
                            }
                        });
                    }
                    result.Succeed = true;
                    result.Data = _mapper.Map<AppointmentResultModel>(appointment);
                }
            }
        }
        catch (Exception e)
        {
            transaction.Rollback();
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateRequestAppointment(int appointmentId, RequestAppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        using var transaction = _dbContext.Database.BeginTransaction();

        if (model.RequestUpgradeIds.Any() && model.RequestExpandId != null)
        {
            result.ErrorMessage = "Cannot have both upgrade and expand request";
            return result;
        }

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointment)
                .Include(x => x.RequestExpandAppointments)
                .FirstOrDefault(x => x.Id == appointmentId && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING;
            }
            else
            {
                _dbContext.RequestUpgradeAppointments.RemoveRange(appointment.RequestUpgradeAppointment);
                _dbContext.RequestExpandAppointments.RemoveRange(appointment.RequestExpandAppointments);
                _dbContext.SaveChanges();
            }

            var createRequestUpgradeAppointmentResults = new List<ResultModel>();
            if (validPrecondition)
            {
                foreach (var requestUpgradeId in model.RequestUpgradeIds)
                {
                    createRequestUpgradeAppointmentResults.Add(await CreateOneRequestUpgradeAppointment(appointmentId, requestUpgradeId));
                }

                if (createRequestUpgradeAppointmentResults.Any(x => !x.Succeed))
                {
                    result.ErrorMessage = createRequestUpgradeAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                    transaction.Rollback();
                    validPrecondition = false;
                }
            }

            var createRequestExpandAppointmentResult = new ResultModel();
            if (validPrecondition)
            {
                if (model.RequestExpandId != null)
                {
                    createRequestExpandAppointmentResult = await CreateOneRequestExpandAppointment(appointment.Id, model.RequestExpandId.Value);
                }

                if (!createRequestExpandAppointmentResult.Succeed)
                {
                    result.ErrorMessage = createRequestExpandAppointmentResult.ErrorMessage;
                    transaction.Rollback();
                    validPrecondition = false;
                }
            }

            if (validPrecondition)
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = new RequestAppointmentCreateResultModel
                {
                    RequestUpgradeAppointments = createRequestUpgradeAppointmentResults.Select(x => x.Data),
                    RequestExpandAppointment = createRequestExpandAppointmentResult.Data,
                };
            }
        }
        catch (Exception e)
        {
            transaction.Rollback();
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private async Task<ResultModel> CreateOneRequestUpgradeAppointment(int appointmentId, int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedRequestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.Include(x => x.Appointment).FirstOrDefault(x => x.AppointmentId == appointmentId && x.RequestUpgradeId == requestUpgradeId && x.Appointment.Status != RequestStatus.Denied && x.Appointment.Status != RequestStatus.Failed);
            if (existedRequestUpgradeAppointment != null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeAppointmentErrorMessgae.EXISTED;
            }
            else
            {
                var appoitment = _dbContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);
                if (appoitment == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                }
                else if (appoitment.Status != RequestStatus.Waiting && appoitment.Status != RequestStatus.Accepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING + "/" + AppointmentErrorMessage.NOT_ACCEPTED;
                }
                else
                {
                    var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == requestUpgradeId);
                    if (requestUpgrade == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                    }
                    else if (requestUpgrade.Status != RequestStatus.Accepted && requestUpgrade.Status != RequestStatus.Waiting)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestUpgradeErrorMessage.NOT_ACCEPTED + ". " + RequestUpgradeErrorMessage.NOT_WAITING;
                    }
                    else if (requestUpgrade.ServerAllocationId != appoitment.ServerAllocationId)
                    {
                        result.ErrorMessage = "Request upgrade and appointment must belong to the same server allocation";
                        validPrecondition = false;
                    }
                }
            }

            if (validPrecondition)
            {
                var requestUpgradeAppointment = new RequestUpgradeAppointment
                {
                    RequestUpgradeId = requestUpgradeId,
                    AppointmentId = appointmentId,
                };
                _dbContext.RequestUpgradeAppointments.Add(requestUpgradeAppointment);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeAppointmentModel>(requestUpgradeAppointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private async Task<ResultModel> CreateOneRequestExpandAppointment(int appointmentId, int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedRequestExpandAppointment = _dbContext.RequestExpandAppointments.Include(x => x.Appointment).FirstOrDefault(x => !x.ForRemoval && x.AppointmentId == appointmentId && x.RequestExpandId == requestExpandId && x.Appointment.Status != RequestStatus.Denied && x.Appointment.Status != RequestStatus.Failed);
            RequestExpand requestExpand = null;
            if (existedRequestExpandAppointment != null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.EXISTED;
            }
            else
            {
                var appoitment = _dbContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);
                if (appoitment == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                }
                else if (appoitment.Status != RequestStatus.Waiting && appoitment.Status != RequestStatus.Accepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING + "/" + AppointmentErrorMessage.NOT_ACCEPTED;
                }
                else
                {
                    requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
                    if (requestExpand == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                    }
                    else if (requestExpand.Status != RequestStatus.Accepted && requestExpand.Status != RequestStatus.Waiting)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestExpandErrorMessage.NOT_ACCEPTED + ". " + RequestExpandErrorMessage.NOT_WAITING;
                    }
                    else if (requestExpand.ServerAllocationId != appoitment.ServerAllocationId)
                    {
                        result.ErrorMessage = "Request expand and appointment must belong to the same server allocation";
                        validPrecondition = false;
                    }
                }
            }

            if (validPrecondition)
            {
                var requestExpandAppointment = new RequestExpandAppointment
                {
                    ForRemoval = requestExpand.ForRemoval,
                    RequestExpandId = requestExpandId,
                    AppointmentId = appointmentId,
                };
                _dbContext.RequestExpandAppointments.Add(requestExpandAppointment);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandAppointmentModel>(requestExpandAppointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private async Task<ResultModel> CreateOneIncidentAppointment(int appointmentId, int incidentId, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedIncidentAppointment = _dbContext.IncidentAppointments.Include(x => x.Appointment).FirstOrDefault(x => x.AppointmentId == appointmentId && x.IncidentId == incidentId && x.Appointment.Status != RequestStatus.Denied && x.Appointment.Status != RequestStatus.Failed);
            Incident incident = null;
            if (existedIncidentAppointment != null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Incident have active appointment";
            }
            else
            {
                var appoitment = _dbContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);
                if (appoitment == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                }
                else if (appoitment.Status != RequestStatus.Waiting && appoitment.Status != RequestStatus.Accepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING + "/" + AppointmentErrorMessage.NOT_ACCEPTED;
                }
                else
                {
                    incident = _dbContext.Incidents.FirstOrDefault(x => x.Id == incidentId && !x.IsResolved);
                    if (incident == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = IncidentErrorMessage.NOT_EXISTED;
                    }
                    else if (!incident.IsResolvByClient)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Incident will be resolv by Quang Trung";
                    }
                    else if (incident.ServerAllocationId != appoitment.ServerAllocationId)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Incident and appointment must belong to the same server allocation";
                    }
                }
            }

            if (validPrecondition)
            {
                var incidentAppointment = new IncidentAppointment
                {
                    IncidentId = incidentId,
                    AppointmentId = appointmentId,
                };
                _dbContext.IncidentUsers.Add(new IncidentUser
                {
                    Action = RequestUserAction.Execute,
                    IncidentId = incidentId,
                    UserId = userId
                });
                _dbContext.IncidentAppointments.Add(incidentAppointment);
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

    public async Task<ResultModel> Update(AppointmentUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments.Include(x => x.ServerAllocation).FirstOrDefault(x => x.Id == model.Id && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            var user = _dbContext.User.FirstOrDefault(x => x.Id == model.UserId);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }

            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                _dbContext.AppointmentUsers.RemoveRange(_dbContext.AppointmentUsers.Where(x => x.AppointmentId == appointment.Id && x.Action == RequestUserAction.Execute));
                _mapper.Map<AppointmentUpdateModel, Appointment>(model, appointment);
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    Action = RequestUserAction.Execute,
                    AppointmentId = appointment.Id,
                    UserId = model.UserId
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentResultModel>(appointment);
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
            var appointment = _dbContext.Appointments.Include(x => x.RequestUpgradeAppointment).FirstOrDefault(x => x.Id == id);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING;
            }
            else
            {
                appointment.Status = RequestStatus.Failed;
                appointment.Note = "Khách hàng xóa";
                _dbContext.SaveChanges();

                var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                foreach (var sale in sales)
                {
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = sale.Id,
                        Action = "Canceled",
                        Title = "Appointment canceled",
                        Body = "There's an appointment just canceled by customer",
                        Data = new NotificationData
                        {
                            Key = "Appointment",
                            Value = appointmentModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = appointment.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Accept(int appointmentId, Guid userId, UserAssignModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade).ThenInclude(x => x.RequestUpgradeUsers)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.RequestExpandUsers)
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
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

            if (validPrecondition && appointment.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                appointment.Status = RequestStatus.Accepted;
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    Action = RequestUserAction.Evaluate,
                    AppointmentId = appointment.Id,
                    UserId = userId
                });

                if (executor != null)
                {
                    _dbContext.AppointmentUsers.Add(new AppointmentUser
                    {
                        Action = RequestUserAction.Execute,
                        AppointmentId = appointmentId,
                        UserId = executor.Id,
                    });
                }

                foreach (var requestUpgrade in appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade))
                {
                    requestUpgrade.Status = RequestStatus.Accepted;
                    _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                    {
                        Action = RequestUserAction.Evaluate,
                        RequestUpgradeId = requestUpgrade.Id,
                        UserId = userId
                    });

                    _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                    {
                        Action = RequestUserAction.Execute,
                        RequestUpgradeId = requestUpgrade.Id,
                        UserId = executor.Id
                    });
                }

                if (appointment.RequestExpandAppointments.Any())
                {
                    var requestExpand = appointment.RequestExpandAppointments.Select(x => x.RequestExpand).FirstOrDefault();
                    requestExpand.Status = RequestStatus.Accepted;
                    if (requestExpand.ForRemoval)
                    {
                        appointment.ServerAllocation.Status = ServerAllocationStatus.Pausing;
                    }
                    _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                    {
                        Action = RequestUserAction.Evaluate,
                        RequestExpandId = requestExpand.Id,
                        UserId = userId
                    });

                    _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                    {
                        Action = RequestUserAction.Execute,
                        RequestExpandId = requestExpand.Id,
                        UserId = executor.Id
                    });
                }

                _dbContext.SaveChanges();
                var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = appointment.ServerAllocation.CustomerId,
                    Action = "Accepted",
                    Title = "Appointment accepted",
                    Body = "There's an appointment just accepted",
                    Data = new NotificationData
                    {
                        Key = "Appointment",
                        Value = appointmentModelString
                    }
                });
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = executor.Id,
                    Action = "Assigned",
                    Title = "Assigned to appointment",
                    Body = "There's an appointment just assigned to you",
                    Data = new NotificationData
                    {
                        Key = "Appointment",
                        Value = appointmentModelString
                    }
                });
                if (appointment.RequestExpandAppointments.Any(x => x.ForRemoval))
                {
                    var serverModelString = JsonSerializer.Serialize(_mapper.Map<ServerAllocationResultModel>(appointment.ServerAllocation));
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = appointment.ServerAllocation.CustomerId,
                        Action = "Paused",
                        Title = "Server paused",
                        Body = "There's an server just paused",
                        Data = new NotificationData
                        {
                            Key = "ServerAllocation",
                            Value = serverModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentResultModel>(appointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Deny(int appointmentId, Guid userId, DenyModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand)
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition && appointment.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                appointment.Status = RequestStatus.Denied;
                appointment.SaleNote = model.SaleNote;
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    Action = RequestUserAction.Evaluate,
                    AppointmentId = appointment.Id,
                    UserId = userId
                });

                var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = appointment.ServerAllocation.CustomerId,
                    Action = "Denied",
                    Title = "Appointment denied",
                    Body = "There's an appointment just denied",
                    Data = new NotificationData
                    {
                        Key = "Appointment",
                        Value = appointmentModelString
                    }
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentResultModel>(appointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignTech(int appointmentId, UserAssignModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
            var appointment = _dbContext.Appointments.Include(x => x.AppointmentUsers).FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
            }
            else if (user == null)
            {
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }
            else
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (!roles.Contains(RoleType.Tech.ToString()))
                {
                    result.ErrorMessage = "User assigned is not a tech";
                }
                else
                {
                    var existedExecutor = appointment.AppointmentUsers?.FirstOrDefault(x => x.Action == RequestUserAction.Execute);
                    if (existedExecutor != null)
                    {
                        _dbContext.AppointmentUsers.Remove(existedExecutor);
                    }
                    _dbContext.AppointmentUsers.Add(new AppointmentUser
                    {
                        Action = RequestUserAction.Execute,
                        AppointmentId = appointmentId,
                        UserId = user.Id,
                    });
                    _dbContext.SaveChanges();
                    result.Succeed = true;
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        using var transaction = _dbContext.Database.BeginTransaction();

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade).ThenInclude(x => x.ServerAllocation)
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Reason == AppointmentReason.Incident)
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot complete incident appointment";
            }
            else
            {
                validPrecondition = IsCompletable(appointmentId, result, userId);
            }

            if ((appointment.ReceiptOfRecipientFilePath == null ||
                appointment.InspectionReportFilePath == null) && model.DocumentModel == null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Need inspection report to complete";
            }

            if (validPrecondition)
            {
                _mapper.Map<AppointmentCompleteModel, Appointment>(model, appointment);
                appointment.Status = RequestStatus.Success;
                _dbContext.SaveChanges();

                var requestUpgradeResults = new List<ResultModel>();
                if (appointment.RequestUpgradeAppointment.Any())
                {
                    var createReceiptResult = await CreateUpgradeReceiptReport(appointment.Id, model.DocumentModel);
                    if (!createReceiptResult.Succeed)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = createReceiptResult.ErrorMessage;
                    }
                    else
                    {
                        appointment.ReceiptOfRecipientFilePath = createReceiptResult.Data as string;
                        foreach (var requestUpgradeId in appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgradeId))
                        {
                            requestUpgradeResults.Add(await CompleteRequestUpgrade(requestUpgradeId));
                        }
                        var createInspectionResult = await CreateUpgradeInspectionReport(appointment.ServerAllocationId, model.DocumentModel);
                        if (!createInspectionResult.Succeed)
                        {
                            validPrecondition = false;
                            result.ErrorMessage = createInspectionResult.ErrorMessage;
                        }
                        else
                        {
                            appointment.InspectionReportFilePath = createInspectionResult.Data as string;
                            _dbContext.SaveChanges();
                        }
                    }
                }

                var requestExpandResult = new ResultModel();
                if (appointment.RequestExpandAppointments.Any())
                {
                    var requestExpand = appointment.RequestExpandAppointments.FirstOrDefault().RequestExpand;

                    if (!requestExpand.ForRemoval)
                    {
                        requestExpandResult = await CompleteRequestExpand(requestExpand.Id);
                    }
                    var createInspectionResult = await CreateExpandInspectionReport(appointment.ServerAllocationId, model.DocumentModel);
                    var createReceiptResult = await CreateExpandReceiptReport(requestExpand.Id, model.DocumentModel);
                    if (!createInspectionResult.Succeed)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = createInspectionResult.ErrorMessage;
                    }
                    else if (!createReceiptResult.Succeed)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = createReceiptResult.ErrorMessage;
                    }
                    else
                    {
                        var serverAllocation = appointment.ServerAllocation;
                        if (!requestExpand.ForRemoval)
                        {
                            serverAllocation.InspectionRecordFilePath = createInspectionResult.Data as string;
                            serverAllocation.ReceiptOfRecipientFilePath = createReceiptResult.Data as string;
                        }
                        else
                        {
                            requestExpandResult = await CompleteRemoval(requestExpand.Id);
                            serverAllocation.RemovalFilePath = createReceiptResult.Data as string;
                        }
                        appointment.InspectionReportFilePath = createInspectionResult.Data as string;
                        appointment.ReceiptOfRecipientFilePath = createReceiptResult.Data as string;

                        _dbContext.SaveChanges();
                    }
                }

                if (!requestExpandResult.Succeed)
                {
                    transaction.Rollback();
                    result.ErrorMessage = requestExpandResult.ErrorMessage;
                }
                else if (requestUpgradeResults.Any(x => !x.Succeed))
                {
                    transaction.Rollback();
                    result.ErrorMessage = requestUpgradeResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                }
                else if (!validPrecondition)
                {
                    transaction.Rollback();
                }
                else
                {
                    var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = appointment.ServerAllocation.CustomerId,
                        Action = "Complete",
                        Title = "Appointment complete",
                        Body = "There's an appointment and all associated request just complete",
                        Data = new NotificationData
                        {
                            Key = "Appointment",
                            Value = appointmentModelString
                        }
                    });
                    if (appointment.RequestExpandAppointments.Any(x => x.ForRemoval))
                    {
                        var serverModelString = JsonSerializer.Serialize(_mapper.Map<ServerAllocationResultModel>(appointment.ServerAllocation));
                        await _notiService.Add(new NotificationCreateModel
                        {
                            UserId = appointment.ServerAllocation.CustomerId,
                            Action = "Removed",
                            Title = "Server removed",
                            Body = "There's an server just removed",
                            Data = new NotificationData
                            {
                                Key = "ServerAllocation",
                                Value = serverModelString
                            }
                        });
                    }

                    result.Succeed = true;
                    transaction.Commit();
                }
            }
        }
        catch (Exception e)
        {
            transaction.Rollback();
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IsCompletable(int appointmentId, ResultModel result, Guid userId)
    {
        bool validPrecondition = true;
        var appointment = _dbContext.Appointments
            .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.RequestExpandLocations)
            .Include(x => x.RequestUpgradeAppointment)
            .Include(x => x.AppointmentUsers)
            .FirstOrDefault(x => x.Id == appointmentId);
        if (appointment == null)
        {
            validPrecondition = false;
            result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
        }

        if (appointment.Status != RequestStatus.Accepted)
        {
            validPrecondition = false;
            result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
        }

        if (appointment.RequestExpandAppointments.Select(x => x.RequestExpand).Any(x => !x.RequestExpandLocations.Any() && !x.ForRemoval))
        {
            validPrecondition = false;
            result.ErrorMessage = "Please assign location to all request expand to complete the appointment";
        }

        var executor = _dbContext.AppointmentUsers.FirstOrDefault(x => x.AppointmentId == appointment.Id && x.Action == RequestUserAction.Execute);
        if (executor == null)
        {
            validPrecondition = false;
            result.ErrorMessage = "Appointment must have an assigned tech";
        }
        else if (executor.UserId != userId)
        {
            validPrecondition = false;
            result.ErrorMessage = "Unassigned tech cannot complete this appointment";
        }

        return validPrecondition;
    }

    private async Task<ResultModel> CompleteRequestUpgrade(int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgrade = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.Component).FirstOrDefault(x => x.Id == requestUpgradeId && x.Status == RequestStatus.Accepted);
            ServerHardwareConfig serverHardwareConfig = null;
            if (requestUpgrade == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
            }
            else if (!requestUpgrade.ServerAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot modify unallocated server";
            }
            else
            {
                serverHardwareConfig = requestUpgrade.ServerAllocation?.ServerHardwareConfigs?.FirstOrDefault(x => x.ComponentId == requestUpgrade.ComponentId);
            }

            if (validPrecondition)
            {
                if (serverHardwareConfig == null)
                {
                    _dbContext.ServerHardwareConfigs.Add(new ServerHardwareConfig
                    {
                        Description = requestUpgrade.Description,
                        ServerAllocationId = requestUpgrade.ServerAllocationId,
                        ComponentId = requestUpgrade.ComponentId
                    });
                }
                else
                {
                    serverHardwareConfig.Description = requestUpgrade.Description;
                }
                requestUpgrade.Status = RequestStatus.Success;
                requestUpgrade.ServerAllocation.DateUpdated = DateTime.UtcNow;
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

    public async Task<ResultModel> CompleteRequestExpand(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == requestExpandId && x.Status == RequestStatus.Accepted);
            ServerAllocation serverAllocation = null;
            var requiredComponents = _dbContext.Components.Where(x => x.IsRequired);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else
            {
                serverAllocation = requestExpand.ServerAllocation;
                foreach (var component in requiredComponents)
                {
                    if (serverAllocation.ServerHardwareConfigs?.FirstOrDefault(x => x.ComponentId == component.Id) == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Cannot allocate server missing config for required component";
                    }

                    if (serverAllocation.SerialNumber == null || serverAllocation.Power == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Server must have serial number and power";
                    }
                }
            }

            List<Location> locations = null;
            if (validPrecondition)
            {
                locations = requestExpand.RequestExpandLocations.Select(x => x.Location).ToList();
                if (!locations.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = "Request dont have target location";
                }
            }

            if (validPrecondition)
            {
                var locationAssignments = new List<LocationAssignment>();
                foreach (var location in locations)
                {
                    locationAssignments.Add(new LocationAssignment
                    {
                        ServerAllocationId = requestExpand.ServerAllocationId,
                        LocationId = location.Id
                    });
                }
                _dbContext.LocationAssignments.AddRange(locationAssignments);
                requestExpand.Status = RequestStatus.Success;
                requestExpand.SuccessExpandAppointmentId = requestExpand.RequestExpandAppointments.Select(x => x.Appointment).FirstOrDefault(x => x.Status == RequestStatus.Success).Id;
                serverAllocation.DateUpdated = DateTime.UtcNow;
                _dbContext.SaveChanges();

                serverAllocation = _dbContext.ServerAllocations
                    .Include(x => x.IpAssignments)
                    .ThenInclude(x => x.IpAddress)
                    .Include(x => x.Customer)
                    .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                    .FirstOrDefault(x => x.Id == serverAllocation.Id);
                serverAllocation.ServerLocation = serverAllocation.GetServerLocation();
                _dbContext.SaveChanges();
                result.Succeed = true;
                //result.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateUpgradeInspectionReport(int serverAllocationId, ServerAllocationCreateRequestExpandInspectionReportModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            string inputPath = Path.Combine(_env.WebRootPath, "Report", "UpgradeAndHostTemplate.docx");
            string outputPath = Path.Combine(_env.WebRootPath, "Report", "BBNT.docx");
            var serverAllocation = _dbContext.ServerAllocations
               .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Include(x => x.Customer)
               .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
               .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
               .FirstOrDefault(x => x.Id == serverAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                File.Copy(inputPath, outputPath, true);
                var customer = serverAllocation.Customer;
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
                    var now = DateTime.UtcNow;
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                    document.RenderText("__Date__", now.ToString("dd/MM/yyyy"));

                    document.RenderText("__Number__", textInfo.ToTitleCase(customer.ContractNumber.ToString()));

                    document.RenderText("__CustomerName__", textInfo.ToTitleCase(customer.Representator));

                    document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());

                    document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(customer.RepresentatorPosition));

                    document.RenderText("__CustomerAddress__", serverAllocation.Customer.Address);

                    document.RenderText("__CustomerPhoneNumber__", serverAllocation.Customer.PhoneNumber);

                    document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));

                    document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

                    document.RenderText("__Location__", textInfo.ToTitleCase(model.Location));

                    document.TickCheckBoxInDocx("Allocation");

                    document.RenderText("__ServerName__", serverAllocation.Name);

                    var cpus = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "CPU").Description);
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

                    var rams = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "RAM").Description);
                    var ramCapacity = 0;
                    for (int i = 0; i < rams.Count(); i++)
                    {
                        ramCapacity += rams[i].Capacity.Value;
                    }
                    document.RenderText("__Ram__", ramCapacity + "Gb");

                    var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "Harddisk").Description);
                    var hardDiskCapacity = 0;
                    for (int i = 0; i < hardDisks.Count(); i++)
                    {
                        hardDiskCapacity += hardDisks[i].Capacity.Value;
                    }
                    document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

                    document.RenderText("__ServerLocation__", serverAllocation.ServerLocation);

                    document.RenderText("__SerialNumber__", serverAllocation.SerialNumber);

                    document.RenderText("__Power__", serverAllocation.Power + "W");

                    if (serverAllocation.MasterIpAddress != null)
                    {
                        document.RenderText("__MasterIP__", serverAllocation.MasterIpAddress);
                    }

                    document.RenderText("__Action__", "");

                    document.RenderText("__RequestHostIpCount__", "");

                    document.RenderText("__RequestHostIpAddreses__", "");

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

    public async Task<ResultModel> CreateExpandInspectionReport(int serverAllocationId, ServerAllocationCreateRequestExpandInspectionReportModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            string inputPath = Path.Combine(_env.WebRootPath, "Report", "ExpandTemplate.docx");
            string outputPath = Path.Combine(_env.WebRootPath, "Report", "Result.docx");
            var serverAllocation = _dbContext.ServerAllocations
               .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Include(x => x.Customer)
               .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
               .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
               .FirstOrDefault(x => x.Id == serverAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                File.Copy(inputPath, outputPath, true);
                var customer = serverAllocation.Customer;
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                    document.RenderText("__Number__", textInfo.ToTitleCase(customer.ContractNumber.ToString()));

                    var now = DateTime.UtcNow;
                    document.RenderText("__Time__", now.ToString("dd/MM/yyyy"));
                    document.RenderText("__Time__", now.ToString("dd/MM/yyyy"));

                    document.RenderText("__CustomerName__", textInfo.ToTitleCase(customer.Representator));

                    document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());

                    document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(customer.RepresentatorPosition));

                    document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));

                    document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

                    document.RenderText("__Location__", model.Location);

                    document.RenderText("__Username__", model.Username);

                    if (model.isSendMS)
                    {
                        document.TickCheckBoxInDocx("Password");
                    }

                    document.TickCheckBoxInDocx("Allocation");

                    var cpus = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "CPU").Description);
                    var cpuString = "";
                    for (int i = 0; i < cpus.Count(); i++)
                    {
                        cpuString += cpus[i].Model;
                        if (i != cpus.Count() - 1)
                        {
                            cpuString += ", ";
                        }
                    }
                    document.RenderText("__Model__", cpuString);

                    var cpuCpu = "";
                    for (int i = 0; i < cpus.Count(); i++)
                    {
                        cpuString += cpus[i].SerialNumber;
                        if (i != cpus.Count() - 1)
                        {
                            cpuString += ", ";
                        }
                    }
                    document.RenderText("__CPU__", cpuString);

                    var rams = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "RAM").Description);
                    var ramCapacity = 0;
                    for (int i = 0; i < rams.Count(); i++)
                    {
                        ramCapacity += rams[i].Capacity.Value;
                    }
                    document.RenderText("__Memory__", ramCapacity + "Gb");

                    var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "Harddisk").Description);
                    var hardDiskCapacity = 0;
                    for (int i = 0; i < hardDisks.Count(); i++)
                    {
                        hardDiskCapacity += hardDisks[i].Capacity.Value;
                    }
                    document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

                    document.RenderText("__Power__", serverAllocation.Power + "W");

                    if (serverAllocation.MasterIpAddress != null)
                    {
                        document.RenderText("__MasterIp__", serverAllocation.MasterIpAddress);
                    }

                    document.RenderText("__Rack__", serverAllocation.ServerLocation);

                    document.RenderText("__SerialNo__", serverAllocation.SerialNumber);

                    document.RenderText("__Size__", serverAllocation.LocationAssignments.Count() + "U");

                    document.RenderText("__IPAddress__", serverAllocation.MasterIpAddress);

                    document.RenderText("__Gateway__", serverAllocation?.IpAssignments?.FirstOrDefault(x => x.Type == IpAssignmentTypes.Master)?.IpAddress?.IpSubnet?.IpAddresses?.FirstOrDefault(x => x.Purpose == IpPurpose.Gateway)?.Address);

                    document.RenderText("__SubnetMask__", IpAddress.GetDefaultSubnetMask(serverAllocation.MasterIpAddress));

                    if (model.Good)
                    {
                        document.TickCheckBoxInDocx("Evaluate");
                    }

                    if (model.Guid)
                    {
                        document.TickCheckBoxInDocx("Guided");
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

    public async Task<ResultModel> CreateUpgradeReceiptReport(int appointmentId, ServerAllocationCreateRequestExpandInspectionReportModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            string inputPath = Path.Combine(_env.WebRootPath, "Report", "Template2.docx");
            string outputPath = Path.Combine(_env.WebRootPath, "Report", "Result.docx");
            var appointment = _dbContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);
            var serverAllocation = _dbContext.ServerAllocations
               .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Include(x => x.Customer)
               .Include(x => x.RequestUpgrades).ThenInclude(x => x.Component)
               .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
               .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
               .FirstOrDefault(x => x.Id == appointment.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (!serverAllocation.LocationAssignments.Any())
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
            }

            else
            {
                File.Copy(inputPath, outputPath, true);
                var customer = serverAllocation.Customer;
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                    var now = DateTime.UtcNow;
                    document.RenderText("__Time__", $"{now.Hour} Giờ {now.Minute} Phút");
                    document.RenderText("__Date__", $"ngày {now.Day:dd} tháng {now.Month:MM} Năm {now.Year}");
                    document.RenderText("__Location__", model.Location);

                    document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());
                    document.RenderText("__CustomerName__", textInfo.ToTitleCase(customer.Representator));
                    document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(customer.RepresentatorPosition));
                    document.RenderText("__Address__", serverAllocation.Customer.Address);
                    document.RenderText("__PhoneNumber__", serverAllocation.Customer.PhoneNumber);
                    document.RenderText("__Email__", serverAllocation.Customer.Email);

                    document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));
                    document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

                    document.RenderText("__DeviceCondition__", model.DeviceCondition);

                    int counter = 1;
                    var receiptReportModels = new List<ReceiptReportModel>();
                    foreach (var requestUpgrade in appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade))
                    {
                        var requestUpgradeDescriptions = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(requestUpgrade.Description);
                        var hardwareDescriptions = new List<ConfigDescriptionModel>();
                        var hardware = serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.ComponentId == requestUpgrade.ComponentId);
                        if (hardware != null)
                        {
                            hardwareDescriptions.AddRange(JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(hardware.Description));
                        }
                        var unChange = requestUpgradeDescriptions.IntersectBy(hardwareDescriptions.Select(x => x.SerialNumber), x => x.SerialNumber).Select(x => x.SerialNumber);
                        requestUpgradeDescriptions.RemoveAll(x => unChange.Contains(x.SerialNumber));
                        hardwareDescriptions.RemoveAll(x => unChange.Contains(x.SerialNumber));
                        var newConfig = new ReceiptReportModel
                        {
                            PartNo = counter++,
                            Model = requestUpgrade.Component.Name + " - ",
                            Action = "Thêm",
                            Quantity = requestUpgradeDescriptions.Count,
                            Unit = "Cái",
                            SerialNumber = ""
                        };

                        for (int i = 0; i < requestUpgradeDescriptions.Count; i++)
                        {
                            newConfig.Model += requestUpgradeDescriptions[i].Model;
                            newConfig.SerialNumber += requestUpgradeDescriptions[i].SerialNumber;
                            if (i < requestUpgradeDescriptions.Count - 1)
                            {
                                newConfig.Model += ", ";
                                newConfig.SerialNumber += ", ";
                            }
                        }
                        receiptReportModels.Add(newConfig);

                        if (hardwareDescriptions.Any())
                        {
                            var oldConfig = new ReceiptReportModel
                            {
                                PartNo = counter++,
                                Model = hardware.Component.Name + " - ",
                                Action = "Gỡ",
                                Quantity = hardwareDescriptions.Count,
                                Unit = "Cái",
                                SerialNumber = ""
                            };

                            for (int i = 0; i < hardwareDescriptions.Count; i++)
                            {
                                oldConfig.Model += hardwareDescriptions[i].Model;
                                oldConfig.SerialNumber += hardwareDescriptions[i].SerialNumber;
                                if (i < hardwareDescriptions.Count - 1)
                                {
                                    oldConfig.Model += ", ";
                                    oldConfig.SerialNumber += ", ";
                                }
                            }
                            receiptReportModels.Add(oldConfig);
                        }
                    }
                    document.InsertToSingleTable(receiptReportModels);
                    document.MainDocumentPart.Document.Save();
                }
                string receiptOfRecipientFileName = _cloudinaryHelper.UploadFile(outputPath);
                serverAllocation.ReceiptOfRecipientFilePath = receiptOfRecipientFileName;
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = receiptOfRecipientFileName;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateExpandReceiptReport(int requestExpandId, ServerAllocationCreateRequestExpandInspectionReportModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            string inputPath = Path.Combine(_env.WebRootPath, "Report", "Template2.docx");
            string outputPath = Path.Combine(_env.WebRootPath, "Report", "Result.docx");
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
            var serverAllocation = _dbContext.ServerAllocations
               .Include(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
               .Include(x => x.Customer)
               .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
               .Include(x => x.LocationAssignments).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
               .FirstOrDefault(x => x.Id == requestExpand.ServerAllocationId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (!requestExpand.ForRemoval && serverAllocation.Status != ServerAllocationStatus.Waiting)
            {
                result.ErrorMessage = "Server need to be waiting for allocation";
            }
            else if (requestExpand.ForRemoval && serverAllocation.Status != ServerAllocationStatus.Pausing)
            {
                result.ErrorMessage = "Server need to be pausing to be remove";
            }
            else if (!serverAllocation.LocationAssignments.Any())
            {
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
            }
            else if (!serverAllocation.IpAssignments.Any())
            {
                result.ErrorMessage = IpAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                File.Copy(inputPath, outputPath, true);
                var customer = serverAllocation.Customer;
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                    var now = DateTime.UtcNow;
                    document.RenderText("__Time__", $"{now.Hour} Giờ {now.Minute} Phút");
                    document.RenderText("__Date__", $"ngày {now.Day:dd)} tháng {now.Month:MM} Năm {now.Year}");
                    document.RenderText("__Location__", model.Location);

                    document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());
                    document.RenderText("__CustomerName__", textInfo.ToTitleCase(customer.Representator));
                    document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(customer.RepresentatorPosition));
                    document.RenderText("__Address__", serverAllocation.Customer.Address);
                    document.RenderText("__PhoneNumber__", serverAllocation.Customer.PhoneNumber);
                    document.RenderText("__Email__", serverAllocation.Customer.Email);

                    document.RenderText("__QTName__", textInfo.ToTitleCase(model.QTName));
                    document.RenderText("__Position__", textInfo.ToTitleCase(model.Position));

                    document.RenderText("__DeviceCondition__", model.DeviceCondition);

                    int counter = 1;
                    var receiptReportModels = new List<ReceiptReportModel>();
                    foreach (var hardware in serverAllocation.ServerHardwareConfigs)
                    {
                        List<ConfigDescriptionModel> descriptions = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(hardware.Description);
                        var receiptReportModel = new ReceiptReportModel
                        {
                            PartNo = counter++,
                            Model = hardware.Component.Name + " - ",
                            Action = "Thêm",
                            Quantity = descriptions.Count,
                            Unit = "Cái",
                            SerialNumber = ""
                        };

                        for (int i = 0; i < descriptions.Count; i++)
                        {
                            receiptReportModel.Model += descriptions[i].Model;
                            receiptReportModel.SerialNumber += descriptions[i].SerialNumber;
                            if (i < descriptions.Count - 1)
                            {
                                receiptReportModel.Model += ", ";
                                receiptReportModel.SerialNumber += ", ";
                            }
                        }
                        receiptReportModels.Add(receiptReportModel);
                    }
                    document.InsertToSingleTable(receiptReportModels);
                    document.MainDocumentPart.Document.Save();
                }
                //var formfile = document.ConvertToIFormFile(outputPath);
                string receiptOfRecipientFileName = _cloudinaryHelper.UploadFile(outputPath);
                serverAllocation.ReceiptOfRecipientFilePath = receiptOfRecipientFileName;
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = receiptOfRecipientFileName;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CompleteRemoval(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.LocationAssignments)
                .FirstOrDefault(x => x.Id == requestExpandId);
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.RequestExpands)
                .Include(x => x.RequestUpgrades)
                .Include(x => x.LocationAssignments)
                .Include(x => x.Appointments)
                .Include(x => x.RequestHosts)
                .Include(x => x.IpAssignments)
                .FirstOrDefault(x => x.RequestExpands.Any(x => x.Id == requestExpandId));
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestExpand.Status != RequestStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.REMOVAL_NOT_ACCEPTED;
            }

            if (validPrecondition)
            {
                requestExpand.ServerAllocation.ServerLocation = null;
                requestExpand.Status = RequestStatus.Success;
                serverAllocation.Status = ServerAllocationStatus.Removed;
                foreach (var appointment in serverAllocation.Appointments.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    appointment.Status = RequestStatus.Failed;
                }
                foreach (var expandRequest in serverAllocation.RequestExpands.Where(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted))
                {
                    expandRequest.Status = RequestStatus.Failed;
                }
                foreach (var requestHost in serverAllocation.RequestHosts.Where(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed))
                {
                    requestHost.Status = RequestHostStatus.Failed;
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

    public async Task<ResultModel> Fail(int appointmentId, AppointmentFailModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand).ThenInclude(x => x.RequestExpandUsers)
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade).ThenInclude(x => x.RequestUpgradeUsers)
                .FirstOrDefault(x => x.Id == appointmentId);
            AppointmentUser executor = null;
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                executor = _dbContext.AppointmentUsers.FirstOrDefault(x => x.AppointmentId == appointment.Id && x.Action == RequestUserAction.Execute);
                if (executor == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentUserErrorMessage.NOT_EXISTED;
                }
            }

            if (validPrecondition)
            {

                appointment.Status = RequestStatus.Failed;
                foreach (var requestUpgrade in appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade))
                {
                    _dbContext.RequestUpgradeUsers.Remove(requestUpgrade.RequestUpgradeUsers.FirstOrDefault(x => x.UserId == executor.UserId && x.Action == RequestUserAction.Execute));
                }

                foreach (var requestExpand in appointment.RequestExpandAppointments.Select(x => x.RequestExpand))
                {
                    _dbContext.RequestExpandUsers.Remove(requestExpand.RequestExpandUsers.FirstOrDefault(x => x.UserId == executor.UserId && x.Action == RequestUserAction.Execute));
                }
                appointment.TechNote = model.TechNote;
                _dbContext.SaveChanges();

                var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = appointment.ServerAllocation.CustomerId,
                    Action = "Reject",
                    Title = "Appointment failed",
                    Body = "There's an appointment just failed",
                    Data = new NotificationData
                    {
                        Key = "Appointment",
                        Value = appointmentModelString
                    }
                });
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentResultModel>(appointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Resolv(int appointmentId, AppointmentResolvModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        using var transaction = _dbContext.Database.BeginTransaction();

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.IncidentAppointments).ThenInclude(x => x.Incident)
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Reason != AppointmentReason.Incident)
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot resolv non incident appointment";
            }
            else
            {
                validPrecondition = IsCompletable(appointmentId, result, userId);
            }

            if (validPrecondition)
            {
                _mapper.Map<AppointmentResolvModel, Appointment>(model, appointment);
                appointment.Status = RequestStatus.Success;
                _dbContext.SaveChanges();
                var incident = appointment.IncidentAppointments.FirstOrDefault().Incident;
                var incidentResult = await ResolvIncident(incident.Id, model.IncidentResolvModel, userId);

                if (!incidentResult.Succeed)
                {
                    validPrecondition = false;
                    result.ErrorMessage = incidentResult.ErrorMessage;
                }
            }

            if (!validPrecondition)
            {
                transaction.Rollback();
            }
            else
            {
                var appointmentModelString = JsonSerializer.Serialize(_mapper.Map<AppointmentResultModel>(appointment));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = appointment.ServerAllocation.CustomerId,
                    Action = "Complete",
                    Title = "Appointment complete",
                    Body = "There's an appointment and incident just resolved",
                    Data = new NotificationData
                    {
                        Key = "Appointment",
                        Value = appointmentModelString
                    }
                });

                result.Succeed = true;
                transaction.Commit();
            }
        }
        catch (Exception e)
        {
            transaction.Rollback();
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private async Task<ResultModel> ResolvIncident(int incidentId, IncidentResolvModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var incident = _dbContext.Incidents
                .Include(x => x.IncidentAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.ServerAllocation)
                .Include(x => x.IncidentUsers).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == incidentId && !x.IsResolved);
            if (incident == null)
            {
                result.ErrorMessage = IncidentErrorMessage.NOT_EXISTED;
            }
            else
            {
                incident.Solution = model.Solution;
                incident.IsResolved = true;
                _dbContext.IncidentUsers.Add(new IncidentUser
                {
                    IncidentId = incident.Id,
                    UserId = userId,
                    Action = RequestUserAction.Execute
                });
                var serverAllocation = incident.ServerAllocation;
                bool stopPausing = serverAllocation.Status == ServerAllocationStatus.Pausing && !serverAllocation.Incidents.Any(x => !x.IsResolved && x.PausingRequired);
                if (stopPausing)
                {
                    serverAllocation.Status = ServerAllocationStatus.Working;
                }
                _dbContext.SaveChanges();

                var incidentModelString = JsonSerializer.Serialize(_mapper.Map<IncidentResultModel>(incident));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = serverAllocation.CustomerId,
                    Action = "Resolved",
                    Title = "Incident resolved",
                    Body = "There's an incident just resolved",
                    Data = new NotificationData
                    {
                        Key = "Incident",
                        Value = incidentModelString
                    }
                });
                if (stopPausing)
                {
                    var serverModelString = JsonSerializer.Serialize(_mapper.Map<ServerAllocationResultModel>(serverAllocation));
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = serverAllocation.CustomerId,
                        Action = "Resolved",
                        Title = "Incident resolved",
                        Body = "There's an incident just resolved",
                        Data = new NotificationData
                        {
                            Key = "ServerAllocation",
                            Value = serverModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = _mapper.Map<IncidentResultModel>(incident);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignInspectionReport(int appointmentId, DocumentFileUploadModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

            var appointment = _dbContext.Appointments
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade)
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (!appointment.RequestUpgradeAppointment.Any())
            {
                result.ErrorMessage = "Appointment does not have request upgrade!";
            }
            else if (appointment.Status != RequestStatus.Success)
            {
                result.ErrorMessage = "Appointment's status is not successed!";
            }
            else if (appointment.DocumentConfirm)
            {
                result.ErrorMessage = "Document already confirmed!";
            }
            else
            {
                string inspectionRecordFileName = _cloudinaryHelper.UploadFile(model.InspectionReport);
                string receiptOfRecipientFileName = _cloudinaryHelper.UploadFile(model.ReceiptOfRecipient);
                appointment.InspectionReportFilePath = inspectionRecordFileName;
                appointment.ReceiptOfRecipientFilePath = receiptOfRecipientFileName;
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

    public async Task<ResultModel> DocumentConfirmTrue(int appointmentId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {

            var appointment = _dbContext.Appointments
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Success)
            {
                result.ErrorMessage = "Appointment's status is not successed!";
            }
            else if (appointment.DocumentConfirm == true)
            {
                result.ErrorMessage = AppointmentErrorMessage.ALREADY_CONFIRM;
            }
            else
            {

                appointment.DocumentConfirm = true;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = appointment.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
