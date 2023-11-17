namespace Data.Entities;
public class LocationAssignment : BaseEntity
{
    public bool IsServer { get; set; }

    public int ServerAllocationId { get; set; }
    public virtual ServerAllocation ServerAllocation { get; set; }

    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
}
