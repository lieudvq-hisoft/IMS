using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class update_table_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9578), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9592), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe842ea6-ed68-4cac-a02d-8c065feb9992", "AQAAAAIAAYagAAAAEOr/90k8KRf+oqY7o3spZNvgPEowmt1qvK7WFNNSjpbJkEe/HNBLqH+vsA7dSE79Sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "063cebbe-6790-47be-bc9d-a1cda750a855", "AQAAAAIAAYagAAAAENa7ezOPgv7nzjjaAri7qP+Hj1x7XDbCLUfm5pp7S3wxzNJ/PZ3gb094pgxnW3vK4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b65c0896-1ba1-49af-8571-5b5f7f208e05", "AQAAAAIAAYagAAAAEEZCKhPiFDVEXkSUhBrWB3H/tShKP52DqytjPdS31riIGv4J/qgdJkpIOXSHX2/JXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c40f8e29-f8e9-42a5-9ab5-f2209edfefe2", "AQAAAAIAAYagAAAAEAvOlhjvu3YYf7CCmX1NNqOOnGL3jtx2Vn7g1uyI8MQICZQ0cSLAuh3L6SYWFCBhDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "369d931b-6736-4067-9404-15c7ac877a69", "AQAAAAIAAYagAAAAEOs/1LEqYG46U1o+Mczyo7R/TjFTI0roR00wCp8ByLdwdtmFMfnHDUUaOo9ol5qOmQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9275), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9436), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9464), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9477), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9488), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9510), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9525), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9546), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9557), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(446), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(523), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(551), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(596), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(608), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(631), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(642), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(653), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(698), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(709), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(721), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(744), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(754), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(765), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(788), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(799), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(810), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(821), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(889), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(923), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(934), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(947), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(958), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(969), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(980), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(991), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1012), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1077), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1094), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1149), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1193), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1357), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1423), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1435), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1446), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1457), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1468), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1520), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1541), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1559), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1590), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1622), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1633), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1645), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1666), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1733), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1743), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1754), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1764), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1774), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1796), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1807), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1839), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1862), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1873), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1884), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1896), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1906), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1918), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1928), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1939), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1971), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1993), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2003), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2075), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2211), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2221), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2243), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2264), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2359), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2464), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2486), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2518), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2529), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2592), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2603), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2624), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2645), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2655), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2763), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2838), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2880), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2902), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2912), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 11, 9, 10, 12, 34, 655, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9598), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9608), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9727), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9720), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9677), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9687), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9729), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9665), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9669), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9689), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9706), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9716), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9724), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9682), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9717), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9734), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9803), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9789), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9795), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 11, 9, 10, 12, 34, 654, DateTimeKind.Local).AddTicks(9807) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cabd45a-1c54-454e-a899-26e2081b2e3f", "AQAAAAIAAYagAAAAEMnsi9MPKLjKI6VOiJQKCQyksrpkGfz+P3DX2wQjj6VrKUMIq6oTEbAwhwTuJgf8VQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e6740df-70e4-4f1c-8132-827c91bd465b", "AQAAAAIAAYagAAAAEAEuCsVcDn+3i2KWufz+5NFPbS01a5wvISFeTaXPfXk7p3A2wBYSJkCMwGZH67nGxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ac3cac6-a84c-4025-996c-68a0a619c352", "AQAAAAIAAYagAAAAEE8vdmuLf6jJXurAK4J1c3Up/W0xknCs+9r+rdEmcFrdYM+RR/ixdLP3SvZMeWztdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "466319c2-774e-4c1d-8243-7e2ba8fc127d", "AQAAAAIAAYagAAAAENnGpD0b67GqzfKNT55867PNNsP5iBdRRBjTQ99NKMlXL05+vkeeowfgh61v795fGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad9751c6-cce0-4e07-8700-b62b88d1bc2d", "AQAAAAIAAYagAAAAEFzYO9iE1/h11B/2Vzo9lG5uHufe5Az5vmYyFyDbEsmk+TtgNakUBoB14w4IoGUTAw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2883), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "HardwareCategories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3817), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3935), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4137), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4148), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4180), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4307), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4317), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4328), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4563), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4574), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4728), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4738), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4749), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4759), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4867), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5117), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5127), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5209), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5229), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5291), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5301), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5383), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5476), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5549), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5767), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5834), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5977), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5992), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6205), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6226), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6279), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6377), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6387), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6398), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6408), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6428), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6468), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6516), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6528), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6591), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6654), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6675), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3798), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3117), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3076), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3118), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3077), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3086), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3121), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3122), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3115), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3124), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3142), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3127), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3128), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3139), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3140), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3202) });

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
    }
}
