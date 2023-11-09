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
public class LocationServiceController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationServiceController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("LocationService")]
    [SwaggerOperation(Summary = "Get all LocationService")]
    public async Task<ActionResult> GetLocationService()
    {
        var result = await _locationService.GetLocationService();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("LocationService")]
    [SwaggerOperation(Summary = "Create LocationService")]
    public async Task<ActionResult> CreateLocationService([FromBody] LocationServiceCreateModel model)
    {
        var result = await _locationService.CreateLocationService(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("LocationService")]
    [SwaggerOperation(Summary = "Update LocationService")]
    public async Task<ActionResult> GetRackDetail(LocationServiceUpdateModel model)
    {
        var result = await _locationService.UpdateLocationService(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("LocationService")]
    [SwaggerOperation(Summary = "Delete LocationService")]
    public async Task<ActionResult> GetRackAvailableLocationChoice(int id)
    {
        var result = await _locationService.DeleteLocationService(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
