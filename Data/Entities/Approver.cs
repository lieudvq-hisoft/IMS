namespace Data.Entities;
public class Approver : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
}
