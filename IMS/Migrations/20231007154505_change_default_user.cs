using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class change_default_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "349205f1-69f6-4661-a945-bf5b6242eebe", "it@gmail.com", "it@gmail.com", "it", "AQAAAAIAAYagAAAAEAz0XcxPx9RjviSiWO7Up3djkCShwTd3wxDjddJ46Ca1M6apk4IsF+6ZvntbxwPg7w==", "it" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "609b5546-3d32-4c17-8126-ebdfd8aa196d", "staff@gmail.com", "staff@gmail.com", "staff", "AQAAAAIAAYagAAAAELPA/VneXTqkO28QpApw3GrlOgM2TYnVmmlRqsEUxqh5Twdp0caQXXvt1F9DucpZvw==", "staff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "bbc65bce-47b0-40a9-ba06-fe2e5ae4b0f1", "manager@gmail.com", "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEBMTuQhgx9fR71UnODX0b1fHPCzO3OVpnqKts6SdqbxYdzc0IcJLcsthcNPc4Dy1oQ==", "manager" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "f938ab94-9cd2-4351-92b2-61f20239504e", "admin@gmail.com", "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEDPP5lHza3HxQvmdTj5EkGrWLydgImuTV2uJxDldbZqPXVTDgQ1/ZSDgNl2FV3g6Vg==", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "8591b203-c691-4ea9-a4aa-33ee70465006", "member2@gmail.com", "member2@gmail.com", "member2@gmail.com", "AQAAAAIAAYagAAAAEAi+062tzBnHbuAEj9QXGdJvvxTAbvcVsEexJsdapk6GsFhTACGRXfglH23AVUCoqg==", "user2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "96c7d585-bcd1-4426-a548-27ea96a688b8", "member3@gmail.com", "member3@gmail.com", "member3@gmail.com", "AQAAAAIAAYagAAAAECA2q2LpdElLdB5wnlQbobl3b/vgq9qKAdREn9AqDknYG7JKR7tfzTSjDg74obLpxQ==", "user3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "4a826301-73fd-4656-9960-780d4cddb812", "member4@gmail.com", "member4@gmail.com", "member4@gmail.com", "AQAAAAIAAYagAAAAELhoUYxurQjMRKpjfHYsc8Cw2fnkUQjn+gzCSWMj+k+ScRLe9YMRE558tC55T/epRg==", "user4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "ff0bbeb1-4dae-4104-bf0a-5710876a2c2c", "member5@gmail.com", "member5@gmail.com", "member5@gmail.com", "AQAAAAIAAYagAAAAEFnDJJLbw+/XSEFejVTp+NLEv+H/ITLVOCkILU5lgD4W9DJeXbCQdr8oL4x2/LplIg==", "user5" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), 0, "Address1", "44b686e1-6084-4d5e-ab41-a5df630f98db", 0, "member1@gmail.com", true, "Fullname1", false, false, null, "member1@gmail.com", "member1@gmail.com", "AQAAAAIAAYagAAAAEDYwxMpcSDVjyzOkWi4HJ+64KVBW4lhKAN17Z8udJYgOSVd8gbP/Y3aPFMFGuTGMhg==", "0000000001", false, "", false, "user1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") });
        }
    }
}
