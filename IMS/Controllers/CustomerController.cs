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
    public async Task<ActionResult> Get([FromQuery] PagingParam<CustomerSortCriteria> pagingParam, [FromQuery] CustomerSearchModel searchModel)
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
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Create a customer and associate user")]
    public async Task<ActionResult> Create([FromBody] CustomerCreateModel model)
    {
        var result = await _customerService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Update a customer")]
    public async Task<ActionResult> Update([FromBody] CustomerUpdateModel model)
    {
        var result = await _customerService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Delete a customer")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _customerService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Email")]
    [AllowAnonymous]
    public async Task<ActionResult> Email()
    {
        await _customerService.SendActivationEmail(new List<int>());
        return Ok();
    }
}
