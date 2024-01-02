using Data.Common.PaginationModel;
using Data.Enums;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.ClaimExtensions;
using Services.Core;

namespace IMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer")]
public class NotificationController : ControllerBase
{
    private readonly INotificationService _notificationService;

    public NotificationController(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpPost]
    public async Task<ActionResult> Add(NotificationCreateModel notification)
    {
        var rs = await _notificationService.Add(notification);
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] PagingParam<NotificationSortCriteria> pagingParam, [FromQuery] NotiSearchModel searchModel)
    {
        var rs = await _notificationService.Get(pagingParam, searchModel, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetDetail(int id)
    {
        var rs = await _notificationService.GetById(id);
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpGet("count")]
    public async Task<ActionResult> CountUserNoti([FromQuery] Guid userId, bool isSeen)
    {
        var rs = await _notificationService.CountUserNoti(userId, isSeen);
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpPut("SeenNotification/{id}")]
    public async Task<IActionResult> SeenNotify(int id)
    {
        var rs = await _notificationService.SeenNotification(id, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNotify(int id)
    {
        var rs = await _notificationService.DeleteNotification(id, Guid.Parse(User.GetId()));
        if (rs.Succeed) return Ok(rs.Data);
        return BadRequest(rs.ErrorMessage);
    }
}

