using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestExpandModel
{
    public int Id { get; set; }
    public int Power { get; set; }
    public RequestStatus Status { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }

    public int ServerAllocationId { get; set; }
}

public class RequestExpandCreateModel
{
    [Required]
    public int Power { get; set; }
    [Required]
    public RequestStatus Status { get; set; }
    [Required]
    public string? Note { get; set; }
    [Required]
    public string? TechNote { get; set; }
    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class RequestExpandSearchModel
{
    public int? Id { get; set; } = null;
}