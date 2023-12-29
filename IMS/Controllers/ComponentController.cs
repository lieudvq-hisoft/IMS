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

    //[HttpGet]
    //public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] ComponentSearchModel searchModel)
    //{
    //    var result = await _componentService.Get(paginationModel, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}")]
    //public async Task<ActionResult> GetDetail(int id)
    //{
    //    var result = await _componentService.GetDetail(id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpGet("All")]
    public async Task<ActionResult> GetAll()
    {
        var result = await _componentService.GetAll();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPost]
    //public async Task<ActionResult> Create([FromBody] ComponentCreateModel model)
    //{
    //    var result = await _componentService.Create(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpPut]
    //public async Task<ActionResult> Update([FromBody] ComponentUpdateModel model)
    //{
    //    var result = await _componentService.Update(model);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpDelete("{id}")]
    //public async Task<ActionResult> Delete(int id)
    //{
    //    var result = await _componentService.Delete(id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/ServerHardwareConfig")]
    //public async Task<ActionResult> GetServerHardwareConfig([FromQuery] PagingParam<BaseSortCriteria> paginationModel, int id)
    //{
    //    var result = await _componentService.GetServerHardwareConfig(paginationModel, id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/RequestUpgrade")]
    //public async Task<ActionResult> GetRequestUpgrade([FromQuery] PagingParam<BaseSortCriteria> paginationModel, int id)
    //{
    //    var result = await _componentService.GetRequestUpgrade(paginationModel, id);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}
}
