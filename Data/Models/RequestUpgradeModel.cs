using Data.Entities;
using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestUpgradeModel
{
    public int Id { get; set; }
    public RequestStatus Status { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public int ServerHardwareConfigId { get; set; }
    public int ServerAllocationId { get; set; }
    public int CustomerId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class RequestUpgradeCreateModel
{
    public int ServerHardwareConfigId { get; set; }
    public int ServerAllocationId { get; set; }
    public int CustomerId { get; set; }
}

public class RequestUpgradeSearchModel
{
    public int? Id { get; set; }
    public int? CustomerId { get; set; }
    public int? ServerAllocationId { get; set; }
}
