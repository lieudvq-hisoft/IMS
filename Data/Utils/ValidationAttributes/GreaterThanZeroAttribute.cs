using System.ComponentModel.DataAnnotations;

namespace Data.Utils.ValidationAttributes;
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