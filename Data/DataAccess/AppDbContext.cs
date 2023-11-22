using Data.Entities;
using Data.Entities.Pending;
using Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data.DataAccess;

public class AppDbContext : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        this.SavingChanges += DbContextBase_SavingChanges;
    }

    private void DbContextBase_SavingChanges(object? sender, SavingChangesEventArgs e)
    {
        var objectContext = (DbContext)sender;
        var modifiedEntities =
            objectContext.ChangeTracker.Entries().Where(c => c.State is EntityState.Added or EntityState.Modified or EntityState.Deleted);

        foreach (var entry in modifiedEntities)
        {
            if (entry.State == EntityState.Added)
            {
                if (entry.GetType().GetProperty("DateCreated") != null)
                {
                    entry.Property("DateCreated").CurrentValue = DateTime.UtcNow;
                }
            }
            if (entry.State == EntityState.Modified)
            {
                if (entry.GetType().GetProperty("DateUpdated") != null)
                {
                    entry.Property("DateUpdated").CurrentValue = DateTime.UtcNow;
                }
            }
            if (entry.State == EntityState.Deleted)
            {
                entry.Property("IsDeleted").CurrentValue = true;
                entry.State = EntityState.Modified;
            }
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ConfigModel();

        builder.Seed();
        builder.FilterSoftDeleted();

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AppointmentUser> AppointmentUsers { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<CompanyType> CompanyTypes { get; set; }
    public DbSet<Component> Components { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<IpAddress> IpAddresses { get; set; }
    public DbSet<IpAssignment> IpAssignments { get; set; }
    public DbSet<IpSubnet> IpSubnets { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<LocationAssignment> LocationAssignments { get; set; }
    public DbSet<Rack> Racks { get; set; }
    public DbSet<RequestExpand> RequestExpands { get; set; }
    public DbSet<RequestExpandAppointment> RequestExpandAppointments { get; set; }
    public DbSet<RequestExpandLocation> RequestExpandLocations { get; set; }
    public DbSet<RequestExpandUser> RequestExpandUsers { get; set; }
    public DbSet<RequestHost> RequestHosts { get; set; }
    public DbSet<RequestHostAppointment> RequestHostAppointments { get; set; }
    public DbSet<RequestHostIp> RequestHostIps { get; set; }
    public DbSet<RequestHostUser> RequestHostUsers { get; set; }
    public DbSet<RequestUpgrade> RequestUpgrades { get; set; }
    public DbSet<RequestUpgradeAppointment> RequestUpgradeAppointments { get; set; }
    public DbSet<RequestUpgradeUser> RequestUpgradeUsers { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<ServerAllocation> ServerAllocations { get; set; }
    public DbSet<ServerHardwareConfig> ServerHardwareConfigs { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
}
