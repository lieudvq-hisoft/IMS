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
                name: "Services",
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
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_AspNetUsers_UserId1",
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
                name: "Locations",
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
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Racks_RackId",
                        column: x => x.RackId,
                        principalTable: "Racks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
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
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
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
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    IsDelegated = table.Column<bool>(type: "boolean", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
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
                    RequestId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_ComponentAssignments_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
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
                    RequestId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_IpAssignments_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestId = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationAssignments_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationAssignments_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
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
                    { new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"), 0, "Address5", "ff79a03f-b234-4b58-90d6-3644e14a07f9", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAELqk7fNQwQnP5bq4hVDL2KpQkaB34plK0e1N2JaR8HVOR1DNrs4+gUTF8tn1J+x1XA==", "0000000005", false, "", false, "admin" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "7b827341-b700-4f71-883d-47ced985a36e", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEEOVeuDGcJVVfBdehYuhNX5xLDE07n4c7em0POv+AUxbYImqpfznrhaQJgJbc5Jt6Q==", "0000000003", false, "", false, "sale" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "ac8e8cc8-1469-4874-a90c-e403e7bff659", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEIK6kWl8G5/Zqt+BcP4I9fRKsTW65ex1lThoiScc6aJBHCUfoQndaynvVBzuHgcVXw==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "dc443707-cd25-402f-b2d0-bccc54abf8ed", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEBu/X6rJuXXeDoDdw8F7/mMkobFzaYg5ODIEHLoEyqo6AEUJbAXHLJwkfg9Bu7Qn5A==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "c2fbe3c0-d3a4-48ba-9097-60aabcf5a0f3", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEGoyLqcLgpttRXhrr4S6dLVL5XDOCI54cfeZBIC2h0xmBXnH/o0rJOvHlVeDWclGFA==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6623), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6633), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6745), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6746), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6764), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6821), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6837), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "ComponentCategories",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6856), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6863), null, false, "CPU" },
                    { 2, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6885), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6885), null, false, "GPU" },
                    { 3, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6895), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6896), null, false, "RAM" },
                    { 4, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6905), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6905), null, false, "OS" },
                    { 5, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6915), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6915), null, false, "ROM" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6934), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6934), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6949), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6950), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "Name", "Type", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7346), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7358), false, "Location", 0, null, null },
                    { 2, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7395), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7396), false, "Expand", 1, null, null },
                    { 3, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7403), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7404), false, "Ip", 2, null, null },
                    { 4, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7411), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7411), false, "MasterIp", 3, null, null },
                    { 5, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7420), false, "Port", 4, null, null },
                    { 6, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7427), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7428), false, "PortPower", 5, null, null },
                    { 7, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7435), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7435), false, "Power", 6, null, null },
                    { 8, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7445), false, "Component", 7, null, null },
                    { 9, new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7455), new DateTime(2023, 11, 10, 22, 41, 39, 233, DateTimeKind.Local).AddTicks(7455), false, "Appointment", 8, null, null }
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
                    { 1, 1, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6966), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6966), false, false, 2 },
                    { 2, 2, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6984), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6984), false, false, 1 },
                    { 3, 3, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6994), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(6994), false, false, 2 },
                    { 4, 4, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7003), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7003), false, false, 1 },
                    { 5, 5, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7012), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7012), false, false, 2 },
                    { 6, 6, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7040), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7040), false, false, 1 },
                    { 7, 7, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7050), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7050), false, false, 2 },
                    { 8, 8, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7059), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7060), false, false, 1 },
                    { 9, 9, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7068), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7069), false, false, 2 },
                    { 10, 10, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7078), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7079), false, false, 1 },
                    { 11, 11, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7087), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7088), false, false, 2 },
                    { 12, 12, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7096), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7097), false, false, 1 },
                    { 13, 13, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7105), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7106), false, false, 2 },
                    { 14, 14, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7114), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7115), false, false, 1 },
                    { 15, 15, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7124), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7124), false, false, 2 },
                    { 16, 16, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7133), false, false, 1 },
                    { 17, 17, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7173), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7173), false, false, 2 },
                    { 18, 18, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7185), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7185), false, false, 1 },
                    { 19, 19, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7194), false, false, 2 },
                    { 20, 20, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7203), false, false, 1 },
                    { 21, 21, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7211), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7211), false, false, 2 },
                    { 22, 22, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7220), false, false, 1 },
                    { 23, 23, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7228), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7228), false, false, 2 },
                    { 24, 24, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7237), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7238), false, false, 1 },
                    { 25, 25, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7246), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7246), false, false, 2 },
                    { 26, 26, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7255), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7255), false, false, 1 },
                    { 27, 27, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7264), false, false, 2 },
                    { 28, 28, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7272), false, false, 1 },
                    { 29, 29, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7281), false, false, 2 },
                    { 30, 30, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7289), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7289), false, false, 1 },
                    { 31, 31, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7298), false, false, 2 },
                    { 32, 32, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7307), false, false, 1 },
                    { 33, 33, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7315), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7315), false, false, 2 },
                    { 34, 34, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7325), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7325), false, false, 1 },
                    { 35, 35, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7334), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7334), false, false, 2 },
                    { 36, 36, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7343), false, false, 1 },
                    { 37, 37, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7352), false, false, 2 },
                    { 38, 38, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7360), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7360), false, false, 1 },
                    { 39, 39, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7369), false, false, 2 },
                    { 40, 40, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7377), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7378), false, false, 1 },
                    { 41, 41, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7386), false, false, 2 },
                    { 42, 42, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7452), false, false, 1 },
                    { 43, 43, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7464), false, false, 2 },
                    { 44, 44, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7473), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7474), false, false, 1 },
                    { 45, 45, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7483), false, false, 2 },
                    { 46, 46, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7491), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7491), false, false, 1 },
                    { 47, 47, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7500), false, false, 2 },
                    { 48, 48, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7509), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7509), false, false, 1 },
                    { 49, 49, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7518), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7518), false, false, 2 },
                    { 50, 50, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7527), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7527), false, false, 1 },
                    { 51, 51, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7536), false, false, 2 },
                    { 52, 52, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7545), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7545), false, false, 1 },
                    { 53, 53, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7553), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7554), false, false, 2 },
                    { 54, 54, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7562), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7562), false, false, 1 },
                    { 55, 55, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7571), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7571), false, false, 2 },
                    { 56, 56, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7579), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7580), false, false, 1 },
                    { 57, 57, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7588), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7588), false, false, 2 },
                    { 58, 58, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7596), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7597), false, false, 1 },
                    { 59, 59, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7606), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7606), false, false, 2 },
                    { 60, 60, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7615), false, false, 1 },
                    { 61, 61, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7623), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7624), false, false, 2 },
                    { 62, 62, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7632), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7633), false, false, 1 },
                    { 63, 63, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7641), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7641), false, false, 2 },
                    { 64, 64, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7650), false, false, 1 },
                    { 65, 65, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7658), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7659), false, false, 2 },
                    { 66, 66, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7699), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7700), false, false, 1 },
                    { 67, 67, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7710), false, false, 2 },
                    { 68, 68, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7718), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7719), false, false, 1 },
                    { 69, 69, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7728), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7728), false, false, 2 },
                    { 70, 70, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7737), false, false, 1 },
                    { 71, 71, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7746), false, false, 2 },
                    { 72, 72, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7755), false, false, 1 },
                    { 73, 73, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7764), false, false, 2 },
                    { 74, 74, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7773), false, false, 1 },
                    { 75, 75, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7782), false, false, 2 },
                    { 76, 76, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7790), false, false, 1 },
                    { 77, 77, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7798), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7799), false, false, 2 },
                    { 78, 78, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7807), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7808), false, false, 1 },
                    { 79, 79, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7817), false, false, 2 },
                    { 80, 80, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7825), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7825), false, false, 1 },
                    { 81, 81, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7833), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7834), false, false, 2 },
                    { 82, 82, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7842), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7843), false, false, 1 },
                    { 83, 83, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7851), false, false, 2 },
                    { 84, 84, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7860), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7860), false, false, 1 },
                    { 85, 85, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7869), false, false, 2 },
                    { 86, 86, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7877), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7877), false, false, 1 },
                    { 87, 87, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7886), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7886), false, false, 2 },
                    { 88, 88, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7894), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7895), false, false, 1 },
                    { 89, 89, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7903), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7903), false, false, 2 },
                    { 90, 90, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7912), false, false, 1 },
                    { 91, 91, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7921), false, false, 2 },
                    { 92, 92, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7929), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7929), false, false, 1 },
                    { 93, 93, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7938), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7938), false, false, 2 },
                    { 94, 94, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7981), false, false, 1 },
                    { 95, 95, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(7992), false, false, 2 },
                    { 96, 96, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8001), false, false, 1 },
                    { 97, 97, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8009), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8010), false, false, 2 },
                    { 98, 98, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8019), false, false, 1 },
                    { 99, 99, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8028), false, false, 2 },
                    { 100, 100, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8036), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8036), false, false, 1 },
                    { 101, 101, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8045), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8046), false, false, 2 },
                    { 102, 102, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8057), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8058), false, false, 1 },
                    { 103, 103, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8067), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8067), false, false, 2 },
                    { 104, 104, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8076), false, false, 1 },
                    { 105, 105, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8085), false, false, 2 },
                    { 106, 106, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8093), false, false, 1 },
                    { 107, 107, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8102), false, false, 2 },
                    { 108, 108, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8110), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8111), false, false, 1 },
                    { 109, 109, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8119), false, false, 2 },
                    { 110, 110, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8128), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8128), false, false, 1 },
                    { 111, 111, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8136), false, false, 2 },
                    { 112, 112, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8145), false, false, 1 },
                    { 113, 113, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8154), false, false, 2 },
                    { 114, 114, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8162), false, false, 1 },
                    { 115, 115, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8171), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8171), false, false, 2 },
                    { 116, 116, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8179), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8180), false, false, 1 },
                    { 117, 117, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8188), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8189), false, false, 2 },
                    { 118, 118, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8197), false, false, 1 },
                    { 119, 119, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8206), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8206), false, false, 2 },
                    { 120, 120, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8215), false, false, 1 },
                    { 121, 121, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8256), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8257), false, false, 2 },
                    { 122, 122, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8267), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8267), false, false, 1 },
                    { 123, 123, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8276), false, false, 2 },
                    { 124, 124, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8284), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8285), false, false, 1 },
                    { 125, 125, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8293), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8293), false, false, 2 },
                    { 126, 126, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8302), false, false, 1 },
                    { 127, 127, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8310), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8310), false, false, 2 },
                    { 128, 128, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8320), false, false, 1 },
                    { 129, 129, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8329), false, false, 2 },
                    { 130, 130, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8339), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8339), false, false, 1 },
                    { 131, 131, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8349), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8349), false, false, 2 },
                    { 132, 132, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8358), false, false, 1 },
                    { 133, 133, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8367), false, false, 2 },
                    { 134, 134, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8376), false, false, 1 },
                    { 135, 135, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8384), false, false, 2 },
                    { 136, 136, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8394), false, false, 1 },
                    { 137, 137, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8402), false, false, 2 },
                    { 138, 138, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8411), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8411), false, false, 1 },
                    { 139, 139, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8419), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8420), false, false, 2 },
                    { 140, 140, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8428), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8428), false, false, 1 },
                    { 141, 141, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8436), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8437), false, false, 2 },
                    { 142, 142, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8477), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8477), false, false, 1 },
                    { 143, 143, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8488), false, false, 2 },
                    { 144, 144, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8497), false, false, 1 },
                    { 145, 145, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8506), false, false, 2 },
                    { 146, 146, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8515), false, false, 1 },
                    { 147, 147, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8523), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8524), false, false, 2 },
                    { 148, 148, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8532), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8532), false, false, 1 },
                    { 149, 149, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8541), false, false, 2 },
                    { 150, 150, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8550), false, false, 1 },
                    { 151, 151, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8558), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8558), false, false, 2 },
                    { 152, 152, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8567), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8567), false, false, 1 },
                    { 153, 153, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8575), false, false, 2 },
                    { 154, 154, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8677), false, false, 1 },
                    { 155, 155, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8687), false, false, 2 },
                    { 156, 156, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8696), false, false, 1 },
                    { 157, 157, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8705), false, false, 2 },
                    { 158, 158, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8714), false, false, 1 },
                    { 159, 159, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8722), false, false, 2 },
                    { 160, 160, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8731), false, false, 1 },
                    { 161, 161, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8740), false, false, 2 },
                    { 162, 162, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8748), false, false, 1 },
                    { 163, 163, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8757), false, false, 2 },
                    { 164, 164, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8765), false, false, 1 },
                    { 165, 165, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8774), false, false, 2 },
                    { 166, 166, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8783), false, false, 1 },
                    { 167, 167, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8791), false, false, 2 },
                    { 168, 168, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8800), false, false, 1 },
                    { 169, 169, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8809), false, false, 2 },
                    { 170, 170, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8855), false, false, 1 },
                    { 171, 171, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8865), false, false, 2 },
                    { 172, 172, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8874), false, false, 1 },
                    { 173, 173, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8882), false, false, 2 },
                    { 174, 174, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8891), false, false, 1 },
                    { 175, 175, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8900), false, false, 2 },
                    { 176, 176, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8909), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8909), false, false, 1 },
                    { 177, 177, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8918), false, false, 2 },
                    { 178, 178, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8927), false, false, 1 },
                    { 179, 179, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8935), false, false, 2 },
                    { 180, 180, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8944), false, false, 1 },
                    { 181, 181, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8952), false, false, 2 },
                    { 182, 182, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8961), false, false, 1 },
                    { 183, 183, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8970), false, false, 2 },
                    { 184, 184, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8978), false, false, 1 },
                    { 185, 185, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8987), false, false, 2 },
                    { 186, 186, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8995), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(8996), false, false, 1 },
                    { 187, 187, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9004), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9005), false, false, 2 },
                    { 188, 188, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9013), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9013), false, false, 1 },
                    { 189, 189, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9022), false, false, 2 },
                    { 190, 190, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9031), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9031), false, false, 1 },
                    { 191, 191, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9040), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9040), false, false, 2 },
                    { 192, 192, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9049), false, false, 1 },
                    { 193, 193, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9057), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9057), false, false, 2 },
                    { 194, 194, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9066), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9066), false, false, 1 },
                    { 195, 195, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9074), false, false, 2 },
                    { 196, 196, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9083), false, false, 1 },
                    { 197, 197, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9122), false, false, 2 },
                    { 198, 198, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9131), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9132), false, false, 1 },
                    { 199, 199, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9141), false, false, 2 },
                    { 200, 200, false, new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9149), new DateTime(2023, 11, 10, 22, 41, 38, 731, DateTimeKind.Local).AddTicks(9150), false, false, 1 }
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
                name: "IX_ComponentAssignments_RequestId",
                table: "ComponentAssignments",
                column: "RequestId");

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
                name: "IX_IpAssignments_RequestId",
                table: "IpAssignments",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Ips_NetworkId",
                table: "Ips",
                column: "NetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationAssignments_LocationId",
                table: "LocationAssignments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationAssignments_RequestId",
                table: "LocationAssignments",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_RackId",
                table: "Locations",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Racks_AreaId",
                table: "Racks",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_OrderId",
                table: "Requests",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceId",
                table: "Requests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_UserId",
                table: "Services",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_UserId1",
                table: "Services",
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
                name: "LocationAssignments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ComponentCategories");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Services");

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
