namespace Data.Models;
public class IpSubnetModel
{
    public int FirstOctet { get; set; }
    public int SecondOctet { get; set; }
    public int ThirdOctet { get; set; }
    public int SubnetMask { get; set; }

    public int ParentNetworkId { get; set; }
}

public class IpSubnetSearchModel
{
    public int? Id { get; set; } = null;
}