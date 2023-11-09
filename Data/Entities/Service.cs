namespace Data.Entities;
public class Service : BaseEntity
{
    public string Name { get; set; }
    public string Type { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }

    public virtual ICollection<LocationService> LocationServices { get; set; } 

    public virtual ICollection<HardwareService> HardwareServices { get; set; }

    public virtual ICollection<IpService> IpServices { get; set; }
}
