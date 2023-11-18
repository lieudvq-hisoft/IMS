using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ComponentModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Unit { get; set; }
    public string Type { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class ComponentCreateModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public string Unit { get; set; }

    [Required]
    public ComponentType Type { get; set; }
}

public class ComponentUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string? Description { get; set; }

    [Required]
    public string Unit { get; set; }

    [Required]
    public ComponentType Type { get; set; }
}

public class ComponentSearchModel
{
    public string? Name { get; set; } = "";
}
