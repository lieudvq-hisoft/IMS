using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ipAssignment_date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAssign",
                table: "IpAssignments");

            migrationBuilder.DropColumn(
                name: "DateUnassign",
                table: "IpAssignments");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2137), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bd667b00-9527-42cf-babf-bab71c6b63e8", new DateTime(2023, 11, 26, 13, 41, 8, 814, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 11, 26, 13, 41, 8, 814, DateTimeKind.Local).AddTicks(3264), "AQAAAAIAAYagAAAAEJLRqQ/+9oldZI4v8Ox9e2AaG7w/DO+8JfUjcKVfvaeuWlT6zXjnYaLgH9iHzqfK5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e70b09c1-a1f8-4fce-b656-317960f74ca9", new DateTime(2023, 11, 26, 13, 41, 8, 653, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 11, 26, 13, 41, 8, 653, DateTimeKind.Local).AddTicks(3104), "AQAAAAIAAYagAAAAEPaUqLlvS6HTKjyGKRwSYyt0yVcBcDS5YtoRj4198qHm/cF301vuN6GvLsNm27yHXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "35ef73cf-9e93-4df6-834c-9a300d45e671", new DateTime(2023, 11, 26, 13, 41, 8, 721, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 11, 26, 13, 41, 8, 721, DateTimeKind.Local).AddTicks(3324), "AQAAAAIAAYagAAAAEDxb9lS6xPIolGjaTQ1SSsym4NTVSHiogygkx0LIu5AGFueAenUaZo48AQeQeE6/Vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b0a0859e-1f49-4d0d-b538-b9b41dead30b", new DateTime(2023, 11, 26, 13, 41, 8, 518, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 11, 26, 13, 41, 8, 518, DateTimeKind.Local).AddTicks(8175), "AQAAAAIAAYagAAAAECPULR/zVz7X8bkQ+MVWarKYkoaNgs4Zkynx09Xi4ahRnIz8MOGVdz3ZhM9acvlfmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "aad610c9-de0e-4429-a913-1439d9d87e82", new DateTime(2023, 11, 26, 13, 41, 8, 366, DateTimeKind.Local).AddTicks(8299), new DateTime(2023, 11, 26, 13, 41, 8, 366, DateTimeKind.Local).AddTicks(8309), "AQAAAAIAAYagAAAAEMruiAjEVOUgmUv4YnJV6uYvBxdtjW4LvEbbffa39OeJbiFP9WEFq6hb+uCietPUUg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1996), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2040), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2154), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2155), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2188), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2173), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2148), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2197), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2151), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2168), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2208), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2153), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2193), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2278), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2264), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2213), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2262), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2267), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2272), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 11, 26, 13, 41, 8, 362, DateTimeKind.Local).AddTicks(2296) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAssign",
                table: "IpAssignments",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUnassign",
                table: "IpAssignments",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "33077cf5-cdcb-41fa-a8f7-4089b2f3179d", new DateTime(2023, 11, 26, 13, 19, 37, 19, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 11, 26, 13, 19, 37, 19, DateTimeKind.Local).AddTicks(3572), "AQAAAAIAAYagAAAAEHnsonxNsImSVw09LCVzMCBQ/cyF1R6kNhTeRal5KLyea0h0CTJ5ouFZMY51JGdotA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "341e2f62-7c66-45aa-8306-14e26af9a073", new DateTime(2023, 11, 26, 13, 19, 36, 821, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 26, 13, 19, 36, 821, DateTimeKind.Local).AddTicks(6472), "AQAAAAIAAYagAAAAEDOHbtfEtsk/wjMD5aOa9R3eQpws+AaLGGZPfKyc/W/JBSAkIKic7Z7WAp4qvZgiHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "617d4822-436b-461c-a313-170a2a873400", new DateTime(2023, 11, 26, 13, 19, 36, 920, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 11, 26, 13, 19, 36, 920, DateTimeKind.Local).AddTicks(5811), "AQAAAAIAAYagAAAAEG8IrTislH4o1hLDxw8ukN6yqILhFNn1WqVJMzAtIPVOfp25DM11DZRalj19lmMOwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "aa218638-5d7b-40d4-bb4e-b38031482caa", new DateTime(2023, 11, 26, 13, 19, 36, 741, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 11, 26, 13, 19, 36, 741, DateTimeKind.Local).AddTicks(8895), "AQAAAAIAAYagAAAAEMj9TmDsVS4fdh+hxbnBZ4bo95Glrllexo2ojnZuiItoSP4YSPG2klwdIrrotL/9zA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "04ec62a0-f6ed-4c3d-8f53-124b4a6509e8", new DateTime(2023, 11, 26, 13, 19, 36, 652, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 11, 26, 13, 19, 36, 652, DateTimeKind.Local).AddTicks(6633), "AQAAAAIAAYagAAAAEEPT11OJlx7YHlEukwAXtC94afiH0ScuMtWozZumqtWyvcdU5OKCkaGAhdJtMAgjDA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1087), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1246), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1259), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1346), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1367), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1378), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1357), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1502), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1515), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1595), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1503), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1520), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1532), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1506), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1534), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1574), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1586), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1523), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1588), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1509), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1537), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1498), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1578), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1618), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1635), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1658), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1666), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1644), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1667), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1621), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1630), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1638), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1645), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1669), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1614), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1622), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1632), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1662), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1624), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1641), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1672), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1672) });
        }
    }
}
