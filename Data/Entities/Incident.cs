using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Incident: BaseEntity
{
    public string Description { get; set; }
    public string? Solution { get; set; }
    public string ResolvByClient { get; set; }
    public string? Document { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<IncidentAppointment> IncidentAppointments { get; set; }
}
