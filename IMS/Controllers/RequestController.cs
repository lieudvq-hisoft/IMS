using Data.Common.PaginationModel;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class RequestController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly IWebHostEnvironment _environment;
    private readonly IRequestService _requestService;
    private readonly IFileService _fileService;
    //private readonly IServerService _serverService;
    private readonly TransactionHelper _transactionHelper;
    //private readonly ILocationService _locationService;
    //private readonly IIpService _ipService;

    public RequestController(ICustomerService customerService,
        IWebHostEnvironment environment,
        IRequestService requestService,
        IFileService fileService,
        //IServerService serverService,
        TransactionHelper transactionHelper
        //ILocationService locationService
        //IIpService ipService,
        )
    {
        _customerService = customerService;
        _environment = environment;
        _requestService = requestService;
        _fileService = fileService;
        //_serverService = serverService;
        _transactionHelper = transactionHelper;
        //_locationService = locationService;
        //_ipService = ipService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get requests, excluding ongoing or stopped requests, and those with unsuccessful additional services")]
    public async Task<ActionResult> GetRequest([FromQuery] PagingParam<RequestSortCriteria> pagingParam, [FromQuery] RequestSearchModel searchModel)
    {
        var result = await _requestService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("Count")]
    //[SwaggerOperation(Summary = "Get request count base on request status")]
    //public async Task<ActionResult> GetRequestCount([FromQuery] List<RequestStatus> status)
    //{
    //    var result = await _requestService.CountRequest(status);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("Service/Count")]
    //[SwaggerOperation(Summary = "Get service request count base on request status")]
    //public async Task<ActionResult> GetServiceRequestCount([FromQuery] List<ServiceRequestStatus> status)
    //{
    //    var result = await _requestService.CountServiceRequest(status);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpGet("{id}")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Get request detail")]
    public async Task<ActionResult> GetRequestDetail([FromRoute] int id)
    {
        var result = await _requestService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPost("Bulk")]
    //[Authorize(Roles = nameof(RoleType.Sale))]
    //[SwaggerOperation(Summary = "[Sale]: Create user, customer and request base on import excel.")]
    //public async Task<ActionResult> Import([FromForm] ExcelFileUploadModel model)
    //{
    //    string folderPath = Path.Combine(_environment.WebRootPath, "request", "import");
    //    string filePath = await _fileService.SaveFile(model.File, folderPath);
    //    await _customerService.Import(filePath);
    //    var result = await _requestService.ImportRequest(filePath);
    //    var customerIds = (result.Data as List<RequestModel>).Select(x => x.CustomerId).ToList();
    //    await _customerService.SendActivationEmail(customerIds);

    //    return File(System.IO.File.OpenRead(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Result.xlsx");
    //}

    //[HttpGet("Bulk/Template")]
    //[Authorize(Roles = nameof(RoleType.Sale))]
    //[SwaggerOperation(Summary = "[Sale]: Generate the excel file for importing. The services will be base on the database")]
    //public async Task<ActionResult> GetImportTemplate()
    //{
    //    string filePath = Path.Combine(_environment.WebRootPath, "request", "import", "Template.xlsx");
    //    var result = await _requestService.GenerateImportExcelTemplate(filePath);
    //    if (result.Succeed)
    //    {
    //        return File(System.IO.File.OpenRead(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Import.xlsx");
    //    }

    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost]
    //[Authorize(Roles = nameof(RoleType.Sale) + "," + nameof(RoleType.Customer))]
    [SwaggerOperation(Summary = "[Sale, Customer]: Create request for an existing customer")]
    public async Task<ActionResult> CreateRequest([FromBody] RequestCreateModel model)
    {
        var result = await _requestService.CreateRequest(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "[Sale]: Update information of a request")]
    public async Task<ActionResult> UpdateRequest([FromBody] RequestUpdateModel model)
    {
        var result = await _requestService.UpdateRequest(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("{id}/CompleteDetail")]
    //[Authorize(Roles = nameof(RoleType.Tech))]
    //[SwaggerOperation(Summary = "[Tech]: Complete")]
    //public async Task<ActionResult> CompleteRequestDetail(int id, RequestDetailCompleteModel model)
    //{
    //    string errorMessage;
    //    using var transaction = _transactionHelper.GetTransaction();
    //    var createServerResult = await _serverService.AttempCreateServer(id, model.ServerCreateModel, transaction);
    //    if (createServerResult.Succeed)
    //    {
    //        var device = createServerResult.Data as Device;
    //        var placeServerResult = await _locationService.AttempPlaceDevice(model.LocationChoiceModel, device, transaction);
    //        if (placeServerResult.Succeed)
    //        {
    //            var assignIpResult = await _ipService.AttempAssignIp(id, model.IpId, transaction);
    //            if (assignIpResult.Succeed)
    //            {
    //                transaction.Commit();
    //                return Ok();
    //            }
    //            else
    //            {
    //                errorMessage = assignIpResult.ErrorMessage;
    //            }
    //        }
    //        else
    //        {
    //            errorMessage = placeServerResult.ErrorMessage;
    //        }
    //    }
    //    else
    //    {
    //        errorMessage = createServerResult.ErrorMessage;
    //    }

    //    transaction.Rollback();
    //    return BadRequest(errorMessage);
    //}

    //[HttpGet("{id}/InspectionRecord")]
    //[SwaggerOperation(Summary = "Get request inspection record")]
    //public async Task<ActionResult> DownloadInspectionRecord(int id)
    //{
    //    var result = await _requestService.GetInspectionRecordFilePath(id);
    //    string folderPath = Path.Combine(_environment.WebRootPath, "request", "inspection_record");
    //    if (result.Succeed)
    //    {
    //        string filePath = Path.Combine(folderPath, result.Data as string);
    //        return File(System.IO.File.OpenRead(filePath), "application/pdf", "InspectionRecord.pdf");
    //    }
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPatch("{id}/InspectionRecord")]
    //[Authorize(Roles = nameof(RoleType.Tech))]
    //[SwaggerOperation(Summary = "[Tech]: Update request inspection record")]
    //public async Task<ActionResult> UploadInspectionRecord(int id, [FromForm] DocumentFileUploadModel model)
    //{
    //    string folderPath = Path.Combine(_environment.WebRootPath, "request", "inspection_record");
    //    string fileName = await _fileService.SaveFileWithGuidName(model.File, folderPath);
    //    var result = await _requestService.AssignInspectionRecordFilePath(id, fileName);
    //    if (!result.Succeed)
    //    {
    //        await _fileService.DeleteFile(fileName);
    //        return BadRequest(result.ErrorMessage);
    //    }

    //    return Ok(fileName);
    //}

    //[HttpGet("{id}/ReceiptOfRecipient")]
    //[SwaggerOperation(Summary = "Get request receipt of recipient")]
    //public async Task<ActionResult> GetReceiptOfRecipient(int id)
    //{
    //    var result = await _requestService.GetReceiptOfRecipientFilePath(id);
    //    string folderPath = Path.Combine(_environment.WebRootPath, "request", "receipt_of_recipient");
    //    if (result.Succeed)
    //    {
    //        string filePath = Path.Combine(folderPath, result.Data as string);
    //        return File(System.IO.File.OpenRead(filePath), "application/pdf", "ReceiptOfRecipient.pdf");
    //    }
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPatch("{id}/ReceiptOfRecipient")]
    //[Authorize(Roles = nameof(RoleType.Tech))]
    //[SwaggerOperation(Summary = "[Tech]: Update request receipt of recipient")]
    //public async Task<ActionResult> UploadReceiptOfRecipient(int id, [FromForm] DocumentFileUploadModel model)
    //{
    //    string folderPath = Path.Combine(_environment.WebRootPath, "request", "receipt_of_recipient");
    //    string fileName = await _fileService.SaveFileWithGuidName(model.File, folderPath);
    //    var result = await _requestService.AssignReceiptOfRecipientFilePath(id, fileName);
    //    if (!result.Succeed)
    //    {
    //        await _fileService.DeleteFile(fileName);
    //        return BadRequest(result.ErrorMessage);
    //    }

    //    return Ok(fileName);
    //}
}
