using Data.Entities;
using Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions;

public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder builder)
    {
        #region CompanyType
        builder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 1,
            Name = "Doanh nghiệp tư nhân",
            Description = "Doanh nghiệp tư nhân",
        });
        builder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 2,
            Name = "Công ty trách nhiệm hữu hạn một thành viên",
            Description = "Công ty trách nhiệm hữu hạn một thành viên",
        });
        builder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 3,
            Name = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
            Description = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
        });
        builder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 4,
            Name = "Công ty cổ phần",
            Description = "Công ty cổ phần",
        });
        builder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 5,
            Name = "Công ty hợp danh",
            Description = "Công ty hợp danh",
        });
        #endregion

        #region Component
        builder.Entity<Component>().HasData(new Component
        {
            Id = 1,
            Name = "CPU",
            Unit = "Cái"
        });
        builder.Entity<Component>().HasData(new Component
        {
            Id = 2,
            Name = "GPU",
            Unit = "Cái"
        });
        builder.Entity<Component>().HasData(new Component
        {
            Id = 3,
            Name = "RAM",
            Unit = "Gb"
        });
        builder.Entity<Component>().HasData(new Component
        {
            Id = 4,
            Name = "OS",
            Unit = "Cái"
        });
        builder.Entity<Component>().HasData(new Component
        {
            Id = 5,
            Name = "ROM",
            Unit = "Cái"
        });
        #endregion

        //#region Location
        //builder.Entity<Area>().HasData(new Area
        //{
        //    Id = 1,
        //    Name = "A",
        //    RowCount = 8,
        //    ColumnCount = 8,
        //});
        //builder.Entity<Area>().HasData(new Area
        //{
        //    Id = 2,
        //    Name = "B",
        //    RowCount = 5,
        //    ColumnCount = 8,
        //});

        //List<Rack> racks = new List<Rack>();
        //for (int i = 1; i <= 8; i++)
        //{
        //    for (int j = 1; j <= 8; j++)
        //    {
        //        racks.Add(new Rack
        //        {
        //            Id = (j - 1) * 8 + i,
        //            MaxPower = 3000,
        //            CurrentPower = (j - 1) * 8 + i == 1 ? 200 : 0,
        //            Column = i,
        //            Row = j,
        //            Size = 42,
        //            AreaId = 1
        //        });
        //    }
        //}

        //for (int i = 1; i <= 8; i++)
        //{
        //    for (int j = 1; j <= 5; j++)
        //    {
        //        racks.Add(new Rack
        //        {
        //            Id = 8 * 8 + (j - 1) * 8 + i,
        //            MaxPower = 3500,
        //            CurrentPower = 0,
        //            Column = i,
        //            Row = j,
        //            Size = 42,
        //            AreaId = 2
        //        });
        //    }
        //}
        //builder.Entity<Rack>().HasData(racks.OrderBy(x => x.Id));

        //int locationId = 1;
        //for (int i = 1; i <= 104; i++)
        //{
        //    for (int j = 1; j <= 42; j++)
        //    {
        //        builder.Entity<Location>().HasData(new Location
        //        {
        //            Id = locationId++,
        //            Position = j,
        //            RackId = i
        //        });
        //    }
        //}
        //#endregion

        #region IP
        //builder.Entity<Network>().HasData(new Network
        //{
        //    Id = 1,
        //    FirstOctet = 192,
        //    SecondOctet = 112,
        //    ThirdOctet = 121,
        //    SubnetMask = 24
        //});
        //builder.Entity<Network>().HasData(new Network
        //{
        //    Id = 2,
        //    FirstOctet = 193,
        //    SecondOctet = 122,
        //    ThirdOctet = 111,
        //    SubnetMask = 25
        //});

        //for (int i = 1; i <= 200; i++)
        //{
        //    builder.Entity<Ip>().HasData(new Ip
        //    {
        //        Id = i,
        //        Address = i,
        //        IsReserved = false,
        //        NetworkId = i % 2 == 0 ? 1 : 2,
        //    });
        //}
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
            Name = "Manager",
            Description = "Manager",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[3],
            Name = "Admin",
            Description = "Admin",
            isDeactive = false,
        });
        #endregion

        for (var i = 1; i <= 5; i++)
        {
            var username = "";
            switch (i)
            {
                case 1:
                    username = "super";
                    break;
                case 2:
                    username = "tech";
                    break;
                case 3:
                    username = "sale";
                    break;
                case 4:
                    username = "manager";
                    break;
                case 5:
                    username = "admin";
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
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                Fullname = "Fullname" + i,
                Address = "Address" + i,
                PhoneNumber = "000000000" + i,
                CurrenNoticeCount = 0,
                IsDeleted = false,
            });

            #region UserRole
            if (i == 1)
            {
                for (int j = 1; j <= 4; j++)
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

        //#region Service
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 1,
        //    Name = "Location",
        //    Type = ServiceType.Location,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 2,
        //    Name = "Expand",
        //    Type = ServiceType.Expand,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 3,
        //    Name = "Ip",
        //    Type = ServiceType.Ip,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 4,
        //    Name = "MasterIp",
        //    Type = ServiceType.MasterIp,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 5,
        //    Name = "Port",
        //    Type = ServiceType.Port,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 6,
        //    Name = "PortPower",
        //    Type = ServiceType.PortPower,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 7,
        //    Name = "Power",
        //    Type = ServiceType.Power,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 8,
        //    Name = "Component",
        //    Type = ServiceType.Component,
        //});
        //builder.Entity<Service>().HasData(new Service
        //{
        //    Id = 9,
        //    Name = "Appointment",
        //    Type = ServiceType.Appointment,
        //});
        //#endregion
    }

    public static void FilterSoftDeleted(this ModelBuilder builder)
    {
        //builder.Entity<Area>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<CompanyType>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Customer>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<ServerHardwareConfig>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Component>().HasQueryFilter(x => !x.IsDeleted);
        //builder.Entity<IpAddress>().HasQueryFilter(x => !x.IsDeleted);
        //builder.Entity<IpAssignment>().HasQueryFilter(x => !x.IsDeleted);
        //builder.Entity<Location>().HasQueryFilter(x => !x.IsDeleted);
        //builder.Entity<IpSubnet>().HasQueryFilter(x => !x.IsDeleted);
        //builder.Entity<Rack>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<ServerAllocation>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Role>().HasQueryFilter(x => !x.isDeactive);
        //builder.Entity<Request>().HasQueryFilter(x => !x.IsDeleted);
        //builder.Entity<Service>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<User>().HasQueryFilter(x => !x.IsDeleted);
    }
}
