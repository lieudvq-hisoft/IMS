using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

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
    [Required]
    public string Description { get; set; }

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
    public string Description { get; set; }

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
