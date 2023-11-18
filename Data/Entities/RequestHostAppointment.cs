﻿using Data.Enums;

namespace Data.Entities.Pending;
public class RequestHostAppointment : BaseEntity
{
    public IpAssignmentTypes Type { get; set; }

    public int RequestHostId { get; set; }
    public virtual RequestHost RequestHost { get; set; }

    public int AppointmentId { get; set; }
    public virtual Appointment Appointment { get; set; }
}
