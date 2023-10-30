using Data.Enums;
using IMS.Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ColocationModel
{
    public int Id { get; set; }
    public DateTime DateCreate { get; set; }
    public string Type { get; set; }
    public string CompanyName { get; set; }
    public ColocationStatus Status { get; set; }
}

public class ColocationCreateModel
{
    [Required]
    public int ExpectedSize { get; set; }

    [Required]
    public DateTime DateCreated { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateCreated", ErrorMessage = "Allocate dat must be later than created date")]
    public DateTime DateAllocate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateAllocate", ErrorMessage = "Stop dat must be later than allocate date")]
    public DateTime DateStop { get; set; }

    public string? Note { get; set; }

    public string? InspectorNote { get; set; }

    public List<AdditionalServiceModel> AdditionalServices { get; set; }
}

public class ColocationSearchModel
{
    public string? SearchValue { get; set; } = "";
    public int? Id { get; set; }
    public ColocationStatus? Status { get; set; }
}

