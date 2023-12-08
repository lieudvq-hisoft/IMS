using Data.Enums;

namespace Data.Entities;
public class AppointmentUser : BaseEntity
{
    public RequestUserAction Action { get; set; }

    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
