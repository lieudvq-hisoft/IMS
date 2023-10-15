﻿using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
//[Authorize(Roles = nameof(RoleType.Staff))]
[AllowAnonymous]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("Areas")]
    public async Task<ActionResult> GetAreas()
    {
        var result = await _locationService.GetAreas();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Rack/{id}")]
    public async Task<ActionResult> GetRack(int id)
    {
        var result = await _locationService.GetRackDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Rack/{id}/Available")]
    public async Task<ActionResult> GetAvailableLocationChoice(int id)
    {
        var result = await _locationService.GetRackAvailableLocationChoice(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
