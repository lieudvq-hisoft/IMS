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
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false),
                    NumberOfPort = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    BasePower = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
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
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    DNS = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servers_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
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
                    RackId = table.Column<int>(type: "integer", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Collocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ExpectedSize = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    InspectorNote = table.Column<string>(type: "text", nullable: true),
                    DateAllocate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateStop = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ServerId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collocations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collocations_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeviceLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsMoveout = table.Column<bool>(type: "boolean", nullable: false),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceLocations_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CollocationId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Collocations_CollocationId",
                        column: x => x.CollocationId,
                        principalTable: "Collocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Services_ServiceId",
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
                    { 1, 8, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3380), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3381), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3403), false, "B", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "isDeactive" },
                values: new object[,]
                {
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), null, "Customer", "Customer", null, false },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), null, "IT Staff", "IT", null, false },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), null, "Sale", "Sale", null, false },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), null, "Manager", "Manager", null, false },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), null, "Admin", "Admin", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 0, "Address2", "59590666-d50b-4527-bd84-62fb3ae10b89", 0, "it@gmail.com", true, "Fullname2", false, false, null, "it@gmail.com", "it", "AQAAAAIAAYagAAAAEDqYtDAGCfxreHa6rlRa/TkEWD5Yz/1a6J+3c8eUs6fiC7b/CppbsjjwVanlVP/ROg==", "0000000002", false, "", false, "it" },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), 0, "Address3", "263cecb5-c852-47bd-a7bd-96f463bb876e", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEKvmWGFxHBcBDBVKNtbtFXPj3l8pB84QXOm/mVWi6XLRfRVfwASP7GUEUyJBsaVczQ==", "0000000003", false, "", false, "sale" },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), 0, "Address4", "93967dc2-ee1d-489f-8053-b3096af6dc68", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEN1DP5uWHmpBKf2oSIWsQesrQigubkSaPrDXnOdZFptqOgR7cthKmkVwzNmS22LBCw==", "0000000004", false, "", false, "manager" },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), 0, "Address5", "8a3ea6eb-6109-4666-927e-f52540152394", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEBom9dmr4guX+6jOdTgehm6bQ2lHx6yYZBxgb5oAPetyNAeJlkwb1O0BrXD1UjZFcA==", "0000000005", false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3047), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3107), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3116), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3124), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3131), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "NumberOfPort", "Size", "Status", "Type" },
                values: new object[] { 1, 200, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3313), false, 3, 2, 0, "Mock" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3150), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3166), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 10, 14, 22, 16, 10, 848, DateTimeKind.Local).AddTicks(3174), "Công suất 100", false, "Công suất 100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd") },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba") },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7") }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3430), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4933), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5080), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5411), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5411), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5595), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5595), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5673), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5674), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5750), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5863), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3464), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4978), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5094), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5423), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5607), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5607), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5683), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5683), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5760), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5873), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3477), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(4994), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5104), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5433), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5434), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5617), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5692), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5768), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5769), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5883), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3511), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5015), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5114), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5444), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5626), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5702), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5777), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5778), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5893), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3524), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5039), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5131), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5455), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5635), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5636), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5712), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5787), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5787), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5902), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3617), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5049), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5141), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5465), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5646), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5721), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5722), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5796), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5912), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3630), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5059), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5151), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5573), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5574), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5654), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5655), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5731), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5731), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5840), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5921), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(3640), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5070), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5395), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5396), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5586), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5663), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5664), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5740), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5741), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5853), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5930), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5941), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6001), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6001), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6058), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6139), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6188), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6235), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6282), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6282), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6332), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5953), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5953), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6019), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6067), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6149), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6196), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6197), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6244), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6292), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6293), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6342), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5962), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5962), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6029), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6076), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6158), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6158), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6206), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6254), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6303), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6351), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5972), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6038), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6039), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6118), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6168), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6215), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6263), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6313), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6362), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5981), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(5981), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6048), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6130), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6178), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6225), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6272), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6323), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6402), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6403), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "RackId", "StartPosition" },
                values: new object[] { 1, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6425), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6425), false, 1, 2 });

            migrationBuilder.InsertData(
                table: "DeviceLocations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "LocationId" },
                values: new object[] { 1, new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6450), new DateTime(2023, 10, 14, 22, 16, 11, 139, DateTimeKind.Local).AddTicks(6450), 1, false, false, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_CollocationId",
                table: "AdditionalServices",
                column: "CollocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ServiceId",
                table: "AdditionalServices",
                column: "ServiceId");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Collocations_CustomerId",
                table: "Collocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Collocations_ServerId",
                table: "Collocations",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyTypeId",
                table: "Customers",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceLocations_DeviceId",
                table: "DeviceLocations",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceLocations_LocationId",
                table: "DeviceLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RackId",
                table: "Locations",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_AreaId",
                table: "Racks",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers",
                column: "DeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalServices");

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
                name: "DeviceLocations");

            migrationBuilder.DropTable(
                name: "Collocations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
