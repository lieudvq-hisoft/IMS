using Data.Enums;

namespace Data.Entities;
public class IpAssignment : BaseEntity
{
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }

    public int IpAddressId { get; set; }
    public IpAddress IpAddress { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }
}
