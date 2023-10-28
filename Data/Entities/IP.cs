﻿using Data.Enums;

namespace Data.Entities;

public class Ip : BaseEntity
{
    public int Address { get; set; }
    public bool Blocked { get; set; }
    public IpType Type { get; set; }
    public bool IsReserved { get; set; }

    public int NetworkId { get; set; }
    public virtual Network Network { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }

    public string DisplayIp()
    {
        return $"{Network.FirstOctet}.{Network.SecondOctet}.{Network.ThirdOctet}.{Address}/{Network.SubnetMask}";
    }
}
