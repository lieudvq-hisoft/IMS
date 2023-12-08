using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestExpandModel
{
    public int Id { get; set; }
    public RequestStatus Status { get; set; }
    public RemovalStatus? RemovalStatus { get; set; }
    public string RequestType { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int ServerAllocationId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public int? Size { get; set; }
    public int? AppointmentId { get; set; }
    public int? SuccessExpandAppointmentId { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public AppointmentResultModel? SucceededAppointment { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
    public RequestExpandAssignLocationModel? RequestedLocation { get; set; }
}

public class RequestExpandResultModel
{
    public int Id { get; set; }
    public RequestStatus Status { get; set; }
    public int? Size { get; set; }
    public RemovalStatus? RemovalStatus { get; set; }
    public string RequestType { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int? SuccessExpandAppointmentId { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestExpandCompleteBulkModel
{
    [Required]
    public List<int> RequestExpandIds { get; set; }
}

public class RequestExpandCreateModel
{
    public int? Size { get; set; }

    [Required]
    public string? Note { get; set; }

    public string? SaleNote { get; set; }

    public string? TechNote { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class RequestExpandAssignLocationModel
{
    [Required]
    [GreaterThanZero]
    public int RackId { get; set; }

    [Required]
    [NotNegative]
    public int StartPosition { get; set; }
}

public class RequestExpandUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [GreaterThanZero]
    public int? Size { get; set; }

    public string? Note { get; set; }

    public string? SaleNote { get; set; }

    public string? TechNote { get; set; }
}

public class RequestExpandRejectModel
{
    [StringLength(2000)]
    public string? SaleNote { get; set; }

    [StringLength(2000)]
    public string? TechNote { get; set; }
}

public class RequestExpandSuggestLocationModel
{
    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
}

public class RequestExpandSearchModel
{
    public int? Id { get; set; }
    public int? ServerAllocationId { get; set; }
    public List<RequestStatus?>? Statuses { get; set; }
}