using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class cascade_delete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0dd454c5-7742-41a6-a3cc-63070718d569", new DateTime(2023, 11, 15, 17, 3, 14, 159, DateTimeKind.Local).AddTicks(5475), new DateTime(2023, 11, 15, 17, 3, 14, 159, DateTimeKind.Local).AddTicks(5488), "AQAAAAIAAYagAAAAEPC19LjPk63mzGfwz6Mw3T+2x3RuvBfYcjohvZJ+K5HzMIEiU8shFALcuxfQyZqwAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e42c8efe-c2c3-49a0-bd0e-2269caade3c7", new DateTime(2023, 11, 15, 17, 3, 13, 997, DateTimeKind.Local).AddTicks(1649), new DateTime(2023, 11, 15, 17, 3, 13, 997, DateTimeKind.Local).AddTicks(1662), "AQAAAAIAAYagAAAAEGaZyTEMJf2+1v1XIadAYO2TryEPtjHvJW6uYWDGYJbPzrGF9pKFPLrSp7yxkF1zyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c6a8adb1-228e-490a-a732-9dda32d9c666", new DateTime(2023, 11, 15, 17, 3, 14, 87, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 11, 15, 17, 3, 14, 87, DateTimeKind.Local).AddTicks(7658), "AQAAAAIAAYagAAAAEGgjVk6gcsTLLfslpSxM2yVDy891MA6EYQT7vzbeLs5NoR+iYoTVhr7SxY8qO5uC3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b00c18ea-df9e-4556-9364-83e3b52b5021", new DateTime(2023, 11, 15, 17, 3, 13, 920, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 11, 15, 17, 3, 13, 920, DateTimeKind.Local).AddTicks(8564), "AQAAAAIAAYagAAAAEKTIneIL1jp51TAzLM/atdhSQRke/zoC5OAx3CHmv35PhusjiLgTB8YyHeZT13eNMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "eb0f8d37-37c3-42d6-beb8-274af9bfa02b", new DateTime(2023, 11, 15, 17, 3, 13, 848, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 11, 15, 17, 3, 13, 848, DateTimeKind.Local).AddTicks(2348), "AQAAAAIAAYagAAAAEGeR92S4FdRMXH2bVBy9MmVnwiREX9j1ZkE037AjPjQzjzIcFNSY8PI5q2sdjAdb4g==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2025), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2217), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2257), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2378), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2386), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2379), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2388), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2404), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2412), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2343), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2389), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2397), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2413), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2355), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2406), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2414), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2374), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2382), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2391), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2399), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2415), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2408), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2416), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2358), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2384), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2393), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2401), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2417), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2359), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2377), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2385), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2418), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2426), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2432), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2423), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2428), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2433), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2463), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2429), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2439), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2464), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2425), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2430), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2435), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2439), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2465), new DateTime(2023, 11, 15, 17, 3, 13, 843, DateTimeKind.Local).AddTicks(2465) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c328e953-3fe6-4bff-9ccb-1273856e8233", new DateTime(2023, 11, 15, 15, 3, 28, 78, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 11, 15, 15, 3, 28, 78, DateTimeKind.Local).AddTicks(6578), "AQAAAAIAAYagAAAAENitAt/Xff47ccV03ix2sLxCf/aSLMQtCkacgbnyRYCG0Hxhe3SePiL/5RnX+C52KA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "d503eda9-1f22-40dd-8c53-b557ed99c384", new DateTime(2023, 11, 15, 15, 3, 27, 919, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 11, 15, 15, 3, 27, 919, DateTimeKind.Local).AddTicks(2883), "AQAAAAIAAYagAAAAED62ye3UdxC0MtRcMkyF6/ViHL6WnsiAErSFqZ325y8khYyL8IDTreN2Z8uGNjkYfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a4a81137-3a92-4370-acd8-9acec4ee2396", new DateTime(2023, 11, 15, 15, 3, 27, 993, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 11, 15, 15, 3, 27, 993, DateTimeKind.Local).AddTicks(1688), "AQAAAAIAAYagAAAAELkuudSarVBo6o7ytWHVAdYkhJNBX8beW3/FrCsKWt+kzQXeJkQ/pAX8oLRwuH5fgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1c8ab246-4000-4a50-82f6-f210ec96b9b9", new DateTime(2023, 11, 15, 15, 3, 27, 851, DateTimeKind.Local).AddTicks(3260), new DateTime(2023, 11, 15, 15, 3, 27, 851, DateTimeKind.Local).AddTicks(3273), "AQAAAAIAAYagAAAAEJAA5UhBmQWSvuwrClTn8lqvbXh9hdRyi36uSNxwWcyajWB1HxsMy9hY99liTfQksA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "670c94b3-cdae-4649-ad92-69b736af6434", new DateTime(2023, 11, 15, 15, 3, 27, 782, DateTimeKind.Local).AddTicks(9870), new DateTime(2023, 11, 15, 15, 3, 27, 782, DateTimeKind.Local).AddTicks(9881), "AQAAAAIAAYagAAAAEIJdni8hxOWusFhEF8tNEOTLO+WW5OTlHB1UVvRFUolnmyl23Gd4yy94l+VZi7gsfA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5947), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5984), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6003), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6024), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6032), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6042), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6005), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6026), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6036), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6054), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6021), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6087), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6092), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6098), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6102), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6107), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6112), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6088), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6093), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6098), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6108), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6113), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6118), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6084), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6099), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6104), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6109), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6114), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6119), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6085), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6105), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6110), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6115), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6120), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6086), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6096), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6106), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6121), new DateTime(2023, 11, 15, 15, 3, 27, 777, DateTimeKind.Local).AddTicks(6121) });
        }
    }
}
