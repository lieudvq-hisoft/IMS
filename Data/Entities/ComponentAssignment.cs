using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class ComponentAssignment : BaseEntity
{
    public bool IsCurrent { get; set; }
    public string Model { get; set; }
    public string SerialNumber { get; set; }
    public DateTime DateInstalled { get; set; }
    public DateTime DateUninstalled { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }

    public int HardwareCategoryId { get; set; }
    public virtual ComponentCategory HardwareCategory { get; set; }
}
