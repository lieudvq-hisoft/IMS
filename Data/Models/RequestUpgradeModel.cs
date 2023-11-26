using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestUpgradeModel
{
    public int Id { get; set; }
    public string Information { get; set; }
    public int Capacity { get; set; }
    public string Status { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public RequestType RequestType { get; set; }
    public int ComponentId { get; set; }
    public int ServerAllocationId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public AppointmentResultModel? SucceededAppointment { get; set; }
    public ComponentResultModel? Component { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
}

public class RequestUpgradeResultModel
{
    public int Id { get; set; }
    public string Information { get; set; }
    public int Capacity { get; set; }
    public string Status { get; set; }
    public RequestType RequestType { get; set; }
    public int ComponentId { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestUpgradeCreateModel
{
    [Required]
    public string Information { get; set; }

    [Required]
    public int Capacity { get; set; }

    [Required]
    public int ComponentId { get; set; }

    [Required]
    public int ServerAllocationId { get; set; }
}

public class RequestUpgradeCreateBulkModel
{
    [Required]
    public List<RequestUpgradeCreateModel> RequestUpgradeCreateModels { get; set; }
}

public class RequestUpgradeEvaluateBulkModel
{
    [Required]
    public List<int> RequestUpgradeIds { get; set; }
}

public class RequestUpgradeCompleteBulkModel
{
    [Required]
    public List<int> RequestUpgradeIds { get; set; }
}

public class RequestUpgradeUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Information { get; set; }

    [Required]
    public int Capacity { get; set; }

    //[Required]
    //public int ComponentId { get; set; }

    //[Required]
    //public int ServerAllocationId { get; set; }
}

public class RequestUpgradeSearchModel
{
    public int? Id { get; set; }
    public int? ComponentId { get; set; }
    public int? ServerAllocationId { get; set; }
}
