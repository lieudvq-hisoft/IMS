using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class ServerAppointment: BaseEntity
{
    public int AppointmentScheduleId { get; set; }
    public virtual AppointmentSchedule AppointmentSchedule { get; set; }

    public int ServerId { get; set; }
    public virtual Server Server { get; set; }
}
