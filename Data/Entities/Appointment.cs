using Data.Enums;
using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;
public class Appointment : BaseEntity
{
    public string? AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public AppointmentReason? Reason { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public RequestStatus Status { get; set; }
    public bool DocumentConfirm { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }
    public DateTime? DateEvaluated { get; set; }
    public DateTime? DateExecuted { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment>? RequestUpgradeAppointment { get; set; }
    public ICollection<AppointmentUser>? AppointmentUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }
    public ICollection<IncidentAppointment>? IncidentAppointments { get; set; }
}
