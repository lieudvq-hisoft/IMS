using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class DeviceLocation : BaseEntity
{
    public bool IsMoveout { get; set; }

    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }

    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
}
