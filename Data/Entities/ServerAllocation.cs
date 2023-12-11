using Data.Enums;

namespace Data.Entities;
public class ServerAllocation : BaseEntity
{
    public ServerAllocationStatus Status { get; set; }
    public string? Name { get; set; }
    public string? SerialNumber { get; set; }
    public int? Power { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public bool LocationRemoved { get; set; }
    public string? MasterIpAddress { get; set; }
    public string? ServerLocation { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? RemovalFilePath { get; set; }

    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public ICollection<ServerHardwareConfig>? ServerHardwareConfigs { get; set; }
    public ICollection<RequestUpgrade>? RequestUpgrades { get; set; }
    public ICollection<LocationAssignment>? LocationAssignments { get; set; }
    public ICollection<Appointment>? Appointments { get; set; }
    public ICollection<RequestExpand>? RequestExpands { get; set; }
    public ICollection<IpAssignment>? IpAssignments { get; set; }
    public ICollection<RequestHost>? RequestHosts { get; set; }

    public string GetServerLocation()
    {
        var locations = LocationAssignments.Select(x => x.Location);
        var rack = locations.Select(x => x.Rack).Distinct().FirstOrDefault();
        var startPosition = locations.Select(x => x.Position).Min();
        var endPosition = locations.Select(x => x.Position).Max();
        return $"{rack.Area.Name}{rack.Column}-{rack.Row} U{startPosition + 1}-U{endPosition + 1}";
    }
}
