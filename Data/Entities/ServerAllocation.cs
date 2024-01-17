using Data.Enums;
using Data.Models;
using Data.Utils.Common;

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
    public DateTime? DateConfirm { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }
    public string? RemovalInspectFilePath { get; set; }
    public string? FinalRemovalInspect { get; set; }
    public string? RemovalReceiptFilePath { get; set; }
    public string? FinalRemovalReceipt { get; set; }
    public string? PartNumber { get; set; }

    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public ICollection<ServerHardwareConfig>? ServerHardwareConfigs { get; set; }
    public ICollection<RequestUpgrade>? RequestUpgrades { get; set; }
    public ICollection<LocationAssignment>? LocationAssignments { get; set; }
    public ICollection<Appointment>? Appointments { get; set; }
    public ICollection<RequestExpand>? RequestExpands { get; set; }
    public ICollection<IpAssignment>? IpAssignments { get; set; }
    public ICollection<RequestHost>? RequestHosts { get; set; }
    public ICollection<Incident>? Incidents { get; set; }

    public string GetServerLocation()
    {
        var locations = LocationAssignments.Select(x => x.Location);
        var rack = locations.Select(x => x.Rack).Distinct().FirstOrDefault();
        var startPosition = locations.Select(x => x.Position).Min();
        var endPosition = locations.Select(x => x.Position).Max();
        return $"{rack.Area.Name}{rack.Row + 1}-{rack.Column + 1} U{startPosition + 1}-U{endPosition + 1}";
    }

    //public bool Filter(ServerAllocationSearchModel searchModel)
    //{
    //    var matchSearchValue = Name.ToLower().Contains(searchModel.SearchValue) 
    //        || Customer.CompanyName.ToLower().Contains(searchModel.SearchValue)
    //        || MasterIpAddress.Contains(searchModel.SearchValue);

    //    var matchStatus = searchModel.Status != null ? searchModel.Status.Contains(Status) : true;
    //    var matchCustomerId = searchModel.CustomerId != null ? CustomerId == searchModel.CustomerId : true;
    //    var matchRack = searchModel.RackId != null ? LocationAssignments.Select(x => x.Location.RackId).Distinct().Any(x => x == searchModel.RackId) : true;
    //    var matchUser = Customer.UserCustomers.Any(x => x.UserId == searchModel.UserId) || searchModel.UserId == null;
    //    return matchSearchValue && matchStatus && matchCustomerId && matchRack && matchUser;
    //}
}
