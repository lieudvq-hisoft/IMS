using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RowCount = table.Column<int>(type: "integer", nullable: false),
                    ColumnCount = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "varchar(350)", nullable: false),
                    isDeactive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Fullname = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CurrenNoticeCount = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardwareCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareCategories", x => x.Id);
                });

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
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Racks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MaxPower = table.Column<double>(type: "double precision", nullable: false),
                    CurrentPower = table.Column<double>(type: "double precision", nullable: false),
                    Column = table.Column<int>(type: "integer", nullable: false),
                    Row = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    AreaId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racks_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    TaxNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CompanyTypeId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<int>(type: "integer", nullable: false),
                    Blocked = table.Column<bool>(type: "boolean", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ExpectedSize = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    InspectorNote = table.Column<string>(type: "text", nullable: true),
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    ReceiptOfRecipientFilePath = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
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
                name: "ServiceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    IsDelegated = table.Column<bool>(type: "boolean", nullable: false),
                    RequestId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRequests_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "ColumnCount", "DateCreated", "DateUpdated", "IsDeleted", "Name", "RowCount" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7818), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7819), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7885), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7886), false, "B", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "isDeactive" },
                values: new object[,]
                {
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), null, "Manager", "Manager", null, false },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), null, "Admin", "Admin", null, false },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), null, "Sale", "Sale", null, false },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), null, "IT Staff", "Tech", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"), 0, "Address5", "d2e79e6a-2044-44dc-b28d-4fc005fc56ab", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEIRa7l74xuHwxEzOrkoffqTkPB/0HwrDaP8UDhF/EoyddlSRgaD/ZdcYBzqBAnam0Q==", "0000000005", false, "", false, "admin" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "46b73705-2c7b-4bd8-bb2f-a3fffb2a8caa", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEAntUKAOE/OcUAlk7XxT2o8ltHZx5bWakFqMdfSbsD5Jwh8FGTh0GutTiO9+fLOwJQ==", "0000000003", false, "", false, "sale" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "8156dad7-ba8d-4a9a-b85c-5695d5cc9e32", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEODMLgv652yWJ/dOTiqd6uAi/7Mwawxslx+b/G8Pxzpwb4xssfAwyClZJsffUeJ4JA==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "f0ea5660-79c6-4217-be3c-e9ce6a905bbd", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEKkqtUrjfKEDfgo6//4Yo9fIvK9qHXZNq7yJv44cnL9TL8nQ0WeF38w6zL9OlHSkCA==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "fd356840-a7eb-4b8f-b054-69b226dd7607", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEE5+0vOuGjZBjzJAiWoE4THikJXAJCUV1CoNCntMN3zjjYWip1j4GSLCvjCsFkgzdw==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7213), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7430), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7478), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7508), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7533), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7534), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "HardwareCategories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7616), null, false, "CPU" },
                    { 2, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7653), null, false, "GPU" },
                    { 3, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7739), null, false, "RAM" },
                    { 4, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7776), null, false, "OS" },
                    { 5, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7789), null, false, "ROM" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8830), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8909), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8932), false, false, 2 },
                    { 2, 2, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8949), false, false, 1 },
                    { 3, 3, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8961), false, false, 2 },
                    { 4, 4, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8972), false, false, 1 },
                    { 5, 5, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8982), false, false, 2 },
                    { 6, 6, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8996), false, false, 1 },
                    { 7, 7, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9007), false, false, 2 },
                    { 8, 8, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9019), false, false, 1 },
                    { 9, 9, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9030), false, false, 2 },
                    { 10, 10, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9050), false, false, 1 },
                    { 11, 11, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9074), false, false, 2 },
                    { 12, 12, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9097), false, false, 1 },
                    { 13, 13, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9166), false, false, 2 },
                    { 14, 14, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9236), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9237), false, false, 1 },
                    { 15, 15, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9269), false, false, 2 },
                    { 16, 16, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9295), false, false, 1 },
                    { 17, 17, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9320), false, false, 2 },
                    { 18, 18, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9348), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9349), false, false, 1 },
                    { 19, 19, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9375), false, false, 2 },
                    { 20, 20, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9399), false, false, 1 },
                    { 21, 21, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9443), false, false, 2 },
                    { 22, 22, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9500), false, false, 1 },
                    { 23, 23, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9561), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9563), false, false, 2 },
                    { 24, 24, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9634), false, false, 1 },
                    { 25, 25, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9697), false, false, 2 },
                    { 26, 26, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9712), false, false, 1 },
                    { 27, 27, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9723), false, false, 2 },
                    { 28, 28, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9733), false, false, 1 },
                    { 29, 29, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9745), false, false, 2 },
                    { 30, 30, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9756), false, false, 1 },
                    { 31, 31, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9767), false, false, 2 },
                    { 32, 32, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9778), false, false, 1 },
                    { 33, 33, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9789), false, false, 2 },
                    { 34, 34, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9805), false, false, 1 },
                    { 35, 35, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9815), false, false, 2 },
                    { 36, 36, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9826), false, false, 1 },
                    { 37, 37, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9837), false, false, 2 },
                    { 38, 38, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9847), false, false, 1 },
                    { 39, 39, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9858), false, false, 2 },
                    { 40, 40, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9868), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9868), false, false, 1 },
                    { 41, 41, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9879), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9879), false, false, 2 },
                    { 42, 42, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9890), false, false, 1 },
                    { 43, 43, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9901), false, false, 2 },
                    { 44, 44, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9912), false, false, 1 },
                    { 45, 45, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9923), false, false, 2 },
                    { 46, 46, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9934), false, false, 1 },
                    { 47, 47, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9944), false, false, 2 },
                    { 48, 48, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9955), false, false, 1 },
                    { 49, 49, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9966), false, false, 2 },
                    { 50, 50, false, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(9976), false, false, 1 },
                    { 51, 51, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(53), false, false, 2 },
                    { 52, 52, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(66), false, false, 1 },
                    { 53, 53, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(77), false, false, 2 },
                    { 54, 54, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(89), false, false, 1 },
                    { 55, 55, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(99), false, false, 2 },
                    { 56, 56, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(109), false, false, 1 },
                    { 57, 57, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(120), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(120), false, false, 2 },
                    { 58, 58, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(130), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(131), false, false, 1 },
                    { 59, 59, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(141), false, false, 2 },
                    { 60, 60, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(152), false, false, 1 },
                    { 61, 61, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(163), false, false, 2 },
                    { 62, 62, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(174), false, false, 1 },
                    { 63, 63, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(184), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(185), false, false, 2 },
                    { 64, 64, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(196), false, false, 1 },
                    { 65, 65, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(206), false, false, 2 },
                    { 66, 66, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(220), false, false, 1 },
                    { 67, 67, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(230), false, false, 2 },
                    { 68, 68, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(241), false, false, 1 },
                    { 69, 69, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(252), false, false, 2 },
                    { 70, 70, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(262), false, false, 1 },
                    { 71, 71, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(273), false, false, 2 },
                    { 72, 72, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(283), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(284), false, false, 1 },
                    { 73, 73, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(294), false, false, 2 },
                    { 74, 74, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(305), false, false, 1 },
                    { 75, 75, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(351), false, false, 2 },
                    { 76, 76, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(363), false, false, 1 },
                    { 77, 77, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(374), false, false, 2 },
                    { 78, 78, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(385), false, false, 1 },
                    { 79, 79, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(396), false, false, 2 },
                    { 80, 80, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(407), false, false, 1 },
                    { 81, 81, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(419), false, false, 2 },
                    { 82, 82, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(430), false, false, 1 },
                    { 83, 83, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(441), false, false, 2 },
                    { 84, 84, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(453), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(453), false, false, 1 },
                    { 85, 85, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(474), false, false, 2 },
                    { 86, 86, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(497), false, false, 1 },
                    { 87, 87, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(532), false, false, 2 },
                    { 88, 88, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(604), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(606), false, false, 1 },
                    { 89, 89, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(633), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(634), false, false, 2 },
                    { 90, 90, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(657), false, false, 1 },
                    { 91, 91, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(680), false, false, 2 },
                    { 92, 92, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(703), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(704), false, false, 1 },
                    { 93, 93, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(727), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(727), false, false, 2 },
                    { 94, 94, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(748), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(749), false, false, 1 },
                    { 95, 95, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(771), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(772), false, false, 2 },
                    { 96, 96, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(796), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(797), false, false, 1 },
                    { 97, 97, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(820), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(821), false, false, 2 },
                    { 98, 98, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(843), false, false, 1 },
                    { 99, 99, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(914), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(914), false, false, 2 },
                    { 100, 100, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(949), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(951), false, false, 1 },
                    { 101, 101, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1040), false, false, 2 },
                    { 102, 102, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1069), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1069), false, false, 1 },
                    { 103, 103, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1129), false, false, 2 },
                    { 104, 104, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1142), false, false, 1 },
                    { 105, 105, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1153), false, false, 2 },
                    { 106, 106, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1163), false, false, 1 },
                    { 107, 107, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1173), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1174), false, false, 2 },
                    { 108, 108, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1184), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1184), false, false, 1 },
                    { 109, 109, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1195), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1195), false, false, 2 },
                    { 110, 110, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1205), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1205), false, false, 1 },
                    { 111, 111, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1216), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1216), false, false, 2 },
                    { 112, 112, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1227), false, false, 1 },
                    { 113, 113, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1237), false, false, 2 },
                    { 114, 114, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1247), false, false, 1 },
                    { 115, 115, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1257), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1258), false, false, 2 },
                    { 116, 116, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1268), false, false, 1 },
                    { 117, 117, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1278), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1279), false, false, 2 },
                    { 118, 118, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1289), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1289), false, false, 1 },
                    { 119, 119, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1300), false, false, 2 },
                    { 120, 120, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1310), false, false, 1 },
                    { 121, 121, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1320), false, false, 2 },
                    { 122, 122, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1331), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1331), false, false, 1 },
                    { 123, 123, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1340), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1341), false, false, 2 },
                    { 124, 124, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1351), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1352), false, false, 1 },
                    { 125, 125, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1361), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1362), false, false, 2 },
                    { 126, 126, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1372), false, false, 1 },
                    { 127, 127, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1383), false, false, 2 },
                    { 128, 128, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1393), false, false, 1 },
                    { 129, 129, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1404), false, false, 2 },
                    { 130, 130, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1456), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1457), false, false, 1 },
                    { 131, 131, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1467), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1467), false, false, 2 },
                    { 132, 132, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1478), false, false, 1 },
                    { 133, 133, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1489), false, false, 2 },
                    { 134, 134, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1499), false, false, 1 },
                    { 135, 135, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1510), false, false, 2 },
                    { 136, 136, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1521), false, false, 1 },
                    { 137, 137, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1531), false, false, 2 },
                    { 138, 138, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1542), false, false, 1 },
                    { 139, 139, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1552), false, false, 2 },
                    { 140, 140, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1563), false, false, 1 },
                    { 141, 141, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1573), false, false, 2 },
                    { 142, 142, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1583), false, false, 1 },
                    { 143, 143, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1594), false, false, 2 },
                    { 144, 144, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1605), false, false, 1 },
                    { 145, 145, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1615), false, false, 2 },
                    { 146, 146, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1626), false, false, 1 },
                    { 147, 147, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1636), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1636), false, false, 2 },
                    { 148, 148, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1646), false, false, 1 },
                    { 149, 149, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1657), false, false, 2 },
                    { 150, 150, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1667), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1668), false, false, 1 },
                    { 151, 151, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1713), false, false, 2 },
                    { 152, 152, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1724), false, false, 1 },
                    { 153, 153, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1735), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1735), false, false, 2 },
                    { 154, 154, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1746), false, false, 1 },
                    { 155, 155, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1757), false, false, 2 },
                    { 156, 156, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1767), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1767), false, false, 1 },
                    { 157, 157, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1777), false, false, 2 },
                    { 158, 158, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1788), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1788), false, false, 1 },
                    { 159, 159, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1798), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1799), false, false, 2 },
                    { 160, 160, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1809), false, false, 1 },
                    { 161, 161, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1820), false, false, 2 },
                    { 162, 162, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1830), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1830), false, false, 1 },
                    { 163, 163, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1841), false, false, 2 },
                    { 164, 164, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1851), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1851), false, false, 1 },
                    { 165, 165, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1861), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1861), false, false, 2 },
                    { 166, 166, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1871), false, false, 1 },
                    { 167, 167, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1881), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1882), false, false, 2 },
                    { 168, 168, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1892), false, false, 1 },
                    { 169, 169, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1903), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1903), false, false, 2 },
                    { 170, 170, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1913), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1913), false, false, 1 },
                    { 171, 171, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1923), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1923), false, false, 2 },
                    { 172, 172, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1934), false, false, 1 },
                    { 173, 173, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1945), false, false, 2 },
                    { 174, 174, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1955), false, false, 1 },
                    { 175, 175, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1974), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1975), false, false, 2 },
                    { 176, 176, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1986), false, false, 1 },
                    { 177, 177, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1997), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(1997), false, false, 2 },
                    { 178, 178, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2044), false, false, 1 },
                    { 179, 179, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2055), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2056), false, false, 2 },
                    { 180, 180, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2067), false, false, 1 },
                    { 181, 181, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2078), false, false, 2 },
                    { 182, 182, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2088), false, false, 1 },
                    { 183, 183, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2098), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2099), false, false, 2 },
                    { 184, 184, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2109), false, false, 1 },
                    { 185, 185, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2120), false, false, 2 },
                    { 186, 186, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2131), false, false, 1 },
                    { 187, 187, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2141), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2142), false, false, 2 },
                    { 188, 188, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2152), false, false, 1 },
                    { 189, 189, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2163), false, false, 2 },
                    { 190, 190, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2174), false, false, 1 },
                    { 191, 191, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2185), false, false, 2 },
                    { 192, 192, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2196), false, false, 1 },
                    { 193, 193, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2207), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2207), false, false, 2 },
                    { 194, 194, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2218), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2218), false, false, 1 },
                    { 195, 195, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2229), false, false, 2 },
                    { 196, 196, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2239), false, false, 1 },
                    { 197, 197, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2250), false, false, 2 },
                    { 198, 198, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2261), false, false, 1 },
                    { 199, 199, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2272), false, false, 2 },
                    { 200, 200, false, new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 11, 9, 17, 38, 23, 145, DateTimeKind.Local).AddTicks(2282), false, false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7893), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7932), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7941), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7942), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7951), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7959), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7959), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7968), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7977), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7985), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7985), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7908), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7934), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7934), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7944), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7952), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7961), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7961), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7969), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7977), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7978), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7986), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7914), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7935), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7944), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7945), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7952), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7953), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7962), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7962), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7970), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7979), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7987), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7987), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7925), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7936), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7936), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7946), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7954), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7963), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7971), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7980), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7988), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7926), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7926), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7937), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7946), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7947), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7955), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7964), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7972), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7981), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7989), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7929), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7938), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7948), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7956), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7965), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7973), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7982), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7991), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7930), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7939), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7948), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7949), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7957), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7966), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7975), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7983), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7992), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7931), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7931), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7940), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7950), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7958), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7967), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7967), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7975), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7976), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7984), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7992), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7993), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7994), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(7994), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8040), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8045), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8050), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8050), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8055), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8060), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8060), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8065), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8065), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8072), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8073), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8036), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8041), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8041), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8046), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8046), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8051), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8056), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8056), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8061), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8066), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8074), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8074), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8037), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8042), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8047), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8052), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8052), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8057), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8057), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8062), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8067), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8075), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8076), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8038), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8043), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8043), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8048), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8048), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8053), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8053), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8058), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8058), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8063), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8068), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8077), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8038), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8039), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8044), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8049), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8054), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8059), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8064), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8071), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 11, 9, 17, 38, 23, 144, DateTimeKind.Local).AddTicks(8079), false, 3500.0, 5, 42 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyTypeId",
                table: "Customers",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxNumber",
                table: "Customers",
                column: "TaxNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HardwareServices_HardwareCategoryId",
                table: "HardwareServices",
                column: "HardwareCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareServices_ServiceId",
                table: "HardwareServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Ips_NetworkId",
                table: "Ips",
                column: "NetworkId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Racks_AreaId",
                table: "Racks",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_RequestId",
                table: "ServiceRequests",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ServiceId",
                table: "ServiceRequests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId",
                table: "ServiceRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId1",
                table: "ServiceRequests",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HardwareServices");

            migrationBuilder.DropTable(
                name: "IpServices");

            migrationBuilder.DropTable(
                name: "LocationServices");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "HardwareCategories");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
