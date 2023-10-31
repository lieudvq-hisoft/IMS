namespace Data.Models;
public class ColocationHistoryModel
{
    public int Id { get; set; }
    public int Time { get; set; }
    public DateTime DateExtended { get; set; }
    public DateTime ProposedDateStop { get; set; }
    public bool IsAccepted { get; set; }

    public int ColocationId { get; set; }
}
