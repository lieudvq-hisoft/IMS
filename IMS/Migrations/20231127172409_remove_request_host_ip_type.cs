using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class remove_request_host_ip_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "RequestHostIps");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "13e3c997-b8b5-442b-8932-6201ee1030c9", new DateTime(2023, 11, 28, 0, 24, 8, 410, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 11, 28, 0, 24, 8, 410, DateTimeKind.Local).AddTicks(4438), "AQAAAAIAAYagAAAAELlSYVLEbUUNZmwo+dA5qEJ4WtcwNeUYt3/0EJt1Cnb47i5SikhwfiXzp+86y2Kpmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8fc8649f-8925-4368-bec7-3655bf294039", new DateTime(2023, 11, 28, 0, 24, 8, 239, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 11, 28, 0, 24, 8, 239, DateTimeKind.Local).AddTicks(3699), "AQAAAAIAAYagAAAAEMf1ufp0vJV52Hn1s6qnwLUnxkl+17H8eAMaD8oNmjKuXiIXa+s4vtymsv4wWTsDdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1c912df2-7eee-42d5-815a-d339f74d9236", new DateTime(2023, 11, 28, 0, 24, 8, 330, DateTimeKind.Local).AddTicks(9540), new DateTime(2023, 11, 28, 0, 24, 8, 330, DateTimeKind.Local).AddTicks(9554), "AQAAAAIAAYagAAAAEFtsN5cW4kilrerViCRE/MDG9ZPGz2SmJsLkpxX3FpK63HhEsejARLB9m9J6eLNy1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "674a4727-9348-4b64-a8db-38994eb2a913", new DateTime(2023, 11, 28, 0, 24, 8, 134, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 11, 28, 0, 24, 8, 134, DateTimeKind.Local).AddTicks(4325), "AQAAAAIAAYagAAAAEC5WdqZ33COaymmpT7ozjZG4GfqsGDZnpS42F5ZFHVyPvs+TtFAEXHDWPCZCjb1avQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "72110a3b-1623-45a9-b955-0295adcc9e0d", new DateTime(2023, 11, 28, 0, 24, 8, 42, DateTimeKind.Local).AddTicks(7509), new DateTime(2023, 11, 28, 0, 24, 8, 42, DateTimeKind.Local).AddTicks(7522), "AQAAAAIAAYagAAAAELn6BinfnLAPDkaifjyUknfRdbNEg7LZesIw+Qa/NPrGdszpso4sVcBLAx8Q5VZUfg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5565), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5651), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5664), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5632), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5754), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5763), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5772), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5781), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5797), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5774), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5782), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5790), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5798), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5775), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5783), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5791), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5799), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5731), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5749), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5766), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5776), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5784), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5792), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5767), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5785), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5793), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5751), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5778), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5786), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5802), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5735), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5779), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5787), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5795), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5803), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5753), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5762), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5771), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5813), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5846), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5808), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5818), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5828), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5842), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5847), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5838), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5843), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5848), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5825), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5834), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5844), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5849), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5836), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5840), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5845), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5850), new DateTime(2023, 11, 28, 0, 24, 8, 38, DateTimeKind.Local).AddTicks(5850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "RequestHostIps",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2dfcd861-12be-47ca-af6e-8e0d4b9d1390", new DateTime(2023, 11, 28, 0, 1, 17, 192, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 28, 0, 1, 17, 192, DateTimeKind.Local).AddTicks(5193), "AQAAAAIAAYagAAAAEEwLeNobt7h7y/SdThsRsbJGe3SGiO95G8DvPNiXamQg5189aoRmnNimV71Uz0v9AA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bb2e80a4-fee4-4a2d-bd2c-1ac92dd1de97", new DateTime(2023, 11, 28, 0, 1, 16, 925, DateTimeKind.Local).AddTicks(3821), new DateTime(2023, 11, 28, 0, 1, 16, 925, DateTimeKind.Local).AddTicks(3838), "AQAAAAIAAYagAAAAEDGpK+CzhYlKU+ybB8vyp17ryxn8UCqyDPv/76fkUEgWG0KaIZp6SyFavDVs+xXJBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "033b395d-0939-4f73-936f-52c1c2ed951c", new DateTime(2023, 11, 28, 0, 1, 17, 107, DateTimeKind.Local).AddTicks(7829), new DateTime(2023, 11, 28, 0, 1, 17, 107, DateTimeKind.Local).AddTicks(7851), "AQAAAAIAAYagAAAAEPp7LR+Bv5elsL04HIahGzppBmqizLCC6NlaKyHSKUvpJAeZJBMFHcI2raaiO1a5AQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3a5f79fe-3705-43f3-94ee-5830d63f747f", new DateTime(2023, 11, 28, 0, 1, 16, 719, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 11, 28, 0, 1, 16, 719, DateTimeKind.Local).AddTicks(536), "AQAAAAIAAYagAAAAEH0dlVis6IyuGq1gxeCpnDop+ftObPch+W/fS+Uy72FHiW+zJSnSP7bd2atOYgOTvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "70b90a0a-61d2-42e2-a42b-1f7e3108b399", new DateTime(2023, 11, 28, 0, 1, 16, 624, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 11, 28, 0, 1, 16, 624, DateTimeKind.Local).AddTicks(5093), "AQAAAAIAAYagAAAAEBUFZokr5/mb2pigv15EAwLItyzMfGuwB6G6yLQbHu2VP9LBJ+0n5/huB3LicphGFA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7638), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7685), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7729), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7925), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7933), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7903), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7919), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7884), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7896), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7921), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7936), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7944), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7897), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7913), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7923), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7931), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8025), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8021), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8022), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8028), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8038), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8023), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8029), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8034), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7953), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8019), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8024), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 11, 28, 0, 1, 16, 619, DateTimeKind.Local).AddTicks(8050) });
        }
    }
}
