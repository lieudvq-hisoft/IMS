using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class nullable_reason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "IpAddresses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5494), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5511), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1e5ba5cf-708b-4ef1-a311-6351135fb20c", new DateTime(2023, 12, 3, 16, 40, 48, 920, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 12, 3, 16, 40, 48, 920, DateTimeKind.Local).AddTicks(3053), "AQAAAAIAAYagAAAAEKPoYI5gyAoI3qfvSjaJuh6EjHwYCkQMGyF1XEW++VeorVoTSUbYXWqEiHH5J0Yb+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e638c461-1817-47c1-b32a-5f4e4a378491", new DateTime(2023, 12, 3, 16, 40, 48, 776, DateTimeKind.Local).AddTicks(3761), new DateTime(2023, 12, 3, 16, 40, 48, 776, DateTimeKind.Local).AddTicks(3774), "AQAAAAIAAYagAAAAEJqODpaggIn307OynWBKzqGEmD0t45/eEch3aFG1ZXWKT7lpG2befrC/oz92HP+xQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ec6095ec-19eb-460a-aeee-1a65577e21f9", new DateTime(2023, 12, 3, 16, 40, 48, 851, DateTimeKind.Local).AddTicks(7552), new DateTime(2023, 12, 3, 16, 40, 48, 851, DateTimeKind.Local).AddTicks(7563), "AQAAAAIAAYagAAAAEC9JGhWDQ6vyCwIW2ZwHHjR5eYrOKb0K7Y9niLnTbOzZrGVIGupucUESJ9bIvbCHbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1cad98b9-9b45-4012-8642-ca4d84c5dfdf", new DateTime(2023, 12, 3, 16, 40, 48, 700, DateTimeKind.Local).AddTicks(2469), new DateTime(2023, 12, 3, 16, 40, 48, 700, DateTimeKind.Local).AddTicks(2481), "AQAAAAIAAYagAAAAELDpE6r7rKERUpGy5B3s/sXEVIZsLbfANugfTHMqwAdOCqUqU9/ZyOppkWNlXHGUyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fa6bfa38-83f8-4472-9951-3369f23a621a", new DateTime(2023, 12, 3, 16, 40, 48, 629, DateTimeKind.Local).AddTicks(921), new DateTime(2023, 12, 3, 16, 40, 48, 629, DateTimeKind.Local).AddTicks(931), "AQAAAAIAAYagAAAAEIwa9kGdIkrpQc5HZMGD0lIQc/Y3WfgwUWqiYtUviq1U8bzvSXvyjWELMz1c6CV03Q==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5257), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5429), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5442), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5612), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5571), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5605), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5622), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5631), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5639), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5655), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5615), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5623), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5632), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5640), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5648), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5656), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5624), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5649), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5625), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5634), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5642), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5658), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5609), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5635), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5643), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5651), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5659), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5627), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5636), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5644), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5652), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5660), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5611), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5637), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5662), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5674), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5715), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5730), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5735), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5665), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5670), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5676), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5726), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5731), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5666), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5671), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5677), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5667), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5672), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5723), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5728), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5738), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5668), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5673), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5719), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5724), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5729), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5734), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5739), new DateTime(2023, 12, 3, 16, 40, 48, 623, DateTimeKind.Local).AddTicks(5739) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "IpAddresses",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(603), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c9fd5c71-231e-4169-8f81-dd79c85acd3e", new DateTime(2023, 12, 3, 15, 4, 45, 309, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 12, 3, 15, 4, 45, 309, DateTimeKind.Local).AddTicks(2773), "AQAAAAIAAYagAAAAEAKFUROZspkg3iopddVsc2hrodRSyKlmekWLC2O+dYq0sMTvZiYa/2sDNtHeeYYVyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "df7c6665-d4c5-441c-b3df-462a5633a44d", new DateTime(2023, 12, 3, 15, 4, 45, 78, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 12, 3, 15, 4, 45, 78, DateTimeKind.Local).AddTicks(3341), "AQAAAAIAAYagAAAAEIN/sLj06dxI/nmcQL2uWKt9JO9wr+zUYXsjEjAvw9+AhtXhkmSzWqetKVEYQTWRfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "75e37545-8284-4f79-9121-4c1fc1030091", new DateTime(2023, 12, 3, 15, 4, 45, 202, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 12, 3, 15, 4, 45, 202, DateTimeKind.Local).AddTicks(3200), "AQAAAAIAAYagAAAAEKubmwaIetBeYP4lxBtgfxw3IS1lR8G0T/90DPWmMLvPQG6pc9Tcq5dDgkpbcLfsaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "cc88a046-7280-404b-a949-0e9e4523c364", new DateTime(2023, 12, 3, 15, 4, 44, 973, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 12, 3, 15, 4, 44, 973, DateTimeKind.Local).AddTicks(1509), "AQAAAAIAAYagAAAAEEB6B4vB0migFX/qAGzlqV6a9d2ITrb0q8NvTUQshKhz7yN3eGdBk76rX7aCphfW4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2f725039-6101-41fc-8509-cd6f24309b91", new DateTime(2023, 12, 3, 15, 4, 44, 862, DateTimeKind.Local).AddTicks(6374), new DateTime(2023, 12, 3, 15, 4, 44, 862, DateTimeKind.Local).AddTicks(6385), "AQAAAAIAAYagAAAAEFBzFOp+DS0nZMXliFnGNrJNCaQ4yR12DS8XmOjEq3gsoTlvzNw9feDDOz7lCEgC+w==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(545), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(610), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(644), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(662), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(671), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(721), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(729), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(737), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(614), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(646), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(655), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(663), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(714), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(722), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(730), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(738), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(616), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(664), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(715), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(723), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(731), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(739), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(648), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(657), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(665), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(716), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(724), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(732), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(740), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(618), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(649), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(658), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(666), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(717), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(725), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(741), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(626), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(659), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(667), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(718), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(726), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(734), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(742), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(628), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(651), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(660), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(668), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(719), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(727), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(735), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(743), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(642), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(652), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(661), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(720), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(728), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(736), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(744), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(746), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(754), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(759), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(764), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(775), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(780), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(785), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(749), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(755), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(765), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(770), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(781), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(786), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(750), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(756), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(761), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(766), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(771), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(777), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(782), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(787), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(751), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(762), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(767), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(778), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(783), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(788), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(752), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(758), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(763), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(768), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(774), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(779), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(784), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(789), new DateTime(2023, 12, 3, 15, 4, 44, 857, DateTimeKind.Local).AddTicks(789) });
        }
    }
}
