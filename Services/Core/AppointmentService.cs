using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IAppointmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> GetAll();
    Task<ResultModel> GetRequestUpgradeAppointment(int id);
    Task<ResultModel> Create(AppointmentCreateModel model);
    Task<ResultModel> Update(AppointmentUpdateModel model);
    Task<ResultModel> Delete(int id);
}

public class AppointmentService : IAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public AppointmentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointments = _dbContext.Appointments
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
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

    public async Task<ResultModel> Create(AppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
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
}
