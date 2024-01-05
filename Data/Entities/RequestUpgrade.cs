using Data.Enums;
using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;
public class RequestUpgrade : BaseEntity
{
    public string? Description { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Upgrade;
    public RequestStatus Status { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }

    public int ComponentId { get; set; }
    public Component? Component { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment>? RequestUpgradeAppointments { get; set; }
    public ICollection<RequestUpgradeUser>? RequestUpgradeUsers { get; set; }

    public bool FilterRequestUpgrade(RequestUpgradeSearchModel searchModel)
    {
        var matchSearchValue = (MyFunction.ConvertToUnSign(ServerAllocation.Name ?? "").IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0);

        bool matchId = searchModel.Id != null ? Id == searchModel.Id : true;
        bool matchComponentId = searchModel.ComponentId != null ? ComponentId == searchModel.ComponentId : true;
        bool matchServerAllocationId = searchModel.ServerAllocationId != null ? ServerAllocationId == searchModel.ServerAllocationId : true;
        bool matchStatus = searchModel.Statuses != null ? searchModel.Statuses.Contains(Status) : true;
        bool matchCustomer = searchModel.CustomerId != null ? ServerAllocation.CustomerId == searchModel.CustomerId : true;
        bool matchUser = searchModel.UserId != null ? RequestUpgradeUsers.Any(x => x.UserId == searchModel.UserId) : true;
        bool matchAppointment = searchModel.AppointmentId != null ? RequestUpgradeAppointments.Any(x => x.AppointmentId == searchModel.AppointmentId) : true;

        return matchSearchValue && matchId && matchComponentId && matchServerAllocationId && matchStatus && matchCustomer && matchUser && matchAppointment;
    }
}
