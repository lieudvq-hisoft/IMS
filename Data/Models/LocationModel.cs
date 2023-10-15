using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class AreaModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public List<RackModel> Racks { get; set; }
}

public class RackModel
{
    public int Id { get; set; }
    public int Column { get; set; }
    public int Row { get; set; }
    public int Size { get; set; }
    public int AreaId { get; set; }
}

public class RackDetailModel
{
    public int Id { get; set; }
    public double MaxPower { get; set; }
    public double CurrentPower { get; set; }
    public int Column { get; set; }
    public int Row { get; set; }
    public int Size { get; set; }
    public int AreaId { get; set; }

    public List<LocationModel> DeviceLocations { get; set; }
}

public class LocationModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Size { get; set; }
    public int StartPosition { get; set; }
}

public class LocationChoiceModel
{
    public int AreaId { get; set; }
    public int RackId { get; set; }
    public int Position { get; set; }
}
