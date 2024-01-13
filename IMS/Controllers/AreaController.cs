using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class AreaController : ControllerBase
{
    private readonly IAreaService _areaService;

    public AreaController(IAreaService areaService)
    {
        _areaService = areaService;
    }

    [HttpGet("All")]
    public async Task<ActionResult> GetALL()
    {
        var result = await _areaService.GetAll();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RackAll")]
    public async Task<ActionResult> GetRackAll(int id)
    {
        var result = await _areaService.GetRackAll(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }


    [HttpPost]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> Create([FromBody] AreaCreateModel model)
    {
        var result = await _areaService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> Update([FromBody] AreaUpdateModel model)
    {
        var result = await _areaService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _areaService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
