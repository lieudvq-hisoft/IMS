using Data.Enums;
using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;
public class RequestExpand : BaseEntity
{
    public RequestStatus Status { get; set; }
    public bool ForRemoval { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Expand;
    public int? Size { get; set; }
    public int? SuccessExpandAppointmentId { get; set; }
    public DateTime? RemovalDateCreated { get; set; }
    public DateTime? RemovalDateUpdated { get; set; }
    public string? ChosenLocation { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestExpandLocation>? RequestExpandLocations { get; set; }
    public ICollection<RequestExpandUser>? RequestExpandUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }

    public bool FilterRequestUpgrade(RequestExpandSearchModel model)
    {
        var matchSearchValue = (MyFunction.ConvertToUnSign(ServerAllocation.Name ?? "").IndexOf(MyFunction.ConvertToUnSign(model.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0);

        bool matchId = model.Id != null ? Id == model.Id : true;
        bool matchServerAllocationId = model.ServerAllocationId != null ? ServerAllocationId == model.ServerAllocationId : true;
        bool matchStatus = model.Statuses != null ? model.Statuses.Contains(Status) : true;
        bool matchUser = model.UserId != null ? RequestExpandUsers.Any(x => x.UserId == model.UserId) : true;
        bool matchCustomer = model.CustomerId != null ? ServerAllocation.CustomerId == model.CustomerId : true;
        bool matchAppointment = model.AppointmentId != null ? RequestExpandAppointments.Any(x => x.AppointmentId == model.AppointmentId) : true;
        bool isRemoval = ForRemoval == model.IsRemoval || model.IsRemoval == null;

        return matchSearchValue && matchId && matchServerAllocationId && matchStatus && matchUser && matchCustomer && matchAppointment && isRemoval;
    }
}
