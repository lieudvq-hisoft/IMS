namespace Data.Models;
public class ServiceModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public bool IsDeletable { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class ServiceCreateModel
{
    public string Name { get; set; }
    public string Type { get; set; }
    public bool IsDeletable { get; set; }
}

public class ServiceUpdateModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
}


