using Data.Models;

namespace Data.Entities;
public class Incident : BaseEntity
{
    public string Description { get; set; }
    public string? Solution { get; set; }
    public bool IsResolved { get; set; }
    public bool IsResolvByClient { get; set; }
    public string? Document { get; set; }
    public bool PausingRequired { get; set; }
    public DateTime? DateResolved { get; set; }

    public ICollection<IncidentUser>? IncidentUsers { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<IncidentAppointment>? IncidentAppointments { get; set; }

    public bool Filter(IncidentSearchModel searchModel)
    {
        var matchIsReserved = searchModel.IsResolved != null ? IsResolved == searchModel.IsResolved : true;
        var matchResolvByClient = searchModel.IsResolvByClient != null ? IsResolvByClient == searchModel.IsResolvByClient : true;
        var matchServer = searchModel.ServerAllocationId != null ? ServerAllocationId == searchModel.ServerAllocationId : true;
        var isAssign = searchModel.IsAssigned != null ? IncidentAppointments?.Select(x => x.Appointment).Any(x => x.Status == Enums.RequestStatus.Accepted) == searchModel.IsAssigned || IsResolved : true;
        var matchCustomer = searchModel.CustomerId != null ? ServerAllocation?.CustomerId == searchModel.CustomerId : true;
        var matchUser = searchModel.UserId != null ? IncidentUsers?.Any(x => x.UserId == searchModel.UserId) : true;
        var matchAppointment = searchModel.AppointmentId != null ? IncidentAppointments?.Any(x => x.AppointmentId == searchModel.AppointmentId) : true;

        return matchIsReserved && matchResolvByClient && matchServer && isAssign && matchCustomer && matchUser == true && matchAppointment == true;
    }
}
