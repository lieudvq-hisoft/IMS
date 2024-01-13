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
public class ComponentController : ControllerBase
{
    private readonly IComponentService _componentService;

    public ComponentController(IComponentService componentService)
    {
        _componentService = componentService;
    }

    [HttpGet("All")]
    public async Task<ActionResult> GetAll()
    {
        var result = await _componentService.GetAll();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
