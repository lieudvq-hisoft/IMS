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

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _requestExpandService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
