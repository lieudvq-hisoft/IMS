using Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IMS.Extensions;

public static class ConnectDbExtension
{
    public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseNpgsql(configuration.GetConnectionString("Dev"),
                b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name));
        });
    }
}
