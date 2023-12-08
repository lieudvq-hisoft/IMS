//using Data.Common.PaginationModel;
//using Data.Enums;
//using Data.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Services.Core.NotUsed;

//namespace IMS.Controllers.NotUsed;

//[Route("api/[controller]")]
//[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
//public class RequestUpgradeAppointmentController : ControllerBase
//{
//    private readonly IRequestUpgradeAppointmentService _RequestUpgradeAppointmentService;

//    public RequestUpgradeAppointmentController(IRequestUpgradeAppointmentService RequestUpgradeAppointmentService)
//    {
//        _RequestUpgradeAppointmentService = RequestUpgradeAppointmentService;
//    }

//    [HttpGet]
//    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestUpgradeAppointmentSearchModel searchModel)
//    {
//        var result = await _RequestUpgradeAppointmentService.Get(pagingParam, searchModel);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult> GetDetail(int id)
//    {
//        var result = await _RequestUpgradeAppointmentService.GetDetail(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpDelete("{id}")]
//    public async Task<ActionResult> Delete(int id)
//    {
//        var result = await _RequestUpgradeAppointmentService.Delete(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }
//}
