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

public class ColocationRequestModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string Type { get; set; }
    public string CompanyName { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; }
}

public class ColocationRequestImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public ColocationCreateModel ColocationCreateModel { get; set; }
}

public class ColocationRequestCreateModel
{
    [Required]
    public int CustomerId { get; set; }

    [Required]
    public ColocationCreateModel ColocationCreateModel { get; set; }
}

public class ColocationCreateModel
{
    [Required]
    public int ExpectedSize { get; set; }

    [Required]
    public DateTime DateCreate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateCreate", ErrorMessage = "Allocate dat must be later than create date")]
    public DateTime DateAllocate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateAllocate", ErrorMessage = "Stop dat must be later than allocate date")]
    public DateTime DateStop { get; set; }

    public string? Note { get; set; }

    public string? InspectorNote { get; set; }

    public List<AdditionalServiceModel> AdditionalServices { get; set; }
}

public class ColocationRequestUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int ExpectedSize { get; set; }

    [Required]
    public DateTime DateCreate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateCreate", ErrorMessage = "Allocate dat must be later than create date")]
    public DateTime DateAllocate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateAllocate", ErrorMessage = "Stop dat must be later than allocate date")]
    public DateTime DateStop { get; set; }

    public string? Note { get; set; }

    public string? InspectorNote { get; set; }

    public List<AdditionalServiceModel> AdditionalServices { get; set; }
}

public class ColocationRequestDetailCompleteModel
{
    [Required]
    public ServerCreateModel ServerCreateModel { get; set; }

    [Required]
    public LocationChoiceModel LocationChoiceModel { get; set; }
}

public class ColocationSearchModel
{
    public string? SearchValue { get; set; } = "";
    public ColocationStatus? Status { get; set; }
}

