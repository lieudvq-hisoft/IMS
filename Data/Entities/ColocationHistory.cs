using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class ColocationHistory : BaseEntity
{
    public DateTime DateExtended { get; set; }

    public int ColocationId { get; set; }
    public virtual Colocation Colocation { get; set; }
}
