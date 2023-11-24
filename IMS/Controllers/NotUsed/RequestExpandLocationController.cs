//using Data.Common.PaginationModel;
//using Data.Enums;
//using Data.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace IMS.Controllers.NotUsed;

//[Route("api/[controller]")]
//[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
//public class RequestExpandLocationController : ControllerBase
//{
//    private readonly IRequestExpandLocationService _requestExpandLocationService;

//    public RequestExpandLocationController(IRequestExpandLocationService requestExpandLocationService)
//    {
//        _requestExpandLocationService = requestExpandLocationService;
//    }

//    [HttpGet]
//    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestExpandLocationSearchModel searchModel)
//    {
//        var result = await _requestExpandLocationService.Get(pagingParam, searchModel);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult> GetDetail(int id)
//    {
//        var result = await _requestExpandLocationService.GetDetail(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }
//}
