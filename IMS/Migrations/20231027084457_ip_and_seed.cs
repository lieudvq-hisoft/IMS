using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ip_and_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations");

            migrationBuilder.CreateTable(
                name: "Networks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstOctet = table.Column<int>(type: "integer", nullable: false),
                    SecondOctet = table.Column<int>(type: "integer", nullable: false),
                    ThirdOctet = table.Column<int>(type: "integer", nullable: false),
                    SubnetMask = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Networks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IsReserved = table.Column<bool>(type: "boolean", nullable: false),
                    NetworkId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ips_Networks_NetworkId",
                        column: x => x.NetworkId,
                        principalTable: "Networks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IpAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateAssign = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUnassign = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ServerId = table.Column<int>(type: "integer", nullable: false),
                    IpId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpAssignments_Ips_IpId",
                        column: x => x.IpId,
                        principalTable: "Ips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IpAssignments_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2141), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2148), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2148), 193, false, 122, 25, 111 }
                });

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

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2162), false, false, 2, 0 },
                    { 2, 2, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2170), false, false, 1, 0 },
                    { 3, 3, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2174), false, false, 2, 0 },
                    { 4, 4, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2178), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2178), false, false, 1, 0 },
                    { 5, 5, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2181), false, false, 2, 0 },
                    { 6, 6, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2186), false, false, 1, 0 },
                    { 7, 7, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2189), false, false, 2, 0 },
                    { 8, 8, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2193), false, false, 1, 0 },
                    { 9, 9, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2196), false, false, 2, 0 },
                    { 10, 10, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2241), false, false, 1, 0 },
                    { 11, 11, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2246), false, false, 2, 0 },
                    { 12, 12, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2249), false, false, 1, 0 },
                    { 13, 13, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2253), false, false, 2, 0 },
                    { 14, 14, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2256), false, false, 1, 0 },
                    { 15, 15, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2260), false, false, 2, 0 },
                    { 16, 16, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2263), false, false, 1, 0 },
                    { 17, 17, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2266), false, false, 2, 0 },
                    { 18, 18, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2271), false, false, 1, 0 },
                    { 19, 19, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2274), false, false, 2, 0 },
                    { 20, 20, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2277), false, false, 1, 0 },
                    { 21, 21, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2281), false, false, 2, 0 },
                    { 22, 22, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2284), false, false, 1, 0 },
                    { 23, 23, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2287), false, false, 2, 0 },
                    { 24, 24, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2291), false, false, 1, 0 },
                    { 25, 25, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2294), false, false, 2, 0 },
                    { 26, 26, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2298), false, false, 1, 0 },
                    { 27, 27, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2301), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2301), false, false, 2, 0 },
                    { 28, 28, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2305), false, false, 1, 0 },
                    { 29, 29, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2308), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2308), false, false, 2, 0 },
                    { 30, 30, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2312), false, false, 1, 0 },
                    { 31, 31, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2315), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2315), false, false, 2, 0 },
                    { 32, 32, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2319), false, false, 1, 0 },
                    { 33, 33, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2323), false, false, 2, 0 },
                    { 34, 34, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2327), false, false, 1, 0 },
                    { 35, 35, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2396), false, false, 2, 0 },
                    { 36, 36, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2400), false, false, 1, 0 },
                    { 37, 37, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2404), false, false, 2, 0 },
                    { 38, 38, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2407), false, false, 1, 0 },
                    { 39, 39, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2411), false, false, 2, 0 },
                    { 40, 40, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2414), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2414), false, false, 1, 0 },
                    { 41, 41, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2417), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2418), false, false, 2, 0 },
                    { 42, 42, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2421), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2421), false, false, 1, 0 },
                    { 43, 43, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2424), false, false, 2, 0 },
                    { 44, 44, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2428), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2428), false, false, 1, 0 },
                    { 45, 45, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2431), false, false, 2, 0 },
                    { 46, 46, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2435), false, false, 1, 0 },
                    { 47, 47, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2438), false, false, 2, 0 },
                    { 48, 48, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2442), false, false, 1, 0 },
                    { 49, 49, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2445), false, false, 2, 0 },
                    { 50, 50, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2448), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2449), false, false, 1, 0 },
                    { 51, 51, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2452), false, false, 2, 0 },
                    { 52, 52, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2456), false, false, 1, 0 },
                    { 53, 53, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2459), false, false, 2, 0 },
                    { 54, 54, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2463), false, false, 1, 0 },
                    { 55, 55, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2466), false, false, 2, 0 },
                    { 56, 56, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2469), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2469), false, false, 1, 0 },
                    { 57, 57, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2473), false, false, 2, 0 },
                    { 58, 58, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2476), false, false, 1, 0 },
                    { 59, 59, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2480), false, false, 2, 0 },
                    { 60, 60, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2483), false, false, 1, 0 },
                    { 61, 61, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2486), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2487), false, false, 2, 0 },
                    { 62, 62, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2490), false, false, 1, 0 },
                    { 63, 63, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2527), false, false, 2, 0 },
                    { 64, 64, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2531), false, false, 1, 0 },
                    { 65, 65, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2535), false, false, 2, 0 },
                    { 66, 66, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2539), false, false, 1, 0 },
                    { 67, 67, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2542), false, false, 2, 0 },
                    { 68, 68, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2546), false, false, 1, 0 },
                    { 69, 69, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2549), false, false, 2, 0 },
                    { 70, 70, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2553), false, false, 1, 0 },
                    { 71, 71, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2556), false, false, 2, 0 },
                    { 72, 72, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2560), false, false, 1, 0 },
                    { 73, 73, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2563), false, false, 2, 0 },
                    { 74, 74, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2567), false, false, 1, 0 },
                    { 75, 75, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2570), false, false, 2, 0 },
                    { 76, 76, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2574), false, false, 1, 0 },
                    { 77, 77, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2577), false, false, 2, 0 },
                    { 78, 78, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2581), false, false, 1, 0 },
                    { 79, 79, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2584), false, false, 2, 0 },
                    { 80, 80, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2588), false, false, 1, 0 },
                    { 81, 81, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2591), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2591), false, false, 2, 0 },
                    { 82, 82, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2595), false, false, 1, 0 },
                    { 83, 83, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2598), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2599), false, false, 2, 0 },
                    { 84, 84, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2602), false, false, 1, 0 },
                    { 85, 85, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2606), false, false, 2, 0 },
                    { 86, 86, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2609), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2609), false, false, 1, 0 },
                    { 87, 87, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2649), false, false, 2, 0 },
                    { 88, 88, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2653), false, false, 1, 0 },
                    { 89, 89, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2677), false, false, 2, 0 },
                    { 90, 90, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2680), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2681), false, false, 1, 0 },
                    { 91, 91, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2684), false, false, 2, 0 },
                    { 92, 92, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2688), false, false, 1, 0 },
                    { 93, 93, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2691), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2691), false, false, 2, 0 },
                    { 94, 94, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2694), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2694), false, false, 1, 0 },
                    { 95, 95, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2698), false, false, 2, 0 },
                    { 96, 96, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2701), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2701), false, false, 1, 0 },
                    { 97, 97, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2705), false, false, 2, 0 },
                    { 98, 98, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2708), false, false, 1, 0 },
                    { 99, 99, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2712), false, false, 2, 0 },
                    { 100, 100, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2715), false, false, 1, 0 },
                    { 101, 101, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2719), false, false, 2, 0 },
                    { 102, 102, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2722), false, false, 1, 0 },
                    { 103, 103, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2726), false, false, 2, 0 },
                    { 104, 104, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2729), false, false, 1, 0 },
                    { 105, 105, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2732), false, false, 2, 0 },
                    { 106, 106, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2736), false, false, 1, 0 },
                    { 107, 107, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2739), false, false, 2, 0 },
                    { 108, 108, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2743), false, false, 1, 0 },
                    { 109, 109, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2746), false, false, 2, 0 },
                    { 110, 110, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2750), false, false, 1, 0 },
                    { 111, 111, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2753), false, false, 2, 0 },
                    { 112, 112, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2756), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2757), false, false, 1, 0 },
                    { 113, 113, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2760), false, false, 2, 0 },
                    { 114, 114, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2798), false, false, 1, 0 },
                    { 115, 115, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2803), false, false, 2, 0 },
                    { 116, 116, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2807), false, false, 1, 0 },
                    { 117, 117, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2810), false, false, 2, 0 },
                    { 118, 118, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2813), false, false, 1, 0 },
                    { 119, 119, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2817), false, false, 2, 0 },
                    { 120, 120, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2820), false, false, 1, 0 },
                    { 121, 121, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2823), false, false, 2, 0 },
                    { 122, 122, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2827), false, false, 1, 0 },
                    { 123, 123, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2830), false, false, 2, 0 },
                    { 124, 124, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2834), false, false, 1, 0 },
                    { 125, 125, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2837), false, false, 2, 0 },
                    { 126, 126, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2841), false, false, 1, 0 },
                    { 127, 127, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2844), false, false, 2, 0 },
                    { 128, 128, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2848), false, false, 1, 0 },
                    { 129, 129, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2851), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2851), false, false, 2, 0 },
                    { 130, 130, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2855), false, false, 1, 0 },
                    { 131, 131, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2859), false, false, 2, 0 },
                    { 132, 132, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2862), false, false, 1, 0 },
                    { 133, 133, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2866), false, false, 2, 0 },
                    { 134, 134, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2869), false, false, 1, 0 },
                    { 135, 135, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2909), false, false, 2, 0 },
                    { 136, 136, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2912), false, false, 1, 0 },
                    { 137, 137, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2916), false, false, 2, 0 },
                    { 138, 138, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2919), false, false, 1, 0 },
                    { 139, 139, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2923), false, false, 2, 0 },
                    { 140, 140, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2926), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2926), false, false, 1, 0 },
                    { 141, 141, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2929), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2929), false, false, 2, 0 },
                    { 142, 142, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2933), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2933), false, false, 1, 0 },
                    { 143, 143, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2936), false, false, 2, 0 },
                    { 144, 144, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2940), false, false, 1, 0 },
                    { 145, 145, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2943), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2943), false, false, 2, 0 },
                    { 146, 146, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2946), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2947), false, false, 1, 0 },
                    { 147, 147, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2950), false, false, 2, 0 },
                    { 148, 148, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2953), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2954), false, false, 1, 0 },
                    { 149, 149, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2957), false, false, 2, 0 },
                    { 150, 150, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2960), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2960), false, false, 1, 0 },
                    { 151, 151, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2964), false, false, 2, 0 },
                    { 152, 152, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2967), false, false, 1, 0 },
                    { 153, 153, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2971), false, false, 2, 0 },
                    { 154, 154, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2974), false, false, 1, 0 },
                    { 155, 155, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2977), false, false, 2, 0 },
                    { 156, 156, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2981), false, false, 1, 0 },
                    { 157, 157, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2984), false, false, 2, 0 },
                    { 158, 158, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2988), false, false, 1, 0 },
                    { 159, 159, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2991), false, false, 2, 0 },
                    { 160, 160, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2995), false, false, 1, 0 },
                    { 161, 161, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(2998), false, false, 2, 0 },
                    { 162, 162, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3002), false, false, 1, 0 },
                    { 163, 163, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3039), false, false, 2, 0 },
                    { 164, 164, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3112), false, false, 1, 0 },
                    { 165, 165, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3116), false, false, 2, 0 },
                    { 166, 166, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3120), false, false, 1, 0 },
                    { 167, 167, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3123), false, false, 2, 0 },
                    { 168, 168, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3126), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3127), false, false, 1, 0 },
                    { 169, 169, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3130), false, false, 2, 0 },
                    { 170, 170, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3134), false, false, 1, 0 },
                    { 171, 171, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3137), false, false, 2, 0 },
                    { 172, 172, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3140), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3141), false, false, 1, 0 },
                    { 173, 173, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3144), false, false, 2, 0 },
                    { 174, 174, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3148), false, false, 1, 0 },
                    { 175, 175, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3151), false, false, 2, 0 },
                    { 176, 176, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3155), false, false, 1, 0 },
                    { 177, 177, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3158), false, false, 2, 0 },
                    { 178, 178, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3161), false, false, 1, 0 },
                    { 179, 179, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3165), false, false, 2, 0 },
                    { 180, 180, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3168), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3168), false, false, 1, 0 },
                    { 181, 181, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3171), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3172), false, false, 2, 0 },
                    { 182, 182, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3175), false, false, 1, 0 },
                    { 183, 183, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3179), false, false, 2, 0 },
                    { 184, 184, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3182), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3182), false, false, 1, 0 },
                    { 185, 185, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3186), false, false, 2, 0 },
                    { 186, 186, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3189), false, false, 1, 0 },
                    { 187, 187, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3192), false, false, 2, 0 },
                    { 188, 188, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3196), false, false, 1, 0 },
                    { 189, 189, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3199), false, false, 2, 0 },
                    { 190, 190, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3238), false, false, 1, 0 },
                    { 191, 191, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3243), false, false, 2, 0 },
                    { 192, 192, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3246), false, false, 1, 0 },
                    { 193, 193, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3249), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3249), false, false, 2, 0 },
                    { 194, 194, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3253), false, false, 1, 0 },
                    { 195, 195, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3256), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3256), false, false, 2, 0 },
                    { 196, 196, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3260), false, false, 1, 0 },
                    { 197, 197, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3263), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3263), false, false, 2, 0 },
                    { 198, 198, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3266), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3267), false, false, 1, 0 },
                    { 199, 199, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3270), false, false, 2, 0 },
                    { 200, 200, new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3273), new DateTime(2023, 10, 27, 15, 44, 57, 155, DateTimeKind.Local).AddTicks(3273), false, false, 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations",
                column: "ServerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_IpId",
                table: "IpAssignments",
                column: "IpId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_ServerId",
                table: "IpAssignments",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ips_NetworkId",
                table: "Ips",
                column: "NetworkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7681), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "adee62ba-4d65-406f-b924-d111012d883e", "AQAAAAIAAYagAAAAEIiA0yGn2i0bxYxF+T8jbz4GswzTgB0roVaGcx6u/Qz+wtoj4mkLH7o+Pmm5t36BJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9926c551-4e3e-4be2-bdc9-f539f34fd744", "AQAAAAIAAYagAAAAEGhiK1KbQbUYCkD//rbTBY5CuU7qBr7w7Jtfkbi9Ktdzr5cW8ihlcaIL+h8k9iB/bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e934a58-7c47-47e6-9231-84ea341e858d", "AQAAAAIAAYagAAAAEGgLuXdO0mnjnoYYwKk0yxyeG+6Sy1+lDftQJgabkAGKn12JQykXY0RaPASSOA3cBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69f477d1-28d8-4d88-8589-2694ace0a12a", "AQAAAAIAAYagAAAAENO3DQblKfRaN9Ii1ONtRTesdic0SeQPPMgFfLdBSR0jVHBR5I6h+0gK9CtotPwq9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57751ee0-13d8-47f7-a5c4-ac0acdadb793", "AQAAAAIAAYagAAAAEAj+Pnu08gQNzhqb7HdEz8FvN3f/JosCv7HiqKDt+CLmkSdyzBfb5S1HSysGONqaXg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9482), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7585), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7656), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(8452), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7713), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7729), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7739), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7732), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7871), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7884), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7886), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7896), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7913), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7897), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7901), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7919), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7903), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7917), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7921), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations",
                column: "ServerId");
        }
    }
}
