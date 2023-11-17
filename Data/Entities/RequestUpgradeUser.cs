namespace Data.Entities;
public class RequestUpgradeUser : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; }

    public int RequestUpgradeId { get; set; }
    public RequestUpgrade RequestUpgrade { get; set; }
}
