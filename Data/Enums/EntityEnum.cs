﻿namespace Data.Enums;

public enum RoleType
{
    Tech = 1,
    Sale = 2,
    Manager = 3,
    Admin = 4
}

public enum OrderStatus
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

public enum ServiceStatus
{
    Incomplete,
    Pending,
    Accepted,
    Denied,
}

public enum UserSortCriteria
{
    Email
}

public enum LocationAssignmentSortingCriteria
{
    ServiceId
}

public enum CustomerSortCriteria
{
    Id
}

public enum OrderSortCriteria
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

public enum RequestSortCriteria
{
    Id,
    OrderId,
    ServiceId
}
