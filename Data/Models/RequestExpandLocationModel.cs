using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestExpandLocationModel
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
