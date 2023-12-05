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

    [HttpGet("All")]
    [SwaggerOperation(Summary = "Get all Rack no paging")]
    public async Task<ActionResult> GetAll()
    {
        var result = await _RackService.GetAll();
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

    //[HttpGet("{id}/Location")]
    //[SwaggerOperation(Summary = "Get all rack location by rack id")]
    //public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, int id)
    //{
    //    var result = await _RackService.GetLocation(pagingParam, id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpGet("{id}/ServerAllocation")]
    [SwaggerOperation(Summary = "Get all rack server allocation by rack id")]
    public async Task<ActionResult> GetServerAllocation([FromQuery] PagingParam<BaseSortCriteria> pagingParam, int id)
    {
        var result = await _RackService.GetServerAllocation(pagingParam, id);
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

    [HttpGet("{id}/Power")]
    [SwaggerOperation(Summary = "Get rack power")]
    public async Task<ActionResult> GetPower(int id)
    {
        var result = await _RackService.GetPower(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Create an arae")]
    public async Task<ActionResult> Create([FromBody] RackCreateModel model)
    {
        var result = await _RackService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Delete an Rack")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _RackService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("SuggestLocation")]
    public async Task<ActionResult> Suggest([FromQuery] SuggestLocationModel model)
    {
        var result = await _RackService.GetRackChoiceSuggestionBySize(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
