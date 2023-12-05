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
    private readonly IWebHostEnvironment _environment;
    private readonly IFileService _fileService;

    public RequestExpandController(IRequestExpandService requestExpandService, IWebHostEnvironment environment, IFileService fileService)
    {
        _requestExpandService = requestExpandService;
        _environment = environment;
        _fileService = fileService;
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

    //[HttpPost]
    //public async Task<ActionResult> Create([FromBody] RequestExpandCreateModel model)
    //{
    //    var result = await _requestExpandService.Create(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] RequestExpandUpdateModel model)
    {
        var result = await _requestExpandService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestExpandService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    public async Task<ActionResult> Reject(int id, RequestExpandRejectModel model)
    {
        var result = await _requestExpandService.Reject(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [SwaggerOperation(Summary = "Accept a waiting request expand")]
    public async Task<ActionResult> Accept(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Accept(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting request expand")]
    public async Task<ActionResult> Deny(int id, [FromBody] DenyModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}/RequestExpandLocation")]
    public async Task<ActionResult> DeleteRequestExpandLocation(int id)
    {
        var result = await _requestExpandService.DeleteRequestExpandLocation(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("Removal/{id}")]
    public async Task<ActionResult> FailRequestRemoval(int id)
    {
        var result = await _requestExpandService.FailRemoval(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/RequestExpandLocation")]
    public async Task<ActionResult> AssignRequestExpandLocation(int id, RequestExpandAssignLocationModel model)
    {
        var result = await _requestExpandService.AssignLocation(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Complete")]
    [SwaggerOperation(Summary = "Complete a completable accepted request expand")]
    public async Task<ActionResult> Complete(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.Complete(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Complete/Bulk")]
    [SwaggerOperation(Summary = "Complete many completable accepted request expand")]
    public async Task<ActionResult> CompleteBulk(RequestExpandCompleteBulkModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.CompleteBulk(model, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Removal/{id}/Complete")]
    public async Task<ActionResult> CompleteRemoval(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestExpandService.CompleteRemoval(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("CompleteRemoval/Bulk")]
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
