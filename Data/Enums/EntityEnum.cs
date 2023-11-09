namespace Data.Enums;

public enum RoleType
{
    Tech = 1,
    Sale = 2,
    Manager = 3,
    Admin = 4
}

public enum RequestStatus
{
    Incomplete,
    Pending,
    Accepted,
    Denied,
    Stopped,
    Ended
}

public enum IpAssignmentType
{
    Master,
    Additional,
    Port
}

public enum ServiceRequestStatus
{
    Pending,
    Accepted,
    Denied,
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

public enum AppointmentSortCriteria
{
    Id
}
