using Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServiceModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class ServiceCreateModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public ServiceType Type { get; set; }
}

public class ServiceUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public ServiceType Type { get; set; }
}

