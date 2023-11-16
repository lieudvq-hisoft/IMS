
using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IRequestUpgradeAppointmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestUpgradeAppointmentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(RequestUpgradeAppointmentCreateModel model);
    Task<ResultModel> Update(RequestUpgradeAppointmentUpdateModel model);
    Task<ResultModel> Delete(int id);
}

public class RequestUpgradeAppointmentService : IRequestUpgradeAppointmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestUpgradeAppointmentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestUpgradeAppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgradeAppointments = _dbContext.RequestUpgradeAppointments
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestUpgradeAppointments.Count());

            requestUpgradeAppointments = requestUpgradeAppointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestUpgradeAppointments = requestUpgradeAppointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestUpgradeAppointmentModel>(requestUpgradeAppointments).ToList();

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
            var requestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.FirstOrDefault(x => x.Id == id);

            if (requestUpgradeAppointment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestUpgradeAppointmentModel>(requestUpgradeAppointment);
            }
            else
            {
                result.ErrorMessage = RequestUpgradeAppointmentErrorMessgae.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(RequestUpgradeAppointmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var existedRequestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.FirstOrDefault(x => x.AppointmentId == model.AppointmentId && x.RequestUpgradeId == model.RequestUpgradeId);
            if (existedRequestUpgradeAppointment != null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeAppointmentErrorMessgae.EXISTED;
            }
            else
            {
                var appoitment = _dbContext.Appointments.FirstOrDefault(x => x.Id == model.AppointmentId);
                if (appoitment == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                }

                var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == model.RequestUpgradeId);
                if (requestUpgrade == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                }
            }
            
            if(validPrecondition)
            {
                var requestUpgradeAppointment = _mapper.Map<RequestUpgradeAppointment>(model);
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

    public async Task<ResultModel> Update(RequestUpgradeAppointmentUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.FirstOrDefault(x => x.Id == model.Id);
            if (requestUpgradeAppointment == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestUpgradeAppointmentErrorMessgae.NOT_EXISTED;
            }
            else
            {
                var existedRequestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.FirstOrDefault(x => x.AppointmentId == model.AppointmentId && x.RequestUpgradeId == model.RequestUpgradeId && x.Id != model.Id);
                if (existedRequestUpgradeAppointment != null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestUpgradeAppointmentErrorMessgae.EXISTED;
                }
                else
                {
                    var appoitment = _dbContext.Appointments.FirstOrDefault(x => x.Id == model.AppointmentId);
                    if (appoitment == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = AppointmentErrorMessgae.NOT_EXISTED;
                    }

                    var requestUpgrade = _dbContext.RequestUpgrades.FirstOrDefault(x => x.Id == model.RequestUpgradeId);
                    if (requestUpgrade == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = RequestUpgradeErrorMessage.NOT_EXISTED;
                    }
                }
            }

            if (validPrecondition)
            {
                _mapper.Map<RequestUpgradeAppointmentUpdateModel, RequestUpgradeAppointment>(model, requestUpgradeAppointment);
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

    public async Task<ResultModel> Delete(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgradeAppointment = _dbContext.RequestUpgradeAppointments.FirstOrDefault(x => x.Id == id);
            if (requestUpgradeAppointment == null)
            {
                result.ErrorMessage = RequestUpgradeAppointmentErrorMessgae.NOT_EXISTED;
            }
            else
            {
                _dbContext.RequestUpgradeAppointments.Remove(requestUpgradeAppointment);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestUpgradeAppointment.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}

