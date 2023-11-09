using Data.Enums;

namespace Data.Entities;
public class Service : BaseEntity
{
    public string Name { get; set; }
    public ServiceType Type { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }

    public virtual ICollection<LocationAssignment> LocationAssignments { get; set; } 

    public virtual ICollection<ComponentAssignment> ComponentAssignments { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
}
