using Data.Entities;
using LoremNET;
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

        #region Service
        builder.Entity<Service>().HasData(new Service
        {
            Id = 1,
            Name = "Cấp bổ sung U",
            Type = "Size",
            Description = "Thuê Chỗ",
        });
        builder.Entity<Service>().HasData(new Service
        {
            Id = 2,
            Name = "Bổ sung IP",
            Type = "Ip",
            Description = "Thêm 1U",
        });
        builder.Entity<Service>().HasData(new Service
        {
            Id = 3,
            Name = "Thêm Port",
            Type = "Port",
            Description = "Công suất 100",
        });
        #endregion

        #region Device
        for (int i = 1; i <= 50; i++)
        {
            builder.Entity<Device>().HasData(new Device
            {
                Id = i,
                Type = i <= 10 ? "Hub" : "Server",
                Size = (int)Lorem.Number(2, 10),
                BasePower = (int)Lorem.Number(200, 500),
            });
        }
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
        builder.Entity<Rack>().HasData(racks.OrderBy(x => x.Id));

        for (int i = 1; i <= 30; i++)
        {
            builder.Entity<Location>().HasData(new Location
            {
                Id = i,
                StartPosition = (int)Lorem.Number(1, 30),
                RackId = i,
                DeviceId = i,
            });
        }

        #endregion

        #region IP
        builder.Entity<Network>().HasData(new Network
        {
            Id = 1,
            FirstOctet = 192,
            SecondOctet = 112,
            ThirdOctet = 121,
            SubnetMask = 24
        });
        builder.Entity<Network>().HasData(new Network
        {
            Id = 2,
            FirstOctet = 193,
            SecondOctet = 122,
            ThirdOctet = 111,
            SubnetMask = 25
        });

        for (int i = 1; i <= 200; i++)
        {
            builder.Entity<Ip>().HasData(new Ip
            {
                Id = i,
                Address = i,
                Type = Enums.IpType.Host,
                IsReserved = false,
                NetworkId = i % 2 == 0 ? 1 : 2,
            });
        }
        #endregion

        #region Server
        for (int i = 1; i <= 40; i++)
        {
            builder.Entity<Server>().HasData(new Server
            {
                Id = i,
                SerialNumber = Guid.NewGuid().ToString(),
                Model = Lorem.Words(3, true),
                NumberOfPort = 1,
                AdditionalNumberOfPort = 0,
                DeviceId = i + 10,
                IsDeleted = (i == 31 || i == 32) ? true : false,
            });

            builder.Entity<IpAssignment>().HasData(new IpAssignment
            {
                Id = i,
                DateAssign = DateTime.UtcNow,
                IsActive = (i == 31 || i == 32) ? false : true,
                IsDeleted = (i == 31 || i == 32) ? true : false,
                ServerId = i,
                IpId = i + 3
            });
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
            new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
        };

        #region Roles
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[0],
            Name = "Customer",
            Description = "Customer",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[1],
            Name = "Tech",
            Description = "IT Staff",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[2],
            Name = "Sale",
            Description = "Sale",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
        {
            Id = seedGuids[3],
            Name = "Manager",
            Description = "Manager",
            isDeactive = false,
        });
        builder.Entity<Role>().HasData(new Role
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
                for (int j = 1; j <= 5; j++)
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
                    RoleId = seedGuids[i - 1],
                    UserId = seedGuids[i - 1],
                });
            }
            #endregion
        }

        for (int i = 6; i <= 30; i++)
        {
            Guid id = Guid.NewGuid();
            builder.Entity<User>().HasData(new User
            {
                Id = id,
                UserName = $"customer{i - 5}",
                NormalizedUserName = $"customer{i - 5}",
                Email = Lorem.Email(),
                NormalizedEmail = Lorem.Email(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                Fullname = Lorem.Words(3, true),
                Address = $"{Lorem.Words(1)}/{Lorem.Words(1)}, {Lorem.Words(3)}",
                PhoneNumber = Lorem.Number(1000000000, 9999999999).ToString(),
                CurrenNoticeCount = 0,
                IsDeleted = false,
            });

            builder.Entity<UserRole>().HasData(new UserRole
            {
                RoleId = seedGuids[0],
                UserId = id,
            });

            builder.Entity<Customer>().HasData(new Customer
            {
                Id = i - 4,
                UserId = id,
                CompanyName = Lorem.Words(3),
                TaxNumber = (Math.Abs((int)Lorem.Number(1000000000, 9999999999))).ToString(),
                CompanyTypeId = (int)Lorem.Number(1, 5),
            });

            if (i - 5 <= 5)
            {
                builder.Entity<Request>().HasData(new Request
                {
                    Id = i - 5,
                    Status = Enums.RequestStatus.Incomplete,
                    ExpectedSize = 5,
                    Note = Lorem.Paragraph(20, 3),
                    DateCreated = DateTime.Now.AddMonths((int)Lorem.Number(-3, 3)),
                    DateAllocate = DateTime.Now.AddMonths((int)Lorem.Number(0, 7)),
                    InitialDateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    DateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    CustomerId = i - 4
                });
            }
            else if (i - 5 <= 10)
            {
                builder.Entity<Request>().HasData(new Request
                {
                    Id = i - 5,
                    Status = Enums.RequestStatus.Pending,
                    ExpectedSize = 5,
                    Note = Lorem.Paragraph(20, 3),
                    DateCreated = DateTime.Now.AddMonths((int)Lorem.Number(-3, 3)),
                    DateAllocate = DateTime.Now.AddMonths((int)Lorem.Number(0, 7)),
                    InitialDateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    DateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    CustomerId = i - 4
                });
            }
            else if (i - 5 <= 15)
            {
                builder.Entity<Request>().HasData(new Request
                {
                    Id = i - 5,
                    Status = Enums.RequestStatus.Accepted,
                    ExpectedSize = 5,
                    Note = Lorem.Paragraph(20, 3),
                    DateCreated = DateTime.Now.AddMonths((int)Lorem.Number(-3, 3)),
                    DateAllocate = DateTime.Now.AddMonths((int)Lorem.Number(0, 7)),
                    InitialDateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    DateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    CustomerId = i - 4,
                    ServerId = i - 15
                });
            }
            else if (i - 5 <= 20)
            {
                if (i - 5 == 16)
                {
                    for (int j = 16; j <= 45; j++)
                    {
                        builder.Entity<Request>().HasData(new Request
                        {
                            Id = j,
                            Status = Enums.RequestStatus.Ongoing,
                            ExpectedSize = 5,
                            Note = Lorem.Paragraph(20, 3),
                            DateCreated = DateTime.Now.AddMonths((int)Lorem.Number(-3, 3)),
                            DateAllocate = DateTime.Now.AddMonths((int)Lorem.Number(0, 7)),
                            InitialDateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                            DateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                            CustomerId = (int)Lorem.Number(16, 20),
                            ServerId = j - 10,
                        });
                    }
                }
            }
            else if (i - 5 <= 22)
            {
                builder.Entity<Request>().HasData(new Request
                {
                    Id = i + 20,
                    Status = Enums.RequestStatus.Denied,
                    ExpectedSize = 5,
                    Note = Lorem.Paragraph(20, 3),
                    DateCreated = DateTime.Now.AddMonths((int)Lorem.Number(-3, 3)),
                    DateAllocate = DateTime.Now.AddMonths((int)Lorem.Number(0, 7)),
                    InitialDateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    DateStop = DateTime.Now.AddYears((int)Lorem.Number(1, 3)),
                    CustomerId = i - 4,
                    ServerId = i + 10
                });
            }
            else if (i - 5 <= 25)
            {
                builder.Entity<Request>().HasData(new Request
                {
                    Id = i + 20,
                    Status = Enums.RequestStatus.Ended,
                    ExpectedSize = 5,
                    Note = Lorem.Paragraph(20, 3),
                    DateCreated = DateTime.Now.AddYears((int)Lorem.Number(-5, -4)),
                    DateAllocate = DateTime.Now.AddYears((int)Lorem.Number(-3, -2)),
                    InitialDateStop = DateTime.Now.AddYears((int)Lorem.Number(-1, 0)),
                    DateStop = DateTime.Now.AddYears((int)Lorem.Number(-1, 0)),
                    CustomerId = i - 4,
                    ServerId = i + 10
                });
            }
        }

        builder.Entity<Customer>().HasData(new Customer
        {
            Id = 1,
            UserId = seedGuids[0],
            CompanyName = "super",
            TaxNumber = "0000000000",
            CompanyTypeId = 1,
        });
        #endregion     
    }

    public static void FilterSoftDeleted(this ModelBuilder builder)
    {
        builder.Entity<ServiceRequest>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Approver>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Area>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Request>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<RequestExtendHistory>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<CompanyType>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Customer>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Device>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Executor>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Ip>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<IpAssignment>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Location>()
            .HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Network>()
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
    }
}
