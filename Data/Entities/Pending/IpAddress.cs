namespace Data.Entities;

public class IpAddress : BaseEntity
{
    public int Address { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }

    public int IpSubnetId { get; set; }
    public virtual IpSubnet IpSubnet { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
}
