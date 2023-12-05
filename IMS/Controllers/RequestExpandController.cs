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
public class RequestExpandController : ControllerBase
{
    private readonly IRequestExpandService _requestExpandService;

    public RequestExpandController(IRequestExpandService requestExpandService)
    {
        _requestExpandService = requestExpandService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestExpandSearchModel searchModel)
    {
        var result = await _requestExpandService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _requestExpandService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Appointment")]
    public async Task<ActionResult> GetAppointment(int id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentSearchModel searchModel)
    {
        var result = await _requestExpandService.GetAppointment(id, pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [Authorize(Roles = "Customer")]
    [SwaggerOperation(Summary = "[Customer]")]
    public async Task<ActionResult> Create([FromBody] RequestExpandCreateModel model)
    {
        var result = await _requestExpandService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    [Authorize(Roles = "Customer," + nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "[Customer, Tech, Sale]")]
    public async Task<ActionResult> Update([FromBody] RequestExpandUpdateModel model)
    {
        var result = await _requestExpandService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Customer")]
    [SwaggerOperation(Summary = "[Customer]")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestExpandService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]")]
    public async Task<ActionResult> Reject(int id, RequestExpandRejectModel model)
    {
        var result = await _requestExpandService.Reject(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "[Sale]: Accept a waiting request expand")]
    public async Task<ActionResult> Accept(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Accept(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "[Sale]: Deny a waiting request expand")]
    public async Task<ActionResult> Deny(int id, [FromBody] DenyModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}/RequestExpandLocation")]
    [Authorize(Roles = "Customer")]
    [SwaggerOperation(Summary = "[Customer]")]
    public async Task<ActionResult> DeleteRequestExpandLocation(int id)
    {
        var result = await _requestExpandService.DeleteRequestExpandLocation(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("Removal/{id}")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]")]
    public async Task<ActionResult> FailRequestRemoval(int id)
    {
        var result = await _requestExpandService.FailRemoval(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/RequestExpandLocation")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]")]
    public async Task<ActionResult> AssignRequestExpandLocation(int id, RequestExpandAssignLocationModel model)
    {
        var result = await _requestExpandService.AssignLocation(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Complete")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Complete a completable accepted request expand")]
    public async Task<ActionResult> Complete(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Complete(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Complete/Bulk")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]: Complete many completable accepted request expand")]
    public async Task<ActionResult> CompleteBulk(RequestExpandCompleteBulkModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.CompleteBulk(model, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Removal/{id}/Complete")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]")]
    public async Task<ActionResult> CompleteRemoval(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.CompleteRemoval(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("CompleteRemoval/Bulk")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    [SwaggerOperation(Summary = "[Tech]")]
    public async Task<ActionResult> CompleteRemovalBulk(RequestExpandCompleteBulkModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.CompleteRemovalBulk(model, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/ChosenLocation")]
    public async Task<ActionResult> GetChosenLocation(int id)
    {
        var result = await _requestExpandService.GetChosenLocation(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/SuggestLocation")]
    [SwaggerOperation(Summary = "Suggest location for request expand")]
    public async Task<ActionResult> Suggest(int id)
    {
        var result = await _requestExpandService.GetRackChoiceSuggestionBySize(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
