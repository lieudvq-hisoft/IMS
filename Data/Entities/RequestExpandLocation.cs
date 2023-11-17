﻿namespace Data.Entities;
public class RequestExpandLocation : BaseEntity
{
    public bool IsServer { get; set; }

    public int RequestExpandId { get; set; }
    public RequestExpand RequestExpand { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }
}
