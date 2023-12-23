namespace Data.Entities;
public class RequestHostIp : BaseEntity
{
    public double? Capacity { get; set; }

    public int IpAddressId { get; set; }
    public virtual IpAddress IpAddress { get; set; }

    public int RequestHostId { get; set; }
    public virtual RequestHost RequestHost { get; set; }
}
