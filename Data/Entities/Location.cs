using Data.Enums;

namespace Data.Entities;
public class Location
{
    public int Id { get; set; }
    public bool IsReserved { get; set; }
    public bool IsDeleted { get; set; }
    public int Position { get; set; }

    public int RackId { get; set; }
    public Rack Rack { get; set; }

    public ICollection<LocationAssignment> LocationAssignments { get; set; }
    public ICollection<RequestExpandLocation> RequestExpandLocations { get; set; }

    public bool IsAvailable()
    {
        return !IsReserved && !LocationAssignments.Any() && !RequestExpandLocations.Select(x => x.RequestExpand).Any(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted);
    }
}
