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
public class RackController : ControllerBase
{
    private readonly IRackService _RackService;

    public RackController(IRackService RackService)
    {
        _RackService = RackService;
    }

    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Get detail information of an Rack")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _RackService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Map")]
    [SwaggerOperation(Summary = "Get all rack location with server allocation id by rack id")]
    public async Task<ActionResult> GetRackMap(int id)
    {
        var result = await _RackService.GetRackMap(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "Create an arae")]
    public async Task<ActionResult> Create([FromBody] RackCreateModel model)
    {
        var result = await _RackService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "Delete an Rack")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _RackService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
