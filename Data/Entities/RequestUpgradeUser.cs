using Data.Enums;

namespace Data.Entities;
public class RequestUpgradeUser : BaseEntity
{
    public RequestUserAction Action { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public int RequestUpgradeId { get; set; }
    public RequestUpgrade RequestUpgrade { get; set; }
}
