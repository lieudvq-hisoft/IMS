using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Data.Extensions;

public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region User
        var hasher = new PasswordHasher<User>();

        List<Guid> seedGuids = new List<Guid>();
        for (int i = 1; i <= 5; i++)
        {
            seedGuids.Add(GenerateSeededGuid(i));
        }

        #region Roles
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(1),
            Name = "Customer",
            Description = "Customer",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(2),
            Name = "IT",
            Description = "IT Staff",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(3),
            Name = "Staff",
            Description = "Staff",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(4),
            Name = "Manager",
            Description = "Manager",
            isDeactive = false,
        });
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = GenerateSeededGuid(5),
            Name = "Admin",
            Description = "Admin",
            isDeactive = false,
        });
        #endregion

        for (var i = 1; i <= 5; i++)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = seedGuids[i - 1],
                UserName = "user" + i.ToString(),
                NormalizedUserName = "member" + i.ToString() + "@gmail.com",
                Email = "member" + i.ToString() + "@gmail.com",
                NormalizedEmail = "member" + i.ToString() + "@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "12345678"),
                SecurityStamp = string.Empty,
                FirstName = "FirstName" + i,
                LastName = "LastName" + i,
                Address = "Address" + i,
                PhoneNumber = "000000000" + i,
                isDelete = false,
                CurrenNoticeCount = 0,
                FcmToken = "token" + i,
            });

            #region UserRole
            modelBuilder.Entity<UserRole>().HasData(new UserRole
            {
                RoleId = GenerateSeededGuid(i),
                UserId = GenerateSeededGuid(i),
            });
            #endregion
        }
        #endregion

        #region Customer
        modelBuilder.Entity<Customer>().HasData(new Customer
        {
            Id = 1,
            CompanyName = "Company 1",
            CompanyRepresentative = "Representative 1",
            TaxNumber = "taxnumber1",
            UserId = seedGuids[0]
        });
        modelBuilder.Entity<Customer>().HasData(new Customer
        {
            Id = 2,
            CompanyName = "Company 2",
            CompanyRepresentative = "Representative 2",
            TaxNumber = "taxnumber2",
            UserId = seedGuids[1]
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
