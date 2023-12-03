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

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] IpSubnetSearchModel searchModel)
    {
        var result = await _ipSubnetService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("IpRange")]
    public async Task<ActionResult> GetIpRange([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] IpSubnetSearchModel searchModel)
    {
        var result = await _ipSubnetService.GetIpRange(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
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

    [HttpGet("{id}/IpAddress")]
    public async Task<ActionResult> GetIpAddress(int id, [FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] IpAddressSearchModel searchModel)
    {
        var result = await _ipSubnetService.GetIpAddress(id, paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Tree")]
    public async Task<ActionResult> GetIpSubnetTree()
    {
        var result = await _ipSubnetService.GetIpSubnetTree();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("NextAddress")]
    public async Task<ActionResult> GetNextAddress([FromQuery] NextAddressModel model)
    {
        var result = await _ipSubnetService.GetNextAddress(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> CreateIpRange([FromBody] IpRangeCreateModel model)
    {
        var result = await _ipSubnetService.CreateIpRange(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/Subnet")]
    public async Task<ActionResult> CreateIpSubnet(int id, [FromBody] CreateSubnetModel model)
    {
        var result = await _ipSubnetService.Create(id, model.IpSubnets);
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
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _ipSubnetService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}