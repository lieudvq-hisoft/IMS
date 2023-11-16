using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestUpgradeAppointmentModel
{
    public int AppointmentId { get; set; }
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeAppointmentCreateModel
{
    [Required]
    public int AppointmentId { get; set; }
    [Required]
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeAppointmentUpdateModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int AppointmentId { get; set; }
    [Required]
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeAppointmentSearchModel
{
    public int AppointmentId { get; set; }
    public int RequestUpgradeId { get; set; }
}