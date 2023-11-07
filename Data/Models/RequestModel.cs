using Data.Entities;
using Data.Enums;
using IMS.Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Data.Models;
public class RequestModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateStop { get; set; }
    public string Type { get; set; }
    public string CustomerName { get; set; }
    public int CustomerId { get; set; }
    public string Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public List<ServiceRequestModel>? ServiceRequestModels { get; set; }
}

public class InitialRequestCreateModel
{
    [Required]
    public int CustomerId { get; set; }

    [Required]
    public RequestCreateModel RequestCreateModel { get; set; }
}

public class RequestCreateModel
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

    public List<ServiceRequestModel> ServiceRequests { get; set; }
}

public class RequestSearchModel
{
    public string? CompanyName { get; set; } = "";
    public int? Id { get; set; } = null;
    public List<RequestStatus>? Status { get; set; } = null;
    public List<ServiceRequestStatus>? ServiceRequestStatus { get; set; } = null;
}

public class RequestImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public RequestCreateModel RequestCreateModel { get; set; }
}

public class RequestUpdateModel
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

    public List<ServiceRequestModel> ServiceRequests { get; set; }
}

public class RequestDetailCompleteModel
{
    [Required]
    public ServerCreateModel ServerCreateModel { get; set; }

    [Required]
    public LocationChoiceModel LocationChoiceModel { get; set; }

    public int IpId { get; set; }
}

