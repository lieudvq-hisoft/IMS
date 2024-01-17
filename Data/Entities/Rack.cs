﻿namespace Data.Entities;
public class Rack : BaseEntity
{
    public int MaxPower { get; set; }
    public int Column { get; set; }
    public int Row { get; set; }
    public int Size { get; set; }

    public int AreaId { get; set; }
    public Area Area { get; set; }

    public ICollection<Location> Locations { get; set; }

    public string DisplayRack()
    {
        return $"{Area.Name}{Column + 1}-{Row + 1}";
    }
}
