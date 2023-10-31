using IMS.Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ColocationRequestModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateStop { get; set; }
    public string Type { get; set; }
    public string CompanyName { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
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

public class ColocationRequestUpdateModel
{
    [Required]
    public int Id { get; set; }

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

public class ColocationRequestDetailCompleteModel
{
    [Required]
    public ServerCreateModel ServerCreateModel { get; set; }

    [Required]
    public LocationChoiceModel LocationChoiceModel { get; set; }

    public int IpId { get; set; }
}


