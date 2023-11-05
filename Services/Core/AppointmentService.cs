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
}
