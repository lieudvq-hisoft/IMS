using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class AppointmentModel
{
    public int Id { get; set; }
    public DateTime DateAppointed { get; set; }
    public string Reason { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}

public class AppointmentCreateModel
{
    [Required]
    public DateTime DateAppointed { get; set; }

    [Required]
    public string Reason { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class AppointmentUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [Required]
    public DateTime DateAppointed { get; set; }

    [Required]
    public string Reason { get; set; }

    [Required]
    public int ServerAllocationId { get; set; }
}

public class AppointmentSearchModel
{
    public int? Id { get; set; }
    public RequestStatus? Status { get; set; }
    public int? ServerAllocationId { get; set; }
}

