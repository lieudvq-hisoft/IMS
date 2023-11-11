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
    Task<ResultModel> Update(IpAssignmentUpdateModel model);
    Task<ResultModel> Delete(int id);
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
                .Include(x => x.Request)
                .Where(delegate (IpAssignment x)
                {
                    return MatchString(searchModel.Type.ToString(), x.Type.ToString());
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

        try
        {
            var ipAssignment = new IpAssignment
            {
                DateAssign = model.DateAssign,
                Type = model.Type,
                IpId = model.IpId,
                RequestId = model.RequestId,
            };

            _dbContext.IpAssignments.Add(ipAssignment);
            _dbContext.SaveChanges();

            result.Succeed = true;
            result.Data = _mapper.Map<IpAssignmentModel>(ipAssignment);
            
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(IpAssignmentUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAssignment = _dbContext.IpAssignments.FirstOrDefault(x => x.Id == model.Id);

            if (ipAssignment == null)
            {
                result.ErrorMessage = IpAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                ipAssignment.DateAssign = model.DateAssign;
                ipAssignment.Type = model.Type;
                ipAssignment.IpId = model.IpId;
                ipAssignment.RequestId = model.RequestId;

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<IpAssignmentModel>(ipAssignment);
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
            var ipAssignment = _dbContext.IpAssignments.FirstOrDefault(x => x.Id == id);
            if (ipAssignment == null)
            {
                result.ErrorMessage = IpAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                ipAssignment.IsDeleted = true;
                ipAssignment.DateUpdated = DateTime.Now;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = ipAssignment.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}