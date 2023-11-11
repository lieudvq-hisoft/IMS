namespace Data.Entities;
public class Rack : BaseEntity
{
    public double MaxPower { get; set; }
    public double CurrentPower { get; set; }
    public int Column { get; set; }
    public int Row { get; set; }
    public int Size { get; set; }

    public int AreaId { get; set; }
    public virtual Area Area { get; set; }

    public virtual ICollection<Location> Locations { get; set; }

    public string DisplayRack()
    {
        return $"{Area.Name}{Column}-{Row}";
    }
}
