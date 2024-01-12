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
public class RequestHostController : ControllerBase
{
    private readonly IRequestHostService _requestHostService;

    public RequestHostController(IRequestHostService requestHostService)
    {
        _requestHostService = requestHostService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestHostSearchModel searchModel)
    {
        var result = await _requestHostService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _requestHostService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("{id}/IpAddress")]
    //public async Task<ActionResult> GetAssignedIp(int id, [FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] IpAddressSearchModel searchModel)
    //{
    //    var result = await _requestHostService.GetIpAddress(id, paginationModel, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost]
    public async Task<ActionResult> Create([FromForm] RequestHostCreateModel model)
    {
        var result = await _requestHostService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("PortUpgrade")]
    public async Task<ActionResult> CreatePortUpgrade([FromBody] RequestHostCreateUpgradeModel model)
    {
        var result = await _requestHostService.CreatePortUpgrade(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] RequestHostUpdateModel model)
    {
        var result = await _requestHostService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("PortUpgrade")]
    public async Task<ActionResult> UpdatePortUpgrade([FromBody] RequestHostUpdateUpgradeModel model)
    {
        var result = await _requestHostService.UpdatePortUpgrade(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestHostService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/IpAddress")]
    public async Task<ActionResult> AssignIp(int id, [FromBody] RequestHostIpAssignmentModel model)
    {
        var result = await _requestHostService.AssignAdditionalIp(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Accept")]
    [SwaggerOperation(Summary = "Accept a waiting request host")]
    public async Task<ActionResult> Accept(int id, [FromBody] EvaluateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestHostService.Accept(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("Accept/Bulk")]
    //[SwaggerOperation(Summary = "Accept many waiting request host")]
    //public async Task<ActionResult> AcceptBulk(RequestHostEvaluateBulkModel model)
    //{
    //    var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
    //    var result = await _requestHostService.EvaluateBulk(model, RequestHostStatus.Accepted, new Guid(userId));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut("{id}/Deny")]
    [SwaggerOperation(Summary = "Deny a waiting request host")]
    public async Task<ActionResult> Deny(int id, [FromBody] EvaluateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestHostService.Deny(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("Deny/Bulk")]
    //[SwaggerOperation(Summary = "Deny many waiting request host")]
    //public async Task<ActionResult> DenyBulk(RequestHostEvaluateBulkModel model)
    //{
    //    var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
    //    var result = await _requestHostService.EvaluateBulk(model, RequestHostStatus.Denied, new Guid(userId));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost("{id}/Document")]
    public async Task<ActionResult> UploadDocument(int id, [FromForm] RequestHostDocumentFileUploadModel model)
    {
        var result = await _requestHostService.AssignInspectionReport(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPut("{id}/Process")]
    //public async Task<ActionResult> Process(int id)
    //{
    //    var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
    //    var result = await _requestHostService.Process(id, new Guid(userId));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPut("{id}/Complete")]
    public async Task<ActionResult> Complete(int id, [FromBody] HostAndUpgradeCreateInspectionReportModel? model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestHostService.Complete(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/CompletePortUpgrade")]
    public async Task<ActionResult> CompletePortUpgrade(int id, [FromBody] HostAndUpgradeCreateInspectionReportModel? model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _requestHostService.CompletePortUpgrade(id, new Guid(userId), model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    public async Task<ActionResult> Reject(int id, RequestHostRejectModel model)
    {
        var result = await _requestHostService.Reject(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/DocumentConfirmation/True")]
    public async Task<ActionResult> DocumentConfirmationTrue(int id)
    {
        var result = await _requestHostService.DocumentConfirmTrue(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
