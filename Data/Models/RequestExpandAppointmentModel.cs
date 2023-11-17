using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestExpandAppointmentModel
{
    public int RequestExpandId { get; set; }
    public int AppointmentId { get; set; }
}

public class RequestExpandAppointmentCreateModel
{
    [Required]
    [GreaterThanZero]
    public int RequestExpandId { get; set; }
    [Required]
    [GreaterThanZero]
    public int AppointmentId { get; set; }
}

public class RequestExpandAppointmentSearchModel
{
    public int? Id { get; set; } = null;
}

