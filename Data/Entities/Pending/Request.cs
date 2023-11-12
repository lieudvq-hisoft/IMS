using Data.Enums;

namespace Data.Entities;
public class Request : BaseEntity
{
    public RequestStatus Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public bool IsDelegated { get; set; }

    public int ServerAllocationId { get; set; }
    //public virtual ServerAllocation ServerAllocation { get; set; }

    public int? ServiceId { get; set; }
    public virtual Service? Service { get; set; }

    //public virtual ICollection<LocationAssignment> LocationAssignments { get; set; } 

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
}
