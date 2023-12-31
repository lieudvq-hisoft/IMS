using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServerAllocationModel
{
    public int Id { get; set; }
    public ServerAllocationStatus Status { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public IpAddressResultModel? MasterIp { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public bool LocationRemoved { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }
    public string? RemovalInspectFilePath { get; set; }
    public string? FinalRemovalInspect { get; set; }
    public string? RemovalReceiptFilePath { get; set; }
    public string? FinalRemovalReceipt { get; set; }
    public int? PausingRequireIncidentCount { get; set; }
    public int? IncidentCount { get; set; }
    public string Location { get; set; }
    public string? MasterIpAddress { get; set; }
    public string? PartNumber { get; set; }
    public int IpCount { get; set; }
    public Guid CustomerId { get; set; }
    public CustomerModel? Customer { get; set; }
}

public class ServerAllocationResultModel
{
    public int Id { get; set; }
    public ServerAllocationStatus Status { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public string? PartNumber { get; set; }
    public string? MasterIpAddress { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public string? ServerLocation { get; set; }
    public bool LocationRemoved { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }
    public string? RemovalInspectFilePath { get; set; }
    public string? FinalRemovalInspect { get; set; }
    public string? RemovalReceiptFilePath { get; set; }
    public string? FinalRemovalReceipt { get; set; }
    public Guid CustomerId { get; set; }
}

public class ServerAllocationAssignLocationModel
{
    [Required]
    [GreaterThanZero]
    public int RackId { get; set; }

    [Required]
    [NotNegative]
    public int StartPosition { get; set; }

    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
}

public class ServerAllocationCreateModel
{
    [Required]
    [StringLength(255, MinimumLength = 6)]
    public string Name { get; set; }

    [StringLength(255, MinimumLength = 6)]
    public string? SerialNumber { get; set; }

    [StringLength(255, MinimumLength = 6)]
    public string? PartNumber { get; set; }

    [Range(100, double.MaxValue)]
    public int? Power { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }

    public string? SaleNote { get; set; }
}

public class ServerAllocationUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(255, MinimumLength = 6)]
    public string SerialNumber { get; set; }

    [Required]
    [StringLength(255, MinimumLength = 6)]
    public string PartNumber { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Power { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }
}

public class ServerAllocationMasterIpAssignmentModel
{
    [Required]
    public int IpAddressId { get; set; }
}

public class ServerAllocationSearchModel
{
    public string? SearchValue { get; set; }
    public Guid? CustomerId { get; set; }
    public int? RackId { get; set; }
    public List<ServerAllocationStatus>? Status { get; set; }
}

public class ServerAllocationImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public ServerAllocationCreateModel RequestCreateModel { get; set; }
}

public class HostAndUpgradeCreateInspectionReportModel
{
    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string QTName { get; set; } = "QTName";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string Position { get; set; } = "Position";

    [Required]
    [MinLength(6)]
    [MaxLength(2000)]
    public string Location { get; set; } = "Location";

    [Required]
    public bool Good { get; set; } = true;

    [MaxLength(2000)]
    public string Note { get; set; } = "Note";
}


public class ServerAllocationCreateRequestExpandInspectionReportModel
{
    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string QTName { get; set; } = "QTName";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string Position { get; set; } = "Position";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string Username { get; set; } = "Username";

    [Required]
    public bool isSendMS { get; set; } = true;

    [Required]
    public bool Good { get; set; } = true;

    [Required]
    public bool Guid { get; set; } = true;

    [MaxLength(2000)]
    public string Note { get; set; } = "Note";

    [Required]
    public string DeviceCondition { get; set; }
}

public class ReceiptOfRecipientModel
{
    [Required]
    [MinLength(6)]
    [MaxLength(2000)]
    public string Location { get; set; } = "Location";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string CustomerName { get; set; } = "CustomerName";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string CustomerPosition { get; set; } = "CustomerPosition";

    [Required]
    [MinLength(6)]
    [MaxLength(2000)]
    public string Address { get; set; } = "Address";


    [Required]
    [MinLength(8)]
    [MaxLength(12)]
    public string PhoneNumber { get; set; } = "PhoneNumber";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string Email { get; set; } = "Email";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string QTName { get; set; } = "QTName";

    [Required]
    [MinLength(6)]
    [MaxLength(255)]
    public string Position { get; set; } = "Position";

    [MinLength(2)]
    [MaxLength(255)]
    public string DeviceCondition { get; set; } = "DeviceCondition";
}