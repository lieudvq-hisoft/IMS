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
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    TaxNumber = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyTypeId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, 8, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2957), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2972), false, "B", 5 }
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
                    { new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"), 0, "Address5", "8cabd45a-1c54-454e-a899-26e2081b2e3f", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEMnsi9MPKLjKI6VOiJQKCQyksrpkGfz+P3DX2wQjj6VrKUMIq6oTEbAwhwTuJgf8VQ==", "0000000005", false, "", false, "admin" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "3e6740df-70e4-4f1c-8132-827c91bd465b", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEAEuCsVcDn+3i2KWufz+5NFPbS01a5wvISFeTaXPfXk7p3A2wBYSJkCMwGZH67nGxQ==", "0000000003", false, "", false, "sale" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "0ac3cac6-a84c-4025-996c-68a0a619c352", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEE8vdmuLf6jJXurAK4J1c3Up/W0xknCs+9r+rdEmcFrdYM+RR/ixdLP3SvZMeWztdw==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "466319c2-774e-4c1d-8243-7e2ba8fc127d", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAENnGpD0b67GqzfKNT55867PNNsP5iBdRRBjTQ99NKMlXL05+vkeeowfgh61v795fGQ==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "ad9751c6-cce0-4e07-8700-b62b88d1bc2d", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEFzYO9iE1/h11B/2Vzo9lG5uHufe5Az5vmYyFyDbEsmk+TtgNakUBoB14w4IoGUTAw==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2694), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2803), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2817), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2830), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2842), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "HardwareCategories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2868), null, false, "CPU" },
                    { 2, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2883), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2883), null, false, "GPU" },
                    { 3, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2895), null, false, "RAM" },
                    { 4, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2907), null, false, "OS" },
                    { 5, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2929), null, false, "ROM" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3772), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3798), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3798), 193, false, 122, 25, 111 }
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
                    { 1, 1, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3817), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3818), false, false, 2 },
                    { 2, 2, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3833), false, false, 1 },
                    { 3, 3, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3845), false, false, 2 },
                    { 4, 4, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3855), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3855), false, false, 1 },
                    { 5, 5, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3866), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3867), false, false, 2 },
                    { 6, 6, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3924), false, false, 1 },
                    { 7, 7, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3935), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3935), false, false, 2 },
                    { 8, 8, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3945), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3946), false, false, 1 },
                    { 9, 9, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4037), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4038), false, false, 2 },
                    { 10, 10, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4119), false, false, 1 },
                    { 11, 11, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4137), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4137), false, false, 2 },
                    { 12, 12, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4148), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4149), false, false, 1 },
                    { 13, 13, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4159), false, false, 2 },
                    { 14, 14, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4170), false, false, 1 },
                    { 15, 15, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4180), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4180), false, false, 2 },
                    { 16, 16, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4191), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4191), false, false, 1 },
                    { 17, 17, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4201), false, false, 2 },
                    { 18, 18, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4214), false, false, 1 },
                    { 19, 19, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4224), false, false, 2 },
                    { 20, 20, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4235), false, false, 1 },
                    { 21, 21, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4245), false, false, 2 },
                    { 22, 22, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4255), false, false, 1 },
                    { 23, 23, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4266), false, false, 2 },
                    { 24, 24, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4275), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4276), false, false, 1 },
                    { 25, 25, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4286), false, false, 2 },
                    { 26, 26, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4297), false, false, 1 },
                    { 27, 27, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4307), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4307), false, false, 2 },
                    { 28, 28, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4317), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4318), false, false, 1 },
                    { 29, 29, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4328), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4328), false, false, 2 },
                    { 30, 30, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4339), false, false, 1 },
                    { 31, 31, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4349), false, false, 2 },
                    { 32, 32, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4397), false, false, 1 },
                    { 33, 33, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4408), false, false, 2 },
                    { 34, 34, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4420), false, false, 1 },
                    { 35, 35, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4431), false, false, 2 },
                    { 36, 36, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4441), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4441), false, false, 1 },
                    { 37, 37, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4452), false, false, 2 },
                    { 38, 38, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4462), false, false, 1 },
                    { 39, 39, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4472), false, false, 2 },
                    { 40, 40, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4482), false, false, 1 },
                    { 41, 41, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4492), false, false, 2 },
                    { 42, 42, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4503), false, false, 1 },
                    { 43, 43, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4512), false, false, 2 },
                    { 44, 44, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4523), false, false, 1 },
                    { 45, 45, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4533), false, false, 2 },
                    { 46, 46, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4543), false, false, 1 },
                    { 47, 47, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4553), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4554), false, false, 2 },
                    { 48, 48, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4563), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4564), false, false, 1 },
                    { 49, 49, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4574), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4574), false, false, 2 },
                    { 50, 50, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4584), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4584), false, false, 1 },
                    { 51, 51, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4595), false, false, 2 },
                    { 52, 52, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4605), false, false, 1 },
                    { 53, 53, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4618), false, false, 2 },
                    { 54, 54, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4628), false, false, 1 },
                    { 55, 55, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4639), false, false, 2 },
                    { 56, 56, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4649), false, false, 1 },
                    { 57, 57, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4660), false, false, 2 },
                    { 58, 58, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4707), false, false, 1 },
                    { 59, 59, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4718), false, false, 2 },
                    { 60, 60, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4728), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4728), false, false, 1 },
                    { 61, 61, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4738), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4739), false, false, 2 },
                    { 62, 62, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4749), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4749), false, false, 1 },
                    { 63, 63, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4759), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4760), false, false, 2 },
                    { 64, 64, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4770), false, false, 1 },
                    { 65, 65, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4780), false, false, 2 },
                    { 66, 66, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4793), false, false, 1 },
                    { 67, 67, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4804), false, false, 2 },
                    { 68, 68, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4814), false, false, 1 },
                    { 69, 69, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4825), false, false, 2 },
                    { 70, 70, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4836), false, false, 1 },
                    { 71, 71, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4846), false, false, 2 },
                    { 72, 72, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4856), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4857), false, false, 1 },
                    { 73, 73, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4867), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4867), false, false, 2 },
                    { 74, 74, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4878), false, false, 1 },
                    { 75, 75, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4889), false, false, 2 },
                    { 76, 76, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4900), false, false, 1 },
                    { 77, 77, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4910), false, false, 2 },
                    { 78, 78, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4920), false, false, 1 },
                    { 79, 79, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4930), false, false, 2 },
                    { 80, 80, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4940), false, false, 1 },
                    { 81, 81, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(4950), false, false, 2 },
                    { 82, 82, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5052), false, false, 1 },
                    { 83, 83, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5064), false, false, 2 },
                    { 84, 84, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5075), false, false, 1 },
                    { 85, 85, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5085), false, false, 2 },
                    { 86, 86, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5097), false, false, 1 },
                    { 87, 87, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5107), false, false, 2 },
                    { 88, 88, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5117), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5117), false, false, 1 },
                    { 89, 89, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5127), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5127), false, false, 2 },
                    { 90, 90, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5138), false, false, 1 },
                    { 91, 91, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5148), false, false, 2 },
                    { 92, 92, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5158), false, false, 1 },
                    { 93, 93, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5168), false, false, 2 },
                    { 94, 94, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5178), false, false, 1 },
                    { 95, 95, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5189), false, false, 2 },
                    { 96, 96, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5199), false, false, 1 },
                    { 97, 97, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5209), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5210), false, false, 2 },
                    { 98, 98, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5220), false, false, 1 },
                    { 99, 99, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5229), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5230), false, false, 2 },
                    { 100, 100, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5240), false, false, 1 },
                    { 101, 101, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5250), false, false, 2 },
                    { 102, 102, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5260), false, false, 1 },
                    { 103, 103, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5271), false, false, 2 },
                    { 104, 104, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5282), false, false, 1 },
                    { 105, 105, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5291), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5292), false, false, 2 },
                    { 106, 106, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5301), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5302), false, false, 1 },
                    { 107, 107, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5312), false, false, 2 },
                    { 108, 108, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5323), false, false, 1 },
                    { 109, 109, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5370), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5371), false, false, 2 },
                    { 110, 110, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5383), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5383), false, false, 1 },
                    { 111, 111, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5394), false, false, 2 },
                    { 112, 112, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5404), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5404), false, false, 1 },
                    { 113, 113, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5415), false, false, 2 },
                    { 114, 114, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5425), false, false, 1 },
                    { 115, 115, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5435), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5435), false, false, 2 },
                    { 116, 116, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5446), false, false, 1 },
                    { 117, 117, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5456), false, false, 2 },
                    { 118, 118, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5467), false, false, 1 },
                    { 119, 119, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5476), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5477), false, false, 2 },
                    { 120, 120, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5487), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5488), false, false, 1 },
                    { 121, 121, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5498), false, false, 2 },
                    { 122, 122, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5508), false, false, 1 },
                    { 123, 123, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5519), false, false, 2 },
                    { 124, 124, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5529), false, false, 1 },
                    { 125, 125, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5539), false, false, 2 },
                    { 126, 126, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5549), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5549), false, false, 1 },
                    { 127, 127, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5564), false, false, 2 },
                    { 128, 128, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5580), false, false, 1 },
                    { 129, 129, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5599), false, false, 2 },
                    { 130, 130, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5681), false, false, 1 },
                    { 131, 131, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5704), false, false, 2 },
                    { 132, 132, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5726), false, false, 1 },
                    { 133, 133, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5747), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5747), false, false, 2 },
                    { 134, 134, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5767), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5768), false, false, 1 },
                    { 135, 135, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5790), false, false, 2 },
                    { 136, 136, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5812), false, false, 1 },
                    { 137, 137, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5834), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5835), false, false, 2 },
                    { 138, 138, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5856), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5857), false, false, 1 },
                    { 139, 139, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5879), false, false, 2 },
                    { 140, 140, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5893), false, false, 1 },
                    { 141, 141, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5907), false, false, 2 },
                    { 142, 142, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5921), false, false, 1 },
                    { 143, 143, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5935), false, false, 2 },
                    { 144, 144, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5949), false, false, 1 },
                    { 145, 145, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5963), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5964), false, false, 2 },
                    { 146, 146, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5977), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5978), false, false, 1 },
                    { 147, 147, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5992), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(5992), false, false, 2 },
                    { 148, 148, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6006), false, false, 1 },
                    { 149, 149, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6020), false, false, 2 },
                    { 150, 150, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6033), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6034), false, false, 1 },
                    { 151, 151, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6049), false, false, 2 },
                    { 152, 152, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6063), false, false, 1 },
                    { 153, 153, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6076), false, false, 2 },
                    { 154, 154, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6090), false, false, 1 },
                    { 155, 155, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6103), false, false, 2 },
                    { 156, 156, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6117), false, false, 1 },
                    { 157, 157, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6172), false, false, 2 },
                    { 158, 158, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6185), false, false, 1 },
                    { 159, 159, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6195), false, false, 2 },
                    { 160, 160, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6205), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6206), false, false, 1 },
                    { 161, 161, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6216), false, false, 2 },
                    { 162, 162, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6226), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6227), false, false, 1 },
                    { 163, 163, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6237), false, false, 2 },
                    { 164, 164, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6248), false, false, 1 },
                    { 165, 165, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6258), false, false, 2 },
                    { 166, 166, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6269), false, false, 1 },
                    { 167, 167, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6279), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6279), false, false, 2 },
                    { 168, 168, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6289), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6290), false, false, 1 },
                    { 169, 169, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6300), false, false, 2 },
                    { 170, 170, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6314), false, false, 1 },
                    { 171, 171, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6324), false, false, 2 },
                    { 172, 172, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6335), false, false, 1 },
                    { 173, 173, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6345), false, false, 2 },
                    { 174, 174, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6356), false, false, 1 },
                    { 175, 175, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6367), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6367), false, false, 2 },
                    { 176, 176, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6377), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6377), false, false, 1 },
                    { 177, 177, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6387), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6388), false, false, 2 },
                    { 178, 178, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6398), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6398), false, false, 1 },
                    { 179, 179, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6408), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6408), false, false, 2 },
                    { 180, 180, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6418), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6419), false, false, 1 },
                    { 181, 181, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6428), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6429), false, false, 2 },
                    { 182, 182, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6440), false, false, 1 },
                    { 183, 183, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6455), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6455), false, false, 2 },
                    { 184, 184, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6468), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6469), false, false, 1 },
                    { 185, 185, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6516), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6517), false, false, 2 },
                    { 186, 186, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6528), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6529), false, false, 1 },
                    { 187, 187, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6539), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6539), false, false, 2 },
                    { 188, 188, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6550), false, false, 1 },
                    { 189, 189, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6559), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6560), false, false, 2 },
                    { 190, 190, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6570), false, false, 1 },
                    { 191, 191, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6580), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6580), false, false, 2 },
                    { 192, 192, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6591), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6591), false, false, 1 },
                    { 193, 193, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6602), false, false, 2 },
                    { 194, 194, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6613), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6613), false, false, 1 },
                    { 195, 195, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6623), false, false, 2 },
                    { 196, 196, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6634), false, false, 1 },
                    { 197, 197, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6644), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6644), false, false, 2 },
                    { 198, 198, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6654), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6654), false, false, 1 },
                    { 199, 199, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6664), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6664), false, false, 2 },
                    { 200, 200, false, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6675), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(6675), false, false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2978), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3020), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3073), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3082), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3091), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3100), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3108), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3116), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2988), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3022), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3075), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3084), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3093), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3101), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3109), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3117), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3117), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(2995), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3023), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3076), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3076), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3084), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3094), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3102), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3110), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3118), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3118), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3013), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3024), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3077), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3077), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3086), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3095), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3102), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3103), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3111), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3119), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3014), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3025), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3078), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3086), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3087), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3096), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3104), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3112), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3120), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3120), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3016), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3027), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3079), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3088), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3097), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3105), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3113), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3121), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3121), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3017), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3070), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3080), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3089), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3098), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3106), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3114), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3122), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3122), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3019), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3072), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3081), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3090), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3099), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3107), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3115), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3115), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3123), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3124), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3125), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3132), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3137), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3137), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3142), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3142), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3147), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3189), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3194), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3199), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3127), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3127), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3133), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3138), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3143), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3148), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3189), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3195), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3200), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3128), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3128), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3134), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3139), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3139), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3144), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3185), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3191), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3196), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3201), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3129), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3135), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3140), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3140), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3145), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3186), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3192), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3197), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3202), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3130), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3136), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3141), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3146), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3187), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3193), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3198), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 9, 9, 50, 43, 553, DateTimeKind.Local).AddTicks(3202), false, 3500.0, 5, 42 }
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
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

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
                name: "IX_Ips_NetworkId",
                table: "Ips",
                column: "NetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RackId",
                table: "Locations",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ServiceId",
                table: "Locations",
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
                name: "Hardwares");

            migrationBuilder.DropTable(
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "Locations");

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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
