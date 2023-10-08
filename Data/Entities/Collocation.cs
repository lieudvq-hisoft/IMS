using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Collocation : BaseEntity
{
    public bool IsApproved { get; set; }
    public string? Note { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public int ServerId { get; set; }
    public virtual Server Server { get; set; }
}
