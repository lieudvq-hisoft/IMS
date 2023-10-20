using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class seed_super_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd") },
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba") },
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d393ecc-0d69-4518-8c74-6fd365973ba7", "AQAAAAIAAYagAAAAEP+Bu05kNeyt9Q0sLjFQoWajpuHAzrYIG9hVKex2hBR/iVOeqeBbz0mVGFdnMorCTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2df02a47-e12d-42ac-8fc4-75192a0a71df", "AQAAAAIAAYagAAAAEE3aWh5cif7QzxZ/+jHl6J89qtgt8CZkh9PTRPLV3BHmyxu3J+xVQi53zY1a+RGZJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ed9f441-5319-4897-aae3-3b529d7c8f4b", "AQAAAAIAAYagAAAAELGx/04U+M3umRPFH+x6FekrWTR5Ki4VQFEDBJtXqCxfjohXWhhJ9ZAKfmavIRB+OQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3079d340-e8bf-48ff-b346-ec0e95a6a7d4", "AQAAAAIAAYagAAAAENO3JLY1JPCc6v1iO7RsgXQY7aAYzBVksqNt6FDrk0Ar2CGr4quIZg8bW4Tb8xW42A==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), 0, "Address1", "91e08197-7a1f-4150-8fcd-0ab578a0c561", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEHPr6BGXszRLHACJeZ2l3SPDyVXKN2i7/O3qfvMm3CBOHD39YXlab/j0titkKPNnrw==", "0000000001", false, "", false, "super" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(371), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(447), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(465), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2792), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2794), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2779), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2794), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2789), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2796), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2797), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2861), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2888), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2880), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2889), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2893), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2866), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2883), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 10, 20, 10, 52, 35, 279, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 10, 20, 10, 52, 34, 880, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16eba310-335f-4c15-8065-e892c95f6e94", "AQAAAAIAAYagAAAAEG/DtW4rHsWyVp7RsVHB1RxBteizFEbX9SN22zw3rTilSxGFOiBC/8oAHxzUp1jymg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6de3d884-cfda-42dd-9d5d-1ed1c4acc3ef", "AQAAAAIAAYagAAAAEEeeUZ8UMjn1lC88t/R35cLBoMX9kVzRnBVRAS4Ap6tXl4LRqAKDaghAwcKb1i7DRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f30fdce0-81e8-4618-b308-efe2e394eade", "AQAAAAIAAYagAAAAED+VouIz6KM3DDTJBuqbSKqzbjDi1adEcnuNL4EWnbA5o1vAN4fSwjrjfAfjlnC34g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d90f3c38-efab-467e-9fe0-bea70d888544", "AQAAAAIAAYagAAAAEIUdqGIg8G0G5DUIayGCayREy1WreRi+ewr//duTWsPB/XSWpSBtyuruhViP7ETjnA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2528), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2716), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2554), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2794), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2797), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3004), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3122), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3267), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3031), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 10, 19, 17, 13, 10, 781, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4746), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 10, 19, 17, 13, 10, 174, DateTimeKind.Local).AddTicks(4820) });
        }
    }
}
