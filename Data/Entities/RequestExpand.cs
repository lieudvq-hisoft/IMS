﻿using Data.Enums;

namespace Data.Entities;
public class RequestExpand : BaseEntity
{
    public int Power { get; set; }
    public RequestStatus Status { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestExpandLocation> RequestExpandLocations { get; set; }
    public ICollection<RequestExpandUser> RequestExpandUsers { get; set; }
    public ICollection<RequestExpandAppointment> RequestExpandAppointments { get; set; }
}
