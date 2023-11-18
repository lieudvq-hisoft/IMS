using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestHostModel
{
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestHostSearchModel
{
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestHostEvaluateBulkModel
{
    [Required]
    public List<int> RequestHostIds { get; set; }

    [Required]
    public string UserId { get; set; }
}
