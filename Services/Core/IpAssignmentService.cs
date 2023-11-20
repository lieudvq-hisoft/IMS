using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess.Constant;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Utils.Paging;

namespace Services.Core;
public interface IIpAssignmentService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpAssignmentSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> Create(IpAssignmentCreateModel model);
    Task<ResultModel> Update(IpAssignmentUpdateModel model);
    Task<ResultModel> Delete(int id);
}

public class IpAssignmentService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public IpAssignmentService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, IpAssignmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var ipAssignments = _dbContext.IpAssignments
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, ipAssignments.Count());

            ipAssignments = ipAssignments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            ipAssignments = ipAssignments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<IpAssignmentModel>(ipAssignments).ToList();

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
            var ipAssignment = _dbContext.IpAssignments
                .FirstOrDefault(x => x.Id == id);

            if (ipAssignment != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<IpAssignmentModel>(ipAssignment);
            }
            else
            {
                result.ErrorMessage = IpAssignmentErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> Create(IpAssignmentCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var ipAddressId = _dbContext.IpAddresses.FirstOrDefault(x => x.Id == model.IpAddressId);
            if (ipAddressId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
            }

            var serverAllocationId = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
            if (serverAllocationId == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }

            if(validPrecondition)
            {
                var ipAssignment = _mapper.Map<IpAssignment>(model);
                _dbContext.IpAssignments.Add(ipAssignment);
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
            var ipAssignment = _dbContext.IpAssignments.Include(x => x.Racks).ThenInclude(x => x.Locations).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == id);
            if (ipAssignment == null)
            {
                result.ErrorMessage = IpAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                _dbContext.IpAssignments.Remove(ipAssignment);
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

    public async Task<ResultModel> Update(IpAssignmentUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var ipAssignment = _dbContext.IpAssignments.FirstOrDefault(x => x.Id == model.Id);
            if (ipAssignment == null)
            {
                result.ErrorMessage = IpAssignmentErrorMessage.NOT_EXISTED;
            }
            else
            {
                var ipAddressId = _dbContext.IpAddresses.FirstOrDefault(x => x.Id == model.IpAddressId);
                if (ipAddressId == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = IpAddressErrorMessage.NOT_EXISTED;
                }

                var serverAllocationId = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId);
                if (serverAllocationId == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
                }
            }

            if (validPrecondition)
            {
                _mapper.Map<IpAssignmentUpdateModel, IpAssignment>(model, ipAssignment);

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
}

