using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class Server : BaseEntity
{
    public string ServerDetail { get; set; }
    public int Device_Id { get; set; }
    public virtual required Device Device { get; set; }
}
