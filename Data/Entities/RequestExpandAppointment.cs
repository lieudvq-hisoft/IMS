namespace Data.Entities;
public class RequestExpandAppointment : BaseEntity
{
    public bool ForRemoval { get; set; }

    public int RequestExpandId { get; set; }
    public RequestExpand RequestExpand { get; set; }

    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }
}
