using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_host : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InspectionReportFilePath",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleNote",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechNote",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4065), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4081), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "169766f5-1e07-420c-8283-b02cb2f375f7", new DateTime(2023, 11, 27, 22, 27, 10, 542, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 11, 27, 22, 27, 10, 542, DateTimeKind.Local).AddTicks(1699), "AQAAAAIAAYagAAAAEKOH9e/06xyIWFBKsG1uTmYO2CmF8aNWyBpsTPwhVjwYtXEFp8KoQPk/JX0WPN+uhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "af0321ab-fd76-4530-bdbc-24f08e888c3e", new DateTime(2023, 11, 27, 22, 27, 10, 355, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 11, 27, 22, 27, 10, 355, DateTimeKind.Local).AddTicks(8736), "AQAAAAIAAYagAAAAEDNUNvsRKTQji/nCTLniSZG5yXTEMhDkf6b3wwFK1GvSL1I9eEgBlOZK1vddD/lzVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "541d3e01-1c89-401d-b57c-e65915111692", new DateTime(2023, 11, 27, 22, 27, 10, 438, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 11, 27, 22, 27, 10, 438, DateTimeKind.Local).AddTicks(6473), "AQAAAAIAAYagAAAAELqOBajBwOAG9N3sHjMW1Ozq0yfxif6NOLPUVnfqGJO82zEYAnTFE0bwJvkicKB8BA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "774bb7dc-2ce8-48bd-9c8c-816b72542268", new DateTime(2023, 11, 27, 22, 27, 10, 268, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 11, 27, 22, 27, 10, 268, DateTimeKind.Local).AddTicks(7954), "AQAAAAIAAYagAAAAED7G+L2I6oB69tBKvLiooTVLqToGzmcjVPD5zF5TjmF4RsibQj47q7UREQ1SE2s6pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6d10301a-8220-43a8-844f-56b8fbef2d8e", new DateTime(2023, 11, 27, 22, 27, 10, 188, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 27, 22, 27, 10, 188, DateTimeKind.Local).AddTicks(1542), "AQAAAAIAAYagAAAAEOlbIhSIzvua6S3tgOSPbSfTVzj7CuUTZeaVgxTiY/ptnYvpopOXJxpPdqxXT0H1jA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3802), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3905), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3917), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3928), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3967), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4023), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4036), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4006), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4145), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4167), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4161), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4162), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4209), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4187), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4153), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4180), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4181), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4174), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4198), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4166), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4281), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4219), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4262), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4281), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4268), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4288), new DateTime(2023, 11, 27, 22, 27, 10, 183, DateTimeKind.Local).AddTicks(4289) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionReportFilePath",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "ReceiptOfRecipientFilePath",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "SaleNote",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "TechNote",
                table: "RequestHosts");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "294f3cda-6dc8-453f-a22d-475948298b31", new DateTime(2023, 11, 27, 21, 13, 16, 87, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 11, 27, 21, 13, 16, 87, DateTimeKind.Local).AddTicks(3328), "AQAAAAIAAYagAAAAEBVaeduHRHvmpZ1A6RUWGl7t6nKbd2yO9SjyS8pUtpoIpvsBAQIIqyzqCDSXWadLLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "76555446-a9f8-44c2-beb6-f8be0f296263", new DateTime(2023, 11, 27, 21, 13, 15, 950, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 11, 27, 21, 13, 15, 950, DateTimeKind.Local).AddTicks(282), "AQAAAAIAAYagAAAAELjf+2lS3PRHNPa7Rl856LnREOgsTSa7ea7Oft99wmwVP5/hxY4v0jLhsRbeq3JssA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "36f2260b-f4d8-4260-8ff1-82f4acb6c759", new DateTime(2023, 11, 27, 21, 13, 16, 19, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 11, 27, 21, 13, 16, 19, DateTimeKind.Local).AddTicks(6845), "AQAAAAIAAYagAAAAEC6s1nR+l16M3LFoSnoP2roP5eXE21bI97K5AJY/I+rR/3PqjyPy6zQXGLMDenD2ug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "22ec75bf-9ee1-458e-acc9-414156bfb2a8", new DateTime(2023, 11, 27, 21, 13, 15, 882, DateTimeKind.Local).AddTicks(7163), new DateTime(2023, 11, 27, 21, 13, 15, 882, DateTimeKind.Local).AddTicks(7177), "AQAAAAIAAYagAAAAEBKl9vSfwNt5vwhEIuEOfw2m32/tgx5INexfNPFnhkSqFPl3+1rJ6w9ni1EUFl/WaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2ed2deed-d12d-4fda-b4ea-b2a93134f42d", new DateTime(2023, 11, 27, 21, 13, 15, 815, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 11, 27, 21, 13, 15, 815, DateTimeKind.Local).AddTicks(9947), "AQAAAAIAAYagAAAAEEQxff/4QgF0uyg9sOUmS9uF5DMqJiVdVPTrOFl1F4QNZNjIlM3tTmy0ZeiEL/WOfA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2567), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2647), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2899), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2917), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2941), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2948), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2910), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2934), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2902), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2927), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2935), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2943), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2920), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2964), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2965), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2971), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2975), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2968), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 11, 27, 21, 13, 15, 812, DateTimeKind.Local).AddTicks(3026) });
        }
    }
}
