using Data.Enums;
using Data.Models;

namespace Data.Entities.Pending;
public class RequestHost : BaseEntity
{
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }

    public ICollection<RequestHostIp> RequestHostIps { get; set; }

    public ICollection<RequestHostUser> RequestHostUsers { get; set; }

    public bool FilterRequestHost(RequestHostSearchModel model)
    {
        bool matchIpAssignmentTypes = model.Type != null ? this.Type == model.Type : true;
        bool matchStatus = model.Status != null ? this.Status == model.Status : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? this.ServerAllocationId == model.ServerAllocationId : true;

        return matchIpAssignmentTypes && matchStatus && matchServerAllocationId;
    }
}
