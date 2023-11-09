namespace Data.Entities;
public class LocationService : BaseEntity
{
    public int StartPosition { get; set; }
    public int Size { get; set; }
    public int Power { get; set; }

    public int RackId { get; set; }
    public virtual Rack Rack { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }
}
