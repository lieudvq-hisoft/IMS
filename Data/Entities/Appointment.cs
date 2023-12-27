using Data.Enums;
using Data.Models;

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
    public bool IsCorrectPerson { get; set; }
    public RequestStatus Status { get; set; }
    public bool DocumentConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment>? RequestUpgradeAppointment { get; set; }
    public ICollection<AppointmentUser>? AppointmentUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }
    public ICollection<IncidentAppointment>? IncidentAppointments { get; set; }

    public bool FilterAppointment(AppointmentSearchModel model)
    {
        bool matchId = model.Id != null ? Id == model.Id : true;
        bool matchStatus = model.Status != null ? Status == model.Status : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? ServerAllocationId == model.ServerAllocationId : true;
        bool matchCustomer = model.CustomerId != null ? ServerAllocation.CustomerId == model.CustomerId : true;
        bool matchUser = model.UserId != null ? AppointmentUsers.Any(x => x.UserId == model.UserId) : true;

        return matchId && matchStatus && matchServerAllocationId && matchCustomer && matchUser;
    }
}
