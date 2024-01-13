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
public class RequestUpgradeController : ControllerBase
{
    private readonly IRequestUpgradeService _requestUpgradeService;

    public RequestUpgradeController(IRequestUpgradeService requestUpgradeService)
    {
        _requestUpgradeService = requestUpgradeService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<RequestUpgradeSortCriteria> paginationModel, [FromQuery] RequestUpgradeSearchModel searchModel)
    {
        var result = await _requestUpgradeService.Get(paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _requestUpgradeService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Appointment")]
    public async Task<ActionResult> GetAppointment(int id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentSearchModel searchModel)
    {
        var result = await _requestUpgradeService.GetAppointment(id, pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [Authorize(Roles = nameof(RoleType.Customer))]
    [SwaggerOperation(Summary = "Create new request upgrade, state is waiting")]
    public async Task<ActionResult> Create([FromBody] RequestUpgradeCreateModel model)
    {
        var result = await _requestUpgradeService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Update([FromBody] RequestUpgradeUpdateModel model)
    {
        var result = await _requestUpgradeService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestUpgradeService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> Reject(int id, RequestUpgradeRejectModel model)
    {
        var result = await _requestUpgradeService.Reject(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Accept a waiting request upgrade")]
    public async Task<ActionResult> Accept(int id, [FromBody] EvaluateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestUpgradeService.Accept(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Deny a waiting request upgrade")]
    public async Task<ActionResult> Deny(int id, [FromBody] EvaluateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestUpgradeService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
