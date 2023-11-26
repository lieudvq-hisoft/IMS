﻿using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class RequestHostModel
{
    public int Id { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestHostResultModel
{
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}
public class RequestHostCreateModel
{
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}

public class RequestHostIpAssignmentModel
{
    [Required]
    public List<int> IpAddressIds { get; set; }
}


public class RequestHostUpdateModel
{
    public int Id { get; set; }
    public IpAssignmentTypes Type { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
}


public class RequestHostSearchModel
{
    public IpAssignmentTypes? Type { get; set; } = null;
    public RequestStatus? Status { get; set; } = null;
    public int? ServerAllocationId { get; set; } = null;
}

public class RequestHostEvaluateBulkModel
{
    [Required]
    public List<int> RequestHostIds { get; set; }

    [Required]
    public string UserId { get; set; }
}
