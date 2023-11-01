namespace Data.Entities;
public class RequestExtendHistory : BaseEntity
{
    public int Time { get; set; }
    public DateTime DateExtended { get; set; }
    public DateTime ProposedDateStop { get; set; }
    public bool IsAccepted { get; set; }

    public int RequestId { get; set; }
    public virtual Request Request { get; set; }
}
