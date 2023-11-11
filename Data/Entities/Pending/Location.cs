namespace Data.Entities;
public class Location : BaseEntity
{
    public int Position { get; set; }

    public int RackId { get; set; }
    public virtual Rack Rack { get; set; }

    public virtual ICollection<LocationAssignment> LocationAssignments { get; set; }
}
