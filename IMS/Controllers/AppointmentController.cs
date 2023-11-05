using Data.Common.PaginationModel;
using Data.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
//[Authorize(AuthenticationSchemes = "Bearer")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;
    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get appointment list")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<AppointmentSortCriteria> pagingParam)
    {
        var result = await _appointmentService.Get(pagingParam);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Get server list")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _appointmentService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

}
