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
    private readonly ILocationService _LocationService;

    public LocationController(ILocationService LocationService)
    {
        _LocationService = LocationService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get all Location")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<SimpleSortCriteria> pagingParam, [FromQuery] LocationSearchModel searchModel)
    {
        var result = await _LocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _LocationService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("{id}/RequestExpandLocation")]
    //public async Task<ActionResult> GetRequestExpandLocation(int id)
    //{
    //    var result = await _LocationService.GetRequestExpandLocation(id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/LocationAssignment")]
    //public async Task<ActionResult> GetLocationAssignment(int id)
    //{
    //    var result = await _LocationService.GetLocationAssignment(id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut("Reserve")]
    public async Task<ActionResult> ReserveLocation(LocationReserveModel model)
    {
        var result = await _LocationService.ReservceLocation(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Unreserve")]
    public async Task<ActionResult> UnreserveLocation(LocationReserveModel model)
    {
        var result = await _LocationService.UnreservceLocation(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}