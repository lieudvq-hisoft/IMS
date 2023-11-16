using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Appointment: BaseEntity
{
    public DateTime DateAppointed { get; set; }
    public string Reason { get; set; }
    public RequestStatus Status { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment> RequestUpgradeAppointment { get; set; }
    public ICollection<AppointmentUser> AppointmentUsers { get; set; }
}
