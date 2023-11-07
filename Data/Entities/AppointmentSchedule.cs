using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class AppointmentSchedule : BaseEntity
{
    public string VisitorName { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public string Reason { get; set; }
    public string? Note { get; set; }
    public bool? CorrectPerson { get; set; }
    public string? TechNote { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public int? TechExecutionId { get; set; }
    public virtual TechExecution? TechExecution { get; set; }

    
    public virtual ICollection<ServerAppointment> ServerAppointments { get; set; }
}
