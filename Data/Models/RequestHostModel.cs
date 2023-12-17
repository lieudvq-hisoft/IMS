using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestHostModel
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int? Capacity { get; set; }
    public bool IsRemoval { get; set; }
    public bool IsUpgrade { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public bool DocumentConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    //public string? ReceiptOfRecipientFilePath { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public int ServerAllocationId { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
}

public class RequestHostResultModel
{
    public int Id { get; set; }
    public string? Note { get; set; }
    public int Quantity { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int? Capacity { get; set; }
    public bool IsRemoval { get; set; }
    public bool IsUpgrade { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public bool DocumentConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }

    public int ServerAllocationId { get; set; }
}

public class RequestHostCreateModel
{
    public string? Note { get; set; }

    public string? SaleNote { get; set; }

    public string? TechNote { get; set; }

    [Required]
    [GreaterThanZero]
    public int Quantity { get; set; }

    [EnsureMinimumElements]
    public List<int>? Capacities { get; set; }

    [Required]
    public bool IsRemoval { get; set; }

    [Required]
    public IpAssignmentTypes Type { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class RequestHostCreateUpgradeModel
{
    public string? Note { get; set; }

    public string? SaleNote { get; set; }

    public string? TechNote { get; set; }

    [Required]
    [GreaterThanZero]
    public int Capacity { get; set; }

    [Required]
    [EnsureMinimumElements]
    public List<int> PortIpIds { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class RequestHostIpAssignmentModel
{
    [Required]
    public List<int> IpAddressIds { get; set; }
}

public class RequestHostUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    public string? Note { get; set; }

    public string? SaleNote { get; set; }

    public string? TechNote { get; set; }

    [Required]
    [GreaterThanZero]
    public int Quantity { get; set; }

    public IpAssignmentTypes Type { get; set; }
}

public class RequestHostSearchModel
{
    public IpAssignmentTypes? Type { get; set; }
    public RequestHostStatus? Status { get; set; }
    public string? MasterIp { get; set; }
    public string? Customer { get; set; }
    public bool? IsRemoved { get; set; }
}

public class RequestHostEvaluateBulkModel
{
    [Required]
    public List<int> RequestHostIds { get; set; }
}

public class RequestHostRejectModel
{
    [StringLength(2000)]
    public string? Note { get; set; }

    [StringLength(2000)]
    public string? SaleNote { get; set; }

    [StringLength(2000)]
    public string? TechNote { get; set; }
}
