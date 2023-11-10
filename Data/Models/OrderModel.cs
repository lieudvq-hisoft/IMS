using Data.Entities;
using Data.Enums;
using IMS.Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Data.Models;
public class OrderModel
{
    public int Id { get; set; }
    public OrderStatus Status { get; set; }
    public int ExpectedSize { get; set; }
    public string? Note { get; set; }
    public string? InspectorNote { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public int CustomerId { get; set; }
}

public class OrderCreateModel
{
    [Required]
    public int ExpectedSize { get; set; }

    [Required]
    public string? Note { get; set; }

    [Required]
    public int CustomerId { get; set; }
}
public class OrderUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public OrderStatus Status { get; set; }

    [Required]
    public int ExpectedSize { get; set; }

    public string? Note { get; set; }

    public string? InspectorNote { get; set; }
}

public class OrderSearchModel
{
    public int? CustomerId { get; set; } = null;
    public List<OrderStatus>? Status { get; set; } = null;
}

public class OrderImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public OrderCreateModel RequestCreateModel { get; set; }
}

