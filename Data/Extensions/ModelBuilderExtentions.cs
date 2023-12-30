using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions;

public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder builder)
    {
        #region Component
        builder.Entity<Component>().HasData(new Component
        {
            Id = 1,
            Name = "CPU",
            //IsRequired = true,
        });
        builder.Entity<Component>().HasData(new Component
        {
            Id = 2,
            Name = "RAM",
            //IsRequired = true,
            //RequireCapacity = true
        });
        builder.Entity<Component>().HasData(new Component
        {
            Id = 3,
            Name = "Harddisk",
            //IsRequired = true,
            //RequireCapacity = true
        });
        //builder.Entity<Component>().HasData(new Component
        //{
        //    Id = 2,
        //    Name = "GPU",
        //    RequireCapacity = true
        //});
        //builder.Entity<Component>().HasData(new Component
        //{
        //    Id = 4,
        //    Name = "Motherboard",
        //});
        #endregion

        #region Location
        builder.Entity<Area>().HasData(new Area
        {
            Id = 1,
            Name = "A",
            RowCount = 8,
            ColumnCount = 8,
        });
        builder.Entity<Area>().HasData(new Area
        {
            Id = 2,
            Name = "B",
            RowCount = 5,
            ColumnCount = 8,
        });

        List<Rack> racks = new List<Rack>();
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                racks.Add(new Rack
                {
                    Id = (j - 1) * 8 + i,
                    MaxPower = 3000,
                    Column = i,
                    Row = j,
                    Size = 42,
                    AreaId = 1
                });
            }
        }

        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                racks.Add(new Rack
                {
                    Id = 8 * 8 + (j - 1) * 8 + i,
                    MaxPower = 3500,
                    Column = i,
                    Row = j,
                    Size = 42,
                    AreaId = 2
                });
            }
        }
        builder.Entity<Rack>().HasData(racks.OrderBy(x => x.Id));

        int locationId = 1;
        for (int i = 1; i <= 104; i++)
        {
            for (int j = 0; j < 42; j++)
            {
                builder.Entity<Location>().HasData(new Location
                {
                    Id = locationId++,
                    Position = j,
                    RackId = i
                });
            }
        }
        #endregion

        #region User
        var hasher = new PasswordHasher<User>();

        List<Guid> seedGuids = new List<Guid>
        {
            new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
            new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
            new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
            new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
            new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928")
        };

        #region Roles
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[0],
            Name = "Tech",
            Description = "IT Staff",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[1],
            Name = "Sale",
            Description = "Sale",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[2],
            Name = "Admin",
            Description = "Admin",
            isDeactive = false,
        });
        #endregion

        for (var i = 1; i <= 4; i++)
        {
            var username = "";
            var address = "";
            var fullname = "";
            var phoneNumber = "";
            switch (i)
            {
                case 1:
                    // super
                    username = "khacnhien.dao";
                    address = "Đ. Mạc Đĩnh Chi, Khu phố Tân Hòa, Dĩ An, Bình Dương";
                    fullname = "Đào Khắc Nhiên";
                    phoneNumber = "0866445139";
                    break;
                case 2:
                    // tech
                    username = "caovy.tran";
                    address = "24/5 Lê Trọng Tấn, P.Tây Thạnh, Q.Tân Phú, TPHCM";
                    fullname = "Trần Cao Vỹ";
                    phoneNumber = "0985097145";
                    break;
                case 3:
                    // sale
                    username = "nhatha.pham";
                    address = "Origami Tòa S10.03, Vinhomes Grand Park, Long Bình, Quận 9, TP.HCM";
                    fullname = "Phạm Nhật Hạ";
                    phoneNumber = "0834666630";
                    break;
                case 4:
                    // admin
                    username = "anhtuan.tran";
                    address = "Tòa S106 Vinhomes Grand Park, TP. Thủ Đức, TP. Hồ Chí Minh";
                    fullname = "Trần Anh Tuấn";
                    phoneNumber = "0682716278";
                    break;
            }

            builder.Entity<User>().HasData(new User
            {
                Id = seedGuids[i - 1],
                UserName = username,
                NormalizedUserName = username,
                Email = username + "@gmail.com",
                NormalizedEmail = username + "@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword123"),
                SecurityStamp = string.Empty,
                Fullname = fullname,
                Address = address,
                PhoneNumber = phoneNumber,
                CurrenNoticeCount = 0,
                IsDeleted = false,
            });

            #region UserRole
            if (i == 1)
            {
                for (int j = 1; j <= 3; j++)
                {
                    builder.Entity<UserRole>().HasData(new UserRole
                    {
                        RoleId = seedGuids[j - 1],
                        UserId = seedGuids[i - 1],
                    });
                }
            }
            else
            {
                builder.Entity<UserRole>().HasData(new UserRole
                {
                    RoleId = seedGuids[i - 2],
                    UserId = seedGuids[i - 1],
                });
            }
            #endregion
        }
        #endregion
    }

    public static void FilterSoftDeleted(this ModelBuilder builder)
    {
        builder.Entity<Appointment>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<AppointmentUser>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Area>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Component>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Contact>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Customer>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Incident>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<IncidentAppointment>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<IncidentUser>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<IpAddress>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<IpAssignment>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<IpSubnet>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Location>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<LocationAssignment>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Rack>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestExpand>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestExpandAppointment>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestExpandLocation>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestExpandUser>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestHost>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestHostIp>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestHostUser>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestUpgrade>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestUpgradeAppointment>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestUpgradeUser>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Role>().HasQueryFilter(x => !x.isDeactive);
        builder.Entity<ServerAllocation>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<ServerHardwareConfig>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<User>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<UserCustomer>().HasQueryFilter(x => !x.IsDeleted);
    }

    public static void ConfigModel(this ModelBuilder builder)
    {
        builder.Entity<Appointment>(b =>
        {
            b.HasMany(e => e.RequestUpgradeAppointment)
                .WithOne(e => e.Appointment)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.AppointmentUsers)
                .WithOne(e => e.Appointment)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestExpandAppointments)
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
            //b.HasIndex(e => e.TaxNumber).IsUnique();
            b.HasMany(e => e.ServerAllocations)
                .WithOne(e => e.Customer)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.UserCustomers)
                .WithOne(e => e.Customer)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<IpAddress>(b =>
        {
            b.HasMany(e => e.IpAssignments)
                .WithOne(e => e.IpAddress)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestHostIps)
                .WithOne(e => e.IpAddress)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<IpSubnet>(b =>
        {
            b.HasMany(e => e.SubNets)
                .WithOne(e => e.ParentNetwork)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.IpAddresses)
                .WithOne(e => e.IpSubnet)
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
            b.HasMany(e => e.RequestExpandAppointments)
                .WithOne(e => e.RequestExpand)
                .OnDelete(DeleteBehavior.ClientCascade);
        });

        builder.Entity<RequestHost>(b =>
        {
            b.HasMany(e => e.RequestHostIps)
                .WithOne(e => e.RequestHost)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.RequestHostUsers)
                .WithOne(e => e.RequestHost)
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
            b.HasMany(e => e.RequestHosts)
               .WithOne(e => e.ServerAllocation)
               .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.IpAssignments)
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
            b.HasMany(e => e.RequestHostUsers)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.ClientCascade);
            b.HasMany(e => e.UserCustomers)
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
    }
}
