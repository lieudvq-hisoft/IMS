using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class RequestExpandLocation: BaseEntity
{
    public int RequestExpandId { get; set; }
    public RequestExpand RequestExpand { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }
}
