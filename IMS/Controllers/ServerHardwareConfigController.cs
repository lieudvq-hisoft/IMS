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
public class ServerHardwareConfigController : ControllerBase
{
    private readonly IServerHardwareConfigService _serverHardwareConfigService;

    public ServerHardwareConfigController(IServerHardwareConfigService serverHardwareConfigService)
    {
        _serverHardwareConfigService = serverHardwareConfigService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<ServerHardwareConfigSortCriteria> paginationModel, [FromQuery] ServerHardwareConfigSearchModel searchModel)
    {
        var result = await _serverHardwareConfigService.Get(paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _serverHardwareConfigService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] ServerHardwareConfigCreateModel model)
    {
        var result = await _serverHardwareConfigService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPost("Bulk")]
    //public async Task<ActionResult> CreateBulk([FromBody] ServerHardwareConfigCreateBulkModel model)
    //{
    //    var result = await _serverHardwareConfigService.CreateBulk(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ServerHardwareConfigUpdateModel model)
    {
        var result = await _serverHardwareConfigService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _serverHardwareConfigService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
