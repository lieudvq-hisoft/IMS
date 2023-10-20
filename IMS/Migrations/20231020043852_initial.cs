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
                    { 1, 8, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7681), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7681), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7690), false, "B", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "isDeactive" },
                values: new object[,]
                {
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), null, "Sale", "Sale", null, false },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), null, "Admin", "Admin", null, false },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), null, "Manager", "Manager", null, false },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), null, "IT Staff", "Tech", null, false },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), null, "Customer", "Customer", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "adee62ba-4d65-406f-b924-d111012d883e", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEIiA0yGn2i0bxYxF+T8jbz4GswzTgB0roVaGcx6u/Qz+wtoj4mkLH7o+Pmm5t36BJw==", "0000000003", false, "", false, "sale" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "9926c551-4e3e-4be2-bdc9-f539f34fd744", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEGhiK1KbQbUYCkD//rbTBY5CuU7qBr7w7Jtfkbi9Ktdzr5cW8ihlcaIL+h8k9iB/bg==", "0000000005", false, "", false, "admin" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "3e934a58-7c47-47e6-9231-84ea341e858d", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEGgLuXdO0mnjnoYYwKk0yxyeG+6Sy1+lDftQJgabkAGKn12JQykXY0RaPASSOA3cBA==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "69f477d1-28d8-4d88-8589-2694ace0a12a", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAENO3DQblKfRaN9Ii1ONtRTesdic0SeQPPMgFfLdBSR0jVHBR5I6h+0gK9CtotPwq9w==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "57751ee0-13d8-47f7-a5c4-ac0acdadb793", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEAj+Pnu08gQNzhqb7HdEz8FvN3f/JosCv7HiqKDt+CLmkSdyzBfb5S1HSysGONqaXg==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9482), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9493), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9535), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9548), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9549), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9560), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9571), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "NumberOfPort", "Size", "Status", "Type" },
                values: new object[] { 1, 200, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7656), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7656), false, 3, 2, 1, "Mock" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9599), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9661), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 10, 20, 11, 38, 52, 65, DateTimeKind.Local).AddTicks(9675), "Công suất 100", false, "Công suất 100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[] { 1, "super", 1, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7585), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7589), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7713), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7713), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7738), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7745), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7753), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7856), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7865), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7872), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7879), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7729), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7729), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7739), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7739), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7747), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7754), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7859), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7866), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7873), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7879), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7879), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7730), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7740), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7748), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7754), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7859), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7860), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7867), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7874), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7880), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7731), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7731), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7741), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7748), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7755), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7861), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7867), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7868), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7874), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7874), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7881), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7881), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7732), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7732), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7742), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7749), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7756), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7861), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7868), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7875), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7882), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7734), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7743), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7750), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7757), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7862), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7869), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7876), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7876), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7883), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7735), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7744), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7751), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7758), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7863), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7870), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7870), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7877), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7884), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7737), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7744), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7752), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7854), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7864), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7871), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7871), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7878), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7884), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7884), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7886), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7886), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7892), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7896), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7896), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7901), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7905), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7909), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7913), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7914), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7918), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7888), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7893), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7897), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7897), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7901), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7902), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7906), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7910), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7914), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7914), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7918), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7919), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7889), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7889), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7894), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7898), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7903), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7907), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7911), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7915), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7919), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7919), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7890), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7895), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7899), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7903), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7903), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7908), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7912), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7916), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7916), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7920), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7891), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7891), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7895), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7900), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7904), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7908), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7908), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7913), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7917), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7917), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7921), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(7921), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(8452), new DateTime(2023, 10, 20, 11, 38, 52, 424, DateTimeKind.Local).AddTicks(8453), 1, false, false, 1, 2 });

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
