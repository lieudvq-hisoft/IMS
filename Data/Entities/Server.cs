namespace Data.Entities;

public class Server : BaseEntity
{
    public string SerialNumber { get; set; }
    public string Model { get; set; }

    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }
}
