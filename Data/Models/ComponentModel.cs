using Data.Enums;

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
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Unit { get; set; }
    public ComponentType Type { get; set; }
}

public class ComponentUpdateModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string Unit { get; set; }
    public ComponentType Type { get; set; }
}

public class ComponentSearchModel
{
    public string? Name { get; set; } = "";
}
