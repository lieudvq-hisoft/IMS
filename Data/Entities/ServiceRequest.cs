using Data.Enums;

namespace Data.Entities;
public class ServiceRequest : BaseEntity
{
    public int Quantity { get; set; }
    public ServiceRequestStatus Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public bool IsDelegated { get; set; }

    public int RequestId { get; set; }
    public virtual Request Request { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }
}
