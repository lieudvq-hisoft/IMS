using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class LocationAssignmentController : ControllerBase
{
    private readonly ILocationAssignmentService _LocationAssignmentService;

    public LocationAssignmentController(ILocationAssignmentService LocationAssignmentService)
    {
        _LocationAssignmentService = LocationAssignmentService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<LocationAssignmentSortingCriteria> pagingParam, [FromQuery] LocationAssignmentSearchModel searchModel)
    {
        var result = await _LocationAssignmentService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _LocationAssignmentService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] LocationAssignmentCreateModel model)
    {
        var result = await _LocationAssignmentService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _LocationAssignmentService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
