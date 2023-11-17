using Data.Common.PaginationModel;
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
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;
    private readonly IWebHostEnvironment _environment;
    private readonly IFileService _fileService;

    public AppointmentController(IAppointmentService AppointmentService, IWebHostEnvironment environment, IFileService fileService)
    {
        _appointmentService = AppointmentService;
        _environment = environment;
        _fileService = fileService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentSearchModel searchModel)
    {
        var result = await _appointmentService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("All")]
    public async Task<ActionResult> Get()
    {
        var result = await _appointmentService.GetAll();
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

    [HttpGet("{id}/RequestUpgradeAppointment")]
    public async Task<ActionResult> GetRequestUpgradeAppointment(int id)
    {
        var result = await _appointmentService.GetRequestUpgradeAppointment(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestUpgrade")]
    public async Task<ActionResult> GetRequestUpgrade(int id)
    {
        var result = await _appointmentService.GetRequestUpgrade(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] AppointmentCreateModel model)
    {
        var result = await _appointmentService.Create(model);
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
    public async Task<ActionResult> Accept(int id, [FromBody] UserAssignModel model)
    {
        var result = await _appointmentService.Evaluate(id, RequestStatus.Accepted, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting appointment")]
    public async Task<ActionResult> Deny(int id, [FromBody] UserAssignModel model)
    {
        var result = await _appointmentService.Evaluate(id, RequestStatus.Denied, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Complete")]
    public async Task<ActionResult> Complete(int id, [FromBody] AppointmentCompleteModel model)
    {
        var result = await _appointmentService.Complete(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Fail")]
    public async Task<ActionResult> Fail(int id, [FromBody] string userId)
    {
        var result = await _appointmentService.Fail(id, userId);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/InspectionReport")]
    public async Task<ActionResult> UploadInspectionReport(int id, [FromForm] DocumentFileUploadModel model)
    {
        string folderPath = Path.Combine(_environment.WebRootPath, "InspectionReport");
        string fileName = await _fileService.SaveFileWithGuidName(model.File, folderPath);
        var result = await _appointmentService.AssignInspectionReport(id, fileName);
        if (!result.Succeed)
        {
            await _fileService.DeleteFile(fileName);
            return BadRequest(result.ErrorMessage);
        }

        return Ok(fileName);
    }
}
