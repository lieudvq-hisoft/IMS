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
                    Status = table.Column<int>(type: "integer", nullable: false),
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
                name: "AppointmentSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateAppointed = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateCheckedIn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false),
                    VisitorName = table.Column<string>(type: "text", nullable: false),
                    VisitorPosition = table.Column<string>(type: "text", nullable: false),
                    VisitorEmployeedId = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    TechExecutionId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppointmentSchedules_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentSchedules_TechExecutions_TechExecutionId",
                        column: x => x.TechExecutionId,
                        principalTable: "TechExecutions",
                        principalColumn: "Id");
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
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
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
                name: "ServerAppointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentScheduleId = table.Column<int>(type: "integer", nullable: false),
                    ServerId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServerAppointments_AppointmentSchedules_AppointmentSchedule~",
                        column: x => x.AppointmentScheduleId,
                        principalTable: "AppointmentSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServerAppointments_Servers_ServerId",
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
                    { 1, 8, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2988), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2997), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2997), false, "B", 5 }
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
                    { new Guid("03a7e586-6663-4d23-89c6-000376f27e10"), 0, "A/Rutrum, Nulla vestibulum at", "4931caea-d436-48e8-941e-452111483823", 0, "eleifend@quam.com", true, "Eu ex dictumst", false, false, null, "a@lacus.com", "customer18", "AQAAAAIAAYagAAAAECamnDJYOyMuli39bHcGrRYvwxpj7cietwezDMscSE0hpuR0bShwXc7mTkxNJlowfA==", "5977899070", false, "", false, "customer18" },
                    { new Guid("0ec9ec85-b0e7-4c0c-883e-3a2540123698"), 0, "At/Dolor, Class vehicula egestas", "b13a44d4-552d-43d5-a656-cf48d924d63c", 0, "ac@semper.com", true, "Duis erat tempus", false, false, null, "nisi@ligula.com", "customer4", "AQAAAAIAAYagAAAAEMaegy9rkSteToeWYciXI6yI85MLku+qxYgQk1P/FPkUIXYX69RW/oaH1BkPqTIm3A==", "1055628718", false, "", false, "customer4" },
                    { new Guid("10fdf0f4-37d8-4cce-8435-c21d587e4e72"), 0, "Lobortis/Vestibulum, Elementum dictumst amet", "24ece903-711c-47a6-b091-adb7cf57ec80", 0, "varius@eget.com", true, "Id consectetur vehicula", false, false, null, "luctus@a.com", "customer24", "AQAAAAIAAYagAAAAEFPYeOitpCHH/3xDMPNEOinwO+E+RWKpvE+xnTLozueIhvD7jfeFmNvsifSY75n7gQ==", "2847347756", false, "", false, "customer24" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "8fc9e020-9c3a-4720-b36e-0eeb1e7eff84", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAECrLgITlKXrAQWfJT70o2GZ44gh6G+89rqsz8O+ivVpqb6M9idBrkvlsvK+uEyQ6Sw==", "0000000003", false, "", false, "sale" },
                    { new Guid("26f388cd-690a-41a0-9046-af190f6fdd92"), 0, "In/Condimentum, Tincidunt placerat lectus", "a7bfdfc2-0b98-4cdc-9724-cbffd369c508", 0, "lacus@tempor.com", true, "Tempor sem convallis", false, false, null, "posuere@vehicula.com", "customer8", "AQAAAAIAAYagAAAAEL9B46xcxWOYb2we8g9GWcst0rARzAz1338MXrjrDGrhaLMtfx73emCUBcrXvi9q1w==", "1732946391", false, "", false, "customer8" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "b5059a3d-a5cf-40ad-9746-540bcdacbf81", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEBuix5qFu9lyupQCSMKlEvXYOpx13QNsI3Pfy/7S5TXIzDnD8zIg1aKjUmGb943jbg==", "0000000005", false, "", false, "admin" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "aa1d7028-d4d3-40d6-bee5-f4eef087258d", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAELk59c/jvE9uAj7kaXNtDStnxJE94En+yrhDj2lhg6K7fOCJCkFaicqvDCIChAqy6w==", "0000000004", false, "", false, "manager" },
                    { new Guid("39c087b9-3f62-409e-b14c-ed23806547f7"), 0, "Quis/Leo, Egestas mi nunc", "ebb1f309-111e-4bf6-83af-90d94e937215", 0, "viverra@dictumst.com", true, "Condimentum orci mattis", false, false, null, "nostra@orci.com", "customer21", "AQAAAAIAAYagAAAAEOebspwQiRc2V418ishEBjQqGotrdo8pJfdEORJMU7B+x0cRMCLjP3lnsKjIMoFXvA==", "3682922698", false, "", false, "customer21" },
                    { new Guid("3dd71fb3-f7bd-4d25-bf62-30986472015b"), 0, "Ante/Nam, Laoreet congue dictumst", "6cf3040c-4200-486d-bd25-18715f3ddd6f", 0, "dui@scelerisque.com", true, "Quisque nisi interdum", false, false, null, "curabitur@erat.com", "customer13", "AQAAAAIAAYagAAAAEPWKt9LD0kUFZLF2X7KokeNf4ZJ9AcPayXGhX4FeuB4HEBizjukrc8u8i4JFUjgpag==", "1651903866", false, "", false, "customer13" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "e0389fea-bb6c-4fc5-9a6e-3680da73858f", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEHxRXKgnka1AgMbWK/TyEnP173L6CKUKrPH9dlXvLbzkDObf4jgrOELk5oUfYPYwWA==", "0000000002", false, "", false, "tech" },
                    { new Guid("4b78dd6e-e7e5-4496-bc09-7979aaf75978"), 0, "Id/Risus, Placerat velit orci", "135ccf2a-b11b-4810-8ef6-a167ebccb5c1", 0, "urna@varius.com", true, "Vitae enim ad", false, false, null, "tortor@luctus.com", "customer12", "AQAAAAIAAYagAAAAEHEQNuJ+nhZMn/djSPb/am75tyxltGlHzYJMtv3C5stNIXIlgOBpShFSVGoIn4XMKw==", "9130446812", false, "", false, "customer12" },
                    { new Guid("508aacdc-5683-4334-b885-3b4c01df2715"), 0, "Fringilla/Nec, Mattis metus lacinia", "a87ef326-ea27-4fed-b699-57e1e5364f79", 0, "laoreet@suscipit.com", true, "Elementum ad est", false, false, null, "mi@id.com", "customer15", "AQAAAAIAAYagAAAAEETSfvpNezS8VWpqfZpff5Hd1eJv3KDVmAsBqb4tRqkZ6qLYx5l3G5InJsAiyLb/ow==", "7298361516", false, "", false, "customer15" },
                    { new Guid("51a0db81-8b56-4d8b-afec-836e6181a96a"), 0, "Dapibus/Leo, Ad at elit", "b3e4b462-aaa6-406d-ab22-cdc8756a5695", 0, "fringilla@massa.com", true, "Quisque cursus pulvinar", false, false, null, "nam@arcu.com", "customer17", "AQAAAAIAAYagAAAAEFAcnIoMooC7jYbmUqe3Bl+hgK5COhCvL8m884KpBFYVl3p7Tp0szRBFEz9halD/3g==", "3173096863", false, "", false, "customer17" },
                    { new Guid("52afe920-87b3-4ff6-b235-b69a325a8a3e"), 0, "Gravida/Quisque, Mollis massa amet", "8a0388bc-6c1c-4f79-a901-707828220505", 0, "amet@ac.com", true, "Litora vitae class", false, false, null, "laoreet@lacinia.com", "customer6", "AQAAAAIAAYagAAAAENH2rbD5aZoBLsSHLr+U2iePQRT9IGSXbpaIHssskw+hhVZaX2DuAOyBkU+kaN3J+Q==", "3105397660", false, "", false, "customer6" },
                    { new Guid("558417fa-d0da-494e-b73e-b175acc330ab"), 0, "Vel/Odio, Mattis augue inceptos", "38017cc5-72eb-40ff-9f30-0d678efe4605", 0, "sapien@ultricies.com", true, "Cursus mauris auctor", false, false, null, "ante@pretium.com", "customer20", "AQAAAAIAAYagAAAAEFnM46TGtDG62/OqYTMNjn2+GR0gcPDsKPijRQxlcUh4UmBnIwpofa8I1fZldxhXDA==", "5258613841", false, "", false, "customer20" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "ae1e5702-2e56-4097-98be-db76aa2a8971", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEDtfox/0ZSStq0ahRS84oWe0kjQvGkTEsayCfvUza9nAI4oq5y+XAyO16XBvKnop+A==", "0000000001", false, "", false, "super" },
                    { new Guid("8d5adb9c-0d6f-4656-aed8-f349cebddb02"), 0, "Scelerisque/A, Tortor scelerisque finibus", "ac92c228-f3a9-4c71-b54b-6cf00712a6c8", 0, "finibus@sagittis.com", true, "Volutpat praesent quis", false, false, null, "dolor@a.com", "customer11", "AQAAAAIAAYagAAAAEIttH+7Mr7N7T6v75DTtZc2vv0YX5R4jWV8h8yeqr6mnSHi3LxT09GA1nfqpJH5MtQ==", "6700623593", false, "", false, "customer11" },
                    { new Guid("92a074c2-b565-4b00-b9f8-d9cc113b7b5c"), 0, "Diam/Facilisis, Leo tortor aenean", "5c13c9ee-c8f7-40de-99ca-0f473fbeb280", 0, "neque@dui.com", true, "Neque dignissim nibh", false, false, null, "vitae@elit.com", "customer1", "AQAAAAIAAYagAAAAENKp1Ewb3Hkg6v8w6K4Nio8WgAj14SYiweEXQQblcH9v8QC9kh2qBsVPR1GKNhu6iQ==", "7480651106", false, "", false, "customer1" },
                    { new Guid("9852259e-9884-4533-b866-87f4d0b5b0cb"), 0, "Nibh/Porta, Congue orci nec", "292c1227-41dd-4e58-a08c-dcba3fcd8583", 0, "in@lacinia.com", true, "Leo nec convallis", false, false, null, "duis@erat.com", "customer23", "AQAAAAIAAYagAAAAEE1j3qXBBAOPgCsYEomBnjur19bRxtioHjVER6tJO0G5iKHEbbEKhb3uXNG0J5H2AA==", "7516421722", false, "", false, "customer23" },
                    { new Guid("9c2c0a2b-7028-467d-b920-1ade788edba5"), 0, "Sapien/Ante, Suspendisse volutpat ex", "a1e4bddb-a21b-4a02-9c5a-7ed22ef644c3", 0, "id@dolor.com", true, "Praesent primis suspendisse", false, false, null, "non@purus.com", "customer10", "AQAAAAIAAYagAAAAEAY2n294INdUxftuQxigRKctI/z1KwOAb3uvd4xbxz0tKgk0Sel/EMiYfXZe4wgAtw==", "2917994217", false, "", false, "customer10" },
                    { new Guid("a0ea47db-4104-4b2b-97a8-60fe071a0a1f"), 0, "Varius/Nec, Hendrerit placerat porttitor", "992f31e9-946a-4d0e-8e00-9d8db0ac8610", 0, "ullamcorper@nostra.com", true, "Eu nec sociosqu", false, false, null, "quisque@ut.com", "customer25", "AQAAAAIAAYagAAAAEHrk6htFhfQ2n/t2K6ejNZoei61zN8PuLMUGfyB1NL7JRSX5DUQMeXAUmyX9exeieA==", "3824929332", false, "", false, "customer25" },
                    { new Guid("ad637cc5-9fa6-46fd-ad79-9c808598c4a1"), 0, "Sapien/Nunc, Pulvinar neque a", "b2fadcb1-ff69-4149-a7aa-660f85cb0eeb", 0, "suscipit@augue.com", true, "Molestie lacinia fringilla", false, false, null, "nunc@nisi.com", "customer5", "AQAAAAIAAYagAAAAELZZLUMrQMBqnCYuGB05y2CgzPYuRRPqpMYP0P2ThzCRZ1MEZ52geAjTEUFx0gbb9Q==", "7382318298", false, "", false, "customer5" },
                    { new Guid("b6b44886-80b1-4aef-889b-f3d81e01119b"), 0, "Turpis/Semper, Per euismod ligula", "12c9d74c-5f95-4525-9749-508f18500568", 0, "ut@class.com", true, "Laoreet magna eu", false, false, null, "bibendum@dignissim.com", "customer14", "AQAAAAIAAYagAAAAELGeB1Z7I8U2JpUSA9oktKyuYWLLX6c+wJN1qVLkFUoxf/leM9Mv1+LSlp6Z9sa6iQ==", "7800401106", false, "", false, "customer14" },
                    { new Guid("bb834ca9-9603-4aa1-9935-8b3bfcfc5640"), 0, "Sodales/Placerat, Enim sagittis at", "44632c95-75cc-4214-ac5f-76f318b62137", 0, "feugiat@auctor.com", true, "Mauris euismod elit", false, false, null, "convallis@tempus.com", "customer9", "AQAAAAIAAYagAAAAEBsloO/BJerF0/IcctSzgq6j77NOgT4igk277Hx4ovO8Rgp7mPQGk1l8DwbgMossrg==", "2992934813", false, "", false, "customer9" },
                    { new Guid("c0500300-696c-4b00-9917-812b430b9f85"), 0, "Nulla/Nostra, Vestibulum mattis imperdiet", "1df3d481-ca81-4905-a3f4-76fb005f0d3d", 0, "sapien@feugiat.com", true, "Fames elementum euismod", false, false, null, "pulvinar@himenaeos.com", "customer3", "AQAAAAIAAYagAAAAEILm1OxMKz5odM319Rti5eQLPPaYOoDBAZKnU62kdnNMy1/RwY3r8U2DBIaakgbzxQ==", "6273332572", false, "", false, "customer3" },
                    { new Guid("c106a720-f1e9-4d3d-8288-d7fd16a906bb"), 0, "Felis/Fringilla, Blandit cursus bibendum", "47139bd8-423f-4cfc-bd0b-7f0f9957e134", 0, "integer@suspendisse.com", true, "Luctus praesent orci", false, false, null, "tincidunt@interdum.com", "customer7", "AQAAAAIAAYagAAAAEGxZgtGg6d2sHz55YjiIJiATHywsdgPKtuxm0I22JNV9fUf3O4iSfTwau1CuarF+Pw==", "9953618325", false, "", false, "customer7" },
                    { new Guid("e9f11601-9f2e-45a1-b946-0346f2a94c6d"), 0, "Ultrices/Porta, Pretium ullamcorper enim", "38474360-e859-4e11-a0b8-aaa181845b7d", 0, "hendrerit@blandit.com", true, "Quis id aliquam", false, false, null, "etiam@sed.com", "customer16", "AQAAAAIAAYagAAAAEF1P8VNxAO0cWwAOTtipAuqcLTMzvEQJ/HazoCwT5KzHsXm+D3xkSFTzXO6gRN347w==", "4413805639", false, "", false, "customer16" },
                    { new Guid("ed5a8620-0421-49a8-9a83-1facfea5e262"), 0, "Volutpat/Vel, Aenean tempor interdum", "674fe9ea-b259-43bc-a846-5ace5e6216ed", 0, "etiam@proin.com", true, "Porta torquent tortor", false, false, null, "etiam@nullam.com", "customer19", "AQAAAAIAAYagAAAAEPk+vfRdZBJR5LVhModACZ5F1stIyLdvjDZFuxIwL//jkeY7mJmDsgHPjvgoo4nsxA==", "6177646843", false, "", false, "customer19" },
                    { new Guid("f0c3a4da-578f-46cf-b79a-cbfeaee44404"), 0, "Nunc/Laoreet, Venenatis velit sagittis", "6f7c9768-ebb6-4a00-8a1d-1bc95a25b25c", 0, "duis@ipsum.com", true, "Odio fusce placerat", false, false, null, "porttitor@finibus.com", "customer2", "AQAAAAIAAYagAAAAEFzzFpZux4298nUmqwEY1TbKk5ST5XpE4Vkx7aMLf0w36GBIflZh3Z4mhwm1BKXcNQ==", "1950059967", false, "", false, "customer2" },
                    { new Guid("f47da39d-6461-47d0-aaf2-2f0f3a1308ee"), 0, "Malesuada/Eleifend, Erat tellus ex", "f855c716-48a2-47bb-877d-ea20e29b633d", 0, "auctor@ante.com", true, "Varius praesent cursus", false, false, null, "et@posuere.com", "customer22", "AQAAAAIAAYagAAAAEOZC4736YFkXigdm+rbFNSYGv2m2EFscT6b9GPg3kCfJVNuqsRMxjx0e/08YPVKMIA==", "4087240247", false, "", false, "customer22" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2561), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2609), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2614), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2626), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2630), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 405, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2678), false, 7, 1, "Hub" },
                    { 2, 0, 0, 317, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2701), false, 4, 1, "Hub" },
                    { 3, 0, 0, 281, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2708), false, 6, 0, "Hub" },
                    { 4, 0, 0, 484, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2715), false, 6, 1, "Hub" },
                    { 5, 0, 0, 296, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2720), false, 8, 1, "Hub" },
                    { 6, 0, 0, 494, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2728), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2728), false, 2, 0, "Hub" },
                    { 7, 0, 0, 459, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2734), false, 5, 1, "Hub" },
                    { 8, 0, 0, 376, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2741), false, 6, 1, "Hub" },
                    { 9, 0, 0, 203, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2747), false, 7, 0, "Hub" },
                    { 10, 0, 0, 426, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2754), false, 6, 1, "Hub" },
                    { 11, 0, 0, 462, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2761), false, 5, 0, "Server" },
                    { 12, 0, 0, 219, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2767), false, 4, 0, "Server" },
                    { 13, 0, 0, 349, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2772), false, 7, 0, "Server" },
                    { 14, 0, 0, 404, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2778), false, 9, 0, "Server" },
                    { 15, 0, 0, 245, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2783), false, 6, 0, "Server" },
                    { 16, 0, 0, 442, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2793), false, 3, 0, "Server" },
                    { 17, 0, 0, 201, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2799), false, 4, 0, "Server" },
                    { 18, 0, 0, 394, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2805), false, 5, 0, "Server" },
                    { 19, 0, 0, 375, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2811), false, 9, 0, "Server" },
                    { 20, 0, 0, 272, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2816), false, 8, 0, "Server" },
                    { 21, 0, 0, 223, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2822), false, 8, 0, "Server" },
                    { 22, 0, 0, 435, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2827), false, 3, 0, "Server" },
                    { 23, 0, 0, 208, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2832), false, 9, 0, "Server" },
                    { 24, 0, 0, 213, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2837), false, 5, 0, "Server" },
                    { 25, 0, 0, 419, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2842), false, 2, 0, "Server" },
                    { 26, 0, 0, 439, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2847), false, 2, 0, "Server" },
                    { 27, 0, 0, 391, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2853), false, 2, 0, "Server" },
                    { 28, 0, 0, 423, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2858), false, 5, 0, "Server" },
                    { 29, 0, 0, 439, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2863), false, 3, 0, "Server" },
                    { 30, 0, 0, 297, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2868), false, 10, 0, "Server" },
                    { 31, 0, 0, 413, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2873), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2873), false, 8, 0, "Server" },
                    { 32, 0, 0, 262, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2878), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2879), false, 10, 0, "Server" },
                    { 33, 0, 0, 453, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2884), false, 4, 0, "Server" },
                    { 34, 0, 0, 233, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2891), false, 5, 0, "Server" },
                    { 35, 0, 0, 389, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2896), false, 8, 0, "Server" },
                    { 36, 0, 0, 280, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2906), false, 2, 0, "Server" },
                    { 37, 0, 0, 395, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2912), false, 3, 0, "Server" },
                    { 38, 0, 0, 478, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2917), false, 2, 0, "Server" },
                    { 39, 0, 0, 294, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2921), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2922), false, 9, 0, "Server" },
                    { 40, 0, 0, 317, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2927), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2927), false, 4, 0, "Server" },
                    { 41, 0, 0, 349, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2932), false, 4, 0, "Server" },
                    { 42, 0, 0, 362, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2937), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2937), false, 6, 0, "Server" },
                    { 43, 0, 0, 495, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2942), false, 3, 0, "Server" },
                    { 44, 0, 0, 328, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2948), false, 10, 0, "Server" },
                    { 45, 0, 0, 302, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2952), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2953), false, 9, 0, "Server" },
                    { 46, 0, 0, 281, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2957), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2958), false, 5, 0, "Server" },
                    { 47, 0, 0, 224, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2963), false, 10, 0, "Server" },
                    { 48, 0, 0, 291, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2969), false, 5, 2, "Server" },
                    { 49, 0, 0, 254, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2974), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2975), false, 6, 2, "Server" },
                    { 50, 0, 0, 249, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2980), false, 5, 2, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3973), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4063), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2649), "Thuê Chỗ", false, "Cấp bổ sung U", "Size" },
                    { 2, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2658), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2658), "Thêm 1U", false, "Bổ sung IP", "Ip" },
                    { 3, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(2664), "Công suất 100", false, "Thêm Port", "Port" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("03a7e586-6663-4d23-89c6-000376f27e10") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("0ec9ec85-b0e7-4c0c-883e-3a2540123698") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("10fdf0f4-37d8-4cce-8435-c21d587e4e72") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("26f388cd-690a-41a0-9046-af190f6fdd92") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("39c087b9-3f62-409e-b14c-ed23806547f7") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("3dd71fb3-f7bd-4d25-bf62-30986472015b") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4b78dd6e-e7e5-4496-bc09-7979aaf75978") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("508aacdc-5683-4334-b885-3b4c01df2715") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("51a0db81-8b56-4d8b-afec-836e6181a96a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("52afe920-87b3-4ff6-b235-b69a325a8a3e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("558417fa-d0da-494e-b73e-b175acc330ab") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("8d5adb9c-0d6f-4656-aed8-f349cebddb02") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("92a074c2-b565-4b00-b9f8-d9cc113b7b5c") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9852259e-9884-4533-b866-87f4d0b5b0cb") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9c2c0a2b-7028-467d-b920-1ade788edba5") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("a0ea47db-4104-4b2b-97a8-60fe071a0a1f") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ad637cc5-9fa6-46fd-ad79-9c808598c4a1") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b6b44886-80b1-4aef-889b-f3d81e01119b") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("bb834ca9-9603-4aa1-9935-8b3bfcfc5640") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("c0500300-696c-4b00-9917-812b430b9f85") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("c106a720-f1e9-4d3d-8288-d7fd16a906bb") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("e9f11601-9f2e-45a1-b946-0346f2a94c6d") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ed5a8620-0421-49a8-9a83-1facfea5e262") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f0c3a4da-578f-46cf-b79a-cbfeaee44404") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f47da39d-6461-47d0-aaf2-2f0f3a1308ee") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(429), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(430), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Ex quam ac", 3, new DateTime(2023, 11, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 11, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2022), false, "466693707", new Guid("92a074c2-b565-4b00-b9f8-d9cc113b7b5c") },
                    { 3, "Feugiat cursus commodo", 5, new DateTime(2023, 11, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 11, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(1446), false, "55002511", new Guid("f0c3a4da-578f-46cf-b79a-cbfeaee44404") },
                    { 4, "Lorem placerat eros", 2, new DateTime(2023, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(8697), new DateTime(2023, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(8701), false, "1399126179", new Guid("c0500300-696c-4b00-9917-812b430b9f85") },
                    { 5, "Eros class gravida", 3, new DateTime(2023, 11, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 11, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(3451), false, "860943425", new Guid("0ec9ec85-b0e7-4c0c-883e-3a2540123698") },
                    { 6, "Tortor sem dolor", 5, new DateTime(2023, 11, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 11, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(3832), false, "1977528864", new Guid("ad637cc5-9fa6-46fd-ad79-9c808598c4a1") },
                    { 7, "Tellus arcu felis", 1, new DateTime(2023, 11, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(998), new DateTime(2023, 11, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(1001), false, "1235695832", new Guid("52afe920-87b3-4ff6-b235-b69a325a8a3e") },
                    { 8, "Suspendisse eget eros", 2, new DateTime(2023, 11, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 11, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(4893), false, "1558219003", new Guid("c106a720-f1e9-4d3d-8288-d7fd16a906bb") },
                    { 9, "Elit ligula ornare", 5, new DateTime(2023, 11, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(4237), false, "1806339842", new Guid("26f388cd-690a-41a0-9046-af190f6fdd92") },
                    { 10, "Lectus dolor tristique", 1, new DateTime(2023, 11, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 11, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(7959), false, "678905443", new Guid("bb834ca9-9603-4aa1-9935-8b3bfcfc5640") },
                    { 11, "Tristique primis elementum", 3, new DateTime(2023, 11, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(5576), new DateTime(2023, 11, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(5580), false, "1390363389", new Guid("9c2c0a2b-7028-467d-b920-1ade788edba5") },
                    { 12, "Tortor cursus neque", 3, new DateTime(2023, 11, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 11, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(6773), false, "1527880046", new Guid("8d5adb9c-0d6f-4656-aed8-f349cebddb02") },
                    { 13, "Odio sem egestas", 3, new DateTime(2023, 11, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(7367), new DateTime(2023, 11, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(7370), false, "1087893569", new Guid("4b78dd6e-e7e5-4496-bc09-7979aaf75978") },
                    { 14, "Consectetur urna diam", 1, new DateTime(2023, 11, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 11, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(5173), false, "1287675870", new Guid("3dd71fb3-f7bd-4d25-bf62-30986472015b") },
                    { 15, "Auctor vel felis", 4, new DateTime(2023, 11, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 11, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(3572), false, "508714656", new Guid("b6b44886-80b1-4aef-889b-f3d81e01119b") },
                    { 16, "Lacinia id phasellus", 4, new DateTime(2023, 11, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 11, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(6837), false, "224602513", new Guid("508aacdc-5683-4334-b885-3b4c01df2715") },
                    { 17, "Dui nisi et", 1, new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(2178), false, "887443898", new Guid("e9f11601-9f2e-45a1-b946-0346f2a94c6d") },
                    { 18, "Vitae erat in", 3, new DateTime(2023, 11, 4, 22, 0, 32, 497, DateTimeKind.Local).AddTicks(6689), new DateTime(2023, 11, 4, 22, 0, 32, 497, DateTimeKind.Local).AddTicks(6692), false, "603670073", new Guid("51a0db81-8b56-4d8b-afec-836e6181a96a") },
                    { 19, "Molestie ante rhoncus", 5, new DateTime(2023, 11, 4, 22, 0, 32, 565, DateTimeKind.Local).AddTicks(6416), new DateTime(2023, 11, 4, 22, 0, 32, 565, DateTimeKind.Local).AddTicks(6419), false, "1063472761", new Guid("03a7e586-6663-4d23-89c6-000376f27e10") },
                    { 20, "Venenatis curabitur sed", 1, new DateTime(2023, 11, 4, 22, 0, 32, 633, DateTimeKind.Local).AddTicks(2494), new DateTime(2023, 11, 4, 22, 0, 32, 633, DateTimeKind.Local).AddTicks(2497), false, "1717772383", new Guid("ed5a8620-0421-49a8-9a83-1facfea5e262") },
                    { 21, "Taciti elit nisi", 1, new DateTime(2023, 11, 4, 22, 0, 32, 701, DateTimeKind.Local).AddTicks(6874), new DateTime(2023, 11, 4, 22, 0, 32, 701, DateTimeKind.Local).AddTicks(6878), false, "1307704373", new Guid("558417fa-d0da-494e-b73e-b175acc330ab") },
                    { 22, "Amet eu fermentum", 4, new DateTime(2023, 11, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 11, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(5521), false, "886656661", new Guid("39c087b9-3f62-409e-b14c-ed23806547f7") },
                    { 23, "Et blandit mollis", 2, new DateTime(2023, 11, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(2969), new DateTime(2023, 11, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(2972), false, "1755042107", new Guid("f47da39d-6461-47d0-aaf2-2f0f3a1308ee") },
                    { 24, "Dapibus blandit erat", 2, new DateTime(2023, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(4415), false, "1913364420", new Guid("9852259e-9884-4533-b866-87f4d0b5b0cb") },
                    { 25, "Dictum porta est", 1, new DateTime(2023, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(3955), false, "328026731", new Guid("10fdf0f4-37d8-4cce-8435-c21d587e4e72") },
                    { 26, "Integer sem vestibulum", 4, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(7899), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(7902), false, "1183907196", new Guid("a0ea47db-4104-4b2b-97a8-60fe071a0a1f") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4074), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4075), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4084), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4085), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4088), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4088), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4092), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4095), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4100), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4103), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4103), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4106), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4107), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4110), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4114), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4115), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4118), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4122), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4125), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4125), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4128), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4128), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4131), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4132), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4135), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4135), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4138), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4138), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4142), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4143), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4146), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4146), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4149), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4149), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4152), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4153), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4156), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4156), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4160), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4163), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4172), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4176), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4179), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4182), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4186), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4189), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4193), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4196), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4199), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4204), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4207), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4211), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4214), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4218), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4221), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4224), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4227), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4228), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4231), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4235), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4238), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4238), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4241), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4245), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4248), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4252), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4252), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4255), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4259), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4267), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4271), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4274), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4278), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4281), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4281), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4285), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4288), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4288), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4291), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4291), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4295), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4298), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4301), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4304), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4305), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4308), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4308), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4311), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4312), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4315), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4315), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4319), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4320), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4323), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4323), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4326), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4326), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4329), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4330), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4333), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4336), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4336), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4339), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4340), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4343), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4343), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4346), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4354), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4355), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4358), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4358), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4361), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4365), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4368), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4371), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4371), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4375), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4375), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4378), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4378), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4381), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4382), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4385), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4385), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4388), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4392), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4395), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4395), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4398), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4402), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4405), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4405), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4408), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4408), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4412), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4415), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4415), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4419), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4422), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4422), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4425), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4425), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4429), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4432), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4435), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4435), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4439), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4442), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4450), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4454), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4457), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4460), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4463), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4464), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4467), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4470), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4471), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4474), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4474), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4477), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4477), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4481), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4481), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4484), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4488), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4491), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4491), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4494), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4497), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4498), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4501), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4501), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4504), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4504), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4508), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4508), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4511), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4511), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4514), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4515), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4518), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4518), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4522), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4525), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4525), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4528), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4528), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4531), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4532), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4535), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4538), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4539), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4542), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4542), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4551), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4555), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4558), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4558), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4561), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4562), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4565), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4569), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4572), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4572), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4575), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4579), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4582), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4585), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4589), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4592), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4595), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4598), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4599), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4602), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4605), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4608), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4609), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4612), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4616), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4619), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4629), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4632), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4636), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4639), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4643), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4646), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4649), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4652), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4653), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4656), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4656), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4659), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4662), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4663), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4666), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4669), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4669), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4673), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4676), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4679), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4682), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4683), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4686), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4689), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4689), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4692), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4693), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4696), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4696), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4699), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4699), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4702), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4703), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4706), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4709), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4713), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4716), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4724), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4727), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4728), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4731), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4731), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4734), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4737), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4738), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4741), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4745), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4748), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4751), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4751), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4755), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4758), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4761), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4761), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4765), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4768), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4771), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4771), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4774), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4775), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4778), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4781), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4784), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4785), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4788), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4791), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4792), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4795), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4798), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4798), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3002), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3017), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3025), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3039), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3046), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3054), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3061), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3069), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3008), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3019), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3032), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3032), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3039), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3048), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3055), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3062), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3070), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3009), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3020), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3033), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3040), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3048), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3056), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3063), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3071), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3010), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3020), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3021), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3034), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3041), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3049), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3049), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3056), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3056), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3064), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3072), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3012), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3022), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3035), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3042), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3042), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3050), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3057), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3064), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3073), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3014), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3022), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3036), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3043), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3051), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3058), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3065), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3074), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3015), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3023), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3037), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3044), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3052), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3059), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3066), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3066), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3075), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3016), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3024), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3038), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3045), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3053), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3060), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3067), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3076), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3077), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3077), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3083), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3083), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3088), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3093), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3097), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3106), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3111), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3111), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3115), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3115), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3079), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3084), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3089), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3093), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3093), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3098), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3107), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3112), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3116), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3080), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3085), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3085), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3090), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3090), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3094), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3099), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3108), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3112), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3113), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3117), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3117), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3081), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3081), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3086), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3086), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3091), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3095), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3099), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3109), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3109), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3114), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3118), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3118), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3082), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3087), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3087), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3092), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3096), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3096), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3100), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3110), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3110), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3114), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3114), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3119), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3119), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "SaleApprovals",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "SaleId" },
                values: new object[] { 1, new DateTime(2023, 11, 4, 22, 0, 31, 171, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 11, 4, 22, 0, 31, 171, DateTimeKind.Local).AddTicks(7656), false, new Guid("1abb6e28-793d-460f-8a24-745998356da8") });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(4808), 11, false, "Facilisis ante conubia", 1, "11635cbb-64b1-4d81-8b92-ca57a422dceb" },
                    { 2, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5159), 12, false, "Justo fames tempor", 1, "6ca80f43-1089-4c32-a5f3-b6cc29910f8a" },
                    { 3, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5364), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5365), 13, false, "Magna pharetra nostra", 1, "b0c9b226-80a2-4850-9f54-819abed85f1d" },
                    { 4, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5556), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5556), 14, false, "Tempor purus eros", 1, "9d09920d-1581-45bb-82cd-b004d0900c69" },
                    { 5, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5753), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5754), 15, false, "Blandit laoreet eget", 1, "2fe62549-741c-4b01-b2da-8b53783f8dec" },
                    { 6, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5950), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5950), 16, false, "Litora platea odio", 1, "4a14d3d2-e4c0-44a8-bb7e-9dd846de13cf" },
                    { 7, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6157), 17, false, "Magna volutpat ultricies", 1, "f87c2c60-5748-4be2-b8a1-56582249798c" },
                    { 8, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6388), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6388), 18, false, "Gravida eros ac", 1, "c824c159-db88-4bfc-8c47-a1473f2642f1" },
                    { 9, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6574), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6575), 19, false, "Venenatis tellus neque", 1, "deeb4b5f-5b68-49f1-a7c9-8d6d31b4c4ea" },
                    { 10, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6774), 20, false, "Interdum pharetra arcu", 1, "196a9d6b-0618-4d60-a9b3-da8b335dfc4f" },
                    { 11, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6955), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6955), 21, false, "Nullam ornare in", 1, "c3e03691-9c37-4765-8c67-a34b62b5b704" },
                    { 12, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7251), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7252), 22, false, "Dui sagittis gravida", 1, "ea08ede3-7482-4247-b225-44e2c34ba018" },
                    { 13, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7431), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7431), 23, false, "Dolor ex interdum", 1, "bd2bb712-bfc0-4265-aa75-fec28406e8b6" },
                    { 14, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7599), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7600), 24, false, "Justo porta bibendum", 1, "6fb5d389-4524-4ec8-8238-063793b590fb" },
                    { 15, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7813), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7814), 25, false, "Dapibus sit dui", 1, "497b04dc-7637-40b5-9dfc-dffcb4034d0d" },
                    { 16, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7984), 26, false, "Sit lectus varius", 1, "99b88214-7f1b-4bad-a985-d2a7af428267" },
                    { 17, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8199), 27, false, "Ex curabitur dignissim", 1, "8c8e863a-a1d1-4948-9b05-583c56e578f0" },
                    { 18, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8413), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8413), 28, false, "Dui neque volutpat", 1, "f52231d8-b286-4821-b171-1228076a63b2" },
                    { 19, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8590), 29, false, "Vestibulum ante arcu", 1, "f77f8d72-c1b7-4824-877a-bf4e5d6211ec" },
                    { 20, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8796), 30, false, "Eget urna eros", 1, "e710c47a-9f22-4554-a48f-f53c763bb559" },
                    { 21, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9016), 31, false, "Elit donec dolor", 1, "62dafa69-0059-4f20-b5e5-1de879f96939" },
                    { 22, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9245), 32, false, "Varius class faucibus", 1, "5147d095-3ba6-4edc-abaf-a89d63fe7968" },
                    { 23, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9456), 33, false, "Efficitur eget donec", 1, "4f497bae-c961-4c91-861b-afd031535baf" },
                    { 24, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9645), 34, false, "Convallis sem sagittis", 1, "3b00b6a9-60cb-456c-963b-0aa85fef1754" },
                    { 25, 0, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9862), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9862), 35, false, "Litora volutpat tempor", 1, "7c9cc819-657e-4eb0-8693-473a5777f654" },
                    { 26, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(71), 36, false, "Suscipit iaculis vestibulum", 1, "1d6c1112-f9cd-44c9-84bd-67c34f06d055" },
                    { 27, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(343), 37, false, "Lacinia eleifend tempor", 1, "1aa2890e-3e83-4d57-b55d-a798d0cf74a9" },
                    { 28, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(557), 38, false, "Nec et lacinia", 1, "c040d9a4-452a-43c1-96f9-ee4532933821" },
                    { 29, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(752), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(753), 39, false, "Magna donec fermentum", 1, "ea2d9ac2-dc02-4434-be53-2c7e69ed306f" },
                    { 30, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(926), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(926), 40, false, "Dictum tristique lacinia", 1, "10b476e7-03b2-4229-9af5-147ab409c5bf" },
                    { 31, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1122), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1122), 41, true, "Mi amet ullamcorper", 1, "3d5254f6-e6da-4d5b-842b-c951a4927026" },
                    { 32, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1315), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1315), 42, true, "Mi pretium luctus", 1, "90b5085d-dd4d-4764-b34e-10ee7bb6bce6" },
                    { 33, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1526), 43, false, "Maximus class vitae", 1, "f2153ec7-a80f-4653-aab1-480ffa319dc3" },
                    { 34, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1815), 44, false, "Arcu venenatis torquent", 1, "407d47e9-48d1-4cb6-9f10-1405dda303fe" },
                    { 35, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2057), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2057), 45, false, "Aliquam ut primis", 1, "4881061b-d01e-4a03-9a43-d032c3124197" },
                    { 36, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2384), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2385), 46, false, "Cursus eu auctor", 1, "8de37bae-a751-41f9-ac78-5ef069d123cc" },
                    { 37, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2659), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2659), 47, false, "Ultrices bibendum eros", 1, "b97b665a-dd7f-40dd-975c-3f5e4dfe191b" },
                    { 38, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2940), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2940), 48, false, "Cursus nisl quam", 1, "5bd00429-74a7-4570-8baf-3147d8db272f" },
                    { 39, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3187), 49, false, "Porttitor a morbi", 1, "3ba7f450-42d5-478b-95d8-224cae0c9d63" },
                    { 40, 0, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3477), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3477), 50, false, "Tincidunt lacus congue", 1, "d3907cba-34aa-4bd6-b361-49659f0cdac0" }
                });

            migrationBuilder.InsertData(
                table: "TechExecutions",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "TechId" },
                values: new object[] { 1, new DateTime(2023, 11, 4, 22, 0, 31, 89, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 11, 4, 22, 0, 31, 89, DateTimeKind.Local).AddTicks(5143), false, new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsDeleted", "ServerId", "Status", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(5150), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5148), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5148), 4, false, 1, 2, 0 },
                    { 2, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5359), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5359), 5, false, 2, 2, 0 },
                    { 3, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(5552), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5551), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5551), 6, false, 3, 2, 0 },
                    { 4, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(5750), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5749), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5749), 7, false, 4, 2, 0 },
                    { 5, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(5945), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5944), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(5945), 8, false, 5, 2, 0 },
                    { 6, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(6153), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6152), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6152), 9, false, 6, 2, 0 },
                    { 7, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(6384), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6383), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6384), 10, false, 7, 2, 0 },
                    { 8, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(6570), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6570), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6570), 11, false, 8, 2, 0 },
                    { 9, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6768), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6768), 12, false, 9, 2, 0 },
                    { 10, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(6951), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6951), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(6951), 13, false, 10, 2, 0 },
                    { 11, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(7241), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7241), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7241), 14, false, 11, 2, 0 },
                    { 12, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(7427), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7427), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7427), 15, false, 12, 2, 0 },
                    { 13, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(7596), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7595), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7596), 16, false, 13, 2, 0 },
                    { 14, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(7810), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7809), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7810), 17, false, 14, 2, 0 },
                    { 15, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7980), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(7980), 18, false, 15, 2, 0 },
                    { 16, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(8195), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8194), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8195), 19, false, 16, 2, 0 },
                    { 17, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(8408), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8407), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8408), 20, false, 17, 2, 0 },
                    { 18, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(8586), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8586), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8586), 21, false, 18, 2, 0 },
                    { 19, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(8792), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8792), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(8792), 22, false, 19, 2, 0 },
                    { 20, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(9013), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9012), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9012), 23, false, 20, 2, 0 },
                    { 21, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(9241), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9241), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9241), 24, false, 21, 2, 0 },
                    { 22, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(9452), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9451), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9452), 25, false, 22, 2, 0 },
                    { 23, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(9642), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9641), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9642), 26, false, 23, 2, 0 },
                    { 24, new DateTime(2023, 11, 4, 15, 0, 30, 950, DateTimeKind.Utc).AddTicks(9858), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9858), null, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(9858), 27, false, 24, 2, 0 },
                    { 25, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(68), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(67), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(67), 28, false, 25, 2, 0 },
                    { 26, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(339), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(338), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(338), 29, false, 26, 2, 0 },
                    { 27, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(553), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(552), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(553), 30, false, 27, 2, 0 },
                    { 28, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(748), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(748), 31, false, 28, 2, 0 },
                    { 29, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(922), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(922), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(922), 32, false, 29, 2, 0 },
                    { 30, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1118), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1118), 33, false, 30, 2, 0 },
                    { 31, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(1311), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1310), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1310), 34, true, 31, 1, 0 },
                    { 32, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1521), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1522), 35, true, 32, 1, 0 },
                    { 33, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(1808), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1808), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(1808), 36, false, 33, 2, 0 },
                    { 34, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(2053), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2052), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2052), 37, false, 34, 2, 0 },
                    { 35, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(2381), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2380), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2380), 38, false, 35, 2, 0 },
                    { 36, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(2655), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2654), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2655), 39, false, 36, 2, 0 },
                    { 37, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(2936), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2935), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(2936), 40, false, 37, 2, 0 },
                    { 38, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(3183), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3182), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3183), 41, false, 38, 2, 0 },
                    { 39, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(3473), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3472), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3473), 42, false, 39, 2, 0 },
                    { 40, new DateTime(2023, 11, 4, 15, 0, 30, 951, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3842), null, new DateTime(2023, 11, 4, 22, 0, 30, 951, DateTimeKind.Local).AddTicks(3843), 43, false, 40, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3824), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3824), 1, false, 1, 20 },
                    { 2, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3835), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3835), 2, false, 2, 8 },
                    { 3, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3840), 3, false, 3, 23 },
                    { 4, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3844), 4, false, 4, 6 },
                    { 5, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3848), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3848), 5, false, 5, 14 },
                    { 6, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3853), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3853), 6, false, 6, 1 },
                    { 7, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3857), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3858), 7, false, 7, 24 },
                    { 8, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3867), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3868), 8, false, 8, 19 },
                    { 9, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3872), 9, false, 9, 3 },
                    { 10, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3877), 10, false, 10, 19 },
                    { 11, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3881), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3881), 11, false, 11, 23 },
                    { 12, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3885), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3885), 12, false, 12, 18 },
                    { 13, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3889), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3889), 13, false, 13, 25 },
                    { 14, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3893), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3893), 14, false, 14, 30 },
                    { 15, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3897), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3897), 15, false, 15, 1 },
                    { 16, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3901), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3901), 16, false, 16, 9 },
                    { 17, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3905), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3905), 17, false, 17, 10 },
                    { 18, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3910), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3911), 18, false, 18, 14 },
                    { 19, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3914), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3915), 19, false, 19, 8 },
                    { 20, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3919), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3919), 20, false, 20, 23 },
                    { 21, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3923), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3923), 21, false, 21, 21 },
                    { 22, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3926), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3927), 22, false, 22, 9 },
                    { 23, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3930), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3931), 23, false, 23, 23 },
                    { 24, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3934), 24, false, 24, 7 },
                    { 25, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3938), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3938), 25, false, 25, 15 },
                    { 26, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3942), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3942), 26, false, 26, 7 },
                    { 27, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3947), 27, false, 27, 21 },
                    { 28, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3951), 28, false, 28, 28 },
                    { 29, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3955), 29, false, 29, 5 },
                    { 30, new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3958), new DateTime(2023, 11, 4, 22, 0, 30, 950, DateTimeKind.Local).AddTicks(3959), 30, false, 30, 11 }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "SaleApprovalId", "ServerId", "Status", "TechExecutionId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 11, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 1, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2896), new DateTime(2026, 11, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2905), new DateTime(2023, 11, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2257), 5, new DateTime(2025, 11, 4, 22, 0, 31, 388, DateTimeKind.Local).AddTicks(2903), null, null, false, "Eu sollicitudin tellus, non enim, aliquam feugiat suspendisse aliquet phasellus dignissim pretium vestibulum, mattis, risus euismod, orci, euismod arcu, ullamcorper. Rhoncus, integer fermentum porta dapibus nulla, habitasse consectetur vestibulum, suspendisse elementum ornare lectus tellus, at, quis, odio porttitor, viverra ut. Ipsum duis aptent habitasse facilisis ex quam, ullamcorper id morbi ornare lorem mi, litora conubia varius lectus, ligula fermentum ac.", null, null, null, 0, null },
                    { 2, 3, new DateTime(2024, 4, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(2385), new DateTime(2023, 8, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 11, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(2389), new DateTime(2023, 11, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(1695), 5, new DateTime(2026, 11, 4, 22, 0, 31, 465, DateTimeKind.Local).AddTicks(2387), null, null, false, "Ligula, facilisis tellus vestibulum, imperdiet himenaeos varius, dignissim dictumst egestas massa, eget sit augue proin pulvinar, sagittis a id nulla. Finibus viverra maecenas lacinia quam, tristique dapibus faucibus sodales pharetra sed enim, commodo, diam ut adipiscing porta, fringilla, quisque ad. Mollis scelerisque tortor, dui, ligula, ante a, eu porttitor ex vel, fringilla libero urna, faucibus semper tempor metus eget egestas.", null, null, null, 0, null },
                    { 3, 4, new DateTime(2023, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(9551), new DateTime(2023, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(9547), new DateTime(2025, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(8917), 5, new DateTime(2026, 11, 4, 22, 0, 31, 534, DateTimeKind.Local).AddTicks(9553), null, null, false, "Volutpat, tempus nec quis pulvinar odio, eu porta justo sagittis, torquent sollicitudin varius ligula quisque pellentesque auctor, etiam finibus nisi. Turpis sociosqu ac molestie tempor nulla, ipsum quam ad enim magna, ut fringilla, volutpat, donec at, velit tortor, eros quisque. Vehicula vulputate suspendisse pharetra dui, ad sociosqu aliquam sapien taciti ullamcorper risus pretium pellentesque eget porttitor, magna dictum vitae duis.", null, null, null, 0, null },
                    { 4, 5, new DateTime(2024, 3, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 10, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(4359), new DateTime(2025, 11, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(4368), new DateTime(2023, 11, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(3685), 5, new DateTime(2026, 11, 4, 22, 0, 31, 603, DateTimeKind.Local).AddTicks(4366), null, null, false, "Blandit, sem, dolor, imperdiet ex, gravida fringilla, himenaeos duis neque, suscipit nibh enim leo, pulvinar, risus porttitor lacus mauris, rhoncus. Viverra leo, urna, in, non lorem, ad at, placerat ultrices, fermentum pulvinar ac consectetur gravida tellus sodales vivamus dignissim tempus. Faucibus volutpat, lacinia, facilisis ante tincidunt luctus conubia odio leo posuere cursus pharetra pellentesque nisl taciti egestas vitae, libero lorem.", null, null, null, 0, null },
                    { 5, 6, new DateTime(2024, 1, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 2, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 11, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(4751), new DateTime(2023, 11, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(4109), 5, new DateTime(2026, 11, 4, 22, 0, 31, 673, DateTimeKind.Local).AddTicks(4749), null, null, false, "In auctor, maximus vehicula consequat fringilla, magna amet eros varius, volutpat sed augue urna ante efficitur laoreet interdum sit posuere. Placerat, mi, vehicula pulvinar commodo ultrices, ante duis interdum, sollicitudin primis platea tempor sagittis, in magna cras quis, mauris, porttitor. Dapibus eros malesuada curabitur velit porta tellus, risus eu, enim lobortis finibus luctus, laoreet, facilisis quam a, nam massa, augue.", null, null, null, 0, null },
                    { 6, 7, new DateTime(2024, 1, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(1959), new DateTime(2023, 11, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 11, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 11, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(1285), 5, new DateTime(2024, 11, 4, 22, 0, 31, 742, DateTimeKind.Local).AddTicks(1961), null, null, false, "Accumsan integer mollis congue urna, dui, lorem, mauris, leo, proin nulla, quam morbi fermentum litora mattis torquent luctus, dolor, ultricies. Turpis platea porta, a, dui, neque dolor, auctor, mattis, ad volutpat molestie felis erat, amet, odio tortor feugiat elit pretium. Feugiat, id, ante, in finibus consectetur tellus leo arcu, adipiscing porttitor, suspendisse sodales gravida dignissim bibendum, eros finibus, pharetra interdum.", null, null, null, 1, null },
                    { 7, 8, new DateTime(2023, 11, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 2, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(6045), new DateTime(2025, 11, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(5223), 5, new DateTime(2025, 11, 4, 22, 0, 31, 810, DateTimeKind.Local).AddTicks(6051), null, null, false, "Rhoncus tincidunt accumsan ligula imperdiet massa, ultrices, sociosqu lobortis ac conubia elementum amet convallis eget feugiat, dignissim himenaeos nisl euismod. Hendrerit at, condimentum venenatis lectus in, libero nulla, vitae mollis ultrices, fusce eleifend ad litora vestibulum sagittis aenean felis nibh. Habitasse torquent commodo, laoreet, tellus nam venenatis sollicitudin erat felis odio, aliquet iaculis mi amet, est consequat sit arcu finibus.", null, null, null, 1, null },
                    { 8, 9, new DateTime(2024, 2, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 8, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(5121), new DateTime(2026, 11, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 11, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(4498), 5, new DateTime(2024, 11, 4, 22, 0, 31, 879, DateTimeKind.Local).AddTicks(5128), null, null, false, "Aptent etiam accumsan ligula, velit imperdiet mauris, pellentesque finibus ullamcorper nunc, arcu, faucibus class urna, sollicitudin neque, pulvinar volutpat rhoncus. Facilisis vulputate congue, vehicula integer dictum tempor, odio, diam nulla quis, fusce elit, sodales rutrum condimentum cursus, lacus amet mi. Erat, erat arcu amet faucibus luctus, accumsan sed sollicitudin pellentesque morbi elit, nisi, magna, eu vulputate curabitur eros, sed, condimentum.", null, null, null, 1, null },
                    { 9, 10, new DateTime(2024, 3, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 9, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 11, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 11, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(8209), 5, new DateTime(2025, 11, 4, 22, 0, 31, 947, DateTimeKind.Local).AddTicks(8968), null, null, false, "Platea urna nisi tellus, eu ullamcorper aenean sed, porttitor, interdum enim nulla, facilisis consectetur sollicitudin erat feugiat bibendum dictumst pulvinar. Arcu, aliquet varius, tellus integer pellentesque sem lorem dolor porttitor vehicula eros feugiat eros, diam vivamus aptent odio, congue turpis. Gravida orci, eu a, in per convallis curabitur odio et pellentesque molestie inceptos tincidunt massa torquent sit condimentum ante ligula.", null, null, null, 1, null },
                    { 10, 11, new DateTime(2024, 2, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 1, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(6763), new DateTime(2024, 11, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 11, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(5804), 5, new DateTime(2026, 11, 4, 22, 0, 32, 16, DateTimeKind.Local).AddTicks(6770), null, null, false, "Sodales nulla porta, elit mattis, eu ac, tortor egestas volutpat eget eu, cursus consectetur porttitor nullam taciti scelerisque euismod odio. A justo mauris, purus ante, amet nec, lacinia, sagittis pulvinar, urna tortor leo laoreet, at class ipsum commodo, tempor nostra. Cras ullamcorper sagittis vehicula ultricies blandit, sapien elementum consectetur pretium eu quis, ultrices, mollis inceptos ultrices et, lorem, vel, lacinia.", null, null, null, 1, null },
                    { 11, 12, new DateTime(2024, 5, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(7996), new DateTime(2023, 11, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(7990), new DateTime(2025, 11, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(8000), new DateTime(2023, 11, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(7087), 5, new DateTime(2024, 11, 4, 22, 0, 32, 84, DateTimeKind.Local).AddTicks(7998), null, null, false, "Ante eget pulvinar, dictumst vestibulum lacinia, aptent sed mi tempor magna, fames at a scelerisque feugiat hendrerit eros nec, varius. Pharetra eros, consectetur nec, tellus, non, orci euismod, porta imperdiet sit ligula sed dui ante, leo, eleifend erat, at ante. Cras litora mi eleifend consectetur ex orci, varius, laoreet, pharetra purus eu torquent sapien mauris fames aliquet lectus, ligula tempus.", null, 1, 1, 2, null },
                    { 12, 13, new DateTime(2023, 11, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 8, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(8480), new DateTime(2026, 11, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 11, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(7662), 5, new DateTime(2025, 11, 4, 22, 0, 32, 152, DateTimeKind.Local).AddTicks(8490), null, null, false, "Praesent tempor accumsan nulla, mattis, purus vel, et, suscipit porttitor, ornare posuere elit, in congue, urna, feugiat duis dictum a. Vivamus sagittis elementum praesent tempus fames viverra vehicula placerat etiam mi dapibus eget ullamcorper finibus, quis, vulputate integer vel volutpat. Blandit faucibus ante pulvinar, metus pulvinar arcu taciti imperdiet lorem, nibh, adipiscing semper sem, habitasse tincidunt duis fusce quis morbi.", null, 1, 2, 2, null },
                    { 13, 14, new DateTime(2024, 1, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(6114), new DateTime(2023, 8, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(6110), new DateTime(2025, 11, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(6119), new DateTime(2023, 11, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(5426), 5, new DateTime(2025, 11, 4, 22, 0, 32, 220, DateTimeKind.Local).AddTicks(6117), null, null, false, "Pulvinar auctor praesent porta, facilisis sem, lectus dapibus congue, dolor, duis nostra, sollicitudin tempor, porta efficitur libero gravida quam sodales. Sed magna suscipit odio aliquam varius, orci, finibus donec dui rutrum quis lobortis gravida et at, tincidunt mauris urna, tortor. Primis libero vivamus felis a ultricies sodales dapibus mi, taciti elit, lobortis urna, tempus risus porttitor interdum luctus, pellentesque sem.", null, 1, 3, 2, null },
                    { 14, 15, new DateTime(2024, 3, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 12, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(4854), new DateTime(2026, 11, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(4864), new DateTime(2023, 11, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(4164), 5, new DateTime(2024, 11, 4, 22, 0, 32, 290, DateTimeKind.Local).AddTicks(4862), null, null, false, "Magna pharetra lorem, fringilla, molestie sem, hendrerit nam tempor, tellus commodo, mauris tincidunt cras habitasse aenean orci varius nullam euismod. Sit congue, proin fames sagittis, augue conubia eleifend blandit facilisis consequat placerat mi nulla arcu, porttitor, sodales at id mattis. Ac mi erat, tortor, ligula blandit, aliquam ultrices, odio, dictum ex, ullamcorper varius euismod in, venenatis magna ex sapien aliquet.", null, 1, 4, 2, null },
                    { 15, 16, new DateTime(2024, 3, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 9, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(7705), new DateTime(2025, 11, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(7716), new DateTime(2023, 11, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(7060), 5, new DateTime(2026, 11, 4, 22, 0, 32, 358, DateTimeKind.Local).AddTicks(7714), null, null, false, "Mattis, at placerat nisl rutrum dolor porta blandit, posuere, ex, lacinia, feugiat fringilla, arcu, tempor quam sollicitudin gravida enim a. Non vitae, aliquet elit consectetur et nibh, fringilla, mauris orci enim mattis, cursus urna, mauris, est laoreet, egestas vulputate duis. Vel accumsan ut laoreet auctor morbi eu, ultricies donec fames porttitor egestas volutpat sed, magna, ac, aliquam mi quis litora.", null, 1, 5, 2, null },
                    { 16, 16, new DateTime(2024, 5, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(3297), new DateTime(2024, 1, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(3292), new DateTime(2025, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(2391), 5, new DateTime(2025, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(3299), null, null, false, "Non, enim, lobortis justo viverra sagittis, volutpat risus malesuada etiam ligula, lectus primis efficitur aenean nulla eleifend, id, ante, nullam. Lectus, sem tortor, ligula, urna, consequat amet sem, orci eleifend, lacinia scelerisque amet, sodales convallis massa, volutpat in tristique dictumst. Euismod, finibus, consequat inceptos dolor, auctor quis leo, ac, vehicula et malesuada interdum eu, lacinia est cursus ultrices, nibh, aenean.", null, 1, 6, 4, 1 },
                    { 17, 16, new DateTime(2024, 2, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4123), new DateTime(2023, 12, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4122), new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4126), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(3339), 5, new DateTime(2025, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4125), null, null, false, "At rhoncus, auctor, neque, vitae elit, euismod nunc, placerat, porta massa vel interdum amet eu, mauris bibendum, odio, consectetur velit. At, faucibus sollicitudin ligula, mauris magna ultrices, luctus, iaculis metus eget praesent quisque sagittis, sagittis fames consequat tellus finibus, porta. Taciti nulla, libero auctor lorem tortor, inceptos quis, hac porta, consectetur turpis duis ultrices eget quam, pulvinar, odio leo, euismod.", null, 1, 7, 4, 1 },
                    { 18, 19, new DateTime(2024, 2, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 8, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4990), new DateTime(2026, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4180), 5, new DateTime(2026, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(4993), null, null, false, "Nostra, luctus, vestibulum etiam malesuada pulvinar, laoreet proin tempus id rhoncus lorem, in, eu, rhoncus, eros, nibh, nunc donec finibus. Ut orci urna, libero egestas tempor pulvinar, feugiat, faucibus tempor, vitae aptent congue porttitor, pharetra laoreet tortor metus sit commodo. Primis nostra, lobortis at bibendum, nunc, quam turpis integer dui, mi fusce quis, ultrices, arcu, amet lacinia non, euismod tristique.", null, 1, 8, 4, 1 },
                    { 19, 20, new DateTime(2024, 3, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 1, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(5862), new DateTime(2025, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(5004), 5, new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(5865), null, null, false, "Mauris, viverra augue habitasse purus laoreet auctor, quisque fringilla, nibh, eleifend, platea inceptos egestas consectetur ligula metus torquent bibendum, magna. Conubia arcu, ante euismod, ut ultricies eleifend interdum, suscipit sed, maecenas phasellus quis, nulla eu mi urna dui eros inceptos. Mi eros, feugiat, interdum hac scelerisque turpis tempor, eleifend dictumst amet et, bibendum, pellentesque ultrices, semper sed lorem id, per.", null, 1, 9, 4, 1 },
                    { 20, 16, new DateTime(2024, 3, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(6645), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(6643), new DateTime(2025, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(6647), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(5877), 5, new DateTime(2025, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(6646), null, null, false, "Elementum dapibus tortor commodo dui, dictum nisl cursus, euismod odio, et dictumst amet, luctus, gravida nunc orci, scelerisque purus pulvinar. Congue, ut ultrices, arcu, justo lacus nostra, sapien scelerisque tortor massa nulla, dolor mollis sed, nisi duis mattis tortor, pretium. Placerat, pulvinar, ligula in fringilla, euismod egestas lorem, libero lacinia, tincidunt eget faucibus volutpat, ac tellus vitae leo, lectus, euismod.", null, 1, 10, 4, 1 },
                    { 21, 16, new DateTime(2024, 1, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 9, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(7453), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(6656), 5, new DateTime(2026, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(7451), null, null, false, "Orci sociosqu id, ipsum tellus nisi, odio, eleifend enim primis posuere sodales vulputate turpis non, quis, mollis suspendisse nunc, nibh. Interdum, ante arcu, fermentum bibendum, vivamus odio, tempor laoreet turpis proin vestibulum augue pulvinar, ligula eros, lacinia, class etiam per. Nisi metus ornare placerat, fermentum non, augue porttitor lobortis mi, duis sodales dui massa ex, sem eleifend, blandit tincidunt feugiat.", null, 1, 11, 4, 1 },
                    { 22, 18, new DateTime(2024, 4, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(8260), new DateTime(2023, 9, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(8259), new DateTime(2026, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(8263), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(7461), 5, new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(8262), null, null, false, "Condimentum platea mi in, elit laoreet enim, posuere, aliquet amet, eu auctor, suspendisse mauris, sapien lorem maximus accumsan felis curabitur. Vitae suscipit nunc mi, egestas mauris curabitur odio, blandit, quis arcu ac, sed amet malesuada consequat litora ullamcorper enim, id. Arcu morbi fringilla, lectus, sem, adipiscing fames viverra eget ultrices, bibendum eu, turpis primis faucibus urna conubia dictumst velit himenaeos.", null, 1, 12, 4, 1 },
                    { 23, 18, new DateTime(2024, 2, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 9, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(8273), 5, new DateTime(2026, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9129), null, null, false, "Dolor pulvinar, leo nulla euismod, porttitor ligula luctus, laoreet, sociosqu enim, eros mauris lacinia rutrum sodales amet nec porttitor, torquent. Nisl at, nulla, nunc lacinia id, hac litora curabitur cursus viverra platea ad per feugiat, dui, conubia ex inceptos leo. Vestibulum, vivamus suscipit tellus laoreet, tortor, pulvinar gravida leo litora fringilla, eleifend elit, posuere, vitae, himenaeos nec vitae at facilisis.", null, 1, 13, 4, 1 },
                    { 24, 18, new DateTime(2024, 6, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9926), new DateTime(2024, 1, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9929), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9140), 5, new DateTime(2024, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9928), null, null, false, "Vestibulum, dictumst nulla blandit mollis in, fusce aptent auctor sem arcu nibh, vivamus varius, rhoncus sit luctus mi augue quam. Neque, quam risus facilisis hac ac morbi lorem, inceptos lobortis egestas eu, cursus, taciti tempus platea elit massa, neque ultricies. Proin rhoncus nibh, ornare volutpat, enim, class at tempus interdum mi quis quisque ante, accumsan pharetra bibendum tortor, tristique nisl.", null, 1, 14, 4, 1 },
                    { 25, 17, new DateTime(2024, 2, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(698), new DateTime(2024, 2, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(697), new DateTime(2025, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(701), new DateTime(2023, 11, 4, 22, 0, 32, 427, DateTimeKind.Local).AddTicks(9938), 5, new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(700), null, null, false, "Ornare porttitor, enim hendrerit magna, ac, taciti ligula, commodo, aliquam ante, nisi, commodo tortor aliquet dolor, fames vestibulum, quam, nibh. Fusce porttitor, auctor, semper rhoncus mi, pharetra lectus, vestibulum, lectus libero lacinia, laoreet dolor nibh, ut vulputate hendrerit bibendum eu. Imperdiet lorem est tristique varius ex amet tincidunt tempor malesuada conubia a turpis commodo, sem laoreet, ipsum vel auctor, quis.", null, 1, 15, 4, 1 },
                    { 26, 19, new DateTime(2024, 4, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 8, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(710), 5, new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(1490), null, null, false, "Tellus, justo pellentesque vulputate semper diam ipsum a cursus hac augue convallis nulla, viverra bibendum tempus sollicitudin odio tellus sem. Duis sagittis tempor, eget interdum posuere nulla mattis, nunc, hendrerit class est nec, morbi lorem, eu maecenas justo rutrum pulvinar. Semper aenean vitae, arcu sed quisque nec non magna, volutpat vel lectus dictum eros a, erat sapien mattis feugiat, ornare.", null, 1, 16, 4, 1 },
                    { 27, 18, new DateTime(2024, 1, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 9, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(2326), new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(1534), 5, new DateTime(2025, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(2330), null, null, false, "Sodales dignissim eleifend, adipiscing id purus porttitor venenatis amet, porta, ad porttitor, tristique eu, congue mi massa commodo, lacinia auctor. Sollicitudin lorem egestas feugiat nec nec, euismod, lobortis ante lacinia sodales at, magna, odio hac morbi quisque mi, ligula aliquam. Curabitur congue, mi hendrerit pretium nostra, enim nibh turpis massa, gravida ac, leo vulputate lobortis sed nulla non molestie auctor.", null, 1, 17, 4, 1 },
                    { 28, 17, new DateTime(2024, 4, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 8, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3194), new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(2340), 5, new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3197), null, null, false, "Hendrerit magna, blandit, id, torquent eleifend, amet pellentesque erat, porttitor ornare vitae, nunc donec leo, a aliquet laoreet vehicula rutrum. Vehicula auctor, nunc, lacinia, nisi aenean faucibus orci, iaculis posuere, sed class luctus ante, consectetur sem, donec odio ornare platea. Proin primis mi arcu luctus, nunc, fringilla, class tellus cursus elit in porttitor sit ultricies rutrum laoreet, at, cursus, bibendum.", null, 1, 18, 4, 1 },
                    { 29, 20, new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 1, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3958), new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3963), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3210), 5, new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3961), null, null, false, "Accumsan magna lacinia eu, velit amet lectus finibus, habitasse nec et quam, fusce at nunc blandit, maximus turpis nisl arcu. Amet, adipiscing odio, proin scelerisque sed enim ipsum magna, ligula tempus quam, lacinia placerat porttitor donec inceptos facilisis mauris, et. Sem, iaculis at, ex, vestibulum quis, rhoncus, massa, sodales imperdiet class nostra, erat, arcu nec, aptent nisl at a, lectus.", null, 1, 19, 4, 1 },
                    { 30, 17, new DateTime(2024, 6, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 10, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(4711), new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(4715), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(3971), 5, new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(4714), null, null, false, "Aliquet lacinia, dolor erat, imperdiet placerat, ultrices, tellus at nullam eu integer blandit, conubia habitasse consectetur magna, lacus euismod, quam. Sollicitudin aptent in feugiat, rhoncus nulla, nam enim eu, elit, ac neque in, aliquam posuere tempor, blandit vitae, fusce ultricies. Interdum malesuada leo eleifend, dictum vivamus est aliquam lacinia posuere, nibh facilisis porttitor id, class in ante, augue auctor, amet.", null, 1, 20, 4, 1 },
                    { 31, 18, new DateTime(2024, 1, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(5509), new DateTime(2023, 12, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(5508), new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(4723), 5, new DateTime(2025, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(5511), null, null, false, "Malesuada porta arcu, faucibus praesent primis bibendum vehicula ex conubia turpis ex, nibh, est quis, mauris, eget inceptos massa, neque. Dapibus etiam euismod, nam eu, urna, consectetur sagittis nulla orci torquent phasellus maecenas augue vitae, consequat varius risus et, adipiscing. Nibh, odio, euismod id himenaeos eros, felis ante pulvinar, curabitur nulla aenean mattis tortor, congue dignissim malesuada cras non tempor.", null, 1, 21, 4, 1 },
                    { 32, 16, new DateTime(2024, 3, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 12, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(6265), new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(5521), 5, new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(6268), null, null, false, "Ligula tempus ultricies adipiscing nullam fames magna tortor, dignissim posuere, laoreet, interdum vehicula iaculis quisque orci, aliquet dui pretium eget. Varius vehicula placerat, dolor tempor platea tortor nullam quis venenatis dui aliquet convallis iaculis fusce sociosqu conubia turpis nec amet. Orci, est at elit ex, lacus pretium ut hendrerit lacinia himenaeos tempus dapibus nisi, id, commodo ipsum mollis posuere auctor.", null, 1, 22, 4, 1 },
                    { 33, 17, new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7074), new DateTime(2023, 8, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7072), new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7077), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(6279), 5, new DateTime(2025, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7075), null, null, false, "Mi donec felis mauris, quam, magna porttitor turpis et, finibus euismod, et massa, ornare leo, mattis eros torquent commodo, rutrum. Cras ante dolor, vitae lectus, auctor, lacinia, aenean diam luctus, inceptos nibh tristique vel interdum nunc non, commodo fringilla primis. Ac, faucibus lectus at, nec, luctus tempor, consectetur sollicitudin convallis vestibulum, feugiat, lorem fermentum non urna dictum quisque mollis vitae.", null, 1, 23, 4, 1 },
                    { 34, 17, new DateTime(2024, 5, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7824), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7822), new DateTime(2025, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7091), 5, new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7825), null, null, false, "Magna, sed massa, nec, at, rhoncus, nisi, curabitur leo, blandit, diam ligula lacus lacinia, a dictum eleifend lobortis nisl et. Laoreet felis sodales sed, mollis ante, justo feugiat conubia accumsan nullam ullamcorper semper blandit, quam, viverra est erat, ac, quisque. Nec, per eleifend, ac, vitae sociosqu sem, sed fringilla, faucibus est pretium euismod, nunc, lorem, condimentum luctus ultricies urna sodales.", null, 1, 24, 4, 1 },
                    { 35, 16, new DateTime(2024, 4, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(8649), new DateTime(2023, 12, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(8651), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(7836), 5, new DateTime(2025, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(8650), null, null, false, "Euismod, vitae, hendrerit inceptos luctus at bibendum a, euismod sed, nec egestas a tempor, ante, laoreet, donec finibus, magna felis. Sem, nam arcu odio ullamcorper lacus cursus donec fames himenaeos dictumst conubia sed, ultrices, egestas lorem, tellus enim, et sollicitudin. Non, consectetur mi, fringilla, feugiat nibh, ad quam fames pulvinar, cursus commodo dictum fermentum vestibulum, non condimentum aliquet quam, enim.", null, 1, 25, 4, 1 },
                    { 36, 18, new DateTime(2023, 12, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(9437), new DateTime(2023, 9, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(9436), new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(9440), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(8660), 5, new DateTime(2026, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(9439), null, null, false, "Duis finibus nostra, per mi diam auctor accumsan placerat congue, purus urna imperdiet ad phasellus cursus commodo conubia nibh integer. Finibus dictumst mauris tellus malesuada sollicitudin pharetra vehicula faucibus feugiat, etiam dignissim conubia blandit, quam, in phasellus feugiat proin arcu. Mi, fames aenean vestibulum, volutpat, nibh, orci phasellus sapien amet laoreet dui fermentum curabitur sit porta, dapibus cursus, dictumst ultricies.", null, 1, 26, 4, 1 },
                    { 37, 17, new DateTime(2024, 5, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(237), new DateTime(2026, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(242), new DateTime(2023, 11, 4, 22, 0, 32, 428, DateTimeKind.Local).AddTicks(9449), 5, new DateTime(2026, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(241), null, null, false, "Maecenas accumsan libero rhoncus nibh sagittis torquent ullamcorper commodo laoreet, tempor fusce molestie et habitasse vel est volutpat, phasellus tortor. Adipiscing augue tortor, nam rutrum orci cras mi odio etiam ligula, maximus dui, nulla nisl maecenas hendrerit felis neque donec. Quisque mi, amet, primis vitae, in sem, sociosqu orci, vestibulum volutpat, sapien interdum nibh, id vitae maximus ante, conubia dictum.", null, 1, 27, 4, 1 },
                    { 38, 19, new DateTime(2024, 3, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 1, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1050), new DateTime(2026, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1054), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(251), 5, new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1053), null, null, false, "Porta leo, torquent elit, quam, erat, inceptos ad sodales leo tempus lectus ac, nisi pretium lacinia, efficitur auctor rhoncus cras. Accumsan purus fusce amet, ex, varius volutpat, elementum mauris a efficitur finibus porta, mauris, odio, tempor vitae ad ultricies maecenas. Dolor, auctor, eu, sem, tortor sit id, cras posuere, ac primis neque, est turpis at, commodo, lacinia, donec vitae, sed.", null, 1, 28, 4, 1 },
                    { 39, 20, new DateTime(2024, 2, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1844), new DateTime(2023, 10, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1842), new DateTime(2024, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1064), 5, new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1846), null, null, false, "Lacinia, imperdiet condimentum pretium id, vehicula erat urna, in lectus amet nisl taciti auctor dapibus bibendum magna, venenatis nullam habitasse. Ex, velit finibus, mi, varius pellentesque sagittis posuere diam leo, primis mattis varius, ante, consectetur urna, duis phasellus et orci. Rhoncus, auctor gravida posuere taciti pharetra id, non, mattis magna, ac, suspendisse fames molestie varius sodales volutpat commodo massa ante.", null, 1, 29, 4, 1 },
                    { 40, 19, new DateTime(2024, 6, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 12, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(2638), new DateTime(2024, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(1855), 5, new DateTime(2024, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(2641), null, null, false, "Ut volutpat mauris, ligula venenatis ante rhoncus interdum, platea mi, neque arcu, nullam accumsan dolor, laoreet, erat, lobortis nostra, dignissim. At ligula hac bibendum tortor, urna, accumsan vehicula condimentum tempor, congue placerat, id, ut cursus inceptos erat lorem, metus cras. Condimentum dolor commodo, dolor, congue, justo nisi curabitur lobortis primis integer eleifend, pharetra enim, odio ut dapibus rhoncus id, nec.", null, 1, 30, 4, 1 },
                    { 41, 17, new DateTime(2024, 4, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(3390), new DateTime(2023, 12, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(3393), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(2651), 5, new DateTime(2024, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(3391), null, null, false, "Felis condimentum sem congue pulvinar, feugiat, molestie magna metus tempor sociosqu taciti dapibus vel primis cursus, enim lorem, blandit posuere. Ornare accumsan mauris, purus rutrum facilisis sit ultrices dapibus duis erat pharetra placerat, curabitur augue vel amet, elit, tempor laoreet. Commodo, proin mi, diam interdum, sem tempor et sed feugiat viverra ullamcorper congue, vestibulum mollis inceptos class bibendum, magna, ex.", null, 1, 31, 4, 1 },
                    { 42, 19, new DateTime(2024, 5, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 8, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(4184), new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(3401), 5, new DateTime(2024, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(4187), null, null, false, "Dictumst sollicitudin enim, rutrum diam pharetra eu vel, dolor placerat commodo, orci, varius, feugiat hendrerit sapien enim nullam lacinia auctor. Dui, fermentum pulvinar, vulputate est ante eros, commodo sapien dignissim nulla nullam elit varius, pretium commodo, mattis arcu morbi massa. Dui, a, ad interdum vel nec quis, eros elit, molestie taciti massa, aliquam sollicitudin ac sem, tempus mattis, urna, curabitur.", null, 1, 32, 4, 1 },
                    { 43, 19, new DateTime(2023, 12, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 9, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(5019), new DateTime(2026, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(5024), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(4197), 5, new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(5023), null, null, false, "Molestie conubia nibh, quisque luctus, massa, gravida tortor, accumsan lacinia mollis vivamus quis ex malesuada etiam arcu, mattis varius, libero. Tellus, turpis sagittis, tempus ornare ad varius, odio lacinia venenatis tortor taciti maximus non, lorem, aenean bibendum, platea eleifend, quisque. Porttitor, sem condimentum nisi mattis, litora lorem vitae, nulla, facilisis tempor, hendrerit proin viverra dui, dictumst fringilla, turpis convallis tincidunt.", null, 1, 33, 4, 1 },
                    { 44, 19, new DateTime(2024, 1, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6066), new DateTime(2024, 1, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6064), new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(5035), 5, new DateTime(2024, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6067), null, null, false, "Id, hendrerit vel lectus, dolor, vitae, dictumst auctor varius, nisl lacus ligula facilisis elit ipsum feugiat velit metus porttitor posuere. Quis litora ante nullam torquent dignissim ornare laoreet commodo, nunc orci ultrices, nec nibh nisl libero porttitor in, vulputate non. Quisque commodo interdum, dignissim finibus, fringilla vestibulum velit imperdiet euismod, auctor, posuere, nisi, habitasse bibendum, lacus donec dictum lectus, consequat.", null, 1, 34, 4, 1 },
                    { 45, 17, new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6879), new DateTime(2023, 8, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6877), new DateTime(2026, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6882), new DateTime(2023, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6079), 5, new DateTime(2025, 11, 4, 22, 0, 32, 429, DateTimeKind.Local).AddTicks(6881), null, null, false, "Malesuada pulvinar quis curabitur augue odio hac arcu, quam a fringilla amet cursus, bibendum accumsan placerat praesent vulputate urna, aliquet. Congue, finibus, ante, tortor cursus, nec, aliquet dictumst congue nec dolor molestie justo turpis a commodo, enim metus nullam fermentum. Morbi molestie primis quisque integer nisi, enim, mattis, sem, elementum nostra, sit fermentum ex pulvinar dui, imperdiet congue ipsum iaculis.", null, 1, 35, 4, 1 },
                    { 46, 22, new DateTime(2024, 3, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(9257), new DateTime(2023, 11, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(9251), new DateTime(2025, 11, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(9261), new DateTime(2023, 11, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(7031), 5, new DateTime(2024, 11, 4, 22, 0, 32, 784, DateTimeKind.Local).AddTicks(9259), null, null, false, "Sodales nunc interdum, odio, vitae, mi, amet, diam at orci consectetur rhoncus, posuere maecenas molestie suscipit ac vestibulum, varius imperdiet. Interdum, rutrum eros, in, dapibus suspendisse convallis tellus, sed adipiscing justo etiam ultrices cursus sem, congue, ultrices, massa aenean porta. Taciti nunc eros mauris pulvinar, viverra a ex, gravida lobortis primis curabitur maecenas sapien posuere nibh, hac ipsum felis sed.", null, null, 36, 3, null },
                    { 47, 23, new DateTime(2024, 3, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 8, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(4328), new DateTime(2024, 11, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 11, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(3378), 5, new DateTime(2024, 11, 4, 22, 0, 32, 878, DateTimeKind.Local).AddTicks(4336), null, null, false, "Justo erat, lectus ante, bibendum, massa nisi, diam mauris, accumsan convallis ultricies imperdiet ut ullamcorper conubia id per egestas integer. Purus sed suscipit accumsan ligula dictum dui, tempus enim, aliquet maximus id tristique efficitur class integer velit nisi, nibh vitae. Conubia at donec vitae quis commodo, non nulla, dictum dictumst molestie ex nisi tellus, sodales ultrices tortor purus tincidunt felis.", null, null, 37, 3, null },
                    { 48, 24, new DateTime(2020, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(5851), new DateTime(2019, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(5845), new DateTime(2022, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(4818), 5, new DateTime(2022, 11, 4, 22, 0, 32, 982, DateTimeKind.Local).AddTicks(5853), null, null, false, "Praesent dolor, lectus, euismod, interdum, fusce ac placerat placerat, tortor nisl ad commodo varius dui mollis accumsan nostra, hendrerit orci. Quis euismod, congue, donec ex tortor, hendrerit himenaeos nibh, mauris curabitur amet sociosqu platea vehicula mollis in, tellus eros sollicitudin. Efficitur metus in, taciti sollicitudin blandit viverra augue pretium fermentum gravida vitae, amet, purus quam, torquent arcu, fusce interdum nibh.", null, 1, 38, 6, 1 },
                    { 49, 25, new DateTime(2021, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(5251), new DateTime(2019, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(5247), new DateTime(2023, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(5256), new DateTime(2023, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(4457), 5, new DateTime(2023, 11, 4, 22, 0, 33, 53, DateTimeKind.Local).AddTicks(5254), null, null, false, "Nunc euismod, primis vestibulum interdum varius nisl maximus adipiscing quisque sociosqu etiam auctor, dignissim nostra, ante urna interdum, dui, mollis. Suspendisse iaculis tortor, sit velit feugiat, quisque venenatis et dolor vitae, taciti ligula dolor, mattis, hac suscipit ligula, ex ipsum. Vel ornare placerat, a, pellentesque ac tempor dignissim sem primis tellus, mi, non, quisque auctor, dictumst tortor dolor, justo posuere.", null, 1, 39, 6, 1 },
                    { 50, 26, new DateTime(2021, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9241), new DateTime(2018, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9237), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9245), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(8195), 5, new DateTime(2022, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9243), null, null, false, "Nunc orci, convallis aliquam taciti class lobortis ac, ipsum enim libero ac volutpat quam vitae, quam, sit velit felis consectetur. Nam ad dapibus euismod placerat vulputate nulla, in platea gravida enim congue, vitae, ornare consequat mauris, nunc, at nec, pellentesque. Tempor pretium in, lacinia, metus risus inceptos sagittis, iaculis quis aliquam maximus etiam in ligula, id pulvinar, himenaeos volutpat, tristique.", null, 1, 40, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ServiceRequests",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "InspectionRecordFilePath", "IpId", "IsDelegated", "IsDeleted", "Quantity", "RequestId", "SaleApprovalId", "ServiceId", "Status", "TechExecutionId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9273), null, null, false, false, 3, 6, null, 2, 0, null, null, null },
                    { 2, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9289), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9289), null, null, false, false, 1, 6, null, 2, 0, null, null, null },
                    { 3, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9295), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9295), null, null, false, false, 1, 6, null, 1, 0, null, null, null },
                    { 4, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9303), null, null, false, false, 1, 7, null, 2, 0, null, null, null },
                    { 5, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9308), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9309), null, null, false, false, 5, 7, null, 3, 0, null, null, null },
                    { 6, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9317), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9318), null, null, false, false, 3, 7, null, 3, 0, null, null, null },
                    { 7, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9324), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9325), null, null, false, false, 5, 8, null, 1, 0, null, null, null },
                    { 8, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9330), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9331), null, null, false, false, 5, 8, null, 3, 0, null, null, null },
                    { 9, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9337), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9337), null, null, false, false, 5, 8, null, 2, 0, null, null, null },
                    { 10, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9344), null, null, false, false, 4, 8, null, 2, 0, null, null, null },
                    { 11, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9351), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9351), null, null, false, false, 1, 9, null, 3, 0, null, null, null },
                    { 12, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9358), null, null, false, false, 5, 10, null, 2, 0, null, null, null },
                    { 13, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9364), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9364), null, null, false, false, 1, 10, null, 3, 0, null, null, null },
                    { 14, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9374), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9374), null, null, false, false, 1, 11, null, 1, 2, null, null, null },
                    { 15, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9382), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9383), null, null, false, false, 1, 11, null, 3, 0, null, null, null },
                    { 16, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9424), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9425), null, null, false, false, 5, 12, null, 3, 0, null, null, null },
                    { 17, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9434), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9434), null, null, false, false, 1, 13, null, 2, 2, null, null, null },
                    { 18, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9443), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9443), null, null, false, false, 5, 14, null, 2, 0, null, null, null },
                    { 19, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9449), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9449), null, null, false, false, 5, 14, null, 2, 0, null, null, null },
                    { 20, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9456), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9457), null, null, false, false, 2, 14, 1, 2, 1, null, null, null },
                    { 21, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9465), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9465), null, null, false, false, 4, 15, null, 3, 0, null, null, null },
                    { 22, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9474), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9474), null, null, false, false, 5, 16, null, 1, 2, null, null, null },
                    { 23, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9484), null, null, false, false, 2, 17, 1, 3, 1, null, null, null },
                    { 24, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9491), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9491), null, null, false, false, 5, 17, null, 1, 2, null, null, null },
                    { 25, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9499), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9500), null, null, false, false, 4, 18, 1, 3, 1, null, null, null },
                    { 26, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9507), null, null, false, false, 5, 18, 1, 1, 1, null, null, null },
                    { 27, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9514), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9514), null, null, false, false, 1, 18, 1, 2, 3, 1, null, null },
                    { 28, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9523), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9523), null, null, false, false, 1, 19, null, 3, 2, null, null, null },
                    { 29, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9532), null, null, false, false, 2, 20, null, 1, 2, null, null, null },
                    { 30, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9539), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9539), null, null, false, false, 4, 20, 1, 2, 1, null, null, null },
                    { 31, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9546), null, null, false, false, 3, 20, null, 2, 2, null, null, null },
                    { 32, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9588), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9588), null, null, false, false, 4, 21, 1, 3, 1, null, null, null },
                    { 33, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9595), null, null, false, false, 1, 21, null, 3, 0, null, null, null },
                    { 34, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9603), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9603), null, null, false, false, 4, 21, 1, 1, 1, null, null, null },
                    { 35, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9611), null, null, false, false, 1, 21, null, 1, 2, null, null, null },
                    { 36, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9619), null, null, false, false, 5, 22, null, 1, 2, null, null, null },
                    { 37, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9626), null, null, false, false, 3, 22, 1, 2, 1, null, null, null },
                    { 38, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9633), null, null, false, false, 3, 22, 1, 2, 3, 1, null, null },
                    { 39, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9642), null, null, false, false, 3, 23, null, 2, 2, null, null, null },
                    { 40, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9648), null, null, false, false, 1, 23, 1, 1, 1, null, null, null },
                    { 41, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9655), null, null, false, false, 3, 23, 1, 2, 1, null, null, null },
                    { 42, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9663), null, null, false, false, 3, 24, 1, 3, 3, 1, null, null },
                    { 43, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9670), null, null, false, false, 5, 24, null, 1, 2, null, null, null },
                    { 44, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9677), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9678), null, null, false, false, 3, 24, 1, 2, 3, 1, null, null },
                    { 45, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9684), null, null, false, false, 5, 24, 1, 3, 3, 1, null, null },
                    { 46, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9693), null, null, false, false, 2, 25, 1, 1, 1, null, null, null },
                    { 47, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9737), null, null, false, false, 4, 26, 1, 3, 3, 1, null, null },
                    { 48, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9745), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9745), null, null, false, false, 5, 26, 1, 1, 1, null, null, null },
                    { 49, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9753), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9753), null, null, false, false, 4, 26, null, 3, 2, null, null, null },
                    { 50, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9760), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9760), null, null, false, false, 5, 26, 1, 2, 3, 1, null, null },
                    { 51, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9768), null, null, false, false, 2, 27, null, 3, 2, null, null, null },
                    { 52, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9777), null, null, false, false, 3, 28, 1, 3, 3, 1, null, null },
                    { 53, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9783), null, null, false, false, 2, 28, null, 2, 2, null, null, null },
                    { 54, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9790), null, null, false, false, 5, 28, null, 3, 0, null, null, null },
                    { 55, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9797), null, null, false, false, 3, 28, null, 2, 2, null, null, null },
                    { 56, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9806), null, null, false, false, 2, 29, 1, 1, 3, 1, null, null },
                    { 57, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9813), null, null, false, false, 2, 29, 1, 3, 3, 1, null, null },
                    { 58, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9819), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9819), null, null, false, false, 3, 29, 1, 1, 3, 1, null, null },
                    { 59, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9828), null, null, false, false, 5, 30, 1, 2, 1, null, null, null },
                    { 60, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9834), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9835), null, null, false, false, 5, 30, null, 1, 0, null, null, null },
                    { 61, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9841), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9842), null, null, false, false, 1, 30, 1, 1, 3, 1, null, null },
                    { 62, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9850), null, null, false, false, 3, 31, null, 2, 0, null, null, null },
                    { 63, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9891), null, null, false, false, 3, 32, null, 2, 0, null, null, null },
                    { 64, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9900), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9900), null, null, false, false, 5, 32, 1, 2, 3, 1, null, null },
                    { 65, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9907), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9907), null, null, false, false, 4, 32, null, 2, 0, null, null, null },
                    { 66, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9916), null, null, false, false, 5, 33, 1, 1, 3, 1, null, null },
                    { 67, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9923), null, null, false, false, 1, 33, null, 3, 2, null, null, null },
                    { 68, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9931), null, null, false, false, 1, 34, null, 1, 0, null, null, null },
                    { 69, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9937), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9938), null, null, false, false, 5, 34, 1, 1, 3, 1, null, null },
                    { 70, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9944), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9945), null, null, false, false, 4, 34, 1, 3, 3, 1, null, null },
                    { 71, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9951), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9952), null, null, false, false, 4, 34, null, 2, 0, null, null, null },
                    { 72, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9960), null, null, false, false, 5, 35, 1, 3, 3, 1, null, null },
                    { 73, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9966), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9967), null, null, false, false, 3, 35, 1, 1, 1, null, null, null },
                    { 74, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9974), null, null, false, false, 4, 35, null, 1, 2, null, null, null },
                    { 75, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9982), null, null, false, false, 1, 36, null, 2, 0, null, null, null },
                    { 76, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9989), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9989), null, null, false, false, 4, 36, null, 2, 2, null, null, null },
                    { 77, new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 11, 4, 22, 0, 33, 124, DateTimeKind.Local).AddTicks(9997), null, null, false, false, 5, 36, null, 1, 0, null, null, null },
                    { 78, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(38), null, null, false, false, 3, 36, null, 2, 2, null, null, null },
                    { 79, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(46), null, null, false, false, 2, 36, 1, 1, 1, null, null, null },
                    { 80, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(53), null, null, false, false, 1, 36, null, 1, 0, null, null, null },
                    { 81, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(61), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(61), null, null, false, false, 2, 37, 1, 2, 3, 1, null, null },
                    { 82, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(68), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(68), null, null, false, false, 1, 37, null, 2, 2, null, null, null },
                    { 83, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(75), null, null, false, false, 1, 37, null, 2, 2, null, null, null },
                    { 84, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(82), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(83), null, null, false, false, 3, 37, 1, 2, 1, null, null, null },
                    { 85, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(91), null, null, false, false, 3, 38, 1, 1, 1, null, null, null },
                    { 86, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(98), null, null, false, false, 4, 38, 1, 2, 1, null, null, null },
                    { 87, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(106), null, null, false, false, 4, 39, null, 3, 0, null, null, null },
                    { 88, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(114), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(115), null, null, false, false, 3, 40, null, 1, 2, null, null, null },
                    { 89, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(122), null, null, false, false, 2, 40, null, 2, 0, null, null, null },
                    { 90, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(130), null, null, false, false, 4, 41, null, 3, 0, null, null, null },
                    { 91, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(137), null, null, false, false, 1, 41, null, 3, 2, null, null, null },
                    { 92, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(144), null, null, false, false, 5, 41, null, 2, 0, null, null, null },
                    { 93, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(152), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(152), null, null, false, false, 1, 42, 1, 1, 1, null, null, null },
                    { 94, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(206), null, null, false, false, 4, 42, null, 3, 0, null, null, null },
                    { 95, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(215), null, null, false, false, 4, 42, 1, 1, 3, 1, null, null },
                    { 96, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(223), null, null, false, false, 3, 43, 1, 2, 1, null, null, null },
                    { 97, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(231), null, null, false, false, 5, 44, 1, 1, 1, null, null, null },
                    { 98, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(238), null, null, false, false, 2, 44, 1, 2, 3, 1, null, null },
                    { 99, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(245), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(245), null, null, false, false, 4, 44, null, 2, 2, null, null, null },
                    { 100, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(253), null, null, false, false, 1, 45, null, 1, 2, null, null, null },
                    { 101, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(260), null, null, false, false, 1, 45, null, 1, 0, null, null, null },
                    { 102, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(268), null, null, false, false, 5, 46, null, 3, 2, null, null, null },
                    { 103, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(275), null, null, false, false, 3, 46, null, 1, 2, null, null, null },
                    { 104, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(281), null, null, false, false, 4, 46, null, 3, 2, null, null, null },
                    { 105, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(286), null, null, false, false, 1, 46, null, 2, 2, null, null, null },
                    { 106, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(294), null, null, false, false, 4, 47, null, 3, 2, null, null, null },
                    { 107, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(300), null, null, false, false, 2, 47, null, 1, 2, null, null, null },
                    { 108, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(306), null, null, false, false, 5, 47, null, 3, 2, null, null, null },
                    { 109, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(312), null, null, false, false, 3, 47, null, 3, 2, null, null, null },
                    { 110, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(322), null, null, false, false, 2, 48, null, 2, 2, null, null, null },
                    { 111, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(364), null, null, false, false, 2, 48, null, 3, 2, null, null, null },
                    { 112, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(372), null, null, false, false, 2, 48, 1, 2, 1, null, null, null },
                    { 113, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(381), null, null, false, false, 4, 49, 1, 3, 1, null, null, null },
                    { 114, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(389), null, null, false, false, 3, 49, 1, 3, 3, 1, null, null },
                    { 115, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(396), null, null, false, false, 3, 49, 1, 1, 3, 1, null, null },
                    { 116, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(405), null, null, false, false, 3, 50, 1, 1, 1, null, null, null },
                    { 117, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(412), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(412), null, null, false, false, 1, 50, null, 3, 0, null, null, null },
                    { 118, new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 11, 4, 22, 0, 33, 125, DateTimeKind.Local).AddTicks(419), null, null, false, false, 4, 50, 1, 1, 3, 1, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedules_CustomerId",
                table: "AppointmentSchedules",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentSchedules_TechExecutionId",
                table: "AppointmentSchedules",
                column: "TechExecutionId");

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
                name: "IX_ServerAppointments_AppointmentScheduleId",
                table: "ServerAppointments",
                column: "AppointmentScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAppointments_ServerId",
                table: "ServerAppointments",
                column: "ServerId");

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
                name: "ServerAppointments");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "AppointmentSchedules");

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
