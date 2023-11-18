using Data.Enums;

namespace Data.Entities.Pending;
public class RequestHost : BaseEntity
{
    public IpAssignmentTypes Type { get; set; }

    public int ServerAllocationId { get; set; }
    public virtual ServerAllocation ServerAllocation { get; set; }

    public virtual ICollection<RequestHostAppointment> RequestHostAppointments { get; set; }
    
    public virtual ICollection<RequestHostIp> RequestHostIps { get; set; }

    public virtual ICollection<RequestHostUser> RequestHostUsers { get; set; }
}
