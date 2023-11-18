using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ip_relate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IpSubnets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstOctet = table.Column<int>(type: "integer", nullable: false),
                    SecondOctet = table.Column<int>(type: "integer", nullable: false),
                    ThirdOctet = table.Column<int>(type: "integer", nullable: false),
                    SubnetMask = table.Column<int>(type: "integer", nullable: false),
                    ParentNetworkId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpSubnets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpSubnets_IpSubnets_ParentNetworkId",
                        column: x => x.ParentNetworkId,
                        principalTable: "IpSubnets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestHosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    ServerAllocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestHosts_ServerAllocations_ServerAllocationId",
                        column: x => x.ServerAllocationId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IpAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<int>(type: "integer", nullable: false),
                    Blocked = table.Column<bool>(type: "boolean", nullable: false),
                    IsReserved = table.Column<bool>(type: "boolean", nullable: false),
                    IpSubnetId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpAddresses_IpSubnets_IpSubnetId",
                        column: x => x.IpSubnetId,
                        principalTable: "IpSubnets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestHostAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestHostId = table.Column<int>(type: "integer", nullable: false),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHostAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestHostAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestHostAppointments_RequestHosts_RequestHostId",
                        column: x => x.RequestHostId,
                        principalTable: "RequestHosts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestHostUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RequestHostId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHostUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestHostUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestHostUsers_RequestHosts_RequestHostId",
                        column: x => x.RequestHostId,
                        principalTable: "RequestHosts",
                        principalColumn: "Id");
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
                    IpAddressId = table.Column<int>(type: "integer", nullable: false),
                    ServerAllocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpAssignments_IpAddresses_IpAddressId",
                        column: x => x.IpAddressId,
                        principalTable: "IpAddresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IpAssignments_ServerAllocations_ServerAllocationId",
                        column: x => x.ServerAllocationId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestHostIps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IpAddressId = table.Column<int>(type: "integer", nullable: false),
                    RequestHostId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestHostIps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestHostIps_IpAddresses_IpAddressId",
                        column: x => x.IpAddressId,
                        principalTable: "IpAddresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestHostIps_RequestHosts_RequestHostId",
                        column: x => x.RequestHostId,
                        principalTable: "RequestHosts",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6395), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6b824d23-53db-4e0e-bdfb-a2320027bba8", new DateTime(2023, 11, 18, 16, 32, 56, 478, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 11, 18, 16, 32, 56, 478, DateTimeKind.Local).AddTicks(5983), "AQAAAAIAAYagAAAAEM+hBbRjMvDOu6KGKXQS6tV0DQMnLhf3aDmdrTxCbvGMk9O5yujmp0doVF68CWUlRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "244afe47-5fef-40a0-933e-e379d71b8748", new DateTime(2023, 11, 18, 16, 32, 56, 320, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 11, 18, 16, 32, 56, 320, DateTimeKind.Local).AddTicks(6028), "AQAAAAIAAYagAAAAEAIpwejI+Jc7v2j8C1SzsypJHxOPKLBJ+zHvWIvqkdhagORF645TFP8KwV+HqkK5hA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "419b087f-da08-412b-bb0f-10600a7e8022", new DateTime(2023, 11, 18, 16, 32, 56, 398, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 11, 18, 16, 32, 56, 398, DateTimeKind.Local).AddTicks(2265), "AQAAAAIAAYagAAAAEOWDFvW+DnzoioIJGC/9q725DH8uyEP6FkL6Tx9jJ+uLENEJxCvzadHJRKGnAfNLzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ef9f9050-daa5-43dc-9134-80f1cffdace5", new DateTime(2023, 11, 18, 16, 32, 56, 250, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 11, 18, 16, 32, 56, 250, DateTimeKind.Local).AddTicks(160), "AQAAAAIAAYagAAAAEFcFO7ZN3MDv+2T+h5uzhLtc0wQ1LCHx4gYkFG8cMW2c7iUv3DYCw/ZwURKziDaruw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dba79aaf-baba-4460-a7ec-43d78f61ad2b", new DateTime(2023, 11, 18, 16, 32, 56, 174, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 11, 18, 16, 32, 56, 174, DateTimeKind.Local).AddTicks(3196), "AQAAAAIAAYagAAAAELsucVtjkfRNDwILkVTAjrKIosid5qwBAsD4YynmAPf+GI6vBfUxtv1JZUPHyEd7ig==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6452), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6461), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6486), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6494), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6502), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6442), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6487), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6495), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6503), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6444), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6464), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6471), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6480), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6488), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6445), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6456), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6465), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6481), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6489), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6482), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6498), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6448), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6466), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6483), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6518), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6459), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6467), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6475), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6476) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6484), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6492), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6500), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6451), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6468), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6476), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6520), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6521), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6528), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6533), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6538), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6543), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6548), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6558), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6523), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6529), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6534), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6544), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6530), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6535), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6540), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6545), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6555), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6525), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6531), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6541), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6551), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6561), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6527), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6537), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6547), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6552), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6557), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6562), new DateTime(2023, 11, 18, 16, 32, 56, 168, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.CreateIndex(
                name: "IX_IpAddresses_IpSubnetId",
                table: "IpAddresses",
                column: "IpSubnetId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_IpAddressId",
                table: "IpAssignments",
                column: "IpAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_ServerAllocationId",
                table: "IpAssignments",
                column: "ServerAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_IpSubnets_ParentNetworkId",
                table: "IpSubnets",
                column: "ParentNetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostAppointments_AppointmentId",
                table: "RequestHostAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostAppointments_RequestHostId",
                table: "RequestHostAppointments",
                column: "RequestHostId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostIps_IpAddressId",
                table: "RequestHostIps",
                column: "IpAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostIps_RequestHostId",
                table: "RequestHostIps",
                column: "RequestHostId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHosts_ServerAllocationId",
                table: "RequestHosts",
                column: "ServerAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostUsers_RequestHostId",
                table: "RequestHostUsers",
                column: "RequestHostId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestHostUsers_UserId",
                table: "RequestHostUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "RequestHostAppointments");

            migrationBuilder.DropTable(
                name: "RequestHostIps");

            migrationBuilder.DropTable(
                name: "RequestHostUsers");

            migrationBuilder.DropTable(
                name: "IpAddresses");

            migrationBuilder.DropTable(
                name: "RequestHosts");

            migrationBuilder.DropTable(
                name: "IpSubnets");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8629), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "790a71e0-e14d-46cb-a364-5d20f39e531d", new DateTime(2023, 11, 17, 17, 1, 19, 612, DateTimeKind.Local).AddTicks(7463), new DateTime(2023, 11, 17, 17, 1, 19, 612, DateTimeKind.Local).AddTicks(7476), "AQAAAAIAAYagAAAAECLcNW42PViwywlV/T0caPKXpvQ/u47FPmb8BiAXpkGxwXcpwpbEydb6ua5pSMM8OA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f1c8f8b8-ca3b-45aa-a8a4-4ee4831a97e1", new DateTime(2023, 11, 17, 17, 1, 19, 450, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 11, 17, 17, 1, 19, 450, DateTimeKind.Local).AddTicks(9435), "AQAAAAIAAYagAAAAECZ1SQUTtGvDYSPK8EnDSsAbcE58XZeayUygIRZ8NSqv4Ip4aZoijLVp5l3cHkq0bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "054536fd-f52b-42b4-b37e-7d26233fa444", new DateTime(2023, 11, 17, 17, 1, 19, 520, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 11, 17, 17, 1, 19, 520, DateTimeKind.Local).AddTicks(5319), "AQAAAAIAAYagAAAAEBjAxbvPKa4IU7lwUiJPqeIHz/gj+FtEpN+B+T/hPXnRtkYQq775FesTl6lk1/BgiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b3e488d1-132a-4279-b7f7-94eafb6f3ebe", new DateTime(2023, 11, 17, 17, 1, 19, 364, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 11, 17, 17, 1, 19, 364, DateTimeKind.Local).AddTicks(9504), "AQAAAAIAAYagAAAAEMZekXXHerGsSqBxTIkTeeTW+CokB34Ghor6GWWoKcI/Gd/n1bQvdUYSTjDXfDwQvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ed999b42-a537-4f8f-85f1-4edd4db15268", new DateTime(2023, 11, 17, 17, 1, 19, 291, DateTimeKind.Local).AddTicks(5776), new DateTime(2023, 11, 17, 17, 1, 19, 291, DateTimeKind.Local).AddTicks(5788), "AQAAAAIAAYagAAAAEMOEwlTDxeIU957eNTHgQoGiYc6aP6T4/DGycowCIC8NmCglGoYbuYZ3TQ2TopuiGQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8459), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8473), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8525), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8557), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8655), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8742), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8675), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8685), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8694), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8743), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8678), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8688), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8738), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8680), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8812), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8817), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8813), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8814), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8815), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8816), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 11, 17, 17, 1, 19, 285, DateTimeKind.Local).AddTicks(8855) });
        }
    }
}
