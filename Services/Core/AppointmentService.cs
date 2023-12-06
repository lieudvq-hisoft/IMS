using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

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
}

public class AppointmentService : IAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;
    private readonly UserManager<User> _userManager;

    public AppointmentService(AppDbContext dbContext, IMapper mapper, ICloudinaryHelper cloudinaryHelper, UserManager<User> userManage)
    {
        _dbContext = dbContext;
        _mapper = mapper;
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
        bool validCondition = true;

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
                    validCondition = false;
                }

                var createRequestExpandAppointmentResults = new List<ResultModel>();
                if (validCondition)
                {
                    foreach (var requestExpandId in model.RequestExpandIds)
                    {
                        createRequestExpandAppointmentResults.Add(await CreateOneRequestExpandAppointment(appointment.Id, requestExpandId));
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
                        createRequestRemovalAppointmentResults.Add(await CreateOneRequestRemovalAppointment(appointment.Id, requestRemovalId));
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
            var appointment = _dbContext.Appointments.Include(x => x.RequestExpandAppointments).Include(x => x.RequestUpgradeAppointment).FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                validPrecondition = IsCompletable(appointmentId, result);
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

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                _mapper.Map<AppointmentCompleteModel, Appointment>(model, appointment);
                appointment.Status = RequestStatus.Success;
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

        if (appointment.InspectionReportFilePath == null || appointment.ReceiptOfRecipientFilePath == null)
        {
            if (appointment.RequestUpgradeAppointment.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_COMPLETABLE;
            }
        }

        if (appointment.RequestExpandAppointments.Select(x => x.RequestExpand).Any(x => !x.RequestExpandLocations.Any()))
        {
            validPrecondition = false;
            result.ErrorMessage = "Please assign location to all request expand to complete the appointment";
        }

        return validPrecondition;
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
            string inspectionReportFileName = _cloudinaryHelper.UploadFile(model.InspectionReport);

            string receiptOfRecipientFileName = _cloudinaryHelper.UploadFile(model.ReceiptOfRecipient);
            var appointment = _dbContext.Appointments
                .Include(x => x.RequestUpgradeAppointment).ThenInclude(x => x.RequestUpgrade)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.RequestExpand)
                .FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
            }
            else
            {
                appointment.InspectionReportFilePath = inspectionReportFileName;
                appointment.ReceiptOfRecipientFilePath = receiptOfRecipientFileName;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = new DocumentFileResultModel
                {
                    InspectionReport = inspectionReportFileName,
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
}
