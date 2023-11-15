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
    [GreaterThanZero]
    public string Name { get; set; }
    [Required]
    [GreaterThanZero]
    public int RowCount { get; set; }
    [Required]
    [GreaterThanZero]
    public int ColumnCount { get; set; }
}

public class AreaUpdateModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [GreaterThanZero]
    public int RowCount { get; set; }
    [Required]
    [GreaterThanZero]
    public int ColumnCount { get; set; }
}

public class AreaSearchModel
{
    public int? AreaId { get; set; } = null;
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
    [GreaterThanZero]
    public double MaxPower { get; set; }
    [Required]
    [GreaterThanZero]
    public double CurrentPower { get; set; }
    [Required]
    [GreaterThanZero]
    public int Column { get; set; }
    [Required]
    [GreaterThanZero]
    public int Row { get; set; }
    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
    [Required]
    public int AreaId { get; set; }
}

public class RackUpdateModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    [GreaterThanZero]
    public double MaxPower { get; set; }
    [Required]
    [GreaterThanZero]
    public double CurrentPower { get; set; }
    [Required]
    [GreaterThanZero]
    public int Column { get; set; }
    [Required]
    [GreaterThanZero]
    public int Row { get; set; }
    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
    [Required]
    public int AreaId { get; set; }
}

public class RackSearchModel
{
    public int? RackId { get; set; } = null;
}
#endregion

public class LocationModel
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public int Position { get; set; }
    public int RackId { get; set; }
}

public class LocationSearchModel
{
    public int? LocationId { get; set; } = null;
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

[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
public class GreaterThanZeroAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is int intValue && intValue > 0)
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("The value must be greater than 0.");
    }
}

