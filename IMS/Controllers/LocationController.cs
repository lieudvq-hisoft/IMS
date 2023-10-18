using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("Area")]
    [SwaggerOperation(Summary = "Get all area")]
    public async Task<ActionResult> GetAreas()
    {
        var result = await _locationService.GetAreas();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Area/{id}/Suggestion")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Get all area have enough space for device with specified size")]
    public async Task<ActionResult> GetAreaSuggestionRack(int id, [FromQuery] int size)
    {
        var result = await _locationService.GetRackChoiceSuggestionBySize(id, size);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Rack/{id}")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Get a detail information of rack and it's device map")]
    public async Task<ActionResult> GetRackDetail(int id)
    {
        var result = await _locationService.GetRackDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Rack/{id}/Available")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Get all empty space of a rack")]
    public async Task<ActionResult> GetRackAvailableLocationChoice(int id)
    {
        var result = await _locationService.GetRackAvailableLocationChoice(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
