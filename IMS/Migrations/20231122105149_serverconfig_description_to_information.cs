using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class serverconfig_description_to_information : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ServerHardwareConfigs",
                newName: "Information");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "RequestUpgrades",
                newName: "Information");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5335), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5358), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8902152f-ccaf-411f-b81a-42786c59472b", new DateTime(2023, 11, 22, 17, 51, 47, 559, DateTimeKind.Local).AddTicks(4736), new DateTime(2023, 11, 22, 17, 51, 47, 559, DateTimeKind.Local).AddTicks(4754), "AQAAAAIAAYagAAAAEPPGBJPeOAViyR/2xypO8THDRzSs6+q2zU3LGgGRb6FUPRkD0LvPqhiP4pCQhxwH2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6b82a6e0-f97a-4b87-9b98-e781097b3d7b", new DateTime(2023, 11, 22, 17, 51, 47, 307, DateTimeKind.Local).AddTicks(6551), new DateTime(2023, 11, 22, 17, 51, 47, 307, DateTimeKind.Local).AddTicks(6566), "AQAAAAIAAYagAAAAEA7YBbfvRf/Xvo2Jr3/9xBMSxBuJ0iEXfMpfbWa2swzCXLGO+gyzjke5tNMwyc2Knw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "08beeec8-c29a-4a3f-ab44-2995ba95f0ff", new DateTime(2023, 11, 22, 17, 51, 47, 447, DateTimeKind.Local).AddTicks(5536), new DateTime(2023, 11, 22, 17, 51, 47, 447, DateTimeKind.Local).AddTicks(5551), "AQAAAAIAAYagAAAAEK4Oy+7VXdxkMb3E4ZHnLVthpVIg00h9Alh56U23/5Wt2r7u0tjT2FtrAb7IOboI3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a01e129c-b1a0-44c9-82da-8ddf1ce2ec2e", new DateTime(2023, 11, 22, 17, 51, 47, 117, DateTimeKind.Local).AddTicks(495), new DateTime(2023, 11, 22, 17, 51, 47, 117, DateTimeKind.Local).AddTicks(514), "AQAAAAIAAYagAAAAEK7plqlGI2VtOP8NqrKaKF9GAkjdHaFwUv/vkll79J+/ytGAQ3qmdTLrG1OG88cb3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "556c44d2-91fe-49db-a3d1-08d2e99a8cbe", new DateTime(2023, 11, 22, 17, 51, 47, 19, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 11, 22, 17, 51, 47, 19, DateTimeKind.Local).AddTicks(6050), "AQAAAAIAAYagAAAAEN0nGJ1hk9buqNwjrGYVBL5+rcALuAUkbXrGfaFNlxD3NxeNbX5m1VmgwRUeD6zz8g==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(4857), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5044), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5124), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5145), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Unit" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5162), "Cái" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Unit" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5178), "Cái" });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5391), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5408), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5396), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5423), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5447), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5468), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5398), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5411), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5437), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5448), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5480), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5413), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5426), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5438), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5450), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5460), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5471), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5482), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5401), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5462), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5472), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5483), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5416), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5429), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5441), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5452), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5463), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5473), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5484), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5405), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5417), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5431), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5486), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5432), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5443), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5476), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5489), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5571), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5545), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5564), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5557), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5566), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5559), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5585), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5593), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5561), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5612) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Information",
                table: "ServerHardwareConfigs",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Information",
                table: "RequestUpgrades",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3122), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "037af667-46ca-421f-8e85-dc9993f4c18b", new DateTime(2023, 11, 22, 16, 22, 2, 555, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 11, 22, 16, 22, 2, 555, DateTimeKind.Local).AddTicks(2227), "AQAAAAIAAYagAAAAEPHqLnUFGs6692TyPaFK/QeoeXAquieZ/5iP/ygwNHKowNMwUPomvJ0wiuCtXtH2NQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f5e653cc-1ebc-48d8-9b6e-e082ecc476c5", new DateTime(2023, 11, 22, 16, 22, 2, 394, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 11, 22, 16, 22, 2, 394, DateTimeKind.Local).AddTicks(3591), "AQAAAAIAAYagAAAAEJy+PC6LWm2O4wM44qBiX8LgUd8/3t3LeSGKH+OxKvSg604GfxTAwXryWNvVIDMq7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6c322e43-ec05-48ac-aeee-cedb258a7abd", new DateTime(2023, 11, 22, 16, 22, 2, 468, DateTimeKind.Local).AddTicks(7195), new DateTime(2023, 11, 22, 16, 22, 2, 468, DateTimeKind.Local).AddTicks(7210), "AQAAAAIAAYagAAAAEJRivX/byHyRBlQoltwN0Zz+EDeT2OYEosmuk2cI0d2CRSOTwHAmpeR3YmyqVppLOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e062629e-84d1-421f-a645-adb0fc43daa3", new DateTime(2023, 11, 22, 16, 22, 2, 316, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 11, 22, 16, 22, 2, 316, DateTimeKind.Local).AddTicks(8992), "AQAAAAIAAYagAAAAENWdwpDKj19+8ZxnvEyffbm1/Aahin3yu4SVlZqRtdBcS2/dYq3wHCtM4JquB1eEIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b20745bf-3d41-48f0-8efe-ab8b0ed607fc", new DateTime(2023, 11, 22, 16, 22, 2, 247, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 11, 22, 16, 22, 2, 247, DateTimeKind.Local).AddTicks(5505), "AQAAAAIAAYagAAAAEBxvPJXg6Q7R8Ci238KDFEO8neKQ+addw45rtiGhVlLf2ALMc2OXgfDWaywq8W0AwA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Unit" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3050), "Gb" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "Unit" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3063), "Gb" });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3181), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3206), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3183), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3208), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3223), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3211), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3179), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3213), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3180), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3205), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3213), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3265), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3251), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3266), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3271), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3267), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3272), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3248), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3258), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3268), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3282), new DateTime(2023, 11, 22, 16, 22, 2, 242, DateTimeKind.Local).AddTicks(3283) });
        }
    }
}
