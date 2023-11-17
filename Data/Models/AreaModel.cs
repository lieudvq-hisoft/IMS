using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class AreaModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }
}

public class AreaCreateModel
{
    [Required]
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
