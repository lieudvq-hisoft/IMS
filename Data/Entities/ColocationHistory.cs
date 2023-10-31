namespace Data.Entities;
public class ColocationHistory : BaseEntity
{
    public int Time { get; set; }
    public DateTime DateExtended { get; set; }
    public DateTime ProposedDateStop { get; set; }
    public bool IsAccepted { get; set; }

    public int ColocationId { get; set; }
    public virtual Colocation Colocation { get; set; }
}
