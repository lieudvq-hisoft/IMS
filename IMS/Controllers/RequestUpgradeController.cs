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

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] RequestUpgradeCreateModel model)
    {
        var result = await _requestUpgradeService.Create(model);
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

    [HttpPut("{id}/Accept")]
    public async Task<ActionResult> Accept(int id, [FromBody] Guid userId)
    {
        var result = await _requestUpgradeService.Evaluate(id, RequestStatus.Accepted, userId);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Deny")]
    public async Task<ActionResult> Deny(int id, [FromBody] Guid userId)
    {
        var result = await _requestUpgradeService.Evaluate(id, RequestStatus.Denied, userId);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Reject")]
    public async Task<ActionResult> Reject(int id)
    {
        var result = await _requestUpgradeService.Reject(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Completability")]
    public async Task<ActionResult> GetCompletability(int id)
    {
        var result = await _requestUpgradeService.CheckCompletability(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut("{id}/Complete")]
    public async Task<ActionResult> Complete(int id)
    {
        var result = await _requestUpgradeService.Complete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/InspectionReport")]
    public async Task<ActionResult> DownloadInspectionReport(int id)
    {
        var result = await _requestUpgradeService.GetInspectionReport(id);
        string folderPath = Path.Combine(_environment.WebRootPath, "RequestUpgrade");
        if (result.Succeed)
        {
            string filePath = Path.Combine(folderPath, result.Data as string);
            return File(System.IO.File.OpenRead(filePath), "application/pdf", "InspectionReport.pdf");
        }
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/InspectionReport")]
    public async Task<ActionResult> UploadInspectionReport(int id, [FromForm] DocumentFileUploadModel model)
    {
        string folderPath = Path.Combine(_environment.WebRootPath, "RequestUpgrade");
        string fileName = await _fileService.SaveFileWithGuidName(model.File, folderPath);
        var result = await _requestUpgradeService.AssignInspectionReport(id, fileName);
        if (!result.Succeed)
        {
            await _fileService.DeleteFile(fileName);
            return BadRequest(result.ErrorMessage);
        }

        return Ok(fileName);
    }
}
