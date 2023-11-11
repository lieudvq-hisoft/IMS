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
public class IpAssignmentController : ControllerBase
{
    private readonly IIpAssignmentService _ipAssignmentService;

    public IpAssignmentController(IIpAssignmentService ipAssignmentService)
    {
        _ipAssignmentService = ipAssignmentService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get IpAssignmentService")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<IpAssignmentSortCriteria> paginationModel, [FromQuery] IpAssignmentSearchModel searchModel)
    {
        var result = await _ipAssignmentService.Get(paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create IpAssignmentService")]
    public async Task<ActionResult> Post([FromBody] IpAssignmentCreateModel model)
    {
        var result = await _ipAssignmentService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch]
    [SwaggerOperation(Summary = "Update IpAssignmentService")]
    public async Task<ActionResult> Patch([FromBody] IpAssignmentUpdateModel model)
    {
        var result = await _ipAssignmentService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Delete IpAssignmentService")]
    public async Task<ActionResult> Delete([FromQuery] int id)
    {
        var result = await _ipAssignmentService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
