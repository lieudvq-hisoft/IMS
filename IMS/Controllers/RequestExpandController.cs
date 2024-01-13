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
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Create([FromForm] RequestExpandCreateModel model)
    {
        var result = await _requestExpandService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Update([FromBody] RequestExpandUpdateModel model)
    {
        var result = await _requestExpandService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Customer))]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestExpandService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> Reject(int id, RequestExpandRejectModel model)
    {
        var result = await _requestExpandService.Reject(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Accept a waiting request expand")]
    public async Task<ActionResult> Accept(int id, [FromBody] EvaluateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Accept(id, Guid.Parse(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Deny a waiting request expand")]
    public async Task<ActionResult> Deny(int id, [FromBody] EvaluateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/RequestExpandLocation")]
    [Authorize(Roles = nameof(RoleType.Tech))]
    public async Task<ActionResult> AssignRequestExpandLocation(int id, RequestExpandAssignLocationModel model)
    {
        var result = await _requestExpandService.AssignLocation(id, model);
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
