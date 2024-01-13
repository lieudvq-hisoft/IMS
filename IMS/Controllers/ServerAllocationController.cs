using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ClaimExtensions;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class ServerAllocationController : ControllerBase
{
    private readonly IServerAllocationService _serverAllocationService;

    public ServerAllocationController(IServerAllocationService serverAllocationService)
    {
        _serverAllocationService = serverAllocationService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get requests, excluding ongoing or stopped requests, and those with unsuccessful additional services")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] ServerAllocationSearchModel searchModel)
    {
        var result = await _serverAllocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail([FromRoute] int id)
    {
        var result = await _serverAllocationService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Create([FromBody] ServerAllocationCreateModel model)
    {
        var result = await _serverAllocationService.Create(model, new Guid
            (User.GetId()));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    [Authorize(Roles = nameof(RoleType.Customer) + "," + nameof(RoleType.Tech))]
    public async Task<ActionResult> Update([FromBody] ServerAllocationUpdateModel model)
    {
        var result = await _serverAllocationService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Confirm")]
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Confirm(int id)
    {
        var result = await _serverAllocationService.Confirm(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/MasterIp")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> AssignMasterIp(int id, [FromBody] ServerAllocationMasterIpAssignmentModel model)
    {
        var result = await _serverAllocationService.AssignMasterIp(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/Document")]
    public async Task<ActionResult> UploadInspectionRecordAndReceiptOfRecipientReport(int id, [FromForm] DocumentFileUploadModel model)
    {
        var result = await _serverAllocationService.AssignInspectionRecordAndReceiptOfRecipientReport(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
