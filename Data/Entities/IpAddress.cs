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

    public bool Filter(IpAddressSearchModel searchModel)
    {
        var matchAddress = searchModel.Address != null ? Address.Contains(searchModel.Address) : true;
        var available = searchModel.IsAvailable != null ? IsAvailable() == searchModel.IsAvailable : true;
        var assigned = searchModel.IsAssigned != null ? IsAssigned() == searchModel.IsAssigned : true;
        var isReserved = searchModel.IsReserved != null ? IsReserved == searchModel.IsReserved : true;
        var blocked = searchModel.IsBlocked != null ? Blocked == searchModel.IsBlocked : true;
        var matchRequestHost = searchModel.RequestHostId != null ? RequestHostIps.Any(x => x.RequestHostId == searchModel.RequestHostId) : true;
        var matchServer = searchModel.ServerAllocationId != null ? IpAssignments.Any(x => x.ServerAllocationId == searchModel.ServerAllocationId) : true;

        return matchAddress && available && assigned && isReserved && blocked && matchRequestHost;
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