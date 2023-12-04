using Data.Enums;
using Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class IpAddress
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public string Address { get; set; }
    public string? Reason { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }
    public IpPurpose Purpose { get; set; }

    public int IpSubnetId { get; set; }
    public virtual IpSubnet IpSubnet { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }
    public virtual ICollection<RequestHostIp> RequestHostIps { get; set; }

    public bool IsAvailable()
    {
        return !Blocked && !IsReserved && !IpAssignments.Any() && !RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed);
    }

    public bool Filter(IpAddressSearchModel searchModel)
    {
        var matchAddress = searchModel.Address != null ? Address.Contains(searchModel.Address) : true;
        var available = searchModel.IsAvailable != null ? IsAvailable() == searchModel.IsAvailable : true;
        var assigned = searchModel.IsAssigned != null ? IpAssignments.Any() == searchModel.IsAssigned : true;
        var isReserved = searchModel.IsReserved != null ? IsReserved == searchModel.IsReserved : true;
        var blocked = searchModel.IsBlocked != null? Blocked == searchModel.IsBlocked : true;
        return matchAddress && available && assigned && isReserved && blocked;
    }
}
