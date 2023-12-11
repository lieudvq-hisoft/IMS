using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ClaimExtensions;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class ServerAllocationController : ControllerBase
{
    private readonly IServerAllocationService _serverAllocationService;

    public ServerAllocationController(IServerAllocationService serverAllocationService)
    {
        _serverAllocationService = serverAllocationService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get requests, excluding ongoing or stopped requests, and those with unsuccessful additional services")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] ServerAllocationSearchModel searchModel)
    {
        var result = await _serverAllocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail([FromRoute] int id)
    {
        var result = await _serverAllocationService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/HardwareConfig")]
    public async Task<ActionResult> GetHardwareConfig([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetHardwareConfig(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestUpgrade")]
    public async Task<ActionResult> GetRequestUpgrade([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetRequestUpgrade(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestExpand")]
    public async Task<ActionResult> GetRequestExpand([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetRequestExpand(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestHost")]
    public async Task<ActionResult> GetRequestHost(int id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestHostSearchModel searchModel)
    {
        var result = await _serverAllocationService.GetRequestHost(id, pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }


    [HttpGet("{id}/LocationAssignment")]
    public async Task<ActionResult> GetLocationAssignment([FromRoute] int id)
    {
        var result = await _serverAllocationService.GetLocationAssignment(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/IpAddress")]
    public async Task<ActionResult> GetIpAddress([FromRoute] int id, [FromQuery] PagingParam<SimpleSortCriteria> paginationModel, [FromQuery] IpAddressSearchModel searchModel)
    {
        var result = await _serverAllocationService.GetIpAddress(id, paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Location")]
    public async Task<ActionResult> GetLocation([FromQuery] PagingParam<SimpleSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetLocation(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Appointment")]
    public async Task<ActionResult> GetAppointment([FromRoute] int id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentSearchModel searchModel)
    {
        var result = await _serverAllocationService.GetAppointment(id, pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] ServerAllocationCreateModel model)
    {
        var result = await _serverAllocationService.Create(model, new Guid
            (User.GetId()));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ServerAllocationUpdateModel model)
    {
        var result = await _serverAllocationService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Confirm")]
    public async Task<ActionResult> Confirm(int id)
    {
        var result = await _serverAllocationService.Confirm(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpDelete("{id}")]
    //public async Task<ActionResult> Delete(int id)
    //{
    //    var result = await _serverAllocationService.Delete(id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost("{id}/MasterIp")]
    public async Task<ActionResult> AssignMasterIp(int id, [FromBody] ServerAllocationMasterIpAssignmentModel model)
    {
        var result = await _serverAllocationService.AssignMasterIp(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPost("{id}/ServerLocation")]
    //public async Task<ActionResult> AssignServerLocation(int id, [FromBody] ServerAllocationAssignLocationModel model)
    //{
    //    var result = await _serverAllocationService.AssignLocation(id, model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPost("{id}/InspectionReport")]
    //public async Task<ActionResult> CreateInspectionReport(int id, [FromBody] HostAndUpgradeCreateInspectionReportModel model)
    //{
    //    var result = await _serverAllocationService.CreateUpgradeAndHostInspectionReport(id, model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPost("{id}/ReceiptOfRecipient")]
    //public async Task<ActionResult> CreateReceiptOfRecipient(int id, [FromBody] ServerAllocationCreateRequestExpandInspectionReportModel model)
    //{
    //    var result = await _serverAllocationService.CreateReceiptReport(id, model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPost("{id}/RequestExpandInspection")]
    //public async Task<ActionResult> CreateRequestExpandInspection(int id, [FromBody] ServerAllocationCreateRequestExpandInspectionReportModel model)
    //{
    //    var result = await _serverAllocationService.CreateRequestExpandInspectionReport(id, model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost("{id}/Document")]
    public async Task<ActionResult> UploadInspectionRecordAndReceiptOfRecipientReport(int id, [FromForm] DocumentFileUploadModel model)
    {
        var result = await _serverAllocationService.AssignInspectionRecordAndReceiptOfRecipientReport(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
