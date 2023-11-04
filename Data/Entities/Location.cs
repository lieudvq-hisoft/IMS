namespace Data.Entities;
public class Location : BaseEntity
{
    public int StartPosition { get; set; }

    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }

    public int RackId { get; set; }
    public virtual Rack Rack { get; set; }
}
