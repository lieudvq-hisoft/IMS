using Data.Entities;
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
    public string AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public string Reason { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public bool IsCorrectPerson { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class AppointmentCreateModel
{
    [Required]
    public string AppointedCustomer { get; set; }

    [Required]
    public DateTime DateAppointed { get; set; }

    [Required]
    public string Reason { get; set; }

    public string? Note { get; set; }

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

    public string? Note { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class AppointmentCompleteModel
{
    [Required]
    public DateTime DateCheckedIn { get; set; }

    [Required]
    public DateTime DateCheckedOut { get; set; }

    public string? TechNote { get; set; }

    [Required]
    public bool IsCorrectPerson { get; set; }

    [Required]
    public string UserId { get; set; }
}

public class AppointmentSearchModel
{
    public int? Id { get; set; }
    public RequestStatus? Status { get; set; }
    public int? ServerAllocationId { get; set; }
}

