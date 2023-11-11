namespace Data.Entities;
public class Component : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Unit { get; set; }

    public ICollection<ServerHardwareConfig> HardwareConfigs { get; set; }
}
