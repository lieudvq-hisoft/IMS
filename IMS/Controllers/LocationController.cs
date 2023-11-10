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
public class LocationController : ControllerBase
{
    private readonly ILocationAssignmentService _locationService;

    public LocationController(ILocationAssignmentService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("LocationService")]
    [SwaggerOperation(Summary = "Get all LocationService")]
    public async Task<ActionResult> GetLocationService([FromQuery] PagingParam<LocationAssignmentSortingCriteria> pagingParam, [FromQuery] LocationAssignmentSearchModel searchModel)
    {
        var result = await _locationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("LocationService")]
    [SwaggerOperation(Summary = "Create LocationService")]
    public async Task<ActionResult> CreateLocationService([FromBody] LocationCreateModel model)
    {
        var result = await _locationService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("LocationService")]
    //[SwaggerOperation(Summary = "Update LocationService")]
    //public async Task<ActionResult> GetRackDetail(LocationUpdateModel model)
    //{
    //    var result = await _locationService.Update(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpDelete("LocationService")]
    [SwaggerOperation(Summary = "Delete LocationService")]
    public async Task<ActionResult> GetRackAvailableLocationChoice(int id)
    {
        var result = await _locationService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
