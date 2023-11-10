using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class IpAssignmentModel
{
    public int Id { get; set; }
    public DateTime DateAssign { get; set; }
    public string IpAddress { get; set; }
    //public string InspectionRecordFilePath { get; set; }
}

public class IpAssignmentSearchModel
{
    public int? ServiceId { get; set; } = null;
    public IpAssignmentTypes Type { get; set; }
}

public class IpAssignmentCreateModel
{
    [Required]   
    public DateTime DateAssign { get; set; }
    [Required]
    public IpAssignmentTypes Type { get; set; }
    [Required]
    public int IpId { get; set; }
    [Required]
    public int ServiceId { get; set; }
}

public class IpAssignmentUpdateModel
{
    public int Id { get; set; }
    [Required]
    public DateTime DateAssign { get; set; }
    [Required]
    public IpAssignmentTypes Type { get; set; }
    [Required]
    public int IpId { get; set; }
    [Required]
    public int ServiceId { get; set; }
}
