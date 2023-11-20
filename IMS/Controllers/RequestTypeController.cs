using Data.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class RequestTypeController: ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult> Get()
    {
        return Ok(Enum.GetNames(typeof(RequestType)).ToList());
    }
}
