using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class IncidentModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public string? Description { get; set; }
    public string? Solution { get; set; }
    public bool PausingRequired { get; set; }
    public bool IsResolved { get; set; }
    public bool IsResolvByClient { get; set; }
    public string? Document { get; set; }

    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }

    public ServerAllocationResultModel? ServerAllocation { get; set; }

    public AppointmentResultModel? Appointment { get; set; }
}

public class IncidentResultModel
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public string? Description { get; set; }
    public string? Solution { get; set; }
    public bool PausingRequired { get; set; }
    public bool IsResolved { get; set; }
    public bool IsResolvByClient { get; set; }
    public string? Document { get; set; }

    public Guid UserId { get; set; }

    public int ServerAllocationId { get; set; }
}

public class IncidentCreateModel
{
    [Required]
    public string Description { get; set; }

    [Required]
    public bool IsResolvByClient { get; set; }

    [Required]
    public bool PausingRequired { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class IncidentResolvModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Solution { get; set; }
}

public class IncidentSearchModel
{

}
