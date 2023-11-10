using Data.Enums;

namespace Data.Entities;
public class ServiceType : BaseEntity
{
    public string Name { get; set; }
    public ServiceCategory Type { get; set; }

    public virtual ICollection<Service> Services { get; set; }
}
