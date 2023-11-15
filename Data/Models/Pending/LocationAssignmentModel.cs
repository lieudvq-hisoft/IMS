using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class LocationAssignmentModel
{
    public int ServiceId { get; set; }
    public int StartPosition { get; set; }
    public string Rack { get; set; }
    public int Size { get; set; }
}

public class LocationCreateModel
{
    [Required]
    public int ServiceId { get; set; }

    [Required]
    public int StartPosition { get; set; }

    [Required]
    public int RackId { get; set; }

    [Required]
    public int Size { get; set; }
}

public class LocationUpdateModel
{
    [Required]
    public int ServiceId { get; set; }

    [Required]
    public int StartPosition { get; set; }

    [Required]
    public int RackId { get; set; }

    [Required]
    public int Size { get; set; }
}

#region Area models
public class AreaModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }
}

public class AreaDetailModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public List<RackModel> Racks { get; set; }
}

public class AreaCreateModel
{
    [Required]
    public string Name { get; set; }
    [Required]
    public int RowCount { get; set; }
    [Required]
    public int ColumnCount { get; set; }
}

public class AreaUpdateModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int RowCount { get; set; }
    [Required]
    public int ColumnCount { get; set; }
}
#endregion

#region Rack models
public class RackModel
{
    public int Id { get; set; }
    public double MaxPower { get; set; }
    public double CurrentPower { get; set; }
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


public class RackCreateModel
{
    [Required]
    public double MaxPower { get; set; }
    [Required]
    public double CurrentPower { get; set; }
    [Required]
    public int Column { get; set; }
    [Required]
    public int Row { get; set; }
    [Required]
    public int Size { get; set; }
    [Required]
    public int AreaId { get; set; }
}

public class RackUpdateModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public double MaxPower { get; set; }
    [Required]
    public double CurrentPower { get; set; }
    [Required]
    public int Column { get; set; }
    [Required]
    public int Row { get; set; }
    [Required]
    public int Size { get; set; }
    [Required]
    public int AreaId { get; set; }
}
#endregion

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

    [Required]
    public int RackId { get; set; }

    [Required]
    public int Position { get; set; }
}

public class LocationAssignmentSearchModel
{
    public int? ServiceId { get; set; } = null;
}

public class AreaSearchModel
{
    public int? AreaId { get; set; } = null;
}

public class RackSearchModel
{
    public int? RackId { get; set; } = null;
}

