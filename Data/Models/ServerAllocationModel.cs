using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServerAllocationModel
{
    public int Id { get; set; }
    public ServerAllocationStatus Status { get; set; }
    //public int ExpectedSize { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    //public string? InspectionRecordFilePath { get; set; }
    //public string? ReceiptOfRecipientFilePath { get; set; }
    public int CustomerId { get; set; }
}

public class ServerAllocationCreateModel
{
    public string? Note { get; set; }

    public string? TechNote { get; set; }

    public string? SaleNote { get; set; }

    [Required]
    public int CustomerId { get; set; }
}

public class ServerAllocationUpdateModel
{
    [Required]
    public int Id { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }

    public string? SaleNote { get; set; }
}

public class ServerAllocationSearchModel
{
    public int? CustomerId { get; set; }
    public List<ServerAllocationStatus>? Status { get; set; }
}

public class ServerAllocationImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public ServerAllocationCreateModel RequestCreateModel { get; set; }
}