using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServerHardwareConfigModel
{
    public int Id { get; set; }
    public string Information { get; set; }
    public int Capacity { get; set; }
    public int ServerAllocationId { get; set; }
    public int ComponentId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;

    public string ComponentName { get; set; }
    public string ComponentType { get; set; }
    public string ComponentUnit { get; set; }
}

public class ServerHardwareConfigCreateModel
{
    [Required]
    public string Information { get; set; }

    [Required]
    public int Capacity { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }

    [Required]
    [GreaterThanZero]
    public int ComponentId { get; set; }
}

public class ServerHardwareConfigUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [Required]
    public string Information { get; set; }

    [Required]
    public int Capacity { get; set; }

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
