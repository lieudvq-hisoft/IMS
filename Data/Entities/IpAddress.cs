using Data.Entities.Pending;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Data.Enums;

namespace Data.Entities;

public class IpAddress
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public string Address { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }
    public IpPurpose Purpose { get; set; }

    public int IpSubnetId { get; set; }
    public virtual IpSubnet IpSubnet { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
    public virtual ICollection<RequestHostIp> RequestHostIps { get; set; }
}
