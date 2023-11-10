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
                name: "Area",
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
                    table.PrimaryKey("PK_Area", x => x.Id);
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
                name: "ComponentCategories",
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
                    table.PrimaryKey("PK_ComponentCategories", x => x.Id);
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
                name: "Rack",
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
                    table.PrimaryKey("PK_Rack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rack_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
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
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceTypes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceTypes_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    RackId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Rack_RackId",
                        column: x => x.RackId,
                        principalTable: "Rack",
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
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    IsDelegated = table.Column<bool>(type: "boolean", nullable: false),
                    RequestId = table.Column<int>(type: "integer", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComponentAssignments",
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
                    table.PrimaryKey("PK_ComponentAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentAssignments_ComponentCategories_HardwareCategoryId",
                        column: x => x.HardwareCategoryId,
                        principalTable: "ComponentCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComponentAssignments_Services_ServiceId",
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
                name: "LocationAssignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationAssignment_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationAssignment_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"), 0, "Address5", "d0c9f4c5-c2e8-4de8-8a3f-070440eb5718", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEJTQgWdY8AoYgeDv8Yzi/kDqzgXt/KeRw359VxSufujB1mhIHchNEePLl2ilv88NUA==", "0000000005", false, "", false, "admin" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "812b3961-505f-4237-8073-543d7cc62150", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAECqWMLkH9Yj45B761xGeKrz4hqv8Elw4BpxEyQ4OPSeapahhy3OM2WWmoS0sKRzQ+g==", "0000000003", false, "", false, "sale" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "a91807fc-38c5-44fc-b4fe-22ce4f2ecac4", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAENdCKYGEmZ/MakbaVygceroB0F/xACzTZhwOOZN7sqd8xCsPF7jybeQ+21FbhTCQ1g==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "34387b91-1502-4759-a895-ecc66d8fa719", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEBuJLp79AN+mVlEiZVviLI60ZSg+iiKBzmK3olVbhEQDBXEt7YDzkpkhWNx3B4yjPg==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "c9c60fd4-df52-451c-8f96-13e97c185cc8", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAENk854j7L2eK7vnH447NWGCFgGNyZCqhkpdIGhtsSkOoH50sGMYhrDvqxsEKjR5GxA==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4360), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4436), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4446), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4447), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4456), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4456), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4469), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4469), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "ComponentCategories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4499), null, false, "CPU" },
                    { 2, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4523), null, false, "GPU" },
                    { 3, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4532), null, false, "RAM" },
                    { 4, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4541), null, false, "OS" },
                    { 5, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4549), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4549), null, false, "ROM" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4565), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4579), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Name", "Type", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3712), false, "Location", 0, null, null },
                    { 2, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3751), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3752), false, "Expand", 1, null, null },
                    { 3, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3758), false, "Ip", 2, null, null },
                    { 4, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3763), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3763), false, "MasterIp", 3, null, null },
                    { 5, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3768), false, "Port", 4, null, null },
                    { 6, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3775), false, "PortPower", 5, null, null },
                    { 7, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3780), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3780), false, "Power", 6, null, null },
                    { 8, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3785), false, "Component", 7, null, null },
                    { 9, new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3789), new DateTime(2023, 11, 10, 20, 24, 2, 581, DateTimeKind.Local).AddTicks(3790), false, "Appointment", 8, null, null }
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
                    { 1, 1, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4594), false, false, 2 },
                    { 2, 2, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4604), false, false, 1 },
                    { 3, 3, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4612), false, false, 2 },
                    { 4, 4, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4639), false, false, 1 },
                    { 5, 5, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4647), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4647), false, false, 2 },
                    { 6, 6, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4656), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4657), false, false, 1 },
                    { 7, 7, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4664), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4665), false, false, 2 },
                    { 8, 8, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4673), false, false, 1 },
                    { 9, 9, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4680), false, false, 2 },
                    { 10, 10, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4731), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4731), false, false, 1 },
                    { 11, 11, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4740), false, false, 2 },
                    { 12, 12, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4748), false, false, 1 },
                    { 13, 13, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4756), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4756), false, false, 2 },
                    { 14, 14, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4764), false, false, 1 },
                    { 15, 15, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4772), false, false, 2 },
                    { 16, 16, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4780), false, false, 1 },
                    { 17, 17, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4788), false, false, 2 },
                    { 18, 18, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4797), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4797), false, false, 1 },
                    { 19, 19, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4804), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4805), false, false, 2 },
                    { 20, 20, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4812), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4812), false, false, 1 },
                    { 21, 21, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4820), false, false, 2 },
                    { 22, 22, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4828), false, false, 1 },
                    { 23, 23, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4835), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4835), false, false, 2 },
                    { 24, 24, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4842), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4843), false, false, 1 },
                    { 25, 25, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4851), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4851), false, false, 2 },
                    { 26, 26, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4859), false, false, 1 },
                    { 27, 27, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4866), false, false, 2 },
                    { 28, 28, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4874), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4875), false, false, 1 },
                    { 29, 29, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4882), false, false, 2 },
                    { 30, 30, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4890), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4890), false, false, 1 },
                    { 31, 31, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4897), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4898), false, false, 2 },
                    { 32, 32, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4906), false, false, 1 },
                    { 33, 33, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4914), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4914), false, false, 2 },
                    { 34, 34, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4957), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4958), false, false, 1 },
                    { 35, 35, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4967), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4967), false, false, 2 },
                    { 36, 36, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4974), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4975), false, false, 1 },
                    { 37, 37, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4982), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4983), false, false, 2 },
                    { 38, 38, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4990), false, false, 1 },
                    { 39, 39, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(4998), false, false, 2 },
                    { 40, 40, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5006), false, false, 1 },
                    { 41, 41, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5013), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5014), false, false, 2 },
                    { 42, 42, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5022), false, false, 1 },
                    { 43, 43, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5030), false, false, 2 },
                    { 44, 44, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5037), false, false, 1 },
                    { 45, 45, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5045), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5045), false, false, 2 },
                    { 46, 46, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5052), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5053), false, false, 1 },
                    { 47, 47, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5060), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5060), false, false, 2 },
                    { 48, 48, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5068), false, false, 1 },
                    { 49, 49, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5076), false, false, 2 },
                    { 50, 50, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5084), false, false, 1 },
                    { 51, 51, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5092), false, false, 2 },
                    { 52, 52, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5099), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5099), false, false, 1 },
                    { 53, 53, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5107), false, false, 2 },
                    { 54, 54, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5115), false, false, 1 },
                    { 55, 55, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5122), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5123), false, false, 2 },
                    { 56, 56, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5131), false, false, 1 },
                    { 57, 57, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5139), false, false, 2 },
                    { 58, 58, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5147), false, false, 1 },
                    { 59, 59, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5155), false, false, 2 },
                    { 60, 60, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5162), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5162), false, false, 1 },
                    { 61, 61, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5170), false, false, 2 },
                    { 62, 62, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5211), false, false, 1 },
                    { 63, 63, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5219), false, false, 2 },
                    { 64, 64, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5226), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5227), false, false, 1 },
                    { 65, 65, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5235), false, false, 2 },
                    { 66, 66, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5244), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5244), false, false, 1 },
                    { 67, 67, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5252), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5252), false, false, 2 },
                    { 68, 68, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5260), false, false, 1 },
                    { 69, 69, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5268), false, false, 2 },
                    { 70, 70, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5276), false, false, 1 },
                    { 71, 71, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5284), false, false, 2 },
                    { 72, 72, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5291), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5291), false, false, 1 },
                    { 73, 73, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5299), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5299), false, false, 2 },
                    { 74, 74, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5306), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5307), false, false, 1 },
                    { 75, 75, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5314), false, false, 2 },
                    { 76, 76, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5322), false, false, 1 },
                    { 77, 77, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5330), false, false, 2 },
                    { 78, 78, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5338), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5338), false, false, 1 },
                    { 79, 79, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5346), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5346), false, false, 2 },
                    { 80, 80, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5354), false, false, 1 },
                    { 81, 81, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5362), false, false, 2 },
                    { 82, 82, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5369), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5369), false, false, 1 },
                    { 83, 83, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5377), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5377), false, false, 2 },
                    { 84, 84, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5385), false, false, 1 },
                    { 85, 85, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5393), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5393), false, false, 2 },
                    { 86, 86, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5435), false, false, 1 },
                    { 87, 87, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5443), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5443), false, false, 2 },
                    { 88, 88, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5451), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5451), false, false, 1 },
                    { 89, 89, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5458), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5459), false, false, 2 },
                    { 90, 90, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5466), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5467), false, false, 1 },
                    { 91, 91, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5474), false, false, 2 },
                    { 92, 92, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5482), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5482), false, false, 1 },
                    { 93, 93, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5489), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5490), false, false, 2 },
                    { 94, 94, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5497), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5497), false, false, 1 },
                    { 95, 95, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5505), false, false, 2 },
                    { 96, 96, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5513), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5513), false, false, 1 },
                    { 97, 97, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5520), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5521), false, false, 2 },
                    { 98, 98, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5528), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5528), false, false, 1 },
                    { 99, 99, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5536), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5537), false, false, 2 },
                    { 100, 100, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5544), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5545), false, false, 1 },
                    { 101, 101, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5552), false, false, 2 },
                    { 102, 102, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5560), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5560), false, false, 1 },
                    { 103, 103, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5568), false, false, 2 },
                    { 104, 104, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5575), false, false, 1 },
                    { 105, 105, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5583), false, false, 2 },
                    { 106, 106, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5591), false, false, 1 },
                    { 107, 107, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5599), false, false, 2 },
                    { 108, 108, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5606), false, false, 1 },
                    { 109, 109, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5614), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5614), false, false, 2 },
                    { 110, 110, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5622), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5622), false, false, 1 },
                    { 111, 111, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5630), false, false, 2 },
                    { 112, 112, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5637), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5637), false, false, 1 },
                    { 113, 113, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5676), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5676), false, false, 2 },
                    { 114, 114, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5686), false, false, 1 },
                    { 115, 115, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5693), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5694), false, false, 2 },
                    { 116, 116, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5701), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5702), false, false, 1 },
                    { 117, 117, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5710), false, false, 2 },
                    { 118, 118, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5717), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5718), false, false, 1 },
                    { 119, 119, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5726), false, false, 2 },
                    { 120, 120, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5733), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5733), false, false, 1 },
                    { 121, 121, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5741), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5741), false, false, 2 },
                    { 122, 122, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5749), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5749), false, false, 1 },
                    { 123, 123, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5757), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5757), false, false, 2 },
                    { 124, 124, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5765), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5765), false, false, 1 },
                    { 125, 125, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5773), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5773), false, false, 2 },
                    { 126, 126, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5781), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5782), false, false, 1 },
                    { 127, 127, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5789), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5789), false, false, 2 },
                    { 128, 128, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5797), false, false, 1 },
                    { 129, 129, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5804), false, false, 2 },
                    { 130, 130, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5814), false, false, 1 },
                    { 131, 131, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5822), false, false, 2 },
                    { 132, 132, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5829), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5829), false, false, 1 },
                    { 133, 133, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5838), false, false, 2 },
                    { 134, 134, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5878), false, false, 1 },
                    { 135, 135, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5886), false, false, 2 },
                    { 136, 136, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5894), false, false, 1 },
                    { 137, 137, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5902), false, false, 2 },
                    { 138, 138, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5910), false, false, 1 },
                    { 139, 139, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5918), false, false, 2 },
                    { 140, 140, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5926), false, false, 1 },
                    { 141, 141, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5934), false, false, 2 },
                    { 142, 142, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5942), false, false, 1 },
                    { 143, 143, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5949), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5950), false, false, 2 },
                    { 144, 144, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5957), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5957), false, false, 1 },
                    { 145, 145, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5965), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5965), false, false, 2 },
                    { 146, 146, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5973), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5973), false, false, 1 },
                    { 147, 147, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5980), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5981), false, false, 2 },
                    { 148, 148, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5988), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5989), false, false, 1 },
                    { 149, 149, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5996), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(5996), false, false, 2 },
                    { 150, 150, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6004), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6004), false, false, 1 },
                    { 151, 151, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6013), false, false, 2 },
                    { 152, 152, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6020), false, false, 1 },
                    { 153, 153, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6027), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6028), false, false, 2 },
                    { 154, 154, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6035), false, false, 1 },
                    { 155, 155, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6043), false, false, 2 },
                    { 156, 156, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6051), false, false, 1 },
                    { 157, 157, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6059), false, false, 2 },
                    { 158, 158, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6067), false, false, 1 },
                    { 159, 159, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6075), false, false, 2 },
                    { 160, 160, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6083), false, false, 1 },
                    { 161, 161, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6147), false, false, 2 },
                    { 162, 162, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6157), false, false, 1 },
                    { 163, 163, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6165), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6165), false, false, 2 },
                    { 164, 164, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6173), false, false, 1 },
                    { 165, 165, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6181), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6181), false, false, 2 },
                    { 166, 166, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6189), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6189), false, false, 1 },
                    { 167, 167, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6197), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6197), false, false, 2 },
                    { 168, 168, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6205), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6205), false, false, 1 },
                    { 169, 169, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6213), false, false, 2 },
                    { 170, 170, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6222), false, false, 1 },
                    { 171, 171, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6229), false, false, 2 },
                    { 172, 172, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6238), false, false, 1 },
                    { 173, 173, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6246), false, false, 2 },
                    { 174, 174, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6254), false, false, 1 },
                    { 175, 175, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6262), false, false, 2 },
                    { 176, 176, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6270), false, false, 1 },
                    { 177, 177, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6278), false, false, 2 },
                    { 178, 178, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6285), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6286), false, false, 1 },
                    { 179, 179, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6294), false, false, 2 },
                    { 180, 180, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6302), false, false, 1 },
                    { 181, 181, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6310), false, false, 2 },
                    { 182, 182, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6317), false, false, 1 },
                    { 183, 183, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6325), false, false, 2 },
                    { 184, 184, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6333), false, false, 1 },
                    { 185, 185, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6341), false, false, 2 },
                    { 186, 186, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6349), false, false, 1 },
                    { 187, 187, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6357), false, false, 2 },
                    { 188, 188, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6366), false, false, 1 },
                    { 189, 189, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6405), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6406), false, false, 2 },
                    { 190, 190, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6414), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6415), false, false, 1 },
                    { 191, 191, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6422), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6422), false, false, 2 },
                    { 192, 192, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6430), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6430), false, false, 1 },
                    { 193, 193, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6438), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6438), false, false, 2 },
                    { 194, 194, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6446), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6446), false, false, 1 },
                    { 195, 195, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6454), false, false, 2 },
                    { 196, 196, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6461), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6462), false, false, 1 },
                    { 197, 197, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6469), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6470), false, false, 2 },
                    { 198, 198, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6477), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6478), false, false, 1 },
                    { 199, 199, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6485), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6486), false, false, 2 },
                    { 200, 200, false, new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6493), new DateTime(2023, 11, 10, 20, 24, 2, 219, DateTimeKind.Local).AddTicks(6494), false, false, 1 }
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
                name: "IX_ComponentAssignments_HardwareCategoryId",
                table: "ComponentAssignments",
                column: "HardwareCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentAssignments_ServiceId",
                table: "ComponentAssignments",
                column: "ServiceId");

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
                name: "IX_Location_RackId",
                table: "Location",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationAssignment_LocationId",
                table: "LocationAssignment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationAssignment_ServiceId",
                table: "LocationAssignment",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rack_AreaId",
                table: "Rack",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_RequestId",
                table: "Services",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeId",
                table: "Services",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_UserId",
                table: "ServiceTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_UserId1",
                table: "ServiceTypes",
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
                name: "ComponentAssignments");

            migrationBuilder.DropTable(
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "LocationAssignment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ComponentCategories");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Rack");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
