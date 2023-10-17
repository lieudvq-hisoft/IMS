using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
[AllowAnonymous]
public class CompanyTypeController: ControllerBase
{
    private readonly ICompanyTypeService _companyTypeService;

    public CompanyTypeController(ICompanyTypeService companyTypeService)
    {
        _companyTypeService = companyTypeService;
    }

    [SwaggerOperation(Summary = "Get all company type")]
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _companyTypeService.Get();
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
