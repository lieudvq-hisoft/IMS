using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class LocationModel
{
    public int Id { get; set; }
    public int Position { get; set; }
    public int RackId { get; set; }
}

public class LocationResultModel
{
    public int Id { get; set; }
    public int Position { get; set; }
    public int RackId { get; set; }
}

public class LocationRackMapModel
{
    public int Id { get; set; }
    public int Position { get; set; }
    public int RackId { get; set; }
    public ServerAllocationModel? ServerAllocation { get; set; }
    public ServerAllocationModel? RequestedServerAllocation { get; set; }
    public RequestExpandResultModel? RequestExpand { get; set; }
}

public class LocationSearchModel
{
    public int? LocationId { get; set; } = null;
}

public class LocationChoiceModel
{
    public int AreaId { get; set; }

    [Required]
    public int RackId { get; set; }

    [Required]
    public int Position { get; set; }

}
public class LocationSuggestResultModel
{
    public AreaResultModel Area { get; set; }

    [Required]
    public RackResultModel Rack { get; set; }

    [Required]
    public int Position { get; set; }
}
