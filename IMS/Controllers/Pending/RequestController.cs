//using Data.Common.PaginationModel;
//using Data.Enums;
//using Data.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Services.Core;

//namespace IMS.Controllers;
//[Route("api/[controller]")]
//[ApiController]
//[Authorize(AuthenticationSchemes = "Bearer")]
//public class RequestController : ControllerBase
//{
//    private readonly IRequestService _serviceService;

//    public RequestController(IRequestService serviceService)
//    {
//        _serviceService = serviceService;
//    }

//    [HttpGet]
//    public async Task<ActionResult> Get([FromQuery] PagingParam<RequestSortCriteria> paginationModel, [FromQuery] RequestSearchModel searchModel)
//    {
//        var result = await _serviceService.Get(paginationModel, searchModel);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    [HttpPost]
//    public async Task<ActionResult> Post([FromBody] RequestCreateModel model)
//    {
//        var result = await _serviceService.Create(model);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }

//    //[HttpPatch]
//    //[SwaggerOperation(Summary = "Update a service")]
//    //public async Task<ActionResult> Update([FromBody] ServiceUpdateModel model)
//    //{
//    //    var result = await _serviceService.Update(model);
//    //    if (result.Succeed) return Ok(result.Data);
//    //    return BadRequest(result.ErrorMessage);
//    //}

//    [HttpDelete("{id}")]
//    public async Task<ActionResult> Delete(int id)
//    {
//        var result = await _serviceService.Delete(id);
//        if (result.Succeed) return Ok(result.Data);
//        return BadRequest(result.ErrorMessage);
//    }
//}
