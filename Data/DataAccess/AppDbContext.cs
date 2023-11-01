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
                entry.Property("DateCreated").CurrentValue = DateTime.UtcNow;
            }
            if (entry.State == EntityState.Modified)
            {
                entry.Property("DateUpdated").CurrentValue = DateTime.UtcNow;
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

        builder.Seed();
        builder.FilterSoftDeleted();
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
    public DbSet<Approver> Approvers { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<CompanyType> CompanyTypes { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<Executor> Executors { get; set; }
    public DbSet<Ip> Ips { get; set; }
    public DbSet<IpAssignment> IpAssignments { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Network> Networks { get; set; }
    public DbSet<Rack> Racks { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<RequestExtendHistory> RequestExtendHistories { get; set; }
    public DbSet<ServiceRequest> ServiceRequests { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
}
