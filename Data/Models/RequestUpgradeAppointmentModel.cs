using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestUpgradeAppointmentModel
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public int RequestUpgradeId { get; set; }
}

public class RequestAppointmentCreateModel
{
    [Required]
    public List<int> RequestUpgradeIds { get; set; }

    [Required]
    public List<int> RequestExpandIds { get; set; }

    [Required]
    public List<int> RequestHostIds { get; set; }
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