
using Data.Entities;

namespace Data.Models;

public class NotificationModel
{
    public int Id { get; set; }
    public bool? Seen { get; set; }
    public string? Action { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public object? Data { get; set; }
    public string? TypeModel { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
}

public class NotificationSearchModel
{
    public string? SearchText { get; set; }
}

public class NotificationCreateModel
{
    public Guid UserId { get; set; }
    public bool Seen { get; set; } = false;
    public string Action { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public NotificationData Data { get; set; }
}

