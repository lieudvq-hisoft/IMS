using Data.Enums;

namespace Data.Entities;
public class IncidentUser : BaseEntity
{
    public RequestUserAction Action { get; set; }

    public int IncidentId { get; set; }
    public Incident Incident { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }
}
