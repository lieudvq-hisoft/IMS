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
public class RequestController : ControllerBase
{
    private readonly IRequestService _serviceService;

    public RequestController(IRequestService serviceService)
    {
        _serviceService = serviceService;
    }

    //[HttpGet]
    //[SwaggerOperation(Summary = "Get services")]
    //public async Task<ActionResult> Get()
    //{
    //    var result = await _serviceService.Get();
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPost]
    //[SwaggerOperation(Summary = "Create services")]
    //public async Task<ActionResult> Post([FromBody] RequestCreateModel model)
    //{
    //    var result = await _serviceService.Create(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPatch]
    //[SwaggerOperation(Summary = "Update a service")]
    //public async Task<ActionResult> Update([FromBody] ServiceUpdateModel model)
    //{
    //    var result = await _serviceService.Update(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "Delete a service")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _serviceService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
