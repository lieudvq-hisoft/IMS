using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ClaimExtensions;
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
    public async Task<ActionResult> GetDetail(string id)
    {
        var result = await _customerService.GetDetail(new Guid(id));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("{id}/ServerAllocation")]
    //public async Task<ActionResult> GetServerAllocation([FromQuery] PagingParam<BaseSortCriteria> pagingParam, string id)
    //{
    //    var result = await _customerService.GetServerAllocation(pagingParam, new Guid(id));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/Appointment")]
    //public async Task<ActionResult> GetAppointment(string id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] AppointmentSearchModel searchModel)
    //{
    //    var result = await _customerService.GetAppointment(new Guid(id), pagingParam, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost]
    [SwaggerOperation(Summary = "Create a customer and associate user")]
    public async Task<ActionResult> Create([FromBody] CustomerCreateModel model)
    {
        var userId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _customerService.Create(model, new Guid(userId));
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

    [HttpPut("Password")]
    [Authorize(Roles = "Customer")]
    public async Task<ActionResult> ChangePassword([FromBody] CustomerChangePasswordModel model)
    {
        var customerId = User.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
        var result = await _customerService.ChangePassword(model, new Guid(customerId));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(Summary = "[Sale]: Delete a customer")]
    public async Task<ActionResult> Delete(string id)
    {
        var result = await _customerService.Delete(new Guid(id));
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

    [HttpPost("FcmToken")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> BindFcmToken([FromBody] BindFcmtokenModel model)
    {
        var rs = await _customerService.BindFcmtoken(model, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpDelete("FcmToken")]
    public async Task<IActionResult> DeleteFcmToken([FromBody] DeleteFcmtokenModel model)
    {
        var rs = await _customerService.DeleteFcmToken(model.FcmToken, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpPost("SeenCurrenNoticeCount")]
    public async Task<ActionResult> SeenCurrenNoticeCount()
    {
        var result = await _customerService.SeenCurrenNoticeCount(Guid.Parse(User.GetId()));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
