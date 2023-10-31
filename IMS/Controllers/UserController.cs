using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    //[Authorize(Roles = nameof(RoleType.Admin))]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "[Admin]: Register a new user, cannot register a customer")]
    public async Task<ActionResult> Register([FromBody] UserCreateModel model)
    {
        var result = await _userService.Register(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Activate/{email}")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Activate a user")]
    public async Task<ActionResult> Activate(string email)
    {
        var result = await _userService.ActivateUser(email);
        if (result.Succeed)
            return Redirect("https://ims.hisoft.vn/signin");
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("MyAccount")]
    [SwaggerOperation(Summary = "Get your information")]
    public async Task<ActionResult> GetAccountInfo()
    {
        var email = User.Claims.FirstOrDefault(x => x.Type == "Email").Value;
        var result = await _userService.GetAccountInfo(email);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch("MyAccount")]
    [SwaggerOperation(Summary = "Update your information")]
    public async Task<ActionResult> UpdateAccountInfo([FromBody] UserUpdateModel model)
    {
        var result = await _userService.UpdateAccountInfo(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
