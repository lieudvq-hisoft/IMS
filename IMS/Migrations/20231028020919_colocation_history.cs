using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class colocation_history : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateStop",
                table: "Colocations");

            migrationBuilder.RenameColumn(
                name: "NumberOfPort",
                table: "Devices",
                newName: "AdditionalSize");

            migrationBuilder.AddColumn<int>(
                name: "AdditionalNumberOfPort",
                table: "Servers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPort",
                table: "Servers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Blocked",
                table: "Ips",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalPower",
                table: "Devices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ColocationHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateStop = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ColocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColocationHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColocationHistories_Colocations_ColocationId",
                        column: x => x.ColocationId,
                        principalTable: "Colocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98a9ac2d-496d-4cfb-8493-ba025aa1f8a2", "AQAAAAIAAYagAAAAEMDf9j5Mr1asbhyz3SZ0OGIt1QgspB0k8psOp2eNHmlT5j7Pnv4OAOAahBOOlRRoYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c0fb061c-9590-48d8-8f7f-b4443508ce26", "AQAAAAIAAYagAAAAEO6b0VdYNUvTtRNf4ye1PgKuw29zZI5cAlEwVrA6xuMl+M1CKmOtkXMQtkK9mDeqMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "581bd23a-4b6e-4d3e-b7c9-6ff9360b5828", "AQAAAAIAAYagAAAAEBejD8caHhUGSDzMny83128IuRDmEaypuS6d0ePizGQr272iOryeDn/NVOTv9MTiNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30484e0b-cd78-4d1e-a236-129b3e80b5ee", "AQAAAAIAAYagAAAAELNOR0sv6qAMgCWX4uFbNFCJ1jbXiEcLhsaKuyWKgHZSCXfyHS6l2p4AFOeVDfTXeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fab9d05-562e-4f2e-9fb3-1fa4cd898e52", "AQAAAAIAAYagAAAAELFbZNcU9ZtD9kBPexdMAzgjl0qD7dpYurSkcoXVkHkh35XWzlzC3k65ndvNhN0CmA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1868), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalPower", "AdditionalSize", "DateCreated", "DateUpdated", "Status" },
                values: new object[] { 0, 0, new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4157), 0 });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(803), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(830), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(847), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(848) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(876), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(911), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(927), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(941), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(956), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(972), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1019), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1064), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1181), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1475), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1625), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1671), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1746), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1936), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1969), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2001), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2304), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2371), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2393), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2419), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2523), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2560), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2796), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2941), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3124), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3374), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3424), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3435), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3485), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3501), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3518), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3714), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3731), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3747), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3763), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4187), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4321), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4389), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4424), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4695), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4743), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4839), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4901), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4927), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4945), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5013), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5446), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5468), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5488), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5509), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5519), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5550), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5580), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Blocked", "DateCreated", "DateUpdated" },
                values: new object[] { false, new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(451), new DateTime(2023, 10, 28, 9, 9, 18, 727, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4235), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4591), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4569), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4688), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4691), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4576), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4671), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4579), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4674), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4697), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4269), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4581), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4654), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4677), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4634), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4657), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4703), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4637), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4711), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4729), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5025), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4732), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4746), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4761), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4775), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4735), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5031), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4738), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4752), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4766), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4989), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4726), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4755), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5008), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5036), new DateTime(2023, 10, 28, 9, 9, 18, 726, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 10, 28, 9, 9, 17, 314, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.CreateIndex(
                name: "IX_ColocationHistories_ColocationId",
                table: "ColocationHistories",
                column: "ColocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColocationHistories");

            migrationBuilder.DropColumn(
                name: "AdditionalNumberOfPort",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "NumberOfPort",
                table: "Servers");

            migrationBuilder.DropColumn(
                name: "Blocked",
                table: "Ips");

            migrationBuilder.DropColumn(
                name: "AdditionalPower",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "AdditionalSize",
                table: "Devices",
                newName: "NumberOfPort");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStop",
                table: "Colocations",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "DateCreated", "DateUpdated", "NumberOfPort", "Status" },
                values: new object[] { new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 10, 27, 15, 55, 49, 995, DateTimeKind.Local).AddTicks(8440), 3, 1 });

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
        }
    }
}
