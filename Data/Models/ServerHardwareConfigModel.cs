using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServerHardwareConfigModel
{
    public int Id { get; set; }
    public string Information { get; set; }
    public int ServerAllocationId { get; set; }
    public int ComponentId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;

    public ComponentModel? Component { get; set; }
}

public class ServerHardwareConfigResultModel
{
    public int Id { get; set; }
    public string Information { get; set; }
    public int ServerAllocationId { get; set; }
    public int ComponentId { get; set; }
}

public class ServerHardwareConfigCreateModel
{
    [Required]
    public string Information { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }

    [Required]
    [GreaterThanZero]
    public int ComponentId { get; set; }
}

public class ServerHardwareConfigCreateBulkModel
{
    public List<ServerHardwareConfigCreateModel> ServerHardwareConfigCreateModels { set; get; }
}

public class ServerHardwareConfigUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [Required]
    public string Information { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }

    [Required]
    [GreaterThanZero]
    public int ComponentId { get; set; }
}

public class ServerHardwareConfigSearchModel
{
    public int? Id { get; set; }
    public int? ServerAllocationId { get; set; }
    public int? ComponentId { get; set; }
}
