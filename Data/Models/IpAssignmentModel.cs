using Data.Enums;

namespace Data.Models;
public class IpAssignmentModel
{
    public int Id { get; set; }
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public int IpAddressId { get; set; }
    public int ServerAllocationId { get; set; }
}

public class IpAssignmentResultModel
{
    public int Id { get; set; }
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public int IpAddressId { get; set; }
    public int ServerAllocationId { get; set; }
}


public class IpAssignmentSearchModel
{
    public int? Id { get; set; } = null;
}

public class IpAssignmentCreateModel
{
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public int IpAddressId { get; set; }
    public int ServerAllocationId { get; set; }
}

public class IpAssignmentUpdateModel
{
    public int Id { get; set; }
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public int IpAddressId { get; set; }
    public int ServerAllocationId { get; set; }
}