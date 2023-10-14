﻿using Data.Common.PaginationModel;
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
    private readonly IServerService _serverService;

    public CollocationController(ICustomerService customerService, IWebHostEnvironment environment, ICollocationService collocationService, IFileService fileService, IServerService serverService)
    {
        _customerService = customerService;
        _environment = environment;
        _collocationService = collocationService;
        _fileService = fileService;
        _serverService = serverService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<CollocationSortCriteria> pagingParam, [FromQuery] CollocationSearchModel searchModel)
    {
        var result = await _collocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("Request")]
    public async Task<ActionResult> GetRequest([FromQuery] PagingParam<CollocationSortCriteria> pagingParam, [FromQuery] CollocationSearchModel searchModel)
    {
        var result = await _collocationService.GetRequest(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("Request/Bulk")]
    public async Task<ActionResult> Import(IFormFile importFile)
    {
        string folderPath = Path.Combine(_environment.WebRootPath, "import\\customer");
        string filePath = await _fileService.SaveFile(importFile, folderPath);
        await _customerService.Import(filePath);
        await _collocationService.Import(filePath);

        return File(System.IO.File.OpenRead(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Result.xlsx");
    }

    [HttpPost("Request")]
    public async Task<ActionResult> Create([FromBody] CollocationRequestCreateModel model)
    {
        var result = await _collocationService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}