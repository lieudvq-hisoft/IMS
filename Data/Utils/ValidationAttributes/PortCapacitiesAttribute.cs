using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Data.Utils.ValidationAttributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public class PortCapacitiesAttribute : ValidationAttribute
{
    public PortCapacitiesAttribute()
    {
        ErrorMessage = "Must contain only 0.1 and/or 1.";
    }

    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return true;
        }

        if (value is IEnumerable enumerable)
        {
            var capacities = enumerable.Cast<double>().ToList();

            return capacities.All(i => i == 0.1 || i == 1);
        }

        return false;
    }
}
