using Data.Enums;

namespace Data.Entities;
public class Appointment : BaseEntity
{
    public string AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public string Reason { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public bool IsCorrectPerson { get; set; }
    public RequestStatus Status { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment> RequestUpgradeAppointment { get; set; }
    public ICollection<AppointmentUser> AppointmentUsers { get; set; }
    public ICollection<RequestExpandAppointment> RequestExpandAppointments { get; set; }
}
