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
public class IpSubnetController : ControllerBase
{
    private readonly IIpSubnetService _ipSubnetService;

    public IpSubnetController(IIpSubnetService ipSubnetService)
    {
        _ipSubnetService = ipSubnetService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _ipSubnetService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/IpSubnet")]
    public async Task<ActionResult> GetSubnet(int id)
    {
        var result = await _ipSubnetService.GetIpSubnet(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Tree")]
    public async Task<ActionResult> GetIpSubnetTree()
    {
        var result = await _ipSubnetService.GetTree();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> CreateIpRange([FromBody] IpRangeCreateModel model)
    {
        var result = await _ipSubnetService.CreateIpRange(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("SuggestAdditional")]
    public async Task<ActionResult> SuggestAdditional([FromQuery] SuggestAdditionalIpModel model)
    {
        var result = await _ipSubnetService.SuggestAdditionalIps(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _ipSubnetService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}