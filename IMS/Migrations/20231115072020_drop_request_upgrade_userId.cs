using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class drop_request_upgrade_userId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestUpgrades_AspNetUsers_UserId1",
                table: "RequestUpgrades");

            migrationBuilder.DropIndex(
                name: "IX_RequestUpgrades_UserId1",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "RequestUpgrades");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "89a5daa5-79a0-4671-8508-6d3511ae8ca4", new DateTime(2023, 11, 15, 14, 20, 19, 358, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 11, 15, 14, 20, 19, 358, DateTimeKind.Local).AddTicks(8099), "AQAAAAIAAYagAAAAEJRgWqem8K+qQekUFh+MVkTRFV4c13+SfuDtevK4UY4I1dfKA6hNkOFCP0sIR3VjCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4a691283-9ce5-43e8-bce8-cb4fb68c92e0", new DateTime(2023, 11, 15, 14, 20, 19, 188, DateTimeKind.Local).AddTicks(8423), new DateTime(2023, 11, 15, 14, 20, 19, 188, DateTimeKind.Local).AddTicks(8438), "AQAAAAIAAYagAAAAEJQG3jSeJHYzILhwSvwcbRNxN82tsYl/eI/0imlTTNjOPEFoVlVOKdusa1mIyzB+vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8ca04274-dc2d-4d3d-a035-327acd413b6a", new DateTime(2023, 11, 15, 14, 20, 19, 275, DateTimeKind.Local).AddTicks(2535), new DateTime(2023, 11, 15, 14, 20, 19, 275, DateTimeKind.Local).AddTicks(2547), "AQAAAAIAAYagAAAAENtG1qziskXhkRW7X1cZ2S1NcN00GycvMP1PVSeubVTkr+eU0FCC2VYHEtM8OUwMTg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0c803d3c-9f58-4041-8910-713ea4b4fa7b", new DateTime(2023, 11, 15, 14, 20, 19, 101, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 11, 15, 14, 20, 19, 101, DateTimeKind.Local).AddTicks(8090), "AQAAAAIAAYagAAAAEOeBqANSza3vRjG0lcrdWnrPJ4U9uRdkCk0alNwZ8b7tuF531vFGgzF0iNFNVLrvkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b417743f-078d-4759-b435-7a48cdd9f9c1", new DateTime(2023, 11, 15, 14, 20, 19, 32, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 11, 15, 14, 20, 19, 32, DateTimeKind.Local).AddTicks(8133), "AQAAAAIAAYagAAAAEIsffABIDkEcSnDS9RgX8urV+QMtzVW79ZKrBuLlPvw8OmSn1ByUC5zC+V5MM6JaWg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2001), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2013), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2038), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2217), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2226), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2220), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2237), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2221), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2222), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2223), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2240), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2225), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2233), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2332), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2337), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2303), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2309), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2335), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 11, 15, 14, 20, 19, 28, DateTimeKind.Local).AddTicks(2342) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RequestUpgrades",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "RequestUpgrades",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9345), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3c279b90-a0cc-4723-ab49-f8ad95255a55", new DateTime(2023, 11, 15, 11, 32, 26, 491, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 11, 15, 11, 32, 26, 491, DateTimeKind.Local).AddTicks(6352), "AQAAAAIAAYagAAAAEEGWHSkDtU0uHZ+Bfeqbjh9zl89rYIYOX9KPQsE9lluaFNW7fuvD+uH9utw7Ypwihw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ed0599bd-2e12-4ea6-8635-d20502475f71", new DateTime(2023, 11, 15, 11, 32, 26, 350, DateTimeKind.Local).AddTicks(9639), new DateTime(2023, 11, 15, 11, 32, 26, 350, DateTimeKind.Local).AddTicks(9703), "AQAAAAIAAYagAAAAEDcCn3gXrSe3xg8cwDwpelP9TjYiibMBvU5YzpSRg0Ire4CSPzqSq3HGDI8IBO27wA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b6f25910-1f2a-4463-aee2-20f0d6c9ba73", new DateTime(2023, 11, 15, 11, 32, 26, 421, DateTimeKind.Local).AddTicks(5534), new DateTime(2023, 11, 15, 11, 32, 26, 421, DateTimeKind.Local).AddTicks(5546), "AQAAAAIAAYagAAAAEFLy5ZE9vipb+7zvqDvV7qk0cbauAet6XFWDqLaPUwikreB9U57XRKh4RuEO9U4Q8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1cc5d827-c621-49fa-894f-07a8e1885672", new DateTime(2023, 11, 15, 11, 32, 26, 283, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 11, 15, 11, 32, 26, 283, DateTimeKind.Local).AddTicks(588), "AQAAAAIAAYagAAAAECh7ddO719etwXQoNgwwRzvzwb5W8CIjPAUzFdzDO+09PKUl7MDdi+QOPFJZco3NuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f48aa5de-9b73-45b5-8470-42bcdc4a5cbf", new DateTime(2023, 11, 15, 11, 32, 26, 213, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 11, 15, 11, 32, 26, 213, DateTimeKind.Local).AddTicks(7878), "AQAAAAIAAYagAAAAEF8WhcD3K9f6EtTZ0uP3Zchlf7J3k+qppcDIqIU81xYcOyIYcExTT+Wf97g5OgdrBA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9148), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9195), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9232), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9288), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9301), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9353), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9382), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9457), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9467), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9475), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9484), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9492), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9501), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9372), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9449), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9459), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9477), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9485), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9493), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9502), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9460), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9468), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9478), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9494), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9503), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9375), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9451), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9469), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9479), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9487), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9504), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9462), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9471), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9480), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9488), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9497), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9505), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9378), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9453), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9463), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9472), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9481), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9498), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9506), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9473), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9482), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9490), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9455), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9474), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9508), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9517), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9522), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9575), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9580), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9585), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9512), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9518), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9523), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9565), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9576), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9581), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9586), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9514), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9519), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9567), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9572), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9582), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9587), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9515), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9520), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9568), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9573), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9578), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9583), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9588), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9515), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9521), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9569), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9584), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9589), new DateTime(2023, 11, 15, 11, 32, 26, 208, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgrades_UserId1",
                table: "RequestUpgrades",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestUpgrades_AspNetUsers_UserId1",
                table: "RequestUpgrades",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
