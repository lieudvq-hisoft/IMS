//using Data.Common.PaginationModel;
//using Data.Enums;
//using Data.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace IMS.Controllers.NotUsed;

//[Route("api/[controller]")]
//[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
//public class RequestExpandAppointmentController : ControllerBase
//{
//    private readonly IRequestExpandAppointmentService _requestExpandAppointmentService;

//    public RequestExpandAppointmentController(IRequestExpandAppointmentService requestExpandAppointmentService)
//    {
//        _requestExpandAppointmentService = requestExpandAppointmentService;
//    }

//    [HttpGet]
//    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestExpandAppointmentSearchModel searchModel)
//    {
//        var result = await _requestExpandAppointmentService.Get(pagingParam, searchModel);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult> GetDetail(int id)
//    {
//        var result = await _requestExpandAppointmentService.GetDetail(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpPost]
//    public async Task<ActionResult> Create([FromBody] RequestExpandAppointmentCreateModel model)
//    {
//        var result = await _requestExpandAppointmentService.Create(model);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpDelete("{id}")]
//    public async Task<ActionResult> Delete(int id)
//    {
//        var result = await _requestExpandAppointmentService.Delete(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }
//}
