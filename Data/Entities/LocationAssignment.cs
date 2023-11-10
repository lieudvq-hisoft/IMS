using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class LocationAssignment : BaseEntity
{
    public int RequestId { get; set; }
    public virtual Request Request { get; set; }

    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
}
