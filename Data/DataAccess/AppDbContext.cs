﻿using Data.Entities;
using Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
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
        builder.Entity<Appointment>(b =>
        {
            b.HasMany(e => e.RequestUpgradeAppointment)
                .WithOne(e => e.Appointment)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.AppointmentUsers)
                .WithOne(e => e.Appointment)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<Area>(b =>
        {
            b.HasMany(e => e.Racks)
                .WithOne(e => e.Area)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<Component>(b =>
        {
            b.HasMany(e => e.ServerHardwareConfigs)
                .WithOne(e => e.Component)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestUpgrades)
                .WithOne(e => e.Component)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<Customer>(b =>
        {
            b.HasIndex(e => e.TaxNumber).IsUnique();
            b.HasMany(e => e.ServerAllocations)
                .WithOne(e => e.Customer)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<Location>(b =>
        {
            b.HasMany(e => e.LocationAssignments)
                .WithOne(e => e.Location)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestExpandLocations)
                .WithOne(e => e.Location)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<Rack>(b =>
        {
            b.HasMany(e => e.Locations)
                .WithOne(e => e.Rack)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<RequestExpand>(b =>
        {
            b.HasMany(e => e.RequestExpandLocations)
                .WithOne(e => e.RequestExpand)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestExpandUsers)
                .WithOne(e => e.RequestExpand)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<RequestUpgrade>(b =>
        {
            b.HasMany(e => e.RequestUpgradeAppointments)
                .WithOne(e => e.RequestUpgrade)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestUpgradeAppointments)
                .WithOne(e => e.RequestUpgrade)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<ServerAllocation>(b =>
        {
            b.HasMany(e => e.ServerHardwareConfigs)
                .WithOne(e => e.ServerAllocation)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestUpgrades)
                .WithOne(e => e.ServerAllocation)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.LocationAssignments)
                .WithOne(e => e.ServerAllocation)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.Appointments)
                .WithOne(e => e.ServerAllocation)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestExpands)
               .WithOne(e => e.ServerAllocation)
               .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<User>(b =>
        {
            // Each User can have many entries in the UserRole join table
            b.HasMany(e => e.UserRoles)
                .WithOne(e => e.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            b.HasIndex(e => e.Email).IsUnique();
            b.HasIndex(e => e.PhoneNumber).IsUnique();
            b.HasMany(e => e.RequestUpgradeUsers)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.AppointmentUsers)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestExpandUsers)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<Role>(b =>
        {
            // Each Role can have many entries in the UserRole join table
            b.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
        });

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
    public DbSet<Location> Locations { get; set; }
    public DbSet<LocationAssignment> LocationAssignments { get; set; }
    public DbSet<Rack> Racks { get; set; }
    public DbSet<RequestExpand> RequestExpands { get; set; }
    public DbSet<RequestExpandLocation> RequestExpandLocations { get; set; }
    public DbSet<RequestExpandUser> RequestExpandUsers { get; set; }
    public DbSet<RequestUpgrade> RequestUpgrades { get; set; }
    public DbSet<RequestUpgradeAppointment> RequestUpgradeAppointments { get; set; }
    public DbSet<RequestUpgradeUser> RequestUpgradeUsers { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<ServerAllocation> ServerAllocations { get; set; }
    public DbSet<ServerHardwareConfig> ServerHardwareConfigs { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
    //public DbSet<IpAddress> Ips { get; set; }
    //public DbSet<IpAssignment> IpAssignments { get; set; }
    //public DbSet<IpSubnet> Networks { get; set; }
    //public DbSet<Request> Requests { get; set; }
    //public DbSet<Service> Services { get; set; }
}
