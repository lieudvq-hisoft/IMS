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
public class AppointmentUserController : ControllerBase
{
    private readonly IAppointmentUserService _appointmentUserService;

    public AppointmentUserController(IAppointmentUserService appointmentUserService)
    {
        _appointmentUserService = appointmentUserService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get all Appointment users")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentUserSearchModel searchModel)
    {
        var result = await _appointmentUserService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _appointmentUserService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
