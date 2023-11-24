using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.Utilities;

namespace Services.Core.NotUsed;
public interface IAppointmentUserService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentUserSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
}

public class AppointmentUserService : IAppointmentUserService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public AppointmentUserService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, AppointmentUserSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var appointmentUsers = _dbContext.AppointmentUsers
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointmentUsers.Count());

            appointmentUsers = appointmentUsers.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            appointmentUsers = appointmentUsers.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<AppointmentUserModel>>(appointmentUsers.ToList());

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
            var appointmentUser = _dbContext.AppointmentUsers
                .FirstOrDefault(x => x.Id == id);

            if (appointmentUser != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<AppointmentUserModel>(appointmentUser);
            }
            else
            {
                result.ErrorMessage = AppointmentUserErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }
}