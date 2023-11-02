namespace Data.Entities;
public class SaleApproval : BaseEntity
{
    public Guid SaleId { get; set; }
    public virtual User Sale { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
}
