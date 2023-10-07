using Data.Common.PaginationModel;
using Data.Enums;
using Data.Model;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Services.Core;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<CustomerSortCriteria> pagingParam, [FromQuery] CustomerSearchModel searchModel)
    {
        var result = await _customerService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("bulk")]
    public async Task<ActionResult> Import()
    {
        var result = await _customerService.Import("Test_Excel.xlsx");
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromForm] CustomerCreateModel model)
    {
        var result = await _customerService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _customerService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [AllowAnonymous]
    [HttpPatch]
    public async Task<ActionResult> Update([FromForm] CustomerUpdateModel model)
    {
        var result = await _customerService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
