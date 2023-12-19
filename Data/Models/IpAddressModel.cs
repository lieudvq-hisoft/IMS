using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class IpAddressModel
{
    public int Id { get; set; }
    public string Address { get; set; }
    public bool Blocked { get; set; }
    public bool IsReserved { get; set; }
    public string Purpose { get; set; }
    public string AssignmentType { get; set; }
    public string Reason { get; set; }
    public int? Capacity { get; set; }
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
    public string Reason { get; set; }

    public int IpSubnetId { get; set; }
}

public class IpAddressIdListModel
{
    [Required]
    public string Reason { get; set; }

    [Required]
    public List<int> IpAddressIds { get; set; }
}

public class IpAddressChangePurposeModel
{
    [Required]
    public IpPurpose Purpose { get; set; }

    [Required]
    public List<int> IpAddressIds { get; set; }
}

public class IpAddressSearchModel
{
    public string? Address { get; set; }
    public bool? IsAvailable { get; set; }
    public bool? IsAssigned { get; set; }
    public bool? IsBlocked { get; set; }
    public bool? IsReserved { get; set; }
}

public class IpAssignmentModel
{
    public int Id { get; set; }
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public int? Capacity { get; set; }
    public int IpAddressId { get; set; }
    public int ServerAllocationId { get; set; }
}