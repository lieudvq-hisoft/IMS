namespace Data.Entities;

public class Device : BaseEntity
{
    public string Type { get; set; }
    public int Size { get; set; }
    public int AdditionalSize { get; set; }
    public int BasePower { get; set; }
    public int AdditionalPower { get; set; }

    public virtual Server? Server { get; set; }

    public virtual ICollection<Location> Locations { get; set; }
}
