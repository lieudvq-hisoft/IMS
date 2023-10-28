using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class add_unique_constraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8e14a4cb-bc42-45a0-b463-5e481262ad0d", "AQAAAAIAAYagAAAAECynAmwxgJs0krU2FZuv7NqRZM5iiIHVN2kTFQeqMd68pan+/DryCx/H2H46rjrrAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7c2ceb32-2e7e-4ef3-8480-a06fc260e573", "AQAAAAIAAYagAAAAEBIVfmX2LFgfYoYrAplg2rYPAsj1xbXnbUQQ/5bA+6svN3nGtRwKaIwEILE5eI9LkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a9f87f9-2a9c-4bbe-ba23-69273f07d7ee", "AQAAAAIAAYagAAAAEJTwFPn9mxOQHzV8FMi1XvbYxg5JfyIZJU6KiGe0y2KAPb1pVVT5Em/2RbWNzYNkSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ccc6bd0-18bf-46a8-bedf-4d00afc6b90f", "AQAAAAIAAYagAAAAEC3QIjmxEBrTuHbLE28RNggKTnEpu8/Yf7kzVtslKSU7w/rxrlkLUnz/eXaNGSVh2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "565d0b43-a9e4-4717-8031-171751cd276a", "AQAAAAIAAYagAAAAELm++6NraGC8P0Wx0vOHomBu+rBX1ORWdbC23nX7b9Xkpr2lAq9ULeOfDhCc64Wiig==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1536), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1570), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8409), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(57), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(64), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(86), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(92), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(164), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(180), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(186), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(199), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(212), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(240), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(281), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(294), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(403), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(423), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(437), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(457), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(545), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(552), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(579), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(706), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(713), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(723), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(730), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(737), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(744), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(751), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(764), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(771), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(778), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(784), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(791), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(797), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(804), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(811), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(818), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(824), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(831), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(837), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(844), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(851), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(857), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(917), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(924), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(995), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1002), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1024), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1064), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1071), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1078), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1084), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1097), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1110), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1130), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1144), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1215), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1224), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1237), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1257), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1264), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1272), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1292), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1305), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1319), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1348), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1355), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1556), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1570), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1619), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1633), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1640), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1647), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1654), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1669), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1683), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1698), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1705), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1796), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1836), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1843), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1850), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1877), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1883), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1890), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1897), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1903), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1916), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1923), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1929), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1936), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1943), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1950), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2052), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2099), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2105), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2124), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2137), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(12), new DateTime(2023, 10, 27, 15, 55, 49, 996, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8560), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8719), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8563), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8697), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8537), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8564), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8698), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8565), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8576), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8712), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8724), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8567), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8578), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8701), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8556), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8568), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8702), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8558), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8571), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8736), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 10, 27, 15, 55, 49, 524, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.CreateIndex(
                name: "IX_Servers_SerialNumber",
                table: "Servers",
                column: "SerialNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ips_Address_NetworkId",
                table: "Ips",
                columns: new[] { "Address", "NetworkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxNumber",
                table: "Customers",
                column: "TaxNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Name",
                table: "Areas",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Servers_SerialNumber",
                table: "Servers");

            migrationBuilder.DropIndex(
                name: "IX_Ips_Address_NetworkId",
                table: "Ips");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TaxNumber",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Areas_Name",
                table: "Areas");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1197), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1207), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "59be7cc0-f1c5-422f-b7b3-d1484192c83e", "AQAAAAIAAYagAAAAELfjW3FK2oGGvYPApFIokzKdNKqbISSdV450BwlWTKmSY3oNZia1AUQzgMcJrFF+pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c523f732-eba5-4abb-a4b5-48d6290a318c", "AQAAAAIAAYagAAAAEPK8l+0XMX0Io586Qevb6Fv2R+4m2Z22DkfD9F2J5643lXGlKXGTDM4OFXOMqMSREw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7861b4f3-1769-4f81-aee1-0a676fb0c4e9", "AQAAAAIAAYagAAAAEGpmezMbZ1uBUpVdbLLAXUMcW4Q+zLM8ufS0EhBr+e+/VJgRAFUsLJ5Look5r1oHpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eab137c-3026-4ecf-953f-26437cbb7e80", "AQAAAAIAAYagAAAAEGk8m35jKPFV9qvy1g3HW902gA2uV+zbq0MGpJ6HMMqY8dl7t5CgVu0bWKKhIury4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b13415fd-c81f-4fc7-9cd3-d19e27fb6209", "AQAAAAIAAYagAAAAEDW+CSC7YPfX8T85FYEI6UAPCxwsIFrPFvz2AR1lKktMflaE0nN5gk5MOyLSUJyf3A==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1155), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1180), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2414), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2417), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2421), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2428), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2448), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2469), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2486), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2591), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2609), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2851), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2943), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2953), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3140), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3168), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3171), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3182), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3266), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2148), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1214), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1229), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1237), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1252), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1378), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1392), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1220), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1246), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1379), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1239), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1373), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1380), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1387), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1394), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1240), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1248), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1373), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1381), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1224), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1241), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1249), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1381), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1396), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1225), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1242), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1249), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1375), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1396), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1235), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1376), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1397), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1384), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1398), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1400), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1405), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1414), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1423), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1428), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1432), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1402), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1406), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1411), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1415), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1420), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1424), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1428), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1433), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1407), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1416), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1420), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1425), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1417), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1421), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1426), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1430), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1404), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1409), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1422), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1427), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1431), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1435), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 10, 27, 15, 44, 56, 626, DateTimeKind.Local).AddTicks(2615) });
        }
    }
}
