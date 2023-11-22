namespace Data.Entities;
public class IpSubnet : BaseEntity
{
    public int FirstOctet { get; set; }
    public int SecondOctet { get; set; }
    public int ThirdOctet { get; set; }
    public int FourthOctet { get; set; }
    public int SubnetMask { get; set; }

    public int? ParentNetworkId { get; set; }
    public IpSubnet? ParentNetwork { get; set; }

    public ICollection<IpSubnet> SubNets { get; } = new List<IpSubnet>();

    public ICollection<IpAddress> IpAddresses { get; set; }
}
