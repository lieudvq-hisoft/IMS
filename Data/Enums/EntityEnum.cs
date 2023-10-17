﻿using System;
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

public enum ColocationStatus
{
    Incomplete,
    Pending,
    Accepted,
    Denied,
    Ongoing,
    Stopped
}

public enum ColocationRequestType
{
    New,
    Additional,
    Mixed
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