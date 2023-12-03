using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utils.ValidationAttributes;
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public class EnsureMinimumElementsAttribute : ValidationAttribute
{
    private readonly int _min;
    private readonly int _max;

    public EnsureMinimumElementsAttribute(int min = 0, int max = int.MaxValue)
    {
        _min = min;
        _max = max;
    }

    public override bool IsValid(object value)
    {
        if (!(value is IList list))
            return false;

        return list.Count >= _min && list.Count <= _max;
    }
}