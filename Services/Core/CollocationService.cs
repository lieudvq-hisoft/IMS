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
    Task<ResultModel> AttempCreateFromExcel(CollocationCreateModel model, Customer customer);
    Task<ResultModel> Get(PagingParam<CollocationSortCriteria> paginationModel, CollocationSearchModel searchModel);
    Task<ResultModel> Import(string filePath);
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

    public async Task<ResultModel> Import(string filePath)
    {
        //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
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
                    var service = _dbContext.Services.FirstOrDefault(x => x.Name == serviceName);
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
                    var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.User.UserName == username);
                    var result = await AttempCreateFromExcel(model, customer);
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
    public async Task<ResultModel> AttempCreateFromExcel(CollocationCreateModel model, Customer customer)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var services = new List<Service>();
            foreach (var additionalService in model.AdditionalServices)
            {
                if (additionalService.Quantity > 0)
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
            }

            if (validPrecondition)
            {
                var collocation = new Collocation
                {
                    Status = CollocationStatus.Pending,
                    ExpectedSize = model.ExpectedSize,
                    Note = model.Note,
                    InspectorNote = model.InspectorNote,
                    DateCreated = model.DateCreate,
                    DateAllocate = model.DateAllocate,
                    DateStop = model.DateStop,
                    CustomerId = customer.Id,
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
            _dbContext.Attach(customer);
            _dbContext.Entry(customer).Reference(x => x.User).Load();
            var user = customer.User;
            _dbContext.Remove(customer);
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        return result;
    }
}
