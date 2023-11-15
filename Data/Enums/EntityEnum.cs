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
    Incomplete,
    Pending,
    Accepted,
    Denied,
    Stopped,
    Ended
}

public enum ServiceType
{
    Location,
    Expand,
    Ip,
    MasterIp,
    Port,
    PortPower,
    Power,
    Component,
    Appointment
}

public enum IpAssignmentTypes
{
    Master,
    Additional,
    Port
}

public enum RequestStatus
{
    Pending,
    Accepted,
    Denied,
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
