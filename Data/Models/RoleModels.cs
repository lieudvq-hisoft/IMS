﻿namespace Data.Models;

public class RoleModel
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public bool isDeactive { get; set; }
}
