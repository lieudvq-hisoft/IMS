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
                    { 1, 8, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2349), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2356), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2357), false, "B", 5 }
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
                    { new Guid("050bac5e-7478-4470-b554-030f89b045f4"), 0, "Laoreet/Mi, Quam ultrices varius", "5510f9fe-679f-4312-9575-c710b0978d27", 0, "lacinia@finibus.com", true, "Elit pharetra aliquet", false, false, null, "imperdiet@leo.com", "customer19", "AQAAAAIAAYagAAAAEPFSq6E9XLkwscefAxWdHze/mxnGkFomcji0dbacqAQJn9R6HBEzSkM/SBOPwnLnOQ==", "6633894255", false, "", false, "customer19" },
                    { new Guid("15da2322-bdde-4453-9e41-4941be4e92a7"), 0, "Commodo/Maecenas, Duis mauris nisi", "d969f2fb-f669-4b24-81df-d3a732f651f3", 0, "facilisis@consectetur.com", true, "Vitae pretium nisi", false, false, null, "ultrices@libero.com", "customer6", "AQAAAAIAAYagAAAAEOYwu67uZiRiEUMDR8vSpamdJcIM1r66TwK2kGBiRvOzzQ3QioOC2LgeZp/FW/tbEg==", "7609709471", false, "", false, "customer6" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "16fbdd6e-cd9d-415d-aabb-4d55f622ada6", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEL58YEGWCpcZWABp9qKT3Fld0ckuOrBSxPyIrfIfnZK6bdLm3Tv+vf9XWTDzH823cA==", "0000000003", false, "", false, "sale" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "9b4870f9-5dd1-48ee-bb31-14944225429c", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEO2LwX1ZFcEP2QravRFZcbr5fpNMoJgqZXi8vyHrmfPuhqtz1mJo0V7dyj/D6+nEhQ==", "0000000005", false, "", false, "admin" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "4a0d5910-a210-4c1b-b100-eb3b319dc0f3", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEEzMT2rqa8S9ceR6Za4Wow/YBCwBROfpvOzd3PsdpkFBkdnPIuY1KslcigaUGtn84Q==", "0000000004", false, "", false, "manager" },
                    { new Guid("38be337d-262a-4b0b-9d21-fabc2649621f"), 0, "Magna/Neque, Maecenas diam vitae", "594ca9e2-78b6-4643-8f19-e51f844050d3", 0, "suspendisse@magna.com", true, "Lacinia finibus porttitor", false, false, null, "molestie@habitasse.com", "customer10", "AQAAAAIAAYagAAAAEMqzVBYny+a09pDuEuaOO46IeIOMdQM2d5tAILRv3DNhpnRNIFeMeIZ+lcqq1arAXw==", "4498209289", false, "", false, "customer10" },
                    { new Guid("3ec47dab-1581-43f2-b8a2-199f8925d388"), 0, "Lorem/Orci, Iaculis fringilla nam", "ff318de8-209a-46f5-8169-8c175f833921", 0, "purus@luctus.com", true, "Ultrices lorem morbi", false, false, null, "at@urna.com", "customer17", "AQAAAAIAAYagAAAAEDLpXbogOLbPrpp4/V+nawwq5cYUZs9LuuIEaSfQSoA4BeXkNvo5LlDIEp4kRyg0Hg==", "7448762750", false, "", false, "customer17" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "a294d258-3524-4fa9-8ac0-1b017d98a7e9", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAENApUw9tO273bj9rL0OBxwljwQvSo5ZWcVamDrbJ2398uks9q4TnBtcmhPANZ25ILA==", "0000000002", false, "", false, "tech" },
                    { new Guid("4a670894-c33f-43f3-965a-026cf56ca0d2"), 0, "Non/Vehicula, Porttitor scelerisque vulputate", "03b082d4-e834-4d6d-95be-ef306fad880c", 0, "tellus@ipsum.com", true, "Curabitur porttitor rhoncus", false, false, null, "laoreet@sem.com", "customer11", "AQAAAAIAAYagAAAAEBMzFBO4kK3xPbuzstEyUXbKpf1QuHtwYvqDy8xagDSceBMgQbejVFTbFeMua3Dl+g==", "1203159026", false, "", false, "customer11" },
                    { new Guid("4e5d516f-e387-44e6-b067-e69fd5083a3f"), 0, "Eleifend/Feugiat, Ante placerat himenaeos", "dce2872b-9c68-4e36-96d3-52213558b92c", 0, "non@nullam.com", true, "Morbi sed vulputate", false, false, null, "tristique@neque.com", "customer8", "AQAAAAIAAYagAAAAEM5alwTj0FpdbuB3OYsSLNSSWVYhPiqQosLAGhq1JPW0cwPq9PNotph1P25DZW+JyQ==", "6230691627", false, "", false, "customer8" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "3f245821-d445-4a70-8c8e-f0385795b2d4", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEOdqM6WjvtU/0+30PT25AiMoplRkfHwJUDjaPvuBeZSpiOxELE7S6/MicP9iCRZR5g==", "0000000001", false, "", false, "super" },
                    { new Guid("5acf4ab6-d7a7-41d7-9f63-8b6c78de6881"), 0, "Maximus/Orci, Leo nullam laoreet", "49293426-edff-4c2a-ad90-0a44da03336f", 0, "luctus@bibendum.com", true, "Eleifend et ultricies", false, false, null, "nullam@massa.com", "customer4", "AQAAAAIAAYagAAAAELsve77RRosYO4S9bzOI9k1YQg7V6XzbkruWG8U4uV6N2l2j7ACuyCksYPvtdEldmA==", "5458081354", false, "", false, "customer4" },
                    { new Guid("76424aae-f6e6-41b1-bb52-993d6eb1e364"), 0, "Cursus/Dolor, Nunc metus blandit", "69926ec2-4073-4328-b730-7a7f1b1c7524", 0, "ante@dictum.com", true, "Ullamcorper blandit himenaeos", false, false, null, "placerat@euismod.com", "customer14", "AQAAAAIAAYagAAAAED113rmxpgqFFSLmtrLgzH6jfs528sz/BFGcLi1i2FDB41k70vihGV5dNJzT68g4RA==", "1493631831", false, "", false, "customer14" },
                    { new Guid("78e12599-387c-413f-9734-5628b8f9d6dd"), 0, "Ac/Ac, Mauris pharetra mauris", "d9e051ca-7343-447c-bd38-e13bf5dddf3b", 0, "consectetur@sagittis.com", true, "Eros tempor duis", false, false, null, "fusce@orci.com", "customer21", "AQAAAAIAAYagAAAAEHbKKyLZi0zzq9pSf0fqvcpDXGHslYnRaVmUcutnJoQluC4VwtRIabj+K6kc09DjEw==", "4564308732", false, "", false, "customer21" },
                    { new Guid("7d1184ef-5c0a-4c28-9118-2f758247c73b"), 0, "Et/Mi, Eget cras in", "8183a2e6-b951-480e-84f7-ae3377219bfb", 0, "euismod@ad.com", true, "Consectetur non sed", false, false, null, "dictum@luctus.com", "customer23", "AQAAAAIAAYagAAAAEGSskoQyICzVYgEg/2E2cYw+kv/iKPdrxuWjBMsiXpVP6Nz8MGQyEBsPsugShgd4YQ==", "6944711489", false, "", false, "customer23" },
                    { new Guid("888a4352-49de-4326-a9fe-c535b2071d46"), 0, "Ac/Feugiat, Platea aptent pulvinar", "ae478ee4-25eb-44b5-8302-90bf4fe0a6a0", 0, "elit@vitae.com", true, "Magna phasellus enim", false, false, null, "ex@velit.com", "customer13", "AQAAAAIAAYagAAAAEC/PZv0zSGck23KW05xCtkA2bCoN9NEHmRtwUL0oWhPk5GN/qOtAWkCHl+ZdocDTLQ==", "6303857957", false, "", false, "customer13" },
                    { new Guid("95f6f604-2234-4e98-8ddf-316a48c3b7c3"), 0, "Accumsan/Dolor, Lobortis tortor et", "02a82946-6b5e-48b9-9c1b-bb76ba129708", 0, "faucibus@blandit.com", true, "Elementum laoreet aptent", false, false, null, "lacinia@porttitor.com", "customer22", "AQAAAAIAAYagAAAAEC7yKOx7bohmvEq/VsVftY6+bjy3pkpr4aq1U6SsZ5GvxufCG8zRNVmuKt5Q9QJRtQ==", "3951288780", false, "", false, "customer22" },
                    { new Guid("9b6bcac3-7fc6-4762-8066-cfee2118daf9"), 0, "Sagittis/Euismod, Dictum ut eros", "05a70e6f-3dcf-4413-9e21-f266c4919aa1", 0, "blandit@dui.com", true, "Urna non est", false, false, null, "luctus@neque.com", "customer12", "AQAAAAIAAYagAAAAEPpS/Hnror07Qu1L1aFharcLJW2OMBVoUSNo8nbbsGMbifwx4y5FbUnfLPsM9WLrEw==", "6225131446", false, "", false, "customer12" },
                    { new Guid("9b794573-4f82-41c6-b9f9-bdd0070d2793"), 0, "Elit/Ultricies, Facilisis fames semper", "0962a589-104e-4b78-bf4d-cd236a33d2a8", 0, "at@consectetur.com", true, "Sociosqu blandit magna", false, false, null, "eu@nisi.com", "customer18", "AQAAAAIAAYagAAAAECBA7zHjGXRuJzwDy0kAbJcjezD8fSWX1EmM5jNBFdta2q9KNPgvwvli00J5o/kSSA==", "4014253301", false, "", false, "customer18" },
                    { new Guid("9b7c7772-55dd-4269-9bc0-1d4340584a12"), 0, "Fermentum/Placerat, Iaculis nec fusce", "ae447acb-c0a2-4931-b46b-8424db949420", 0, "nunc@sit.com", true, "Adipiscing vel fringilla", false, false, null, "curabitur@porttitor.com", "customer3", "AQAAAAIAAYagAAAAEAfj2ON6bTXYefLVFLICsDiCnyycJknfasHofKP4CDRH79uagEqapOOKdai58joB9Q==", "8663660273", false, "", false, "customer3" },
                    { new Guid("9fb1c9b5-7ffe-4f2f-8d15-918362aa4a98"), 0, "Eu/Adipiscing, Aenean feugiat nostra", "6832c755-f064-4b9e-9192-192035b1958d", 0, "integer@nulla.com", true, "Venenatis non finibus", false, false, null, "egestas@at.com", "customer5", "AQAAAAIAAYagAAAAEEGu5RXjwbC9kTGpZ+5zFu/FVFvN4PtiRZ6v7tKRZYa7RYmCdJxo8rRnJ3UBH3C6bw==", "5320631238", false, "", false, "customer5" },
                    { new Guid("ab3727ef-50c9-4740-8a78-a765b6202507"), 0, "Purus/Molestie, Dui interdum aliquam", "8203b2a0-057e-456c-9e3d-c0875321a25c", 0, "feugiat@tellus.com", true, "Malesuada libero neque", false, false, null, "aliquet@erat.com", "customer15", "AQAAAAIAAYagAAAAEIVXL2i7/c78rSoETFliNlN9wMFOXyP+pQRHO0jOPozN6RzPzC3yCefXca+/jjaRNg==", "8181065000", false, "", false, "customer15" },
                    { new Guid("b85ce419-930f-49c2-967b-ae0b48bd141e"), 0, "Ligula/Inceptos, Magna at cursus", "57f1d812-6956-48c7-a387-cef6f8e7ba9d", 0, "porta@eleifend.com", true, "Interdum sagittis libero", false, false, null, "leo@auctor.com", "customer2", "AQAAAAIAAYagAAAAEBrtann8Wm7z4bGhBfoT24N6GMW9noLtCDBi8hu+KnbO/0vyye3XxFKtx5RD6eZHYQ==", "3917712989", false, "", false, "customer2" },
                    { new Guid("bb2207a4-4d8d-402a-996d-650399f0332d"), 0, "Leo/Vitae, Duis ac quis", "e7b8c831-732c-45dd-99ba-a5a5e3d6dd48", 0, "quis@viverra.com", true, "Feugiat sit porta", false, false, null, "enim@ut.com", "customer16", "AQAAAAIAAYagAAAAEFAPfKHm5ao/UW7K8+l1lLtxZW7RDRQOdJaQMDzw5PUYpizTClRlgH5/BiS8ALzaxw==", "6670461622", false, "", false, "customer16" },
                    { new Guid("c5631b55-54e4-4e12-99e3-1c4fe93b5ce9"), 0, "Tempus/Et, Duis tristique maecenas", "edd45c87-8b92-4a87-a969-ee55a6f49c5b", 0, "ac@quisque.com", true, "Nec blandit faucibus", false, false, null, "nisl@nibh.com", "customer25", "AQAAAAIAAYagAAAAEMbD9oyonqvPUXru48pi18RLU0wfYPQzrU5MVSxRQdLSXFKKebxIbL79Yg9LD3a+bw==", "1394470313", false, "", false, "customer25" },
                    { new Guid("cf6b86d4-676e-41d7-a7fd-6dfd57e96ad5"), 0, "Pulvinar/Ultricies, Mauris non vivamus", "dec24ee0-820a-45d2-aa96-717a10d8bb53", 0, "magna@commodo.com", true, "Leo aliquet ex", false, false, null, "platea@nibh.com", "customer7", "AQAAAAIAAYagAAAAEMxsERDPSmSvwaX9M3/kivk0uZiogjmpWpTXo6DLDd+cmVAqE8htRunD/BjXCQPqrg==", "6601167796", false, "", false, "customer7" },
                    { new Guid("d09e6a57-029a-442a-92d1-4f589bc3b611"), 0, "Duis/Scelerisque, Odio eleifend velit", "2d943b16-d49d-4cc5-924c-cb540da8ae64", 0, "id@maximus.com", true, "A mollis iaculis", false, false, null, "eros@venenatis.com", "customer9", "AQAAAAIAAYagAAAAED2abPiZ3AtHlBdtXKosxfdICSaLOyL6/p3Uay1PSKQ5WLJW6cF5YL/oB3C3aQ84SQ==", "9285801532", false, "", false, "customer9" },
                    { new Guid("dccdca68-3d0d-420b-bb17-264dc781f213"), 0, "Massa/Purus, Pulvinar mollis enim", "10be9dcc-acdf-41ac-8c5b-7fa6a58fc008", 0, "odio@scelerisque.com", true, "Fringilla nostra bibendum", false, false, null, "dapibus@massa.com", "customer24", "AQAAAAIAAYagAAAAEHQDgtyXuj5EhE7fHeANrvSVGz6w9ibrqMb5ER9Olk9WIqs4MjNeEkFF7+GQh+mXJQ==", "7981278669", false, "", false, "customer24" },
                    { new Guid("df924a58-a334-45eb-9ae6-eb57518160ad"), 0, "Scelerisque/Tellus, Mattis interdum felis", "a081c9f7-fc56-4e8f-b85b-e7c10aab6023", 0, "fusce@vehicula.com", true, "Proin elit sit", false, false, null, "sodales@porta.com", "customer1", "AQAAAAIAAYagAAAAEIRIDd2jDnABKLZ/kYLHHCnjiWk4DaAQKUPG7WCoIyVxR3DknlsJPbz0wYzANzXRdQ==", "2564624937", false, "", false, "customer1" },
                    { new Guid("fe338f5f-1a9e-406e-a7c0-4301f2ecf3b2"), 0, "Lobortis/Neque, Eleifend nibh litora", "b81f1351-19a0-4803-9de1-5eeff24c364b", 0, "aptent@ex.com", true, "Eros erat tortor", false, false, null, "imperdiet@platea.com", "customer20", "AQAAAAIAAYagAAAAEAPII3mwLazYOyAPsfMDqy+zaEpcMc9zTcEoRq2WQh+DFw/LiCod5+p9lHNcwVnFOg==", "3467731646", false, "", false, "customer20" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1864), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1867), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1910), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1910), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1915), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1915), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1919), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1919), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1923), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1923), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 309, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1965), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1965), false, 5, "Hub" },
                    { 2, 0, 0, 348, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1983), false, 9, "Hub" },
                    { 3, 0, 0, 251, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2030), false, 6, "Hub" },
                    { 4, 0, 0, 281, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2035), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2036), false, 5, "Hub" },
                    { 5, 0, 0, 265, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2041), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2041), false, 3, "Hub" },
                    { 6, 0, 0, 401, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2048), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2049), false, 9, "Hub" },
                    { 7, 0, 0, 268, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2053), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2054), false, 5, "Hub" },
                    { 8, 0, 0, 351, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2059), false, 10, "Hub" },
                    { 9, 0, 0, 205, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2064), false, 3, "Hub" },
                    { 10, 0, 0, 354, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2070), false, 8, "Hub" },
                    { 11, 0, 0, 418, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2075), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2075), false, 3, "Server" },
                    { 12, 0, 0, 363, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2080), false, 8, "Server" },
                    { 13, 0, 0, 277, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2085), false, 9, "Server" },
                    { 14, 0, 0, 240, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2091), false, 2, "Server" },
                    { 15, 0, 0, 469, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2095), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2096), false, 10, "Server" },
                    { 16, 0, 0, 461, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2101), false, 10, "Server" },
                    { 17, 0, 0, 250, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2106), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2106), false, 4, "Server" },
                    { 18, 0, 0, 234, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2112), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2112), false, 2, "Server" },
                    { 19, 0, 0, 323, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2117), false, 6, "Server" },
                    { 20, 0, 0, 372, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2122), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2122), false, 6, "Server" },
                    { 21, 0, 0, 241, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2127), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2127), false, 6, "Server" },
                    { 22, 0, 0, 331, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2132), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2133), false, 6, "Server" },
                    { 23, 0, 0, 466, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2137), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2138), false, 3, "Server" },
                    { 24, 0, 0, 318, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2175), false, 9, "Server" },
                    { 25, 0, 0, 368, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2179), false, 3, "Server" },
                    { 26, 0, 0, 390, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2184), false, 2, "Server" },
                    { 27, 0, 0, 319, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2189), false, 7, "Server" },
                    { 28, 0, 0, 260, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2194), false, 6, "Server" },
                    { 29, 0, 0, 418, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2199), false, 4, "Server" },
                    { 30, 0, 0, 318, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2204), false, 4, "Server" },
                    { 31, 0, 0, 381, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2209), false, 7, "Server" },
                    { 32, 0, 0, 382, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2214), false, 8, "Server" },
                    { 33, 0, 0, 224, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2219), false, 9, "Server" },
                    { 34, 0, 0, 268, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2225), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2225), false, 5, "Server" },
                    { 35, 0, 0, 208, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2230), false, 3, "Server" },
                    { 36, 0, 0, 410, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2235), false, 2, "Server" },
                    { 37, 0, 0, 459, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2240), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2240), false, 3, "Server" },
                    { 38, 0, 0, 297, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2245), false, 9, "Server" },
                    { 39, 0, 0, 392, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2250), false, 4, "Server" },
                    { 40, 0, 0, 287, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2255), false, 5, "Server" },
                    { 41, 0, 0, 267, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2260), false, 9, "Server" },
                    { 42, 0, 0, 239, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2265), false, 2, "Server" },
                    { 43, 0, 0, 356, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2270), false, 10, "Server" },
                    { 44, 0, 0, 243, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2306), false, 8, "Server" },
                    { 45, 0, 0, 462, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2312), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2312), false, 4, "Server" },
                    { 46, 0, 0, 398, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2317), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2317), false, 6, "Server" },
                    { 47, 0, 0, 457, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2324), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2325), false, 7, "Server" },
                    { 48, 0, 0, 286, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2330), false, 5, "Server" },
                    { 49, 0, 0, 242, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2335), false, 6, "Server" },
                    { 50, 0, 0, 448, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2340), false, 8, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3465), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3466), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3471), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3472), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1940), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1941), "Thuê Chỗ", false, "Cấp bổ sung U", "Size" },
                    { 2, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1949), "Thêm 1U", false, "Bổ sung IP", "Ip" },
                    { 3, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(1954), "Công suất 100", false, "Thêm Port", "Port" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("050bac5e-7478-4470-b554-030f89b045f4") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("15da2322-bdde-4453-9e41-4941be4e92a7") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("38be337d-262a-4b0b-9d21-fabc2649621f") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("3ec47dab-1581-43f2-b8a2-199f8925d388") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4a670894-c33f-43f3-965a-026cf56ca0d2") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4e5d516f-e387-44e6-b067-e69fd5083a3f") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("5acf4ab6-d7a7-41d7-9f63-8b6c78de6881") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("76424aae-f6e6-41b1-bb52-993d6eb1e364") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("78e12599-387c-413f-9734-5628b8f9d6dd") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("7d1184ef-5c0a-4c28-9118-2f758247c73b") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("888a4352-49de-4326-a9fe-c535b2071d46") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("95f6f604-2234-4e98-8ddf-316a48c3b7c3") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9b6bcac3-7fc6-4762-8066-cfee2118daf9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9b794573-4f82-41c6-b9f9-bdd0070d2793") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9b7c7772-55dd-4269-9bc0-1d4340584a12") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9fb1c9b5-7ffe-4f2f-8d15-918362aa4a98") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ab3727ef-50c9-4740-8a78-a765b6202507") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b85ce419-930f-49c2-967b-ae0b48bd141e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("bb2207a4-4d8d-402a-996d-650399f0332d") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("c5631b55-54e4-4e12-99e3-1c4fe93b5ce9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("cf6b86d4-676e-41d7-a7fd-6dfd57e96ad5") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("d09e6a57-029a-442a-92d1-4f589bc3b611") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("dccdca68-3d0d-420b-bb17-264dc781f213") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("df924a58-a334-45eb-9ae6-eb57518160ad") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("fe338f5f-1a9e-406e-a7c0-4301f2ecf3b2") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8378), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Iaculis aliquet hac", 1, new DateTime(2023, 11, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(7101), new DateTime(2023, 11, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(7104), false, "1313706672", new Guid("df924a58-a334-45eb-9ae6-eb57518160ad") },
                    { 3, "Eget dapibus sociosqu", 3, new DateTime(2023, 11, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 11, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(1009), false, "266190764", new Guid("b85ce419-930f-49c2-967b-ae0b48bd141e") },
                    { 4, "Vel faucibus duis", 4, new DateTime(2023, 11, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 11, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(515), false, "893713712", new Guid("9b7c7772-55dd-4269-9bc0-1d4340584a12") },
                    { 5, "Vitae euismod leo", 5, new DateTime(2023, 11, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(5653), new DateTime(2023, 11, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(5656), false, "1828585236", new Guid("5acf4ab6-d7a7-41d7-9f63-8b6c78de6881") },
                    { 6, "Lacinia suscipit eros", 1, new DateTime(2023, 11, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 11, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(6527), false, "1328996892", new Guid("9fb1c9b5-7ffe-4f2f-8d15-918362aa4a98") },
                    { 7, "Pulvinar in proin", 5, new DateTime(2023, 11, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(454), new DateTime(2023, 11, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(456), false, "1976492963", new Guid("15da2322-bdde-4453-9e41-4941be4e92a7") },
                    { 8, "Hac fermentum vehicula", 5, new DateTime(2023, 11, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(434), new DateTime(2023, 11, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(437), false, "196359281", new Guid("cf6b86d4-676e-41d7-a7fd-6dfd57e96ad5") },
                    { 9, "Porttitor sem maximus", 4, new DateTime(2023, 11, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(5665), new DateTime(2023, 11, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(5668), false, "376495832", new Guid("4e5d516f-e387-44e6-b067-e69fd5083a3f") },
                    { 10, "Id orci suspendisse", 1, new DateTime(2023, 11, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 11, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(3060), false, "1319053138", new Guid("d09e6a57-029a-442a-92d1-4f589bc3b611") },
                    { 11, "Praesent viverra facilisis", 2, new DateTime(2023, 11, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 11, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7074), false, "1330179755", new Guid("38be337d-262a-4b0b-9d21-fabc2649621f") },
                    { 12, "Nisi volutpat euismod", 4, new DateTime(2023, 11, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(633), new DateTime(2023, 11, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(636), false, "1086430856", new Guid("4a670894-c33f-43f3-965a-026cf56ca0d2") },
                    { 13, "Luctus laoreet purus", 3, new DateTime(2023, 11, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(5426), new DateTime(2023, 11, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(5428), false, "305349862", new Guid("9b6bcac3-7fc6-4762-8066-cfee2118daf9") },
                    { 14, "Euismod primis commodo", 5, new DateTime(2023, 11, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(7846), new DateTime(2023, 11, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(7849), false, "2042154206", new Guid("888a4352-49de-4326-a9fe-c535b2071d46") },
                    { 15, "Eu pulvinar iaculis", 4, new DateTime(2023, 11, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(6667), new DateTime(2023, 11, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(6670), false, "1854056997", new Guid("76424aae-f6e6-41b1-bb52-993d6eb1e364") },
                    { 16, "Est orci mi", 5, new DateTime(2023, 11, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(5551), new DateTime(2023, 11, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(5553), false, "2071651499", new Guid("ab3727ef-50c9-4740-8a78-a765b6202507") },
                    { 17, "Et sagittis commodo", 4, new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(5342), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(5345), false, "561258183", new Guid("bb2207a4-4d8d-402a-996d-650399f0332d") },
                    { 18, "Cursus magna etiam", 4, new DateTime(2023, 11, 2, 22, 3, 19, 733, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 2, 22, 3, 19, 733, DateTimeKind.Local).AddTicks(6271), false, "1299696059", new Guid("3ec47dab-1581-43f2-b8a2-199f8925d388") },
                    { 19, "Neque rhoncus mattis", 4, new DateTime(2023, 11, 2, 22, 3, 19, 801, DateTimeKind.Local).AddTicks(5272), new DateTime(2023, 11, 2, 22, 3, 19, 801, DateTimeKind.Local).AddTicks(5276), false, "527586708", new Guid("9b794573-4f82-41c6-b9f9-bdd0070d2793") },
                    { 20, "Imperdiet porttitor nisi", 1, new DateTime(2023, 11, 2, 22, 3, 19, 871, DateTimeKind.Local).AddTicks(792), new DateTime(2023, 11, 2, 22, 3, 19, 871, DateTimeKind.Local).AddTicks(800), false, "2128398231", new Guid("050bac5e-7478-4470-b554-030f89b045f4") },
                    { 21, "Finibus habitasse hac", 4, new DateTime(2023, 11, 2, 22, 3, 19, 941, DateTimeKind.Local).AddTicks(3671), new DateTime(2023, 11, 2, 22, 3, 19, 941, DateTimeKind.Local).AddTicks(3674), false, "1275342926", new Guid("fe338f5f-1a9e-406e-a7c0-4301f2ecf3b2") },
                    { 22, "Tempor quam nulla", 5, new DateTime(2023, 11, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(4637), new DateTime(2023, 11, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(4639), false, "1562709895", new Guid("78e12599-387c-413f-9734-5628b8f9d6dd") },
                    { 23, "Quis tempor nisl", 2, new DateTime(2023, 11, 2, 22, 3, 20, 77, DateTimeKind.Local).AddTicks(9630), new DateTime(2023, 11, 2, 22, 3, 20, 77, DateTimeKind.Local).AddTicks(9633), false, "535011050", new Guid("95f6f604-2234-4e98-8ddf-316a48c3b7c3") },
                    { 24, "Lacus per quam", 3, new DateTime(2023, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(4908), new DateTime(2023, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(4911), false, "1545777635", new Guid("7d1184ef-5c0a-4c28-9118-2f758247c73b") },
                    { 25, "Ante quisque duis", 3, new DateTime(2023, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(2097), new DateTime(2023, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(2102), false, "1223579585", new Guid("dccdca68-3d0d-420b-bb17-264dc781f213") },
                    { 26, "Donec vitae torquent", 1, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(5842), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(5845), false, "1999713682", new Guid("c5631b55-54e4-4e12-99e3-1c4fe93b5ce9") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3480), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3486), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3486), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3490), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3490), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3494), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3494), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3497), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3497), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3502), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3502), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3506), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3509), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3509), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3512), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3513), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3546), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3546), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3550), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3553), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3554), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3557), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3557), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3560), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3561), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3564), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3564), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3567), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3568), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3571), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3571), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3575), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3576), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3579), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3582), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3583), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3586), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3586), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3590), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3593), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3597), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3600), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3603), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3604), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3607), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3611), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3614), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3618), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3621), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3624), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3628), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3662), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3662), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3666), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3670), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3673), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3673), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3676), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3677), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3680), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3680), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3684), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3687), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3691), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3694), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3694), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3698), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3701), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3701), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3705), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3708), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3711), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3712), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3715), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3718), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3719), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3722), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3722), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3725), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3729), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3729), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3732), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3732), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3735), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3736), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3739), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3739), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3743), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3743), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3746), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3749), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3750), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3753), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3753), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3756), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3757), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3794), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3794), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3798), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3801), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3801), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3804), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3805), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3809), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3809), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3813), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3813), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3816), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3816), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3819), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3820), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3823), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3823), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3826), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3826), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3830), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3830), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3834), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3837), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3837), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3840), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3843), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3844), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3847), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3847), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3850), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3851), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3854), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3854), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3857), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3861), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3864), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3868), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3871), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3871), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3874), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3875), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3909), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3909), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3913), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3913), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3916), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3920), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3923), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3927), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3930), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3930), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3933), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3933), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3936), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3937), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3940), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3940), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3944), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3947), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3947), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3951), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3954), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3957), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3957), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3961), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3961), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3964), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3968), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3968), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3971), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3972), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3975), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3975), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3978), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3979), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3982), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3986), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3989), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3993), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3996), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3996), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3999), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4000), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4033), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4033), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4040), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4044), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4044), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4048), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4051), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4051), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4055), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4058), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4058), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4061), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4062), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4065), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4065), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4068), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4069), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4072), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4072), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4075), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4076), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4079), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4079), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4082), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4083), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4086), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4086), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4089), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4090), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4093), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4093), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4097), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4098), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4101), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4105), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4108), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4108), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4141), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4142), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4145), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4145), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4148), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4149), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4152), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4156), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4159), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4162), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4162), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4166), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4169), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4173), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4176), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4180), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4183), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4187), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4190), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4194), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4197), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4197), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4201), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4204), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4207), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4211), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4214), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4218), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4222), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4225), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4228), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4232), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4235), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4235), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4286), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4289), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4293), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4296), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4300), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4303), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4303), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4307), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4310), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4310), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4313), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4314), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4317), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4317), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4320), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4320), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4323), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4324), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4327), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4327), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4331), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4334), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4334), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4337), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4337), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4341), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4344), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4344), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4348), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4351), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4355), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4358), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4362), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4365), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4365), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4368), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4372), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4375), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4375), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4409), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4413), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4413), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4416), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4417), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4420), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4420), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4423), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4427), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4430), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4430), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4434), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4437), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4437), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4440), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4441), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4444), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4448), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2361), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2375), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2375), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2384), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2384), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2392), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2400), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2408), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2408), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2445), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2445), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2452), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2366), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2367), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2377), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2386), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2386), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2393), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2394), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2401), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2401), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2409), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2446), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2446), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2453), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2368), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2377), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2378), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2387), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2387), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2394), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2402), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2410), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2447), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2447), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2454), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2369), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2369), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2378), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2379), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2388), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2388), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2395), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2395), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2403), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2411), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2448), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2448), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2455), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2455), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2370), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2380), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2388), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2389), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2396), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2396), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2404), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2404), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2411), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2412), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2448), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2449), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2456), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2372), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2381), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2389), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2390), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2397), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2397), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2405), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2442), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2450), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2457), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2373), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2373), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2382), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2382), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2391), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2398), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2406), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2406), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2443), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2450), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2451), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2457), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2458), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2374), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2374), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2383), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2391), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2391), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2399), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2399), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2407), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2407), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2444), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2451), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2459), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2460), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2466), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2471), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2476), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2480), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2484), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2484), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2489), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2493), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2493), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2462), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2462), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2467), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2467), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2472), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2472), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2476), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2481), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2485), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2489), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2490), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2494), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2494), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2463), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2463), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2468), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2468), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2473), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2477), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2477), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2481), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2482), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2486), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2486), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2490), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2495), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2464), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2464), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2469), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2469), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2474), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2478), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2482), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2482), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2487), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2491), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2491), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2495), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2496), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2465), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2465), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2470), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2470), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2474), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2475), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2479), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2479), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2483), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2488), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2492), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(2497), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "SaleApprovals",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "SaleId" },
                values: new object[] { 1, new DateTime(2023, 11, 2, 22, 3, 18, 392, DateTimeKind.Local).AddTicks(57), new DateTime(2023, 11, 2, 22, 3, 18, 392, DateTimeKind.Local).AddTicks(61), false, new Guid("1abb6e28-793d-460f-8a24-745998356da8") });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4455), 11, false, "Mauris proin luctus", 1, "60e9328d-9ac1-47be-82d3-971084213079" },
                    { 2, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4878), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4878), 12, false, "Sollicitudin mollis inceptos", 1, "e0bbadad-daeb-45bf-9c5c-dae638556d7c" },
                    { 3, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5214), 13, false, "Leo est ultrices", 1, "c40fc44e-011b-4df4-a362-48dbcca19c6d" },
                    { 4, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5478), 14, false, "Dui eleifend suspendisse", 1, "55bd6a6f-7b3c-4ee0-ab14-027dd42aed4b" },
                    { 5, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5759), 15, false, "Leo auctor egestas", 1, "38d940d7-c55b-4867-ad57-ed23427e6cd4" },
                    { 6, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6041), 16, false, "Sed hendrerit sem", 1, "9bc90810-4996-49f7-918d-a11c37115214" },
                    { 7, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6311), 17, false, "Venenatis pharetra diam", 1, "25224798-da79-46b9-8cc1-d9c39ca27c43" },
                    { 8, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6609), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6609), 18, false, "Fames rhoncus efficitur", 1, "bdead987-0c40-47f2-91a1-9e724d5ae3c3" },
                    { 9, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6838), 19, false, "Hac in libero", 1, "50006987-4f29-4bca-a147-03d8456a3d25" },
                    { 10, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7184), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7185), 20, false, "Interdum conubia et", 1, "8360b326-23f0-48ed-96dc-0721b999d67b" },
                    { 11, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7483), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7483), 21, false, "Luctus varius ultricies", 1, "b319cfc3-f8b8-4787-9fe2-d5ce110af7a5" },
                    { 12, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7809), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7809), 22, false, "Himenaeos eget malesuada", 1, "986ac7e8-1a3c-454d-8934-366c069512ea" },
                    { 13, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8073), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8073), 23, false, "Vitae volutpat elit", 1, "b28995d1-c7f9-4d6f-8c34-3df371583d97" },
                    { 14, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8373), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8373), 24, false, "Nibh inceptos donec", 1, "f7f6b1e4-a4be-4cdd-abae-9ad164ff3778" },
                    { 15, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8635), 25, false, "Id elementum lectus", 1, "2cff55c1-bf33-4434-a451-f26bbe4c569e" },
                    { 16, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8911), 26, false, "Lacinia posuere elementum", 1, "45b1e4d9-95e1-4cf3-9ba6-d83fa265be95" },
                    { 17, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9188), 27, false, "Fusce ultricies maecenas", 1, "cbb7148e-0796-4bb3-89eb-3caa78388b59" },
                    { 18, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9438), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9438), 28, false, "Orci sagittis purus", 1, "bdd14184-5865-407f-8cf2-978c44c15573" },
                    { 19, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9699), 29, false, "Nec urna imperdiet", 1, "d6de84b3-0a8f-445b-94a7-978af570927f" },
                    { 20, 0, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9948), 30, false, "Mauris vulputate blandit", 1, "1e70ba45-f9f7-41fe-82f4-17cade741fbe" },
                    { 21, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(204), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(204), 31, false, "Leo mattis conubia", 1, "961a8324-0fea-4dd2-8e80-ff527b3169ac" },
                    { 22, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(509), 32, false, "Mauris feugiat vehicula", 1, "b7410196-2f51-411c-be98-4b44281d64ca" },
                    { 23, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(792), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(792), 33, false, "Porta aptent curabitur", 1, "88b857e9-4b24-4694-9588-506c7d067df5" },
                    { 24, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1163), 34, false, "Eu maximus purus", 1, "daad696c-9a5f-48f7-9cec-08f64ce11e51" },
                    { 25, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1423), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1423), 35, false, "Velit porttitor vehicula", 1, "ea344230-1b64-49b5-a82b-6075d27c2635" },
                    { 26, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1659), 36, false, "Cursus feugiat quis", 1, "ad0234d3-8f1e-410b-92f5-29a3950b3bfa" },
                    { 27, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1917), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1917), 37, false, "Libero enim nulla", 1, "eb306c71-e3ae-4b13-bdcf-74d251e5ce44" },
                    { 28, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2156), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2156), 38, false, "Praesent accumsan nostra", 1, "1546175e-045d-47a6-96d3-5f9afbd2138d" },
                    { 29, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2389), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2389), 39, false, "Dignissim tellus diam", 1, "a0eb3e13-c3dd-48f0-ba58-b344c5f94eaf" },
                    { 30, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2634), 40, false, "Sed euismod aliquam", 1, "dde95c06-6928-4fd8-998e-875f19317ca7" },
                    { 31, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2904), 41, true, "Lectus euismod integer", 1, "7446aed5-3ce5-450b-8c34-15fa9d096499" },
                    { 32, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3135), 42, true, "Lorem adipiscing nulla", 1, "3bfe6525-964a-4da0-9a05-72743227c3bd" },
                    { 33, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3408), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3408), 43, false, "Vehicula nunc orci", 1, "314d6ef7-8808-47bc-993b-b522e85c7f63" },
                    { 34, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3655), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3655), 44, false, "Nam commodo torquent", 1, "9c00a271-0eb7-4d83-8f3d-ddfc2ec31f50" },
                    { 35, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3927), 45, false, "Tortor eros nulla", 1, "3335bdd3-e06c-4b9c-97fa-3e19ac28d156" },
                    { 36, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4162), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4162), 46, false, "Habitasse sed nulla", 1, "93d96f50-be57-4f60-8fac-247844e89af1" },
                    { 37, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4403), 47, false, "Non tortor fringilla", 1, "43960e17-2453-4fb9-a658-3be535cf0ff9" },
                    { 38, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4750), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4750), 48, false, "Nunc ad quam", 1, "6fefb4e9-5907-49e6-b462-0c6f7c99faa4" },
                    { 39, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5082), 49, false, "Nam non ligula", 1, "8502531b-bb88-46c1-bc70-ac32c923ee8b" },
                    { 40, 0, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5320), 50, false, "Facilisis consequat maximus", 1, "75ad89fa-a0d8-4b96-83c1-3a67d25e57f1" }
                });

            migrationBuilder.InsertData(
                table: "TechExecutions",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "TechId" },
                values: new object[] { 1, new DateTime(2023, 11, 2, 22, 3, 18, 321, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 11, 2, 22, 3, 18, 321, DateTimeKind.Local).AddTicks(6000), false, new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsActive", "IsDeleted", "ServerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(4870), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4869), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(4869), 4, true, false, 1 },
                    { 2, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(5209), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5208), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5209), 5, true, false, 2 },
                    { 3, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(5474), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5474), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5474), 6, true, false, 3 },
                    { 4, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(5754), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5753), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(5754), 7, true, false, 4 },
                    { 5, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(6036), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6035), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6035), 8, true, false, 5 },
                    { 6, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(6308), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6307), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6307), 9, true, false, 6 },
                    { 7, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(6605), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6604), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6605), 10, true, false, 7 },
                    { 8, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(6834), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6833), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(6834), 11, true, false, 8 },
                    { 9, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(7179), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7178), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7179), 12, true, false, 9 },
                    { 10, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(7479), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7478), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7479), 13, true, false, 10 },
                    { 11, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(7805), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7804), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(7805), 14, true, false, 11 },
                    { 12, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(8069), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8068), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8069), 15, true, false, 12 },
                    { 13, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(8369), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8368), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8369), 16, true, false, 13 },
                    { 14, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(8631), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8630), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8630), 17, true, false, 14 },
                    { 15, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(8907), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8906), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(8907), 18, true, false, 15 },
                    { 16, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(9184), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9183), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9183), 19, true, false, 16 },
                    { 17, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(9433), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9432), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9433), 20, true, false, 17 },
                    { 18, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(9695), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9694), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9694), 21, true, false, 18 },
                    { 19, new DateTime(2023, 11, 2, 15, 3, 18, 114, DateTimeKind.Utc).AddTicks(9944), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9943), null, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(9944), 22, true, false, 19 },
                    { 20, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(200), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(199), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(200), 23, true, false, 20 },
                    { 21, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(505), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(505), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(505), 24, true, false, 21 },
                    { 22, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(787), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(788), 25, true, false, 22 },
                    { 23, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1100), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1100), 26, true, false, 23 },
                    { 24, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(1419), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1418), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1419), 27, true, false, 24 },
                    { 25, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(1655), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1655), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1655), 28, true, false, 25 },
                    { 26, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(1913), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1912), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(1913), 29, true, false, 26 },
                    { 27, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2152), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2152), 30, true, false, 27 },
                    { 28, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(2385), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2384), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2385), 31, true, false, 28 },
                    { 29, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(2630), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2629), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2629), 32, true, false, 29 },
                    { 30, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(2900), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2899), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(2900), 33, true, false, 30 },
                    { 31, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(3131), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3131), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3131), 34, false, true, 31 },
                    { 32, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(3404), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3404), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3404), 35, false, true, 32 },
                    { 33, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3649), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3650), 36, true, false, 33 },
                    { 34, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(3923), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3922), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(3922), 37, true, false, 34 },
                    { 35, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(4158), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4157), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4158), 38, true, false, 35 },
                    { 36, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(4398), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4398), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4398), 39, true, false, 36 },
                    { 37, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4745), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(4746), 40, true, false, 37 },
                    { 38, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(5078), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5077), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5077), 41, true, false, 38 },
                    { 39, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(5316), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5316), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5316), 42, true, false, 39 },
                    { 40, new DateTime(2023, 11, 2, 15, 3, 18, 115, DateTimeKind.Utc).AddTicks(5640), new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5639), null, new DateTime(2023, 11, 2, 22, 3, 18, 115, DateTimeKind.Local).AddTicks(5640), 43, true, false, 40 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3205), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3206), 1, false, false, 1, 20 },
                    { 2, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3219), 2, false, false, 2, 3 },
                    { 3, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3224), 3, false, false, 3, 28 },
                    { 4, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3229), 4, false, false, 4, 22 },
                    { 5, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3233), 5, false, false, 5, 3 },
                    { 6, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3239), 6, false, false, 6, 23 },
                    { 7, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3243), 7, false, false, 7, 20 },
                    { 8, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3247), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3248), 8, false, false, 8, 8 },
                    { 9, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3252), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3252), 9, false, false, 9, 28 },
                    { 10, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3257), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3258), 10, false, false, 10, 16 },
                    { 11, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3262), 11, false, false, 11, 7 },
                    { 12, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3266), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3266), 12, false, false, 12, 26 },
                    { 13, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3270), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3270), 13, false, false, 13, 11 },
                    { 14, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3275), 14, false, false, 14, 16 },
                    { 15, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3351), 15, false, false, 15, 16 },
                    { 16, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3358), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3358), 16, false, false, 16, 27 },
                    { 17, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3396), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3396), 17, false, false, 17, 19 },
                    { 18, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3404), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3404), 18, false, false, 18, 9 },
                    { 19, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3408), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3408), 19, false, false, 19, 10 },
                    { 20, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3412), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3412), 20, false, false, 20, 11 },
                    { 21, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3416), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3417), 21, false, false, 21, 8 },
                    { 22, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3421), 22, false, false, 22, 1 },
                    { 23, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3425), 23, false, false, 23, 23 },
                    { 24, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3429), 24, false, false, 24, 10 },
                    { 25, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3433), 25, false, false, 25, 23 },
                    { 26, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3438), 26, false, false, 26, 25 },
                    { 27, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3442), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3442), 27, false, false, 27, 21 },
                    { 28, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3446), 28, false, false, 28, 27 },
                    { 29, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3451), 29, false, false, 29, 3 },
                    { 30, new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 11, 2, 22, 3, 18, 114, DateTimeKind.Local).AddTicks(3455), 30, false, false, 30, 6 }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "SaleApprovalId", "ServerId", "Status", "TechExecutionId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 6, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(8285), new DateTime(2023, 10, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(8281), new DateTime(2024, 11, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(8290), new DateTime(2023, 11, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(7446), 5, new DateTime(2024, 11, 2, 22, 3, 18, 614, DateTimeKind.Local).AddTicks(8288), null, null, false, "Quam, nisi eget phasellus urna mi suspendisse semper maximus in class varius dolor, ut donec integer dui, nunc eu at. Nunc dictum maecenas odio tristique curabitur sed vel, commodo fusce dui sociosqu faucibus aliquet primis iaculis in, tempus eu mattis. Torquent efficitur posuere, placerat tortor, dolor, nam porta eleifend dapibus vulputate arcu litora vestibulum, laoreet nunc pulvinar leo facilisis eleifend.", null, null, null, 0, null },
                    { 2, 3, new DateTime(2024, 3, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 2, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 11, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 11, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(1362), 5, new DateTime(2025, 11, 2, 22, 3, 18, 691, DateTimeKind.Local).AddTicks(2202), null, null, false, "Mauris, arcu neque, sagittis, mattis dolor, sit nullam massa sed, pulvinar ante nisi, suspendisse faucibus sodales primis vestibulum, fermentum placerat. Et, sollicitudin suspendisse fringilla aptent est rutrum euismod, convallis nisi, pulvinar sem tincidunt justo consectetur lacinia, odio aliquam sociosqu et. Nibh, proin tellus, habitasse sapien mauris porta dapibus per phasellus ante, ut velit tortor vestibulum inceptos gravida lobortis volutpat, tincidunt.", null, null, null, 0, null },
                    { 3, 4, new DateTime(2024, 5, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(1624), new DateTime(2024, 1, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 11, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 11, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(791), 5, new DateTime(2024, 11, 2, 22, 3, 18, 760, DateTimeKind.Local).AddTicks(1626), null, null, false, "Placerat, luctus ultrices ad porttitor, orci, himenaeos aenean bibendum placerat semper sem accumsan ante, finibus tristique condimentum augue nec, malesuada. Condimentum vitae amet vitae, nibh, mi non, urna, a vulputate imperdiet lacinia, ornare et quam risus himenaeos blandit, ipsum aenean. Id quis sed, amet, himenaeos eleifend etiam placerat, mattis, scelerisque feugiat, ad platea rhoncus metus dolor, semper orci, tempus integer.", null, null, null, 0, null },
                    { 4, 5, new DateTime(2024, 5, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(6808), new DateTime(2024, 2, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(6803), new DateTime(2025, 11, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 11, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(5942), 5, new DateTime(2024, 11, 2, 22, 3, 18, 836, DateTimeKind.Local).AddTicks(6811), null, null, false, "Finibus arcu vulputate libero enim, etiam leo mauris praesent nulla nullam mollis duis mattis, commodo, congue erat lacinia maximus dui. Quisque tortor, dictum laoreet, sed eros et, libero taciti class rutrum hendrerit tristique vestibulum venenatis a interdum eget rhoncus, nisi. Mauris, nibh semper himenaeos eget commodo orci diam tortor, integer auctor, pellentesque magna pulvinar, rhoncus aliquam eros ipsum mattis, non.", null, null, null, 0, null },
                    { 5, 6, new DateTime(2024, 5, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 1, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 11, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(7697), new DateTime(2023, 11, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(6824), 5, new DateTime(2026, 11, 2, 22, 3, 18, 908, DateTimeKind.Local).AddTicks(7695), null, null, false, "Condimentum dictumst neque, ligula, viverra euismod porttitor ultrices, quam praesent consectetur et, varius, hac phasellus massa, quis consequat litora mauris. Vitae ex, platea cras maximus habitasse leo nisi, mauris, turpis malesuada dui fusce molestie sit commodo neque, tincidunt nisl elit. Volutpat himenaeos interdum finibus, fermentum fringilla maximus erat maecenas efficitur ultricies nec, pharetra suscipit rhoncus consequat amet luctus ut rutrum.", null, null, null, 0, null },
                    { 6, 7, new DateTime(2024, 2, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(1658), new DateTime(2023, 10, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(1653), new DateTime(2025, 11, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(1662), new DateTime(2023, 11, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(770), 5, new DateTime(2025, 11, 2, 22, 3, 18, 977, DateTimeKind.Local).AddTicks(1660), null, null, false, "Lorem, feugiat suscipit posuere egestas sed ligula, viverra sodales bibendum, vitae adipiscing vestibulum massa fringilla magna, sollicitudin primis nam nunc. Ex, leo, tortor, lacus vel, sem magna pharetra sagittis, sem, luctus sed volutpat torquent nec, pulvinar, aenean lacinia eget blandit. Aliquet cursus bibendum enim, faucibus orci, dictum adipiscing ligula, erat, ultricies molestie dui, quis, finibus facilisis placerat, magna iaculis vitae.", null, null, null, 1, null },
                    { 7, 8, new DateTime(2023, 12, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(1509), new DateTime(2023, 12, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 11, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(1514), new DateTime(2023, 11, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(731), 5, new DateTime(2025, 11, 2, 22, 3, 19, 46, DateTimeKind.Local).AddTicks(1512), null, null, false, "Nulla, vitae eu, porta et ornare at, mauris, ipsum eleifend, interdum, congue, tempor auctor, tincidunt non ullamcorper rhoncus, risus sagittis. Laoreet, faucibus maecenas bibendum a massa convallis ultrices eros ante mollis scelerisque euismod, feugiat, sed cursus, himenaeos rutrum facilisis hac. Justo eu, ipsum mattis egestas donec iaculis vestibulum volutpat consectetur id, mi, tempor urna, accumsan ultrices phasellus quis laoreet, nulla.", null, null, null, 1, null },
                    { 8, 9, new DateTime(2023, 11, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(6864), new DateTime(2023, 10, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 11, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 11, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(5966), 5, new DateTime(2025, 11, 2, 22, 3, 19, 114, DateTimeKind.Local).AddTicks(6866), null, null, false, "Ornare tincidunt id, orci, fringilla dignissim justo et finibus augue sed, pretium feugiat, erat, suspendisse pharetra sem, ac, aliquet conubia. Suspendisse sed aliquam sem aenean feugiat, facilisis dictumst magna, vel, in, posuere lectus ad leo, vehicula vel sodales tristique leo. Finibus eget risus fermentum mauris porta, malesuada scelerisque euismod, porta urna sociosqu justo ipsum pulvinar posuere mi, nec tempor, nam.", null, null, null, 1, null },
                    { 9, 10, new DateTime(2023, 11, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(4153), new DateTime(2024, 2, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(4148), new DateTime(2026, 11, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(4157), new DateTime(2023, 11, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(3337), 5, new DateTime(2024, 11, 2, 22, 3, 19, 183, DateTimeKind.Local).AddTicks(4155), null, null, false, "Augue fermentum porttitor, sed aliquet dui at nibh, tempus ultrices, urna eu, maecenas massa, nisl amet, enim, ex, metus nunc. Erat, dictum ad imperdiet luctus placerat, orci, phasellus mauris elit, faucibus vel, ante odio id libero lectus, at laoreet lacus. Amet, neque nibh fames sagittis risus magna consectetur interdum, velit tellus primis taciti iaculis nec, enim massa eleifend, elementum erat.", null, null, null, 1, null },
                    { 10, 11, new DateTime(2023, 12, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 1, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7915), new DateTime(2026, 11, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7924), new DateTime(2023, 11, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7292), 5, new DateTime(2026, 11, 2, 22, 3, 19, 251, DateTimeKind.Local).AddTicks(7922), null, null, false, "Sollicitudin scelerisque neque euismod, interdum tempus arcu, viverra porttitor, vitae lobortis eleifend, tincidunt consectetur gravida venenatis inceptos condimentum a, libero. Maximus nisi, magna, volutpat luctus, luctus quis placerat eleifend, adipiscing inceptos pharetra dolor, mauris, interdum erat suscipit orci, tempor arcu. Massa augue suspendisse luctus etiam varius neque, morbi nostra, bibendum, amet vestibulum, erat, ex mollis faucibus tempor conubia ex, eu.", null, null, null, 1, null },
                    { 11, 12, new DateTime(2024, 1, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 11, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(1512), new DateTime(2025, 11, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 11, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(878), 5, new DateTime(2026, 11, 2, 22, 3, 19, 320, DateTimeKind.Local).AddTicks(1519), null, null, false, "Posuere ad fames pulvinar, consequat laoreet, blandit, sociosqu amet, eu velit tortor conubia dapibus nunc, malesuada orci fringilla rutrum non. Tortor sem, feugiat vitae tortor, porta maecenas finibus, viverra et, volutpat sem orci, erat diam arcu sodales turpis ad vitae. Vestibulum interdum placerat sem, lorem fames risus ultricies ornare eros, sapien arcu, id litora malesuada ipsum eros accumsan arcu leo.", null, 1, 1, 2, null },
                    { 12, 13, new DateTime(2024, 6, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 8, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 11, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(6670), new DateTime(2023, 11, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(5731), 5, new DateTime(2024, 11, 2, 22, 3, 19, 388, DateTimeKind.Local).AddTicks(6668), null, null, false, "Laoreet nec taciti auctor justo congue, nisi, gravida nibh, ut nullam vitae, amet, neque, elementum ex, facilisis bibendum etiam tempus. Phasellus nulla tortor, a, aliquam placerat tempus vel quam, enim, gravida sollicitudin volutpat, morbi nostra, semper ante, turpis dolor, adipiscing. Hac blandit placerat duis porta, scelerisque libero magna, condimentum vivamus cras etiam quam mattis, vulputate inceptos rhoncus, non varius, metus.", null, 1, 2, 2, null },
                    { 13, 14, new DateTime(2023, 11, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(9006), new DateTime(2024, 2, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(9001), new DateTime(2025, 11, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(9011), new DateTime(2023, 11, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(8131), 5, new DateTime(2026, 11, 2, 22, 3, 19, 456, DateTimeKind.Local).AddTicks(9009), null, null, false, "Erat lectus sapien molestie maximus consequat tincidunt vivamus ante phasellus varius at vel, fermentum praesent convallis elit tortor, metus hac. Luctus, cras primis sagittis, semper curabitur cursus, faucibus leo, class congue est fringilla, platea euismod, commodo convallis pellentesque quam, vel. Eleifend turpis nisl pellentesque tempus nam pulvinar, erat, varius, sem vestibulum, pulvinar porttitor, placerat, nec, accumsan suspendisse rutrum purus eu.", null, 1, 3, 2, null },
                    { 14, 15, new DateTime(2023, 12, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(7531), new DateTime(2024, 2, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 11, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 11, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(6885), 5, new DateTime(2025, 11, 2, 22, 3, 19, 524, DateTimeKind.Local).AddTicks(7534), null, null, false, "Mollis enim interdum accumsan ipsum vel, pulvinar porta, sem, nunc, cursus sapien torquent platea adipiscing mi, vitae, varius tempor, lectus. Quam mi, tortor, fusce lobortis consequat enim, eget elit, bibendum amet vitae, himenaeos nisi, a, dolor, cras quam, lacinia feugiat. Auctor, congue, aliquam fermentum felis in posuere rhoncus semper convallis dolor, suspendisse vel lacinia, duis faucibus posuere, orci sagittis, finibus.", null, 1, 4, 2, null },
                    { 15, 16, new DateTime(2024, 5, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(6482), new DateTime(2024, 1, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(6478), new DateTime(2025, 11, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(6486), new DateTime(2023, 11, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(5798), 5, new DateTime(2026, 11, 2, 22, 3, 19, 594, DateTimeKind.Local).AddTicks(6484), null, null, false, "Diam phasellus ligula et, amet nullam tristique lobortis non congue, feugiat, felis blandit, convallis quis leo, molestie ipsum maximus neque. In cursus, sem, luctus et, laoreet, neque, semper neque porttitor feugiat, ultricies vivamus mattis, nec, lobortis egestas tempor phasellus id. Amet lorem tellus dapibus placerat, tempor, himenaeos vestibulum, ipsum aenean volutpat faucibus nullam ligula lectus sed mauris, pulvinar, enim, proin.", null, 1, 5, 2, null },
                    { 16, 17, new DateTime(2024, 2, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 8, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(6501), new DateTime(2024, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(5599), 5, new DateTime(2026, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(6508), null, null, false, "Mauris nostra, congue class ante posuere a fermentum phasellus faucibus cursus, id, laoreet, felis non ad placerat, elementum sed, ex. Risus enim, dolor ipsum ullamcorper bibendum nibh praesent rhoncus massa, molestie dui magna, auctor, convallis mauris vestibulum ultrices sagittis, lorem. Bibendum, pretium tempor eleifend vel, augue venenatis magna commodo, aptent dolor nulla, varius, interdum dictumst erat velit nec, lectus, duis.", null, 1, 6, 4, 1 },
                    { 17, 16, new DateTime(2024, 3, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 10, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(7231), new DateTime(2024, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(7236), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(6526), 5, new DateTime(2024, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(7235), null, null, false, "Rhoncus consectetur conubia dolor arcu, turpis odio, congue sapien vel metus urna ligula, aptent tristique condimentum at proin ultrices donec. Quis, vehicula nibh, consectetur nulla diam ante, venenatis enim laoreet, vivamus sollicitudin lectus, nisi, scelerisque etiam cursus, placerat non, volutpat. Primis ipsum enim elit, mollis taciti felis ante, adipiscing praesent gravida efficitur amet non vestibulum, posuere, lacinia, commodo, est molestie.", null, 1, 7, 4, 1 },
                    { 18, 16, new DateTime(2024, 4, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8021), new DateTime(2023, 9, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8019), new DateTime(2024, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8024), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(7253), 5, new DateTime(2025, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8022), null, null, false, "Dui, ipsum elit, bibendum, fringilla eleifend quis litora rhoncus maximus condimentum interdum, eros, eu suscipit primis vel, egestas aliquet nullam. Metus ligula mattis, ex, est enim, ligula, dolor, suscipit cras aliquam convallis nibh eleifend, iaculis curabitur mattis vestibulum, vulputate eu. Consectetur sagittis, urna euismod quam pulvinar, tortor, duis aliquet tincidunt in, commodo, elit tempor iaculis tellus, pellentesque class donec nunc.", null, 1, 8, 4, 1 },
                    { 19, 20, new DateTime(2024, 3, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 1, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8759), new DateTime(2025, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8032), 5, new DateTime(2026, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8762), null, null, false, "Maximus lacinia sed suscipit rutrum cursus, sagittis sit non, suspendisse convallis per enim, velit magna, diam hac aptent porta, nisi. Laoreet, lobortis dapibus interdum, semper eros, tempus sapien bibendum, inceptos velit et, lacinia interdum posuere vitae eget volutpat, adipiscing tempor. Libero eros urna, non lacinia, id sagittis mollis facilisis finibus aptent interdum nibh varius lacinia ex, mattis, phasellus consequat nulla.", null, 1, 9, 4, 1 },
                    { 20, 18, new DateTime(2024, 2, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(9627), new DateTime(2023, 8, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(9629), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(8772), 5, new DateTime(2024, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(9628), null, null, false, "Per urna viverra nibh, quis erat ullamcorper mauris, ad pretium suspendisse tempor, lectus at, id, augue egestas rutrum purus finibus. Vulputate platea leo etiam tellus adipiscing maximus curabitur sem proin tortor bibendum, posuere et quis dui lorem, amet nec, per. In nostra, eleifend laoreet, erat adipiscing auctor, arcu, nisl dictum mollis euismod eu, pellentesque tellus, massa integer ipsum eleifend, lectus.", null, 1, 10, 4, 1 },
                    { 21, 16, new DateTime(2023, 12, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 12, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(382), new DateTime(2025, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 11, 2, 22, 3, 19, 662, DateTimeKind.Local).AddTicks(9639), 5, new DateTime(2024, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(385), null, null, false, "Tellus vel, interdum erat luctus finibus, pulvinar eros, fermentum lacinia adipiscing posuere condimentum finibus conubia dui, vitae blandit augue platea. Porta, scelerisque quis, ut quam rhoncus, dignissim quis felis arcu tempor mollis ex, euismod ultrices condimentum donec magna vel iaculis. Dapibus adipiscing a praesent lacinia, tortor volutpat aliquet efficitur neque rhoncus venenatis commodo, tempor ad lectus a, rutrum morbi rhoncus.", null, 1, 11, 4, 1 },
                    { 22, 16, new DateTime(2024, 3, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(2034), new DateTime(2023, 10, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(2024), new DateTime(2026, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(395), 5, new DateTime(2026, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(2036), null, null, false, "Phasellus consequat lectus id, porta, vulputate vitae ultrices, quam bibendum, cras aliquet quam, mauris, morbi rutrum odio, lobortis proin ultrices. Quisque dictumst lacinia pulvinar, aenean donec mi, diam eget morbi volutpat dolor varius, nunc, nisi ultrices, vel ullamcorper lobortis lacus. Ac, ultrices, quam aliquet lacinia adipiscing dolor feugiat gravida ad libero nunc proin magna scelerisque orci arcu vel praesent tortor.", null, 1, 12, 4, 1 },
                    { 23, 20, new DateTime(2024, 5, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(3514), new DateTime(2023, 10, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(3507), new DateTime(2024, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(3519), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(2104), 5, new DateTime(2024, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(3517), null, null, false, "Mi, bibendum, congue, est inceptos amet sit congue cras elementum bibendum fringilla, tristique blandit pretium consequat ligula magna, eu ante. Odio, inceptos hac torquent quis, elit, purus neque, venenatis tristique amet leo consequat nullam tempor eros, ipsum vehicula dui porta. Purus erat congue, primis nulla, proin lorem lectus, condimentum integer neque, velit cursus, vivamus elit fringilla, etiam cras diam lectus.", null, 1, 13, 4, 1 },
                    { 24, 20, new DateTime(2024, 2, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 12, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(3561), 5, new DateTime(2025, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(5170), null, null, false, "Curabitur dapibus sodales quisque aliquam elit aliquet placerat nibh, lorem, nunc, cursus fringilla, ultricies laoreet mattis leo, vestibulum, congue, felis. Id magna dapibus euismod, quisque rutrum viverra lectus, id, nunc, ac ad rhoncus efficitur interdum, mollis pulvinar, ultrices massa nisi. Pulvinar, mi magna, commodo tellus, enim odio dictum nostra, tristique finibus porttitor, erat feugiat, fusce dui, sagittis, ex, ante neque.", null, 1, 14, 4, 1 },
                    { 25, 20, new DateTime(2024, 2, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 2, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(7175), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(5212), 5, new DateTime(2026, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(7171), null, null, false, "Class turpis ex dolor mi, lobortis elit justo rhoncus tempus fames himenaeos duis aenean id at malesuada quam ornare pellentesque. Finibus, mattis suspendisse posuere, ac ligula vitae magna, tellus nibh sit laoreet augue quisque lobortis nostra, suscipit id, porttitor, mi. Tincidunt conubia ligula, interdum quam finibus porta lacinia porttitor cras ac eu, posuere, non quam, eleifend, urna, gravida fames imperdiet.", null, 1, 15, 4, 1 },
                    { 26, 17, new DateTime(2024, 2, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(9040), new DateTime(2025, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(7210), 5, new DateTime(2025, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(9049), null, null, false, "Lectus amet, lobortis eget magna, mi varius leo, litora duis odio, tellus dapibus mauris, lacinia, odio nibh consequat dictumst inceptos. Per tempus luctus, est mattis massa, vel, cursus malesuada primis arcu, sagittis, ac tortor auctor, nam aliquet egestas dictumst magna. Ultrices, cras enim, pharetra suspendisse at, odio, efficitur rhoncus, at ante sodales sagittis et, eu nisi nibh, in, varius ante.", null, 1, 16, 4, 1 },
                    { 27, 16, new DateTime(2024, 2, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(313), new DateTime(2024, 1, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(307), new DateTime(2026, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 11, 2, 22, 3, 19, 663, DateTimeKind.Local).AddTicks(9083), 5, new DateTime(2025, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(316), null, null, false, "Aptent urna et ultrices turpis tristique donec condimentum velit non, lacus lobortis dui, placerat, nunc auctor, primis massa nibh fringilla. Orci nunc, sed in, ante sem, aliquam a sed, consequat eu, aenean egestas vel, mattis, malesuada ex, ante, posuere, integer. Amet nam eget ut vitae litora congue, inceptos luctus quis eu, auctor quam blandit primis vel, et, id, ante viverra.", null, 1, 17, 4, 1 },
                    { 28, 17, new DateTime(2023, 12, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 1, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(1415), new DateTime(2025, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(1422), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(350), 5, new DateTime(2025, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(1420), null, null, false, "Nulla, amet risus id odio orci, a, ullamcorper nisi, justo et, class et himenaeos nunc, porta pulvinar, quam mauris, velit. In, maximus magna proin bibendum, enim, ultrices dictumst at, fusce nec dui, rhoncus eu, arcu ac, nunc lacinia, est consectetur. Scelerisque molestie cursus aenean nostra, tempor, tortor risus et, vulputate aliquam enim fermentum sem eros, pretium curabitur neque, aliquet vestibulum.", null, 1, 18, 4, 1 },
                    { 29, 19, new DateTime(2024, 6, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(2322), new DateTime(2024, 1, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(2319), new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(1443), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(2324), null, null, false, "Quisque mollis pharetra est nunc, mi vel, congue, ut vestibulum feugiat massa, turpis ornare euismod a auctor aenean viverra porttitor. Litora amet, faucibus class vulputate commodo, nisi sociosqu in leo, etiam tortor, sem finibus, aliquam erat tempus congue, maximus interdum. Imperdiet eget placerat, fusce nullam vitae turpis eros, facilisis hendrerit ullamcorper est lacinia nec, ultrices aliquam primis feugiat placerat sit.", null, 1, 19, 4, 1 },
                    { 30, 16, new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(3491), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(3496), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(2358), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(3494), null, null, false, "Arcu, ipsum eros purus tortor fermentum non augue velit risus erat volutpat, id litora ultrices, tempor aenean scelerisque rhoncus, massa. Nibh iaculis odio commodo id, nullam interdum quis risus congue fermentum nam blandit, tempor, sollicitudin enim, commodo, nostra, lacus proin. Per eu non, ad adipiscing et praesent vestibulum, ex augue lacinia, quis, vel scelerisque fames bibendum donec vel, suscipit posuere.", null, 1, 20, 4, 1 },
                    { 31, 19, new DateTime(2024, 1, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 8, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(4330), new DateTime(2025, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(4337), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(3536), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(4335), null, null, false, "Lectus, laoreet volutpat vel fringilla suscipit in, nunc, hendrerit massa etiam congue nisl odio, imperdiet vel, diam lorem erat, fusce. Sagittis leo diam class eros ultrices, tellus suspendisse dignissim id, rhoncus neque erat, lobortis porttitor, fusce dolor varius, nec, pretium. Proin molestie taciti sed, praesent tortor, velit luctus in, dapibus consectetur egestas eleifend ornare a, amet, amet sed congue eu.", null, 1, 21, 4, 1 },
                    { 32, 19, new DateTime(2024, 1, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 9, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5205), new DateTime(2026, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5212), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(4369), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5210), null, null, false, "Libero sed massa, aliquet consequat conubia vitae, sodales suspendisse eu phasellus ullamcorper posuere blandit quisque ligula, ornare enim consectetur odio. Etiam elementum habitasse augue venenatis dolor, tortor, magna pretium id, congue, interdum pulvinar, odio, porta maximus phasellus in nec porttitor. Faucibus torquent cras auctor dictumst ut at, dolor eget ornare felis a, orci, varius mattis tempor posuere, finibus, cursus risus.", null, 1, 22, 4, 1 },
                    { 33, 19, new DateTime(2024, 1, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 2, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5848), new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5233), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5851), null, null, false, "Praesent torquent dui, erat, condimentum efficitur litora pretium duis ligula hac lectus, nunc, cras felis id mauris maecenas urna amet. Vulputate auctor rhoncus, ornare rutrum quisque libero fringilla, odio, mi, ultricies semper turpis nisl elit, eget phasellus mi bibendum nibh. Auctor, elit, ex bibendum, pulvinar enim, arcu feugiat cursus, sagittis, integer eget odio nec nulla, rutrum a lacinia, lectus, sodales.", null, 1, 23, 4, 1 },
                    { 34, 19, new DateTime(2024, 2, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(6738), new DateTime(2023, 10, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(5869), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(6740), null, null, false, "Egestas feugiat, congue, nibh fringilla, risus aptent ornare fringilla tempor, pulvinar consequat conubia nibh, cras ullamcorper nunc, tristique amet, quis. Euismod volutpat, pretium porttitor, at venenatis erat, placerat id, nisi posuere, non, arcu feugiat, ligula, dapibus accumsan ante, sed, velit. Duis varius, turpis etiam tellus, sem aliquet donec venenatis sed diam malesuada nam fames vel, orci, leo, lectus euismod dolor.", null, 1, 24, 4, 1 },
                    { 35, 16, new DateTime(2024, 5, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(7702), new DateTime(2023, 10, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(6751), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(7704), null, null, false, "Class feugiat, platea lobortis sem tristique aptent nullam sagittis, eget donec adipiscing rhoncus laoreet dictum commodo, maximus lacus convallis mauris. Ex, fames sapien integer urna, enim auctor fringilla tellus ad cras mi, praesent fusce pharetra per sagittis, viverra eget eu. Mollis nibh, id fringilla, erat commodo, suspendisse erat, curabitur quam, vestibulum, efficitur vel vitae scelerisque euismod ut fusce lacinia nunc.", null, 1, 25, 4, 1 },
                    { 36, 20, new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 12, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(7753), 5, new DateTime(2025, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(8588), null, null, false, "Egestas amet hendrerit non adipiscing donec suscipit est fermentum cras habitasse duis inceptos rutrum lectus elit litora maecenas maximus nibh. Lobortis maecenas eros sapien dignissim laoreet elementum velit justo nullam euismod, morbi fringilla, ante nunc, commodo, hac enim ultricies mi. Iaculis rutrum a inceptos massa, auctor ac quis sodales quam mauris, non, auctor, luctus, molestie aenean vestibulum, fermentum arcu, ex.", null, 1, 26, 4, 1 },
                    { 37, 20, new DateTime(2024, 4, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(9326), new DateTime(2023, 10, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(9324), new DateTime(2026, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(9329), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(8599), 5, new DateTime(2024, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(9327), null, null, false, "Sollicitudin bibendum, sagittis nisl aptent placerat hendrerit torquent bibendum tellus euismod varius facilisis praesent odio, euismod, dui, ullamcorper risus etiam. Porttitor, quis et ligula, ultrices, eget sollicitudin nullam lectus, a pharetra dapibus etiam ullamcorper erat, urna eu felis feugiat, volutpat. Et, enim, nisl ante, scelerisque pulvinar, tristique sollicitudin integer non elit, cursus adipiscing curabitur fames urna auctor id euismod, ipsum.", null, 1, 27, 4, 1 },
                    { 38, 19, new DateTime(2023, 12, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 1, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(168), new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 11, 2, 22, 3, 19, 664, DateTimeKind.Local).AddTicks(9337), 5, new DateTime(2026, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(171), null, null, false, "Tincidunt quam vulputate primis sit tellus, neque leo mollis sagittis, lacinia libero suscipit amet, rhoncus, et, in, odio morbi malesuada. Dolor, eros, molestie nunc, morbi eget odio, nec laoreet ut placerat, praesent est dapibus feugiat tellus, ante, pulvinar, vestibulum taciti. Nisi, ultrices, porta, volutpat, tristique odio, dictum finibus luctus eros, purus quam placerat nisl amet a ultrices sociosqu quis cursus.", null, 1, 28, 4, 1 },
                    { 39, 17, new DateTime(2024, 4, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(908), new DateTime(2023, 9, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(906), new DateTime(2026, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(182), 5, new DateTime(2024, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(909), null, null, false, "Non, rhoncus eleifend sem augue sapien habitasse primis duis praesent in pretium nulla, at luctus, dui fames finibus, pulvinar vestibulum. Maximus interdum, pretium leo, suscipit in risus aptent nibh vestibulum, nulla consectetur tortor lectus pulvinar sed donec et luctus, erat. Ad cras sociosqu curabitur molestie per pulvinar quisque in fames nibh lorem semper varius amet, conubia maximus vitae, erat libero.", null, 1, 29, 4, 1 },
                    { 40, 18, new DateTime(2024, 4, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 12, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(1744), new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(1748), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(918), 5, new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(1747), null, null, false, "Dui porttitor curabitur sem, gravida id, eleifend augue erat, in, in placerat ut malesuada duis phasellus vel, luctus fringilla proin. Eros, nullam per egestas posuere cursus, turpis suscipit nisi nostra, duis quis ante eu ipsum finibus arcu felis erat, augue. Sagittis, consectetur commodo, placerat varius elit, amet neque sed, tempor, metus feugiat at, fringilla, urna, posuere, adipiscing sociosqu ligula, ornare.", null, 1, 30, 4, 1 },
                    { 41, 16, new DateTime(2024, 1, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(2501), new DateTime(2024, 2, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(2499), new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(1757), 5, new DateTime(2024, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(2503), null, null, false, "Felis blandit posuere sodales morbi ligula sagittis lectus accumsan euismod, hendrerit praesent volutpat amet massa tellus ultricies convallis venenatis blandit. Sociosqu dui, mattis, sem, faucibus sit non nec rhoncus, quisque libero nisi turpis nullam est bibendum, amet lobortis ad aenean. Enim, fames sit urna, consequat eleifend sociosqu a, semper vel, vehicula fermentum pulvinar tellus, at lectus, vitae, mi, auctor massa.", null, 1, 31, 4, 1 },
                    { 42, 20, new DateTime(2024, 5, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(3281), new DateTime(2023, 8, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(3279), new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(3284), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(2512), 5, new DateTime(2026, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(3282), null, null, false, "Magna, euismod feugiat, dictum interdum, ornare ultrices, dui, ultrices aliquet diam elit, nunc, tristique elit turpis erat vivamus risus himenaeos. Urna, quisque aptent accumsan tellus, ante, porttitor, in aliquet augue dui quam, rhoncus, est dignissim pharetra eros sed varius, pretium. Bibendum laoreet, sed, nostra, elit, eros, aliquam eros viverra feugiat amet etiam ac ornare aptent lectus massa, maecenas porttitor, suspendisse.", null, 1, 32, 4, 1 },
                    { 43, 17, new DateTime(2024, 4, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 1, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4105), new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4109), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(3292), 5, new DateTime(2024, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4108), null, null, false, "Placerat, in scelerisque metus erat aliquet luctus cursus, risus sociosqu imperdiet taciti facilisis a blandit eros, vestibulum elementum eleifend, vitae. Egestas velit tempor urna, nulla vel luctus, pulvinar, nunc curabitur pellentesque ullamcorper at blandit bibendum tincidunt imperdiet nibh mollis maximus. Ut himenaeos imperdiet neque dapibus ligula in, risus magna ex donec nisl duis mollis vulputate id, praesent commodo, posuere, non.", null, 1, 33, 4, 1 },
                    { 44, 16, new DateTime(2024, 5, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 10, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4961), new DateTime(2024, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4966), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4119), 5, new DateTime(2024, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4965), null, null, false, "Tempor, venenatis vehicula quam feugiat, accumsan interdum quis, porttitor pellentesque et praesent nostra, nibh vestibulum himenaeos felis ad morbi conubia. Nec, velit sagittis magna feugiat nunc, nec molestie ultrices, vel finibus, blandit dolor, imperdiet sapien lacinia, dolor eleifend etiam ornare. Dictum commodo consectetur hac purus facilisis eu tellus erat, pharetra odio, litora ultrices, himenaeos aptent leo proin est id, auctor.", null, 1, 34, 4, 1 },
                    { 45, 20, new DateTime(2024, 2, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 1, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(5714), new DateTime(2026, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(5718), new DateTime(2023, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(4975), 5, new DateTime(2025, 11, 2, 22, 3, 19, 665, DateTimeKind.Local).AddTicks(5716), null, null, false, "Quam nunc, facilisis laoreet aptent cursus convallis metus euismod, praesent vitae ac, pellentesque ante imperdiet porta, urna ad mattis, mollis. Orci aptent vel, praesent vestibulum, at posuere sed, blandit, ante, placerat luctus lectus fermentum in, mattis, dolor quam etiam porttitor. Vitae quam magna ac, aliquam bibendum condimentum lectus ultrices, duis sociosqu per auctor leo tempor nulla sollicitudin habitasse ex, donec.", null, 1, 35, 4, 1 },
                    { 46, 22, new DateTime(2024, 5, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(5745), new DateTime(2023, 11, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(5740), new DateTime(2025, 11, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(5750), new DateTime(2023, 11, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(4929), 5, new DateTime(2026, 11, 2, 22, 3, 20, 9, DateTimeKind.Local).AddTicks(5748), null, null, false, "Adipiscing neque nisi lacinia dolor placerat vitae fermentum elit, quis, ipsum convallis rhoncus feugiat, aliquam at vitae, aliquet rhoncus, cras. Tincidunt ad urna placerat, erat, in, orci, habitasse iaculis nulla, placerat fringilla laoreet libero non, quisque euismod mattis, eros, at. Accumsan lectus imperdiet himenaeos lacinia nunc, pharetra auctor, ut dictum maximus mauris ac laoreet, ullamcorper nisi, magna, fermentum orci, risus.", null, null, 36, 3, null },
                    { 47, 23, new DateTime(2024, 4, 2, 22, 3, 20, 78, DateTimeKind.Local).AddTicks(877), new DateTime(2023, 9, 2, 22, 3, 20, 78, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 11, 2, 22, 3, 20, 78, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 11, 2, 22, 3, 20, 77, DateTimeKind.Local).AddTicks(9919), 5, new DateTime(2024, 11, 2, 22, 3, 20, 78, DateTimeKind.Local).AddTicks(879), null, null, false, "Lacinia, lectus inceptos risus tristique tempus posuere justo consequat odio, litora bibendum, convallis urna, mollis condimentum hendrerit sit vestibulum facilisis. Varius posuere hendrerit metus consectetur nisi tellus, quis, dapibus aliquam cras lorem, curabitur risus sodales fames volutpat massa, euismod tellus. Nunc, et varius nostra, sed eu mattis ultrices, auctor tincidunt molestie interdum leo, fusce est nisi hac cursus blandit, mi.", null, null, 37, 3, null },
                    { 48, 24, new DateTime(2021, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(6232), new DateTime(2018, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(6228), new DateTime(2022, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(5272), 5, new DateTime(2022, 11, 2, 22, 3, 20, 146, DateTimeKind.Local).AddTicks(6236), null, null, false, "Dui vel, quam, tempor varius quisque nulla et, curabitur etiam fermentum porta, laoreet, nec, id congue dictumst nisi posuere, litora. Torquent purus sagittis eu, consequat viverra sociosqu placerat, phasellus eleifend, facilisis nulla, aenean luctus proin neque mauris suspendisse sed, lacus. Morbi eleifend class sit praesent aliquet ante porta, tortor, lacinia dui maximus laoreet, in tortor porta luctus, ligula molestie hendrerit.", null, 1, 38, 6, 1 },
                    { 49, 25, new DateTime(2020, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(3357), new DateTime(2018, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(3354), new DateTime(2022, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(3362), new DateTime(2023, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(2516), 5, new DateTime(2023, 11, 2, 22, 3, 20, 215, DateTimeKind.Local).AddTicks(3360), null, null, false, "Tortor, dictumst consequat lobortis elit mauris, placerat porttitor lacinia, eros arcu scelerisque varius, ipsum aliquet orci tellus, primis nulla maecenas. Etiam nulla integer et mi, mattis congue inceptos porttitor, phasellus at eros, porta, rhoncus lorem ac hac accumsan quis vehicula. Id commodo, malesuada ultricies lacinia interdum varius nulla, quam, velit neque dapibus mollis ad luctus, porttitor diam viverra laoreet rhoncus.", null, 1, 39, 6, 1 },
                    { 50, 26, new DateTime(2020, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7038), new DateTime(2018, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7034), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(6141), 5, new DateTime(2022, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7040), null, null, false, "Porttitor, commodo condimentum cursus lacinia urna eu, in eu justo rutrum egestas varius, tincidunt vivamus torquent conubia nibh euismod aptent. Finibus, molestie dapibus duis nisi elit ad fringilla, lobortis aenean nullam nibh, vestibulum, quam, cursus, sapien cras euismod vulputate eleifend. Sed, blandit, elit tempor luctus, rhoncus, libero torquent et nunc nullam eu placerat, fringilla, est nisi lectus dui vestibulum odio.", null, 1, 40, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ServiceRequests",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "InspectionRecordFilePath", "IpId", "IsDeleted", "Quantity", "RequestId", "SaleApprovalId", "ServiceId", "Status", "TechExecutionId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7071), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7071), null, null, false, 3, 6, null, 2, 0, null, null, null },
                    { 2, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7119), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7119), null, null, false, 2, 6, null, 3, 0, null, null, null },
                    { 3, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7129), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7129), null, null, false, 3, 7, null, 2, 0, null, null, null },
                    { 4, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7136), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7136), null, null, false, 2, 7, null, 1, 0, null, null, null },
                    { 5, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7143), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7143), null, null, false, 1, 8, null, 3, 0, null, null, null },
                    { 6, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7153), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7153), null, null, false, 3, 8, null, 3, 0, null, null, null },
                    { 7, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7159), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7159), null, null, false, 3, 8, null, 2, 0, null, null, null },
                    { 8, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7165), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7165), null, null, false, 1, 8, null, 1, 0, null, null, null },
                    { 9, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7172), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7172), null, null, false, 1, 9, null, 2, 0, null, null, null },
                    { 10, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7179), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7179), null, null, false, 4, 9, null, 3, 0, null, null, null },
                    { 11, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7187), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7187), null, null, false, 3, 10, null, 2, 0, null, null, null },
                    { 12, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7193), null, null, false, 3, 10, null, 1, 0, null, null, null },
                    { 13, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7202), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7202), null, null, false, 5, 11, null, 3, 2, null, null, null },
                    { 14, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7210), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7210), null, null, false, 4, 11, 1, 2, 1, null, null, null },
                    { 15, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7218), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7218), null, null, false, 4, 11, 1, 2, 1, null, null, null },
                    { 16, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7226), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7226), null, null, false, 1, 12, 1, 2, 1, null, null, null },
                    { 17, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7233), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7233), null, null, false, 3, 12, 1, 2, 1, null, null, null },
                    { 18, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7274), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7275), null, null, false, 4, 13, null, 3, 0, null, null, null },
                    { 19, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7283), null, null, false, 4, 13, null, 2, 2, null, null, null },
                    { 20, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7290), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7290), null, null, false, 5, 13, 1, 1, 1, null, null, null },
                    { 21, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7298), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7299), null, null, false, 3, 14, null, 1, 2, null, null, null },
                    { 22, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7306), null, null, false, 4, 14, 1, 2, 1, null, null, null },
                    { 23, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7313), null, null, false, 1, 14, null, 3, 2, null, null, null },
                    { 24, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7321), null, null, false, 1, 15, 1, 3, 1, null, null, null },
                    { 25, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7329), null, null, false, 5, 15, null, 2, 2, null, null, null },
                    { 26, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7339), null, null, false, 4, 16, null, 3, 2, null, null, null },
                    { 27, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7347), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7347), null, null, false, 2, 16, 1, 1, 3, 1, null, null },
                    { 28, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7355), null, null, false, 1, 16, null, 2, 0, null, null, null },
                    { 29, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7363), null, null, false, 1, 16, null, 1, 0, null, null, null },
                    { 30, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7371), null, null, false, 4, 17, 1, 3, 3, 1, null, null },
                    { 31, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7378), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7378), null, null, false, 2, 17, 1, 3, 3, 1, null, null },
                    { 32, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7386), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7386), null, null, false, 2, 17, 1, 2, 3, 1, null, null },
                    { 33, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7393), null, null, false, 2, 18, null, 1, 2, null, null, null },
                    { 34, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7430), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7431), null, null, false, 1, 18, 1, 1, 3, 1, null, null },
                    { 35, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7439), null, null, false, 3, 18, null, 2, 0, null, null, null },
                    { 36, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7446), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7446), null, null, false, 4, 18, 1, 2, 1, null, null, null },
                    { 37, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7454), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7454), null, null, false, 1, 19, 1, 1, 3, 1, null, null },
                    { 38, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7462), null, null, false, 2, 19, null, 1, 0, null, null, null },
                    { 39, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7470), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7471), null, null, false, 5, 20, null, 3, 2, null, null, null },
                    { 40, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7478), null, null, false, 5, 20, null, 1, 0, null, null, null },
                    { 41, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7485), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7485), null, null, false, 5, 20, null, 1, 2, null, null, null },
                    { 42, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7493), null, null, false, 2, 21, 1, 2, 1, null, null, null },
                    { 43, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7500), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7501), null, null, false, 4, 21, 1, 3, 1, null, null, null },
                    { 44, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7508), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7508), null, null, false, 4, 21, null, 3, 2, null, null, null },
                    { 45, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7516), null, null, false, 4, 22, 1, 2, 3, 1, null, null },
                    { 46, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7523), null, null, false, 1, 22, 1, 1, 1, null, null, null },
                    { 47, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7532), null, null, false, 2, 23, 1, 1, 3, 1, null, null },
                    { 48, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7540), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7540), null, null, false, 1, 24, 1, 2, 1, null, null, null },
                    { 49, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7547), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7547), null, null, false, 4, 24, null, 2, 0, null, null, null },
                    { 50, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7554), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7554), null, null, false, 1, 24, null, 2, 2, null, null, null },
                    { 51, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7594), null, null, false, 2, 25, null, 2, 0, null, null, null },
                    { 52, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7601), null, null, false, 3, 25, null, 3, 2, null, null, null },
                    { 53, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7607), null, null, false, 4, 25, null, 2, 0, null, null, null },
                    { 54, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7614), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7615), null, null, false, 2, 25, null, 2, 0, null, null, null },
                    { 55, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7621), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7622), null, null, false, 3, 25, null, 3, 2, null, null, null },
                    { 56, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7628), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7629), null, null, false, 1, 25, 1, 3, 3, 1, null, null },
                    { 57, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7636), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7636), null, null, false, 5, 26, null, 1, 0, null, null, null },
                    { 58, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7645), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7645), null, null, false, 4, 27, 1, 3, 3, 1, null, null },
                    { 59, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7652), null, null, false, 4, 27, null, 1, 0, null, null, null },
                    { 60, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7660), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7660), null, null, false, 3, 27, 1, 1, 3, 1, null, null },
                    { 61, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7668), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7668), null, null, false, 1, 28, null, 2, 0, null, null, null },
                    { 62, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7675), null, null, false, 4, 28, 1, 2, 3, 1, null, null },
                    { 63, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7682), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7682), null, null, false, 5, 28, null, 2, 0, null, null, null },
                    { 64, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7690), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7691), null, null, false, 4, 29, null, 1, 0, null, null, null },
                    { 65, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7698), null, null, false, 2, 29, null, 3, 0, null, null, null },
                    { 66, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7754), null, null, false, 4, 30, 1, 3, 3, 1, null, null },
                    { 67, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7762), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7762), null, null, false, 2, 30, null, 1, 0, null, null, null },
                    { 68, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7769), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7770), null, null, false, 2, 31, null, 2, 0, null, null, null },
                    { 69, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7777), null, null, false, 5, 31, 1, 3, 3, 1, null, null },
                    { 70, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7784), null, null, false, 3, 31, 1, 1, 1, null, null, null },
                    { 71, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7791), null, null, false, 3, 31, 1, 1, 3, 1, null, null },
                    { 72, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7798), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7798), null, null, false, 1, 31, 1, 2, 3, 1, null, null },
                    { 73, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7806), null, null, false, 5, 32, null, 3, 0, null, null, null },
                    { 74, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7812), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7813), null, null, false, 1, 32, 1, 1, 1, null, null, null },
                    { 75, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7819), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7820), null, null, false, 3, 32, null, 1, 2, null, null, null },
                    { 76, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7827), null, null, false, 1, 32, null, 1, 2, null, null, null },
                    { 77, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7835), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7835), null, null, false, 1, 33, 1, 3, 3, 1, null, null },
                    { 78, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7842), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7842), null, null, false, 2, 33, null, 2, 2, null, null, null },
                    { 79, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7849), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7849), null, null, false, 4, 33, null, 3, 2, null, null, null },
                    { 80, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7856), null, null, false, 4, 33, 1, 3, 3, 1, null, null },
                    { 81, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7864), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7864), null, null, false, 5, 34, 1, 3, 1, null, null, null },
                    { 82, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7906), null, null, false, 4, 34, null, 3, 0, null, null, null },
                    { 83, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7913), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7914), null, null, false, 1, 35, null, 2, 2, null, null, null },
                    { 84, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7921), null, null, false, 2, 35, 1, 1, 1, null, null, null },
                    { 85, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7928), null, null, false, 5, 35, null, 2, 0, null, null, null },
                    { 86, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7936), null, null, false, 3, 36, null, 3, 0, null, null, null },
                    { 87, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7943), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7943), null, null, false, 2, 36, 1, 3, 3, 1, null, null },
                    { 88, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7950), null, null, false, 2, 36, 1, 1, 1, null, null, null },
                    { 89, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7957), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7957), null, null, false, 3, 36, 1, 1, 1, null, null, null },
                    { 90, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7964), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7964), null, null, false, 2, 36, 1, 1, 3, 1, null, null },
                    { 91, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7972), null, null, false, 4, 37, 1, 2, 3, 1, null, null },
                    { 92, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7979), null, null, false, 1, 37, null, 1, 0, null, null, null },
                    { 93, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7986), null, null, false, 4, 37, 1, 1, 3, 1, null, null },
                    { 94, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7993), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(7993), null, null, false, 3, 37, 1, 1, 1, null, null, null },
                    { 95, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8000), null, null, false, 3, 37, 1, 2, 3, 1, null, null },
                    { 96, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8009), null, null, false, 4, 38, null, 3, 2, null, null, null },
                    { 97, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8015), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8015), null, null, false, 2, 38, 1, 2, 3, 1, null, null },
                    { 98, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8055), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8055), null, null, false, 3, 39, null, 3, 2, null, null, null },
                    { 99, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8062), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8063), null, null, false, 3, 39, null, 1, 2, null, null, null },
                    { 100, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8070), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8070), null, null, false, 3, 39, null, 1, 0, null, null, null },
                    { 101, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8077), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8078), null, null, false, 3, 40, 1, 1, 1, null, null, null },
                    { 102, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8085), null, null, false, 3, 40, null, 1, 0, null, null, null },
                    { 103, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8092), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8092), null, null, false, 5, 40, null, 2, 2, null, null, null },
                    { 104, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8100), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8101), null, null, false, 5, 41, null, 2, 2, null, null, null },
                    { 105, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8108), null, null, false, 4, 41, 1, 1, 1, null, null, null },
                    { 106, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8115), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8115), null, null, false, 5, 42, 1, 2, 1, null, null, null },
                    { 107, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8123), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8123), null, null, false, 1, 42, null, 2, 2, null, null, null },
                    { 108, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8130), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8130), null, null, false, 3, 42, 1, 1, 3, 1, null, null },
                    { 109, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8138), null, null, false, 4, 43, 1, 3, 1, null, null, null },
                    { 110, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8145), null, null, false, 3, 43, null, 1, 0, null, null, null },
                    { 111, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8153), null, null, false, 1, 43, 1, 3, 3, 1, null, null },
                    { 112, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8160), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8160), null, null, false, 1, 43, null, 3, 0, null, null, null },
                    { 113, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8168), null, null, false, 4, 44, null, 2, 0, null, null, null },
                    { 114, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8175), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8175), null, null, false, 2, 44, null, 2, 0, null, null, null },
                    { 115, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8214), null, null, false, 1, 45, 1, 2, 1, null, null, null },
                    { 116, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8221), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8221), null, null, false, 1, 45, null, 1, 0, null, null, null },
                    { 117, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8229), null, null, false, 1, 45, null, 1, 0, null, null, null },
                    { 118, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8235), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8235), null, null, false, 2, 45, 1, 3, 1, null, null, null },
                    { 119, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8243), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8244), null, null, false, 1, 46, null, 1, 2, null, null, null },
                    { 120, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8251), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8251), null, null, false, 2, 47, null, 3, 2, null, null, null },
                    { 121, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8261), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8261), null, null, false, 2, 48, null, 2, 0, null, null, null },
                    { 122, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8270), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8270), null, null, false, 3, 48, 1, 1, 3, 1, null, null },
                    { 123, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8279), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8279), null, null, false, 3, 49, null, 1, 2, null, null, null },
                    { 124, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8286), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8286), null, null, false, 1, 49, 1, 2, 1, null, null, null },
                    { 125, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8293), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8294), null, null, false, 4, 49, 1, 1, 1, null, null, null },
                    { 126, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8301), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8301), null, null, false, 2, 49, 1, 3, 3, 1, null, null },
                    { 127, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8309), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8310), null, null, false, 5, 50, 1, 2, 3, 1, null, null },
                    { 128, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8317), null, null, false, 5, 50, null, 2, 2, null, null, null },
                    { 129, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8324), null, null, false, 3, 50, null, 2, 0, null, null, null },
                    { 130, new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 11, 2, 22, 3, 20, 283, DateTimeKind.Local).AddTicks(8365), null, null, false, 2, 50, null, 3, 0, null, null, null }
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
