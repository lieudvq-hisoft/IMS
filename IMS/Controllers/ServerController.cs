using Data.Common.PaginationModel;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
[AllowAnonymous]
public class ServerController: ControllerBase
{
    private readonly IServerService _serverService;
    public ServerController(IServerService serverService)
    {
        _serverService = serverService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get server list")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<ServerSortCriteria> pagingParam, [FromQuery] ServerSearchModel searchModel)
    {
        var result = await _serverService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
