using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class appointment_and_relate_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestUpgrades_AspNetUsers_UserId",
                table: "RequestUpgrades");

            migrationBuilder.DropIndex(
                name: "IX_RequestUpgrades_UserId",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RequestUpgrades");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateAppointed = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ServerAllocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_ServerAllocations_ServerAllocationId",
                        column: x => x.ServerAllocationId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestUpgradeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequestUpgradeId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestUpgradeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestUpgradeUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestUpgradeUsers_RequestUpgrades_RequestUpgradeId",
                        column: x => x.RequestUpgradeId,
                        principalTable: "RequestUpgrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentUsers_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppointmentUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestUpgradeAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    RequestUpgradeId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestUpgradeAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestUpgradeAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestUpgradeAppointments_RequestUpgrades_RequestUpgradeId",
                        column: x => x.RequestUpgradeId,
                        principalTable: "RequestUpgrades",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0dc57749-0573-4252-942f-b85920bfeb1f", new DateTime(2023, 11, 16, 14, 44, 37, 405, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 11, 16, 14, 44, 37, 405, DateTimeKind.Local).AddTicks(8636), "AQAAAAIAAYagAAAAEHslU3x3l0lElOvB7y6pYJHFfFRE/mbRQmSG3QyDNHNbQG7sye8bRvHr+7m4uaXtaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "adffe3f0-dd1d-4dc7-8e25-a75c25bfacee", new DateTime(2023, 11, 16, 14, 44, 37, 179, DateTimeKind.Local).AddTicks(6702), new DateTime(2023, 11, 16, 14, 44, 37, 179, DateTimeKind.Local).AddTicks(6713), "AQAAAAIAAYagAAAAEMaOKefeloJUpfaIAz19lwGuostZNV0/3QNNuCR8yBLjPYOru9P/I1WVQjX8DOr6dA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ae7b81a7-93f3-4827-9e41-075768807c7a", new DateTime(2023, 11, 16, 14, 44, 37, 267, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 11, 16, 14, 44, 37, 267, DateTimeKind.Local).AddTicks(8875), "AQAAAAIAAYagAAAAEPxH48onMmxmKT4bosdC9xZ0AAOC1iBnHjjDD0EuAdleDTeQj3LUwzj6t5OnKo0JyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "42c3df9b-a2aa-45c8-bc9e-8981d1f764a4", new DateTime(2023, 11, 16, 14, 44, 37, 95, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 11, 16, 14, 44, 37, 95, DateTimeKind.Local).AddTicks(5170), "AQAAAAIAAYagAAAAEM71kEndpJi2evPDDNPNun+VIN6us9sbMZBICsvaGkfHKFPVkwnlK1vKJ/IeorNpjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "41265a58-2f5c-4912-be93-4acdb47da957", new DateTime(2023, 11, 16, 14, 44, 37, 23, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 11, 16, 14, 44, 37, 23, DateTimeKind.Local).AddTicks(6722), "AQAAAAIAAYagAAAAEApVH2qDyQOp8OLgmk+AKG15BxzSwb2jBN9ZFHLl8RuCjEGx93dppE50asy/fmLJEg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2417), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2779), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2764), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2789), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2733), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2775), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2792), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2794), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServerAllocationId",
                table: "Appointments",
                column: "ServerAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentUsers_AppointmentId",
                table: "AppointmentUsers",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentUsers_UserId",
                table: "AppointmentUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgradeAppointments_AppointmentId",
                table: "RequestUpgradeAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgradeAppointments_RequestUpgradeId",
                table: "RequestUpgradeAppointments",
                column: "RequestUpgradeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgradeUsers_RequestUpgradeId",
                table: "RequestUpgradeUsers",
                column: "RequestUpgradeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgradeUsers_UserId",
                table: "RequestUpgradeUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentUsers");

            migrationBuilder.DropTable(
                name: "RequestUpgradeAppointments");

            migrationBuilder.DropTable(
                name: "RequestUpgradeUsers");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "RequestUpgrades",
                type: "uuid",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "9f26d64c-7082-4a5f-b96d-b4a20c1438f8", new DateTime(2023, 11, 16, 11, 50, 25, 481, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 11, 16, 11, 50, 25, 481, DateTimeKind.Local).AddTicks(1685), "AQAAAAIAAYagAAAAEAH8CrMFEtxM+hKbH2zhbibWhn1zkq69ZncbhAp/cALJVXi+PM7uLnxciZekU1YtiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6e4c1fc2-3e73-4e1e-afea-8b36cff3cbf5", new DateTime(2023, 11, 16, 11, 50, 25, 303, DateTimeKind.Local).AddTicks(7388), new DateTime(2023, 11, 16, 11, 50, 25, 303, DateTimeKind.Local).AddTicks(7398), "AQAAAAIAAYagAAAAEHOacW2LPRtTV6EfH6erB9nr5DUKVPeU/EgBz9S19i4J3nfaQY2XsB94tn1TIH2V9g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a653a553-a072-4874-b744-ac92ea18cdb1", new DateTime(2023, 11, 16, 11, 50, 25, 395, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 11, 16, 11, 50, 25, 395, DateTimeKind.Local).AddTicks(9991), "AQAAAAIAAYagAAAAEHn2FKNLKj1KKxaDkKPA9DAHf6GjbSxoCHh6U6cgoMQ3sH4c93MD383r5O5FSEMZdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4ec99588-dc6f-4c60-a2d4-66e02e948f84", new DateTime(2023, 11, 16, 11, 50, 25, 219, DateTimeKind.Local).AddTicks(9364), new DateTime(2023, 11, 16, 11, 50, 25, 219, DateTimeKind.Local).AddTicks(9380), "AQAAAAIAAYagAAAAEH2TItraHFkkA6LowIWd77x8Afij9j2XxKU9jAIlzNALQhc/IsRBdBqigKXtLFJ0aQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e53142d0-3d2f-4fda-a0e6-49bbc87ae060", new DateTime(2023, 11, 16, 11, 50, 25, 148, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 11, 16, 11, 50, 25, 148, DateTimeKind.Local).AddTicks(8988), "AQAAAAIAAYagAAAAECEh3KXcgX1d3U79SukYUPHpdj6e5GOK5El9TtnU3NV5zp5N480eREIQCjhuQjjZZA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8101), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8118), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8142), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8150), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8065), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8103), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8111), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8135), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8150), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8104), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8112), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8120), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8151), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8094), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8113), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8130), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8137), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8095), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8106), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8114), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8122), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8131), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8146), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8098), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8115), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8139), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8147), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8154), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8108), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8116), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8124), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8155), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8149), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8158), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8170), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8185), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8190), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8171), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8181), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8191), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8196), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8201), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8161), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8177), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8182), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8187), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8192), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8202), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8173), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8178), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8183), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8193), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8198), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8203), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8169), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8174), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8189), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8194), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8204), new DateTime(2023, 11, 16, 11, 50, 25, 143, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpgrades_UserId",
                table: "RequestUpgrades",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestUpgrades_AspNetUsers_UserId",
                table: "RequestUpgrades",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
