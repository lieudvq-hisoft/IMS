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
public class ServiceController : ControllerBase
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get services")]
    public async Task<ActionResult> Get([FromQuery]PagingParam<ServiceSortCriteria> paginationModel)
    {
        var result = await _serviceService.Get(paginationModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create services")]
    public async Task<ActionResult> Post([FromBody] ServiceCreateModel model)
    {
        var result = await _serviceService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch]
    [SwaggerOperation(Summary = "Update a service")]
    public async Task<ActionResult> Update([FromBody] ServiceUpdateModel model)
    {
        var result = await _serviceService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "Delete a service")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _serviceService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
