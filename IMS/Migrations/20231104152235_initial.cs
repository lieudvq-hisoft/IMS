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
                    { 1, 8, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2950), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2958), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2958), false, "B", 5 }
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
                    { new Guid("0712ad11-454c-4de2-9be2-ead1bc5a303e"), 0, "Sem/Nam, Commodo praesent sodales", "d42a2858-037a-4eaf-9a50-6d1f9c0d3194", 0, "consequat@et.com", true, "Nostra tempus class", false, false, null, "pharetra@ex.com", "customer25", "AQAAAAIAAYagAAAAEDkavNZWqvfp69Ve8HrKeFnTSrmOOr39fN9vBZwxOFXav0FQrNvW3YnBI/VcSxEZBQ==", "1845686758", false, "", false, "customer25" },
                    { new Guid("0f59bd2e-0af2-42a3-af82-250bca8c7df5"), 0, "Tincidunt/Cursus, Elementum sodales felis", "b40e5183-0e0b-47b8-886d-a768e020335c", 0, "mattis@pharetra.com", true, "Orci nunc enim", false, false, null, "ullamcorper@ante.com", "customer3", "AQAAAAIAAYagAAAAENls756i7NdxlBbYpmiUfQV3ybFIrMy1pfekE1Vcg9247hiJ5i0Zk3h0gb1vZdtcEQ==", "4611655533", false, "", false, "customer3" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "80926492-bf51-46a1-b412-686dce439170", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEAsB5R7Uej5y//Pb7DQBP+6eNoqSL6VL9nDaC0QybsJ9hx91wG3q6F/jjXjn5dqfLA==", "0000000003", false, "", false, "sale" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "3cddf901-e344-44c0-9e75-02a5af2986db", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEJn+g7GS4cyTSmntNZ78BFlS6LFWQ7LOHjcoeM/tDOqEteI0u8gjbmmD2hNXFmsQGA==", "0000000005", false, "", false, "admin" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "734f6b9c-7744-43fb-83a9-7f113b5643de", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAENz6IxlpRjuYU2bY/JmsNprYVWQEY3/yZd83YgS1OotYQhdB5ehdalJGKsjR9o6vkw==", "0000000004", false, "", false, "manager" },
                    { new Guid("342b7133-88fc-4fd0-9a17-39733509124d"), 0, "At/Quis, Platea per mollis", "4bc98469-8c17-40a0-84f6-d08cdab30a1b", 0, "dolor@consequat.com", true, "Dignissim quisque sem", false, false, null, "ex@ac.com", "customer5", "AQAAAAIAAYagAAAAEH6oo7dGnIdJGVdYL2bBU9VX5ogP0vzb/RFwsK4KoXVOU/6/T9yy78+rAW0Meh/gWg==", "8713149894", false, "", false, "customer5" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "f8be9de1-dea4-46e3-8d1c-e3923d9eaa4d", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAECYbQoXDjhEokxQI1GgIogZOKcyS/fCxuE8sWIF/AoXnQiaSgrudzyEegQiSctohzQ==", "0000000002", false, "", false, "tech" },
                    { new Guid("55efc134-3340-4497-9c14-bf7d3a93f55c"), 0, "Fusce/Blandit, At vel elementum", "7e9506e2-1bb2-4daa-8638-982fd3639672", 0, "maecenas@auctor.com", true, "Eu in aenean", false, false, null, "egestas@ultricies.com", "customer15", "AQAAAAIAAYagAAAAEDpqBu1U27zfcFIXCI6SLnJfOpGBij4riDdpd0mAJG/5R0cQTB7+xGCb4Z69YkwB1g==", "8776788170", false, "", false, "customer15" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "e053fe3d-67a0-40fb-896b-8c7fc866c1e9", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEDxyaRzpaRdBUUa8prsVrMGteHI1GJ2kt6qFaJBXj8XooOkovtu2RoHBG0yhAgQgug==", "0000000001", false, "", false, "super" },
                    { new Guid("5fb26c77-6833-49d1-b7d8-1ccb74cb6df4"), 0, "Diam/Mi, Primis fermentum nec", "a8a9a5db-3e7a-47db-9d8c-37652ed715c3", 0, "lorem@himenaeos.com", true, "Taciti enim diam", false, false, null, "fames@feugiat.com", "customer7", "AQAAAAIAAYagAAAAEMmQFghFfGTm6F5rCPMkO52t4wknblKUO8JAAbPplGQmMaE8WmtOMeaOvP2r+vBmZg==", "7450531796", false, "", false, "customer7" },
                    { new Guid("6b1c9dea-17ff-46dd-89da-2104e741ea39"), 0, "A/Convallis, Proin laoreet accumsan", "16fd4906-2c1b-414a-9836-c5eb7c9c2a60", 0, "lorem@posuere.com", true, "Porttitor tempus eros", false, false, null, "id@blandit.com", "customer4", "AQAAAAIAAYagAAAAEF7VYXHpvlyqEdY4u+whzr8QBGBRuTBHErX8Qu60kYUkj/LbhzAiJXEH3SsFVEnDtw==", "2348686653", false, "", false, "customer4" },
                    { new Guid("8b0669b4-b6bf-48d2-90ad-92376bb6d6b5"), 0, "Dui/Lobortis, Neque convallis curabitur", "9ca4d6ca-f756-4dad-8b43-cb8b73d9d812", 0, "egestas@metus.com", true, "Curabitur neque lobortis", false, false, null, "phasellus@nibh.com", "customer23", "AQAAAAIAAYagAAAAEMXiqUTHetAluS1Aed3qWifUU9/0rmXelPIvw/q27yXWr+EBhe+xGyhY4GKJcojL8A==", "7048229512", false, "", false, "customer23" },
                    { new Guid("91ef1ab6-1b06-44f6-855f-4a3a69d3386c"), 0, "Metus/Sem, Condimentum magna commodo", "9b0fbf57-0dbe-4804-b141-c24d8b5788be", 0, "augue@vitae.com", true, "Mi turpis blandit", false, false, null, "id@platea.com", "customer22", "AQAAAAIAAYagAAAAEKWCEM408nXpQcVQGtCw8D6CSJjprzDOUfoTRBH0qYaBsTIAoOTKUC+QudOJTz4yzw==", "2875392053", false, "", false, "customer22" },
                    { new Guid("9a36ab1a-1f81-463f-aba9-705bbbee913b"), 0, "Ante/Non, Pulvinar a fermentum", "45ddb2fc-18d3-4585-891d-979a8b6af948", 0, "ipsum@enim.com", true, "Enim ut porta", false, false, null, "posuere@ligula.com", "customer17", "AQAAAAIAAYagAAAAEOQ10IBh8xRBsdvSj4L3hLc+B4pCDVB+G+yIrXdjmvpvIr692Zirqv7elXPwBgr+mQ==", "8855160123", false, "", false, "customer17" },
                    { new Guid("ab0481c0-f48c-4f5d-8274-b1b8ab246d2f"), 0, "Vulputate/Mattis, Nulla sem praesent", "ed6d8507-6c37-49a2-aa19-93711bcbffa0", 0, "primis@consectetur.com", true, "Commodo mollis ullamcorper", false, false, null, "fusce@vitae.com", "customer12", "AQAAAAIAAYagAAAAEMRkVYHfstws2UrP15IvS93U+o0b8ZTrTVnbu5qxBl6YPcBWX46DxgbsxxEFaCzCPA==", "5740345379", false, "", false, "customer12" },
                    { new Guid("b0aef274-ec8d-41e9-82e5-b73f452ef756"), 0, "Vestibulum/In, Nec taciti finibus", "0735504f-5489-45a7-a1c9-88b343167485", 0, "velit@quisque.com", true, "Lacus commodo posuere", false, false, null, "sagittis@fermentum.com", "customer10", "AQAAAAIAAYagAAAAECJecPUpI8kN2D5NZbOlrdafI15ljXHaAjLkiH2awWV/XGlhqaN3IuJcWya7jO8HKA==", "6548496531", false, "", false, "customer10" },
                    { new Guid("b4b02566-4d4d-4c0d-9ca3-275165b14bc5"), 0, "Praesent/Nunc, Pulvinar pulvinar velit", "aff97b18-b22b-4b68-96e9-fc5f60358d13", 0, "scelerisque@nisi.com", true, "Lorem malesuada tellus", false, false, null, "fermentum@nibh.com", "customer9", "AQAAAAIAAYagAAAAEFvyRzBL2mVd7PGR9ZAlLtHnlEWZK9PQwKpgu/Bwv5cU8U3PjW4Kt7EfdD5u/wBsPQ==", "2907119093", false, "", false, "customer9" },
                    { new Guid("b6f67015-2796-438f-a80f-b7e0ef614c8b"), 0, "Rutrum/Tortor, Porttitor donec mi", "f1d86a37-8c9a-4a4e-b1f7-f7dc959bff46", 0, "feugiat@auctor.com", true, "Dolor eu litora", false, false, null, "morbi@arcu.com", "customer16", "AQAAAAIAAYagAAAAEFdtPkFWrxmZvLZ28YVdxMBLgrzudLLrnK9J4vwiJcgcALDNVopdAgGlX3vVIWzYkg==", "9921873551", false, "", false, "customer16" },
                    { new Guid("c17a19e1-93a2-4206-beae-eb239c952b2a"), 0, "Accumsan/Elit, Torquent maecenas sem", "8a4f1e72-ce17-49c4-beae-78b66a6a51e5", 0, "primis@aliquam.com", true, "Facilisis erat eros", false, false, null, "scelerisque@massa.com", "customer14", "AQAAAAIAAYagAAAAECr6H+mpGaw+rvB+aRzAj02P4t7oRzsIstdUHeB0SPSpYuclu3Nxuh5cnx1F/86DSw==", "2444159627", false, "", false, "customer14" },
                    { new Guid("ce9798e8-2675-4d88-a05e-fa91cbee5167"), 0, "Est/Consectetur, Lorem imperdiet consectetur", "0cf2e244-ca7f-4029-adad-2b6372ae5542", 0, "nec@nibh.com", true, "Non orci arcu", false, false, null, "pretium@vulputate.com", "customer8", "AQAAAAIAAYagAAAAEKntHEwgQtRts4P1ei2N4CjbHmowhMOhN4y6jGjKQZb01UYCz1Vc++yq5lFcYlH1SQ==", "3382661487", false, "", false, "customer8" },
                    { new Guid("dbe2bb1c-f5d2-49e8-bf52-515988188447"), 0, "Non/Suspendisse, Nec dictumst semper", "0c7ca035-109f-46f6-aedd-fb1867325bb1", 0, "nec@placerat.com", true, "Viverra elit velit", false, false, null, "laoreet@nam.com", "customer11", "AQAAAAIAAYagAAAAEArw6CQcmMjjG5gf3BLsKENBO1xEQCkpvBjeJgh2kWBDKsXKJc2vPB/7q9VhPaN1lg==", "6145750498", false, "", false, "customer11" },
                    { new Guid("dc56a414-ec43-48b4-9008-754e61327b2d"), 0, "Lectus/Ullamcorper, Elit at himenaeos", "6eac4471-fb5d-4b71-956d-341f098348b9", 0, "semper@odio.com", true, "Congue condimentum mi", false, false, null, "ipsum@auctor.com", "customer20", "AQAAAAIAAYagAAAAEAFA0tTRnuNKQm4pakJR7SKYxcbFOVTmHFHd0/8t+UVKxASVg8MHxgqnruRy/49v0A==", "6818208692", false, "", false, "customer20" },
                    { new Guid("eeb39753-22cf-4117-851d-cf23f9e9ae13"), 0, "Ac/Sollicitudin, Fusce massa tellus", "24004679-a6f0-411d-ad34-8a52158a59b2", 0, "dolor@porttitor.com", true, "Torquent ultrices elit", false, false, null, "lacinia@dictum.com", "customer19", "AQAAAAIAAYagAAAAEFydhM+sXcYbs31KG4xfug3Bv5CPLTk5K8dZmTwm4emK7DobfDkJVl474/OivLExgw==", "7963736224", false, "", false, "customer19" },
                    { new Guid("f37396a1-af0b-4a5c-9e7f-97b1d93997ac"), 0, "Ligula/Magna, Orci euismod ultrices", "c574d265-d2d8-42e1-aa37-e162a44573d3", 0, "laoreet@arcu.com", true, "Platea urna hendrerit", false, false, null, "finibus@nam.com", "customer18", "AQAAAAIAAYagAAAAECdd02nsNECSNch+c9SFctRgSMueB5c4Tqy7XQm11CTmj2gS6TUJKttoScksGLYJpA==", "4346155631", false, "", false, "customer18" },
                    { new Guid("f3e902fe-60d5-4c6e-be68-49ca8c417b65"), 0, "Nec/Nisl, Integer sagittis volutpat", "e131e6d6-9f46-4b88-a653-406c901befec", 0, "tortor@lacinia.com", true, "Bibendum tortor arcu", false, false, null, "nibh@at.com", "customer21", "AQAAAAIAAYagAAAAEHHxUVadAoueLIvDL1G0VgMKfCQq4wP7PcG+bypN3yET89oZ9ym/cK9r71BW7EK9SA==", "7108550328", false, "", false, "customer21" },
                    { new Guid("f9286af1-aa0a-4f41-ae75-1d2bfe80180a"), 0, "Commodo/Morbi, Urna nibh lobortis", "05ae9226-ad4e-49ca-b25d-99d226a92754", 0, "eleifend@pretium.com", true, "Ad sodales pulvinar", false, false, null, "gravida@rhoncus.com", "customer24", "AQAAAAIAAYagAAAAEJ0ku3UPBum0X2/QK6XcWxO/5JB6nw3wf3PbuIeaXVAxjXFMAwu8vCDxhEbnl8e4Cg==", "2745676601", false, "", false, "customer24" },
                    { new Guid("faa3bf3d-9e3d-445e-a1c1-3d3b860b1acc"), 0, "Aenean/Mi, Tellus sollicitudin sagittis", "687ff80f-75a3-452c-8149-9d1589406560", 0, "curabitur@aliquam.com", true, "Taciti donec dolor", false, false, null, "condimentum@vivamus.com", "customer2", "AQAAAAIAAYagAAAAEDnjDG27s8MF3+T77SQu93A4kn2ihO3yMArXYKFoANLkk4WVNHe/wd6/RO2LdQlyng==", "7553527878", false, "", false, "customer2" },
                    { new Guid("fadf155a-d94e-4d0b-8485-8279243fa321"), 0, "Rutrum/Gravida, Sagittis cursus erat", "29182c9c-d32a-4a24-9404-653fe0802985", 0, "fringilla@mauris.com", true, "Elementum nec facilisis", false, false, null, "elit@orci.com", "customer1", "AQAAAAIAAYagAAAAEL/v76SZArcu12nSqcNFQxU6iLkhwb7lv8Qvg+VlXVt6oddQCJEj5LXRzXSItAEGIw==", "8889214146", false, "", false, "customer1" },
                    { new Guid("febeec57-f6d8-4a3e-9758-14328d094455"), 0, "Congue/Ultricies, Dictum bibendum sem", "9138eab3-ed65-4b52-814d-2a0a85085585", 0, "accumsan@etiam.com", true, "Volutpat imperdiet congue", false, false, null, "molestie@fermentum.com", "customer13", "AQAAAAIAAYagAAAAEP0/wLQADf7LnBI6j4mHt7fEH4tPCrzd28LpUuHmiRRiHP3C1TVb9R4FWlpg6voVqQ==", "8158002418", false, "", false, "customer13" },
                    { new Guid("ff90f26f-dac6-4e14-a7bc-733146fd673f"), 0, "Suspendisse/Tristique, Maecenas arcu magna", "e5a50205-8770-472c-b493-241615c3ef86", 0, "venenatis@pulvinar.com", true, "Iaculis nec ullamcorper", false, false, null, "nisl@inceptos.com", "customer6", "AQAAAAIAAYagAAAAEPu2P7NlmWwytClf29O9iGW1DEbt8U+Nn722NIArm8ncjpdjXFa8koklWwR1scz4Kw==", "3825647941", false, "", false, "customer6" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2489), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2551), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2552), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2557), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2561), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2565), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2566), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 220, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2617), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2617), false, 2, 0, "Hub" },
                    { 2, 0, 0, 255, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2639), false, 2, 0, "Hub" },
                    { 3, 0, 0, 268, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2646), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2646), false, 3, 1, "Hub" },
                    { 4, 0, 0, 267, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2653), false, 8, 1, "Hub" },
                    { 5, 0, 0, 375, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2670), false, 9, 1, "Hub" },
                    { 6, 0, 0, 307, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2678), false, 5, 0, "Hub" },
                    { 7, 0, 0, 422, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2684), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2684), false, 2, 0, "Hub" },
                    { 8, 0, 0, 218, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2691), false, 3, 1, "Hub" },
                    { 9, 0, 0, 421, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2697), false, 7, 1, "Hub" },
                    { 10, 0, 0, 344, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2704), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2705), false, 3, 0, "Hub" },
                    { 11, 0, 0, 216, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2711), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2712), false, 10, 0, "Server" },
                    { 12, 0, 0, 267, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2718), false, 5, 0, "Server" },
                    { 13, 0, 0, 237, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2723), false, 7, 0, "Server" },
                    { 14, 0, 0, 288, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2729), false, 10, 0, "Server" },
                    { 15, 0, 0, 464, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2735), false, 4, 0, "Server" },
                    { 16, 0, 0, 494, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2741), false, 7, 0, "Server" },
                    { 17, 0, 0, 284, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2746), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2746), false, 10, 0, "Server" },
                    { 18, 0, 0, 210, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2753), false, 9, 0, "Server" },
                    { 19, 0, 0, 301, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2759), false, 3, 0, "Server" },
                    { 20, 0, 0, 216, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2764), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2765), false, 9, 0, "Server" },
                    { 21, 0, 0, 301, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2770), false, 2, 0, "Server" },
                    { 22, 0, 0, 321, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2775), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2775), false, 6, 0, "Server" },
                    { 23, 0, 0, 235, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2781), false, 7, 0, "Server" },
                    { 24, 0, 0, 429, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2786), false, 7, 0, "Server" },
                    { 25, 0, 0, 260, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2799), false, 3, 0, "Server" },
                    { 26, 0, 0, 407, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2804), false, 3, 0, "Server" },
                    { 27, 0, 0, 489, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2809), false, 5, 0, "Server" },
                    { 28, 0, 0, 286, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2815), false, 4, 0, "Server" },
                    { 29, 0, 0, 340, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2820), false, 2, 0, "Server" },
                    { 30, 0, 0, 294, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2826), false, 10, 0, "Server" },
                    { 31, 0, 0, 401, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2831), false, 3, 0, "Server" },
                    { 32, 0, 0, 284, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2836), false, 6, 0, "Server" },
                    { 33, 0, 0, 236, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2842), false, 5, 0, "Server" },
                    { 34, 0, 0, 355, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2848), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2848), false, 3, 0, "Server" },
                    { 35, 0, 0, 390, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2854), false, 7, 0, "Server" },
                    { 36, 0, 0, 277, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2859), false, 2, 0, "Server" },
                    { 37, 0, 0, 428, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2865), false, 5, 0, "Server" },
                    { 38, 0, 0, 449, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2870), false, 6, 0, "Server" },
                    { 39, 0, 0, 463, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2875), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2876), false, 10, 0, "Server" },
                    { 40, 0, 0, 342, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2881), false, 3, 0, "Server" },
                    { 41, 0, 0, 295, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2886), false, 2, 0, "Server" },
                    { 42, 0, 0, 280, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2891), false, 2, 0, "Server" },
                    { 43, 0, 0, 452, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2896), false, 10, 0, "Server" },
                    { 44, 0, 0, 361, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2902), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2902), false, 10, 0, "Server" },
                    { 45, 0, 0, 222, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2913), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2914), false, 3, 0, "Server" },
                    { 46, 0, 0, 275, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2919), false, 10, 0, "Server" },
                    { 47, 0, 0, 252, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2924), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2924), false, 3, 0, "Server" },
                    { 48, 0, 0, 409, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2930), false, 9, 2, "Server" },
                    { 49, 0, 0, 203, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2936), false, 9, 2, "Server" },
                    { 50, 0, 0, 372, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2941), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2942), false, 7, 2, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4353), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4354), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4364), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2588), "Thuê Chỗ", false, "Cấp bổ sung U", "Size" },
                    { 2, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2597), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2598), "Thêm 1U", false, "Bổ sung IP", "Ip" },
                    { 3, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2603), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2603), "Công suất 100", false, "Thêm Port", "Port" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("0712ad11-454c-4de2-9be2-ead1bc5a303e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("0f59bd2e-0af2-42a3-af82-250bca8c7df5") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("342b7133-88fc-4fd0-9a17-39733509124d") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("55efc134-3340-4497-9c14-bf7d3a93f55c") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("5fb26c77-6833-49d1-b7d8-1ccb74cb6df4") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("6b1c9dea-17ff-46dd-89da-2104e741ea39") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("8b0669b4-b6bf-48d2-90ad-92376bb6d6b5") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("91ef1ab6-1b06-44f6-855f-4a3a69d3386c") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9a36ab1a-1f81-463f-aba9-705bbbee913b") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ab0481c0-f48c-4f5d-8274-b1b8ab246d2f") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b0aef274-ec8d-41e9-82e5-b73f452ef756") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b4b02566-4d4d-4c0d-9ca3-275165b14bc5") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b6f67015-2796-438f-a80f-b7e0ef614c8b") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("c17a19e1-93a2-4206-beae-eb239c952b2a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ce9798e8-2675-4d88-a05e-fa91cbee5167") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("dbe2bb1c-f5d2-49e8-bf52-515988188447") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("dc56a414-ec43-48b4-9008-754e61327b2d") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("eeb39753-22cf-4117-851d-cf23f9e9ae13") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f37396a1-af0b-4a5c-9e7f-97b1d93997ac") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f3e902fe-60d5-4c6e-be68-49ca8c417b65") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f9286af1-aa0a-4f41-ae75-1d2bfe80180a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("faa3bf3d-9e3d-445e-a1c1-3d3b860b1acc") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("fadf155a-d94e-4d0b-8485-8279243fa321") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("febeec57-f6d8-4a3e-9758-14328d094455") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ff90f26f-dac6-4e14-a7bc-733146fd673f") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3823), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3824), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Donec ac fringilla", 2, new DateTime(2023, 11, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(2553), new DateTime(2023, 11, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(2558), false, "137613617", new Guid("fadf155a-d94e-4d0b-8485-8279243fa321") },
                    { 3, "Laoreet vel elementum", 2, new DateTime(2023, 11, 4, 22, 22, 33, 123, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 11, 4, 22, 22, 33, 123, DateTimeKind.Local).AddTicks(9180), false, "629058709", new Guid("faa3bf3d-9e3d-445e-a1c1-3d3b860b1acc") },
                    { 4, "Egestas mollis ex", 4, new DateTime(2023, 11, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(6131), new DateTime(2023, 11, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(6135), false, "1044093265", new Guid("0f59bd2e-0af2-42a3-af82-250bca8c7df5") },
                    { 5, "Sed ante tellus", 5, new DateTime(2023, 11, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 11, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(3557), false, "1597834486", new Guid("6b1c9dea-17ff-46dd-89da-2104e741ea39") },
                    { 6, "Lacinia leo est", 2, new DateTime(2023, 11, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(2758), false, "989252346", new Guid("342b7133-88fc-4fd0-9a17-39733509124d") },
                    { 7, "Lobortis morbi laoreet", 5, new DateTime(2023, 11, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 11, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(3302), false, "1725932921", new Guid("ff90f26f-dac6-4e14-a7bc-733146fd673f") },
                    { 8, "Massa sollicitudin placerat", 1, new DateTime(2023, 11, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(704), new DateTime(2023, 11, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(708), false, "337854911", new Guid("5fb26c77-6833-49d1-b7d8-1ccb74cb6df4") },
                    { 9, "Tincidunt enim congue", 3, new DateTime(2023, 11, 4, 22, 22, 33, 730, DateTimeKind.Local).AddTicks(8521), new DateTime(2023, 11, 4, 22, 22, 33, 730, DateTimeKind.Local).AddTicks(8526), false, "1219977013", new Guid("ce9798e8-2675-4d88-a05e-fa91cbee5167") },
                    { 10, "Egestas tempor porta", 5, new DateTime(2023, 11, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 11, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(3766), false, "272187549", new Guid("b4b02566-4d4d-4c0d-9ca3-275165b14bc5") },
                    { 11, "Pulvinar orci at", 4, new DateTime(2023, 11, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 11, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(2363), false, "23105635", new Guid("b0aef274-ec8d-41e9-82e5-b73f452ef756") },
                    { 12, "Elit metus porta", 5, new DateTime(2023, 11, 4, 22, 22, 33, 933, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 11, 4, 22, 22, 33, 933, DateTimeKind.Local).AddTicks(9500), false, "1186766652", new Guid("dbe2bb1c-f5d2-49e8-bf52-515988188447") },
                    { 13, "Amet aenean auctor", 1, new DateTime(2023, 11, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 11, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(5651), false, "595246516", new Guid("ab0481c0-f48c-4f5d-8274-b1b8ab246d2f") },
                    { 14, "Laoreet eleifend dictum", 4, new DateTime(2023, 11, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 11, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(4368), false, "436530426", new Guid("febeec57-f6d8-4a3e-9758-14328d094455") },
                    { 15, "Non sagittis finibus", 3, new DateTime(2023, 11, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(2917), new DateTime(2023, 11, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(2921), false, "196801683", new Guid("c17a19e1-93a2-4206-beae-eb239c952b2a") },
                    { 16, "Quis cras nulla", 3, new DateTime(2023, 11, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 11, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(2665), false, "419337845", new Guid("55efc134-3340-4497-9c14-bf7d3a93f55c") },
                    { 17, "Mollis orci placerat", 1, new DateTime(2023, 11, 4, 22, 22, 34, 325, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 11, 4, 22, 22, 34, 325, DateTimeKind.Local).AddTicks(9964), false, "1546955127", new Guid("b6f67015-2796-438f-a80f-b7e0ef614c8b") },
                    { 18, "Fringilla integer in", 5, new DateTime(2023, 11, 4, 22, 22, 34, 504, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 11, 4, 22, 22, 34, 504, DateTimeKind.Local).AddTicks(6254), false, "995253850", new Guid("9a36ab1a-1f81-463f-aba9-705bbbee913b") },
                    { 19, "Posuere imperdiet euismod", 5, new DateTime(2023, 11, 4, 22, 22, 34, 573, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 11, 4, 22, 22, 34, 573, DateTimeKind.Local).AddTicks(9804), false, "1844263070", new Guid("f37396a1-af0b-4a5c-9e7f-97b1d93997ac") },
                    { 20, "Aliquam nunc luctus", 1, new DateTime(2023, 11, 4, 22, 22, 34, 649, DateTimeKind.Local).AddTicks(733), new DateTime(2023, 11, 4, 22, 22, 34, 649, DateTimeKind.Local).AddTicks(738), false, "495450436", new Guid("eeb39753-22cf-4117-851d-cf23f9e9ae13") },
                    { 21, "Tempus habitasse ultrices", 2, new DateTime(2023, 11, 4, 22, 22, 34, 725, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 11, 4, 22, 22, 34, 725, DateTimeKind.Local).AddTicks(2179), false, "673489350", new Guid("dc56a414-ec43-48b4-9008-754e61327b2d") },
                    { 22, "Arcu at congue", 3, new DateTime(2023, 11, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(1679), new DateTime(2023, 11, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(1684), false, "1650888802", new Guid("f3e902fe-60d5-4c6e-be68-49ca8c417b65") },
                    { 23, "Id mi mauris", 4, new DateTime(2023, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(4981), new DateTime(2023, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(4985), false, "863065459", new Guid("91ef1ab6-1b06-44f6-855f-4a3a69d3386c") },
                    { 24, "Ut nulla sapien", 3, new DateTime(2023, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(8306), new DateTime(2023, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(8310), false, "1715396249", new Guid("8b0669b4-b6bf-48d2-90ad-92376bb6d6b5") },
                    { 25, "Nec id dui", 5, new DateTime(2023, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(3776), new DateTime(2023, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(3781), false, "1317426784", new Guid("f9286af1-aa0a-4f41-ae75-1d2bfe80180a") },
                    { 26, "Hendrerit nunc placerat", 4, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(1393), false, "1504826253", new Guid("0712ad11-454c-4de2-9be2-ead1bc5a303e") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4373), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4382), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4383), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4386), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4387), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4390), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4390), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4394), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4394), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4398), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4402), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4406), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4409), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4410), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4414), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4414), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4418), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4418), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4421), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4422), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4432), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4436), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4436), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4440), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4443), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4443), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4447), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4451), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4455), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4459), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4462), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4462), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4466), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4466), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4469), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4470), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4473), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4473), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4476), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4477), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4480), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4484), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4484), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4488), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4491), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4491), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4495), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4498), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4499), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4502), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4506), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4510), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4514), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4514), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4518), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4521), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4530), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4534), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4538), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4541), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4542), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4545), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4545), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4549), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4549), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4552), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4553), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4556), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4556), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4560), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4560), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4563), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4564), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4567), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4571), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4574), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4575), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4579), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4582), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4586), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4586), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4590), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4594), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4597), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4601), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4605), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4608), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4608), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4611), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4612), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4615), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4615), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4619), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4623), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4626), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4630), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4639), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4643), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4647), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4651), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4654), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4654), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4658), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4661), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4662), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4665), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4665), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4668), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4669), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4672), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4672), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4676), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4680), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4683), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4687), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4687), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4691), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4694), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4694), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4698), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4698), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4701), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4702), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4705), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4705), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4709), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4709), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4712), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4713), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4716), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4716), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4720), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4723), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4724), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4733), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4733), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4736), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4737), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4740), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4740), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4744), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4747), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4748), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4751), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4751), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4755), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4759), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4762), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4762), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4766), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4766), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4770), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4773), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4773), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4777), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4777), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4780), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4781), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4784), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4784), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4788), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4791), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4792), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4795), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4798), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4799), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4802), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4806), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4810), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4810), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4813), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4814), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4817), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4821), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4825), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4828), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4837), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4837), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4841), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4845), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4848), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4848), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4852), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4856), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4859), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4859), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4863), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4866), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4870), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4874), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4877), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4881), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4881), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4886), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4886), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4890), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4893), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4897), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4897), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4901), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4904), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4904), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4907), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4908), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4911), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4911), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4921), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4924), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4925), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4928), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4928), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4931), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4932), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4935), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4935), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4939), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4942), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4943), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4946), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4950), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4950), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4954), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4957), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4957), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4961), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4964), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4965), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4968), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4972), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4972), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4975), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4976), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4979), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4982), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4983), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4986), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4990), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4994), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4997), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5001), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5001), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5004), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5005), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5008), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5008), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5012), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5012), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5015), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5016), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5019), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5019), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5029), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5032), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5036), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5036), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5040), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5044), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5047), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5051), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5054), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5055), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5058), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5062), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5066), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5069), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5073), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5077), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5080), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5084), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5088), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5091), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5095), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5099), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5102), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5102), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5106), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5106), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5110), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5113), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5117), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5117), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5121), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5124), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5124), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5133), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5137), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5141), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5145), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5148), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5148), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5152), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5155), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5156), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5159), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2963), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2963), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2979), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2987), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2988), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2996), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2996), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3003), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3004), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3012), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3028), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3036), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2970), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2981), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2990), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2997), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2997), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3006), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3013), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3029), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3029), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3037), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2971), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2972), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2982), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2990), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2990), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2998), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3006), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3007), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3014), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3030), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3038), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2973), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2983), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2991), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2999), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3008), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3015), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3031), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3031), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3039), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2974), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2984), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2992), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2992), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3000), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3008), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3016), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3032), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3032), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3039), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3040), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2976), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2985), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2993), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3001), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3009), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3017), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3033), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3040), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3040), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2977), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2986), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2994), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3002), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3010), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3026), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3034), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3042), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2978), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2987), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2995), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(2995), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3003), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3011), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3027), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3035), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3042), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3042), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3044), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3050), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3054), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3059), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3064), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3068), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3072), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3073), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3077), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3077), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3046), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3046), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3050), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3051), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3055), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3060), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3064), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3069), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3073), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3073), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3078), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3078), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3047), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3052), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3056), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3056), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3061), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3065), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3065), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3070), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3074), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3079), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3048), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3053), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3057), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3062), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3066), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3066), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3070), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3071), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3075), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3075), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3080), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3049), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3049), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3053), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3058), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3063), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3067), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3067), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3071), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3071), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3076), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3076), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3080), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(3081), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "SaleApprovals",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "SaleId" },
                values: new object[] { 1, new DateTime(2023, 11, 4, 22, 22, 32, 788, DateTimeKind.Local).AddTicks(7662), new DateTime(2023, 11, 4, 22, 22, 32, 788, DateTimeKind.Local).AddTicks(7665), false, new Guid("1abb6e28-793d-460f-8a24-745998356da8") });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5176), 11, false, "Lacinia nulla sapien", 1, "a7aebb75-9f94-41ee-b250-acafff273259" },
                    { 2, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5503), 12, false, "Id a dui", 1, "1fa07131-9d05-483e-8997-65bd71b695c8" },
                    { 3, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5757), 13, false, "Mattis dictumst quam", 1, "f9df3a5e-2bab-4bd3-b9e0-6e7e420fa784" },
                    { 4, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5985), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5985), 14, false, "Eleifend magna dui", 1, "6da6f763-219d-4f1e-b58d-0f034eb73279" },
                    { 5, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6196), 15, false, "Nisi non blandit", 1, "7ba82f35-002d-4c07-b6ef-50ee1e8c97df" },
                    { 6, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6591), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6592), 16, false, "Eleifend fringilla tellus", 1, "db041685-d424-4b27-bed0-5812d659420b" },
                    { 7, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6841), 17, false, "Eget dui scelerisque", 1, "6f7444e7-ffdb-4e17-bc84-500dcee76ee7" },
                    { 8, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7054), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7054), 18, false, "Suspendisse ac ex", 1, "bfd1be08-d5b8-490e-8225-ef186f168589" },
                    { 9, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7240), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7241), 19, false, "Scelerisque ac fermentum", 1, "66c8da48-b668-487a-9623-224ef701406c" },
                    { 10, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7435), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7435), 20, false, "Mauris massa lectus", 1, "dbe101f5-1fbd-4585-8b15-0e61d1dcf306" },
                    { 11, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7613), 21, false, "Duis diam enim", 1, "fcfee9c3-a630-44be-8b6a-3ccd913397e0" },
                    { 12, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7789), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7790), 22, false, "Ullamcorper consequat egestas", 1, "7a601784-712e-4d24-8b38-08273b3adefe" },
                    { 13, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7980), 23, false, "Primis ullamcorper finibus", 1, "6415e73c-7eb8-4c48-920a-0eef722ed2c1" },
                    { 14, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8183), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8183), 24, false, "Nisi praesent congue", 1, "8e389b7d-f7fb-4dfe-8753-215a54d17de2" },
                    { 15, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8383), 25, false, "Platea suscipit a", 1, "fb5e217d-498b-48d3-8a4f-89698d466f0d" },
                    { 16, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8569), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8570), 26, false, "Volutpat primis congue", 1, "feac087e-5de9-4cea-9fc7-540a717df64d" },
                    { 17, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8772), 27, false, "Laoreet vulputate mattis", 1, "5d651a69-476d-47e9-91b4-20bbffef4509" },
                    { 18, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9010), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9010), 28, false, "Ante ligula in", 1, "89b946dd-93af-4b7a-a6f2-29daab9a8f76" },
                    { 19, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9223), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9224), 29, false, "Aliquet tempus eros", 1, "6a8d4ff3-fc72-4dd4-be82-408e9ed289b0" },
                    { 20, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9425), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9426), 30, false, "Feugiat dignissim dolor", 1, "0cf7ca35-8295-4f40-b681-6fa6a4491a51" },
                    { 21, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9619), 31, false, "Congue elit blandit", 1, "9d0ee632-37c1-4d86-8602-ada28ba391cb" },
                    { 22, 0, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9837), 32, false, "Elit ullamcorper libero", 1, "3fa54f8b-c8d3-4238-95c3-73cf04f1abf9" },
                    { 23, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(7), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(8), 33, false, "Cras erat malesuada", 1, "2346e23c-47d1-4da3-a47b-294a47c96862" },
                    { 24, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(193), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(194), 34, false, "Nisi accumsan euismod", 1, "544fb1e2-472f-4788-ba42-78266de7751a" },
                    { 25, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(377), 35, false, "Fringilla cras eros", 1, "e7abf2d1-c4e5-4a9e-99bc-ab07ccd6588a" },
                    { 26, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(573), 36, false, "Pulvinar dolor porttitor", 1, "73d391a6-38e1-4ce4-87f5-dfe695b7b32b" },
                    { 27, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(798), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(798), 37, false, "Ac efficitur nullam", 1, "1816e72e-7f5b-4a1e-a81b-4efac05bbc64" },
                    { 28, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1005), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1006), 38, false, "Rutrum feugiat dictum", 1, "f49c4609-3532-4d51-a3e1-c0d57369b5e3" },
                    { 29, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1198), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1198), 39, false, "Inceptos tincidunt interdum", 1, "f3363c5a-180d-40c3-a48b-c45fcd8a5a97" },
                    { 30, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1400), 40, false, "Pellentesque eu lobortis", 1, "de21035c-40c0-4913-9530-f8905a857c86" },
                    { 31, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1607), 41, true, "Tortor vestibulum eu", 1, "51f187ef-9e7e-40c9-95ab-c2dba600293c" },
                    { 32, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1810), 42, true, "Commodo suspendisse urna", 1, "7f9a27b6-65a1-475e-838b-667c5e306705" },
                    { 33, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2030), 43, false, "Volutpat et ornare", 1, "4ca2694f-5eac-4469-85f6-e0bf04f78d75" },
                    { 34, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2253), 44, false, "Pharetra viverra orci", 1, "80af19d0-baab-45c3-8590-c9592a0fe52e" },
                    { 35, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2443), 45, false, "Id rhoncus praesent", 1, "41c6aa60-829e-4564-b530-ac3f03813f2d" },
                    { 36, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2634), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2634), 46, false, "Cursus nunc urna", 1, "796eccb4-fd6e-4a71-9b2d-835044b6b95b" },
                    { 37, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2822), 47, false, "Tortor ex lacus", 1, "b90d2b29-8da3-4ddc-9f27-e5737321a6d7" },
                    { 38, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3033), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3033), 48, false, "Velit dictum purus", 1, "507f0fe4-0cdb-403b-8cff-fe99499b770a" },
                    { 39, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3247), 49, false, "Fringilla tristique ultricies", 1, "82e7fd5d-b57a-4298-9759-c1f4c6649ac7" },
                    { 40, 0, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3497), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3497), 50, false, "Suscipit dictum magna", 1, "aed8cd97-c2b9-47a8-aaca-844e2d5e2842" }
                });

            migrationBuilder.InsertData(
                table: "TechExecutions",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "TechId" },
                values: new object[] { 1, new DateTime(2023, 11, 4, 22, 22, 32, 713, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 11, 4, 22, 22, 32, 713, DateTimeKind.Local).AddTicks(1115), false, new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsDeleted", "ServerId", "Status", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(5493), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5491), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5492), 4, false, 1, 2, 0 },
                    { 2, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(5751), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5750), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5750), 5, false, 2, 2, 0 },
                    { 3, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(5980), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5979), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(5980), 6, false, 3, 2, 0 },
                    { 4, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(6191), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6190), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6190), 7, false, 4, 2, 0 },
                    { 5, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(6581), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6579), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6580), 8, false, 5, 2, 0 },
                    { 6, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(6836), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6835), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(6836), 9, false, 6, 2, 0 },
                    { 7, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(7049), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7049), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7049), 10, false, 7, 2, 0 },
                    { 8, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(7236), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7236), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7236), 11, false, 8, 2, 0 },
                    { 9, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7429), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7429), 12, false, 9, 2, 0 },
                    { 10, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(7608), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7608), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7608), 13, false, 10, 2, 0 },
                    { 11, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(7785), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7784), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7785), 14, false, 11, 2, 0 },
                    { 12, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(7976), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7975), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(7976), 15, false, 12, 2, 0 },
                    { 13, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(8179), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8178), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8178), 16, false, 13, 2, 0 },
                    { 14, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(8379), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8378), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8379), 17, false, 14, 2, 0 },
                    { 15, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(8566), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8565), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8565), 18, false, 15, 2, 0 },
                    { 16, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(8768), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8767), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(8768), 19, false, 16, 2, 0 },
                    { 17, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(9005), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9004), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9005), 20, false, 17, 2, 0 },
                    { 18, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(9219), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9218), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9218), 21, false, 18, 2, 0 },
                    { 19, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(9421), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9420), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9421), 22, false, 19, 2, 0 },
                    { 20, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(9615), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9614), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9615), 23, false, 20, 2, 0 },
                    { 21, new DateTime(2023, 11, 4, 15, 22, 32, 568, DateTimeKind.Utc).AddTicks(9833), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9832), null, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(9833), 24, false, 21, 2, 0 },
                    { 22, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(3), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3), 25, false, 22, 2, 0 },
                    { 23, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(190), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(189), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(189), 26, false, 23, 2, 0 },
                    { 24, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(373), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(372), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(372), 27, false, 24, 2, 0 },
                    { 25, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(569), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(568), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(568), 28, false, 25, 2, 0 },
                    { 26, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(786), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(785), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(785), 29, false, 26, 2, 0 },
                    { 27, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1001), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1001), 30, false, 27, 2, 0 },
                    { 28, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(1194), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1193), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1193), 31, false, 28, 2, 0 },
                    { 29, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(1395), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1394), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1395), 32, false, 29, 2, 0 },
                    { 30, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(1603), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1602), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1602), 33, false, 30, 2, 0 },
                    { 31, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(1805), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1804), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(1805), 34, true, 31, 1, 0 },
                    { 32, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(2025), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2025), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2025), 35, true, 32, 1, 0 },
                    { 33, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(2248), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2247), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2247), 36, false, 33, 2, 0 },
                    { 34, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(2430), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2429), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2429), 37, false, 34, 2, 0 },
                    { 35, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(2630), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2629), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2630), 38, false, 35, 2, 0 },
                    { 36, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(2818), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2818), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(2818), 39, false, 36, 2, 0 },
                    { 37, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(3029), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3028), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3029), 40, false, 37, 2, 0 },
                    { 38, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(3242), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3241), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3242), 41, false, 38, 2, 0 },
                    { 39, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(3493), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3492), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3492), 42, false, 39, 2, 0 },
                    { 40, new DateTime(2023, 11, 4, 15, 22, 32, 569, DateTimeKind.Utc).AddTicks(3687), new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3686), null, new DateTime(2023, 11, 4, 22, 22, 32, 569, DateTimeKind.Local).AddTicks(3687), 43, false, 40, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4085), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4086), 1, false, 1, 29 },
                    { 2, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4099), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4100), 2, false, 2, 18 },
                    { 3, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4105), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4105), 3, false, 3, 25 },
                    { 4, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4110), 4, false, 4, 6 },
                    { 5, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4115), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4115), 5, false, 5, 29 },
                    { 6, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4120), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4121), 6, false, 6, 17 },
                    { 7, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4125), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4126), 7, false, 7, 27 },
                    { 8, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4130), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4130), 8, false, 8, 9 },
                    { 9, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4135), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4135), 9, false, 9, 6 },
                    { 10, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4140), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4141), 10, false, 10, 23 },
                    { 11, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4145), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4146), 11, false, 11, 20 },
                    { 12, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4150), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4150), 12, false, 12, 4 },
                    { 13, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4155), 13, false, 13, 1 },
                    { 14, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4160), 14, false, 14, 27 },
                    { 15, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4165), 15, false, 15, 17 },
                    { 16, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4169), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4169), 16, false, 16, 21 },
                    { 17, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4174), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4174), 17, false, 17, 3 },
                    { 18, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4185), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4185), 18, false, 18, 23 },
                    { 19, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4191), 19, false, 19, 16 },
                    { 20, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4195), 20, false, 20, 4 },
                    { 21, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4200), 21, false, 21, 29 },
                    { 22, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4204), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4204), 22, false, 22, 11 },
                    { 23, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4209), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4209), 23, false, 23, 30 },
                    { 24, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4214), 24, false, 24, 12 },
                    { 25, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4218), 25, false, 25, 12 },
                    { 26, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4223), 26, false, 26, 10 },
                    { 27, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4227), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4228), 27, false, 27, 4 },
                    { 28, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4233), 28, false, 28, 29 },
                    { 29, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4237), 29, false, 29, 23 },
                    { 30, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4241), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4242), 30, false, 30, 18 },
                    { 31, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4246), 31, false, 31, 14 },
                    { 32, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4253), 32, false, 32, 7 },
                    { 33, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4257), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4258), 33, false, 33, 6 },
                    { 34, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4263), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4263), 34, false, 34, 25 },
                    { 35, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4268), 35, false, 35, 16 },
                    { 36, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4272), 36, false, 36, 8 },
                    { 37, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4276), 37, false, 37, 17 },
                    { 38, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4281), 38, false, 38, 20 },
                    { 39, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4285), 39, false, 39, 22 },
                    { 40, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4295), 40, false, 40, 5 },
                    { 41, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4299), 41, false, 41, 21 },
                    { 42, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4304), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4304), 42, false, 42, 7 },
                    { 43, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4308), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4308), 43, false, 43, 1 },
                    { 44, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4312), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4312), 44, false, 44, 7 },
                    { 45, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4316), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4317), 45, false, 45, 11 },
                    { 46, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4321), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4321), 46, false, 46, 26 },
                    { 47, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4325), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4325), 47, false, 47, 8 },
                    { 48, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4329), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4329), 48, false, 48, 5 },
                    { 49, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4334), 49, false, 49, 16 },
                    { 50, new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 11, 4, 22, 22, 32, 568, DateTimeKind.Local).AddTicks(4338), 50, false, 50, 19 }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "SaleApprovalId", "ServerId", "Status", "TechExecutionId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 5, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 8, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(3618), new DateTime(2025, 11, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 11, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(2851), 5, new DateTime(2026, 11, 4, 22, 22, 33, 21, DateTimeKind.Local).AddTicks(3625), null, null, false, "Purus orci ipsum ex dui, suscipit sapien aptent lacinia scelerisque quis, libero porta lorem, pharetra ante, varius, amet pellentesque mauris. Risus ipsum vitae tristique praesent id, condimentum eu, porta, congue, sociosqu posuere per fames maecenas dui eget congue iaculis quam. Hac ex himenaeos volutpat fusce et commodo congue, risus tempus sit egestas cras metus blandit, enim, aliquam tempor, porta, conubia.", null, null, null, 0, null },
                    { 2, 3, new DateTime(2023, 12, 4, 22, 22, 33, 124, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 9, 4, 22, 22, 33, 124, DateTimeKind.Local).AddTicks(1217), new DateTime(2026, 11, 4, 22, 22, 33, 124, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 11, 4, 22, 22, 33, 123, DateTimeKind.Local).AddTicks(9805), 5, new DateTime(2025, 11, 4, 22, 22, 33, 124, DateTimeKind.Local).AddTicks(1230), null, null, false, "Phasellus viverra nullam volutpat nulla ornare placerat elit, aenean mollis semper tortor, id, convallis vivamus orci, dolor neque, sit quam. Sagittis sodales laoreet magna, ad eget himenaeos nullam ante, dapibus phasellus volutpat nisi nisl ut molestie vulputate sociosqu amet, non. Ante nulla auctor metus fermentum velit etiam nunc erat, scelerisque vestibulum, sagittis, integer rhoncus nullam purus mattis, neque maecenas euismod.", null, null, null, 0, null },
                    { 3, 4, new DateTime(2024, 2, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(7371), new DateTime(2024, 1, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(7367), new DateTime(2024, 11, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 11, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(6456), 5, new DateTime(2025, 11, 4, 22, 22, 33, 314, DateTimeKind.Local).AddTicks(7374), null, null, false, "Fringilla, dignissim metus cursus, primis suspendisse maecenas fermentum ut nulla quis, molestie massa, massa porttitor, blandit varius nulla, enim id. Pellentesque mauris iaculis id, magna, sodales eu tincidunt nisi, fringilla suspendisse sed sollicitudin euismod, consectetur phasellus varius, fermentum aliquet platea. Tempus mollis placerat, pulvinar est inceptos ex vitae eu pretium ut tempor augue leo, sollicitudin tellus blandit lectus in finibus.", null, null, null, 0, null },
                    { 4, 5, new DateTime(2024, 4, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(5146), new DateTime(2023, 11, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(5140), new DateTime(2026, 11, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 11, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(3935), 5, new DateTime(2025, 11, 4, 22, 22, 33, 404, DateTimeKind.Local).AddTicks(5150), null, null, false, "Porttitor, tellus, interdum est gravida efficitur etiam faucibus vel, massa fringilla ligula nibh eros mi pellentesque rhoncus nostra, amet sagittis. Nisl ultricies etiam habitasse nullam blandit id pretium dictum facilisis posuere, quam ullamcorper bibendum, pulvinar, ligula, libero semper id, suscipit. Nisl sem, aliquet neque, diam duis amet consequat praesent nulla mattis, eleifend, magna nec, commodo eleifend libero ut per eget.", null, null, null, 0, null },
                    { 5, 6, new DateTime(2024, 1, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(3859), new DateTime(2023, 8, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(3854), new DateTime(2025, 11, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 11, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(3091), 5, new DateTime(2026, 11, 4, 22, 22, 33, 503, DateTimeKind.Local).AddTicks(3862), null, null, false, "Pharetra vestibulum, quis, odio, tincidunt aptent integer eget interdum, scelerisque id, auctor bibendum, venenatis euismod imperdiet eros maximus massa lorem. Sem, mollis mattis elit, integer varius mi, vitae eleifend dui, in fermentum dui tincidunt ultricies enim lacinia, urna, et inceptos. Suspendisse porta phasellus condimentum et nam sollicitudin facilisis nisi, quam, lacus sagittis, purus tristique eu, mauris congue, turpis sem, nibh.", null, null, null, 0, null },
                    { 6, 7, new DateTime(2024, 5, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 12, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 11, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 11, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(3611), 5, new DateTime(2024, 11, 4, 22, 22, 33, 576, DateTimeKind.Local).AddTicks(4298), null, null, false, "Venenatis tortor, dui, luctus, vulputate vestibulum nibh elit eu nisl eu, sem efficitur fringilla, massa ligula dui arcu consectetur etiam. Amet, placerat suscipit fringilla, mattis, ultricies feugiat semper quam erat, metus velit quis fames eros dolor mi lorem libero consectetur. Maecenas arcu, auctor sed, dolor at eu, et, eget imperdiet convallis vivamus lorem, euismod, vitae egestas fermentum viverra commodo, erat.", null, null, null, 1, null },
                    { 7, 8, new DateTime(2024, 5, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(1584), new DateTime(2024, 2, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(1580), new DateTime(2026, 11, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 11, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(955), 5, new DateTime(2025, 11, 4, 22, 22, 33, 660, DateTimeKind.Local).AddTicks(1587), null, null, false, "Enim, sem, inceptos in, suscipit tellus litora est nulla, sagittis elit, in vestibulum, tortor, interdum, volutpat blandit bibendum, sollicitudin nibh. Gravida blandit urna sem, quis varius, odio, pretium mollis morbi sagittis quam urna, accumsan nec, at orci, arcu tincidunt sit. Convallis est euismod, interdum, inceptos platea mattis vitae primis amet, blandit bibendum, orci vel molestie congue risus interdum hac nec.", null, null, null, 1, null },
                    { 8, 9, new DateTime(2024, 3, 4, 22, 22, 33, 731, DateTimeKind.Local).AddTicks(20), new DateTime(2023, 8, 4, 22, 22, 33, 731, DateTimeKind.Local).AddTicks(11), new DateTime(2026, 11, 4, 22, 22, 33, 731, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 11, 4, 22, 22, 33, 730, DateTimeKind.Local).AddTicks(8847), 5, new DateTime(2024, 11, 4, 22, 22, 33, 731, DateTimeKind.Local).AddTicks(23), null, null, false, "Vestibulum, interdum platea eleifend, quis, eros, nibh efficitur risus id primis neque id, sollicitudin mollis tempus aenean ligula eleifend eu. Per vel et suscipit ad diam tempor, volutpat, venenatis taciti eget massa, sapien arcu ex odio, enim sagittis, auctor finibus. Dolor quam, ultricies odio sed, dapibus diam efficitur primis orci, lectus, magna, cras duis orci platea ullamcorper at tellus et.", null, null, null, 1, null },
                    { 9, 10, new DateTime(2024, 3, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 10, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(4887), new DateTime(2026, 11, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 11, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(4082), 5, new DateTime(2025, 11, 4, 22, 22, 33, 798, DateTimeKind.Local).AddTicks(4894), null, null, false, "Dui tempor eros, suscipit lacus ante, eget elit quis gravida porta, pulvinar, pellentesque a, vitae urna finibus, sodales vitae, magna. Quam tempor maecenas posuere, ultricies ante, donec congue nibh cursus vehicula id, molestie suspendisse lorem, rhoncus velit ut nostra, nec. Nam arcu arcu, vitae at, eros, ultrices bibendum feugiat, nisl molestie commodo, ad inceptos rhoncus, habitasse id quisque nisi, eu.", null, null, null, 1, null },
                    { 10, 11, new DateTime(2024, 3, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(3519), new DateTime(2024, 1, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(3514), new DateTime(2025, 11, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(3523), new DateTime(2023, 11, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(2661), 5, new DateTime(2026, 11, 4, 22, 22, 33, 865, DateTimeKind.Local).AddTicks(3521), null, null, false, "Leo vestibulum tempor, augue finibus, vehicula orci quis, fusce pellentesque dapibus rhoncus laoreet a, laoreet, dignissim eu, nec, justo ut. Fringilla orci conubia posuere, commodo vestibulum sit urna, vivamus phasellus non, sem, tellus ante suspendisse pellentesque nulla, nisi, gravida viverra. At, orci magna, nullam ut erat, eros, consequat erat vehicula lectus praesent et, aenean auctor quisque felis dapibus duis nisl.", null, null, null, 1, null },
                    { 11, 12, new DateTime(2023, 11, 4, 22, 22, 33, 934, DateTimeKind.Local).AddTicks(626), new DateTime(2023, 11, 4, 22, 22, 33, 934, DateTimeKind.Local).AddTicks(621), new DateTime(2025, 11, 4, 22, 22, 33, 934, DateTimeKind.Local).AddTicks(631), new DateTime(2023, 11, 4, 22, 22, 33, 933, DateTimeKind.Local).AddTicks(9760), 5, new DateTime(2026, 11, 4, 22, 22, 33, 934, DateTimeKind.Local).AddTicks(629), null, null, false, "Convallis ipsum velit felis viverra iaculis a, laoreet, nec, elementum diam dapibus posuere, ut fringilla sagittis aptent phasellus tincidunt arcu. Lacinia dui blandit integer aliquet semper ex feugiat ligula vehicula sociosqu aptent pulvinar, vulputate dolor consequat a curabitur nunc, fermentum. Neque congue elit, ultrices, vestibulum id, ut imperdiet dolor, non consequat conubia ultrices ultricies inceptos pellentesque lorem nam fames facilisis.", null, 1, 1, 2, null },
                    { 12, 13, new DateTime(2024, 5, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 9, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(6706), new DateTime(2025, 11, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(6716), new DateTime(2023, 11, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(5930), 5, new DateTime(2025, 11, 4, 22, 22, 34, 2, DateTimeKind.Local).AddTicks(6714), null, null, false, "Placerat rhoncus, leo, nostra, litora ultrices vestibulum feugiat, urna nisl tortor, mi in, interdum, nisi, vehicula proin justo venenatis curabitur. Mauris, vel aenean nunc, metus class sollicitudin et, massa volutpat torquent arcu, sem, sociosqu ipsum lacinia, congue, ultrices velit euismod. Mi, conubia sed tortor ligula tellus, tellus quis sociosqu neque praesent hac leo, ante molestie pretium odio nunc convallis gravida.", null, 1, 2, 2, null },
                    { 13, 14, new DateTime(2023, 12, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 10, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(5431), new DateTime(2026, 11, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 11, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(4634), 5, new DateTime(2026, 11, 4, 22, 22, 34, 74, DateTimeKind.Local).AddTicks(5438), null, null, false, "Quis, etiam phasellus orci, nisl ultricies elit dapibus quisque tempus at, porttitor lobortis elementum tellus, tempor, consectetur convallis massa ante. Pharetra aptent mattis, posuere feugiat, ultricies ipsum proin nulla nunc, eu, risus mauris elit, consectetur morbi lobortis tortor ornare taciti. Pulvinar, vitae tortor quis feugiat, finibus, sagittis, a, semper lectus mattis, ultrices, torquent amet, class convallis ac, fusce tellus, ultricies.", null, 1, 3, 2, null },
                    { 14, 15, new DateTime(2024, 2, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 8, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(4015), new DateTime(2026, 11, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(4024), new DateTime(2023, 11, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(3217), 5, new DateTime(2024, 11, 4, 22, 22, 34, 142, DateTimeKind.Local).AddTicks(4023), null, null, false, "Ipsum ante fringilla, orci, euismod, posuere, dictum massa, odio nibh risus quis, elementum egestas dui, ac pellentesque fringilla mauris, commodo. Nibh per porttitor, lectus ut est taciti efficitur interdum eleifend, viverra tortor, iaculis porttitor nam primis euismod, mollis enim blandit. Hendrerit rhoncus feugiat vestibulum, odio, phasellus faucibus suscipit id mauris ultrices, habitasse sed massa, fames at, condimentum nostra, feugiat, laoreet.", null, 1, 4, 2, null },
                    { 15, 16, new DateTime(2024, 2, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(3861), new DateTime(2023, 11, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(3856), new DateTime(2025, 11, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(3867), new DateTime(2023, 11, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(3002), 5, new DateTime(2024, 11, 4, 22, 22, 34, 210, DateTimeKind.Local).AddTicks(3864), null, null, false, "Proin sodales primis porta, leo, posuere consequat habitasse tellus magna etiam a cursus, laoreet quam fusce vulputate non class dui. Ornare efficitur tortor lacus eros, elit lacinia sed, justo lacinia, placerat, est malesuada erat, porta proin luctus non, metus sit. Nibh varius, cras lacus mattis phasellus eros, et fringilla, blandit quam, sapien ipsum dui lorem, ac, lobortis luctus maximus interdum.", null, 1, 5, 2, null },
                    { 16, 20, new DateTime(2024, 3, 4, 22, 22, 34, 326, DateTimeKind.Local).AddTicks(3684), new DateTime(2023, 12, 4, 22, 22, 34, 326, DateTimeKind.Local).AddTicks(3676), new DateTime(2024, 11, 4, 22, 22, 34, 326, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 11, 4, 22, 22, 34, 326, DateTimeKind.Local).AddTicks(2133), 5, new DateTime(2026, 11, 4, 22, 22, 34, 326, DateTimeKind.Local).AddTicks(3687), null, null, false, "Efficitur fusce euismod, consequat pulvinar, libero nulla, posuere, leo rhoncus, nunc aptent felis eu, sollicitudin ac, primis lacus fringilla, venenatis. Posuere, vestibulum vitae ullamcorper est sed, cras ante, mauris, rhoncus, duis viverra massa, scelerisque vivamus in ligula ut a et. Cursus placerat, ultrices quam litora amet lorem venenatis vel tempus posuere, ultrices, pulvinar egestas consectetur mollis tellus, ultricies molestie etiam.", null, 1, 6, 4, 1 },
                    { 17, 17, new DateTime(2024, 3, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(2609), new DateTime(2024, 1, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(2597), new DateTime(2026, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(2614), new DateTime(2023, 11, 4, 22, 22, 34, 326, DateTimeKind.Local).AddTicks(3743), 5, new DateTime(2025, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(2611), null, null, false, "Pellentesque sagittis, ad maecenas nibh iaculis primis lacus nam quisque porttitor semper dignissim vel taciti quam malesuada posuere eleifend, turpis. Rutrum mauris, ligula elit, porta semper vivamus commodo, dapibus leo dignissim vestibulum ante, posuere a, mauris eros, litora scelerisque auctor. Inceptos quis odio, nulla taciti laoreet vulputate orci consectetur magna, ornare fusce nisl lectus dui, ante, viverra donec quam, mollis.", null, 1, 7, 4, 1 },
                    { 18, 20, new DateTime(2024, 6, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(5743), new DateTime(2023, 8, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(5736), new DateTime(2026, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(5748), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(2738), 5, new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(5746), null, null, false, "Bibendum, nulla, suspendisse efficitur accumsan pulvinar, finibus eros, nunc, ultricies malesuada leo consectetur sodales dignissim semper amet finibus, mattis dui. A, conubia sollicitudin adipiscing sapien feugiat, eros id rutrum fames tortor, non, non urna vivamus eget cursus finibus, eleifend nulla. Aliquet nec sem, nisi orci enim elit tortor varius, rhoncus semper sodales class amet urna sed, ultrices, dictumst convallis inceptos.", null, 1, 8, 4, 1 },
                    { 19, 19, new DateTime(2024, 1, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(6653), new DateTime(2024, 2, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(6656), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(5803), 5, new DateTime(2025, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(6654), null, null, false, "Nulla fames quis ante, nec fringilla quam, elementum litora mi quis, lectus, tellus lacinia, massa, a, libero purus aliquet finibus. Praesent tortor, commodo, quis phasellus lorem, feugiat, aliquam convallis sem urna, venenatis mi metus et, velit sit rutrum vel ante. Finibus nibh nec proin porta euismod, porttitor, ultricies vel, vulputate mattis placerat, bibendum, integer erat, eget quis fringilla, posuere, feugiat.", null, 1, 9, 4, 1 },
                    { 20, 18, new DateTime(2024, 3, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(7559), new DateTime(2023, 12, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(7554), new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(7564), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(6689), 5, new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(7561), null, null, false, "Urna, et nulla, iaculis tristique ac eu porttitor, sem, sociosqu libero sem volutpat, turpis ligula, phasellus leo posuere elit inceptos. Litora dui malesuada tellus habitasse lacinia arcu, nibh, conubia nec ullamcorper massa ultrices arcu praesent eleifend, nostra, quam, quisque bibendum. Sit interdum, id, non, himenaeos feugiat, congue, pulvinar, ad vestibulum, ligula, venenatis scelerisque fusce eu enim pellentesque class fringilla fringilla.", null, 1, 10, 4, 1 },
                    { 21, 17, new DateTime(2024, 3, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8245), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8249), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(7601), 5, new DateTime(2025, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8247), null, null, false, "Ornare leo malesuada scelerisque purus id, nec pretium lectus, fermentum est tincidunt ante, quam, sagittis venenatis mattis tempus odio imperdiet. Lobortis class sed enim, rhoncus, felis sagittis tortor tempor auctor luctus nullam leo tortor, dui turpis dolor risus pretium ultricies. Pulvinar non, mattis, orci, quam, auctor erat nibh vehicula convallis ex duis sagittis, luctus, primis laoreet, posuere risus consequat tortor.", null, 1, 11, 4, 1 },
                    { 22, 18, new DateTime(2024, 1, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 8, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8961), new DateTime(2025, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8262), 5, new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(8969), null, null, false, "Auctor, aenean ante gravida interdum est etiam sem, euismod, erat neque, fermentum sodales volutpat, risus ultrices curabitur mattis, vel, nunc. Non ligula, malesuada pharetra elementum dignissim tempor commodo dolor cras mattis, porttitor ultrices, eros, eros leo ligula primis ante, proin. Amet, nisi venenatis placerat, nam finibus, porta dui fusce vel, ex phasellus ultrices, mauris felis bibendum id augue non odio.", null, 1, 12, 4, 1 },
                    { 23, 16, new DateTime(2024, 3, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 12, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(9770), new DateTime(2025, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(9009), 5, new DateTime(2024, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(9776), null, null, false, "Eros id fringilla, odio, platea vestibulum dolor, facilisis maximus etiam ac, mattis venenatis commodo, eros, hendrerit posuere, integer sapien quisque. Ultricies urna, a dolor, euismod, tempor ullamcorper quisque euismod dui, erat, condimentum nulla fames vehicula nam per venenatis lectus vestibulum. Ex libero in id, leo, volutpat, nec tristique congue maximus litora tincidunt amet nullam non dolor sed porttitor, ultrices, imperdiet.", null, 1, 13, 4, 1 },
                    { 24, 18, new DateTime(2024, 1, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(445), new DateTime(2024, 2, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 11, 4, 22, 22, 34, 328, DateTimeKind.Local).AddTicks(9807), 5, new DateTime(2024, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(447), null, null, false, "Eu commodo tempor, porttitor, tincidunt eleifend, feugiat non, dignissim ante, dolor convallis nullam iaculis etiam mi sapien elit volutpat, litora. Luctus dictumst urna imperdiet elementum ullamcorper amet, laoreet, quam rutrum ac, porta, gravida at platea orci consequat scelerisque fames egestas. Phasellus eu, nibh, pulvinar in turpis nisi cras sem odio, non, nulla, nec, mauris, hac facilisis lacinia, cursus, sodales suscipit.", null, 1, 14, 4, 1 },
                    { 25, 16, new DateTime(2024, 4, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 10, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1141), new DateTime(2024, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(458), 5, new DateTime(2026, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1149), null, null, false, "Ultricies congue tincidunt dui tortor, dignissim massa feugiat fermentum mauris, ornare class primis felis nulla, vestibulum, nisi himenaeos nec, nulla. Orci velit laoreet, mi, risus aenean praesent enim, dolor, interdum ac finibus sagittis, amet eget dictumst adipiscing dui, efficitur nullam. Velit non, commodo himenaeos tristique ullamcorper tempor rhoncus ligula, fringilla, in felis duis fames a primis orci molestie augue ultrices.", null, 1, 15, 4, 1 },
                    { 26, 18, new DateTime(2024, 5, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 2, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1907), new DateTime(2026, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1915), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1185), 5, new DateTime(2026, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1912), null, null, false, "Suscipit ligula, vivamus magna, commodo, ac, viverra enim, eleifend sociosqu nunc sagittis, ultricies aptent lorem volutpat a massa pretium luctus. Feugiat, nisl aliquam duis interdum, litora porttitor, non porttitor mattis, consequat metus dictum ornare dolor eleifend posuere, ac, vivamus bibendum. Congue, tristique laoreet sem, eleifend velit urna, et ex inceptos porttitor mauris, consequat tellus, ad neque nec, est lacinia, ultrices.", null, 1, 16, 4, 1 },
                    { 27, 20, new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(2758), new DateTime(2024, 2, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(2754), new DateTime(2025, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(1944), 5, new DateTime(2026, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(2760), null, null, false, "Condimentum dui nibh lectus, diam himenaeos ornare risus curabitur nibh, torquent sem, ullamcorper aenean ac, dapibus pretium ante, vitae, inceptos. Tempor, non erat, primis ligula odio, nunc, vivamus sit molestie imperdiet lacus est lacinia, mauris, duis etiam sollicitudin sem, nullam. Enim, rutrum luctus, pellentesque quisque at, suscipit et lacus at fames lacinia, semper vivamus dui, lorem erat, odio, litora proin.", null, 1, 17, 4, 1 },
                    { 28, 16, new DateTime(2024, 2, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(3436), new DateTime(2024, 1, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(3434), new DateTime(2025, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(2792), 5, new DateTime(2026, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(3438), null, null, false, "Per maximus ornare finibus, orci accumsan quam, laoreet vitae consectetur neque himenaeos posuere euismod sagittis orci, iaculis condimentum proin feugiat. Molestie nunc, diam augue nibh posuere, duis scelerisque vehicula erat, interdum mauris, sollicitudin et, est non, erat efficitur at euismod. Fusce neque, congue, erat, tellus, efficitur vulputate velit integer elit praesent ex hendrerit bibendum, cursus suscipit sociosqu odio sagittis, turpis.", null, 1, 18, 4, 1 },
                    { 29, 16, new DateTime(2024, 3, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(4064), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(4067), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(3450), 5, new DateTime(2025, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(4065), null, null, false, "Urna et, lectus non, mauris, pellentesque massa nunc, mauris duis neque, phasellus ex lobortis sollicitudin mattis amet velit nisi ad. Dictumst sed aenean platea turpis nunc volutpat massa ornare malesuada lorem, suscipit congue, vitae, tincidunt imperdiet efficitur pellentesque pulvinar integer. Interdum, porta, cursus, varius, nostra, lectus porttitor quam volutpat, elit felis pulvinar turpis justo molestie lacus mi vitae eget euismod.", null, 1, 19, 4, 1 },
                    { 30, 18, new DateTime(2023, 12, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(1558), new DateTime(2023, 9, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 11, 4, 22, 22, 34, 329, DateTimeKind.Local).AddTicks(4075), 5, new DateTime(2025, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(1562), null, null, false, "Dolor ex semper et pulvinar fringilla per ultrices, ac, in, leo, vulputate bibendum, ut ipsum laoreet libero orci, aenean nisl. Conubia scelerisque pulvinar, quisque torquent a, maximus enim, integer elit, tincidunt eget orci venenatis primis tempor proin tellus mattis commodo. Tempus himenaeos congue adipiscing volutpat fames phasellus amet praesent risus nisi ligula euismod lacinia, lacus tellus rhoncus, viverra aptent vestibulum.", null, 1, 20, 4, 1 },
                    { 31, 16, new DateTime(2023, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(3868), new DateTime(2023, 12, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(3856), new DateTime(2024, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(1720), 5, new DateTime(2026, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(3872), null, null, false, "At, nostra, scelerisque tortor, ac egestas elementum varius, vestibulum, mattis neque euismod, ultrices, interdum, malesuada urna, lacinia dapibus pellentesque suscipit. Pulvinar, ultrices sed ullamcorper augue non ante ultrices, aenean finibus congue nulla, sem eu, scelerisque lectus, volutpat, odio, et placerat. Platea etiam vestibulum donec egestas vehicula auctor phasellus blandit dictumst nibh per dolor, semper mauris aliquet nunc posuere, hendrerit augue.", null, 1, 21, 4, 1 },
                    { 32, 17, new DateTime(2024, 1, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(5546), new DateTime(2024, 2, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(5541), new DateTime(2025, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(3973), 5, new DateTime(2024, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(5550), null, null, false, "Congue, adipiscing mattis, accumsan molestie vitae sem, massa, sagittis himenaeos auctor, at gravida ultrices mollis eleifend vel ornare interdum amet. Eleifend, quis torquent lectus eu cras semper elementum facilisis commodo congue at nostra, ullamcorper dictum eu, arcu nibh enim, risus. Nibh, nec maecenas donec posuere quisque felis porta, fusce non aliquam lacinia ipsum inceptos maximus elementum euismod eros dolor tempor.", null, 1, 22, 4, 1 },
                    { 33, 19, new DateTime(2024, 6, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 8, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(7430), new DateTime(2026, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(7444), new DateTime(2023, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(5601), 5, new DateTime(2026, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(7440), null, null, false, "Adipiscing metus est varius, dictumst augue tellus orci, dictum nullam consectetur ut blandit ullamcorper vehicula ultricies nisi erat phasellus mi. Vulputate nisl lacinia elit, elit faucibus nisi, congue, placerat, mattis, mauris mollis vitae sagittis per malesuada nibh eget convallis fringilla. Blandit phasellus consectetur lectus adipiscing ipsum est vestibulum, lacinia per et enim elementum vitae, condimentum sapien sagittis lorem bibendum placerat.", null, 1, 23, 4, 1 },
                    { 34, 18, new DateTime(2024, 6, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 2, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(3105), new DateTime(2024, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 11, 4, 22, 22, 34, 333, DateTimeKind.Local).AddTicks(7496), 5, new DateTime(2026, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(3125), null, null, false, "Vehicula pharetra sit vulputate sed, nisl et urna himenaeos sem, amet quis nullam euismod metus accumsan per torquent efficitur commodo. Tellus fringilla, donec auctor, luctus, laoreet sit eget mi justo placerat taciti pulvinar, pharetra sed magna dictum felis nunc, cras. Nec, pellentesque enim, at, eros, eget porta, vestibulum ligula, ipsum blandit facilisis et, massa velit maecenas turpis convallis amet id.", null, 1, 24, 4, 1 },
                    { 35, 16, new DateTime(2024, 6, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 9, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(4823), new DateTime(2025, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(3206), 5, new DateTime(2025, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(4828), null, null, false, "Lectus, porttitor aliquet ultricies quis primis nisl integer dictum commodo nostra, massa, volutpat, sem, velit magna dignissim conubia euismod, mattis. Primis nisi, etiam pharetra praesent libero bibendum, eros elementum et, euismod non auctor commodo, vestibulum facilisis justo erat, suscipit leo. Praesent bibendum, suspendisse urna arcu erat, et, in fringilla dictumst non lacus finibus, leo, augue accumsan ac aenean id, porta.", null, 1, 25, 4, 1 },
                    { 36, 18, new DateTime(2024, 6, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(6301), new DateTime(2025, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(4856), 5, new DateTime(2026, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(6306), null, null, false, "Justo in commodo erat, ac laoreet nec vel, hendrerit eget rhoncus, arcu, massa, dolor placerat, ex, nec, suscipit ad aenean. Laoreet, elit, at efficitur blandit commodo, non, metus torquent quis, suspendisse in luctus, magna, amet ultrices, duis justo egestas a. Ad cursus tortor lorem, elit, finibus, nisi posuere placerat vulputate sed, quis, eleifend, volutpat dapibus vel, varius, euismod faucibus amet.", null, 1, 26, 4, 1 },
                    { 37, 16, new DateTime(2024, 3, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(7788), new DateTime(2023, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(7785), new DateTime(2025, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(7793), new DateTime(2023, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(6331), 5, new DateTime(2026, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(7791), null, null, false, "Bibendum, ipsum eleifend pharetra consequat sodales leo, lacus sit phasellus convallis magna, risus eu, sem lobortis vel litora imperdiet pretium. Mauris fermentum ex purus massa, tellus sem elit enim etiam placerat, venenatis quam, magna taciti eu, lacinia, amet, interdum, ligula. Elementum sollicitudin amet hac lacus sapien id tellus mattis orci, bibendum, luctus, eleifend, proin aliquet eu dignissim lectus ex, lacinia.", null, 1, 27, 4, 1 },
                    { 38, 18, new DateTime(2024, 6, 4, 22, 22, 34, 336, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 1, 4, 22, 22, 34, 336, DateTimeKind.Local).AddTicks(3439), new DateTime(2025, 11, 4, 22, 22, 34, 336, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 11, 4, 22, 22, 34, 335, DateTimeKind.Local).AddTicks(7815), 5, new DateTime(2026, 11, 4, 22, 22, 34, 336, DateTimeKind.Local).AddTicks(3449), null, null, false, "Hendrerit justo ac tellus, blandit tempor, dui, erat enim, mi vestibulum tortor, morbi mattis mattis, consectetur vulputate dictumst in nostra. Accumsan luctus, ultrices, eu fermentum congue, dui placerat morbi dolor vulputate lacus ornare eleifend convallis arcu, elementum dapibus elit, bibendum. Luctus, fermentum himenaeos arcu platea sit euismod gravida porttitor quam, ullamcorper quam id, non cursus, iaculis leo, congue, proin massa.", null, 1, 28, 4, 1 },
                    { 39, 18, new DateTime(2024, 1, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(107), new DateTime(2023, 10, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(102), new DateTime(2025, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(111), new DateTime(2023, 11, 4, 22, 22, 34, 336, DateTimeKind.Local).AddTicks(3516), 5, new DateTime(2024, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(109), null, null, false, "Tempor, orci scelerisque blandit quisque fames sagittis ante, tellus aenean nisi ultrices, a habitasse nunc eu, sollicitudin litora pulvinar, mollis. Porttitor vestibulum, mauris, nibh, venenatis amet, id, lorem sociosqu hendrerit placerat volutpat, fusce arcu dictum risus facilisis auctor in ultrices. Lobortis blandit, placerat feugiat, ut etiam tempor, sem, commodo mi, ligula faucibus erat libero ultrices, phasellus congue himenaeos inceptos cursus.", null, 1, 29, 4, 1 },
                    { 40, 19, new DateTime(2024, 4, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 8, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(158), 5, new DateTime(2026, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(1604), null, null, false, "Ut eu, quam odio, erat semper etiam gravida amet tortor, id suspendisse cras pretium fringilla arcu quisque himenaeos fames et. Posuere, quam gravida tellus, neque placerat non, eleifend malesuada quam, neque, auctor augue bibendum congue, leo, justo hendrerit fringilla in. Ultricies sapien lobortis ullamcorper vulputate sociosqu lectus, condimentum nullam posuere aptent sed, id, morbi non, dictum rhoncus, euismod neque, fames.", null, 1, 30, 4, 1 },
                    { 41, 16, new DateTime(2024, 4, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(3274), new DateTime(2023, 10, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(3269), new DateTime(2024, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(3283), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(1659), 5, new DateTime(2025, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(3280), null, null, false, "Ad faucibus lacinia, lectus, ante, felis pulvinar, posuere, porttitor pulvinar ligula nullam volutpat habitasse mi, ex, lectus ipsum nisl praesent. Id, rutrum erat, cursus nisl ex, duis quis, vel malesuada bibendum, in, curabitur dignissim eget leo sed quis porttitor, lacus. Neque vel, elit aliquet dictumst donec magna, hac consectetur maximus nibh, integer ac, vestibulum quisque feugiat rutrum lacinia blandit, dui.", null, 1, 31, 4, 1 },
                    { 42, 16, new DateTime(2024, 2, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 10, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(6210), new DateTime(2024, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(3324), 5, new DateTime(2025, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(6223), null, null, false, "Varius, praesent platea pulvinar condimentum lorem ligula, mi dictumst bibendum rhoncus phasellus tellus, lectus, litora euismod tincidunt neque scelerisque in. Erat orci tortor, pulvinar nunc, accumsan interdum sit nam sagittis, eros, efficitur quam varius laoreet lacinia finibus, quis, nullam vestibulum. Tellus ac, laoreet, iaculis scelerisque litora enim, eu, cras magna commodo, pulvinar, maximus sapien non nam nulla fusce laoreet eleifend.", null, 1, 32, 4, 1 },
                    { 43, 17, new DateTime(2024, 6, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 12, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(7811), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(6283), 5, new DateTime(2026, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(7808), null, null, false, "Mauris, euismod conubia taciti consequat class in commodo, amet, blandit id ligula pretium mollis ut neque, eros congue, blandit, justo. Id, sem consequat habitasse maximus mollis dapibus varius sem, porttitor interdum, euismod, torquent tortor augue dui, inceptos hendrerit rhoncus imperdiet. Habitasse a, nisl lacinia, hendrerit faucibus nulla, purus elit rhoncus, non eleifend, at, nunc, mi per condimentum vel sed, taciti.", null, 1, 33, 4, 1 },
                    { 44, 17, new DateTime(2024, 5, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(9378), new DateTime(2025, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(9387), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(7850), 5, new DateTime(2026, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(9385), null, null, false, "Tincidunt libero a, amet, vitae feugiat, mauris volutpat, suspendisse blandit aptent commodo mi ante, orci quis, hac euismod, litora tellus. Orci, rhoncus, magna velit sodales massa nec facilisis arcu sapien sociosqu placerat interdum porttitor, eu quam, ac, dui mauris ultricies. Quam, quisque ex tristique cursus feugiat in, dolor, nulla elementum lectus morbi elit, ullamcorper vivamus enim, hendrerit ante mollis elit.", null, 1, 34, 4, 1 },
                    { 45, 16, new DateTime(2023, 11, 4, 22, 22, 34, 338, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 11, 4, 22, 22, 34, 338, DateTimeKind.Local).AddTicks(416), new DateTime(2024, 11, 4, 22, 22, 34, 338, DateTimeKind.Local).AddTicks(422), new DateTime(2023, 11, 4, 22, 22, 34, 337, DateTimeKind.Local).AddTicks(9426), 5, new DateTime(2026, 11, 4, 22, 22, 34, 338, DateTimeKind.Local).AddTicks(420), null, null, false, "Suspendisse nulla euismod laoreet quam vitae blandit nibh, himenaeos fringilla, ante, tincidunt amet, gravida taciti ex platea ut id eleifend. Himenaeos arcu class consequat massa malesuada suspendisse nunc, congue, rhoncus, vulputate quam, dolor, nec in ante quisque pulvinar leo arcu. Porttitor, eu, cursus, mauris, accumsan ultricies dui fermentum sagittis cursus ex ultrices molestie purus conubia et at neque rutrum viverra.", null, 1, 35, 4, 1 },
                    { 46, 22, new DateTime(2023, 12, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 12, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(2899), new DateTime(2025, 11, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 11, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(1981), 5, new DateTime(2025, 11, 4, 22, 22, 34, 794, DateTimeKind.Local).AddTicks(2906), null, null, false, "Donec litora cras magna laoreet, bibendum porttitor, luctus, semper purus lacinia neque, sed, class ut id, eros tortor, hendrerit orci. Tempus integer dolor, quis nisi, vel odio efficitur maximus quisque amet, urna praesent velit ornare in, ante, fames nam ultrices. Faucibus pharetra purus nullam vestibulum feugiat, lorem, urna ut curabitur condimentum vitae, quis, lectus nulla, est commodo sapien fames feugiat.", null, null, 36, 3, null },
                    { 47, 23, new DateTime(2023, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(6362), new DateTime(2023, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(6356), new DateTime(2026, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(6366), new DateTime(2023, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(5298), 5, new DateTime(2026, 11, 4, 22, 22, 34, 861, DateTimeKind.Local).AddTicks(6365), null, null, false, "Erat cursus, congue, ad volutpat sem, porttitor, porttitor quisque sem ex mi mi, convallis luctus, commodo amet, dignissim dolor, volutpat. Gravida laoreet, consequat odio odio, pretium non, malesuada vulputate enim etiam leo, habitasse risus sapien volutpat, tristique platea arcu suscipit. Lacus pretium commodo tempor, tellus justo fames velit aenean vel malesuada ante nibh, fusce massa class risus dignissim varius, consectetur.", null, null, 37, 3, null },
                    { 48, 24, new DateTime(2020, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(9386), new DateTime(2019, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(9382), new DateTime(2022, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(9390), new DateTime(2023, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(8589), 5, new DateTime(2023, 11, 4, 22, 22, 34, 929, DateTimeKind.Local).AddTicks(9388), null, null, false, "Odio, nulla luctus, litora cursus elit sociosqu ante nostra, praesent felis tellus, hendrerit a, phasellus ullamcorper egestas nisi urna ligula. Luctus, interdum, himenaeos quam nibh ullamcorper neque dictumst purus eleifend elementum molestie fermentum gravida tellus, consequat ut rhoncus, bibendum proin. Nibh metus nec eleifend eu aliquet vestibulum primis luctus, erat, maecenas sagittis, bibendum, bibendum finibus, blandit feugiat luctus rhoncus suscipit.", null, 1, 38, 6, 1 },
                    { 49, 25, new DateTime(2021, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(5030), new DateTime(2018, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(5025), new DateTime(2022, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(4076), 5, new DateTime(2022, 11, 4, 22, 22, 34, 997, DateTimeKind.Local).AddTicks(5032), null, null, false, "Id, risus pulvinar, mauris nunc, lectus proin ex, vel, pellentesque commodo, inceptos vulputate neque, faucibus hac quam, aptent est leo. Sem, in, nunc, enim eros imperdiet litora adipiscing ante ornare turpis vitae cursus, diam vehicula elit, inceptos id, torquent hac. Eros, suscipit lacus lectus amet semper porttitor in, risus cursus, sapien consequat eu donec adipiscing congue mauris quis auctor placerat.", null, 1, 39, 6, 1 },
                    { 50, 26, new DateTime(2020, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2569), new DateTime(2018, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2565), new DateTime(2022, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(1726), 5, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2572), null, null, false, "Turpis mauris accumsan integer phasellus urna, amet mollis leo, ante, litora congue fringilla, velit libero praesent dolor, interdum, tempus elit. Primis donec volutpat, venenatis non dictumst in, vitae, tortor non, posuere, mi, massa, nunc, eros, fusce commodo eu nibh, dui. Varius arcu lectus platea imperdiet ante euismod, himenaeos tortor, sed rutrum facilisis dui, mollis dignissim interdum faucibus sapien tempor odio.", null, 1, 40, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ServiceRequests",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "InspectionRecordFilePath", "IpId", "IsDelegated", "IsDeleted", "Quantity", "RequestId", "SaleApprovalId", "ServiceId", "Status", "TechExecutionId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2604), null, null, false, false, 4, 6, null, 1, 0, null, null, null },
                    { 2, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2621), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2622), null, null, false, false, 5, 7, null, 2, 0, null, null, null },
                    { 3, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2629), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2630), null, null, false, false, 5, 8, null, 3, 0, null, null, null },
                    { 4, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2636), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2636), null, null, false, false, 5, 8, null, 3, 0, null, null, null },
                    { 5, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2644), null, null, false, false, 3, 9, null, 3, 0, null, null, null },
                    { 6, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2652), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2653), null, null, false, false, 2, 9, null, 1, 0, null, null, null },
                    { 7, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2660), null, null, false, false, 1, 10, null, 2, 0, null, null, null },
                    { 8, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2669), null, null, false, false, 2, 11, null, 2, 2, null, null, null },
                    { 9, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2679), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2680), null, null, false, false, 3, 12, 1, 1, 1, null, null, null },
                    { 10, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2687), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2688), null, null, false, false, 4, 12, null, 3, 0, null, null, null },
                    { 11, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2695), null, null, false, false, 4, 12, null, 2, 2, null, null, null },
                    { 12, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2744), null, null, false, false, 5, 13, 1, 3, 1, null, null, null },
                    { 13, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2753), null, null, false, false, 2, 13, null, 1, 2, null, null, null },
                    { 14, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2760), null, null, false, false, 3, 13, 1, 3, 1, null, null, null },
                    { 15, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2768), null, null, false, false, 3, 13, null, 3, 0, null, null, null },
                    { 16, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2776), null, null, false, false, 5, 14, null, 2, 2, null, null, null },
                    { 17, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2783), null, null, false, false, 3, 14, 1, 1, 1, null, null, null },
                    { 18, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2792), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2792), null, null, false, false, 5, 14, null, 3, 0, null, null, null },
                    { 19, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2799), null, null, false, false, 5, 14, null, 2, 2, null, null, null },
                    { 20, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2807), null, null, false, false, 3, 15, null, 3, 2, null, null, null },
                    { 21, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2815), null, null, false, false, 1, 15, null, 3, 2, null, null, null },
                    { 22, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2828), null, null, false, false, 4, 16, null, 3, 0, null, null, null },
                    { 23, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2836), null, null, false, false, 5, 16, null, 1, 0, null, null, null },
                    { 24, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2844), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2844), null, null, false, false, 1, 16, null, 3, 0, null, null, null },
                    { 25, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2852), null, null, false, false, 1, 17, 1, 3, 1, null, null, null },
                    { 26, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2860), null, null, false, false, 2, 17, 1, 1, 3, 1, null, null },
                    { 27, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2868), null, null, false, false, 2, 17, 1, 2, 1, null, null, null },
                    { 28, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2907), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2907), null, null, false, false, 5, 18, null, 3, 0, null, null, null },
                    { 29, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2915), null, null, false, false, 4, 18, 1, 1, 3, 1, null, null },
                    { 30, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2922), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2923), null, null, false, false, 1, 18, null, 3, 0, null, null, null },
                    { 31, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2930), null, null, false, false, 3, 18, 1, 1, 1, null, null, null },
                    { 32, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2938), null, null, false, false, 5, 19, null, 3, 2, null, null, null },
                    { 33, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2945), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2946), null, null, false, false, 2, 19, 1, 3, 1, null, null, null },
                    { 34, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2953), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2954), null, null, false, false, 2, 19, 1, 1, 3, 1, null, null },
                    { 35, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2962), null, null, false, false, 1, 19, null, 3, 0, null, null, null },
                    { 36, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2970), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2970), null, null, false, false, 5, 20, 1, 1, 1, null, null, null },
                    { 37, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2977), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2978), null, null, false, false, 1, 20, 1, 2, 1, null, null, null },
                    { 38, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2986), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2986), null, null, false, false, 1, 21, null, 2, 2, null, null, null },
                    { 39, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2993), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(2994), null, null, false, false, 1, 21, null, 2, 2, null, null, null },
                    { 40, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3001), null, null, false, false, 5, 21, 1, 3, 3, 1, null, null },
                    { 41, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3009), null, null, false, false, 3, 22, null, 1, 0, null, null, null },
                    { 42, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3017), null, null, false, false, 3, 22, 1, 2, 1, null, null, null },
                    { 43, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3053), null, null, false, false, 4, 22, null, 1, 2, null, null, null },
                    { 44, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3062), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3062), null, null, false, false, 5, 23, null, 1, 2, null, null, null },
                    { 45, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3069), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3070), null, null, false, false, 5, 23, null, 2, 0, null, null, null },
                    { 46, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3077), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3077), null, null, false, false, 3, 23, 1, 2, 3, 1, null, null },
                    { 47, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3084), null, null, false, false, 1, 23, 1, 3, 3, 1, null, null },
                    { 48, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3092), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3093), null, null, false, false, 1, 24, null, 2, 0, null, null, null },
                    { 49, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3100), null, null, false, false, 2, 24, 1, 1, 1, null, null, null },
                    { 50, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3107), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3108), null, null, false, false, 2, 24, null, 3, 2, null, null, null },
                    { 51, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3115), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3115), null, null, false, false, 1, 24, 1, 3, 1, null, null, null },
                    { 52, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3124), null, null, false, false, 5, 25, null, 2, 0, null, null, null },
                    { 53, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3131), null, null, false, false, 2, 25, 1, 3, 1, null, null, null },
                    { 54, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3139), null, null, false, false, 5, 25, null, 3, 0, null, null, null },
                    { 55, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3147), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3147), null, null, false, false, 4, 26, null, 2, 0, null, null, null },
                    { 56, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3154), null, null, false, false, 5, 26, 1, 1, 3, 1, null, null },
                    { 57, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3161), null, null, false, false, 1, 26, null, 3, 2, null, null, null },
                    { 58, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3169), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3169), null, null, false, false, 1, 27, 1, 1, 1, null, null, null },
                    { 59, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3177), null, null, false, false, 1, 27, 1, 3, 3, 1, null, null },
                    { 60, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3214), null, null, false, false, 5, 28, null, 2, 2, null, null, null },
                    { 61, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3222), null, null, false, false, 3, 28, null, 2, 0, null, null, null },
                    { 62, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3229), null, null, false, false, 5, 28, 1, 1, 3, 1, null, null },
                    { 63, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3237), null, null, false, false, 2, 28, 1, 1, 3, 1, null, null },
                    { 64, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3244), null, null, false, false, 3, 28, null, 2, 0, null, null, null },
                    { 65, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3253), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3253), null, null, false, false, 4, 29, null, 3, 2, null, null, null },
                    { 66, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3262), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3262), null, null, false, false, 5, 30, null, 2, 0, null, null, null },
                    { 67, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3269), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3269), null, null, false, false, 5, 30, null, 2, 0, null, null, null },
                    { 68, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3276), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3276), null, null, false, false, 3, 30, null, 3, 2, null, null, null },
                    { 69, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3283), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3284), null, null, false, false, 5, 30, null, 1, 0, null, null, null },
                    { 70, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3292), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3292), null, null, false, false, 3, 31, null, 3, 0, null, null, null },
                    { 71, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3300), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3300), null, null, false, false, 4, 31, 1, 3, 3, 1, null, null },
                    { 72, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3307), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3308), null, null, false, false, 3, 31, null, 2, 2, null, null, null },
                    { 73, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3316), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3316), null, null, false, false, 1, 32, null, 1, 0, null, null, null },
                    { 74, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3353), null, null, false, false, 5, 32, 1, 3, 1, null, null, null },
                    { 75, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3363), null, null, false, false, 2, 33, 1, 3, 3, 1, null, null },
                    { 76, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3371), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3372), null, null, false, false, 4, 34, null, 1, 2, null, null, null },
                    { 77, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3379), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3379), null, null, false, false, 1, 34, null, 1, 0, null, null, null },
                    { 78, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3386), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3386), null, null, false, false, 2, 34, 1, 3, 1, null, null, null },
                    { 79, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3394), null, null, false, false, 1, 35, 1, 3, 3, 1, null, null },
                    { 80, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3402), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3402), null, null, false, false, 1, 35, null, 3, 2, null, null, null },
                    { 81, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3409), null, null, false, false, 3, 35, 1, 2, 1, null, null, null },
                    { 82, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3418), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3418), null, null, false, false, 5, 36, 1, 2, 1, null, null, null },
                    { 83, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3426), null, null, false, false, 1, 36, null, 2, 2, null, null, null },
                    { 84, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3433), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3433), null, null, false, false, 5, 36, null, 2, 2, null, null, null },
                    { 85, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3441), null, null, false, false, 1, 37, 1, 2, 3, 1, null, null },
                    { 86, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3449), null, null, false, false, 1, 37, null, 1, 2, null, null, null },
                    { 87, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3456), null, null, false, false, 4, 37, null, 3, 2, null, null, null },
                    { 88, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3465), null, null, false, false, 5, 38, 1, 2, 3, 1, null, null },
                    { 89, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3472), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3472), null, null, false, false, 2, 38, null, 2, 2, null, null, null },
                    { 90, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3509), null, null, false, false, 1, 39, null, 3, 0, null, null, null },
                    { 91, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3517), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3517), null, null, false, false, 2, 40, null, 1, 0, null, null, null },
                    { 92, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3525), null, null, false, false, 2, 40, null, 1, 0, null, null, null },
                    { 93, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3532), null, null, false, false, 2, 40, null, 2, 2, null, null, null },
                    { 94, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3540), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3541), null, null, false, false, 3, 41, null, 1, 2, null, null, null },
                    { 95, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3548), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3548), null, null, false, false, 2, 41, null, 1, 2, null, null, null },
                    { 96, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3555), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3556), null, null, false, false, 1, 41, 1, 3, 1, null, null, null },
                    { 97, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3563), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3563), null, null, false, false, 2, 41, 1, 2, 1, null, null, null },
                    { 98, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3570), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3571), null, null, false, false, 4, 41, null, 3, 0, null, null, null },
                    { 99, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3579), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3579), null, null, false, false, 5, 42, 1, 1, 1, null, null, null },
                    { 100, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3586), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3586), null, null, false, false, 2, 42, 1, 2, 3, 1, null, null },
                    { 101, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3594), null, null, false, false, 2, 42, 1, 3, 3, 1, null, null },
                    { 102, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3602), null, null, false, false, 5, 42, null, 2, 0, null, null, null },
                    { 103, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3610), null, null, false, false, 5, 43, null, 2, 2, null, null, null },
                    { 104, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3617), null, null, false, false, 5, 43, 1, 3, 1, null, null, null },
                    { 105, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3625), null, null, false, false, 5, 43, null, 2, 2, null, null, null },
                    { 106, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3632), null, null, false, false, 4, 43, null, 2, 2, null, null, null },
                    { 107, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3668), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3668), null, null, false, false, 1, 43, 1, 3, 3, 1, null, null },
                    { 108, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3677), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3677), null, null, false, false, 4, 44, 1, 2, 1, null, null, null },
                    { 109, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3684), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3684), null, null, false, false, 5, 44, null, 2, 0, null, null, null },
                    { 110, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3692), null, null, false, false, 1, 45, null, 1, 0, null, null, null },
                    { 111, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3699), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3700), null, null, false, false, 3, 45, 1, 1, 1, null, null, null },
                    { 112, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3708), null, null, false, false, 2, 46, null, 3, 2, null, null, null },
                    { 113, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3715), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3715), null, null, false, false, 3, 46, null, 2, 2, null, null, null },
                    { 114, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3723), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3723), null, null, false, false, 3, 47, null, 2, 2, null, null, null },
                    { 115, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3733), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3733), null, null, false, false, 2, 48, null, 1, 0, null, null, null },
                    { 116, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3741), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3742), null, null, false, false, 2, 48, 1, 3, 1, null, null, null },
                    { 117, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3749), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3749), null, null, false, false, 3, 48, 1, 1, 3, 1, null, null },
                    { 118, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3757), null, null, false, false, 5, 48, null, 3, 2, null, null, null },
                    { 119, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3765), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3765), null, null, false, false, 4, 49, 1, 2, 1, null, null, null },
                    { 120, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3772), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3772), null, null, false, false, 4, 49, 1, 1, 3, 1, null, null },
                    { 121, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3780), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3780), null, null, false, false, 3, 50, 1, 2, 1, null, null, null },
                    { 122, new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3787), new DateTime(2023, 11, 4, 22, 22, 35, 65, DateTimeKind.Local).AddTicks(3787), null, null, false, false, 3, 50, 1, 2, 3, 1, null, null }
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
