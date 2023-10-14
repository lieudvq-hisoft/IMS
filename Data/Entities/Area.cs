using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Area: BaseEntity
{
    public int RowCount { get; set; }
    public int ColumnCount { get; set; }

    public virtual ICollection<Rack> Racks { get; set; }
}
