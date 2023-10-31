namespace Data.Entities;
public class Executor : BaseEntity
{
    public int UserId { get; set; }
    public virtual User User { get; set; }

    public virtual ICollection<AdditionalService> AdditionalServices { get; set; }
}
