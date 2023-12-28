using Data.Enums;
using Data.Models;

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

    public bool FilterRequestUpgrade(RequestUpgradeSearchModel model)
    {
        bool matchId = model.Id != null ? Id == model.Id : true;
        bool matchComponentId = model.ComponentId != null ? ComponentId == model.ComponentId : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? ServerAllocationId == model.ServerAllocationId : true;
        bool matchStatus = model.Statuses != null ? model.Statuses.Contains(Status) : true;
        bool matchCustomer = model.CustomerId != null ? model.CustomerId == model.CustomerId : true;
        bool matchUser = model.UserId != null ? RequestUpgradeUsers.Any(x => x.UserId == model.UserId) : true;
        bool matchAppointment = model.AppointmentId != null ? RequestUpgradeAppointments.Any(x => x.AppointmentId == model.AppointmentId) : true;

        return matchId && matchComponentId && matchServerAllocationId && matchStatus && matchCustomer && matchUser && matchAppointment;
    }
}
