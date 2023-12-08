namespace Data.Entities;
public class ServerHardwareConfig : BaseEntity
{
    public string Description { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public int ComponentId { get; set; }
    public Component Component { get; set; }
}
