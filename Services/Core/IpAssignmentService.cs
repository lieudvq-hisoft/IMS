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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IIpAssignmentService
{
    Task<ResultModel> Get(PagingParam<IpAssignmentSortCriteria> paginationModel, IpAssignmentSearchModel searchModel);
    Task<ResultModel> Create(IpAssignmentCreateModel model);
    //Task<ResultModel> Update(ServiceUpdateModel model);
    //Task<ResultModel> Delete(int id);
}

public class IpAssignmentService : IIpAssignmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public IpAssignmentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<IpAssignmentSortCriteria> paginationModel, IpAssignmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var IpAssignments = _dbContext.IpAssignments
                .Include(x => x.Ip)
                .Include(x => x.Service)
                .Where(delegate (IpAssignment x)
                {
                    return (x.ServiceId != 0 && x.Id == searchModel.ServiceId) &&
                    MatchString(searchModel.Type.ToString(), x.Type.ToString());
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, IpAssignments.Count());

            IpAssignments = IpAssignments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            IpAssignments = IpAssignments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<IpAssignmentModel>(IpAssignments).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private bool MatchString(string searchValue, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }


    public async Task<ResultModel> Create(IpAssignmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            //if (existingService != null)
            //{
            //    result.ErrorMessage = ServiceErrorMessgae.EXISTED;
            //    validPrecondition = false;
            //}
            //if (existingService != null)
            //{
            //    result.ErrorMessage = ServiceErrorMessgae.EXISTED;
            //    validPrecondition = false;
            //}

            //var existingService = _dbContext.Services.FirstOrDefault(x => x.Name == model.Name);

            //if (validPrecondition)
            //{
            //    var service = new Service
            //    {
            //        Name = model.Name,
            //        Type = model.Type,

            //    };

            //    _dbContext.Services.Add(service);
            //    _dbContext.SaveChanges();

            //    result.Succeed = true;
            //    result.Data = _mapper.Map<ServiceModel>(service);
            //}
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}