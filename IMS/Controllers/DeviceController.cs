using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Core;
using Swashbuckle.AspNetCore.Annotations;

namespace IMS.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class DeviceController : ControllerBase
{
    private readonly IDeviceService _deviceService;
    public DeviceController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "Get non server device list")]
    public async Task<ActionResult> Get([FromQuery] PagingParam<DeviceSortCriteria> pagingParam, [FromQuery] DeviceSearchModel searchModel)
    {
        var result = await _deviceService.Get(pagingParam, searchModel);
        if (result.Succeed) return Ok(result.Data);
        return BadRequest(result.ErrorMessage);
    }
}
