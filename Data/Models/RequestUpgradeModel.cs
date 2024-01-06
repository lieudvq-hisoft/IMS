using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestUpgradeModel
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public RequestType RequestType { get; set; }
    public int ComponentId { get; set; }
    public int? AppointmentId { get; set; }
    public int ServerAllocationId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime? DateEvaluated { get; set; }
    public DateTime? DateExecuted { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public AppointmentResultModel? SucceededAppointment { get; set; }
    public AppointmentResultModel? Appointment { get; set; }
    public ComponentResultModel? Component { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
}

public class RequestUpgradeResultModel
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
    public RequestType RequestType { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public int ComponentId { get; set; }
    public int ServerAllocationId { get; set; }
    public DateTime? DateEvaluated { get; set; }
    public DateTime? DateExecuted { get; set; }
}

public class RequestUpgradeCreateModel
{
    [Required]
    public string Description { get; set; }

    public string? Note { get; set; }

    [Required]
    public int ComponentId { get; set; }

    [Required]
    public int ServerAllocationId { get; set; }
}

public class RequestUpgradeCreateBulkModel
{
    [Required]
    public List<RequestUpgradeCreateModel> RequestUpgradeCreateModels { get; set; }
}

public class RequestUpgradeEvaluateBulkModel
{
    [Required]
    public List<int> RequestUpgradeIds { get; set; }
}

public class RequestUpgradeCompleteBulkModel
{
    [Required]
    public List<int> RequestUpgradeIds { get; set; }
}

public class RequestUpgradeUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Description { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }

    public string? SaleNote { get; set; }
}

public class RequestUpgradeRejectModel
{
    [StringLength(2000)]
    public string? TechNote { get; set; }

    [StringLength(2000)]
    public string? SaleNote { get; set; }
}

public class RequestUpgradeSearchModel
{
    public string? SearchValue { get; set; }
    public int? Id { get; set; }
    public int? ComponentId { get; set; }
    public int? ServerAllocationId { get; set; }
    public List<RequestStatus?>? Statuses { get; set; }
    public Guid? UserId { get; set; }
    public Guid? CustomerId { get; set; }
    public int? AppointmentId { get; set; }
}

public class RequestUpgradeAppointmentModel
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public int RequestUpgradeId { get; set; }
}