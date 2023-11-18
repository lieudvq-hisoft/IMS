﻿using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Services.Utilities;

namespace Services.Core;
public interface IAppointmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> GetAll();
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetRequestUpgradeAppointment(int id);
    Task<ResultModel> GetRequestUpgrade(int id);
    Task<ResultModel> Create(AppointmentCreateModel model);
    Task<ResultModel> CreateRequestUpgradeAppointment(int appointmentId, RequestUpgradeAppointmentCreateModel model);
    Task<ResultModel> Update(AppointmentUpdateModel model);
    Task<ResultModel> Delete(int id);
    Task<ResultModel> Evaluate(int appointmentId, RequestStatus status, UserAssignModel model);
    Task<ResultModel> Complete(int appointmentId, AppointmentCompleteModel model);
    Task<ResultModel> Fail(int appointmentId, string userId);
    Task<ResultModel> AssignInspectionReport(int appointmentId, string fileName);
}

public class AppointmentService : IAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly TransactionHelper _transactionHelper;

    public AppointmentService(AppDbContext dbContext, IMapper mapper, TransactionHelper transactionHelper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _transactionHelper = transactionHelper;
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
                    return FilterAppointment(x, searchModel);
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

    private bool FilterAppointment(Appointment x, AppointmentSearchModel model)
    {
        bool matchId = model.Id != null ? x.Id == model.Id : true;
        bool matchStatus = model.Status != null ? x.Status == model.Status : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;

        return matchId && matchStatus && matchServerAllocationId;
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

        try
        {
            using var transaction = _transactionHelper.GetTransaction();
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var attachRequestUpgradeResults = new List<ResultModel>();
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

                foreach (var requestUpgradeId in model.RequestUpgradeIds)
                {
                    attachRequestUpgradeResults.Add(await CreateOneRequestUpgradeAppointment(appointment.Id, requestUpgradeId));
                }

                if (attachRequestUpgradeResults.Any(x => !x.Succeed))
                {
                    result.ErrorMessage = attachRequestUpgradeResults.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                    transaction.Rollback();
                }
                else
                {
                    transaction.Commit();
                    result.Succeed = true;
                    result.Data = new List<object>
                    {
                        attachRequestUpgradeResults.Select(x => x.Data),
                        _mapper.Map<AppointmentModel>(appointment)
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

    public async Task<ResultModel> CreateRequestUpgradeAppointment(int appointmentId, RequestUpgradeAppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _transactionHelper.GetTransaction();
            _dbContext.Database.UseTransaction(transaction.GetDbTransaction());
            var results = new List<ResultModel>();
            foreach (var requestUpgradeId in model.RequestUpgradeIds)
            {
                results.Add(await CreateOneRequestUpgradeAppointment(appointmentId, requestUpgradeId));
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

    private async Task<ResultModel> CreateOneRequestUpgradeAppointment(int appointmentId, int requestUpgradeId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedRequestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.Include(x => x.Appointment).FirstOrDefault(x => x.AppointmentId == appointmentId && x.RequestUpgradeId == requestUpgradeId && x.Appointment.Status == RequestStatus.Waiting);
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
                else if (appoitment.Status != RequestStatus.Waiting)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_WAITING;
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
                        result.ErrorMessage = "Wrong server allocation";
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

    public async Task<ResultModel> AssignInspectionReport(int appointmentId, string fileName)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
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
                var requestUpgrades = appointment.RequestUpgradeAppointment.Select(x => x.RequestUpgrade);
                var requestExpands = appointment.RequestExpandAppointments.Select(x => x.RequestExpand);
                foreach (var requestUpgrade in requestUpgrades)
                {
                    requestUpgrade.InspectionReportFilePath = fileName;
                }
                foreach (var requestExpand in requestExpands)
                {
                    requestExpand.InspectionReportFilePath = fileName;
                }
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = fileName;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
