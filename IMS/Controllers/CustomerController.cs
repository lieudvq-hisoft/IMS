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
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get all customer")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] CustomerSearchModel searchModel)
    {
        var result = await _customerService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(Summary = "Get detail information of a customer")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var result = await _customerService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    [SwaggerOperation(Summary = "[Sale]: Create a customer and associate user")]
    public async Task<ActionResult> Create([FromBody] CustomerCreateModel model)
    {
        var result = await _customerService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    [SwaggerOperation(Summary = "[Sale]: Update a customer")]
    public async Task<ActionResult> Update([FromBody] CustomerUpdateModel model)
    {
        var result = await _customerService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "[Sale]: Delete a customer")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _customerService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Login")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Login")]
    public async Task<ActionResult> Login([FromBody] CustomerLoginModel model)
    {
        var result = await _customerService.Login(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
