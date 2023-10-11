using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
//[Authorize(Roles = nameof(RoleType.Staff))]
[AllowAnonymous]
public class CollocationController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly IWebHostEnvironment _environment;
    private readonly ICollocationService _collocationService;
    private readonly IFileService _fileService;

    public CollocationController(ICustomerService customerService, IWebHostEnvironment environment, ICollocationService collocationService, IFileService fileService)
    {
        _customerService = customerService;
        _environment = environment;
        _collocationService = collocationService;
        _fileService = fileService;
    }

    [HttpPost("bulk")]
    public async Task<ActionResult> Import(IFormFile importFile)
    {
        string folderPath = Path.Combine(_environment.WebRootPath, "import\\customer");
        string filePath = await _fileService.SaveFile(importFile, folderPath);
        //await _customerService.Import(filePath);

        return File(System.IO.File.OpenRead(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Result.xlsx");
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] CollocationCreateModel model)
    {
        var createCustomerResult = await _customerService.Create(model.CustomerCreateModel);
        if (createCustomerResult.Succeed)
        {
            CustomerModel customerModel = createCustomerResult.Data as CustomerModel;
            var createCollocationResult = await _collocationService.AttempCreate(model, customerModel);

            if (createCollocationResult.Succeed)
            {
                return Ok();
            }
        }



        return BadRequest(createCustomerResult.ErrorMessage);
    }
}
