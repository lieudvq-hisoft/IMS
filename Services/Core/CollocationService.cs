using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Model;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using Services.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Services.Core;
public interface ICollocationService
{
    Task<ResultModel> Get(PagingParam<CollocationSortCriteria> paginationModel, CollocationSearchModel searchModel);
    Task<ResultModel> GetRequest(PagingParam<CollocationSortCriteria> paginationModel, CollocationSearchModel searchModel);
    Task<ResultModel> ImportRequest(string filePath);
    Task<ResultModel> CreateRequest(CollocationRequestCreateModel model);
    Task<ResultModel> UpdateRequest(CollocationRequestUpdateModel model);
    Task<ResultModel> GenerateImportExcelTemplate(string filePath);

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
                .Include(x => x.AdditionalServices)
                .Where(x => !x.IsDeleted
                    && x.Status != CollocationStatus.Pending
                    && !x.AdditionalServices.Any(_ => _.Status == AdditionalServiceStatus.Pending))
                .Where(delegate (Collocation x)
                {
                    return MatchString(searchModel, x.Customer.CompanyName);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, collocations.Count());

            collocations = collocations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            collocations = collocations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<CollocationRequestModel>(collocations).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetRequest(PagingParam<CollocationSortCriteria> paginationModel, CollocationSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var collocations = _dbContext.Collocations
                .Include(x => x.Customer)
                .Include(x => x.AdditionalServices)
                .Where(x => !x.IsDeleted
                    && (x.Status == CollocationStatus.Pending || x.AdditionalServices.Any(_ => _.Status == AdditionalServiceStatus.Pending)))
                .Where(delegate (Collocation x)
                {
                    return MatchString(searchModel, x.Customer.CompanyName);
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, collocations.Count());

            collocations = collocations.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            collocations = collocations.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<CollocationRequestModel>(collocations).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private bool MatchString(CollocationSearchModel searchModel, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }

    public async Task<ResultModel> ImportRequest(string filePath)
    {
        using var package = new ExcelPackage(new FileInfo(filePath));
        var worksheet = package.Workbook.Worksheets["Sheet1"];
        int rowCount = worksheet.Dimension.End.Row;     //get row count
        int colCount = worksheet.Dimension.End.Column;     //get col count
        int successRow = 0;

        for (int row = 2; row <= rowCount; row++)
        {
            var resultCell = worksheet.Cells[row, colCount];
            resultCell.Style.WrapText = true;
            resultCell.Style.VerticalAlignment = ExcelVerticalAlignment.Top;
            string createCustomerResult = resultCell.Value as string;
            if (createCustomerResult == "Ok")
            {
                var model = new CollocationCreateModel()
                {
                    ExpectedSize = int.Parse(worksheet.Cells[row, 8].Value?.ToString().Trim()),
                    DateCreate = DateTime.Parse(worksheet.Cells[row, 9].Value?.ToString().Trim()),
                    DateAllocate = DateTime.Parse(worksheet.Cells[row, 10].Value?.ToString().Trim()),
                    DateStop = DateTime.Parse(worksheet.Cells[row, 11].Value?.ToString().Trim()),
                    Note = worksheet.Cells[row, 12].Value?.ToString().Trim(),
                    AdditionalServices = new List<AdditionalServiceModel>()
                };

                // Get services
                for (int i = 13; i < colCount; i++)
                {
                    var serviceName = worksheet.Cells[1, i].Value?.ToString().Trim();
                    var service = _dbContext.Services.FirstOrDefault(x => !x.IsDeleted && x.Name == serviceName);
                    model.AdditionalServices.Add(new AdditionalServiceModel
                    {
                        Id = service.Id,
                        Quantity = int.Parse(worksheet.Cells[row, i].Value?.ToString().Trim())
                    });
                }

                var context = new ValidationContext(model, serviceProvider: null, items: null);
                var validationResults = new List<ValidationResult>();

                bool isValid = Validator.TryValidateObject(model, context, validationResults, true);

                if (!isValid)
                {
                    foreach (ValidationResult validationError in validationResults)
                    {
                        resultCell.Value = validationError.ErrorMessage + "\r\n";
                    }
                }
                else
                {
                    var companyName = worksheet.Cells[row, 1].Value?.ToString().Trim();
                    var username = MyFunction.ConvertToUnSign(companyName.Trim().Replace(" ", ""));
                    var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => !x.IsDeleted && x.User.UserName == username);
                    var result = await AttempCreateRequestFromExcel(model, customer);
                    if (!result.Succeed)
                    {
                        resultCell.Value = result.ErrorMessage;
                    }
                    else
                    {
                        resultCell.Value = "Ok";
                        successRow++;
                    }
                }
            }
        }

        package.Save();

        return new ResultModel
        {
            Succeed = true,
            Data = successRow
        };
    }

    /// <summary>
    /// Create a new collocation for the customer created previous. Will hard delete the customer on fail
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The result model contain the new collocation</returns>
    private async Task<ResultModel> AttempCreateRequestFromExcel(CollocationCreateModel model, Customer customer)
    {
        var result = await CreateRequest(new CollocationRequestCreateModel
        {
            CollocationCreateModel = model,
            CustomerId = customer.Id
        });

        if (!result.Succeed)
        {
            // Delete customer and user on fail to create collocation
            _dbContext.Attach(customer);
            _dbContext.Entry(customer).Reference(x => x.User).Load();
            var user = customer.User;
            _dbContext.Remove(customer);
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        return result;
    }

    public async Task<ResultModel> CreateRequest(CollocationRequestCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        var createModel = model.CollocationCreateModel;
        var customerId = model.CustomerId;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => !x.IsDeleted && x.Id == customerId);
            if (customer == null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Customer " + ErrorMessage.NOT_EXISTED;
            }

            var services = new List<Service>();
            if (validPrecondition)
            {
                foreach (var additionalService in createModel.AdditionalServices)
                {
                    if (additionalService.Quantity > 0)
                    {
                        var service = _dbContext.Services.FirstOrDefault(x => !x.IsDeleted && x.Id == additionalService.Id);
                        if (service == null)
                        {
                            validPrecondition = false;
                        }
                        else
                        {
                            services.Add(service);
                        }
                    }
                }
            }

            if (validPrecondition)
            {
                var collocation = new Collocation
                {
                    Status = CollocationStatus.Pending,
                    ExpectedSize = createModel.ExpectedSize,
                    Note = createModel.Note,
                    InspectorNote = createModel.InspectorNote,
                    DateCreated = createModel.DateCreate,
                    DateAllocate = createModel.DateAllocate,
                    DateStop = createModel.DateStop,
                    CustomerId = customerId,
                };

                _dbContext.Collocations.Add(collocation);
                _dbContext.SaveChanges();

                foreach (var service in services)
                {
                    var additionalService = createModel.AdditionalServices.FirstOrDefault(x => x.Id == service.Id);
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
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> UpdateRequest(CollocationRequestUpdateModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var collocation = _dbContext.Collocations.FirstOrDefault(x => !x.IsDeleted && x.Id == model.Id);
            if (collocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Collocation " + ErrorMessage.NOT_EXISTED;
            }

            if (collocation.Status != CollocationStatus.Pending)
            {
                validPrecondition = false;
                result.ErrorMessage = "Can only update collocation request";
            }

            var services = new List<Service>();
            if (validPrecondition)
            {
                foreach (var additionalService in model.AdditionalServices)
                {
                    if (additionalService.Quantity > 0)
                    {
                        var service = _dbContext.Services.FirstOrDefault(x => !x.IsDeleted && x.Id == additionalService.Id);
                        if (service == null)
                        {
                            validPrecondition = false;
                        }
                        else
                        {
                            services.Add(service);
                        }
                    }
                }
            }

            if (validPrecondition)
            {
                collocation.ExpectedSize = model.ExpectedSize;
                collocation.Note = model.Note;
                collocation.InspectorNote = model.InspectorNote;
                collocation.DateCreated = model.DateCreate;
                collocation.DateAllocate = model.DateAllocate;
                collocation.DateStop = model.DateStop;

                // Delete current additional services
                var currentServices = _dbContext.AdditionalServices.Where(x => !x.IsDeleted && x.CollocationId == model.Id).ToList();
                _dbContext.AdditionalServices.RemoveRange(currentServices);

                // Update additional services
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
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GenerateImportExcelTemplate(string filePath)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var package = new ExcelPackage(new FileInfo(filePath));
            var worksheet = package.Workbook.Worksheets["Sheet1"];
            int rowCount = worksheet.Dimension.End.Row;     //get row count
            int colCount = worksheet.Dimension.End.Column;     //get col count
            var services = _dbContext.Services.Where(x => !x.IsDeleted).ToList();

            // Reset header
            for (int i = 13; i < colCount; i++)
            {
                worksheet.DeleteColumn(i);
                colCount--;
            }

            foreach (var service in services)
            {
                worksheet.Cells[1, colCount++].Value = service.Name;
            }

            package.Save();

            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
