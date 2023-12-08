namespace Data.Entities;
public class Component : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsRequired { get; set; }

    public ICollection<ServerHardwareConfig> ServerHardwareConfigs { get; set; }
    public ICollection<RequestUpgrade> RequestUpgrades { get; set; }
}
