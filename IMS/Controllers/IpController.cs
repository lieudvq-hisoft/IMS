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
public class IpController : ControllerBase
{
    private readonly IIpService _ipService;

    public IpController(IIpService ipService)
    {
        _ipService = ipService;
    }

    [HttpGet("IpAssignment")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Get ip assignments list")]
    public async Task<ActionResult> Get([FromQuery] IpAssignmentSearchModel searchModel)
    {
        var result = await _ipService.Get(searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
