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
                    IsMoveout = table.Column<bool>(type: "boolean", nullable: false),
                    DeviceId = table.Column<int>(type: "integer", nullable: false),
                    RackId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colocations",
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
                    table.PrimaryKey("PK_Colocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colocations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colocations_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ColocationId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Colocations_ColocationId",
                        column: x => x.ColocationId,
                        principalTable: "Colocations",
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
                    { 1, 8, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4578), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4587), false, "B", 5 }
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
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 0, "Address2", "62ba14d9-d0ae-47f6-b126-4bbdc9c7da4b", 0, "it@gmail.com", true, "Fullname2", false, false, null, "it@gmail.com", "it", "AQAAAAIAAYagAAAAEJ8Vcbh0EyIVwU44U4Qtg8PK1mespfA9BGYEEM2riVAz5rev/d9Nu1OnnBlikDTwug==", "0000000002", false, "", false, "it" },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), 0, "Address3", "5a373d9b-349d-4f4c-8619-0d03017d776c", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEM5K75p5D2QHrW5hAIuXP3St1Eb5hGbhuFN+I6dkxverN20vTU3vD+GprM/btnxBdg==", "0000000003", false, "", false, "sale" },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), 0, "Address4", "e794fb2a-680b-4288-b4f9-13cc6606cb13", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEA1kg08vfrS8coN+Gh6Q29sGK/a/OHy9sACB3G/rUqaSlL1v0Yefu9JPEV/AVIqZ3w==", "0000000004", false, "", false, "manager" },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), 0, "Address5", "202ccf26-07c3-406f-9c9a-7ccb457f082d", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEMyX+FfZmJad5+h/ZtSmwVtLpF3WNqJlZCbYUV1dPf95PTuoZXsmFj7hTIP01nzg8A==", "0000000005", false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6392), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6403), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6463), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6474), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6475), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6486), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6496), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "NumberOfPort", "Size", "Status", "Type" },
                values: new object[] { 1, 200, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4516), false, 3, 2, 0, "Mock" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6517), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6534), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6534), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6546), new DateTime(2023, 10, 16, 21, 54, 35, 588, DateTimeKind.Local).AddTicks(6547), "Công suất 100", false, "Công suất 100" }
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
                    { 1, 1, 1, 200.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4602), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4796), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4837), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4838), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4880), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4993), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5043), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5085), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5127), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4611), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4612), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4802), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4844), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4885), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5007), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5007), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5048), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5048), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5090), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5208), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4618), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4807), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4849), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4890), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5012), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5053), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5096), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5213), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4627), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4627), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4812), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4813), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4854), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4854), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4895), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5017), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5017), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5058), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5101), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5219), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4633), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4818), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4860), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4900), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5023), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5064), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5064), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5106), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5106), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5224), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5224), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4644), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4822), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4822), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4864), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4864), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4906), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5028), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5069), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5111), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5111), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5229), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5229), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4650), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4827), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4869), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4870), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4910), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4911), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5033), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5074), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5116), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5235), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4785), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4786), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4832), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4874), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4875), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4915), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(4916), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5038), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5038), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5080), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5121), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5240), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5247), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5247), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5275), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5300), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5300), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5397), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5424), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5424), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5449), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5689), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5690), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5716), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5717), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5254), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5255), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5280), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5305), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5305), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5405), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5405), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5429), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5429), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5454), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5454), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5696), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5696), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5722), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5722), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5260), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5285), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5285), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5310), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5409), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5410), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5434), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5459), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5460), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5701), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5727), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5727), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5265), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5265), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5290), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5315), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5414), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5414), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5439), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5464), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5465), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5706), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5732), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5732), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5270), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5295), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5295), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5320), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5419), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5444), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5444), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5470), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5711), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5711), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5737), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5737), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[] { 1, new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5752), new DateTime(2023, 10, 16, 21, 54, 35, 929, DateTimeKind.Local).AddTicks(5752), 1, false, false, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ColocationId",
                table: "AdditionalServices",
                column: "ColocationId");

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
                name: "IX_Colocations_CustomerId",
                table: "Colocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations",
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
                name: "IX_Locations_DeviceId",
                table: "Locations",
                column: "DeviceId");

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
                column: "DeviceId",
                unique: true);
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
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Colocations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
