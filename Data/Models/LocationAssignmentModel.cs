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

public class LocationModel
{
    public int Id { get; set; }
    public int Position { get; set; }
    public int RackId { get; set; }
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

public class LocationAssignmentSearchModel
{
    public int? ServerAllocationId { get; set; } = null;
}

[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
public class GreaterThanZeroAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is int intValue && intValue > 0)
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("The value must be greater than 0.");
    }
}

