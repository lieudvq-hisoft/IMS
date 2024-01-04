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

    //public bool FilterRequestUpgrade(RequestExpandSearchModel searchModel)
    //{
    //    bool matchId = searchModel.Id != null ? Id == searchModel.Id : true;
    //    bool matchServerAllocationId = searchModel.ServerAllocationId != null ? ServerAllocationId == searchModel.ServerAllocationId : true;
    //    bool matchStatus = searchModel.Statuses != null ? searchModel.Statuses.Contains(Status) : true;
    //    bool matchUser = searchModel.UserId != null ? RequestExpandUsers.Any(x => x.UserId == searchModel.UserId) : true;
    //    bool matchCustomer = searchModel.CustomerId != null ? ServerAllocation.CustomerId == searchModel.CustomerId : true;
    //    bool matchAppointment = searchModel.AppointmentId != null ? RequestExpandAppointments.Any(x => x.AppointmentId == searchModel.AppointmentId) : true;
    //    bool isRemoval = ForRemoval == searchModel.IsRemoval || searchModel.IsRemoval == null;

    //    return matchId && matchServerAllocationId && matchStatus && matchUser && matchCustomer && matchAppointment && isRemoval;
    //}
}
