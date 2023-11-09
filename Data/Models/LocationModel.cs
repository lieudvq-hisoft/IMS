using Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class LocationServiceModel
{
    public int Id { get; set; }
    public int StartPosition { get; set; }
    public int Size { get; set; }
    public int Power { get; set; }

    public int RackId { get; set; }
    public int ServiceId { get; set; }
}

public class LocationServiceCreateModel
{
    public int StartPosition { get; set; }
    public int Size { get; set; }
    public int Power { get; set; }

    public int RackId { get; set; }
    public int ServiceId { get; set; }
}

public class LocationServiceUpdateModel
{
    public int Id { get; set; }
    public int StartPosition { get; set; }
    public int Size { get; set; }
    public int Power { get; set; }

    public int RackId { get; set; }
    public int ServiceId { get; set; }
}


public class AreaModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }
}

public class RackModel
{

    public int Id { get; set; }
    public double MaxPower { get; set; }
    public double CurrentPower { get; set; }
    public int Column { get; set; }
    public int Row { get; set; }
    public int Size { get; set; }
    public virtual AreaModel Area { get; set; }
}

//public class RackDetailModel
//{
//    public int Id { get; set; }
//    public double MaxPower { get; set; }
//    public double CurrentPower { get; set; }
//    public int Column { get; set; }
//    public int Row { get; set; }
//    public int Size { get; set; }
//    public int AreaId { get; set; }

//    public List<LocationModel> DeviceLocations { get; set; }
//}

//public class LocationModel
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Size { get; set; }
//    public int StartPosition { get; set; }
//}

public class LocationChoiceModel
{
    public int AreaId { get; set; }

    [Required]
    public int RackId { get; set; }

    [Required]
    public int Position { get; set; }
}
