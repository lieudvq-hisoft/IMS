using System;
namespace Data.Enums;

public enum RoleType
{
    Customer = 1,
    It = 2,
    Staff = 3,
    Manager = 4,
    Admin = 5
}

public enum DeviceStatus
{
    Running,
    Shutdown
}

public enum CollocationStatus
{
    Pending,
    Success,
    Unsuccess
}

public enum AdditionalServiceStatus
{
    Pending,
    Success,
    Unsuccess
}

public enum UserSortCriteria
{
    Email
}

public enum CustomerSortCriteria
{
    Id
}

public enum CollocationSortCriteria
{
    Id
}