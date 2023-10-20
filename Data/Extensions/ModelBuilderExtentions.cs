using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions;

public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region CompanyType
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 1,
            Name = "Doanh nghiệp tư nhân",
            Description = "Doanh nghiệp tư nhân",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 2,
            Name = "Công ty trách nhiệm hữu hạn một thành viên",
            Description = "Công ty trách nhiệm hữu hạn một thành viên",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 3,
            Name = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
            Description = "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 4,
            Name = "Công ty cổ phần",
            Description = "Công ty cổ phần",
        });
        modelBuilder.Entity<CompanyType>().HasData(new CompanyType
        {
            Id = 5,
            Name = "Công ty hợp danh",
            Description = "Công ty hợp danh",
        });
        #endregion

        #region Service
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 1,
            Name = "Thuê Chỗ",
            Description = "Thuê Chỗ",
        });
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 2,
            Name = "Thêm 1U",
            Description = "Thêm 1U",
        });
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 3,
            Name = "Công suất 100",
            Description = "Công suất 100",
        });
        #endregion

        #region User
        var hasher = new PasswordHasher<User>();

        List<Guid> seedGuids = new List<Guid>
        {
            new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
            new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
            new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
            new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
            new Guid("285135ab-c67d-4285-b689-7e88e7f610f9")
        };

        #region Roles
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[0],
            Name = "Customer",
            Description = "Customer",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[1],
            Name = "Tech",
            Description = "IT Staff",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[2],
            Name = "Sale",
            Description = "Sale",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[3],
            Name = "Manager",
            Description = "Manager",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[4],
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

            modelBuilder.Entity<User>().HasData(new User
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
                for (int j = 1; j <= 5; j++)
                {
                    modelBuilder.Entity<UserRole>().HasData(new UserRole
                    {
                        RoleId = seedGuids[j - 1],
                        UserId = seedGuids[i - 1],
                    });

                }
            }
            else
            {
                modelBuilder.Entity<UserRole>().HasData(new UserRole
                {
                    RoleId = seedGuids[i - 1],
                    UserId = seedGuids[i - 1],
                });
            }
            #endregion
        }
        modelBuilder.Entity<Customer>().HasData(new Customer
        {
            Id = 1,
            UserId = seedGuids[0],
            CompanyName = "super",
            TaxNumber = "0000000000",
            CompanyTypeId = 1,
        });
        #endregion

        #region Device
        modelBuilder.Entity<Device>().HasData(new Device
        {
            Id = 1,
            Type = "Mock",
            NumberOfPort = 3,
            Status = Enums.DeviceStatus.Running,
            Size = 2,
            BasePower = 200,
        });
        #endregion

        #region Location
        modelBuilder.Entity<Area>().HasData(new Area
        {
            Id = 1,
            Name = "A",
            RowCount = 8,
            ColumnCount = 8,
        });
        modelBuilder.Entity<Area>().HasData(new Area
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
                    CurrentPower = (j - 1) * 8 + i == 1 ? 200 : 0,
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
                    CurrentPower = 0,
                    Column = i,
                    Row = j,
                    Size = 42,
                    AreaId = 2
                });
            }
        }
        modelBuilder.Entity<Rack>().HasData(racks.OrderBy(x => x.Id));

        modelBuilder.Entity<Location>().HasData(new Location
        {
            Id = 1,
            StartPosition = 2,
            RackId = 1,
            DeviceId = 1,
        });

        #endregion
    }

    private static Guid GenerateSeededGuid(int seed)
    {
        var r = new Random(seed);
        var guid = new byte[16];
        r.NextBytes(guid);

        return new Guid(guid);
    }
}
