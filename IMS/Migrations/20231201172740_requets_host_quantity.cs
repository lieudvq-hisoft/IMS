using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class requets_host_quantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "RequestHosts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9420ec58-b3ee-4b79-8642-44ed5bab0c04", new DateTime(2023, 12, 2, 0, 27, 37, 992, DateTimeKind.Local).AddTicks(6743), new DateTime(2023, 12, 2, 0, 27, 37, 992, DateTimeKind.Local).AddTicks(6770), "AQAAAAIAAYagAAAAEKr5jNBEbQq8/1AdjWDCND0fxNcZAPNQ/uyFQEhhpnw+77snYRMjHXkcjc6AWb1cHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e75193a3-ab8e-417e-a5b1-305f071e0ec1", new DateTime(2023, 12, 2, 0, 27, 37, 677, DateTimeKind.Local).AddTicks(6588), new DateTime(2023, 12, 2, 0, 27, 37, 677, DateTimeKind.Local).AddTicks(6606), "AQAAAAIAAYagAAAAEO5t22S3lA1n01EwYvgCNTN/y2sxddltlTpq0PhFzh0HO7G6yzHnOVvsJ+9N4b/05A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a498ed88-642a-46c1-8323-475de3ca0cc0", new DateTime(2023, 12, 2, 0, 27, 37, 861, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 12, 2, 0, 27, 37, 861, DateTimeKind.Local).AddTicks(8035), "AQAAAAIAAYagAAAAEBK3Rtu9dvJxSvazwIJ0lGx5LcIjErrwNr2a5L43ui6LMQa2WK+AB353c2azq+hrMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5ee0b1b9-c62a-4206-a669-db527a5ce5e6", new DateTime(2023, 12, 2, 0, 27, 37, 583, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 12, 2, 0, 27, 37, 583, DateTimeKind.Local).AddTicks(4473), "AQAAAAIAAYagAAAAEJ4Wpeg46vORMMyhCjZTisja48QKjV12clKLTbHec1xLoptBVkHDmudolsmNASpWSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2e5210d2-94eb-4feb-8faa-686556b08053", new DateTime(2023, 12, 2, 0, 27, 37, 468, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 12, 2, 0, 27, 37, 468, DateTimeKind.Local).AddTicks(7258), "AQAAAAIAAYagAAAAEIoM17IbMy5GMBB0hH7Q2+v2eNn3Kj3Q1f+oL5WrDFLMV09Mzp2cgMdWoWLrWjHoHw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(1957), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2124), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2352), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2367), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2355), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2369), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2384), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2343), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2359), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2374), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2514), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2346), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2362), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2515), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2348), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2364), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2377), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2365), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2379), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2505), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2519), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2543), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2575), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2583), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2576), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2585), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2529), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2562), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2588), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2589), new DateTime(2023, 12, 2, 0, 27, 37, 461, DateTimeKind.Local).AddTicks(2590) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RequestHosts");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bc250a92-631f-4549-ad84-5fab072b1e06", new DateTime(2023, 12, 2, 0, 12, 28, 537, DateTimeKind.Local).AddTicks(3913), new DateTime(2023, 12, 2, 0, 12, 28, 537, DateTimeKind.Local).AddTicks(3926), "AQAAAAIAAYagAAAAEHDxbeAW8b3vLTB2QcWCTuCEP+YhZ+bJ7Og8SKkoHaTfbFAwPTrgKnoO9lv8frtj+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "63f677fe-05d6-4c02-ad93-1116bef71323", new DateTime(2023, 12, 2, 0, 12, 28, 393, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 12, 2, 0, 12, 28, 393, DateTimeKind.Local).AddTicks(2819), "AQAAAAIAAYagAAAAEC3zdix4iXnzWyOC5yZ1y5I9GU/Y3VGdOIAnGejlB7mHhAXwU4SDaWVb+QN7oEWq0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3a603012-0910-469c-b9f5-1e37eb99a57c", new DateTime(2023, 12, 2, 0, 12, 28, 462, DateTimeKind.Local).AddTicks(831), new DateTime(2023, 12, 2, 0, 12, 28, 462, DateTimeKind.Local).AddTicks(844), "AQAAAAIAAYagAAAAEBVdXzhyCDE8FqFLdgN7srS2CpfIQFPs7CQkluHKq/zf8yg+cq33hNMW3b5x1LTb1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3ef61fdd-410d-43f1-9c36-80ac89ad556a", new DateTime(2023, 12, 2, 0, 12, 28, 318, DateTimeKind.Local).AddTicks(4002), new DateTime(2023, 12, 2, 0, 12, 28, 318, DateTimeKind.Local).AddTicks(4015), "AQAAAAIAAYagAAAAEGlhWrwztV5TnutditCUNN8II4Br+eKMpT4FwzaUZAAq+XHh4rg9KxKcQRAeMxzElA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9bdac291-9a93-4a9f-95cc-b96567bc0c0a", new DateTime(2023, 12, 2, 0, 12, 28, 251, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 12, 2, 0, 12, 28, 251, DateTimeKind.Local).AddTicks(3168), "AQAAAAIAAYagAAAAECIAsLMihCuEYDB1070pH4/XrUs73ywnLdJfaVQ77ft632kmNHt/LFqQeaLT2y5/cA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8529), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8914), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8905), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8925), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8916), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8912), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8903), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8927), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 2, 0, 12, 28, 245, DateTimeKind.Local).AddTicks(8938) });
        }
    }
}
