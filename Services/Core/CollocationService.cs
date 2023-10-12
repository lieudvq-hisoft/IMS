using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Model;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface ICollocationService
{
    Task<ResultModel> AttempCreate(CollocationCreateModel model, CustomerModel customer);
    Task<ResultModel> Get(PagingParam<CollocationSortCriteria> paginationModel, CollocationSearchModel searchModel);
}

public class CollocationService : ICollocationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public CollocationService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<ResultModel> Get(PagingParam<CollocationSortCriteria> paginationModel, CollocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var collocations = _dbContext.Collocations
                .Include(x => x.Customer)
                .Where(x => !x.IsDeleted)
                .Where(delegate (Collocation x)
                {
                    return MatchString(searchModel, x.Customer.CompanyName);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, collocations.Count());

            collocations = collocations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            collocations = collocations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<CollocationModel>(collocations).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    private bool MatchString(CollocationSearchModel searchModel, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }

    /// <summary>
    /// Create a new collocation for the customer created previous. Will hard delete the customer on fail
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The result model contain the new collocation</returns>
    public async Task<ResultModel> AttempCreate(CollocationCreateModel model, CustomerModel customerModel)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var services = new List<Service>();
            foreach (var additionalService in model.AdditionalServices)
            {
                var service = _dbContext.Services.FirstOrDefault(x => x.Id == additionalService.Id);
                if (service == null)
                {
                    validPrecondition = false;
                }
                else
                {
                    services.Add(service);
                }
            }

            if (validPrecondition)
            {
                var collocation = new Collocation
                {
                    Status = CollocationStatus.Pending,
                    Note = model.Note,
                    InspectorNote = model.InspectorNote,
                    DateCreated = model.DateCreate,
                    DateAllocate = model.DateAllocate,
                    DateStop = model.DateStop,
                    CustomerId = customerModel.Id,
                };

                _dbContext.Collocations.Add(collocation);
                _dbContext.SaveChanges();

                foreach (var service in services)
                {
                    var additionalService = model.AdditionalServices.FirstOrDefault(x => x.Id == service.Id);
                    _dbContext.AdditionalServices.Add(new AdditionalService
                    {
                        ServiceId = service.Id,
                        CollocationId = collocation.Id,
                        Quantity = additionalService.Quantity
                    });
                }

                _dbContext.SaveChanges();
                result.Succeed = true;
            }
        }
        catch (Exception ex)
        {
            result.ErrorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
        }

        if (!result.Succeed)
        {
            // Delete customer and user on fail to create collocation
            Customer customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == customerModel.Id);
            User user = customer.User;
            _dbContext.Remove(customer);
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        return result;
    }
}
