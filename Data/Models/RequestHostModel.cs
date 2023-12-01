using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestHostModel
{
    public int Id { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public int ServerAllocationId { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
}

public class RequestHostResultModel
{
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }

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

    [Required]
    public bool IsRemoval { get; set; }

    [Required]
    public IpAssignmentTypes Type { get; set; }

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
    public IpAssignmentTypes? Type { get; set; } = null;
    public RequestHostStatus? Status { get; set; } = null;
    public int? ServerAllocationId { get; set; } = null;
}

public class RequestHostEvaluateBulkModel
{
    [Required]
    public List<int> RequestHostIds { get; set; }

    [Required]
    public string UserId { get; set; }
}
