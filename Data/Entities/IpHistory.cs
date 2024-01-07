using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class IpHistory : BaseEntity
{
    public DateTime DateExecuted { get; set; }
    public bool IsBlock { get; set; }
    public string Reason { get; set; }

    public int IpAddressId { get; set; }
    public IpAddress IpAddress { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
