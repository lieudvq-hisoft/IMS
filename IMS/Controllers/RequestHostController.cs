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
public class RequestHostController : ControllerBase
{
    private readonly IRequestHostService _requestHostService;
    private readonly IWebHostEnvironment _environment;

    public RequestHostController(IRequestHostService requestHostService, IWebHostEnvironment environment)
    {
        this._requestHostService = requestHostService;
        _environment = environment;
    }

    [HttpPut("{id}/Accept")]
    [SwaggerOperation(Summary = "Accept a waiting request host")]
    public async Task<ActionResult> Accept(int id, [FromBody] UserAssignModel model)
    {
        var result = await _requestHostService.Evaluate(id, RequestStatus.Accepted, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Accept/Bulk")]
    [SwaggerOperation(Summary = "Accept many waiting request host")]
    public async Task<ActionResult> AcceptBulk(RequestHostEvaluateBulkModel model)
    {
        var result = await _requestHostService.EvaluateBulk(model, RequestStatus.Accepted);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting request host")]
    public async Task<ActionResult> Deny(int id, [FromBody] UserAssignModel model)
    {
        var result = await _requestHostService.Evaluate(id, RequestStatus.Denied, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Deny/Bulk")]
    [SwaggerOperation(Summary = "Deny many waiting request host")]
    public async Task<ActionResult> DenyBulk(RequestHostEvaluateBulkModel model)
    {
        var result = await _requestHostService.EvaluateBulk(model, RequestStatus.Denied);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
