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
    private readonly IWebHostEnvironment _environment;
    private readonly IFileService _fileService;

    public RequestUpgradeController(IRequestUpgradeService requestUpgradeService, IWebHostEnvironment environment, IFileService fileService)
    {
        this._requestUpgradeService = requestUpgradeService;
        _environment = environment;
        _fileService = fileService;
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
    [SwaggerOperation(Summary = "Create new request upgrade, state is waiting")]
    public async Task<ActionResult> Create([FromBody] RequestUpgradeCreateModel model)
    {
        var result = await _requestUpgradeService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Bulk")]
    [SwaggerOperation(Summary = "Create many request upgrade for server, state is accepted")]
    public async Task<ActionResult> CreateBulk([FromBody] RequestUpgradeCreateBulkModel model)
    {
        var result = await _requestUpgradeService.CreateBulk(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] RequestUpgradeUpdateModel model)
    {
        var result = await _requestUpgradeService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestUpgradeService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    public async Task<ActionResult> Reject(int id, RequestUpgradeRejectModel model)
    {
        var result = await _requestUpgradeService.Reject(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [SwaggerOperation(Summary = "Accept a waiting request upgrade")]
    public async Task<ActionResult> Accept(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestUpgradeService.Accept(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("Accept/Bulk")]
    //[SwaggerOperation(Summary = "Accept many waiting request upgrade")]
    //public async Task<ActionResult> AcceptBulk(RequestUpgradeEvaluateBulkModel model)
    //{
    //    var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
    //    var result = await _requestUpgradeService.EvaluateBulk(model, RequestStatus.Accepted, new Guid(userId));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting request upgrade")]
    public async Task<ActionResult> Deny(int id, [FromBody] DenyModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestUpgradeService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("Deny/Bulk")]
    //[SwaggerOperation(Summary = "Deny many waiting request upgrade")]
    //public async Task<ActionResult> DenyBulk(RequestUpgradeEvaluateBulkModel model)
    //{
    //    var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
    //    var result = await _requestUpgradeService.EvaluateBulk(model, RequestStatus.Denied, new Guid(userId));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpGet("{id}/Completability")]
    [SwaggerOperation(Summary = "True if any appointment success and have inspection record")]
    public async Task<ActionResult> GetCompletability(int id)
    {
        var result = await _requestUpgradeService.CheckCompletability(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Complete")]
    [SwaggerOperation(Summary = "Complete a completable accepted request upgrade. Change serverHardwareconfig")]
    public async Task<ActionResult> Complete(int id)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestUpgradeService.Complete(id, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("Complete/Bulk")]
    [SwaggerOperation(Summary = "Complete many completable accepted request upgrade. Change serverHardwareconfig")]
    public async Task<ActionResult> CompleteBulk(RequestUpgradeCompleteBulkModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestUpgradeService.CompleteBulk(model, new Guid(userId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
