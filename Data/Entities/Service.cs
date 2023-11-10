using Data.Enums;

namespace Data.Entities;
public class Service : BaseEntity
{
    public int Quantity { get; set; }
    public ServiceRequestStatus Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public bool IsDelegated { get; set; }

    public int RequestId { get; set; }
    public virtual Request Request { get; set; }

    public int ServiceTypeId { get; set; }
    public virtual ServiceType ServiceType { get; set; }

    //public virtual ICollection<LocationAssignment> LocationAssignments { get; set; } 

    public virtual ICollection<ComponentAssignment> ComponentAssignments { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
}
