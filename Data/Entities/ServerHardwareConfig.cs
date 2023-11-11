namespace Data.Entities;
public class ServerHardwareConfig : BaseEntity
{
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public DateTime DateInstalled { get; set; }

    public int RequestId { get; set; }
    public Request Request { get; set; }

    public int ComponentId { get; set; }
    public Component Component { get; set; }
}
