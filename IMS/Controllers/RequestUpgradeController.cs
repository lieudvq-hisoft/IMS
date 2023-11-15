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
public class RequestUpgradeController : ControllerBase
{
    private readonly IRequestUpgradeService _requestUpgradeService;

    public RequestUpgradeController(IRequestUpgradeService requestUpgradeService)
    {
        this._requestUpgradeService = requestUpgradeService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<RequestUpgradeSortCriteria> paginationModel, [FromQuery] RequestUpgradeSearchModel searchModel)
    {
        var result = await _requestUpgradeService.Get(paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] RequestUpgradeCreateModel model)
    {
        var result = await _requestUpgradeService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] RequestUpgradeUpdateModel model)
    {
        var result = await _requestUpgradeService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestUpgradeService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    public async Task<ActionResult> Accept(int id)
    {
        var userId = new Guid(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value);
        var result = await _requestUpgradeService.Accept(id, userId);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    public async Task<ActionResult> Deny(int id)
    {
        var userId = new Guid(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value);
        var result = await _requestUpgradeService.Deny(id, userId);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
