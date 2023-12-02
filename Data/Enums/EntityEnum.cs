namespace Data.Enums;

public enum RoleType
{
    Tech = 1,
    Sale = 2,
    Manager = 3,
    Admin = 4
}

public enum ComponentType
{
    Upgrade,
    Change
}

public enum ServerAllocationStatus
{
    Working,
    Pausing,
    Removed
}

public enum IpPurpose
{
    Host,
    Network,
    Broadcast,
    Dns,
    Gateway,
}

public enum RequestUserAction
{
    Evaluate,
    Execute,
    Process
}

public enum IpAssignmentTypes
{
    Additional,
    Port,
    Master,
}

public enum RequestStatus
{
    Waiting,
    Accepted,
    Denied,
    Success,
    Failed
}

public enum RequestHostStatus
{
    Waiting,
    Accepted,
    Denied,
    Processed,
    Success,
    Failed
}

public enum RemovalStatus
{
    Accepted,
    Success,
    Failed
}

public enum RequestType
{
    Upgrade,
    Expand,
    Host,
    Other
}

public enum LocationAssignmentSortingCriteria
{
    Id,
    ServiceId
}

public enum BaseSortCriteria
{
    Id
}

public enum RequestSortCriteria
{
    Id,
    OrderId,
    ServiceId
}

public enum ServerHardwareConfigSortCriteria
{
    Id,
    ServerAllocationId,
    ComponentId
}

public enum RequestUpgradeSortCriteria
{
    Id,
    CustomerId,
    ComponentId
}
