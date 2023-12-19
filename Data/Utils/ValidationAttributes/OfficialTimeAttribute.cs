using Data.DataAccess.Constant;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utils.ValidationAttributes;
public class OfficialTimeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (ErrorMessageString.IsNullOrEmpty())
        {
            ErrorMessage = "Must be in official time";
        }
        else
        {
            ErrorMessage = ErrorMessageString;
        }
        var currentValue = (DateTime)value;
        IConfiguration config = (IConfiguration)validationContext.GetService(typeof(IConfiguration));

        if (currentValue.Hour < int.Parse(config["OfficialTime:Start"]) || currentValue.Hour >= int.Parse(config["OfficialTime:End"]))
            return new ValidationResult(ErrorMessage);

        return ValidationResult.Success;
    }
}