using Data.Enums;
using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;
public class RequestHost : BaseEntity
{
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int Quantity { get; set; }
    public List<double>? Capacities { get; set; }
    public bool IsRemoval { get; set; }
    public bool IsUpgrade { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public bool DocumentConfirm { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestHostIp> RequestHostIps { get; set; }

    public ICollection<RequestHostUser> RequestHostUsers { get; set; }

    public bool FilterRequestHost(RequestHostSearchModel searchModel)
    {
        var matchSearchValue = (MyFunction.ConvertToUnSign(ServerAllocation.Name ?? "").IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0);

        bool matchIpAssignmentTypes = searchModel.Type != null ? Type == searchModel.Type : true;
        bool matchStatus = searchModel.Statuses != null ? searchModel.Statuses.Contains(Status) : true;
        bool matchMasterIp = searchModel.MasterIp != null ? ServerAllocation.MasterIpAddress.Contains(searchModel.MasterIp) : true;
        bool matchCustomer = searchModel.Customer != null ? MyFunction.MatchString(ServerAllocation.Customer.CompanyName, searchModel.Customer) : true;
        bool matchPurpose = searchModel.IsRemoved != null ? IsRemoval == searchModel.IsRemoved : true;
        bool matchServer = searchModel.ServerAllocationId != null ? ServerAllocationId == searchModel.ServerAllocationId : true;
        bool matchCustomerId = searchModel.CustomerId != null ? ServerAllocation.CustomerId == searchModel.CustomerId : true;
        bool matchUser = searchModel.UserId != null ? RequestHostUsers.Any(x => x.UserId == searchModel.UserId) : true;

        return matchSearchValue && matchIpAssignmentTypes && matchStatus && matchMasterIp && matchCustomer && matchPurpose && matchServer && matchCustomerId && matchUser;
    }
}
