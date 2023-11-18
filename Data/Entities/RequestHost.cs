using Data.Enums;

namespace Data.Entities.Pending;
public class RequestHost : BaseEntity
{
    public IpAssignmentTypes Type { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;

    public ICollection<RequestHostAppointment> RequestHostAppointments { get; set; }

    public ICollection<RequestHostIp> RequestHostIps { get; set; }

    public ICollection<RequestHostUser> RequestHostUsers { get; set; }
}
