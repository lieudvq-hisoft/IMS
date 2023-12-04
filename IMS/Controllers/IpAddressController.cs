﻿using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class IpAddressController : ControllerBase
{
    private readonly IIpAddressService _ipAddressService;

    public IpAddressController(IIpAddressService ipAddressService)
    {
        _ipAddressService = ipAddressService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] IpAddressSearchModel searchModel)
    {
        var result = await _ipAddressService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _ipAddressService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/ServerAllocation")]
    public async Task<ActionResult> GetServerAllocation(int id, [FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] ServerAllocationSearchModel searchModel)
    {
        var result = await _ipAddressService.GetServerAllocation(id, paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("SuggestMaster")]
    public async Task<ActionResult> GetSuggestion()
    {
        var result = await _ipAddressService.SuggestMasterIp();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Block")]
    public async Task<ActionResult> Block([FromBody] IpAddressIdListModel model)
    {
        var result = await _ipAddressService.ChangeBlockingStatus(model, true);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Unblock")]
    public async Task<ActionResult> Unblock([FromBody] IpAddressIdListModel model)
    {
        var result = await _ipAddressService.ChangeBlockingStatus(model, false);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Purpose")]
    public async Task<ActionResult> Purpose([FromBody] IpAddressChangePurposeModel model)
    {
        var result = await _ipAddressService.ChangePurpose(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}