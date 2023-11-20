using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestExpandModel
{
    public int Id { get; set; }
    //public int Power { get; set; }
    public RequestStatus Status { get; set; }
    public string RequestType { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestExpandCreateModel
{
    //[Required]
    //[NotNegative]
    //public int Power { get; set; }

    [Required]
    public string? Note { get; set; }

    public string? TechNote { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class RequestExpandAssignLocationModel
{
    [Required]
    [GreaterThanZero]
    public int RackId { get; set; }

    [Required]
    [NotNegative]
    public int StartPosition { get; set; }

    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
}

public class RequestExpandUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    //[Required]
    //[NotNegative]
    //public int Power { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }
}

public class RequestExpandSuggestLocationModel
{
    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
}

public class RequestExpandSearchModel
{
    public int? Id { get; set; } = null;
}