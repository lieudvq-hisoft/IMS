using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class AppointmentModel
{
    public int Id { get; set; }
    public string AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public AppointmentReason Reason { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
    public bool DocumentConfirm { get; set; }
    public string? Purpose { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public DateTime? DateEvaluated { get; set; }
    public DateTime? DateExecuted { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
}

public class AppointmentResultModel
{
    public int Id { get; set; }
    public string AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public AppointmentReason Reason { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public bool DocumentConfirm { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }
    public DateTime? DateEvaluated { get; set; }
    public DateTime? DateExecuted { get; set; }
}

public class AppointmentCreateModel
{
    [Required]
    public string AppointedCustomer { get; set; }

    [Required]
    [OfficialTime]
    public DateTime DateAppointed { get; set; }

    [Required]
    public AppointmentReason Reason { get; set; }

    public string? Note { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }

    [EnsureMinimumElements]
    public List<int>? RequestUpgradeIds { get; set; }

    public int? RequestExpandId { get; set; }
}

public class AppointmentIncidentCreateModel
{
    [Required]
    public string AppointedCustomer { get; set; }

    [Required]
    [OfficialTime]
    public DateTime DateAppointed { get; set; }

    public string? Note { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }

    [Required]
    [GreaterThanZero]
    public int IncidentId { get; set; }
}

public class RequestAppointmentCreateModel
{
    public List<int>? RequestUpgradeIds { get; set; }

    public int? RequestExpandId { get; set; }
}

public class RequestAppointmentCreateResultModel
{
    public IEnumerable<object> RequestUpgradeAppointments { get; set; }

    public object RequestExpandAppointment { get; set; }
}

public class AppointmentCreateResultModel
{
    public AppointmentResultModel Appointment { get; set; }

    public IEnumerable<object> RequestUpgradeAppointments { get; set; }

    public object RequestExpandAppointment { get; set; }
}

public class AppointmentUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [Required]
    [OfficialTime]
    public DateTime DateAppointed { get; set; }

    [Required]
    public string AppointedCustomer { get; set; }

    public string? Note { get; set; }

    public string? SaleNote { get; set; }

    public string? TechNote { get; set; }
}

public class AppointmentFailModel
{
    [Required]
    [StringLength(2000)]
    public string? TechNote { get; set; }

    [Required]
    public ServerAllocationCreateRequestExpandInspectionReportModel DocumentModel { get; set; }
}

public class AppointmentCompleteModel
{
    [Required]
    public DateTime DateCheckedIn { get; set; }

    [Required]
    [SameDateAndLaterThan("DateCheckedIn")]
    public DateTime DateCheckedOut { get; set; }

    public ServerAllocationCreateRequestExpandInspectionReportModel DocumentModel;
}

public class AppointmentResolvModel
{
    [Required]
    public DateTime DateCheckedIn { get; set; }

    [Required]
    [SameDateAndLaterThan("DateCheckedIn")]
    public DateTime DateCheckedOut { get; set; }

    [Required]
    public IncidentResolvModel IncidentResolvModel { get; set; }

    public ServerAllocationCreateRequestExpandInspectionReportModel? DocumentModel;
}

public class AppointmentSearchModel
{
    public string? SearchValue { get; set; }
    public int? Id { get; set; }
    public List<RequestStatus?>? Statuses { get; set; }
    public List<AppointmentReason?>? Reasons { get; set; }
    public int? ServerAllocationId { get; set; }
    public Guid? CustomerId { get; set; }
    public Guid? UserId { get; set; }
}