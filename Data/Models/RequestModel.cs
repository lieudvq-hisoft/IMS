using Data.Entities;
using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public string Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public bool IsDelegated { get; set; }
    public int OrderId { get; set; }
    public int ServiceId { get; set; }
}

public class RequestCreateModel
{
    [Required]
    public bool IsDelegated { get; set; }

    [Required]
    public int OrderId { get; set; }

    [Required]
    public int ServiceId { get; set; }
}

public class RequestSearchModel
{
    public int? OrderId { get; set; }

    public ServiceType? Type { get; set; }

    public ServiceStatus? Status { get; set; }
}

