using Data.Enums;

namespace Data.Entities;
public class IpAssignment : BaseEntity
{
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }

    public int IpId { get; set; }
    public virtual Ip Ip { get; set; }

    public int RequestId { get; set; }
    public virtual Request Request { get; set; }
}
