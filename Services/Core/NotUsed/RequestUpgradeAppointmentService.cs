
using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;

namespace Services.Core.NotUsed;
public interface IRequestUpgradeAppointmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestUpgradeAppointmentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
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

            paging.Data = _mapper.Map<List<RequestUpgradeAppointmentModel>>(requestUpgradeAppointments.ToList());

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

