using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class table_name_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareServices");

            migrationBuilder.DropTable(
                name: "IpServices");

            migrationBuilder.DropTable(
                name: "LocationServices");

            migrationBuilder.CreateTable(
                name: "Hardwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsCurrent = table.Column<bool>(type: "boolean", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    DateInstalled = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUninstalled = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    HardwareCategoryId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardwares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hardwares_HardwareCategories_HardwareCategoryId",
                        column: x => x.HardwareCategoryId,
                        principalTable: "HardwareCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hardwares_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
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
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IpId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_IpAssignments_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartPosition = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    RackId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9446), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9461), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "587a0f68-374f-4bee-abd1-d8922ffccdf5", "AQAAAAIAAYagAAAAEDODOtUvAOtVWg5XTAYeJSvKf84gOWykkwp4FCv6/pMiEAyoSRbLq1zMrcQJHWkzyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d0144c0-cd39-4d80-8826-051fbd58b7ac", "AQAAAAIAAYagAAAAEKbxhNPz3iwAUawMLK1YHbRjO9hFjFKGcKM56KtkSD02NLuErkIemLxdoEpa1zmx0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc2bf7ea-ce88-47d6-8351-08951ff03840", "AQAAAAIAAYagAAAAEPxGvPK9F3hCYB4cVtlvfakgkMkioBTEseGHD4ETwsDRoMRW8Ca5404CoX7rqfB9WA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecfeb264-9396-42b0-930a-d36099aa9ab9", "AQAAAAIAAYagAAAAEEWOuXqW3UGVt3AG1NczF+NAKr8JcjHihx4x1DJho40ktURT1OnTDImB+PGSLwUMvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01a15808-bb53-4ea7-9762-026619647b93", "AQAAAAIAAYagAAAAEE4XO9hHolKD0mZmEMSH6tlm6mvDAWboknTLAKXHm3lxZvWulZ73QKPxxQrZXttPbA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9144), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9247), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9285), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9313), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9348), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9360), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9373), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(377), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(528), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(570), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(580), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(591), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(658), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(668), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(678), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(689), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(700), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(710), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(720), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(731), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(741), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(754), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(765), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(775), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(786), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(797), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(807), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(839), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(849), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(860), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(870), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(880), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(902), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(951), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(965), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(975), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1007), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1028), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1060), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1070), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1081), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1092), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1102), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1157), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1167), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1177), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1188), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1260), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1271), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1282), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1293), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1345), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1357), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1367), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1398), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1409), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1471), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1481), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1492), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1502), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1513), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1534), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1618), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1638), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1680), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1700), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1710), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1731), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1742), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1753), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1763), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1794), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1823), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1843), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1853), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1913), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1936), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1947), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1957), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1967), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1977), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1996), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2007), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2027), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2037), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2057), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2098), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2221), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2291), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2302), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2332), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2352), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2362), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2382), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2412), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2433), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2542), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2594), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2605), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2624), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2644), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2654), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2664), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(199), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 11, 9, 17, 42, 53, 663, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9467), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9503), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9514), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9532), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9558), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9478), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9505), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9516), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9534), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9543), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9551), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9559), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9480), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9517), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9526), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9544), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9552), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9508), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9518), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9527), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9536), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9553), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9497), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9509), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9519), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9537), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9546), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9554), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9563), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9520), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9529), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9538), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9564), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9501), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9511), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9521), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9539), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9565), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9502), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9512), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9522), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9541), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9549), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9557), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9566), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9568), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9643), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9653), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9669), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9638), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9654), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9665), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9634), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9639), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9666), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9635), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9640), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9646), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9651), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9636), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9647), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9652), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9657), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9662), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 11, 9, 17, 42, 53, 662, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_HardwareCategoryId",
                table: "Hardwares",
                column: "HardwareCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hardwares_ServiceId",
                table: "Hardwares",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_IpId",
                table: "IpAssignments",
                column: "IpId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_ServiceId",
                table: "IpAssignments",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RackId",
                table: "Locations",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ServiceId",
                table: "Locations",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.CreateTable(
                name: "HardwareServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HardwareCategoryId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateInstalled = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUninstalled = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsCurrent = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareServices_HardwareCategories_HardwareCategoryId",
                        column: x => x.HardwareCategoryId,
                        principalTable: "HardwareCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardwareServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IpServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IpId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateAssign = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUnassign = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpServices_Ips_IpId",
                        column: x => x.IpId,
                        principalTable: "Ips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IpServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RackId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    StartPosition = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationServices_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7818), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d2e79e6a-2044-44dc-b28d-4fc005fc56ab", "AQAAAAIAAYagAAAAEIRa7l74xuHwxEzOrkoffqTkPB/0HwrDaP8UDhF/EoyddlSRgaD/ZdcYBzqBAnam0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "46b73705-2c7b-4bd8-bb2f-a3fffb2a8caa", "AQAAAAIAAYagAAAAEAntUKAOE/OcUAlk7XxT2o8ltHZx5bWakFqMdfSbsD5Jwh8FGTh0GutTiO9+fLOwJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8156dad7-ba8d-4a9a-b85c-5695d5cc9e32", "AQAAAAIAAYagAAAAEODMLgv652yWJ/dOTiqd6uAi/7Mwawxslx+b/G8Pxzpwb4xssfAwyClZJsffUeJ4JA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0ea5660-79c6-4217-be3c-e9ce6a905bbd", "AQAAAAIAAYagAAAAEKkqtUrjfKEDfgo6//4Yo9fIvK9qHXZNq7yJv44cnL9TL8nQ0WeF38w6zL9OlHSkCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd356840-a7eb-4b8f-b054-69b226dd7607", "AQAAAAIAAYagAAAAEE5+0vOuGjZBjzJAiWoE4THikJXAJCUV1CoNCntMN3zjjYWip1j4GSLCvjCsFkgzdw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9348), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9561), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(120), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(130), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(184), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(283), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(453), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(604), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(633), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(727), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(748), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(771), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(796), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(820), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(914), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1069), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1173), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1184), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1195), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1205), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1216), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1257), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1278), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1289), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1331), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1340), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1351), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1361), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1467), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1636), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1667), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1735), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1767), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1798), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1830), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1851), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1861), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1881), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1903), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1913), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1923), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1974), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1997), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2055), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2098), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2218), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7959), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7985), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7944), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7987), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7936), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7931), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7992), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8065), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8072), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8056), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8074), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8057), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8075), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8053), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8058), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8038), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.CreateIndex(
                name: "IX_HardwareServices_HardwareCategoryId",
                table: "HardwareServices",
                column: "HardwareCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareServices_ServiceId",
                table: "HardwareServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_IpServices_IpId",
                table: "IpServices",
                column: "IpId");

            migrationBuilder.CreateIndex(
                name: "IX_IpServices_ServiceId",
                table: "IpServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationServices_RackId",
                table: "LocationServices",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationServices_ServiceId",
                table: "LocationServices",
                column: "ServiceId");
        }
    }
}
