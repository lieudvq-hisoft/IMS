using Data.Enums;

namespace Data.Entities;
public class RequestExpand : BaseEntity
{
    //public int Power { get; set; }
    public RequestStatus Status { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    //public string? InspectionReportFilePath { get; set; }
    //public string? ReceiptOfRecipientFilePath { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Expand;

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestExpandLocation>? RequestExpandLocations { get; set; }
    public ICollection<RequestExpandUser>? RequestExpandUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }
}
