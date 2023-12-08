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
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestExpand(PagingParam<BaseSortCriteria> paginationModel, int id);
    Task<ResultModel> GetRequestUpgrade(int id, PagingParam<RequestUpgradeSortCriteria> paginationModel, RequestUpgradeSearchModel searchModel);
    Task<ResultModel> Create(AppointmentCreateModel model);
    Task<ResultModel> CreateRequestAppointment(int appointmentId, RequestAppointmentCreateModel model);
    Task<ResultModel> Update(AppointmentUpdateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Accept(int appointmentId, Guid userId, UserAssignModel model);
    Task<ResultModel> Deny(int appointmentId, Guid userId, DenyModel model);
    Task<ResultModel> AssignTech(int appointmentId, UserAssignModel model);
    Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model, Guid userId);
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

    public AppointmentService(AppDbContext dbContext, IMapper mapper, IHostingEnvironment env, ICloudinaryHelper cloudinaryHelper, UserManager<User> userManage)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _env = env;
        _cloudinaryHelper = cloudinaryHelper;
        _userManager = userManage;
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

        if (model.RequestRemovalIds.Any() && (model.RequestUpgradeIds.Any() || model.RequestExpandIds.Any()))
        {
            result.ErrorMessage = "Cannot have other request when remove server";
            return result;
        }

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var appointment = _mapper.Map<Appointment>(model);
                _dbContext.Appointments.Add(appointment);
                _dbContext.SaveChanges();

                var createRequestUpgradeAppointmentResults = new List<ResultModel>();
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

                var createRequestExpandAppointmentResults = new List<ResultModel>();
                if (validPrecondition)
                {
                    foreach (var requestExpandId in model.RequestExpandIds)
                    {
                        createRequestExpandAppointmentResults.Add(await CreateOneRequestExpandAppointment(appointment.Id, requestExpandId));
                    }

                    if (createRequestExpandAppointmentResults.Any(x => !x.Succeed))
                    {
                        result.ErrorMessage = createRequestExpandAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                        transaction.Rollback();
                        validPrecondition = false;
                    }
                }

                var createRequestRemovalAppointmentResults = new List<ResultModel>();
                if (validPrecondition)
                {
                    foreach (var requestRemovalId in model.RequestRemovalIds)
                    {
                        createRequestRemovalAppointmentResults.Add(await CreateOneRequestRemovalAppointment(appointment.Id, requestRemovalId));
                    }

                    if (createRequestRemovalAppointmentResults.Any(x => !x.Succeed))
                    {
                        result.ErrorMessage = createRequestRemovalAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                        transaction.Rollback();
                        validPrecondition = false;
                    }
                }

                if (validPrecondition)
                {
                    transaction.Commit();
                    result.Succeed = true;
                    result.Data = new AppointmentCreateResultModel
                    {
                        RequestUpgradeAppointments = createRequestUpgradeAppointmentResults.Select(x => x.Data),
                        RequestExpandAppointments = createRequestExpandAppointmentResults.Select(x => x.Data),
                        RequestRemovalAppointments = createRequestRemovalAppointmentResults.Select(x => x.Data),
                        Appointment = _mapper.Map<AppointmentResultModel>(appointment)
                    };
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateRequestAppointment(int appointmentId, RequestAppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validCondition = true;

        if (model.RequestRemovalIds.Any() && model.RequestUpgradeIds.Any() || model.RequestExpandIds.Any())
        {
            result.ErrorMessage = "Cannot have other request when remove server";
            return result;
        }

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var appointment = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Include(x => x.RequestUpgradeAppointment)
                .Include(x => x.RequestExpandAppointments)
                .FirstOrDefault(x => x.Id == appointmentId && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            if (appointment == null)
            {
                validCondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Waiting)
            {
                validCondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_WAITING;
            }
            else
            {
                _dbContext.RequestUpgradeAppointments.RemoveRange(appointment.RequestUpgradeAppointment);
                _dbContext.RequestExpandAppointments.RemoveRange(appointment.RequestExpandAppointments);
                _dbContext.SaveChanges();
            }

            var createRequestUpgradeAppointmentResults = new List<ResultModel>();
            if (validCondition)
            {
                foreach (var requestUpgradeId in model.RequestUpgradeIds)
                {
                    createRequestUpgradeAppointmentResults.Add(await CreateOneRequestUpgradeAppointment(appointmentId, requestUpgradeId));
                }

                if (createRequestUpgradeAppointmentResults.Any(x => !x.Succeed))
                {
                    result.ErrorMessage = createRequestUpgradeAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                    transaction.Rollback();
                    validCondition = false;
                }
            }

            var createRequestExpandAppointmentResults = new List<ResultModel>();
            if (validCondition)
            {
                foreach (var requestExpandId in model.RequestExpandIds)
                {
                    createRequestExpandAppointmentResults.Add(await CreateOneRequestExpandAppointment(appointmentId, requestExpandId));
                }

                if (createRequestExpandAppointmentResults.Any(x => !x.Succeed))
                {
                    result.ErrorMessage = createRequestExpandAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                    transaction.Rollback();
                    validCondition = false;
                }
            }

            var createRequestRemovalAppointmentResults = new List<ResultModel>();
            if (validCondition)
            {
                foreach (var requestRemovalId in model.RequestRemovalIds)
                {
                    createRequestRemovalAppointmentResults.Add(await CreateOneRequestRemovalAppointment(appointmentId, requestRemovalId));
                }

                if (createRequestRemovalAppointmentResults.Any(x => !x.Succeed))
                {
                    result.ErrorMessage = createRequestRemovalAppointmentResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                    transaction.Rollback();
                    validCondition = false;
                }
            }

            if (validCondition)
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = new RequestAppointmentCreateResultModel
                {
                    RequestUpgradeAppointments = createRequestUpgradeAppointmentResults.Select(x => x.Data),
                    RequestExpandAppointments = createRequestExpandAppointmentResults.Select(x => x.Data),
                    RequestRemovealAppointments = createRequestRemovalAppointmentResults.Select(x => x.Data)
                };
            }
        }
        catch (Exception e)
        {
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
                    var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
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

    private async Task<ResultModel> CreateOneRequestRemovalAppointment(int appointmentId, int requestRemovalId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedRequestRemovalAppointment = _dbContext.RequestExpandAppointments.Include(x => x.Appointment).FirstOrDefault(x => x.ForRemoval && x.AppointmentId == appointmentId && x.RequestExpandId == requestRemovalId && x.Appointment.Status != RequestStatus.Denied && x.Appointment.Status != RequestStatus.Failed);
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestRemovalId);
            if (existedRequestRemovalAppointment != null)
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
                    if (requestExpand == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                    }
                    else if (requestExpand.Status != RequestStatus.Success)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestExpandErrorMessage.NOT_SUCCESS;
                    }
                    else if (requestExpand.RemovalStatus != null && requestExpand.RemovalStatus != RemovalStatus.Failed)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Request expand removal started";
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
                var requestRemovalAppointment = new RequestExpandAppointment
                {
                    ForRemoval = true,
                    RequestExpandId = requestRemovalId,
                    AppointmentId = appointmentId,
                };
                _dbContext.RequestExpandAppointments.Add(requestRemovalAppointment);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandAppointmentModel>(requestRemovalAppointment);
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
                var roles = await _userManager.GetRolesAsync(user);
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

                foreach (var requestExpand in appointment.RequestExpandAppointments.Select(x => x.RequestExpand))
                {
                    if (requestExpand.Status != RequestStatus.Success)
                    {
                        requestExpand.Status = RequestStatus.Accepted;
                    }
                    else
                    {
                        requestExpand.RemovalStatus = RemovalStatus.Accepted;
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

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
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
            else
            {
                validPrecondition = IsCompletable(appointmentId, result);
            }

            if (appointment.RequestUpgradeAppointment.Any() && appointment.InspectionReportFilePath == null && model.HostAndUpgradeCreateInspectionReportModel == null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Need inspection report to complete";
            }

            if (appointment.RequestExpandAppointments.Any() && appointment.InspectionReportFilePath == null && model.ExpandCreateInspectionReportModel == null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Need inspection report to complete";
            }

            if (validPrecondition)
            {
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
            }

            if (validPrecondition)
            {
                if (appointment.RequestUpgradeAppointment.Any())
                {
                    var createDocResult = await CreateReceiptReport(appointment.Id, model.ReceiptOfRecipientModel);
                    if (!createDocResult.Succeed)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = createDocResult.ErrorMessage;
                    }
                    else
                    {
                        appointment.ReceiptOfRecipientFilePath = createDocResult.Data as string;
                    }
                }
            }

            if (validPrecondition)
            {
                _mapper.Map<AppointmentCompleteModel, Appointment>(model, appointment);
                appointment.Status = RequestStatus.Success;
                _dbContext.SaveChanges();
                var requestUpgradeResults = new List<ResultModel>();

                foreach (var requestUpgradeId in appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgradeId))
                {
                    requestUpgradeResults.Add(await CompleteRequestUpgrade(requestUpgradeId));
                }

                var requestExpandResults = new List<ResultModel>();
                foreach (var requestExpandId in appointment.RequestExpandAppointments.Where(x => !x.ForRemoval).Select(x => x.RequestExpandId))
                {
                    requestExpandResults.Add(await CompleteRequestExpand(requestExpandId));
                }

                var requestRemovalResults = new List<ResultModel>();
                foreach (var requestExpandId in appointment.RequestExpandAppointments.Where(x => x.ForRemoval).Select(x => x.RequestExpandId))
                {
                    requestRemovalResults.Add(await CompleteRemoval(requestExpandId));
                }

                if (requestExpandResults.Any(x => !x.Succeed))
                {
                    transaction.Rollback();
                    result.ErrorMessage = requestExpandResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                }
                else if (requestUpgradeResults.Any(x => !x.Succeed))
                {
                    transaction.Rollback();
                    result.ErrorMessage = requestUpgradeResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                }
                else if (requestRemovalResults.Any(x => !x.Succeed))
                {
                    transaction.Rollback();
                    result.ErrorMessage = requestRemovalResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                }
                else if (!validPrecondition)
                {
                    transaction.Rollback();
                }
                else
                {
                    if (appointment.RequestUpgradeAppointment.Any())
                    {
                        var createDocResult = await CreateUpgradeAndHostInspectionReport(appointment.ServerAllocationId, model.HostAndUpgradeCreateInspectionReportModel);
                        if (!createDocResult.Succeed)
                        {
                            transaction.Rollback();
                            result.ErrorMessage = createDocResult.ErrorMessage;
                        }
                        else
                        {
                            appointment.InspectionReportFilePath = createDocResult.Data as string;
                            _dbContext.SaveChanges();
                            transaction.Commit();
                            result.Succeed = true;
                            result.Data = _mapper.Map<AppointmentResultModel>(appointment);
                        }
                    }
                    if (appointment.RequestExpandAppointments.Any())
                    {
                        var createDocResult = await CreateRequestExpandInspectionReport(appointment.ServerAllocationId, model.ExpandCreateInspectionReportModel);
                        if (!createDocResult.Succeed)
                        {
                            transaction.Rollback();
                            result.ErrorMessage = createDocResult.ErrorMessage;
                        }
                        else
                        {
                            appointment.InspectionReportFilePath = createDocResult.Data as string;
                            appointment.ServerAllocation.InspectionRecordFilePath = createDocResult.Data as string;
                            transaction.Commit();
                            result.Succeed = true;
                            result.Data = _mapper.Map<AppointmentResultModel>(appointment);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IsCompletable(int appointmentId, ResultModel result)
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

        if (appointment.RequestExpandAppointments.Select(x => x.RequestExpand).Any(x => !x.RequestExpandLocations.Any()))
        {
            validPrecondition = false;
            result.ErrorMessage = "Please assign location to all request expand to complete the appointment";
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

    public async Task<ResultModel> CreateUpgradeAndHostInspectionReport(int serverAllocationId, HostAndUpgradeCreateInspectionReportModel model)
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
                        ramCapacity += rams[i].Capacity;
                    }
                    document.RenderText("__Ram__", ramCapacity + "Gb");

                    var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "Harddisk").Description);
                    var hardDiskCapacity = 0;
                    for (int i = 0; i < hardDisks.Count(); i++)
                    {
                        hardDiskCapacity += hardDisks[i].Capacity;
                    }
                    document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

                    document.RenderText("__ServerLocation__", serverAllocation.ServerLocation);

                    document.RenderText("__SerialNumber__", serverAllocation.SerialNumber);

                    document.RenderText("__Power__", serverAllocation.Power + "W");

                    document.RenderText("__MasterIP__", serverAllocation.MasterIpAddress);

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
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CreateRequestExpandInspectionReport(int requestExpandId, ServerAllocationCreateRequestExpandInspectionReportModel model)
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
               .FirstOrDefault(x => x.Id == requestExpandId);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                File.Copy(inputPath, outputPath, true);
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
                    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                    document.RenderText("__Number__", textInfo.ToTitleCase(model.Number));

                    var now = DateTime.UtcNow;
                    document.RenderText("__Time__", $"{now.Day}/{now.Month}/{now.Year}");
                    document.RenderText("__Time__", $"{now.Day}/{now.Month}/{now.Year}");

                    document.RenderText("__CustomerName__", textInfo.ToTitleCase(model.CustomerName));

                    document.RenderText("__CompanyName__", serverAllocation.Customer.CompanyName.ToUpper());

                    document.RenderText("__CustomerPosition__", textInfo.ToTitleCase(model.CustomerPosition));

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
                        ramCapacity += rams[i].Capacity;
                    }
                    document.RenderText("__Memory__", ramCapacity + "Gb");

                    var hardDisks = JsonSerializer.Deserialize<List<ConfigDescriptionModel>>(serverAllocation.ServerHardwareConfigs.FirstOrDefault(x => x.Component.Name == "Harddisk").Description);
                    var hardDiskCapacity = 0;
                    for (int i = 0; i < hardDisks.Count(); i++)
                    {
                        hardDiskCapacity += hardDisks[i].Capacity;
                    }
                    document.RenderText("__HardDisk__", hardDiskCapacity + "Gb");

                    document.RenderText("__Power__", serverAllocation.Power + "W");

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
                serverAllocation.InspectionRecordFilePath = inspectionReportFileName;

                if (serverAllocation.InspectionRecordFilePath != null && serverAllocation.ReceiptOfRecipientFilePath != null)
                {
                    serverAllocation.Status = ServerAllocationStatus.Working;
                }
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

    public async Task<ResultModel> CreateReceiptReport(int appointmentId, ReceiptOfRecipientModel model)
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
                using (WordprocessingDocument document = WordprocessingDocument.Open(outputPath, true))
                {
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
                            newConfig.SerialNumber += requestUpgradeDescriptions[i].Model;
                            if (i < requestUpgradeDescriptions.Count - 1)
                            {
                                newConfig.Model += ", ";
                            }
                        }

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
                                oldConfig.SerialNumber += hardwareDescriptions[i].Model;
                                if (i < hardwareDescriptions.Count - 1)
                                {
                                    oldConfig.Model += ", ";
                                }
                            }
                            receiptReportModels.Add(oldConfig);
                        }
                        receiptReportModels.Add(newConfig);
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
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == requestExpandId && x.Status == RequestStatus.Success);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestExpand.RemovalStatus != RemovalStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.REMOVAL_NOT_ACCEPTED;
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

            var locationAssignments = new List<LocationAssignment>();
            if (validPrecondition)
            {
                foreach (var location in locations)
                {
                    var locationAssignment = _dbContext.LocationAssignments.FirstOrDefault(x => x.LocationId == location.Id);
                    if (locationAssignment == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
                    }
                    else
                    {
                        locationAssignments.Add(locationAssignment);
                    }
                }
            }

            if (validPrecondition)
            {
                _dbContext.LocationAssignments.RemoveRange(locationAssignments);
                requestExpand.RemovalStatus = RemovalStatus.Success;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments);
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
