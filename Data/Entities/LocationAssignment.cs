using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class LocationAssignment : BaseEntity
{
    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }

    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
}
