using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;
using Data.Utils.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DataAccess.Constant;
using Microsoft.AspNetCore.Hosting.Server;

namespace Services.Core;
public interface IAppointmentService
{
    Task<ResultModel> Get(PagingParam<AppointmentSortCriteria> paginationModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(AppointmentScheduleCreateModel model);
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

    public async Task<ResultModel> Get(PagingParam<AppointmentSortCriteria> paginationModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointments = _dbContext.AppointmentSchedules
                .Include(x => x.Customer)
                .ThenInclude(x => x.User)
                .Include(x => x.TechExecution)
                .Include(x => x.ServerAppointments)
                .ThenInclude(x => x.Server)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());

            appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<AppointmentScheduleModel>>(appointments);

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
            var appointment = _dbContext.AppointmentSchedules
                .Include(x => x.Customer)
                .ThenInclude(x => x.User)
                .Include(x => x.TechExecution)
                .Include(x => x.ServerAppointments)
                .ThenInclude(x => x.Server)
                .FirstOrDefault(x => x.Id == id);

            if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
            }
            else
            {
                var appointmentModel = _mapper.Map<AppointmentScheduleDetailModel>(appointment);
                result.Data = appointmentModel;
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Create(AppointmentScheduleCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == model.CustomerId);
            if (customer == null)
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                List<int?> customerServerIds = _dbContext.Requests.Include(x => x.Server).Where(x => x.CustomerId == model.CustomerId && (x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Ongoing || x.Status == RequestStatus.Stopped)).Select(x => x.ServerId).ToList();
                foreach (int serverId in model.ServerIds)
                {
                    if (!customerServerIds.Contains(serverId))
                    {
                        validPrecondition = false;
                        result.ErrorMessage = AppointmentErrorMessgae.SERVER_NOT_BELONG_TO_CUSTOMER;
                    }
                }
            }

            if (validPrecondition)
            {
                var appointmentSchedule = new AppointmentSchedule
                {
                    DateAppointed = model.DateAppointed,
                    Reason = model.Reason,
                    Note = model.Note,
                    VisitorName = model.VisitorName,
                    CustomerId = model.CustomerId
                };
                _dbContext.AppointmentSchedules.Add(appointmentSchedule);
                _dbContext.SaveChanges();

                foreach (int serverId in model.ServerIds)
                {
                    _dbContext.Add(new ServerAppointment
                    {
                        AppointmentScheduleId = appointmentSchedule.Id,
                        ServerId = serverId
                    });
                    _dbContext.SaveChanges();
                }
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
