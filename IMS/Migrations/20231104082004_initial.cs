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
                    Size = table.Column<int>(type: "integer", nullable: false),
                    AdditionalSize = table.Column<int>(type: "integer", nullable: false),
                    BasePower = table.Column<int>(type: "integer", nullable: false),
                    AdditionalPower = table.Column<int>(type: "integer", nullable: false),
                    DeviceStatus = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
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
                name: "SaleApprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SaleId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleApprovals_AspNetUsers_SaleId",
                        column: x => x.SaleId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechExecutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TechId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechExecutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechExecutions_AspNetUsers_TechId",
                        column: x => x.TechId,
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
                    NumberOfPort = table.Column<int>(type: "integer", nullable: false),
                    AdditionalNumberOfPort = table.Column<int>(type: "integer", nullable: false),
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
                name: "Ips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<int>(type: "integer", nullable: false),
                    Blocked = table.Column<bool>(type: "boolean", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
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
                    StartPosition = table.Column<int>(type: "integer", nullable: false),
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
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ExpectedSize = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    InspectorNote = table.Column<string>(type: "text", nullable: true),
                    DateAllocate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InitialDateStop = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateStop = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    ReceiptOfRecipientFilePath = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ServerId = table.Column<int>(type: "integer", nullable: true),
                    TechExecutionId = table.Column<int>(type: "integer", nullable: true),
                    SaleApprovalId = table.Column<int>(type: "integer", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Requests_SaleApprovals_SaleApprovalId",
                        column: x => x.SaleApprovalId,
                        principalTable: "SaleApprovals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_TechExecutions_TechExecutionId",
                        column: x => x.TechExecutionId,
                        principalTable: "TechExecutions",
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
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ServerId = table.Column<int>(type: "integer", nullable: false),
                    IpId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_IpAssignments_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestExtendHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Time = table.Column<int>(type: "integer", nullable: false),
                    DateExtended = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ProposedDateStop = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsAccepted = table.Column<bool>(type: "boolean", nullable: false),
                    RequestId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExtendHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestExtendHistories_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
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
                    SaleApprovalId = table.Column<int>(type: "integer", nullable: true),
                    TechExecutionId = table.Column<int>(type: "integer", nullable: true),
                    IpId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_ServiceRequests_Ips_IpId",
                        column: x => x.IpId,
                        principalTable: "Ips",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_SaleApprovals_SaleApprovalId",
                        column: x => x.SaleApprovalId,
                        principalTable: "SaleApprovals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_TechExecutions_TechExecutionId",
                        column: x => x.TechExecutionId,
                        principalTable: "TechExecutions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "ColumnCount", "DateCreated", "DateUpdated", "IsDeleted", "Name", "RowCount" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9709), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9716), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9717), false, "B", 5 }
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
                    { new Guid("1197da45-ce58-4ff2-ba58-40f8d3845c6a"), 0, "Et/Feugiat, Ultrices pretium augue", "f66bd1f1-6f79-4659-be5e-1ae50fb264ea", 0, "taciti@vivamus.com", true, "Sollicitudin neque at", false, false, null, "sem@accumsan.com", "customer17", "AQAAAAIAAYagAAAAEFr172YZcmBrL8nN3VLWeB1GcKRUZhKAHEemHrt/6lnsB6iUygj7MIN95gfH1P7qsg==", "5649397992", false, "", false, "customer17" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "7358415d-e706-4140-98c0-874a6a5b859a", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEMDMEYS9v80BShcDcB0zqZDSSROOttcng1WzaJ1Uz9XfmJXuXoPVRlZJY2ty39k0AQ==", "0000000003", false, "", false, "sale" },
                    { new Guid("1bc26a0e-45ba-4bf5-9810-fcb2f25da191"), 0, "Consequat/Nunc, Tristique placerat quis", "5ef15a21-bb8a-47d3-9f4d-88d7327306da", 0, "mi@velit.com", true, "Neque tortor quam", false, false, null, "fermentum@malesuada.com", "customer19", "AQAAAAIAAYagAAAAEA80+Zl+xoBfU5CIvP/6kpra37UAKnEBJgIm+ErW9PmEukT+rexjLlF1RvJK0xDY8w==", "8766315323", false, "", false, "customer19" },
                    { new Guid("21305bcd-5f6a-470b-8fab-668d9e6ca24d"), 0, "Dignissim/Platea, Maecenas integer euismod", "c600a979-fc96-4f93-b33e-dc965646bf07", 0, "vestibulum@non.com", true, "Consectetur pretium primis", false, false, null, "euismod@non.com", "customer8", "AQAAAAIAAYagAAAAEH6CyKa30bQIowv0DVd8iSB/NDeJKY3poyY7LO3C6rIibGWzH96m8dGDwiaNnQhq0g==", "5269225981", false, "", false, "customer8" },
                    { new Guid("2351f408-f58a-493d-9e37-4385fae6abe5"), 0, "Porttitor/Luctus, Interdum quis mattis", "d8cda73f-67df-45b0-bfcb-35335845dacd", 0, "vel@sem.com", true, "Taciti sit volutpat", false, false, null, "volutpat@interdum.com", "customer3", "AQAAAAIAAYagAAAAEF45jr/VNLinNAnRXUCX3JzCh7wFDbD3h0bevCY1H8TY5A6ut0DJhlm4VP9w+JxN8Q==", "3561787605", false, "", false, "customer3" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "31963bfe-8b18-4a58-a121-46e0721b791b", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEOHt0LuAuXh63cKjvB08ctatZ6E7TC3UkXxccPXF03LVQbfpRkEA9jvf2kVXSA+hPQ==", "0000000005", false, "", false, "admin" },
                    { new Guid("2def8d0b-5382-442f-8f40-0944f25871f8"), 0, "Enim/Velit, Integer molestie rhoncus", "243cfcb8-fcd7-447b-bb52-46ed855a05c7", 0, "pretium@auctor.com", true, "Ultrices tellus commodo", false, false, null, "vehicula@interdum.com", "customer6", "AQAAAAIAAYagAAAAEKn1hUXBYKW1josoHbbLBPAIzO/j8SmQojg+OqEsg3nfvVrJxbUfuTLO0NvF0lhhLQ==", "9993905590", false, "", false, "customer6" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "25cb4ff3-507d-4b63-bdef-39c0fd88c099", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEHrAA4CeqUVCHueo7zu+NI24qUwfSt0X8KnSTtEFzLXzNWB5CGnRq7dbJGM6V/Q5sg==", "0000000004", false, "", false, "manager" },
                    { new Guid("364f5d16-532c-467d-9468-4d401a03911b"), 0, "Id/Auctor, Cursus auctor eleifend", "b3717484-438d-4137-bb23-71aff78c27f2", 0, "fringilla@rutrum.com", true, "In litora erat", false, false, null, "neque@viverra.com", "customer7", "AQAAAAIAAYagAAAAEFeKGEa3XDRVgICejcSHsaiL1oEPFvBrRV2hp/M98Fn18eUIi9xc6Fx1fZcM7M2bqQ==", "9786974726", false, "", false, "customer7" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "d5c9907e-7ca2-41d1-b6ca-a4716b92882c", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEE0c6+2WTP2vR2vsj/aIGKDkcr7MMuo6bObDy9CyX+l4vL3DShsin6d2macxLtjPzg==", "0000000002", false, "", false, "tech" },
                    { new Guid("4945f4e5-75af-45be-a849-abed0ae91124"), 0, "Risus/Pellentesque, Porttitor cras arcu", "ced0dcf2-4380-487e-9a5d-603a7353d336", 0, "enim@inceptos.com", true, "Platea nibh iaculis", false, false, null, "mauris@ultrices.com", "customer15", "AQAAAAIAAYagAAAAELqMw78C4lzhQ8qVumhPWxJUPORSn6EpSGFjJPnTIM/c5cKza5Qz3Ied5bGQQxWYKg==", "8854687678", false, "", false, "customer15" },
                    { new Guid("4c6588f1-5824-4292-b12b-c5a793b47a08"), 0, "Ligula/Mauris, Amet tellus cras", "a6ab2c0c-a3ca-4e64-9e2d-e3d7031561da", 0, "habitasse@dolor.com", true, "Sed porta arcu", false, false, null, "tellus@auctor.com", "customer10", "AQAAAAIAAYagAAAAELFKWeKC1hDRfzHSJXH0oAmQorce8f43QQ1SYXTPafY3HJgK8BO7fXhHLL3q16DX6Q==", "8158899294", false, "", false, "customer10" },
                    { new Guid("564c7319-2a8d-493d-a828-39e6656eec87"), 0, "Tortor/Lacus, Efficitur lobortis euismod", "50fe7d1f-a94d-439b-80a5-f7a9813024e7", 0, "mattis@lobortis.com", true, "Dolor amet elit", false, false, null, "eros@neque.com", "customer23", "AQAAAAIAAYagAAAAEJtBGtoBKG/xeH0p9iJJTWSON2ebHYKKTI8ejfWW8hskKjeWNSPLXDxOrss9HhW5mA==", "6147132790", false, "", false, "customer23" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "0dcfe120-a1ac-4410-983e-c39df17c9fa3", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAELRH+8oYVPwNPaYS76mAdNdTCLrCEso4eyi/S88seV7rFOYUi2chY0wxZzIs3pNFsQ==", "0000000001", false, "", false, "super" },
                    { new Guid("5b8e5bea-9a9c-458e-bb38-8afcd55fd045"), 0, "Convallis/Dolor, Ultrices sagittis enim", "7a6a1e7a-a7f2-45bd-aada-29e55632baab", 0, "lectus@erat.com", true, "Velit eros bibendum", false, false, null, "taciti@nisl.com", "customer11", "AQAAAAIAAYagAAAAEPvUP/qI10g8CYQTZ67LRJmDXotmzQCmu10KUTndbGjJ2iZMDdoa/PgHnslhcCIXDA==", "8461999055", false, "", false, "customer11" },
                    { new Guid("5c3eac41-0991-4c56-a2fb-cc02ff557e14"), 0, "Dapibus/Libero, Aptent diam auctor", "654bab18-987a-4f8f-8c62-ecd28f1c42e1", 0, "quis@quam.com", true, "Consectetur congue maecenas", false, false, null, "dolor@placerat.com", "customer14", "AQAAAAIAAYagAAAAEJS/TZNy3LGN7c/3BKVAeX07u/ieXnDRMj7XQDe/S6NaPY/CDrKfOFQLKwrcjYH6tw==", "8124583863", false, "", false, "customer14" },
                    { new Guid("6778a3ab-fc16-4afc-b79f-465bc95c3b67"), 0, "Rutrum/Cursus, Vulputate vestibulum eleifend", "b484dbe6-7e6e-4fe7-be95-78d246f93de1", 0, "nibh@magna.com", true, "Bibendum nisl ex", false, false, null, "suspendisse@massa.com", "customer2", "AQAAAAIAAYagAAAAECVZM6IjDRnLRnviFEJwgNNk8GK7b7xgBnzZ3Z9kBTcZ4Q8qWPIxmxxhaMJ072a2XQ==", "5407986580", false, "", false, "customer2" },
                    { new Guid("90fb1970-462e-4aaa-999b-d3a1a649e1c7"), 0, "Luctus/Magna, Arcu ac curabitur", "f3b02e43-f691-41c7-9835-ceb785b59a4c", 0, "tellus@pharetra.com", true, "Tellus nibh semper", false, false, null, "hac@egestas.com", "customer21", "AQAAAAIAAYagAAAAEClPtEbfKLekJTK1+xfRRYJDCJymxEYaL9LU6RsxHVrVKfeUw+JOoPgrYZKnR2HpHg==", "9056464964", false, "", false, "customer21" },
                    { new Guid("950619e5-6354-4d01-93db-85fd17886b44"), 0, "Interdum/Pretium, Ultrices sociosqu nec", "6173e537-9203-4be9-b062-5f5a5f4228c8", 0, "euismod@lacus.com", true, "Finibus porta ut", false, false, null, "in@nulla.com", "customer4", "AQAAAAIAAYagAAAAELBYTWacT0Cj9d/OYPZ7bPCiXYRNkYwokK5IbOiBX68pkirkZAkLSBqLYwStipfqxw==", "1334179679", false, "", false, "customer4" },
                    { new Guid("9923fd8a-850b-4349-a574-2c7e86a7dc73"), 0, "Lacinia/Nisi, Suscipit tempor mattis", "38f89586-55a3-49b1-b4dc-44b08079cd81", 0, "eleifend@at.com", true, "Vivamus bibendum orci", false, false, null, "tempor@placerat.com", "customer16", "AQAAAAIAAYagAAAAEL57fPoA+O1tRV3cjn8wHytQIqnGQxuRnWRKZyaPWj/tXkhdFTkxDBVwgkSIBUWt5A==", "1046576669", false, "", false, "customer16" },
                    { new Guid("a6cbb167-dab7-4264-99f0-78595461395e"), 0, "Inceptos/Pellentesque, Dolor blandit tincidunt", "c365990a-9c59-4d24-85f7-90657ba5d6ba", 0, "sodales@mauris.com", true, "Libero nec vehicula", false, false, null, "ex@accumsan.com", "customer1", "AQAAAAIAAYagAAAAEIUeP5z7gz/hLB4x7qSHAHi2j/gjVTU9KitIFaYzHGpdqG7no3AbWf5vOVnCDPKvHA==", "9001628533", false, "", false, "customer1" },
                    { new Guid("b6e495b5-0449-4ee8-afc0-31cdb826ba42"), 0, "Nibh/Tortor, Dui nulla mauris", "ad17a95f-3673-45af-9f50-c9238791e9c8", 0, "a@semper.com", true, "Convallis ipsum congue", false, false, null, "tincidunt@elementum.com", "customer9", "AQAAAAIAAYagAAAAEGw1j4NOne5RD8i6/RdMnPsAIzzk2cAYMfjRcnjXU6/ZuhWqUlEzM+aKFNiQXSJ9jA==", "2741377283", false, "", false, "customer9" },
                    { new Guid("bccd38ae-29c3-423f-bfd9-f5624d01447c"), 0, "Mi/Scelerisque, Libero euismod tortor", "874bcdb5-1561-436e-a742-c77a0abf07f7", 0, "ac@dolor.com", true, "Velit finibus quam", false, false, null, "ipsum@vivamus.com", "customer22", "AQAAAAIAAYagAAAAEJRwpZvp6IAO7cujaRGvY7rXl4yWaOxvn7My/RLpsmPGaKpxAnuIqnKhyzjs6yobrQ==", "8718192457", false, "", false, "customer22" },
                    { new Guid("bde6f3dd-7153-471a-9141-2ad0eb49790a"), 0, "Erat/Quisque, Placerat velit nulla", "6efd5fd4-ecb3-4643-903c-8914a126967e", 0, "velit@id.com", true, "Feugiat facilisis dictum", false, false, null, "habitasse@a.com", "customer12", "AQAAAAIAAYagAAAAEJbWZEKd0dkVnagI/AtORXIW0CkdiWPK+bvzdy94HQCi4iJOyc7jZmq0hUHw64cEQA==", "1380740777", false, "", false, "customer12" },
                    { new Guid("c65096c3-817b-4424-a39e-14a23c3a0ed8"), 0, "Elit/Metus, Augue semper aliquet", "db28e1b0-51f3-43dc-ae3e-f01cade40848", 0, "cursus@mi.com", true, "Nec leo etiam", false, false, null, "cursus@fringilla.com", "customer25", "AQAAAAIAAYagAAAAEBQJmuq1/yocM92hEKRYSyUyICjhSuhvmgEtFxxSg8sNT/8LTZNayYv3N4hgWUuWyg==", "1477329948", false, "", false, "customer25" },
                    { new Guid("c8a5fd17-9c88-4b64-a7c9-efaf0b146dd7"), 0, "Arcu/Class, Quisque vel lobortis", "73ae3bf5-5fff-40bf-a014-c017f3231e25", 0, "volutpat@magna.com", true, "Facilisis at risus", false, false, null, "amet@nisi.com", "customer20", "AQAAAAIAAYagAAAAEAUd59dCyYHEP2yxcrvH7BjIVQS+Uq6Dxem1wnkjlHJRyARLpeDVfi8Z2aE9okFWVg==", "3664820297", false, "", false, "customer20" },
                    { new Guid("d132c62b-3ed4-420b-a4c1-0725890ecd1a"), 0, "Commodo/Feugiat, Mattis mauris magna", "b86cf9b9-4b45-4ae7-a2dc-39e8b899e341", 0, "tempor@rhoncus.com", true, "Dictum arcu quisque", false, false, null, "quam@tellus.com", "customer24", "AQAAAAIAAYagAAAAEOKe4NgRYENoSogvuhcGmQdH8HELNDFQB/OJLwv2GzgLTxUTScTypIlluq3ME/2nsA==", "8819652092", false, "", false, "customer24" },
                    { new Guid("f086fd63-384c-44e5-a65a-07d4b951a3a6"), 0, "Eros/Condimentum, Fringilla lacus libero", "6287a878-ed8d-4689-a131-8249d3926d3c", 0, "et@facilisis.com", true, "Erat in varius", false, false, null, "ullamcorper@class.com", "customer13", "AQAAAAIAAYagAAAAEAThH3PlFuCe2siVoYi0F7GY78pWcEWXWM7LgXnn9346k+/L9CFdz+0aC3qElCLf2Q==", "6497528828", false, "", false, "customer13" },
                    { new Guid("f6bd5c22-cbe8-4d75-831c-f22252b3ecf9"), 0, "Eu/Congue, Amet urna hac", "2274b09b-214d-4ab7-849e-312630488dd3", 0, "ac@litora.com", true, "Lorem imperdiet quam", false, false, null, "massa@interdum.com", "customer18", "AQAAAAIAAYagAAAAECtpf7oIBIZm9zQ8Sfj5kd/20NZfJcp/pKr6IeRavJ+5V3gNx0VbLC07RxvNDjI5ug==", "7447459771", false, "", false, "customer18" },
                    { new Guid("fb8bbca3-8920-4b40-a913-caf358d4e22f"), 0, "Orci/Nibh, Habitasse rutrum pharetra", "9bc95171-48fa-4a2a-a958-33c21405a9a9", 0, "nibh@venenatis.com", true, "Interdum consectetur aliquet", false, false, null, "vestibulum@odio.com", "customer5", "AQAAAAIAAYagAAAAECbJsnkQu1m337hRaSBf8hxPk/jqNbkKLbnan8f/bIZNaNmCvnfsDfZ91rKSHSVl0w==", "3723719020", false, "", false, "customer5" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9179), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9189), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9246), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9251), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9251), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9255), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9256), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9260), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9260), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "DeviceStatus", "IsDeleted", "Size", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 335, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9302), 1, false, 8, "Hub" },
                    { 2, 0, 0, 226, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9332), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9332), 1, false, 3, "Hub" },
                    { 3, 0, 0, 273, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9338), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9339), 1, false, 2, "Hub" },
                    { 4, 0, 0, 359, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9345), 1, false, 5, "Hub" },
                    { 5, 0, 0, 490, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9350), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9351), 0, false, 9, "Hub" },
                    { 6, 0, 0, 303, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9358), 0, false, 6, "Hub" },
                    { 7, 0, 0, 385, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9364), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9364), 0, false, 9, "Hub" },
                    { 8, 0, 0, 428, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9370), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9371), 0, false, 4, "Hub" },
                    { 9, 0, 0, 439, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9377), 0, false, 4, "Hub" },
                    { 10, 0, 0, 221, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9384), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9384), 1, false, 8, "Hub" },
                    { 11, 0, 0, 203, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9391), 0, false, 5, "Server" },
                    { 12, 0, 0, 405, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9397), 0, false, 2, "Server" },
                    { 13, 0, 0, 496, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9401), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9402), 0, false, 2, "Server" },
                    { 14, 0, 0, 223, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9407), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9407), 0, false, 3, "Server" },
                    { 15, 0, 0, 406, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9412), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9412), 0, false, 3, "Server" },
                    { 16, 0, 0, 394, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9417), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9417), 0, false, 3, "Server" },
                    { 17, 0, 0, 337, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9423), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9423), 0, false, 7, "Server" },
                    { 18, 0, 0, 369, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9429), 0, false, 9, "Server" },
                    { 19, 0, 0, 437, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9434), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9434), 0, false, 7, "Server" },
                    { 20, 0, 0, 377, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9439), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9439), 0, false, 8, "Server" },
                    { 21, 0, 0, 296, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9450), 0, false, 2, "Server" },
                    { 22, 0, 0, 277, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9455), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9455), 0, false, 10, "Server" },
                    { 23, 0, 0, 231, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9460), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9461), 0, false, 6, "Server" },
                    { 24, 0, 0, 447, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9466), 0, false, 7, "Server" },
                    { 25, 0, 0, 296, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9470), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9471), 0, false, 7, "Server" },
                    { 26, 0, 0, 251, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9476), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9476), 0, false, 9, "Server" },
                    { 27, 0, 0, 286, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9481), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9481), 0, false, 9, "Server" },
                    { 28, 0, 0, 247, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9486), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9486), 0, false, 6, "Server" },
                    { 29, 0, 0, 231, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9491), 0, false, 2, "Server" },
                    { 30, 0, 0, 478, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9496), 0, false, 10, "Server" },
                    { 31, 0, 0, 291, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9501), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9501), 0, false, 6, "Server" },
                    { 32, 0, 0, 330, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9506), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9507), 0, false, 9, "Server" },
                    { 33, 0, 0, 477, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9511), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9512), 0, false, 3, "Server" },
                    { 34, 0, 0, 354, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9610), 0, false, 7, "Server" },
                    { 35, 0, 0, 220, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9615), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9615), 0, false, 6, "Server" },
                    { 36, 0, 0, 306, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9620), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9621), 0, false, 2, "Server" },
                    { 37, 0, 0, 402, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9625), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9626), 0, false, 3, "Server" },
                    { 38, 0, 0, 375, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9630), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9631), 0, false, 7, "Server" },
                    { 39, 0, 0, 273, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9636), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9636), 0, false, 3, "Server" },
                    { 40, 0, 0, 264, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9641), 0, false, 4, "Server" },
                    { 41, 0, 0, 215, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9653), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9653), 0, false, 9, "Server" },
                    { 42, 0, 0, 285, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9659), 0, false, 10, "Server" },
                    { 43, 0, 0, 500, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9664), 0, false, 3, "Server" },
                    { 44, 0, 0, 301, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9669), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9669), 0, false, 3, "Server" },
                    { 45, 0, 0, 367, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9674), 0, false, 5, "Server" },
                    { 46, 0, 0, 490, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9679), 0, false, 6, "Server" },
                    { 47, 0, 0, 367, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9684), 0, false, 10, "Server" },
                    { 48, 0, 0, 356, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9689), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9690), 2, false, 2, "Server" },
                    { 49, 0, 0, 202, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9695), 2, false, 5, "Server" },
                    { 50, 0, 0, 380, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9700), 2, false, 5, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(711), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(711), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(719), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(719), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9280), "Thuê Chỗ", false, "Cấp bổ sung U", "Size" },
                    { 2, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9288), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9288), "Thêm 1U", false, "Bổ sung IP", "Ip" },
                    { 3, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9293), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9293), "Công suất 100", false, "Thêm Port", "Port" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("1197da45-ce58-4ff2-ba58-40f8d3845c6a") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("1bc26a0e-45ba-4bf5-9810-fcb2f25da191") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("21305bcd-5f6a-470b-8fab-668d9e6ca24d") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("2351f408-f58a-493d-9e37-4385fae6abe5") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("2def8d0b-5382-442f-8f40-0944f25871f8") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("364f5d16-532c-467d-9468-4d401a03911b") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4945f4e5-75af-45be-a849-abed0ae91124") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4c6588f1-5824-4292-b12b-c5a793b47a08") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("564c7319-2a8d-493d-a828-39e6656eec87") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("5b8e5bea-9a9c-458e-bb38-8afcd55fd045") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("5c3eac41-0991-4c56-a2fb-cc02ff557e14") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("6778a3ab-fc16-4afc-b79f-465bc95c3b67") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("90fb1970-462e-4aaa-999b-d3a1a649e1c7") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("950619e5-6354-4d01-93db-85fd17886b44") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9923fd8a-850b-4349-a574-2c7e86a7dc73") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("a6cbb167-dab7-4264-99f0-78595461395e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b6e495b5-0449-4ee8-afc0-31cdb826ba42") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("bccd38ae-29c3-423f-bfd9-f5624d01447c") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("bde6f3dd-7153-471a-9141-2ad0eb49790a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("c65096c3-817b-4424-a39e-14a23c3a0ed8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("c8a5fd17-9c88-4b64-a7c9-efaf0b146dd7") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("d132c62b-3ed4-420b-a4c1-0725890ecd1a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f086fd63-384c-44e5-a65a-07d4b951a3a6") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f6bd5c22-cbe8-4d75-831c-f22252b3ecf9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("fb8bbca3-8920-4b40-a913-caf358d4e22f") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9296), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Porta ultricies metus", 1, new DateTime(2023, 11, 4, 15, 20, 2, 242, DateTimeKind.Local).AddTicks(9537), new DateTime(2023, 11, 4, 15, 20, 2, 242, DateTimeKind.Local).AddTicks(9540), false, "1453228146", new Guid("a6cbb167-dab7-4264-99f0-78595461395e") },
                    { 3, "Volutpat volutpat urna", 1, new DateTime(2023, 11, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 11, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(7515), false, "452005451", new Guid("6778a3ab-fc16-4afc-b79f-465bc95c3b67") },
                    { 4, "Ex justo sagittis", 1, new DateTime(2023, 11, 4, 15, 20, 2, 471, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 11, 4, 15, 20, 2, 471, DateTimeKind.Local).AddTicks(9715), false, "1793171968", new Guid("2351f408-f58a-493d-9e37-4385fae6abe5") },
                    { 5, "Interdum erat ante", 5, new DateTime(2023, 11, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(4991), new DateTime(2023, 11, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(4993), false, "1028916715", new Guid("950619e5-6354-4d01-93db-85fd17886b44") },
                    { 6, "Porttitor commodo odio", 1, new DateTime(2023, 11, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(6436), new DateTime(2023, 11, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(6438), false, "1331075765", new Guid("fb8bbca3-8920-4b40-a913-caf358d4e22f") },
                    { 7, "Semper adipiscing tortor", 5, new DateTime(2023, 11, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(1319), new DateTime(2023, 11, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(1322), false, "337974278", new Guid("2def8d0b-5382-442f-8f40-0944f25871f8") },
                    { 8, "Sem leo congue", 1, new DateTime(2023, 11, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(5465), new DateTime(2023, 11, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(5469), false, "96685240", new Guid("364f5d16-532c-467d-9468-4d401a03911b") },
                    { 9, "Curabitur lectus ex", 1, new DateTime(2023, 11, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(1164), new DateTime(2023, 11, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(1166), false, "707797629", new Guid("21305bcd-5f6a-470b-8fab-668d9e6ca24d") },
                    { 10, "Commodo justo consectetur", 4, new DateTime(2023, 11, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(7181), new DateTime(2023, 11, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(7183), false, "457571273", new Guid("b6e495b5-0449-4ee8-afc0-31cdb826ba42") },
                    { 11, "Rhoncus nostra faucibus", 1, new DateTime(2023, 11, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(8514), new DateTime(2023, 11, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(8517), false, "1988906461", new Guid("4c6588f1-5824-4292-b12b-c5a793b47a08") },
                    { 12, "Quis conubia risus", 4, new DateTime(2023, 11, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(2163), new DateTime(2023, 11, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(2167), false, "1753429737", new Guid("5b8e5bea-9a9c-458e-bb38-8afcd55fd045") },
                    { 13, "Cras pellentesque nec", 3, new DateTime(2023, 11, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(4356), new DateTime(2023, 11, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(4359), false, "2145845005", new Guid("bde6f3dd-7153-471a-9141-2ad0eb49790a") },
                    { 14, "Sit quis congue", 1, new DateTime(2023, 11, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(523), new DateTime(2023, 11, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(526), false, "1085821664", new Guid("f086fd63-384c-44e5-a65a-07d4b951a3a6") },
                    { 15, "Ac turpis per", 5, new DateTime(2023, 11, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(4771), new DateTime(2023, 11, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(4774), false, "1900928045", new Guid("5c3eac41-0991-4c56-a2fb-cc02ff557e14") },
                    { 16, "Aptent luctus at", 2, new DateTime(2023, 11, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 11, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(8608), false, "1392736767", new Guid("4945f4e5-75af-45be-a849-abed0ae91124") },
                    { 17, "Suspendisse cursus nisl", 2, new DateTime(2023, 11, 4, 15, 20, 3, 474, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 11, 4, 15, 20, 3, 474, DateTimeKind.Local).AddTicks(8922), false, "889404963", new Guid("9923fd8a-850b-4349-a574-2c7e86a7dc73") },
                    { 18, "Hac tempus est", 5, new DateTime(2023, 11, 4, 15, 20, 3, 576, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 11, 4, 15, 20, 3, 576, DateTimeKind.Local).AddTicks(7456), false, "1354438522", new Guid("1197da45-ce58-4ff2-ba58-40f8d3845c6a") },
                    { 19, "Condimentum habitasse fringilla", 1, new DateTime(2023, 11, 4, 15, 20, 3, 657, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 11, 4, 15, 20, 3, 657, DateTimeKind.Local).AddTicks(2218), false, "668336799", new Guid("f6bd5c22-cbe8-4d75-831c-f22252b3ecf9") },
                    { 20, "Porta felis nec", 4, new DateTime(2023, 11, 4, 15, 20, 3, 727, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 11, 4, 15, 20, 3, 727, DateTimeKind.Local).AddTicks(9934), false, "641009085", new Guid("1bc26a0e-45ba-4bf5-9810-fcb2f25da191") },
                    { 21, "Mattis justo posuere", 2, new DateTime(2023, 11, 4, 15, 20, 3, 797, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 11, 4, 15, 20, 3, 797, DateTimeKind.Local).AddTicks(4688), false, "669631417", new Guid("c8a5fd17-9c88-4b64-a7c9-efaf0b146dd7") },
                    { 22, "Cursus velit primis", 2, new DateTime(2023, 11, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 11, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(4197), false, "1756522184", new Guid("90fb1970-462e-4aaa-999b-d3a1a649e1c7") },
                    { 23, "Varius nam viverra", 5, new DateTime(2023, 11, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(7552), new DateTime(2023, 11, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(7554), false, "509748770", new Guid("bccd38ae-29c3-423f-bfd9-f5624d01447c") },
                    { 24, "Rutrum finibus dolor", 4, new DateTime(2023, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(1074), new DateTime(2023, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(1079), false, "997934576", new Guid("564c7319-2a8d-493d-a828-39e6656eec87") },
                    { 25, "Pellentesque commodo litora", 2, new DateTime(2023, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(3542), new DateTime(2023, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(3545), false, "602069379", new Guid("d132c62b-3ed4-420b-a4c1-0725890ecd1a") },
                    { 26, "Vestibulum nec erat", 5, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(7225), false, "146292855", new Guid("c65096c3-817b-4424-a39e-14a23c3a0ed8") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(726), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(727), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(732), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(733), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(736), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(736), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(740), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(740), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(743), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(744), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(753), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(754), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(757), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(757), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(761), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(764), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(764), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(768), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(769), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(772), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(775), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(776), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(779), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(779), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(782), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(783), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(786), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(786), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(789), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(789), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(793), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(793), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(797), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(797), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(800), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(801), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(804), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(804), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(808), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(808), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(811), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(811), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(814), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(815), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(818), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(818), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(821), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(822), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(825), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(825), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(828), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(831), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(832), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(835), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(839), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(842), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(842), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(885), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(885), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(889), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(889), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(894), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(895), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(898), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(898), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(901), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(901), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(905), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(905), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(908), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(908), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(912), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(912), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(915), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(915), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(918), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(919), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(922), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(922), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(925), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(926), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(929), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(929), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(932), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(933), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(936), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(936), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(939), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(939), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(942), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(943), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(946), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(946), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(950), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(950), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(953), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(954), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(957), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(957), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(960), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(961), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(964), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(964), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(967), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(968), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(971), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(971), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(974), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(983), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(984), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(987), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(987), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(990), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(991), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(994), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(998), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1001), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1001), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1004), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1005), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1008), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1008), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1013), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1013), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1016), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1020), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1020), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1023), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1026), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1027), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1030), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1030), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1034), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1037), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1040), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1041), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1044), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1048), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1051), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1054), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1055), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1058), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1061), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1062), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1065), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1065), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1073), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1073), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1077), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1077), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1080), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1081), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1086), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1086), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1090), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1091), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1096), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1096), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1101), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1106), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1107), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1112), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1119), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1124), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1128), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1129), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1134), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1140), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1140), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1146), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1151), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1157), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1158), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1164), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1169), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1170), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1175), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1175), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1181), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1181), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1186), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1187), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1193), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1193), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1198), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1203), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1203), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1208), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1209), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1212), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1222), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1226), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1230), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1233), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1237), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1240), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1240), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1244), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1247), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1251), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1254), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1254), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1257), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1257), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1260), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1261), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1264), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1264), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1267), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1268), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1271), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1271), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1274), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1275), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1278), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1278), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1281), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1282), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1285), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1288), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1288), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1292), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1292), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1303), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1303), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1306), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1307), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1310), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1310), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1313), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1317), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1317), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1321), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1324), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1324), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1328), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1331), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1331), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1334), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1338), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1338), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1341), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1344), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1345), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1348), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1348), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1351), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1352), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1355), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1355), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1359), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1359), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1362), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1362), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1365), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1366), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1369), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1372), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1373), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1376), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1376), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1379), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1380), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1383), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1386), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1390), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1394), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1401), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1401), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1405), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1405), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1409), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1412), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1412), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1415), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1416), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1419), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1419), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1422), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1422), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1425), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1426), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1429), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1432), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1433), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1436), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1439), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1440), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1443), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1446), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1447), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1450), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1453), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1454), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1457), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1457), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1460), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1464), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1467), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1467), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1470), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1471), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1474), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1478), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1481), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1481), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1484), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1485), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1488), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1492), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1495), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1495), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1504), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1504), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1508), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1511), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1511), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1515), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1515), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1518), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1518), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1522), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1525), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1529), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1532), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1532), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1536), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1539), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1539), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1543), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1546), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1550), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1553), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1557), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1557), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9722), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9735), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9743), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9751), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9758), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9771), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9771), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9778), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9785), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9727), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9736), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9737), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9745), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9745), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9752), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9752), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9765), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9772), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9779), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9786), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9728), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9738), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9746), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9753), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9753), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9766), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9773), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9780), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9787), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9729), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9729), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9739), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9747), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9754), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9767), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9774), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9781), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9788), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9729), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9730), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9740), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9747), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9748), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9755), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9768), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9775), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9781), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9788), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9732), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9740), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9740), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9748), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9748), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9756), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9769), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9776), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9782), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9789), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9789), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9733), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9741), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9749), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9749), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9757), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9769), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9770), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9776), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9783), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9790), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9734), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9742), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9750), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9757), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9757), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9770), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9777), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9784), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9791), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9792), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9798), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9803), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9807), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9811), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9815), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9820), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9824), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9824), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9795), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9799), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9803), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9804), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9808), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9812), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9816), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9816), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9820), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9824), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9825), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9796), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9800), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9804), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9809), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9813), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9817), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9817), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9821), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9821), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9825), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9797), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9801), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9805), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9809), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9814), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9818), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9822), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9822), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9826), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9797), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9802), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9806), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9810), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9815), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9819), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9823), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 11, 4, 15, 20, 1, 798, DateTimeKind.Local).AddTicks(9827), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "SaleApprovals",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "SaleId" },
                values: new object[] { 1, new DateTime(2023, 11, 4, 15, 20, 2, 15, DateTimeKind.Local).AddTicks(1551), new DateTime(2023, 11, 4, 15, 20, 2, 15, DateTimeKind.Local).AddTicks(1555), false, new Guid("1abb6e28-793d-460f-8a24-745998356da8") });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1566), 11, false, "Massa eu ante", 1, "2b128750-09b1-41ec-98b1-c99ecac7591a" },
                    { 2, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1902), 12, false, "Viverra class taciti", 1, "e394cfec-f768-4fd3-a5be-f5100abbe59f" },
                    { 3, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2152), 13, false, "Ex quam odio", 1, "2ca9cff7-3ec9-49c7-959b-86a2b8b51a9f" },
                    { 4, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2368), 14, false, "Id consectetur porta", 1, "244d8499-c63e-49ef-88c1-21b89283d5e7" },
                    { 5, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2592), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2592), 15, false, "Tellus tempus scelerisque", 1, "f730110d-d4e3-4855-8773-785657d03fd4" },
                    { 6, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2875), 16, false, "Blandit lacinia efficitur", 1, "4285bb40-16ec-4b77-9841-e063012e00ce" },
                    { 7, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3073), 17, false, "Velit a ligula", 1, "b416cd16-2d95-4386-ab57-5da58f408427" },
                    { 8, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3276), 18, false, "Est morbi nisi", 1, "48f0ba52-9446-4092-80c5-2d0d66f9d30c" },
                    { 9, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3474), 19, false, "Molestie libero ante", 1, "427df1ee-6474-4c67-9d37-f83347bbe978" },
                    { 10, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3681), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3681), 20, false, "Mollis ligula etiam", 1, "0ded0dd9-dc32-4138-9114-2a54192c845a" },
                    { 11, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3882), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3882), 21, false, "Nec ex egestas", 1, "cb4085b4-6052-437b-9775-6de0de00652d" },
                    { 12, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4071), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4071), 22, false, "Bibendum mattis nunc", 1, "ffab4eb9-b339-489b-9133-f9bc923d140c" },
                    { 13, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4268), 23, false, "Eu eu phasellus", 1, "4881a58d-014a-4fca-bf23-c66b8e9199b8" },
                    { 14, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4455), 24, false, "Tempor feugiat libero", 1, "d10d4764-4f75-45a4-9877-ba3f12ab4ef1" },
                    { 15, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4667), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4668), 25, false, "Tellus himenaeos etiam", 1, "7a92f6b5-d216-43c4-b570-1a28de6202f2" },
                    { 16, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4872), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4872), 26, false, "Ex aptent nibh", 1, "9646b9d6-5709-4068-aae8-ad2f046bee44" },
                    { 17, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5073), 27, false, "Blandit sodales ullamcorper", 1, "887905f0-dba1-487f-8cb1-4c4d6375e6e6" },
                    { 18, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5261), 28, false, "Dapibus eleifend cursus", 1, "68980999-6c87-4bfc-abb3-4b3dcd8a5fdd" },
                    { 19, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5455), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5456), 29, false, "Cursus consequat neque", 1, "e2f7b186-81eb-41da-88fc-0322d2b061a1" },
                    { 20, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5669), 30, false, "Euismod ligula mattis", 1, "89c21679-e2a7-4171-8bc3-2c33f4598910" },
                    { 21, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5939), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5939), 31, false, "Pharetra cras rhoncus", 1, "25407adf-e2b4-4526-bfa7-6874e9513a0a" },
                    { 22, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6138), 32, false, "Amet quis elementum", 1, "3ba4e7cf-c277-4b6d-8dd0-95b6ca5e30ae" },
                    { 23, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6355), 33, false, "Luctus per phasellus", 1, "9aca929d-14f6-4785-b8a7-557627b64f8d" },
                    { 24, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6557), 34, false, "Ipsum metus aliquet", 1, "39346ef9-4360-4703-bf72-40d17141463b" },
                    { 25, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6734), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6734), 35, false, "Vitae dolor finibus", 1, "9b090c52-e08d-4e92-a024-83a0d1e24383" },
                    { 26, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6922), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6922), 36, false, "Nunc posuere non", 1, "8aee43ff-f7ef-4b84-9b78-ae800bb921ff" },
                    { 27, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7132), 37, false, "Mi faucibus dapibus", 1, "af91ed9f-3f78-4d73-bf33-531e3f1680c5" },
                    { 28, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7317), 38, false, "Litora scelerisque rutrum", 1, "f0d35991-20be-4d2f-81d5-48af064a68e2" },
                    { 29, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7513), 39, false, "Elit aenean litora", 1, "bb73b3f9-9386-4b95-a12d-04bc989af58d" },
                    { 30, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7707), 40, false, "Feugiat ornare eget", 1, "2c0e0c8b-874a-463f-b0d9-6fc00fe1c3c1" },
                    { 31, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7911), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7912), 41, true, "Convallis ex eros", 1, "bef8a0ae-7458-471b-ac25-88798e9b5ec2" },
                    { 32, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8140), 42, true, "Leo ultrices in", 1, "e60eef75-b1ba-4fa6-aeb8-1685ef8310c4" },
                    { 33, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8324), 43, false, "Sagittis vitae tellus", 1, "f6fa0c18-5df9-44a9-9e27-e89ba781e642" },
                    { 34, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8521), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8521), 44, false, "Porttitor dolor facilisis", 1, "a3fb0a0a-6018-4c22-a031-3e14c6ba39dc" },
                    { 35, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8726), 45, false, "At ac varius", 1, "edd06e54-9b76-4484-934c-6f67098275d5" },
                    { 36, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8998), 46, false, "Mi praesent quis", 1, "64c27c35-2bdb-419b-8d58-3682ddd1a024" },
                    { 37, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9173), 47, false, "Dolor lacinia sagittis", 1, "4a7a6182-59da-46a1-812d-6ad6f0fce99e" },
                    { 38, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9385), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9386), 48, false, "Sollicitudin dolor ullamcorper", 1, "791fcc6b-ffd2-4ce9-9eb0-6e54cd6678c3" },
                    { 39, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9563), 49, false, "Consequat luctus ac", 1, "14c281b3-3e01-4b85-8a7b-868f7b7f387e" },
                    { 40, 0, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9772), 50, false, "Adipiscing ultrices vehicula", 1, "3ab253fd-bb04-467e-8363-7cf728d0f50d" }
                });

            migrationBuilder.InsertData(
                table: "TechExecutions",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "TechId" },
                values: new object[] { 1, new DateTime(2023, 11, 4, 15, 20, 1, 938, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 11, 4, 15, 20, 1, 938, DateTimeKind.Local).AddTicks(5013), false, new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsActive", "IsDeleted", "ServerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1890), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(1891), 4, true, false, 1 },
                    { 2, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2148), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2148), 5, true, false, 2 },
                    { 3, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(2364), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2363), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2364), 6, true, false, 3 },
                    { 4, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(2588), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2588), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2588), 7, true, false, 4 },
                    { 5, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(2870), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2869), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(2869), 8, true, false, 5 },
                    { 6, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3069), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3069), 9, true, false, 6 },
                    { 7, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(3272), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3272), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3272), 10, true, false, 7 },
                    { 8, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(3471), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3470), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3470), 11, true, false, 8 },
                    { 9, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(3671), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3670), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3670), 12, true, false, 9 },
                    { 10, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(3878), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3878), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(3878), 13, true, false, 10 },
                    { 11, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(4067), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4067), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4067), 14, true, false, 11 },
                    { 12, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(4264), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4264), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4264), 15, true, false, 12 },
                    { 13, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(4452), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4451), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4452), 16, true, false, 13 },
                    { 14, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(4664), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4663), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4664), 17, true, false, 14 },
                    { 15, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(4869), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4868), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(4868), 18, true, false, 15 },
                    { 16, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(5069), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5069), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5069), 19, true, false, 16 },
                    { 17, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(5255), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5255), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5255), 20, true, false, 17 },
                    { 18, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(5452), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5451), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5452), 21, true, false, 18 },
                    { 19, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(5666), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5665), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5665), 22, true, false, 19 },
                    { 20, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5934), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(5934), 23, true, false, 20 },
                    { 21, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(6134), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6133), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6134), 24, true, false, 21 },
                    { 22, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(6352), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6351), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6351), 25, true, false, 22 },
                    { 23, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(6553), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6552), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6553), 26, true, false, 23 },
                    { 24, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(6730), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6730), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6730), 27, true, false, 24 },
                    { 25, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(6918), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6918), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(6918), 28, true, false, 25 },
                    { 26, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(7128), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7127), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7128), 29, true, false, 26 },
                    { 27, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(7313), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7312), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7313), 30, true, false, 27 },
                    { 28, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(7509), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7509), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7509), 31, true, false, 28 },
                    { 29, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(7703), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7703), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7703), 32, true, false, 29 },
                    { 30, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(7908), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7907), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(7907), 33, true, false, 30 },
                    { 31, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8128), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8128), 34, false, true, 31 },
                    { 32, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8319), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8320), 35, false, true, 32 },
                    { 33, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(8516), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8515), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8515), 36, true, false, 33 },
                    { 34, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(8722), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8721), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8722), 37, true, false, 34 },
                    { 35, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(8994), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8993), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(8993), 38, true, false, 35 },
                    { 36, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(9170), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9169), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9169), 39, true, false, 36 },
                    { 37, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(9382), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9381), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9382), 40, true, false, 37 },
                    { 38, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(9559), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9558), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9559), 41, true, false, 38 },
                    { 39, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(9763), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9762), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9762), 42, true, false, 39 },
                    { 40, new DateTime(2023, 11, 4, 8, 20, 1, 799, DateTimeKind.Utc).AddTicks(9964), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9964), null, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(9964), 43, true, false, 40 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(554), 1, false, 1, 27 },
                    { 2, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(566), 2, false, 2, 29 },
                    { 3, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(570), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(571), 3, false, 3, 8 },
                    { 4, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(575), 4, false, 4, 11 },
                    { 5, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(579), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(579), 5, false, 5, 1 },
                    { 6, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(584), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(584), 6, false, 6, 14 },
                    { 7, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(589), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(589), 7, false, 7, 2 },
                    { 8, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(593), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(593), 8, false, 8, 21 },
                    { 9, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(598), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(598), 9, false, 9, 10 },
                    { 10, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(603), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(604), 10, false, 10, 14 },
                    { 11, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(608), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(608), 11, false, 11, 9 },
                    { 12, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(612), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(612), 12, false, 12, 6 },
                    { 13, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(616), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(617), 13, false, 13, 27 },
                    { 14, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(628), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(628), 14, false, 14, 26 },
                    { 15, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(633), 15, false, 15, 18 },
                    { 16, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(637), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(637), 16, false, 16, 23 },
                    { 17, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(642), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(642), 17, false, 17, 25 },
                    { 18, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(647), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(648), 18, false, 18, 24 },
                    { 19, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(652), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(652), 19, false, 19, 17 },
                    { 20, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(656), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(656), 20, false, 20, 14 },
                    { 21, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(660), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(660), 21, false, 21, 22 },
                    { 22, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(664), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(665), 22, false, 22, 12 },
                    { 23, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(669), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(669), 23, false, 23, 11 },
                    { 24, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(673), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(673), 24, false, 24, 8 },
                    { 25, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(677), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(677), 25, false, 25, 5 },
                    { 26, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(681), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(682), 26, false, 26, 23 },
                    { 27, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(686), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(686), 27, false, 27, 24 },
                    { 28, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(690), 28, false, 28, 6 },
                    { 29, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(694), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(695), 29, false, 29, 23 },
                    { 30, new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 11, 4, 15, 20, 1, 799, DateTimeKind.Local).AddTicks(699), 30, false, 30, 1 }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "SaleApprovalId", "ServerId", "Status", "TechExecutionId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 2, 4, 15, 20, 2, 243, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 10, 4, 15, 20, 2, 243, DateTimeKind.Local).AddTicks(470), new DateTime(2025, 11, 4, 15, 20, 2, 243, DateTimeKind.Local).AddTicks(478), new DateTime(2023, 11, 4, 15, 20, 2, 242, DateTimeKind.Local).AddTicks(9772), 5, new DateTime(2024, 11, 4, 15, 20, 2, 243, DateTimeKind.Local).AddTicks(476), null, null, false, "Nulla interdum, arcu, sem, tempor lorem, tortor, orci, lacus urna, a, volutpat rutrum commodo, magna, vel, sed, lectus, duis placerat. Dapibus bibendum, interdum fames hac cursus neque, rutrum posuere dui turpis nostra, mattis eleifend, nisi lacus ornare tincidunt maecenas id. Tempor nisl condimentum dolor taciti nec, massa nibh nulla dolor, bibendum ex ultricies ligula, interdum elementum eleifend, aliquet porttitor porta.", null, null, null, 0, null },
                    { 2, 3, new DateTime(2024, 1, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 1, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(8429), new DateTime(2024, 11, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(8438), new DateTime(2023, 11, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(7754), 5, new DateTime(2025, 11, 4, 15, 20, 2, 362, DateTimeKind.Local).AddTicks(8436), null, null, false, "Urna sociosqu mi auctor commodo fringilla in, dignissim eros, tellus vestibulum curabitur euismod tellus, tortor placerat, auctor, blandit eu lectus. Dictum mauris id, auctor, fusce lacus ligula sollicitudin non, pharetra efficitur malesuada posuere, torquent eu, accumsan convallis nostra, hendrerit lacinia. Mattis dictumst velit neque cras bibendum vitae, a, at euismod pretium congue ex, maximus erat tellus, lacus eu felis vestibulum.", null, null, null, 0, null },
                    { 3, 4, new DateTime(2024, 4, 4, 15, 20, 2, 472, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 11, 4, 15, 20, 2, 472, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 11, 4, 15, 20, 2, 472, DateTimeKind.Local).AddTicks(705), new DateTime(2023, 11, 4, 15, 20, 2, 472, DateTimeKind.Local).AddTicks(64), 5, new DateTime(2024, 11, 4, 15, 20, 2, 472, DateTimeKind.Local).AddTicks(703), null, null, false, "Ligula enim varius vestibulum eros, at pretium elit odio bibendum, quis porta lobortis porttitor, justo ante suspendisse massa metus nulla. Mollis tellus, nunc, at, magna, auctor euismod, mauris, tincidunt molestie sollicitudin magna sagittis, mauris congue, ex in, eu iaculis adipiscing. Nec rhoncus est suscipit a laoreet, facilisis blandit, pulvinar lorem viverra velit nibh, nibh quam, urna bibendum, mattis, erat enim.", null, null, null, 0, null },
                    { 4, 5, new DateTime(2024, 2, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 9, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(6356), new DateTime(2025, 11, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(6365), new DateTime(2023, 11, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(5468), 5, new DateTime(2024, 11, 4, 15, 20, 2, 544, DateTimeKind.Local).AddTicks(6363), null, null, false, "Inceptos amet, posuere, lectus, adipiscing sodales egestas in neque lacinia malesuada orci per pretium velit non sociosqu quisque vestibulum, bibendum. Cursus nisl porta lorem luctus, aliquam nunc, maximus arcu arcu, egestas at a donec quam, placerat, consequat a, eros mi. Nulla, porta suspendisse condimentum morbi vivamus torquent habitasse commodo, fringilla scelerisque libero lorem vestibulum, fermentum ligula, et lorem, sollicitudin imperdiet.", null, null, null, 0, null },
                    { 5, 6, new DateTime(2024, 4, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(7646), new DateTime(2023, 12, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(7641), new DateTime(2026, 11, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(7650), new DateTime(2023, 11, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(6762), 5, new DateTime(2025, 11, 4, 15, 20, 2, 617, DateTimeKind.Local).AddTicks(7648), null, null, false, "Luctus praesent erat, efficitur amet, nec lacinia id mattis imperdiet eleifend, platea sed, varius, lectus, lorem, ullamcorper ligula sem rutrum. Justo mattis, sit venenatis auctor nisi lacinia, praesent nibh, suscipit tellus lorem, massa magna at molestie semper sodales lacus eleifend. Eros, mauris, dolor, nibh, tempor, dolor nec praesent arcu rutrum auctor pretium nostra, rhoncus pulvinar id ac, tellus, quam, urna.", null, null, null, 0, null },
                    { 6, 7, new DateTime(2024, 5, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 1, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(2644), new DateTime(2024, 11, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(2654), new DateTime(2023, 11, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(1697), 5, new DateTime(2026, 11, 4, 15, 20, 2, 691, DateTimeKind.Local).AddTicks(2652), null, null, false, "Praesent et taciti sodales amet nam sagittis, arcu urna, ultrices at nulla, lacus primis felis tempus fringilla, iaculis facilisis at. Vestibulum sem interdum leo leo, class ante, venenatis molestie fames suspendisse laoreet pharetra euismod, justo elementum mollis magna curabitur mauris. Mollis pellentesque fermentum eu, at mi, dictum volutpat sapien sollicitudin mauris nunc sem, magna vitae sagittis aptent pulvinar elit, nostra.", null, null, null, 1, null },
                    { 7, 8, new DateTime(2024, 3, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(7294), new DateTime(2023, 12, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(7288), new DateTime(2026, 11, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(7298), new DateTime(2023, 11, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(5872), 5, new DateTime(2026, 11, 4, 15, 20, 2, 773, DateTimeKind.Local).AddTicks(7296), null, null, false, "Ac fusce sed, laoreet, mollis sociosqu vestibulum, gravida porttitor, semper mauris, iaculis ante, etiam eleifend, amet per litora urna leo. Maecenas sem eleifend mattis, ut mauris massa lectus risus fermentum mattis sapien magna pellentesque porttitor, odio, justo class nibh, volutpat. Phasellus diam luctus nullam fames orci rhoncus, et vehicula amet fusce leo, pulvinar tellus, pulvinar, dolor, consequat lorem, proin aenean.", null, null, null, 1, null },
                    { 8, 9, new DateTime(2024, 3, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(2245), new DateTime(2024, 2, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(2241), new DateTime(2024, 11, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 11, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(1435), 5, new DateTime(2026, 11, 4, 15, 20, 2, 875, DateTimeKind.Local).AddTicks(2248), null, null, false, "Justo semper interdum, scelerisque ultrices, velit neque, interdum himenaeos placerat, malesuada porttitor, rhoncus eu varius vehicula vitae, viverra bibendum facilisis. Orci, fringilla, vitae lectus felis vestibulum urna viverra commodo ultrices, et eleifend amet varius sed, suscipit nostra, eu iaculis nunc. Quam, vulputate non molestie nisi eget mattis, nostra, lectus luctus, sagittis nibh pulvinar, volutpat elit, ex, mollis velit nisl neque.", null, null, null, 1, null },
                    { 9, 10, new DateTime(2024, 6, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 11, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(8359), new DateTime(2025, 11, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 11, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(7520), 5, new DateTime(2026, 11, 4, 15, 20, 2, 944, DateTimeKind.Local).AddTicks(8366), null, null, false, "Imperdiet ex, eu, curabitur et, pellentesque adipiscing velit aenean tristique hac sodales litora ultricies ante, condimentum id, bibendum porta laoreet. Lectus odio nostra, aenean ac elit, metus nisi nisi, sed sodales velit integer tempus mi iaculis luctus, nibh mi, ante. In, maximus ut libero maecenas mauris, quisque aptent blandit volutpat, congue, odio, donec ornare aliquet velit ullamcorper molestie rhoncus, euismod.", null, null, null, 1, null },
                    { 10, 11, new DateTime(2023, 12, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(9454), new DateTime(2023, 11, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(9449), new DateTime(2026, 11, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 11, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(8759), 5, new DateTime(2025, 11, 4, 15, 20, 3, 15, DateTimeKind.Local).AddTicks(9456), null, null, false, "Tortor, duis commodo magna lobortis et sagittis, vivamus nam sociosqu at, vitae, ante, aliquet tellus, sit imperdiet cursus, dui, pulvinar. Vivamus molestie erat, ligula in, id metus tempor, primis suscipit hendrerit sed, enim eleifend ornare vehicula placerat facilisis ullamcorper felis. Sagittis, vulputate convallis fermentum placerat rutrum purus commodo, imperdiet vehicula rhoncus, ultrices, vel, pretium luctus, lorem, nunc, eleifend, auctor porta.", null, null, null, 1, null },
                    { 11, 12, new DateTime(2024, 1, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(3057), new DateTime(2024, 1, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(3053), new DateTime(2026, 11, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 11, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(2394), 5, new DateTime(2025, 11, 4, 15, 20, 3, 85, DateTimeKind.Local).AddTicks(3059), null, null, false, "Auctor viverra erat, cursus sociosqu ultrices amet, urna, aliquet litora fringilla, rhoncus, diam suspendisse finibus, nibh, porttitor, magna vestibulum, dolor. Blandit auctor, sapien volutpat, nulla, eleifend, justo maximus erat vitae nullam placerat scelerisque vel, nunc, lobortis quis morbi magna dignissim. Erat, feugiat egestas orci, consequat ut sodales lectus, ante, dolor, nibh rhoncus class gravida ligula, commodo, in, bibendum mattis nostra.", null, 1, 1, 2, null },
                    { 12, 13, new DateTime(2024, 5, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(5619), new DateTime(2023, 12, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 11, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(5626), new DateTime(2023, 11, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(4674), 5, new DateTime(2024, 11, 4, 15, 20, 3, 158, DateTimeKind.Local).AddTicks(5623), null, null, false, "Tempor, nullam id, cras malesuada mollis eleifend sapien posuere, morbi mi eu odio, amet, molestie nisl in, urna, fames odio. Mattis erat arcu nulla, aliquet id, quis magna posuere dolor, suspendisse pulvinar massa, maecenas auctor leo ultrices, elementum pellentesque placerat. Sem tincidunt suscipit cras rhoncus, fringilla tortor urna placerat, ultrices, diam imperdiet quam, euismod nisi fringilla, magna nunc, lacus aliquam.", null, 1, 2, 2, null },
                    { 13, 14, new DateTime(2024, 1, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(1633), new DateTime(2023, 11, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(1629), new DateTime(2026, 11, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(1638), new DateTime(2023, 11, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(781), 5, new DateTime(2024, 11, 4, 15, 20, 3, 232, DateTimeKind.Local).AddTicks(1636), null, null, false, "Condimentum arcu, commodo, diam placerat, tellus, rhoncus, vitae maecenas fermentum phasellus porta, quam, blandit facilisis sollicitudin erat, vestibulum elementum leo. Sed tincidunt sollicitudin consectetur nisi suspendisse quam integer volutpat ultricies nibh arcu bibendum, per amet enim, feugiat, porta gravida laoreet. Dolor, ipsum fermentum luctus neque, nam leo lorem sapien tellus, quis, orci sodales feugiat vitae eros et ligula, viverra auctor.", null, 1, 3, 2, null },
                    { 14, 15, new DateTime(2024, 6, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 8, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 11, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 11, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(5106), 5, new DateTime(2024, 11, 4, 15, 20, 3, 303, DateTimeKind.Local).AddTicks(5973), null, null, false, "Et, nulla, nibh, porttitor, malesuada feugiat laoreet conubia tellus, tempus platea aliquet vestibulum, feugiat, vestibulum blandit arcu et rhoncus leo. Volutpat ut massa, laoreet, posuere, sollicitudin mattis blandit, per placerat, sapien nostra, scelerisque urna, vestibulum, leo, mollis porttitor diam nisi. Nisi, convallis porttitor elit fringilla aliquam erat, pretium mauris, ultrices ante enim, hendrerit tempor, massa, pulvinar, vel aptent massa quam.", null, 1, 4, 2, null },
                    { 15, 16, new DateTime(2024, 4, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 2, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(9567), new DateTime(2024, 11, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 11, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(8866), 5, new DateTime(2025, 11, 4, 15, 20, 3, 373, DateTimeKind.Local).AddTicks(9574), null, null, false, "Maximus neque, lectus, tortor mauris hac sagittis tempus placerat, pulvinar, elit, fusce molestie urna platea luctus, purus proin volutpat, leo. Sodales et condimentum sit orci, a vestibulum nunc, mattis, aptent finibus, gravida efficitur fringilla rhoncus, pulvinar, ante id, cursus nulla. Luctus nibh nisi, tempor, elementum et, facilisis arcu, bibendum sodales ante, vehicula vestibulum iaculis maecenas sociosqu vitae, sit lacinia fermentum.", null, 1, 5, 2, null },
                    { 16, 17, new DateTime(2024, 6, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(1673), new DateTime(2023, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(1682), new DateTime(2023, 11, 4, 15, 20, 3, 474, DateTimeKind.Local).AddTicks(9125), 5, new DateTime(2025, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(1678), null, null, false, "Vestibulum quisque metus dui, pulvinar commodo, nibh, elit, efficitur torquent varius, bibendum, mollis nisi duis odio, ac, faucibus consectetur posuere. Gravida iaculis est at, taciti massa, porta ligula mi, venenatis ante, nisi, tempor, eros, faucibus tellus, himenaeos vitae, elementum dui. Tincidunt urna, at nulla pretium sem vitae nibh, enim dignissim euismod congue sed elementum blandit aliquam mauris, vivamus ullamcorper egestas.", null, 1, 6, 4, 1 },
                    { 17, 19, new DateTime(2023, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(9306), new DateTime(2023, 8, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(9313), new DateTime(2023, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(7698), 5, new DateTime(2025, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(9309), null, null, false, "Nibh, velit himenaeos id, felis risus ligula, egestas orci, erat, rutrum consequat gravida rhoncus, magna, vivamus lorem, blandit, mauris, leo. Odio mi ligula, eget per platea aptent varius, ante ultrices, ligula finibus, euismod, finibus blandit, tempor, erat felis etiam et. Nulla quam ante bibendum, gravida aenean ex, auctor, taciti odio arcu, orci non, ad porttitor nulla, tincidunt consequat blandit, diam.", null, 1, 7, 4, 1 },
                    { 18, 19, new DateTime(2023, 12, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 9, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 11, 4, 15, 20, 3, 475, DateTimeKind.Local).AddTicks(9480), 5, new DateTime(2026, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(3339), null, null, false, "Dapibus non odio consectetur euismod, mattis, fames gravida congue, cras ligula tellus vel, fusce magna convallis himenaeos felis tempor hendrerit. Lacinia, ligula sem, morbi sagittis, ad sit et conubia non ante hac nec, himenaeos porttitor risus pulvinar rhoncus, ullamcorper commodo. Magna, proin aenean faucibus tincidunt rhoncus ac nullam maecenas class elementum turpis mauris, porta, interdum fames tellus eros, inceptos vestibulum.", null, 1, 8, 4, 1 },
                    { 19, 17, new DateTime(2024, 6, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(4403), new DateTime(2023, 9, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(4400), new DateTime(2025, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(4407), new DateTime(2023, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(3411), 5, new DateTime(2025, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(4405), null, null, false, "Risus scelerisque ut lorem, adipiscing torquent sagittis, elementum phasellus volutpat lacinia nibh duis eu cras ante, lobortis massa, interdum, fames. Eleifend, nibh bibendum tortor, ultrices, rhoncus vulputate porta scelerisque arcu dui, curabitur lacus convallis consectetur sit inceptos elit, litora at. Orci, a, hendrerit fames mollis fringilla, cursus efficitur sem, scelerisque gravida malesuada lacinia, arcu, amet, ultrices, neque, maximus auctor, etiam.", null, 1, 9, 4, 1 },
                    { 20, 20, new DateTime(2024, 4, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 12, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(5201), new DateTime(2024, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(5209), new DateTime(2023, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(4429), 5, new DateTime(2024, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(5207), null, null, false, "Eget dictumst porta, per varius, adipiscing ut malesuada arcu taciti rutrum lacinia vestibulum, dolor orci, dolor, venenatis pretium vitae ornare. Ligula malesuada nunc, velit commodo turpis duis pulvinar feugiat tellus aliquam suscipit proin lectus nibh luctus, volutpat, vel, magna egestas. At, elit, dui, semper mauris, nec finibus aenean efficitur mauris sapien fringilla, dignissim diam luctus luctus, vestibulum, dolor amet commodo.", null, 1, 10, 4, 1 },
                    { 21, 19, new DateTime(2023, 12, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(6527), new DateTime(2023, 8, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(6521), new DateTime(2026, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(5237), 5, new DateTime(2025, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(6529), null, null, false, "Sodales consequat fringilla, dui porttitor sed, porta id taciti pellentesque lacinia, eget eros, justo et, etiam nostra, enim, metus donec. Pellentesque massa, consectetur ligula mi, interdum dignissim sed, at congue consequat vulputate adipiscing auctor, placerat ullamcorper cras tempor suscipit justo. Sagittis lobortis eros ac sit arcu, ultrices, laoreet urna, mi cras fames erat, lectus, pellentesque felis quis, et vestibulum, tortor.", null, 1, 11, 4, 1 },
                    { 22, 19, new DateTime(2024, 2, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2059), new DateTime(2024, 2, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2054), new DateTime(2024, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 11, 4, 15, 20, 3, 476, DateTimeKind.Local).AddTicks(6588), 5, new DateTime(2024, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2061), null, null, false, "Enim, purus aliquet eu, fusce scelerisque neque aliquam eget litora congue, orci, at, odio, porttitor ipsum hendrerit platea fringilla, tellus. Purus morbi varius, nulla, ligula, tellus neque, at bibendum, augue ante venenatis non volutpat, condimentum orci, sem convallis tellus, molestie. Odio id vel, luctus, aliquam aptent fermentum mi commodo, pulvinar, inceptos dolor orci non, a, fusce neque, sit erat at.", null, 1, 12, 4, 1 },
                    { 23, 17, new DateTime(2024, 4, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 1, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2971), new DateTime(2025, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2106), 5, new DateTime(2026, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2975), null, null, false, "Aptent auctor, non interdum volutpat at congue, dolor, amet, rhoncus, dignissim porta, dapibus mauris, arcu vehicula ligula felis nostra, primis. Orci, platea cras lorem, conubia enim dui, cursus mauris eros odio, iaculis interdum, tortor elit, dictumst porttitor nostra, risus in. Lorem, ante quis quam, metus mattis odio, maecenas felis id, feugiat tellus, posuere suscipit magna, finibus pharetra dui aenean praesent.", null, 1, 13, 4, 1 },
                    { 24, 20, new DateTime(2024, 3, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(3804), new DateTime(2024, 1, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(3802), new DateTime(2025, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(3806), new DateTime(2023, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(2987), 5, new DateTime(2024, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(3805), null, null, false, "Lacinia habitasse morbi maximus fermentum dictumst egestas interdum, eleifend lorem hac nostra, blandit blandit, massa non aptent eros ultrices, lacus. Sapien blandit, fermentum erat donec commodo laoreet tempus tellus, fringilla volutpat felis aenean suscipit vestibulum mollis fringilla, tellus curabitur aptent. Nibh nulla, consequat porttitor, torquent fringilla ante, lectus per volutpat, blandit, eu, felis cursus, orci rutrum magna, vulputate porta, sociosqu.", null, 1, 14, 4, 1 },
                    { 25, 19, new DateTime(2024, 6, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(4634), new DateTime(2023, 10, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(4633), new DateTime(2025, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(4637), new DateTime(2023, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(3814), 5, new DateTime(2026, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(4636), null, null, false, "Tellus, magna, purus justo bibendum, tortor, vestibulum hendrerit nulla, turpis sed ut praesent placerat, accumsan id, molestie morbi fermentum mi. Lorem ante, nulla cras tincidunt congue, feugiat, posuere, placerat, diam congue egestas dignissim suscipit nulla, at dolor, tempus sociosqu dictumst. Platea tortor, imperdiet id, finibus, pulvinar laoreet quis, erat, euismod lectus neque, et ullamcorper eleifend sed, ultricies eros dolor sem.", null, 1, 15, 4, 1 },
                    { 26, 20, new DateTime(2023, 12, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 10, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(1488), new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(1500), new DateTime(2023, 11, 4, 15, 20, 3, 477, DateTimeKind.Local).AddTicks(4646), 5, new DateTime(2024, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(1497), null, null, false, "Nulla semper hendrerit blandit sapien aliquam sollicitudin pharetra mattis, ante, magna et laoreet cursus nunc, risus efficitur odio, adipiscing integer. Venenatis consequat porta sem, congue semper vehicula aliquet mi ultrices risus nunc ullamcorper euismod, ex nunc, at nullam aenean hac. Nostra, turpis vulputate faucibus magna mattis rhoncus luctus, primis sapien cursus, eget ornare elit, fermentum rutrum erat venenatis orci, aptent.", null, 1, 16, 4, 1 },
                    { 27, 19, new DateTime(2024, 4, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 9, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(2765), new DateTime(2024, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(1546), 5, new DateTime(2024, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(2770), null, null, false, "In, et, felis arcu, nullam tempus lectus sagittis, aliquet mi eget aliquam pretium quis, ligula bibendum non maximus elementum posuere. Ligula, himenaeos enim pretium viverra lobortis mattis torquent diam lorem libero consectetur lectus nec, euismod, risus nisi condimentum amet a. Cursus sed libero tortor elementum ligula, sapien nisi, blandit, amet ac arcu fermentum nec, ultrices, suscipit ultrices sed, ex, phasellus.", null, 1, 17, 4, 1 },
                    { 28, 18, new DateTime(2024, 2, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 10, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(3857), new DateTime(2025, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(2790), 5, new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(3862), null, null, false, "Conubia gravida dignissim class turpis consequat sit molestie porta, morbi orci ex nostra, proin tempor, feugiat ex, ac lectus, euismod. Convallis consequat feugiat fringilla, quis, morbi pretium rhoncus, euismod, quam volutpat sem quam, dictumst dictum praesent taciti nam non interdum. Nam et, fermentum leo euismod nibh, sed commodo blandit taciti urna dignissim erat tempus sed, elit nulla id ante laoreet.", null, 1, 18, 4, 1 },
                    { 29, 17, new DateTime(2023, 12, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 1, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(4989), new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(3878), 5, new DateTime(2024, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(4995), null, null, false, "Quam, urna ac fringilla, massa sed, ipsum vitae, gravida inceptos a eget rutrum urna, bibendum, varius, tortor placerat, suspendisse lorem. Ex sodales blandit fringilla leo turpis accumsan nunc, lacus curabitur magna, pellentesque enim, mauris enim tellus, efficitur sapien habitasse maecenas. Ex pretium massa, neque, lectus, odio, nulla, mi sociosqu est tempor, tellus finibus aptent quis aenean dui sem facilisis quam.", null, 1, 19, 4, 1 },
                    { 30, 17, new DateTime(2024, 2, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 9, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(6168), new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(6175), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(5013), 5, new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(6173), null, null, false, "Posuere, mattis rutrum suspendisse dui, at sed, convallis sagittis mauris, vivamus augue magna, dolor nullam vehicula turpis pulvinar conubia eleifend. Id torquent quis, porttitor tortor, ligula, nibh primis sit nunc rutrum ultrices purus maximus congue, odio magna sapien blandit, in. Quam, sapien mollis enim, tempor, malesuada vel, eget pulvinar, nibh varius, blandit, lacus mattis, aliquam pulvinar vehicula ultrices, risus ante.", null, 1, 20, 4, 1 },
                    { 31, 16, new DateTime(2023, 12, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 8, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(7318), new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(7324), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(6188), 5, new DateTime(2025, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(7322), null, null, false, "Ex vestibulum pellentesque blandit porta, porttitor lectus dolor consequat aenean augue vestibulum, arcu, ullamcorper lacinia, interdum, malesuada ac, primis gravida. Vitae dictum ornare lobortis accumsan sem interdum porta vehicula tellus urna, ad facilisis odio vestibulum pellentesque erat nisi, sed, semper. At, vel, arcu eleifend, dapibus nunc facilisis litora semper urna eros, augue erat ultricies sem, quis, venenatis blandit, risus vitae.", null, 1, 21, 4, 1 },
                    { 32, 19, new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(8471), new DateTime(2023, 9, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(8468), new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(8475), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(7338), 5, new DateTime(2025, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(8473), null, null, false, "Elit viverra laoreet, lacinia eu massa, hac consequat nulla, elementum dictumst fringilla molestie proin erat, sit nulla bibendum, amet, dolor. Hendrerit ut arcu, id, tellus, ante, eget curabitur augue blandit, nec, adipiscing class tellus luctus vitae, dignissim habitasse ligula, gravida. Vivamus ad fames dignissim a praesent leo, cras torquent ante habitasse tincidunt gravida et mattis ipsum volutpat, proin suscipit ultrices.", null, 1, 22, 4, 1 },
                    { 33, 16, new DateTime(2024, 3, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 12, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(9702), new DateTime(2025, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(8488), 5, new DateTime(2026, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(9707), null, null, false, "Ultrices, metus dignissim tempor, nisi per elit et dictumst id eu ante ex, maximus nibh, tortor, quis nibh auctor bibendum. Hendrerit velit aenean venenatis ligula, arcu, tristique duis sapien elit, torquent conubia quis, congue luctus, quam tortor, libero odio, lobortis. Euismod, turpis varius non, risus morbi lobortis placerat justo eget porta purus mattis, sodales volutpat nibh, quam porta, ex, habitasse.", null, 1, 23, 4, 1 },
                    { 34, 17, new DateTime(2023, 12, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(857), new DateTime(2023, 12, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(862), new DateTime(2023, 11, 4, 15, 20, 3, 478, DateTimeKind.Local).AddTicks(9811), 5, new DateTime(2025, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(860), null, null, false, "Ipsum fermentum eros euismod, eu, litora tempor tristique proin sodales duis turpis cras pharetra praesent volutpat, odio suspendisse ligula, maximus. Volutpat, fusce nunc lacus donec amet tempus et erat quisque elementum a est quam ligula sit eu, porttitor, non ultrices. Porttitor vivamus nostra, vitae ligula neque varius convallis himenaeos interdum turpis at, cursus amet bibendum, libero erat, dui suspendisse ornare.", null, 1, 24, 4, 1 },
                    { 35, 20, new DateTime(2024, 3, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(2344), new DateTime(2023, 8, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(2341), new DateTime(2026, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(2348), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(876), 5, new DateTime(2026, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(2346), null, null, false, "Nec, varius sem, ex a, eros, imperdiet ullamcorper lobortis pellentesque ante maecenas ipsum interdum, tempus egestas consectetur accumsan pulvinar, dictum. Lectus, maximus etiam nullam orci, nisi, sit quam odio ullamcorper mi, scelerisque auctor, cursus at, lectus velit mi cras neque. Erat, purus nisi, viverra taciti nunc feugiat magna, vestibulum praesent dui, id, nec elementum scelerisque quis, commodo, ullamcorper cursus, diam.", null, 1, 25, 4, 1 },
                    { 36, 16, new DateTime(2024, 1, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(3547), new DateTime(2023, 12, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(3544), new DateTime(2024, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(3551), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(2364), 5, new DateTime(2025, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(3549), null, null, false, "Vel libero torquent ac, dui convallis nec tempus a luctus, ligula phasellus finibus aliquam vel, bibendum tempor, risus facilisis interdum. Euismod, commodo, inceptos sodales sem adipiscing magna at mauris, pharetra rhoncus, orci litora lectus rhoncus lacus blandit, molestie curabitur eget. Vestibulum praesent donec malesuada suscipit sagittis ad varius, luctus in lacinia venenatis orci porta, lectus, ultrices lacus rutrum himenaeos turpis.", null, 1, 26, 4, 1 },
                    { 37, 17, new DateTime(2024, 1, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 2, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(4757), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(3566), 5, new DateTime(2026, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(4755), null, null, false, "Iaculis tincidunt tempor, suscipit consequat nulla euismod, vestibulum, nam gravida facilisis leo, porta, sagittis fusce lacus amet, tempor sapien posuere. Porttitor, ex accumsan nullam et sagittis lacinia sed, conubia venenatis cursus, eu eros, ultrices egestas luctus, volutpat enim purus in. Luctus mattis interdum velit nibh arcu, sem leo, sagittis non, torquent lacinia integer lorem litora ac at pharetra lacus sit.", null, 1, 27, 4, 1 },
                    { 38, 19, new DateTime(2024, 5, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(4771), 5, new DateTime(2025, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(5928), null, null, false, "Quam, cursus sit nec, id, nec fringilla, gravida tellus, rhoncus, sociosqu donec facilisis posuere massa, imperdiet elementum eu, habitasse eros. Hac aenean ligula luctus, pulvinar sollicitudin eget ullamcorper commodo interdum, varius erat taciti tellus sapien rutrum conubia volutpat laoreet mauris. Vehicula luctus vel, blandit, morbi tortor, eleifend nunc praesent suscipit quis primis enim, enim ante nibh feugiat metus iaculis eu.", null, 1, 28, 4, 1 },
                    { 39, 17, new DateTime(2024, 5, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(7509), new DateTime(2024, 2, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(7505), new DateTime(2025, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(5944), 5, new DateTime(2025, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(7511), null, null, false, "Fames malesuada feugiat fringilla eu volutpat, rhoncus, nisl litora quam, dapibus sollicitudin mi fringilla, iaculis diam nulla quam tempor faucibus. Enim tempor ultrices fringilla erat, euismod, sed, leo venenatis sit nunc, odio, consectetur arcu metus ornare eleifend, tempor, volutpat purus. Integer mauris varius, phasellus non velit amet, condimentum diam massa nec erat, pretium semper tempor, pulvinar, in, nisl eget euismod.", null, 1, 29, 4, 1 },
                    { 40, 18, new DateTime(2024, 4, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 9, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(7541), 5, new DateTime(2026, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(8792), null, null, false, "Sagittis, risus dictumst eu morbi at, lobortis arcu, tortor, ac varius, ex, viverra dictum lacinia, efficitur rhoncus, ex libero inceptos. Lectus dictumst donec pellentesque pharetra justo sit luctus, nunc eget semper tristique arcu, aliquet congue iaculis rhoncus mattis pulvinar interdum. Maecenas conubia suscipit fermentum diam faucibus donec ipsum tristique luctus erat, ligula rutrum est posuere dictumst ac lectus, ultricies euismod.", null, 1, 30, 4, 1 },
                    { 41, 18, new DateTime(2024, 1, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 2, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(47), new DateTime(2025, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 11, 4, 15, 20, 3, 479, DateTimeKind.Local).AddTicks(8810), 5, new DateTime(2026, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(52), null, null, false, "Dui, hendrerit quam, erat, ac proin quisque aptent cursus, urna, non, nunc, nisi neque vestibulum, eros, nostra, habitasse luctus, diam. Bibendum, rhoncus, cursus sodales ligula, sit volutpat viverra nisi odio, augue sem, class dolor, semper enim enim, maximus eu vitae. Libero placerat blandit, eget in, imperdiet odio, enim porta vel, commodo lacinia, fermentum risus a, fringilla bibendum eleifend, dui, praesent.", null, 1, 31, 4, 1 },
                    { 42, 17, new DateTime(2024, 4, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(1208), new DateTime(2023, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(1205), new DateTime(2024, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(74), 5, new DateTime(2026, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(1210), null, null, false, "Dignissim non, tempus finibus, cras ullamcorper placerat a sagittis, feugiat tortor, mauris, consectetur porta neque purus interdum, nibh libero magna. Porttitor suspendisse pharetra imperdiet quam eros, laoreet, curabitur id ultricies taciti nulla conubia bibendum nunc, finibus, commodo dui nisi et. Varius, dui consequat lacinia, himenaeos pharetra erat, arcu placerat leo vel porta egestas integer enim, etiam nam purus erat sollicitudin.", null, 1, 32, 4, 1 },
                    { 43, 16, new DateTime(2024, 2, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 10, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(2245), new DateTime(2025, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(2252), new DateTime(2023, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(1227), 5, new DateTime(2024, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(2250), null, null, false, "Sed lectus, euismod diam nam ac nisi fringilla consectetur leo, sem dui, eros luctus, odio id, quam, et, vitae, tellus. Sit id vel, lacinia class eget dignissim fames blandit, non, amet eleifend, eleifend mattis, lorem eu suscipit ultricies semper tempor. Rutrum id eget sem porta laoreet, mattis, ac orci eros, luctus, blandit, ultricies posuere, elit placerat, porta, vestibulum vitae, ligula.", null, 1, 33, 4, 1 },
                    { 44, 16, new DateTime(2024, 4, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 12, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(2265), 5, new DateTime(2025, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(4400), null, null, false, "Litora accumsan vestibulum tortor quisque varius, quis, cras mi sollicitudin suscipit eu malesuada egestas ultricies erat, nibh fusce venenatis facilisis. Elementum convallis vivamus dictumst nisl torquent maximus amet, cursus, ultrices ex velit nibh, mattis vestibulum aenean laoreet, nec dignissim vitae. Pharetra sollicitudin vehicula rhoncus, interdum, vel, dui condimentum faucibus ex, in eros, molestie sagittis, laoreet ante, finibus quis, arcu, venenatis.", null, 1, 34, 4, 1 },
                    { 45, 20, new DateTime(2024, 4, 4, 15, 20, 3, 481, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 10, 4, 15, 20, 3, 481, DateTimeKind.Local).AddTicks(9877), new DateTime(2026, 11, 4, 15, 20, 3, 481, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 11, 4, 15, 20, 3, 480, DateTimeKind.Local).AddTicks(4482), 5, new DateTime(2025, 11, 4, 15, 20, 3, 481, DateTimeKind.Local).AddTicks(9910), null, null, false, "Odio pulvinar sem, per dignissim malesuada porttitor ultrices, vel pharetra eu vitae, nibh eu, at suscipit finibus feugiat urna, litora. Ultrices, vestibulum vel, euismod, tellus, commodo, feugiat sagittis, mauris, lorem ut pellentesque elementum non urna, etiam adipiscing torquent magna, enim. Dui lacinia eu, praesent lacus ac dolor, auctor condimentum torquent eros hendrerit donec auctor, lectus eleifend, augue non, urna tellus.", null, 1, 35, 4, 1 },
                    { 46, 22, new DateTime(2023, 12, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 1, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(5560), new DateTime(2026, 11, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 11, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(4547), 5, new DateTime(2026, 11, 4, 15, 20, 3, 867, DateTimeKind.Local).AddTicks(5567), null, null, false, "Malesuada ad et, aliquet tristique maximus aenean porta, augue turpis blandit, odio, tincidunt finibus, dictum lacinia, cursus facilisis euismod hac. Lobortis libero nisi, id, ullamcorper id in tellus, sed eleifend aliquam sociosqu bibendum, pulvinar aliquet inceptos donec finibus, at eget. Quam sed scelerisque torquent ad bibendum ultricies iaculis tortor, tempus taciti curabitur aptent ultrices, malesuada luctus aliquam commodo, vestibulum et.", null, null, 36, 3, null },
                    { 47, 23, new DateTime(2024, 3, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(8562), new DateTime(2023, 12, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(8554), new DateTime(2025, 11, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 11, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(7776), 5, new DateTime(2024, 11, 4, 15, 20, 3, 938, DateTimeKind.Local).AddTicks(8564), null, null, false, "Vel, dui, auctor ullamcorper tempor consectetur commodo neque, tellus tristique massa vulputate semper hac lorem, pharetra molestie nisi, luctus, vitae. Tempus ultrices tristique dolor rhoncus, elit ultrices, auctor vestibulum commodo, orci, leo, maecenas dictum ultricies interdum, placerat dui nec, lorem. Interdum, sapien accumsan consequat proin aliquet dapibus eros eu conubia massa, a, rutrum vivamus rhoncus, platea nisi, lacinia, per purus.", null, null, 37, 3, null },
                    { 48, 24, new DateTime(2021, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(2482), new DateTime(2019, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(1528), 5, new DateTime(2022, 11, 4, 15, 20, 4, 11, DateTimeKind.Local).AddTicks(2485), null, null, false, "Erat, non integer quam, risus imperdiet consectetur quisque blandit consequat pretium adipiscing nisl interdum placerat, odio leo fames fringilla, cras. Varius nisl elit, enim, massa, fermentum faucibus lectus, vitae purus posuere dictumst cursus dolor maximus dignissim elementum commodo nulla, sem. Sit porta, tellus, neque accumsan dapibus integer faucibus consectetur gravida efficitur amet, tortor, lectus elementum porta viverra bibendum, massa, justo.", null, 1, 38, 6, 1 },
                    { 49, 25, new DateTime(2020, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(4424), new DateTime(2019, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(4419), new DateTime(2023, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(3801), 5, new DateTime(2022, 11, 4, 15, 20, 4, 83, DateTimeKind.Local).AddTicks(4426), null, null, false, "Semper venenatis dignissim iaculis auctor, sem hendrerit dui integer pulvinar, commodo, ultrices rhoncus, a, blandit, elit faucibus sodales praesent placerat. Eu tortor praesent nisl velit ligula, id vestibulum vehicula vitae, ut maecenas porta sagittis, faucibus posuere rhoncus, ullamcorper erat, integer. Himenaeos nisi dolor, lacinia, eleifend fermentum tellus ac felis porta, auctor, scelerisque ultrices bibendum, tincidunt amet feugiat etiam hendrerit ex.", null, 1, 39, 6, 1 },
                    { 50, 26, new DateTime(2021, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8191), new DateTime(2019, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8187), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8195), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(7439), 5, new DateTime(2022, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8193), null, null, false, "Pellentesque convallis arcu, molestie sollicitudin fringilla, eleifend porta in, ornare lorem massa nisi neque, vulputate aliquet maecenas lectus et risus. Nisi vestibulum, phasellus luctus dapibus proin adipiscing massa, nullam quis, aliquet ligula, sem, amet, erat, ipsum rhoncus lacus mi, amet. Habitasse volutpat condimentum dolor phasellus efficitur pretium augue neque, mattis tristique suscipit bibendum, at nunc, curabitur elit maecenas orci hendrerit.", null, 1, 40, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ServiceRequests",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "InspectionRecordFilePath", "IpId", "IsDelegated", "IsDeleted", "Quantity", "RequestId", "SaleApprovalId", "ServiceId", "Status", "TechExecutionId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8218), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8218), null, null, false, false, 1, 6, null, 2, 0, null, null, null },
                    { 2, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8231), null, null, false, false, 1, 6, null, 3, 0, null, null, null },
                    { 3, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8237), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8238), null, null, false, false, 4, 6, null, 2, 0, null, null, null },
                    { 4, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8245), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8245), null, null, false, false, 1, 7, null, 1, 0, null, null, null },
                    { 5, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8258), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8258), null, null, false, false, 2, 7, null, 3, 0, null, null, null },
                    { 6, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8267), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8267), null, null, false, false, 5, 7, null, 3, 0, null, null, null },
                    { 7, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8273), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8274), null, null, false, false, 2, 7, null, 3, 0, null, null, null },
                    { 8, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8279), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8280), null, null, false, false, 2, 7, null, 3, 0, null, null, null },
                    { 9, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8287), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8288), null, null, false, false, 2, 8, null, 3, 0, null, null, null },
                    { 10, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8295), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8296), null, null, false, false, 4, 9, null, 1, 0, null, null, null },
                    { 11, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8302), null, null, false, false, 2, 9, null, 1, 0, null, null, null },
                    { 12, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8309), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8309), null, null, false, false, 4, 10, null, 3, 0, null, null, null },
                    { 13, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8315), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8315), null, null, false, false, 1, 10, null, 1, 0, null, null, null },
                    { 14, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8324), null, null, false, false, 5, 11, null, 1, 0, null, null, null },
                    { 15, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8333), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8333), null, null, false, false, 4, 12, null, 3, 0, null, null, null },
                    { 16, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8341), null, null, false, false, 3, 13, 1, 2, 1, null, null, null },
                    { 17, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8349), null, null, false, false, 1, 13, null, 2, 0, null, null, null },
                    { 18, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8357), null, null, false, false, 1, 14, null, 3, 2, null, null, null },
                    { 19, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8365), null, null, false, false, 4, 14, null, 2, 0, null, null, null },
                    { 20, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8372), null, null, false, false, 5, 14, null, 2, 0, null, null, null },
                    { 21, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8384), null, null, false, false, 3, 14, 1, 3, 1, null, null, null },
                    { 22, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8391), null, null, false, false, 5, 14, null, 2, 2, null, null, null },
                    { 23, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8399), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8400), null, null, false, false, 4, 15, null, 2, 2, null, null, null },
                    { 24, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8406), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8407), null, null, false, false, 2, 15, null, 3, 0, null, null, null },
                    { 25, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8416), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8416), null, null, false, false, 4, 16, null, 3, 2, null, null, null },
                    { 26, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8425), null, null, false, false, 2, 16, null, 3, 0, null, null, null },
                    { 27, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8432), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8433), null, null, false, false, 1, 16, null, 3, 0, null, null, null },
                    { 28, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8440), null, null, false, false, 2, 16, null, 2, 0, null, null, null },
                    { 29, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8448), null, null, false, false, 4, 17, null, 2, 2, null, null, null },
                    { 30, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8455), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8455), null, null, false, false, 5, 17, null, 3, 2, null, null, null },
                    { 31, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8463), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8463), null, null, false, false, 1, 18, null, 2, 0, null, null, null },
                    { 32, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8470), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8470), null, null, false, false, 1, 18, 1, 2, 1, null, null, null },
                    { 33, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8477), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8478), null, null, false, false, 1, 18, 1, 2, 3, 1, null, null },
                    { 34, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8486), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8486), null, null, false, false, 5, 19, 1, 1, 3, 1, null, null },
                    { 35, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8494), null, null, false, false, 2, 19, null, 1, 0, null, null, null },
                    { 36, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8506), null, null, false, false, 5, 19, 1, 2, 1, null, null, null },
                    { 37, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8514), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8514), null, null, false, false, 5, 20, 1, 1, 3, 1, null, null },
                    { 38, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8521), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8522), null, null, false, false, 1, 20, null, 3, 2, null, null, null },
                    { 39, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8528), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8529), null, null, false, false, 5, 20, 1, 1, 3, 1, null, null },
                    { 40, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8537), null, null, false, false, 3, 21, null, 3, 2, null, null, null },
                    { 41, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8544), null, null, false, false, 3, 21, null, 3, 2, null, null, null },
                    { 42, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8552), null, null, false, false, 5, 22, 1, 2, 1, null, null, null },
                    { 43, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8560), null, null, false, false, 4, 22, null, 1, 2, null, null, null },
                    { 44, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8567), null, null, false, false, 4, 22, 1, 3, 3, 1, null, null },
                    { 45, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8575), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8575), null, null, false, false, 4, 23, 1, 3, 1, null, null, null },
                    { 46, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8582), null, null, false, false, 2, 23, 1, 1, 3, 1, null, null },
                    { 47, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8590), null, null, false, false, 4, 23, null, 1, 2, null, null, null },
                    { 48, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8597), null, null, false, false, 1, 23, null, 1, 2, null, null, null },
                    { 49, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8606), null, null, false, false, 5, 24, null, 1, 0, null, null, null },
                    { 50, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8612), null, null, false, false, 1, 24, null, 1, 0, null, null, null },
                    { 51, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8619), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8681), null, null, false, false, 5, 24, null, 1, 0, null, null, null },
                    { 52, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8691), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8692), null, null, false, false, 4, 24, 1, 1, 1, null, null, null },
                    { 53, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8707), null, null, false, false, 5, 25, null, 2, 0, null, null, null },
                    { 54, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8714), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8715), null, null, false, false, 3, 25, 1, 3, 3, 1, null, null },
                    { 55, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8722), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8723), null, null, false, false, 4, 26, null, 3, 2, null, null, null },
                    { 56, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8730), null, null, false, false, 3, 26, 1, 1, 1, null, null, null },
                    { 57, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8737), null, null, false, false, 1, 26, 1, 3, 3, 1, null, null },
                    { 58, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8745), null, null, false, false, 5, 26, 1, 3, 3, 1, null, null },
                    { 59, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8752), null, null, false, false, 1, 26, null, 1, 0, null, null, null },
                    { 60, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8759), null, null, false, false, 4, 26, 1, 3, 1, null, null, null },
                    { 61, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8768), null, null, false, false, 4, 27, 1, 1, 1, null, null, null },
                    { 62, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8776), null, null, false, false, 5, 28, 1, 1, 3, 1, null, null },
                    { 63, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8784), null, null, false, false, 3, 29, 1, 2, 3, 1, null, null },
                    { 64, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8791), null, null, false, false, 2, 29, 1, 1, 3, 1, null, null },
                    { 65, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8798), null, null, false, false, 5, 29, 1, 3, 1, null, null, null },
                    { 66, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8807), null, null, false, false, 2, 30, null, 3, 0, null, null, null },
                    { 67, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8820), null, null, false, false, 4, 30, 1, 2, 1, null, null, null },
                    { 68, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8828), null, null, false, false, 1, 30, 1, 3, 1, null, null, null },
                    { 69, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8836), null, null, false, false, 2, 31, 1, 1, 3, 1, null, null },
                    { 70, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8844), null, null, false, false, 1, 31, 1, 1, 3, 1, null, null },
                    { 71, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8851), null, null, false, false, 3, 31, 1, 3, 1, null, null, null },
                    { 72, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8860), null, null, false, false, 1, 32, 1, 3, 3, 1, null, null },
                    { 73, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8867), null, null, false, false, 1, 32, null, 2, 0, null, null, null },
                    { 74, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8874), null, null, false, false, 1, 32, 1, 1, 1, null, null, null },
                    { 75, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8882), null, null, false, false, 3, 33, 1, 3, 3, 1, null, null },
                    { 76, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8890), null, null, false, false, 2, 33, 1, 1, 3, 1, null, null },
                    { 77, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8898), null, null, false, false, 1, 34, null, 3, 0, null, null, null },
                    { 78, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8906), null, null, false, false, 5, 35, 1, 2, 1, null, null, null },
                    { 79, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8913), null, null, false, false, 4, 35, null, 1, 0, null, null, null },
                    { 80, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8921), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8921), null, null, false, false, 2, 35, null, 1, 0, null, null, null },
                    { 81, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8930), null, null, false, false, 5, 36, 1, 1, 1, null, null, null },
                    { 82, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8937), null, null, false, false, 5, 36, null, 1, 2, null, null, null },
                    { 83, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8949), null, null, false, false, 3, 36, 1, 3, 3, 1, null, null },
                    { 84, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8958), null, null, false, false, 4, 37, null, 3, 2, null, null, null },
                    { 85, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8965), null, null, false, false, 3, 37, 1, 3, 1, null, null, null },
                    { 86, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8972), null, null, false, false, 4, 37, 1, 1, 1, null, null, null },
                    { 87, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8979), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8979), null, null, false, false, 3, 37, 1, 1, 3, 1, null, null },
                    { 88, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8987), null, null, false, false, 4, 38, null, 1, 2, null, null, null },
                    { 89, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(8995), null, null, false, false, 2, 39, null, 1, 0, null, null, null },
                    { 90, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9002), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9002), null, null, false, false, 2, 39, null, 2, 2, null, null, null },
                    { 91, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9009), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9010), null, null, false, false, 4, 39, null, 2, 0, null, null, null },
                    { 92, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9018), null, null, false, false, 1, 40, null, 2, 0, null, null, null },
                    { 93, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9025), null, null, false, false, 3, 40, null, 3, 0, null, null, null },
                    { 94, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9032), null, null, false, false, 5, 40, 1, 3, 3, 1, null, null },
                    { 95, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9041), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9041), null, null, false, false, 2, 41, 1, 3, 1, null, null, null },
                    { 96, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9048), null, null, false, false, 5, 41, null, 1, 2, null, null, null },
                    { 97, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9057), null, null, false, false, 4, 42, null, 3, 0, null, null, null },
                    { 98, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9064), null, null, false, false, 5, 42, null, 3, 0, null, null, null },
                    { 99, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9071), null, null, false, false, 5, 42, null, 1, 0, null, null, null },
                    { 100, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9083), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9083), null, null, false, false, 4, 42, null, 2, 0, null, null, null },
                    { 101, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9091), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9091), null, null, false, false, 3, 43, null, 2, 2, null, null, null },
                    { 102, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9098), null, null, false, false, 5, 43, null, 3, 2, null, null, null },
                    { 103, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9105), null, null, false, false, 4, 43, 1, 3, 1, null, null, null },
                    { 104, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9113), null, null, false, false, 1, 43, 1, 2, 3, 1, null, null },
                    { 105, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9120), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9120), null, null, false, false, 3, 43, null, 1, 0, null, null, null },
                    { 106, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9129), null, null, false, false, 1, 44, null, 2, 0, null, null, null },
                    { 107, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9135), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9136), null, null, false, false, 5, 44, 1, 1, 3, 1, null, null },
                    { 108, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9142), null, null, false, false, 5, 44, 1, 1, 1, null, null, null },
                    { 109, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9149), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9150), null, null, false, false, 2, 44, null, 1, 2, null, null, null },
                    { 110, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9158), null, null, false, false, 2, 45, 1, 3, 1, null, null, null },
                    { 111, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9165), null, null, false, false, 1, 45, 1, 2, 1, null, null, null },
                    { 112, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9172), null, null, false, false, 5, 45, null, 3, 2, null, null, null },
                    { 113, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9179), null, null, false, false, 1, 45, null, 2, 2, null, null, null },
                    { 114, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9187), null, null, false, false, 4, 46, null, 3, 2, null, null, null },
                    { 115, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9193), null, null, false, false, 4, 46, null, 2, 2, null, null, null },
                    { 116, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9204), null, null, false, false, 3, 46, null, 1, 2, null, null, null },
                    { 117, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9210), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9211), null, null, false, false, 3, 46, null, 2, 2, null, null, null },
                    { 118, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9217), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9217), null, null, false, false, 1, 47, null, 1, 2, null, null, null },
                    { 119, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9223), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9224), null, null, false, false, 3, 47, null, 1, 2, null, null, null },
                    { 120, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9232), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9232), null, null, false, false, 4, 48, null, 2, 2, null, null, null },
                    { 121, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9242), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9242), null, null, false, false, 1, 49, 1, 3, 3, 1, null, null },
                    { 122, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9249), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9250), null, null, false, false, 2, 49, 1, 3, 3, 1, null, null },
                    { 123, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9256), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9257), null, null, false, false, 4, 49, null, 1, 2, null, null, null },
                    { 124, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9265), null, null, false, false, 5, 50, null, 2, 0, null, null, null },
                    { 125, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9271), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9272), null, null, false, false, 3, 50, null, 2, 2, null, null, null },
                    { 126, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9279), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9279), null, null, false, false, 5, 50, 1, 1, 1, null, null, null },
                    { 127, new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9286), new DateTime(2023, 11, 4, 15, 20, 4, 153, DateTimeKind.Local).AddTicks(9286), null, null, false, false, 5, 50, null, 3, 0, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_Name",
                table: "Areas",
                column: "Name",
                unique: true);

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
                name: "IX_IpAssignments_IpId",
                table: "IpAssignments",
                column: "IpId");

            migrationBuilder.CreateIndex(
                name: "IX_IpAssignments_ServerId",
                table: "IpAssignments",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ips_Address_NetworkId",
                table: "Ips",
                columns: new[] { "Address", "NetworkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ips_NetworkId",
                table: "Ips",
                column: "NetworkId");

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
                name: "IX_RequestExtendHistories_RequestId",
                table: "RequestExtendHistories",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SaleApprovalId",
                table: "Requests",
                column: "SaleApprovalId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServerId",
                table: "Requests",
                column: "ServerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TechExecutionId",
                table: "Requests",
                column: "TechExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleApprovals_SaleId",
                table: "SaleApprovals",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servers_SerialNumber",
                table: "Servers",
                column: "SerialNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_IpId",
                table: "ServiceRequests",
                column: "IpId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_RequestId",
                table: "ServiceRequests",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_SaleApprovalId",
                table: "ServiceRequests",
                column: "SaleApprovalId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ServiceId",
                table: "ServiceRequests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_TechExecutionId",
                table: "ServiceRequests",
                column: "TechExecutionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId",
                table: "ServiceRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId1",
                table: "ServiceRequests",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_TechExecutions_TechId",
                table: "TechExecutions",
                column: "TechId");
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
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "RequestExtendHistories");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SaleApprovals");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "TechExecutions");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
