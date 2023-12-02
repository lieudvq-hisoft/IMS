using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class IpSubnetModel
{
    public int Id { get; set; }
    public int FirstOctet { get; set; }
    public int SecondOctet { get; set; }
    public int ThirdOctet { get; set; }
    public int FourthOctet { get; set; }
    public int PrefixLength { get; set; }
    public string? Note { get; set; }

    public int ParentNetworkId { get; set; }
    public List<int> SubnetIds { get; set; }
}

public class IpSubnetResultModel
{
    public int Id { get; set; }
    public int FirstOctet { get; set; }
    public int SecondOctet { get; set; }
    public int ThirdOctet { get; set; }
    public int FourthOctet { get; set; }
    public int PrefixLength { get; set; }
    public string? Note { get; set; }

    public int ParentNetworkId { get; set; }
    public List<int> SubnetIds { get; set; }
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

public class CreateSubnetModel
{
    [Required]
    public List<IpSubnetCreateModel> IpSubnets { get; set; }
}

public class NextAddressModel
{
    [IsIpV4]
    [Required]
    public string IpAddresss { get; set; }

    [Required]
    public int PrefixLength { get; set; }
}

public class IpSubnetCreateModel
{
    [IsIpV4]
    [Required]
    public string IpAddresss { get; set; }

    public string? Note { get; set; }

    [Required]
    [Range(16, 32)]
    public int PrefixLength { get; set; }
}

public class SuggestAdditionalIpModel
{
    [Required]
    public int ServerAllocationId { get; set; }

    [Required]
    public int Quantity { get; set; }
}

public class SuggestAdditionalIpResultModel
{
    public List<IpSubnetResultModel> IpSubnets { get; set; }

    public List<IpAddressResultModel> IpAddresses { get; set; }
}

public class IpSubnetSearchModel
{
    public int? Id { get; set; } = null;
}