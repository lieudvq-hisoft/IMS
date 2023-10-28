using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class ColocationHistory : BaseEntity
{
    public DateTime DateStop { get; set; }
    public DateTime DateStart { get; set; }
    public bool IsActive { get; set; }

    public int ColocationId { get; set; }
    public virtual Colocation Colocation { get; set; }

    public bool OutOfDuration()
    {
        return DateTime.Compare(DateStop, DateTime.Now) > 0;
    }
}
