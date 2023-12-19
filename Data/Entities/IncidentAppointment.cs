using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class IncidentAppointment: BaseEntity
{
    public int IncidentId { get; set; }
    public Incident Incident { get; set; }

    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }
}
