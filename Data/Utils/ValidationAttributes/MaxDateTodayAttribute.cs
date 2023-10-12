using System.ComponentModel.DataAnnotations;

namespace IMS.Data.Utils.ValidationAttributes;
public class MaxDateTodayAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        ErrorMessage = ErrorMessageString;
        var currentValue = (DateTime)value;

        if (currentValue > DateTime.Today)
            return new ValidationResult(ErrorMessage);

        return ValidationResult.Success;
    }
}
