﻿using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ClaimExtensions;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace UserController.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Login")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Login")]
    public async Task<ActionResult> Login([FromBody] LoginModel model)
    {
        var result = await _userService.Login(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Register")]
    [Authorize(Roles = nameof(RoleType.Admin))]
    [SwaggerOperation(Summary = "[Admin]: Register a new user, cannot register a customer")]
    public async Task<ActionResult> Register([FromBody] UserCreateModel model)
    {
        var result = await _userService.Register(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("MyAccount")]
    [Authorize(Roles = nameof(RoleType.Admin) + "," + nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Get your information")]
    public async Task<ActionResult> GetAccountInfo()
    {
        var email = User.Claims.FirstOrDefault(x => x.Type == "Email").Value;
        var result = await _userService.GetAccountInfo(email);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch("MyAccount")]
    [Authorize(Roles = nameof(RoleType.Admin) + "," + nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Update your information")]
    public async Task<ActionResult> UpdateAccountInfo([FromBody] UserUpdateModel model)
    {
        var result = await _userService.UpdateAccountInfo(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpPost("Position")]
    //public async Task<ActionResult> AssignRole([FromBody] UserAssignRoleModel model)
    //{
    //    var result = await _userService.AssignRole(model, new Guid(User.GetId()));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpDelete("Position")]
    //public async Task<ActionResult> UnassignRole([FromBody] UserAssignRoleModel model)
    //{
    //    var result = await _userService.UnassignRole(model, new Guid(User.GetId()));
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpGet]
    [SwaggerOperation(Summary = "Get list of users")]
    [Authorize(Roles = nameof(RoleType.Admin) + "," + nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] UserSearchModel searchModel)
    {
        var result = await _userService.Get(paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Tech")]
    [SwaggerOperation(Summary = "Get list of users")]
    [Authorize(Roles = nameof(RoleType.Admin) + "," + nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    public async Task<ActionResult> GetTech([FromQuery] PagingParam<BaseSortCriteria> paginationModel, [FromQuery] UserSearchModel searchModel)
    {
        var result = await _userService.GetTech(paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    [Authorize(Roles = nameof(RoleType.Admin) + "," + nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    public async Task<ActionResult> GetDetail(string id)
    {
        var result = await _userService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    //[HttpGet("{id}/AssignedRequestExpand")]
    //public async Task<ActionResult> GetAssignedRequestExpand(string id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestExpandSearchModel searchModel)
    //{
    //    var result = await _userService.GetAssignedRequestExpand(id, pagingParam, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/AssignedRequestUpgrade")]
    //public async Task<ActionResult> GetAssignedRequestUpgrade(string id, [FromQuery] PagingParam<RequestUpgradeSortCriteria> paginationModel, [FromQuery] RequestUpgradeSearchModel searchModel)
    //{
    //    var result = await _userService.GetAssignedRequestUpgrade(id, paginationModel, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/AssignedRequestHost")]
    //public async Task<ActionResult> GetAssignedRequestHost(string id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestHostSearchModel searchModel)
    //{
    //    var result = await _userService.GetAssignedRequestHost(id, pagingParam, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    //[HttpGet("{id}/AssignedIncident")]
    //public async Task<ActionResult> GetAssignedIncident(string id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] IncidentSearchModel searchModel)
    //{
    //    var result = await _userService.GetIncident(Guid.Parse(id), pagingParam, searchModel);
    //    if (result.Succeed) return Ok(result.Data);
    //    return BadRequest(result.ErrorMessage);
    //}

    [HttpPost("FcmToken")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> BindFcmToken([FromBody] BindFcmtokenModel model)
    {
        var rs = await _userService.BindFcmtoken(model, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpDelete("FcmToken")]
    public async Task<IActionResult> DeleteFcmToken([FromBody] DeleteFcmtokenModel model)
    {
        var rs = await _userService.DeleteFcmToken(model.FcmToken, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpPost("SeenCurrenNoticeCount")]
    public async Task<ActionResult> SeenCurrenNoticeCount()
    {
        var result = await _userService.SeenCurrenNoticeCount(Guid.Parse(User.GetId()));
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
