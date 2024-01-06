using Data.Enums;
using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;
public class RequestExpand : BaseEntity
{
    public RequestStatus Status { get; set; }
    public bool ForRemoval { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Expand;
    public int? Size { get; set; }
    public int? SuccessExpandAppointmentId { get; set; }
    public DateTime? RemovalDateCreated { get; set; }
    public DateTime? RemovalDateUpdated { get; set; }
    public string? ChosenLocation { get; set; }
    public DateTime? DateEvaluated { get; set; }
    public DateTime? DateExecuted { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestExpandLocation>? RequestExpandLocations { get; set; }
    public ICollection<RequestExpandUser>? RequestExpandUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }
}
