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
using Microsoft.EntityFrameworkCore.Storage;
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
    Task<ResultModel> Evaluate(int appointmentId, RequestStatus status, Guid userId);
    Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model, Guid userId);
    Task<ResultModel> Fail(int appointmentId, Guid userId);
    Task<ResultModel> AssignInspectionReport(int appointmentId, DocumentFileUploadModel model);
}

public class AppointmentService : IAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;

    public AppointmentService(AppDbContext dbContext, IMapper mapper, ICloudinaryHelper cloudinaryHelper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _cloudinaryHelper = cloudinaryHelper;
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
            var appointment = _dbContext.Appointments.Include(x => x.ServerAllocation).FirstOrDefault(x => x.Id == appointmentId && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
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
                    RequestExpandAppointments = createRequestExpandAppointmentResults.Select(x => x.Data)
                }; ;
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
                requestExpand.RemovalStatus = RemovalStatus.Accepted;
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
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
                if (serverAllocation == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                }
            }

            if (validPrecondition)
            {
                _mapper.Map<AppointmentUpdateModel, Appointment>(model, appointment);
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

    public async Task<ResultModel> Evaluate(int appointmentId, RequestStatus status, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            if (status != RequestStatus.Accepted && status != RequestStatus.Denied)
            {
                throw new Exception(ErrorMessage.WRONG_PURPOSE);
            }

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
                appointment.Status = status;
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    Action = RequestUserAction.Evaluate,
                    AppointmentId = appointment.Id,
                    UserId = userId
                });

                if (status == RequestStatus.Accepted)
                {
                    foreach (var requestUpgrade in appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade))
                    {
                        requestUpgrade.Status = status;
                        _dbContext.RequestUpgradeUsers.Add(new RequestUpgradeUser
                        {
                            Action = RequestUserAction.Evaluate,
                            RequestUpgradeId = requestUpgrade.Id,
                            UserId = userId
                        });
                    }
                    foreach (var requestExpand in appointment.RequestExpandAppointments.Select(x => x.RequestExpand))
                    {
                        requestExpand.Status = status;
                        _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                        {
                            Action = RequestUserAction.Evaluate,
                            RequestExpandId = requestExpand.Id,
                            UserId = userId
                        });
                    }
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

    public async Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments.Include(x => x.RequestExpandAppointments).Include(x => x.RequestUpgradeAppointment).Include(x => x.RequestHostAppointments).FirstOrDefault(x => x.Id == appointmentId);
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
                if (appointment.RequestExpandAppointments.Any() || appointment.RequestUpgradeAppointment.Any() || appointment.RequestHostAppointments.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_COMPLETABLE;
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
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    Action = RequestUserAction.Execute,
                    AppointmentId = appointmentId,
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

    public async Task<ResultModel> Fail(int appointmentId, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessage.NOT_EXISTED;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                appointment.Status = RequestStatus.Failed;
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    AppointmentId = appointmentId,
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
