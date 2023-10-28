namespace Data.Enums;

public enum RoleType
{
    Customer = 1,
    Tech = 2,
    Sale = 3,
    Manager = 4,
    Admin = 5
}

public enum ColocationStatus
{
    Incomplete,
    Pending,
    Accepted,
    Denied,
    Ongoing,
    Stopped,
    Ended
}

public enum ColocationRequestType
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

public enum AdditionalServiceStatus
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

public enum ColocationSortCriteria
{
    Id
}
public enum ServerSortCriteria
{
    Id
}