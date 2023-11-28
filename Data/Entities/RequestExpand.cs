using Data.Enums;
using Data.Models;

namespace Data.Entities;
public class RequestExpand : BaseEntity
{
    public RequestStatus Status { get; set; }
    public RemovalStatus? RemovalStatus { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Expand;
    public int? Size { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestExpandLocation>? RequestExpandLocations { get; set; }
    public ICollection<RequestExpandUser>? RequestExpandUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }

    public bool FilterRequestUpgrade(RequestExpandSearchModel model)
    {
        bool matchId = model.Id != null ? this.Id == model.Id : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? this.ServerAllocationId == model.ServerAllocationId : true;
        bool matchStatus = model.Statuses != null ? model.Statuses.Contains(this.Status) : true;

        return matchId && matchServerAllocationId && matchStatus;
    }
}
