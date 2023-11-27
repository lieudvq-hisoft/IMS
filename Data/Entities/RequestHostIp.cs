using Data.Enums;

namespace Data.Entities.Pending;
public class RequestHostIp : BaseEntity
{
    public int IpAddressId { get; set; }
    public virtual IpAddress IpAddress { get; set; }

    public int RequestHostId { get; set; }
    public virtual RequestHost RequestHost { get; set; }
}
