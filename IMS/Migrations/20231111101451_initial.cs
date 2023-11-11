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
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Unit = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IpSubnet",
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
                    table.PrimaryKey("PK_IpSubnet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpSubnet_IpSubnet_ParentNetworkId",
                        column: x => x.ParentNetworkId,
                        principalTable: "IpSubnet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IsDeletable = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Service_AspNetUsers_UserId1",
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
                name: "IpAddress",
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
                    table.PrimaryKey("PK_IpAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpAddress_IpSubnet_IpSubnetId",
                        column: x => x.IpSubnetId,
                        principalTable: "IpSubnet",
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
                name: "ServerAllocations",
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
                    table.PrimaryKey("PK_ServerAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerAllocations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    IsDelegated = table.Column<bool>(type: "boolean", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_ServerAllocations_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Request_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IpAssignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateAssign = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUnassign = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    IpAddressId = table.Column<int>(type: "integer", nullable: false),
                    RequestId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IpAssignment_IpAddress_IpAddressId",
                        column: x => x.IpAddressId,
                        principalTable: "IpAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IpAssignment_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationAssignment",
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
                    table.PrimaryKey("PK_LocationAssignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationAssignment_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationAssignment_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServerHardwareConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "text", nullable: false),
                    SerialNumber = table.Column<string>(type: "text", nullable: false),
                    DateInstalled = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RequestId = table.Column<int>(type: "integer", nullable: false),
                    ComponentId = table.Column<int>(type: "integer", nullable: false),
                    ServerAllocationId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerHardwareConfigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerHardwareConfigs_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerHardwareConfigs_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerHardwareConfigs_ServerAllocations_ServerAllocationId",
                        column: x => x.ServerAllocationId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id");
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
                    { new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"), 0, "Address5", "c3f465fe-8cd3-44b8-bcf8-6f43743520d1", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEJ+K2LN+ZVFKeuksA/QjkAc4lyq7VtAcJoH6wbdpLSSkmA+rMUhPBoEczWkhZYm3Kg==", "0000000005", false, "", false, "admin" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "551c06e5-72a0-4028-b341-df2deb5e6e1c", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEKkCRdTQOL2PeCOU17bv1evfzpPlOHuoEyp8VXRP1ioq7/GxzSnx3EpcytAyDhvEkg==", "0000000003", false, "", false, "sale" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "f1550bed-c703-424f-943a-f914cd48fe46", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEJNiwB7GjE2y+BZb9CTddy7655Xf9JGHtvIdmLPm9PvKdrb2mVXVUhkAGlgH/P6BKw==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "d1d8da09-6004-4bb1-b8ac-5f4fd5df67de", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEC1IrBxoOBLC+eXrVOSEaG6dLcOMgAM0vsBG81msppTyIYd25Vk9UD99ZrI7L8/tFQ==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "ed80b33c-0eae-4008-bb78-fbab0120f7e9", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEGDbjeyENM+nVyxvcand0TFazXisy8fscGSNchS7IiWUjYAcEE925p0mafnlW2nAfg==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(473), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(485), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(509), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(520), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(529), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(529), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(538), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Unit" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(552), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(553), null, false, "CPU", "Cái" },
                    { 2, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(564), null, false, "GPU", "Cái" },
                    { 3, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(613), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(613), null, false, "RAM", "Gb" },
                    { 4, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(626), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(626), null, false, "OS", "Cái" },
                    { 5, new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(635), new DateTime(2023, 11, 11, 17, 14, 50, 747, DateTimeKind.Local).AddTicks(636), null, false, "ROM", "Cái" }
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
                name: "IX_IpAddress_IpSubnetId",
                table: "IpAddress",
                column: "IpSubnetId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignment_IpAddressId",
                table: "IpAssignment",
                column: "IpAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignment_RequestId",
                table: "IpAssignment",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_IpSubnet_ParentNetworkId",
                table: "IpSubnet",
                column: "ParentNetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_RackId",
                table: "Location",
                column: "RackId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationAssignment_LocationId",
                table: "LocationAssignment",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationAssignment_RequestId",
                table: "LocationAssignment",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Rack_AreaId",
                table: "Rack",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_OrderId",
                table: "Request",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ServiceId",
                table: "Request",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAllocations_CustomerId",
                table: "ServerAllocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerHardwareConfigs_ComponentId",
                table: "ServerHardwareConfigs",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerHardwareConfigs_RequestId",
                table: "ServerHardwareConfigs",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerHardwareConfigs_ServerAllocationId",
                table: "ServerHardwareConfigs",
                column: "ServerAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_UserId",
                table: "Service",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_UserId1",
                table: "Service",
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
                name: "IpAssignment");

            migrationBuilder.DropTable(
                name: "LocationAssignment");

            migrationBuilder.DropTable(
                name: "ServerHardwareConfigs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "IpAddress");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "IpSubnet");

            migrationBuilder.DropTable(
                name: "Rack");

            migrationBuilder.DropTable(
                name: "ServerAllocations");

            migrationBuilder.DropTable(
                name: "Service");

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
