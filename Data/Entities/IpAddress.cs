using Data.Enums;
using Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

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

    public bool IsAssigned()
    {
        return IpAssignments.Any() && !RequestHostIps.Select(x => x.RequestHost).Any(x => x.Status == RequestHostStatus.Waiting || x.Status == RequestHostStatus.Accepted || x.Status == RequestHostStatus.Processed); ;
    }

    public bool Filter(IpAddressSearchModel model)
    {
        var matchAddress = model.Address != null ? Address.Contains(model.Address) : true;
        var matchAssignmentType = model.AssignmentTypes != null ? model.AssignmentTypes.Contains(IpAssignments.FirstOrDefault()?.Type) : true;
        var available = model.IsAvailable != null ? IsAvailable() == model.IsAvailable : true;
        var assigned = model.IsAssigned != null ? IsAssigned() == model.IsAssigned : true;
        var isReserved = model.IsReserved != null ? IsReserved == model.IsReserved : true;
        var blocked = model.IsBlocked != null ? Blocked == model.IsBlocked : true;
        var matchRequestHost = model.RequestHostId != null ? RequestHostIps.Any(x => x.RequestHostId == model.RequestHostId) : true;
        var matchServer = model.ServerAllocationId != null ? IpAssignments.Any(x => x.ServerAllocationId == model.ServerAllocationId) : true;
        var matchSubnet = model.SubnetId != null ? IpSubnetId == model.SubnetId : true;
        var matchPurpose = model.Purposes != null ? model.Purposes.Contains(x.Purpose) : true;

        return matchAddress && matchAssignmentType && available && assigned && isReserved && blocked && matchRequestHost && matchServer && matchSubnet && matchPurpose;
    }

    public static string GetDefaultSubnetMask(string ipAddressString)
    {
        IPAddress ipAddress;
        if (IPAddress.TryParse(ipAddressString, out ipAddress) && ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
        {
            byte[] addressBytes = ipAddress.GetAddressBytes();
            int firstByte = addressBytes[0];

            if (IsClassA(firstByte))
            {
                return "255.0.0.0";
            }
            else if (IsClassB(firstByte))
            {
                return "255.255.0.0";
            }
            else if (IsClassC(firstByte))
            {
                return "255.255.255.0";
            }
            else
            {
                return "Unknown";
            }
        }
        else
        {
            throw new Exception("Invalid IPv4 Address");
        }
    }

    static bool IsClassA(int firstByte)
    {
        return firstByte >= 1 && firstByte <= 126;
    }

    static bool IsClassB(int firstByte)
    {
        return firstByte >= 128 && firstByte <= 191;
    }

    static bool IsClassC(int firstByte)
    {
        return firstByte >= 192 && firstByte <= 223;
    }
}

public class IpAddressComparer : IEqualityComparer<IpAddress>
{
    public bool Equals(IpAddress x, IpAddress y)
    {
        return x != null && y != null && x.Address == y.Address;
    }

    public int GetHashCode(IpAddress obj)
    {
        return obj.Id.GetHashCode();
    }
}