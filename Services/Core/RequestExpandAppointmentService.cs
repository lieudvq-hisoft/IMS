using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

public interface IRequestExpandAppointmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandAppointmentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(RequestExpandAppointmentCreateModel model);
    Task<ResultModel> Delete(int id);
}

public class RequestExpandAppointmentService : IRequestExpandAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestExpandAppointmentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandAppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpandAppointments = _dbContext.RequestExpandAppointments
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpandAppointments.Count());

            requestExpandAppointments = requestExpandAppointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestExpandAppointments = requestExpandAppointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestExpandAppointmentModel>>(requestExpandAppointments.ToList());

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
            var requestExpandAppointmentns = _dbContext.RequestExpandAppointments.FirstOrDefault(x => x.Id == id);

            if (requestExpandAppointmentns != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandAppointmentModel>(requestExpandAppointmentns);
            }
            else
            {
                result.ErrorMessage = RequestExpandAppointmentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestExpandAppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == model.RequestExpandId);
            var appointment = _dbContext.Appointments.FirstOrDefault(x => x.Id == model.AppointmentId);
            var existedRequestExpandAppointment = _dbContext.RequestExpandAppointments.Include(x => x.RequestExpand)
                .FirstOrDefault(x => x.RequestExpandId == model.RequestExpandId
                && x.AppointmentId == model.AppointmentId && x.RequestExpand.Status != RequestStatus.Denied);

            if (existedRequestExpandAppointment != null)
            {
                result.ErrorMessage = RequestExpandAppointmentErrorMessage.EXISTED;
            }
            else if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (appointment == null)
            {
                result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
            }
            else if (requestExpand.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestExpandAppointmentErrorMessage.APPOINTMENT_NOT_ACCEPTED;
            }
            else if (requestExpand.ServerAllocationId != appointment.ServerAllocationId)
            {
                result.ErrorMessage = RequestExpandAppointmentErrorMessage.INVALID_SERVER_ALLOCATION;
            }
            else
            {
                var requestExpandAppointmentn = _mapper.Map<RequestExpandAppointment>(model);
                _dbContext.RequestExpandAppointments.Add(requestExpandAppointmentn);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandAppointmentModel>(requestExpandAppointmentn);
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
            var requestExpandAppointmentn = _dbContext.RequestExpandAppointments.FirstOrDefault(x => x.Id == id);
            if (requestExpandAppointmentn == null)
            {
                result.ErrorMessage = RequestExpandAppointmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.RequestExpandAppointments.Remove(requestExpandAppointmentn);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestExpandAppointmentn.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}