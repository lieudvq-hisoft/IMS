namespace Data.Enums;

public enum RoleType
{
    Customer = 1,
    Tech = 2,
    Sale = 3,
    Manager = 4,
    Admin = 5
}

public enum RequestStatus
{
    Incomplete,
    Pending,
    Accepted,
    Denied,
    Ongoing,
    Stopped,
    Ended
}

public enum DeviceStatus
{
    Ongoing,
    Stopped,
    Ended
}

public enum RequestType
{
    New,
    Additional,
    Mixed
}

public enum IpType
{
    Host,
    Port,
    Additional,
    DNS,
    Gateway
}

public enum ServiceRequestStatus
{
    Pending,
    Accepted,
    Denied,
    Success,
}

public enum UserSortCriteria
{
    Email
}

public enum CustomerSortCriteria
{
    Id
}

public enum RequestSortCriteria
{
    Id
}
public enum ServerSortCriteria
{
    Id
}

public enum DeviceSortCriteria
{
    Id
}