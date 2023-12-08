using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Data.Utils.ValidationAttributes;
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
internal class IsIpV4Attribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        //var pattern = new Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$");
        var pattern = new Regex(@"^(19[2-9]|2[0-1][0-9]|22[0-3])\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9]{2}|[1-9][0-9]|[0-9])\.0$");
        if (value is string ipString && pattern.IsMatch(ipString))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("The input must a an ipv4");
    }
}
