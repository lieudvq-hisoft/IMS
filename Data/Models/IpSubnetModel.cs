﻿using Data.Entities;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class IpSubnetModel
{
    public int FirstOctet { get; set; }
    public int SecondOctet { get; set; }
    public int ThirdOctet { get; set; }
    public int FourthOctet { get; set; }
    public int PrefixLength { get; set; }
    public string? Note { get; set; }

    public int ParentNetworkId { get; set; }
}

public class IpRangeCreateModel
{
    [IsIpV4]
    [Required]
    public string IpAddresss { get; set; }

    [Required]
    [Range(16, 24)]
    public int PrefixLength { get; set; }

    public string? Note { get; set; }

    public List<IpSubnetCreateModel?>? IpSubnets { get; set; }
}

public class IpSubnetCreateModel
{
    [IsIpV4]
    [Required]
    public string IpAddresss { get; set; }

    public string? Note { get; set; }

    [Required]
    [Range(24, 32)]
    public int PrefixLength { get; set; }
}

public class IpSubnetSearchModel
{
    public int? Id { get; set; } = null;
}