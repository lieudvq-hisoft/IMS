using Data.Entities;
using Data.Enums;
using IMS.Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Data.Models;
public class RequestModel
{
    public int Id { get; set; }
    public RequestStatus Status { get; set; }
    public int ExpectedSize { get; set; }
    public string? Note { get; set; }
    public string? InspectorNote { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public int CustomerId { get; set; }
}

public class RequestCreateModel
{
    [Required]
    public int ExpectedSize { get; set; }

    [Required]
    public string? Note { get; set; }

    [Required]
    public int CustomerId { get; set; }
}
public class RequestUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public RequestStatus Status { get; set; }

    [Required]
    public int ExpectedSize { get; set; }

    public string? Note { get; set; }

    public string? InspectorNote { get; set; }
}

public class RequestSearchModel
{
    public int? CustomerId { get; set; } = null;
    public List<RequestStatus>? Status { get; set; } = null;
}

public class RequestImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public RequestCreateModel RequestCreateModel { get; set; }
}

public class RequestDetailCompleteModel
{
    [Required]
    public ServerCreateModel ServerCreateModel { get; set; }

    [Required]
    public LocationChoiceModel LocationChoiceModel { get; set; }

    public int IpId { get; set; }
}

