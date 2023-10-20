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
public class ColocationController : ControllerBase
{
    private readonly IColocationService _colocationService;

    public ColocationController(IColocationService colocationService)
    {
        _colocationService = colocationService;
    }


    [HttpGet]
    [SwaggerOperation(Summary = "Get ongoing or stopped colocations")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<ColocationSortCriteria> pagingParam, [FromQuery] ColocationSearchModel searchModel)
    {
        var result = await _colocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
