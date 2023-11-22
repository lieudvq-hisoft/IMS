using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data.Utils.ValidationAttributes;
[AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property)]
internal class IsIpV4Attribute: ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var pattern = new Regex(@"^(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$");
        if (value is string ipString && pattern.IsMatch(ipString))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("The input must a an ipv4");
    }
}
