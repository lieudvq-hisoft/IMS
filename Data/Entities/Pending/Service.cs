using Data.Enums;

namespace Data.Entities;
public class Service : BaseEntity
{
    public string Name { get; set; }
    public ServiceType Type { get; set; }
    public bool IsDeletable { get; set; }

    public virtual ICollection<Request> Requests { get; set; }
}
