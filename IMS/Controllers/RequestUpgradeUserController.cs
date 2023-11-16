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
public class RequestUpgradeUserController : ControllerBase
{
    private readonly IRequestUpgradeUserService _requestUpgradeUserService;

    public RequestUpgradeUserController(IRequestUpgradeUserService requestUpgradeUserService)
    {
        _requestUpgradeUserService = requestUpgradeUserService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get all Request Upgrade Users")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestUpgradeUserSearchModel searchModel)
    {
        var result = await _requestUpgradeUserService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _requestUpgradeUserService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
