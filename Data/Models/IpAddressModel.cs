namespace Data.Models;
public class IpAddressModel
{
    public int Id { get; set; }
    public string Address { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }
    public string Purpose { get; set; }
    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public CustomerResultModel? Customer { get; set; }

    public int IpSubnetId { get; set; }
}

public class IpAddressResultModel
{
    public int Id { get; set; }
    public string Address { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }
    public string Purpose { get; set; }

    public int IpSubnetId { get; set; }
}

public class IpAddressSearchModel
{
    public string? Address { get; set; }
    public bool? IsAvailable { get; set; }
}

