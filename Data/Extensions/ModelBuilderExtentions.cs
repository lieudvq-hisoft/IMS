using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Data.Extensions;

public static class ModelBuilderExtentions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region User
        var hasher = new PasswordHasher<User>();
        Guid GenerateSeededGuid(int seed)
        {
            var r = new Random(seed);
            var guid = new byte[16];
            r.NextBytes(guid);

            return new Guid(guid);
        }
        for (var i = 1; i<=5; i++) {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = GenerateSeededGuid(i),
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
                Gender = (i % 2 == 0) ? true : false,
                Age = "2" + i,
                IdenficationNumber = "001183000001",
                IdenficationConfirm = true,
                IsGoogle = true,
                isBlock = true,
                isDelete = false,
                CurrenNoticeCount = 0,
                FcmToken = "token"+i,
                UserAva = "Avatar" + i,
            }); ;
        }
        #endregion
    }
}
