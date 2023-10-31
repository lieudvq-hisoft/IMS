namespace Data.Entities;
public class IpAssignment : BaseEntity
{
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public bool IsActive { get; set; }

    public int ServerId { get; set; }
    public virtual Server Server { get; set; }

    public int IpId { get; set; }
    public virtual Ip Ip { get; set; }
}
