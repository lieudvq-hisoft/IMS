using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class IpAssignmentModel
{
    public int Id { get; set; }
    public DateTime DateAssign { get; set; }
    public string IpAddress { get; set; }
    public string Status { get; set; }
    public string Content { get; set; }
    //public string InspectionRecordFilePath { get; set; }
}

public class IpAssignmentSearchModel
{
    public int? ServerId { get; set; } = null;
    public IpAssignmentType Type { get; set; }
}
