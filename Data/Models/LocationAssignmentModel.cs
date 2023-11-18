using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class LocationAssignmentModel
{
    public bool IsServer { get; set; }
    public int Id { get; set; }
    public int ServerAllocationId { get; set; }
    public int LocationId { get; set; }
}

public class LocationAssignmentCreateModel
{
    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
    [Required]
    [GreaterThanZero]
    public int LocationId { get; set; }
}

public class LocationAssignmentSearchModel
{
    public int? ServerAllocationId { get; set; } = null;
}

