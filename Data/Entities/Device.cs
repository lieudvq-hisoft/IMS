using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class Device : BaseEntity
{
    public string DeviceName { get; set; }
    public string DeviceType { get; set; }
    public string DeviceDetail { get; set; }
    //status enum later
}
