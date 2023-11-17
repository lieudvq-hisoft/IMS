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

    [HttpGet]
    [SwaggerOperation(Summary = "Get all Rack")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RackSearchModel searchModel)
    {
        var result = await _RackService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Get detail information of an Rack")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _RackService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Location")]
    [SwaggerOperation(Summary = "Get all Rack by area Id")]
    public async Task<ActionResult> Get(int id)
    {
        var result = await _RackService.GetLocation(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create an arae")]
    public async Task<ActionResult> Create([FromBody] RackCreateModel model)
    {
        var result = await _RackService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "Delete an Rack")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _RackService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
