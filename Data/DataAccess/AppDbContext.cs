using Data.Entities;
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

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Seed();
        base.OnModelCreating(builder);
        builder.Entity<User>(b =>
        {
            // Each User can have many entries in the UserRole join table
            b.HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            b.HasIndex(e => e.Email).IsUnique();
            b.HasIndex(e => e.PhoneNumber).IsUnique();
        });

        builder.Entity<Customer>(b =>
        {
            b.HasIndex(e => e.TaxNumber).IsUnique();
        });

        builder.Entity<Role>(b =>
        {
            // Each Role can have many entries in the UserRole join table
            b.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
        });

        builder.Entity<Server>(b =>
        {
            b.HasIndex(e => e.SerialNumber).IsUnique();
        });

        builder.Entity<Area>(b =>
        {
            b.HasIndex(e => e.Name).IsUnique();
        });

        builder.Entity<Ip>(b =>
        {
            b.HasIndex(e => new { e.Address, e.NetworkId }).IsUnique();
        });

        builder.Entity<AdditionalService>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Area>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Colocation>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<CompanyType>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Customer>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Device>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Location>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Rack>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Role>()
            .HasQueryFilter(x => !x.isDeactive);
        builder.Entity<Server>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Service>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<User>()
            .HasQueryFilter(x => !x.IsDeleted);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
    public DbSet<AdditionalService> AdditionalServices { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<Colocation> Colocations { get; set; }
    public DbSet<ColocationHistory> ColocationHistories { get; set; }
    public DbSet<CompanyType> CompanyTypes { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<Ip> Ips { get; set; }
    public DbSet<IpAssignment> IpAssignments { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Network> Networks { get; set; }
    public DbSet<Rack> Racks { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
}
