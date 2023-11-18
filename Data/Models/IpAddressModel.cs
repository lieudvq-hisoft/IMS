using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class IpAddressModel
{
    public int Address { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }

    public int IpSubnetId { get; set; }
}
public class IpAddressSearchModel
{
    public int? Id { get; set; } = null;
}

