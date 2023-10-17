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
public class ColocationController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly IWebHostEnvironment _environment;
    private readonly IColocationService _colocationService;
    private readonly IFileService _fileService;
    private readonly IServerService _serverService;

    public ColocationController(ICustomerService customerService, IWebHostEnvironment environment, IColocationService colocationService, IFileService fileService, IServerService serverService)
    {
        _customerService = customerService;
        _environment = environment;
        _colocationService = colocationService;
        _fileService = fileService;
        _serverService = serverService;
    }


    [HttpGet]
    [Authorize(Roles = nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Get ongoing or stopped colocations")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<ColocationSortCriteria> pagingParam, [FromQuery] ColocationSearchModel searchModel)
    {
        var result = await _colocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Request")]
    [Authorize(Roles = nameof(RoleType.Tech) + "," + nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Get colocation requests, excluding ongoing or stopped colocations, and those with unsuccessful additional services")]
    public async Task<ActionResult> GetRequest([FromQuery] PagingParam<ColocationSortCriteria> pagingParam, [FromQuery] ColocationSearchModel searchModel)
    {
        var result = await _colocationService.GetRequest(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Request/Bulk")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Create user, customer and colocation request base on import excel. Create all 3 entity if success or nothing if any fail validation or have error when inserting. Return the result excel file with result on the right most column")]
    public async Task<ActionResult> Import(IFormFile importFile)
    {
        string domainName = HttpContext.Request.Host.Value;
        string folderPath = Path.Combine(_environment.WebRootPath, "import\\customer");
        string filePath = await _fileService.SaveFile(importFile, folderPath);
        await _customerService.Import(filePath);
        await _colocationService.ImportRequest(filePath);

        return File(System.IO.File.OpenRead(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Result.xlsx");
    }

    [HttpGet("Request/Bulk/Template")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Generate the excel file for importing. The services will be base on the database")]
    public async Task<ActionResult> GetImportTemplate()
    {
        string filePath = Path.Combine(_environment.WebRootPath, "import\\customer\\Template.xlsx");
        var result = await _colocationService.GenerateImportExcelTemplate(filePath);
        if (result.Succeed)
        {
            return File(System.IO.File.OpenRead(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Import.xlsx");
        }

        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Request")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Create colocation request for an existing customer")]
    public async Task<ActionResult> CreateRequest([FromBody] ColocationRequestCreateModel model)
    {
        var result = await _colocationService.CreateRequest(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPatch("Request")]
    [Authorize(Roles = nameof(RoleType.Sale))]
    [SwaggerOperation(Summary = "Update information of a colocation request")]
    public async Task<ActionResult> UpdateRequest([FromBody] ColocationRequestUpdateModel model)
    {
        var result = await _colocationService.UpdateRequest(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
