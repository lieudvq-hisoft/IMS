using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServerModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdate { get; set; }
    public RequestStatus? Status { get; set; }
    public string IpAddress { get; set; }
    public int Size { get; set; }
    public int Power { get; set; }
    public string Customer { get; set; }
}

public class ServerSearchModel
{
    public RequestStatus? Status { get; set; }
}

public class ServerDetailModel
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Status { get; set; }
    public string Model { get; set; }
    public int BasePower { get; set; }
    public int Power { get; set; }
    public int BaseSize { get; set; }
    public int Size { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateAllocate { get; set; }
    public string SerialNumber { get; set; }
    public string Location { get; set; }
    public string IpAddress { get; set; }

    public List<RequestExtendHistoryModel> RequestExtendHistoryModel { get; set; }
    public List<ServiceRequestModel> ServiceRequests { get; set; }

}

public class ServerCreateModel
{
    [Required]
    public string Type { get; set; }
    [Required]
    public int NumberOfPort { get; set; }
    [Required]
    public int Size { get; set; }
    [Required]
    public int BasePower { get; set; }
    [Required]
    public string SerialNumber { get; set; }
    [Required]
    public string Model { get; set; }
}
