using System.ComponentModel.DataAnnotations;

namespace Data.Utils.ValidationAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class PortCapacityAttribute : ValidationAttribute
{
    private readonly double[] allowedValues = { 0.1, 1.0 };

    public PortCapacityAttribute()
    {
        ErrorMessage = "The field must be either 0.1 or 1.0.";
    }

    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return false;
        }

        double inputValue;
        if (double.TryParse(value.ToString(), out inputValue))
        {
            return Array.Exists(allowedValues, v => Math.Abs(v - inputValue) < double.Epsilon);
        }

        return false;
    }
}
