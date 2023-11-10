using Data.Enums;

namespace Data.Entities;
public class Request : BaseEntity
{
    public ServiceStatus Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public bool IsDelegated { get; set; }

    public int OrderId { get; set; }
    public virtual Order Order { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }

    //public virtual ICollection<LocationAssignment> LocationAssignments { get; set; } 

    public virtual ICollection<ComponentAssignment> ComponentAssignments { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
}
