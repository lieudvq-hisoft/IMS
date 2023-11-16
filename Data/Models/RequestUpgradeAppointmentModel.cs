using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestUpgradeAppointmentModel
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeAppointmentCreateModel
{
    [Required]
    [GreaterThanZero]
    public int AppointmentId { get; set; }
    [Required]
    [GreaterThanZero]
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeAppointmentUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }
    [Required]
    [GreaterThanZero]
    public int AppointmentId { get; set; }
    [Required]
    [GreaterThanZero]
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeAppointmentSearchModel
{
    public int? Id { get; set; } = null;
}