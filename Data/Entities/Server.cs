namespace Data.Entities;

public class Server : BaseEntity
{
    public string SerialNumber { get; set; }
    public string Model { get; set; }
    public int NumberOfPort { get; set; }
    public int AdditionalNumberOfPort { get; set; }

    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }

    public virtual Colocation Colocation { get; set; }
}
