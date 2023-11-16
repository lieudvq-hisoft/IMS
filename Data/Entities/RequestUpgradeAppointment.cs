using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class RequestUpgradeAppointment : BaseEntity
{
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public int RequestUpgradeId { get; set; }
    public RequestUpgrade RequestUpgrade { get; set; }
}
