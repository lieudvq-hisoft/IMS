using Data.Enums;
using Data.Models;

namespace Data.Entities;
public class RequestHost : BaseEntity
{
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int Quantity { get; set; }
    public bool IsRemoval { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public string? InspectionReportFilePath { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestHostIp> RequestHostIps { get; set; }

    public ICollection<RequestHostUser> RequestHostUsers { get; set; }

    public bool FilterRequestHost(RequestHostSearchModel model)
    {
        bool matchIpAssignmentTypes = model.Type != null ? Type == model.Type : true;
        bool matchStatus = model.Status != null ? Status == model.Status : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? ServerAllocationId == model.ServerAllocationId : true;
        bool matchCustomer = model.CustomerId != null ? ServerAllocation.CustomerId == model.CustomerId : true;
        bool matchPurpose = model.Purpose != null ? RequestHostIps.Select(x => x.IpAddress).Any(x => x.Purpose == model.Purpose) : true;

        return matchIpAssignmentTypes && matchStatus && matchServerAllocationId && matchCustomer && matchPurpose;
    }
}
