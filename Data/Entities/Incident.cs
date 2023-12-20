namespace Data.Entities;
public class Incident : BaseEntity
{
    public string Description { get; set; }
    public string? Solution { get; set; }
    public bool IsResolved { get; set; }
    public bool IsResolvByClient { get; set; }
    public string? Document { get; set; }
    public bool PausingRequired { get; set; }

    public ICollection<IncidentUser> IncidentUsers { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<IncidentAppointment> IncidentAppointments { get; set; }
}
