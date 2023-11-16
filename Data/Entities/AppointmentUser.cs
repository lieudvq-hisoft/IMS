using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class AppointmentUser: BaseEntity
{
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
