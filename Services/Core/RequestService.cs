using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Services.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Services.Core;
public interface IRequestService
{
    Task<ResultModel> Get(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel);
    Task<ResultModel> GetRequest(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> ImportRequest(string filePath);
    Task<ResultModel> CreateRequest(InitialRequestCreateModel model);
    Task<ResultModel> UpdateRequest(RequestUpdateModel model);
    Task<ResultModel> GenerateImportExcelTemplate(string filePath);
    Task<ResultModel> GetInspectionRecordFilePath(int requestId);
    Task<ResultModel> AssignInspectionRecordFilePath(int requestId, string fileName);
    Task<ResultModel> GetReceiptOfRecipientFilePath(int requestId);
    Task<ResultModel> AssignReceiptOfRecipientFilePath(int requestId, string fileName);
}

public class RequestService : IRequestService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    /// <summary>
    /// Retrieves a paginated list of ongoing and stopped requests with optional search and sorting.
    /// </summary>
    /// <param name="paginationModel">Pagination and sorting parameters.</param>
    /// <param name="searchModel">Criteria for filtering requests.</param>
    /// <returns>The paginated request data or an error message.</returns>
    /// <exception cref="Exception">Thrown when an error occurs during data retrieval.</exception>
    public async Task<ResultModel> Get(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requests = _dbContext.Requests
                .Include(x => x.Customer)
                .Include(x => x.RequestExtendHistories)
                .Include(x => x.ServiceRequests)
                .Where(x => x.Status == RequestStatus.Ongoing
                    || x.Status == RequestStatus.Stopped)
                .Where(delegate (Request x)
                {
                    var matchCompanyName = MatchString(searchModel, x.Customer.CompanyName);
                    var matchStatus = searchModel.Status != null ? x.Status.ToString() == searchModel.Status.ToString() : true;
                    return matchCompanyName && matchStatus;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requests.Count());

            requests = requests.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requests = requests.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestModel>(requests).ToList();

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    /// <summary>
    /// Retrieves a paginated list of request with is request that are not ongoing or stopped with optional search and sorting and request with service not success.
    /// </summary>
    /// <param name="paginationModel">Pagination and sorting parameters.</param>
    /// <param name="searchModel">Criteria for filtering requests.</param>
    /// <returns>The paginated request data or an error message.</returns>
    /// <exception cref="Exception">Thrown when an error occurs during data retrieval.</exception>
    public async Task<ResultModel> GetRequest(PagingParam<RequestSortCriteria> paginationModel, RequestSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requests = _dbContext.Requests
                .Include(x => x.Customer)
                .ThenInclude(x => x.User)
                .Include(x => x.RequestExtendHistories)
                .Include(x => x.ServiceRequests)
                .Where(x => x.Status != RequestStatus.Ongoing ||
                    x.Status != RequestStatus.Stopped ||
                    x.ServiceRequests.Any(_ => _.Status != ServiceRequestStatus.Success))
                .Where(delegate (Request x)
                {
                    var matchCompanyName = MatchString(searchModel, x.Customer.CompanyName);
                    var matchStatus = searchModel.Status != null ? x.GetRequestStatus() == searchModel.Status.ToString() : true;
                    var matchId = searchModel.Id != null ? x.Id == searchModel.Id : true;
                    return matchCompanyName && matchStatus;
                })
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requests.Count());

            requests = requests.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requests = requests.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.ProjectTo<RequestModel>(requests).ToList();

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
            var request = _dbContext.Requests
                .Include(x => x.Customer)
                .ThenInclude(x => x.User)
                .Include(x => x.RequestExtendHistories)
                .Include(x => x.ServiceRequests)
                .FirstOrDefault(x => x.Id == id);

            result.Data = _mapper.Map<RequestModel>(request);
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private bool MatchString(RequestSearchModel searchModel, string? value)
    {
        return MyFunction
            .ConvertToUnSign(value ?? "")
            .IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }

    public async Task<ResultModel> ImportRequest(string filePath)
    {
        var importedRequest = new List<RequestModel>();
        using var package = new ExcelPackage(new FileInfo(filePath));
        var worksheet = package.Workbook.Worksheets["Sheet1"];
        int rowCount = worksheet.Dimension.End.Row;     //get row count
        int colCount = worksheet.Dimension.End.Column;     //get col count

        for (int row = 2; row <= rowCount; row++)
        {
            var resultCell = worksheet.Cells[row, colCount];
            resultCell.Style.WrapText = true;
            resultCell.Style.VerticalAlignment = ExcelVerticalAlignment.Top;
            string createCustomerResult = resultCell.Value as string;
            if (createCustomerResult == "Ok")
            {
                var model = new RequestCreateModel()
                {
                    ExpectedSize = int.Parse(worksheet.Cells[row, 8].Value?.ToString().Trim()),
                    DateCreated = DateTime.Parse(worksheet.Cells[row, 9].Value?.ToString().Trim()),
                    DateAllocate = DateTime.Parse(worksheet.Cells[row, 10].Value?.ToString().Trim()),
                    DateStop = DateTime.Parse(worksheet.Cells[row, 11].Value?.ToString().Trim()),
                    Note = worksheet.Cells[row, 12].Value?.ToString().Trim(),
                    ServiceRequests = new List<ServiceRequestModel>()
                };

                // Get services
                for (int i = 13; i < colCount; i++)
                {
                    var serviceName = worksheet.Cells[1, i].Value?.ToString().Trim();
                    var service = _dbContext.Services.FirstOrDefault(x => x.Name == serviceName);
                    model.ServiceRequests.Add(new ServiceRequestModel
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
                    var email = worksheet.Cells[row, 6].Value?.ToString().Trim();
                    var customer = _dbContext.Customers.Include(x => x.User).FirstOrDefault(x => x.User.Email == email);

                    var result = await AttempCreateRequestFromExcel(model, customer);
                    if (!result.Succeed)
                    {
                        resultCell.Value = result.ErrorMessage;
                    }
                    else
                    {
                        importedRequest.Add(result.Data as RequestModel);
                        resultCell.Value = "Ok";
                    }
                }
            }
        }

        package.Save();

        return new ResultModel
        {
            Succeed = true,
            Data = importedRequest
        };
    }

    /// <summary>
    /// Create a new request for the customer created previous. Will hard delete the customer on fail
    /// </summary>
    /// <param name="model"></param>
    /// <returns>The result model contain the new request</returns>
    private async Task<ResultModel> AttempCreateRequestFromExcel(RequestCreateModel model, Customer customer)
    {
        var result = await CreateRequest(new InitialRequestCreateModel
        {
            RequestCreateModel = model,
            CustomerId = customer.Id
        });

        if (!result.Succeed)
        {
            // Delete customer and user on fail to create request
            _dbContext.Attach(customer);
            _dbContext.Entry(customer).Reference(x => x.User).Load();
            var user = customer.User;
            _dbContext.Remove(customer);
            _dbContext.Remove(user);
            _dbContext.SaveChanges();
        }

        return result;
    }

    public async Task<ResultModel> CreateRequest(InitialRequestCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;
        var createModel = model.RequestCreateModel;
        var customerId = model.CustomerId;

        try
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer == null)
            {
                validPrecondition = false;
                result.ErrorMessage = CustomerErrorMessage.NOT_EXISTED;
            }

            var services = new List<Service>();
            if (validPrecondition)
            {
                foreach (var serviceRequest in createModel.ServiceRequests)
                {
                    if (serviceRequest.Quantity > 0)
                    {
                        var service = _dbContext.Services.FirstOrDefault(x => x.Id == serviceRequest.Id);
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
                var request = new Request
                {
                    Status = RequestStatus.Incomplete,
                    ExpectedSize = createModel.ExpectedSize,
                    Note = createModel.Note,
                    InspectorNote = createModel.InspectorNote,
                    DateAllocate = createModel.DateAllocate,
                    CustomerId = customerId,
                    DateCreated = createModel.DateCreated,
                    InitialDateStop = createModel.DateStop
                };

                _dbContext.Requests.Add(request);
                _dbContext.SaveChanges();

                foreach (var service in services)
                {
                    var serviceRequest = createModel.ServiceRequests.FirstOrDefault(x => x.Id == service.Id);
                    _dbContext.ServiceRequests.Add(new Data.Entities.ServiceRequest
                    {
                        ServiceId = service.Id,
                        RequestId = request.Id,
                        Quantity = serviceRequest.Quantity
                    });
                }

                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<RequestModel>(request);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> UpdateRequest(RequestUpdateModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var request = _dbContext.Requests.Include(x => x.RequestExtendHistories).FirstOrDefault(x => x.Id == model.Id);
            if (request == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }

            if (request.Status != RequestStatus.Pending)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestErrorMessage.UPDATE_NON_PENDING;
            }

            var services = new List<Service>();
            if (validPrecondition)
            {
                foreach (var serviceRequest in model.ServiceRequests)
                {
                    if (serviceRequest.Quantity > 0)
                    {
                        var service = _dbContext.Services.FirstOrDefault(x => x.Id == serviceRequest.Id);
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
                request.ExpectedSize = model.ExpectedSize;
                request.Note = model.Note;
                request.InspectorNote = model.InspectorNote;
                request.DateCreated = model.DateCreated;
                request.DateAllocate = model.DateAllocate;
                request.DateStop = model.DateStop;

                // Delete current additional services
                var currentServices = _dbContext.ServiceRequests.Where(x => x.RequestId == model.Id).ToList();
                _dbContext.ServiceRequests.RemoveRange(currentServices);

                // Update additional services
                foreach (var service in services)
                {
                    var serviceRequest = model.ServiceRequests.FirstOrDefault(x => x.Id == service.Id);
                    _dbContext.ServiceRequests.Add(new ServiceRequest
                    {
                        ServiceId = service.Id,
                        RequestId = request.Id,
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
            var services = _dbContext.Services.ToList();

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

    public async Task<ResultModel> GetInspectionRecordFilePath(int requestId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var request = _dbContext.Requests.FirstOrDefault(x => x.Id == requestId);
            if (request == null)
            {
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            else if (request.Status == RequestStatus.Pending || request.Status == RequestStatus.Denied)
            {
                result.ErrorMessage = RequestErrorMessage.DOWNLOAD_FILE_FROM_NON_ACCEPTED;
            }
            else if (request.InspectionRecordFilePath == null)
            {
                result.ErrorMessage = RequestErrorMessage.FILE_NOT_EXISTED;
            }
            else
            {
                result.Succeed = true;
                result.Data = request.InspectionRecordFilePath;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignInspectionRecordFilePath(int requestId, string fileName)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var request = _dbContext.Requests.FirstOrDefault(x => x.Id == requestId);
            if (request == null)
            {
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            else if (request.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestErrorMessage.ASSIGN_FILE_TO_NON_ACCEPTED;
            }
            else
            {
                request.InspectionRecordFilePath = fileName;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = fileName;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetReceiptOfRecipientFilePath(int requestId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var request = _dbContext.Requests.FirstOrDefault(x => x.Id == requestId);
            if (request == null)
            {
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            else if (request.Status == RequestStatus.Pending || request.Status == RequestStatus.Denied)
            {
                result.ErrorMessage = RequestErrorMessage.DOWNLOAD_FILE_FROM_NON_ACCEPTED;
            }
            else if (request.ReceiptOfRecipientFilePath == null)
            {
                result.ErrorMessage = RequestErrorMessage.FILE_NOT_EXISTED;
            }
            else
            {
                result.Succeed = true;
                result.Data = request.ReceiptOfRecipientFilePath;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignReceiptOfRecipientFilePath(int requestId, string fileName)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var request = _dbContext.Requests.FirstOrDefault(x => x.Id == requestId);
            if (request == null)
            {
                result.ErrorMessage = RequestErrorMessage.NOT_EXISTED;
            }
            else if (request.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestErrorMessage.ASSIGN_FILE_TO_NON_ACCEPTED;
            }
            else
            {
                request.ReceiptOfRecipientFilePath = fileName;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = fileName;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }
}
