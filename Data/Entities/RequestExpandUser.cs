using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class RequestExpandUser: BaseEntity
{
    public int RequestExpandId { get; set; }
    public RequestExpand RequestExpand { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
