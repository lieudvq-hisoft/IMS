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
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;
    private readonly IWebHostEnvironment _environment;

    public AppointmentController(IAppointmentService AppointmentService, IWebHostEnvironment environment)
    {
        _appointmentService = AppointmentService;
        _environment = environment;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentSearchModel searchModel)
    {
        var result = await _appointmentService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Month/{month}")]
    public async Task<ActionResult> Get(int month, [FromQuery] AppointmentSearchModel searchModel)
    {
        var result = await _appointmentService.GetByMonth(searchModel, month);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _appointmentService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("{id}/RequestExpand")]
    //public async Task<ActionResult> GetRequestExpand([FromQuery] PagingParam<BaseSortCriteria> pagingParam, int id)
    //{
    //    var result = await _appointmentService.GetRequestExpand(pagingParam, id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut("{id}/Request")]
    public async Task<ActionResult> CreateRequestUpgradeAppointment(int id, RequestAppointmentCreateModel model)
    {
        var result = await _appointmentService.CreateRequestAppointment(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("{id}/RequestUpgrade")]
    //public async Task<ActionResult> GetRequestUpgrade(int id, [FromQuery] PagingParam<RequestUpgradeSortCriteria> paginationModel, [FromQuery] RequestUpgradeSearchModel searchModel)
    //{
    //    var result = await _appointmentService.GetRequestUpgrade(id, paginationModel, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/Incident")]
    //public async Task<ActionResult> GetIncident(int id, [FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] IncidentSearchModel searchModel)
    //{
    //    var result = await _appointmentService.GetIncident(id, paginationModel, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] AppointmentCreateModel model)
    {
        var result = await _appointmentService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Incident")]
    public async Task<ActionResult> CreateIncident([FromBody] AppointmentIncidentCreateModel model)
    {
        var result = await _appointmentService.CreateIncident(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] AppointmentUpdateModel model)
    {
        var result = await _appointmentService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _appointmentService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [SwaggerOperation(Summary = "Accept a waiting appointment")]
    public async Task<ActionResult> Accept(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _appointmentService.Accept(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting appointment")]
    public async Task<ActionResult> Deny(int id, [FromBody] DenyModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _appointmentService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("{id}/Executor")]
    //public async Task<ActionResult> AssignExecutor(int id, [FromBody] UserAssignModel model)
    //{
    //    var result = await _appointmentService.AssignTech(id, model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut("{id}/Complete")]
    public async Task<ActionResult> Complete(int id, [FromBody] AppointmentCompleteModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _appointmentService.Complete(id, model, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Resolv")]
    public async Task<ActionResult> Resolv(int id, [FromBody] AppointmentResolvModel model)
    {
        var result = await _appointmentService.Resolv(id, model, new Guid(User.GetId()));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Fail")]
    public async Task<ActionResult> Fail(int id, AppointmentFailModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _appointmentService.Fail(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Document")]
    public async Task<ActionResult> UpdateDocument(int id, [FromBody] ServerAllocationCreateRequestExpandInspectionReportModel model)
    {
        var result = await _appointmentService.UpdateDocument(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/FinalDocument")]
    public async Task<ActionResult> UploadFinalDocument(int id, [FromForm] DocumentFileUploadModel model)
    {
        var result = await _appointmentService.AssignFinalDocument(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/DocumentConfirmation/True")]
    public async Task<ActionResult> DocumentConfirmationTrue(int id)
    {
        var result = await _appointmentService.ConfirmDocument(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
