using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class StatisticController : ControllerBase
{
    private readonly IStatisticService _statisticService;

    public StatisticController(IStatisticService statisticService)
    {
        _statisticService = statisticService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] StatisticSearchModel model)
    {
        var result = await _statisticService.GetRequest(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("ByMonth")]
    //public async Task<ActionResult> Get([FromQuery] StatisticSearchByTimeModel model)
    //{
    //    var result = await _statisticService.GetRequestByMonth(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("ByYear")]
    //public async Task<ActionResult> GetByYear([FromQuery] StatisticSearchByTimeModel model)
    //{
    //    var result = await _statisticService.GetRequestByYear(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}
}
