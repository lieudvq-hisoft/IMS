using Data.Enums;
using Data.Models;

namespace Data.Entities;
public class RequestUpgrade : BaseEntity
{
    public string? Information { get; set; }
    public int Capacity { get; set; }
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
        bool matchId = model.Id != null ? this.Id == model.Id : true;
        bool matchComponentId = model.ComponentId != null ? this.ComponentId == model.ComponentId : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? this.ServerAllocationId == model.ServerAllocationId : true;

        return matchId && matchComponentId && matchServerAllocationId;
    }
}
