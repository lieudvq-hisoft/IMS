namespace Data.Entities;
public class Service : BaseEntity
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
}
