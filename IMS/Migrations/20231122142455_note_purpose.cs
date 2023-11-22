using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class note_purpose : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "IpSubnets",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Purpose",
                table: "IpAddresses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6474), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c684f6d5-a6b5-41b8-8d60-0b3551c97b37", new DateTime(2023, 11, 22, 21, 24, 54, 181, DateTimeKind.Local).AddTicks(8165), new DateTime(2023, 11, 22, 21, 24, 54, 181, DateTimeKind.Local).AddTicks(8179), "AQAAAAIAAYagAAAAECSuA+Ha0T5urGKlrkl2FOhO1V2pqewJVe8jiFQjB0ey6W5oNxEzvKuDvLohk4K75A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0da04f0f-cfa8-4218-8d60-e274e468e70e", new DateTime(2023, 11, 22, 21, 24, 54, 26, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 11, 22, 21, 24, 54, 26, DateTimeKind.Local).AddTicks(4480), "AQAAAAIAAYagAAAAEJ8foiIWG3mQGPRvsXHbh9XNyR3KMzdAb9PebuzZAtB1YZ/u69Kej/Rp4qtjgrUT5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "15bd1707-0d34-4af6-9f5c-a6651983f750", new DateTime(2023, 11, 22, 21, 24, 54, 103, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 11, 22, 21, 24, 54, 103, DateTimeKind.Local).AddTicks(5098), "AQAAAAIAAYagAAAAEP9XqLAxD8dAAcjQlrhrk2Cm3PcQE4jFxtY+dPAItOwPDCuY79qB68HothOH1KTbUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ac705d49-1879-4075-b15a-93d87b78a22b", new DateTime(2023, 11, 22, 21, 24, 53, 955, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 11, 22, 21, 24, 53, 955, DateTimeKind.Local).AddTicks(3358), "AQAAAAIAAYagAAAAEEsV+FFxJ8H/KvAo5hueCnvn+6YEECJ/RJ2nChgAj3tH1+VvjudcU8VEcdAzzRO7ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0e3878ca-cc19-42d9-a287-a36f1483e328", new DateTime(2023, 11, 22, 21, 24, 53, 885, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 11, 22, 21, 24, 53, 885, DateTimeKind.Local).AddTicks(9727), "AQAAAAIAAYagAAAAEA/5IZeh7XXYJfSWr/jusR2LRatmpx4sIU1Mki0X3Ye3gHYb0CGrzNTR1QMSGm34iQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6208), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6374), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6399), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6432), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6410), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6507), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6516), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6568), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6576), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6592), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6509), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6569), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6578), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6586), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6593), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6579), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6594), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6602), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6511), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6571), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6587), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6595), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6603), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6512), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6581), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6588), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6596), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6604), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6513), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6565), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6582), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6589), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6597), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6605), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6514), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6566), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6574), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6583), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6598), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6606), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6515), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6575), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6591), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6599), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6607), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6608), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6614), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6619), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6624), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6629), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6639), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6610), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6615), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6620), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6625), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6630), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6635), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6611), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6621), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6626), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6641), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6646), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6612), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6617), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6622), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6627), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6632), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6618), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6628), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6633), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6638), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6681), new DateTime(2023, 11, 22, 21, 24, 53, 881, DateTimeKind.Local).AddTicks(6681) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "IpSubnets");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "IpAddresses");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5162) });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 22, 17, 51, 47, 11, DateTimeKind.Local).AddTicks(5178) });

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
    }
}
