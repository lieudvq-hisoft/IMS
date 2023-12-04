﻿using Data.Enums;
using Data.Models;

namespace Data.Entities;
public class RequestHost : BaseEntity
{
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public int Quantity { get; set; }
    public bool IsRemoval { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestHostStatus Status { get; set; }
    public RequestType RequestType { get; set; } = RequestType.Host;
    public string? InspectionReportFilePath { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public ICollection<RequestHostIp> RequestHostIps { get; set; }

    public ICollection<RequestHostUser> RequestHostUsers { get; set; }

    public bool FilterRequestHost(RequestHostSearchModel model)
    {
        bool matchIpAssignmentTypes = model.Type != null ? Type == model.Type : true;
        bool matchStatus = model.Status != null ? Status == model.Status : true;
        bool matchMasterIp = model.MasterIp != null ? ServerAllocation.MasterIpAddress.Contains(model.MasterIp) : true;
        bool matchCustomer = model.Customer != null ? ServerAllocation.Customer.CompanyName.Contains(model.Customer) : true;
        bool matchPurpose = model.IsRemoved != null ? IsRemoval == model.IsRemoved : true;

        return matchIpAssignmentTypes && matchStatus && matchMasterIp && matchCustomer && matchPurpose;
    }
}
