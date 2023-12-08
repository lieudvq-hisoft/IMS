using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestExpandLocationModel
{
    public int Id { get; set; }
    public int RequestExpandId { get; set; }
    public int LocationId { get; set; }
}

public class RequestExpandLocationResultModel
{
    public int Id { get; set; }
    public int RequestExpandId { get; set; }
    public int LocationId { get; set; }
}


public class RequestExpandLocationCreateModel
{
    [Required]
    [GreaterThanZero]
    public int RequestExpandId { get; set; }
    [Required]
    [GreaterThanZero]
    public int LocationId { get; set; }
}

public class RequestExpandLocationSearchModel
{
    public int? Id { get; set; } = null;
}
