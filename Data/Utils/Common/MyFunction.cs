using System.Text;
using System.Text.RegularExpressions;

namespace Data.Utils.Common;

public static class MyFunction
{
    public static string ConvertToUnSign(string input)
    {
        input = input.Trim();
        for (int i = 0x20; i < 0x30; i++)
        {
            input = input.Replace(((char)i).ToString(), " ");
        }
        Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
        string str = input.Normalize(NormalizationForm.FormD);
        string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
        while (str2.IndexOf("?") >= 0)
        {
            str2 = str2.Remove(str2.IndexOf("?"), 1);
        }
        return str2;
    }

    public static string GetErrorMessage(Exception e)
    {
        return e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
    }

    public static bool MatchString(string searchValue, string? value)
    {
        return ConvertToUnSign(value ?? "")
            .IndexOf(ConvertToUnSign(searchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0;
    }
}