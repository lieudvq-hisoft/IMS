using Data.Enums;

namespace Data.Entities;
public class IpAssignment : BaseEntity
{
    public IpAssignmentTypes Type { get; set; }
    public int? Capacity { get; set; }

    public int IpAddressId { get; set; }
    public IpAddress? IpAddress { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }
}
