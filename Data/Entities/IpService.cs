using Data.Enums;

namespace Data.Entities;
public class IpService : BaseEntity
{
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentType Type { get; set; }

    public int IpId { get; set; }
    public virtual Ip Ip { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }
}
