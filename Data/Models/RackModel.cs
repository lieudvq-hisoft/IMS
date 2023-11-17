using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RackModel
{
    public int Id { get; set; }
    public int MaxPower { get; set; }
    public int Column { get; set; }
    public int Row { get; set; }
    public int Size { get; set; }
    public int AreaId { get; set; }
}

public class RackCreateModel
{
    [Required]
    [GreaterThanZero]
    public int MaxPower { get; set; }

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
    [Range(1, double.MaxValue)]
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
    public int Size { get; set; }
}

public class RackSearchModel
{
    public int? RackId { get; set; } = null;
}
