using System.ComponentModel.DataAnnotations;

namespace Data.Utils.ValidationAttributes;
public class SameDateAndLaterThanAttribute : ValidationAttribute
{
    private readonly string _comparisonProperty;

    public SameDateAndLaterThanAttribute(string comparisonProperty)
    {
        _comparisonProperty = comparisonProperty;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        ErrorMessage = ErrorMessageString;
        var currentValue = (DateTime)value;

        var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

        if (property == null)
            throw new ArgumentException("Property with this name not found");

        var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance);

        if (currentValue <= comparisonValue || currentValue.Date != comparisonValue.Date)
            return new ValidationResult(ErrorMessage);

        return ValidationResult.Success;
    }
}
