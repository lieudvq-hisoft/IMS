namespace Data.Entities;
public class ServerHardwareConfig : BaseEntity
{
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public bool IsCurrent { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public int ComponentId { get; set; }
    public Component Component { get; set; }
}
