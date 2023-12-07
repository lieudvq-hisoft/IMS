using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Utilities;
public class SettingHelper
{
    public static string GetEnvironment()
    {
        return "Dev";
    }
}
