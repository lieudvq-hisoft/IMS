﻿using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;
using System.IO;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class ServerAllocationController : ControllerBase
{
    private readonly ICustomerService _customerService;
    private readonly IWebHostEnvironment _environment;
    private readonly IServerAllocationService _serverAllocationService;
    private readonly IFileService _fileService;

    public ServerAllocationController(ICustomerService customerService,
        IWebHostEnvironment environment,
        IServerAllocationService serverAllocationService,
        IFileService fileService)
    {
        _customerService = customerService;
        _environment = environment;
        _serverAllocationService = serverAllocationService;
        _fileService = fileService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get requests, excluding ongoing or stopped requests, and those with unsuccessful additional services")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] ServerAllocationSearchModel searchModel)
    {
        var result = await _serverAllocationService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail([FromRoute] int id)
    {
        var result = await _serverAllocationService.GetDetail(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/HardwareConfig")]
    public async Task<ActionResult> GetHardwareConfig([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetHardwareConfig(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestUpgrade")]
    public async Task<ActionResult> GetRequestUpgrade([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetRequestUpgrade(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestExpand")]
    public async Task<ActionResult> GetRequestExpand([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetRequestExpand(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/RequestHost")]
    public async Task<ActionResult> GetRequestHost(int id, [FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromQuery] RequestHostSearchModel searchModel)
    {
        var result = await _serverAllocationService.GetRequestHost(id, pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }


    [HttpGet("{id}/LocationAssignment")]
    public async Task<ActionResult> GetLocationAssignment([FromRoute] int id)
    {
        var result = await _serverAllocationService.GetLocationAssignment(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/IpAddress")]
    public async Task<ActionResult> GetIpAddress([FromRoute] int id, [FromQuery] PagingParam<SimpleSortCriteria> paginationModel, [FromQuery] IpAddressSearchModel searchModel)
    {
        var result = await _serverAllocationService.GetIpAddress(id, paginationModel, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Location")]
    public async Task<ActionResult> GetLocation([FromQuery] PagingParam<SimpleSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetLocation(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpGet("{id}/Appointment")]
    public async Task<ActionResult> GetAppointment([FromQuery] PagingParam<BaseSortCriteria> pagingParam, [FromRoute] int id)
    {
        var result = await _serverAllocationService.GetAppointment(pagingParam, id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] ServerAllocationCreateModel model)
    {
        var result = await _serverAllocationService.Create(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] ServerAllocationUpdateModel model)
    {
        var result = await _serverAllocationService.Update(model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var result = await _serverAllocationService.Delete(id);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/MasterIp")]
    public async Task<ActionResult> AssignMasterIp(int id, [FromBody] ServerAllocationMasterIpAssignmentModel model)
    {
        var result = await _serverAllocationService.AssignMasterIp(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/ServerLocation")]
    public async Task<ActionResult> AssignServerLocation(int id, [FromBody] ServerAllocationAssignLocationModel model)
    {
        var result = await _serverAllocationService.AssignLocation(id, model);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }

    [HttpPost("{id}/InspectionReport")]
    public async Task<ActionResult> GetMainDoc(int id, [FromQuery] MainDocModel model)
    {
        var result = await _serverAllocationService.GetMainDoc(id, model);
        if (result.Succeed)
        {
            var path = result.Data as string;
            if (System.IO.File.Exists(path))
            {
                return File(System.IO.File.OpenRead(path), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", Path.GetFileName(path));
            }
            else
            {
                return BadRequest();
            }
        }
        return BadRequest(result.ErrorMessage);
    }
}
