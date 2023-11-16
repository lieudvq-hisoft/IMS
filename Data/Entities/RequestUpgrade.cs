using Data.Enums;

namespace Data.Entities;
public class RequestUpgrade : BaseEntity
{
    public string Description { get; set; }
    public int Capacity { get; set; }

    public RequestStatus Status { get; set; }
    public string? InspectionReportFilePath { get; set; }

    public int ComponentId { get; set; }
    public Component Component { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment> RequestUpgradeAppointments { get; set; }
    public ICollection<RequestUpgradeUser> RequestUpgradeUsers { get; set; }
}
