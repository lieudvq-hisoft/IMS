using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class RequestUpgrade: BaseEntity
{
    public RequestStatus Status { get; set; }
    public string? InspectionReportFilePath { get; set; }

    public int ServerHardwareConfigId { get; set; }
    public ServerHardwareConfig ServerHardwareConfig { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation ServerAllocation { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
