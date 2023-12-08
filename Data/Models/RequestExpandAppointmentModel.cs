using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestExpandAppointmentModel
{
    public bool ForRemoval { get; set; }
    public int RequestExpandId { get; set; }
    public int AppointmentId { get; set; }
}

public class RequestExpandAppointmentResultModel
{
    public bool ForRemoval { get; set; }
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

