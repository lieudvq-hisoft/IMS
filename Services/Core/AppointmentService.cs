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
    Task<ResultModel> GetAll();
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestExpand(int id);
    Task<ResultModel> GetRequestUpgradeAppointment(int id);
    Task<ResultModel> GetRequestUpgrade(int id);
    Task<ResultModel> Create(AppointmentCreateModel model);
    Task<ResultModel> CreateRequestAppointment(int appointmentId, RequestAppointmentCreateModel model);
    Task<ResultModel> Update(AppointmentUpdateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Evaluate(int appointmentId, RequestStatus status, UserAssignModel model);
    Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model);
    Task<ResultModel> Fail(int appointmentId, string userId);
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
                .Where(delegate (Appointment x)
                {
                    return x.FilterAppointment(searchModel);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());

            appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<AppointmentModel>(appointments).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAll()
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointments = _dbContext.Appointments.AsQueryable();

            result.Data = _mapper.ProjectTo<AppointmentModel>(appointments).ToList();
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
            var appointment = _dbContext.Appointments.FirstOrDefault(x => x.Id == id);

            if (appointment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentModel>(appointment);
            }
            else
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRequestExpand(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.RequestExpandAppointments)
                .ThenInclude(x => x.RequestExpand)
                .FirstOrDefault(x => x.Id == id);

            if (appointment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<RequestExpandModel>>
                    (appointment.RequestExpandAppointments.Select(x => x.RequestExpand));
            }
            else
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRequestUpgradeAppointment(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.RequestUpgradeAppointment)
                .FirstOrDefault(x => x.Id == id);

            if (appointment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<RequestUpgradeAppointmentModel>>(appointment.RequestUpgradeAppointment);
            }
            else
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRequestUpgrade(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointment = _dbContext.Appointments
                .Include(x => x.RequestUpgradeAppointment)
                .ThenInclude(x => x.RequestUpgrade)
                .FirstOrDefault(x => x.Id == id);

            if (appointment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<List<RequestUpgradeModel>>(appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade));
            }
            else
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
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
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
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

                if (validCondition)
                {
                    transaction.Commit();
                    result.Succeed = true;
                    result.Data = new AppointmentCreateResultModel
                    {
                        RequestUpgradeAppointments = createRequestUpgradeAppointmentResults.Select(x => x.Data),
                        RequestExpandAppointments = createRequestExpandAppointmentResults.Select(x => x.Data),
                        Appointment = _mapper.Map<AppointmentModel>(appointment),
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
            var createRequestUpgradeAppointmentResults = new List<ResultModel>();
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

            if (validCondition)
            {
                transaction.Commit();
                result.Succeed = true;
                var data = new RequestAppointmentCreateResultModel
                {
                    RequestUpgradeAppointments = createRequestUpgradeAppointmentResults.Select(x => x.Data),
                    RequestExpandAppointments = createRequestExpandAppointmentResults.Select(x => x.Data)
                };
                result.Data = data;
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
            var existedRequestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.Include(x => x.Appointment).FirstOrDefault(x => x.AppointmentId == appointmentId && x.RequestUpgradeId == requestUpgradeId && x.Appointment.Status != RequestStatus.Denied);
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
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                }
                else if (appoitment.Status != RequestStatus.Waiting && appoitment.Status != RequestStatus.Accepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_WAITING + "/" + AppointmentErrorMessgae.NOT_ACCEPTED;
                }
                else
                {
                    var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == requestUpgradeId);
                    if (requestUpgrade == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                    }
                    else if (requestUpgrade.Status != RequestStatus.Accepted)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestUpgradeErrorMessage.NOT_ACCEPTED;
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
            var existedRequestExpandAppointment = _dbContext.RequestExpandAppointments.Include(x => x.Appointment).FirstOrDefault(x => x.AppointmentId == appointmentId && x.RequestExpandId == requestExpandId && x.Appointment.Status != RequestStatus.Denied);
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
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                }
                else if (appoitment.Status != RequestStatus.Waiting && appoitment.Status != RequestStatus.Accepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_WAITING + "/" + AppointmentErrorMessgae.NOT_ACCEPTED;
                }
                else
                {
                    var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
                    if (requestExpand == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                    }
                    else if (requestExpand.Status != RequestStatus.Accepted)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestExpandErrorMessage.NOT_ACCEPTED;
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

    public async Task<ResultModel> Update(AppointmentUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var appointment = _dbContext.Appointments.FirstOrDefault(x => x.Id == model.Id);
            if (appointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
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
                result.Data = _mapper.Map<AppointmentModel>(appointment);
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
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
            }
            else
            {
                _dbContext.Appointments.Remove(appointment);
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

    public async Task<ResultModel> Evaluate(int appointmentId, RequestStatus status, UserAssignModel model)
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

            var appointment = _dbContext.Appointments.FirstOrDefault(x => x.Id == appointmentId);
            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                validPrecondition = false;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition && appointment.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                appointment.Status = status;
                _dbContext.AppointmentUsers.Add(new AppointmentUser
                {
                    AppointmentId = appointment.Id,
                    UserId = new Guid(model.UserId)
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentModel>(appointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model)
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
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
            }
            if (appointment.Status != RequestStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = AppointmentErrorMessgae.NOT_ACCEPTED;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(model.UserId));
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
                    AppointmentId = appointmentId,
                    UserId = new Guid(model.UserId)
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<AreaModel>(appointment);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Fail(int appointmentId, string userId)
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
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == new Guid(userId));
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
                    UserId = new Guid(userId)
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<AreaModel>(appointment);
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
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
            }
            else if (appointment.Status != RequestStatus.Success)
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_SUCCESS;
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
