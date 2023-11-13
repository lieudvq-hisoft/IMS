using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class ServerHardwareConfigModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int ServerAllocationId { get; set; }
    public int ComponentId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class ServerHardwareConfigCreateModel
{
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int ServerAllocationId { get; set; }
    public int ComponentId { get; set; }
}

public class ServerHardwareConfigUpdateModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public int ServerAllocationId { get; set; }
    public int ComponentId { get; set; }
}

public class ServerHardwareConfigSearchModel
{
    public int? Id { get; set; }
    public int? ServerAllocationId { get; set; }
    public int? ComponentId { get; set; }
}
