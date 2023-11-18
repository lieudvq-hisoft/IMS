using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities.Pending;
public class RequestHostIp : BaseEntity
{
    public IpAssignmentTypes Type { get; set; }

    public int IpAddressId { get; set; }
    public virtual IpAddress IpAddress { get; set; }

    public int RequestHostId { get; set; }
    public virtual RequestHost RequestHost { get; set; }
}
