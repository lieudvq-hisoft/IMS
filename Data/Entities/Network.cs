namespace Data.Entities;
public class Network : BaseEntity
{
    public int FirstOctet { get; set; }
    public int SecondOctet { get; set; }
    public int ThirdOctet { get; set; }
    public int SubnetMask { get; set; }

    public virtual ICollection<Ip> Ips { get; set; }
}
