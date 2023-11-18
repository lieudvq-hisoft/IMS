using Data.Enums;

namespace Data.Entities.Pending;
public class RequestHostUser : BaseEntity
{
    public IpAssignmentTypes Type { get; set; }

    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    public int RequestHostId { get; set; }
    public virtual RequestHost RequestHost { get; set; }
}
