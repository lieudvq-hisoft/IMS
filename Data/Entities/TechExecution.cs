namespace Data.Entities;
public class TechExecution : BaseEntity
{
    public Guid TechId { get; set; }
    public virtual User Tech { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
}
