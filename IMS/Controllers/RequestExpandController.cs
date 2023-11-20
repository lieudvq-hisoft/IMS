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

    public RequestExpandController(IRequestExpandService requestExpandService, IWebHostEnvironment environment)
    {
        _requestExpandService = requestExpandService;
        _environment = environment;
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

    [HttpGet("{id}/RequestExpandLocation")]
    public async Task<ActionResult> GetRequestExpandLocation(int id)
    {
        var result = await _requestExpandService.GetRequestExpandLocation(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] RequestExpandCreateModel model)
    {
        var result = await _requestExpandService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

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

    [HttpPut("{id}/Accept")]
    [SwaggerOperation(Summary = "Accept a waiting request expand")]
    public async Task<ActionResult> Accept(int id, [FromBody] UserAssignModel model)
    {
        var result = await _requestExpandService.Evaluate(id, RequestStatus.Accepted, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting request expand")]
    public async Task<ActionResult> Deny(int id, [FromBody] UserAssignModel model)
    {
        var result = await _requestExpandService.Evaluate(id, RequestStatus.Denied, model);
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

    [HttpPost("{id}/RequestExpandLocation")]
    public async Task<ActionResult> AssignRequestExpandLocation(int id, RequestExpandAssignLocationModel model)
    {
        var result = await _requestExpandService.AssignLocation(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Completability")]
    [SwaggerOperation(Summary = "True if any appointment success and have inspection record")]
    public async Task<ActionResult> GetCompletability(int id)
    {
        var result = await _requestExpandService.CheckCompletability(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Complete")]
    [SwaggerOperation(Summary = "Complete a completable accepted request expand")]
    public async Task<ActionResult> Complete(int id)
    {
        var result = await _requestExpandService.Complete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/InspectionReport")]
    public async Task<ActionResult> DownloadInspectionReport(int id)
    {
        var result = await _requestExpandService.GetInspectionReport(id);
        string folderPath = Path.Combine(_environment.WebRootPath, "InspectionReport");
        if (result.Succeed)
        {
            string filePath = Path.Combine(folderPath, result.Data as string);
            return File(System.IO.File.OpenRead(filePath), "application/pdf", "InspectionReport.pdf");
        }
    }

    [HttpPut("SuggestLocation")]
    [SwaggerOperation(Summary = "Suggest location for request expand")]
    public async Task<ActionResult> Suggest(RequestExpandSuggestLocationModel model)
    {
        var result = await _requestExpandService.GetRackChoiceSuggestionBySize(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
