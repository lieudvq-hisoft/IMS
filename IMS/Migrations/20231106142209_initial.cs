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
                    VisitorName = table.Column<string>(type: "text", nullable: false),
                    DateAppointed = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateCheckedIn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Reason = table.Column<string>(type: "text", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    CorrectPerson = table.Column<bool>(type: "boolean", nullable: true),
                    TechNote = table.Column<string>(type: "text", nullable: true),
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
                    { 1, 8, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6676), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6676), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6684), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6684), false, "B", 5 }
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
                    { new Guid("0087049a-2f95-4946-a34c-1060de4fea30"), 0, "Nulla/Est, Lacinia gravida rhoncus", "747fbc93-a402-411f-b7af-e2f438422584", 0, "nostra@varius.com", true, "Tincidunt hendrerit auctor", false, false, null, "nisl@quis.com", "customer12", "AQAAAAIAAYagAAAAEAjgZxeJ8Onw6tlFkNOrtEQi18hHE/V9HVkA4gapt7iJLarnC31lYbYMAXPNYqKZDQ==", "2043939474", false, "", false, "customer12" },
                    { new Guid("1a0f9b56-1b86-449b-ad96-3e26d3813a5b"), 0, "Vel/Risus, Quam molestie scelerisque", "dae17b1c-984e-490b-8233-4b9759d3865e", 0, "hendrerit@gravida.com", true, "Amet nostra ligula", false, false, null, "fermentum@maecenas.com", "customer21", "AQAAAAIAAYagAAAAELj3A+l+OBZ+p/pjpQgTER86rB62WN6wA0PLLbuY1XydG9gmGvg0S4z4GiJJmxSpPw==", "2803771892", false, "", false, "customer21" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "bedb0be6-4c5a-492f-b9f2-f7f919fc3cfb", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAECcAJ2CzKX79NchHgHv3k+L8iskzM6Zp+8c27+BLMaJUfKpth7bZa0hJ2k+MYjxCmw==", "0000000003", false, "", false, "sale" },
                    { new Guid("2145a643-6cb0-4c7e-b290-0e3acb8da5a6"), 0, "Molestie/Metus, Efficitur ut fermentum", "6047c58b-b5d5-4bfe-ad7a-99a05fdcee97", 0, "quam@lectus.com", true, "Justo pulvinar nunc", false, false, null, "ante@neque.com", "customer14", "AQAAAAIAAYagAAAAEBX9oKtErgEx4lUUqYgzy5HXJOuxHUHFwld6N+OqexsRSf7OdA5v/o5JMXYPcuofUA==", "7909320013", false, "", false, "customer14" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "bb42478a-452f-4351-a511-d37ebe7eefb4", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEFYsDgLb5Ks2YpcMLosP2aCWRAMq9HezVGfaAdWzz4vSpV7N237GuAGDqXB6xS/mFw==", "0000000005", false, "", false, "admin" },
                    { new Guid("295be52c-4b37-4d5f-aafd-4a7fa26f40af"), 0, "Volutpat/Sagittis, Viverra mi eros", "b794a3d1-8a50-4246-a285-1c198d9452a1", 0, "ad@sem.com", true, "Sapien ultrices molestie", false, false, null, "class@felis.com", "customer7", "AQAAAAIAAYagAAAAEP83KtgfURYpczQtjey5R3/HqstGt9Gvrq8KCFG7dEupGRC3vZwTO5S2fzpS6XUzDA==", "1792935760", false, "", false, "customer7" },
                    { new Guid("2aefee94-7d4e-4b12-b353-f9dd81d7a1ef"), 0, "Blandit/Ipsum, Mauris eleifend dictumst", "1b89c748-7b02-4a9a-9f2d-64f6f4024a11", 0, "blandit@turpis.com", true, "Himenaeos pretium fames", false, false, null, "id@conubia.com", "customer24", "AQAAAAIAAYagAAAAEHBulXipUwbj8yRUV+CYHtDut0qstj3rI78Od2l6q1YquOXbiWamQuq2lDw1sbR4pQ==", "3136986856", false, "", false, "customer24" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "7d98b3b9-9049-4d95-8a14-2cbf5a4df3d0", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEC+GpmDwRJkqOIERZh/ZmvOVXpCITPLWY3QnRtj4EM2oLXvG63XaOQEzr4UL8DakQA==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "b58d9ad6-a68c-4581-9c52-ba6f201bdbbb", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEMA+/1bM1pHtsKVgNvkzDRJIev5hVDZaPujkAD20i3Cw2myzsuE1fDYDJKuBgL1KSA==", "0000000002", false, "", false, "tech" },
                    { new Guid("4b1f1494-598c-4700-bd5c-9354fb285afa"), 0, "Consequat/Praesent, At tellus scelerisque", "d8c54fd7-233d-4817-900f-34ec94be31c8", 0, "orci@vestibulum.com", true, "Condimentum lectus sem", false, false, null, "euismod@ac.com", "customer17", "AQAAAAIAAYagAAAAEIy2XsDyHjuFDkFvo60h/rPdRqF4D8SFRR1XGJCYC1i9DbjzJ+KUYHTZ7SKKEkvZjw==", "3629821795", false, "", false, "customer17" },
                    { new Guid("4de850c3-4875-4586-8463-3862c518a9e1"), 0, "Hendrerit/A, Placerat sed orci", "072c2c8c-be02-4c6f-87a1-0cd1497fb80d", 0, "fusce@sit.com", true, "Gravida mi fames", false, false, null, "posuere@vivamus.com", "customer23", "AQAAAAIAAYagAAAAEBNnkso4Umek5qa5lyMX+3ODYTpKHRjPtmlHuGVZXdY3DmGpzID3iSGT9nREh+obiw==", "6225016365", false, "", false, "customer23" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "83621f29-4a48-4571-96f2-912225b26ed2", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEG+AGluHbmVU/hOthqGn1KvA8qThjyLXLk1vBCenpo7DfC8AG3ndS/UU4j4qEtoXqA==", "0000000001", false, "", false, "super" },
                    { new Guid("5ce8361f-e1ac-4599-9845-a0c8bd4ee931"), 0, "Laoreet/Eu, Mattis volutpat pharetra", "64092619-0dd8-4d55-b9b8-a495b232a9df", 0, "vel@sodales.com", true, "Ligula neque conubia", false, false, null, "curabitur@vitae.com", "customer19", "AQAAAAIAAYagAAAAEOd7Qy/vTe+AjgVXb+WU7qCqBUVS8MmmTiSEdIPnN8y/m9M2LQjC0J+GUsOqQ9XQ9w==", "1585943387", false, "", false, "customer19" },
                    { new Guid("5e595a6e-d63f-4e60-88b0-d25ccf3a437b"), 0, "Faucibus/Lacinia, Aptent neque dictum", "f1774a8f-dba0-49cd-9356-cfc6f356cc59", 0, "fames@curabitur.com", true, "Himenaeos massa id", false, false, null, "elit@amet.com", "customer3", "AQAAAAIAAYagAAAAEByfPAhNrNAyjC2//GSK6GB/Acmb/TZgCTn1VSpuxeGKjM/p8tIPLzABv8gsKOpGug==", "8084117391", false, "", false, "customer3" },
                    { new Guid("70e3d594-95f9-4abe-939c-abedf5709b64"), 0, "Per/Nullam, Fermentum ante litora", "cd979f9d-95cb-47ce-a821-e3ce8187f504", 0, "arcu@consectetur.com", true, "Lobortis ante ipsum", false, false, null, "auctor@volutpat.com", "customer13", "AQAAAAIAAYagAAAAEH+HX27t3pVrc3gFHMLfRJZlHfNSsVTZlOnNowobUcFVKyAEQnT+4b3QFvYDeN7WBg==", "5405030744", false, "", false, "customer13" },
                    { new Guid("830130c1-969c-4df0-8833-e8520c6fe0ad"), 0, "Nibh/Phasellus, Commodo nisl morbi", "b0b4e491-5737-430f-9c7d-5c87b1ed8591", 0, "mattis@tempor.com", true, "Euismod luctus elementum", false, false, null, "non@ultricies.com", "customer6", "AQAAAAIAAYagAAAAEAzwUWbSEA/6hc3Tbx7wGT6bYXBy6PaKqo4WvMUbOEq6k2nZQTjvY9MpIXwSrXbwAg==", "9185525705", false, "", false, "customer6" },
                    { new Guid("859f3203-5ab4-43a9-bf36-8c03e42f823a"), 0, "Nostra/Tellus, Rhoncus molestie class", "fbb201b0-ea84-478e-8099-c9ede0dc4eea", 0, "dignissim@nibh.com", true, "Lobortis pellentesque mi", false, false, null, "vitae@lorem.com", "customer20", "AQAAAAIAAYagAAAAEEy1GwTYFFx1MTKT1wj/fbZ9PA+T16q5RAOxay/9UKTLOEjbRqbpSkwF6MJRHtnYmg==", "4850200537", false, "", false, "customer20" },
                    { new Guid("8f7ed10d-11fa-4dfe-908f-a96a605131ac"), 0, "Orci/Vestibulum, Dapibus erat phasellus", "d2bb32aa-4cea-4b25-8ccd-d3c69723ae7b", 0, "vitae@rhoncus.com", true, "Faucibus ut lacinia", false, false, null, "ultricies@lacinia.com", "customer10", "AQAAAAIAAYagAAAAEOV7UvZo7bl8bI6v6nk0Brt+RY1BQO6UVF9/wGds9f/TIPgtFmYkC9rYfpcA/j2ETA==", "8185256113", false, "", false, "customer10" },
                    { new Guid("aec8cb65-b8ac-4e46-8661-03c99376d84f"), 0, "Malesuada/Auctor, Sem tortor massa", "587bbdb8-894a-4e98-ba6c-9d83de450555", 0, "dui@nunc.com", true, "Eu sed congue", false, false, null, "consectetur@fusce.com", "customer11", "AQAAAAIAAYagAAAAEAr74g+kg+LHctihNe+N5CD3SSm/6LOpcjfzUcFkad+ZOiitY160CQZyMbc2y2yFrw==", "3054441518", false, "", false, "customer11" },
                    { new Guid("bc8b2b1e-4efd-47d9-93a1-f149506d9876"), 0, "Fringilla/Pellentesque, Primis lectus ultrices", "220e21e7-6bd1-418a-a6dd-7d1d39e3dd06", 0, "diam@nec.com", true, "Sit at urna", false, false, null, "feugiat@suspendisse.com", "customer4", "AQAAAAIAAYagAAAAEG3Qtohwu26z8yQSFtPScGNMFSFCAXPGfUqR+fBvP6mUtSIkkSpiMewzNvSYpPhr3w==", "8190772821", false, "", false, "customer4" },
                    { new Guid("be5a516d-d293-476f-a7b7-a74d0412e08c"), 0, "Taciti/Quis, Quisque rhoncus tempor", "4f960ebb-9dca-4dea-ba7a-0157f3e8cf58", 0, "rhoncus@aliquam.com", true, "Massa tortor arcu", false, false, null, "platea@nulla.com", "customer15", "AQAAAAIAAYagAAAAEH0AprSVZXzUgslSDrK7RtDS5nu5Ly9W9KImi6l4nH6HnKEO1Bjq2M14A9olDGlRvg==", "3901440901", false, "", false, "customer15" },
                    { new Guid("d9323635-87f8-4f9d-a9b0-3c768f7686df"), 0, "Molestie/Ligula, Urna pellentesque luctus", "49fd9df1-3a22-4c9f-a1bf-1559ae1c8f01", 0, "pellentesque@neque.com", true, "Laoreet auctor dictumst", false, false, null, "metus@in.com", "customer2", "AQAAAAIAAYagAAAAEDYeUtR+isxMsi+/pzpr+Ie6OJXee9ouWuDfs2NYKo0ksVxsKpH/41yqy9uZyVXjaQ==", "1582342403", false, "", false, "customer2" },
                    { new Guid("dcae5a40-0672-4693-97c5-82323840687e"), 0, "Elementum/Hac, Lectus congue eros", "d664ba0a-d094-4cea-a14b-43ae75551278", 0, "lacinia@nibh.com", true, "Cursus bibendum in", false, false, null, "urna@quam.com", "customer22", "AQAAAAIAAYagAAAAEJdfo4fdmAzGuFyuT8iaE66n2TSYvx9YHfxmtZJ+rKhHzxoq0Cl43VmVj14bJuUxag==", "1443682690", false, "", false, "customer22" },
                    { new Guid("de855dc9-d733-43d3-ae86-17f6b328fd74"), 0, "Ante/Dictum, Consequat quis etiam", "66a2a4bc-8435-432c-ae69-c24d89c7b2c1", 0, "nisl@maximus.com", true, "Magna commodo vel", false, false, null, "quisque@accumsan.com", "customer16", "AQAAAAIAAYagAAAAEBTo9bWV02Q3nVTjemgW4MvGOIhnOyD2t3o2SPh1Tigjhf8g/Yrq1poOYTmcY6pawQ==", "8749876745", false, "", false, "customer16" },
                    { new Guid("df961f80-b405-4c49-a4b0-5fce24dca41a"), 0, "Nisi/Suspendisse, Proin orci nisi", "a9d7d539-930d-4efb-94ab-0a451ee75f59", 0, "libero@ac.com", true, "Ad nibh faucibus", false, false, null, "posuere@leo.com", "customer18", "AQAAAAIAAYagAAAAEBdNcZ5o6QmZ2veUhEKEGuxY9+HSOjbyhHf1mW5d6fgc7a+gtK5I9wDC+DASDuhKTQ==", "6659372401", false, "", false, "customer18" },
                    { new Guid("e1d74e83-8a43-4170-9148-c08c1c832424"), 0, "Felis/Cursus, Nunc fringilla nullam", "9b509c94-3bec-4792-ab1e-c284872e3e0e", 0, "aliquam@blandit.com", true, "Venenatis sagittis dui", false, false, null, "tristique@dolor.com", "customer1", "AQAAAAIAAYagAAAAEBXk5lAvhha1vrs4S9vcQEaiBCN2eGZxFHNiipyUvvSuJt5J36PSUyHTEJpXSqfqnA==", "8344337128", false, "", false, "customer1" },
                    { new Guid("e63dc61e-fd94-466f-9b8e-ea18f1430d22"), 0, "Tellus/Ac, Nullam at lorem", "54686337-4711-4ae5-aad3-412ed7c3e4da", 0, "nisi@luctus.com", true, "Lacinia consequat magna", false, false, null, "fermentum@magna.com", "customer25", "AQAAAAIAAYagAAAAEAEyGraw+zwKbKXNt0MaYBiXoiGvkCgz38cRh7zIQ+RIplsuoq+rhHH+GtH8myzN5g==", "6907948500", false, "", false, "customer25" },
                    { new Guid("e656d838-13de-4e90-9434-cc2babca9ef9"), 0, "Erat/Aptent, Nostra in feugiat", "df0e54c9-ba21-457c-ac1e-50bf36a21bcc", 0, "nunc@nec.com", true, "Adipiscing lectus tortor", false, false, null, "mollis@imperdiet.com", "customer8", "AQAAAAIAAYagAAAAENEvGTmbcR5nd/kQz3G6kueKoenHOqsoJ6w6eXmziOJwu8KeEi0G6mHTCpVyi9hSwQ==", "2314097025", false, "", false, "customer8" },
                    { new Guid("e66ca5be-cbb5-418c-ba40-215f7ed6d5e6"), 0, "Viverra/Congue, Rhoncus ultrices velit", "52ee4369-4f9c-4bd8-b8d4-2660e48c3bfd", 0, "tortor@purus.com", true, "Nulla nisl pulvinar", false, false, null, "et@lorem.com", "customer9", "AQAAAAIAAYagAAAAELWaJklbNmhWY42vbWJVetVWAuEEtPtRIH+99+idVWjFnWf/FCG1x1Esvt8jOYF8BA==", "3374157013", false, "", false, "customer9" },
                    { new Guid("f8334de7-2ad1-42cb-8ec2-b8e627001b6d"), 0, "Rhoncus/In, Vel vel tellus", "d38bed68-b128-47ae-988a-970486ab9a56", 0, "dictumst@mattis.com", true, "Pulvinar phasellus commodo", false, false, null, "sagittis@posuere.com", "customer5", "AQAAAAIAAYagAAAAEPbWrpGoMBi9onuSiWKUc9gDk65lwP5Gnbo2UfStDO0EGpyRVEkPK2AsGDSmRP9YDw==", "5455868750", false, "", false, "customer5" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(5871), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(5998), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6006), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6006), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6012), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6035), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6035), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 427, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6106), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6106), false, 10, 0, "Hub" },
                    { 2, 0, 0, 203, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6140), false, 4, 1, "Hub" },
                    { 3, 0, 0, 285, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6223), false, 9, 1, "Hub" },
                    { 4, 0, 0, 286, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6233), false, 4, 0, "Hub" },
                    { 5, 0, 0, 231, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6243), false, 6, 0, "Hub" },
                    { 6, 0, 0, 482, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6253), false, 10, 0, "Hub" },
                    { 7, 0, 0, 485, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6262), false, 2, 0, "Hub" },
                    { 8, 0, 0, 400, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6273), false, 6, 0, "Hub" },
                    { 9, 0, 0, 500, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6281), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6282), false, 9, 1, "Hub" },
                    { 10, 0, 0, 235, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6291), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6292), false, 10, 1, "Hub" },
                    { 11, 0, 0, 350, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6301), false, 6, 0, "Server" },
                    { 12, 0, 0, 267, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6311), false, 9, 0, "Server" },
                    { 13, 0, 0, 359, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6319), false, 6, 0, "Server" },
                    { 14, 0, 0, 406, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6327), false, 7, 0, "Server" },
                    { 15, 0, 0, 272, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6335), false, 9, 0, "Server" },
                    { 16, 0, 0, 411, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6344), false, 4, 0, "Server" },
                    { 17, 0, 0, 244, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6352), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6352), false, 6, 0, "Server" },
                    { 18, 0, 0, 207, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6361), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6362), false, 3, 0, "Server" },
                    { 19, 0, 0, 353, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6370), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6370), false, 8, 0, "Server" },
                    { 20, 0, 0, 391, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6378), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6378), false, 10, 0, "Server" },
                    { 21, 0, 0, 462, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6386), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6386), false, 6, 0, "Server" },
                    { 22, 0, 0, 366, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6405), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6406), false, 2, 0, "Server" },
                    { 23, 0, 0, 206, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6415), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6416), false, 3, 0, "Server" },
                    { 24, 0, 0, 335, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6423), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6424), false, 6, 0, "Server" },
                    { 25, 0, 0, 367, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6438), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6439), false, 5, 0, "Server" },
                    { 26, 0, 0, 431, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6460), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6461), false, 10, 0, "Server" },
                    { 27, 0, 0, 437, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6498), false, 5, 0, "Server" },
                    { 28, 0, 0, 219, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6509), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6509), false, 10, 0, "Server" },
                    { 29, 0, 0, 351, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6517), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6518), false, 2, 0, "Server" },
                    { 30, 0, 0, 447, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6526), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6526), false, 2, 0, "Server" },
                    { 31, 0, 0, 331, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6536), false, 10, 0, "Server" },
                    { 32, 0, 0, 225, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6545), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6545), false, 4, 0, "Server" },
                    { 33, 0, 0, 466, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6552), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6553), false, 7, 0, "Server" },
                    { 34, 0, 0, 202, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6560), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6560), false, 9, 0, "Server" },
                    { 35, 0, 0, 301, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6566), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6566), false, 2, 0, "Server" },
                    { 36, 0, 0, 267, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6572), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6572), false, 6, 0, "Server" },
                    { 37, 0, 0, 402, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6577), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6578), false, 8, 0, "Server" },
                    { 38, 0, 0, 230, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6583), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6583), false, 6, 0, "Server" },
                    { 39, 0, 0, 242, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6588), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6589), false, 6, 0, "Server" },
                    { 40, 0, 0, 488, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6594), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6594), false, 7, 0, "Server" },
                    { 41, 0, 0, 289, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6600), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6600), false, 3, 0, "Server" },
                    { 42, 0, 0, 240, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6605), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6605), false, 2, 0, "Server" },
                    { 43, 0, 0, 205, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6621), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6621), false, 9, 0, "Server" },
                    { 44, 0, 0, 460, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6626), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6626), false, 2, 0, "Server" },
                    { 45, 0, 0, 418, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6631), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6632), false, 3, 0, "Server" },
                    { 46, 0, 0, 368, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6637), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6637), false, 4, 0, "Server" },
                    { 47, 0, 0, 292, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6642), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6643), false, 5, 0, "Server" },
                    { 48, 0, 0, 245, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6648), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6649), false, 3, 2, "Server" },
                    { 49, 0, 0, 428, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6655), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6655), false, 8, 2, "Server" },
                    { 50, 0, 0, 335, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6660), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6661), false, 2, 2, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8176), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8176), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8185), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8185), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6067), "Thuê Chỗ", false, "Cấp bổ sung U", "Size" },
                    { 2, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6082), "Thêm 1U", false, "Bổ sung IP", "Ip" },
                    { 3, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6089), "Công suất 100", false, "Thêm Port", "Port" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("0087049a-2f95-4946-a34c-1060de4fea30") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("1a0f9b56-1b86-449b-ad96-3e26d3813a5b") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("2145a643-6cb0-4c7e-b290-0e3acb8da5a6") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("295be52c-4b37-4d5f-aafd-4a7fa26f40af") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("2aefee94-7d4e-4b12-b353-f9dd81d7a1ef") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4b1f1494-598c-4700-bd5c-9354fb285afa") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4de850c3-4875-4586-8463-3862c518a9e1") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("5ce8361f-e1ac-4599-9845-a0c8bd4ee931") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("5e595a6e-d63f-4e60-88b0-d25ccf3a437b") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("70e3d594-95f9-4abe-939c-abedf5709b64") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("830130c1-969c-4df0-8833-e8520c6fe0ad") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("859f3203-5ab4-43a9-bf36-8c03e42f823a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("8f7ed10d-11fa-4dfe-908f-a96a605131ac") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("aec8cb65-b8ac-4e46-8661-03c99376d84f") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("bc8b2b1e-4efd-47d9-93a1-f149506d9876") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("be5a516d-d293-476f-a7b7-a74d0412e08c") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("d9323635-87f8-4f9d-a9b0-3c768f7686df") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("dcae5a40-0672-4693-97c5-82323840687e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("de855dc9-d733-43d3-ae86-17f6b328fd74") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("df961f80-b405-4c49-a4b0-5fce24dca41a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("e1d74e83-8a43-4170-9148-c08c1c832424") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("e63dc61e-fd94-466f-9b8e-ea18f1430d22") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("e656d838-13de-4e90-9434-cc2babca9ef9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("e66ca5be-cbb5-418c-ba40-215f7ed6d5e6") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("f8334de7-2ad1-42cb-8ec2-b8e627001b6d") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(1009), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(1010), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Mauris cursus porta", 5, new DateTime(2023, 11, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 11, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(2569), false, "97458177", new Guid("e1d74e83-8a43-4170-9148-c08c1c832424") },
                    { 3, "Ac dictum malesuada", 1, new DateTime(2023, 11, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(3515), new DateTime(2023, 11, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(3522), false, "616351123", new Guid("d9323635-87f8-4f9d-a9b0-3c768f7686df") },
                    { 4, "Libero suscipit eros", 3, new DateTime(2023, 11, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(2898), new DateTime(2023, 11, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(2904), false, "903403957", new Guid("5e595a6e-d63f-4e60-88b0-d25ccf3a437b") },
                    { 5, "Non nam molestie", 3, new DateTime(2023, 11, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(6463), new DateTime(2023, 11, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(6466), false, "178989447", new Guid("bc8b2b1e-4efd-47d9-93a1-f149506d9876") },
                    { 6, "Suscipit tellus lacinia", 4, new DateTime(2023, 11, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(3100), new DateTime(2023, 11, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(3106), false, "1260825388", new Guid("f8334de7-2ad1-42cb-8ec2-b8e627001b6d") },
                    { 7, "Vestibulum ante justo", 1, new DateTime(2023, 11, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(463), new DateTime(2023, 11, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(466), false, "633995505", new Guid("830130c1-969c-4df0-8833-e8520c6fe0ad") },
                    { 8, "Lacus eu cras", 5, new DateTime(2023, 11, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 11, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(1273), false, "1006894059", new Guid("295be52c-4b37-4d5f-aafd-4a7fa26f40af") },
                    { 9, "Tortor nulla feugiat", 5, new DateTime(2023, 11, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 11, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(7835), false, "1276762370", new Guid("e656d838-13de-4e90-9434-cc2babca9ef9") },
                    { 10, "Sagittis tellus vel", 1, new DateTime(2023, 11, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 11, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(6067), false, "1989615990", new Guid("e66ca5be-cbb5-418c-ba40-215f7ed6d5e6") },
                    { 11, "Nam sapien porta", 4, new DateTime(2023, 11, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(592), new DateTime(2023, 11, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(596), false, "263745809", new Guid("8f7ed10d-11fa-4dfe-908f-a96a605131ac") },
                    { 12, "Nulla magna in", 2, new DateTime(2023, 11, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 11, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(7951), false, "892828969", new Guid("aec8cb65-b8ac-4e46-8661-03c99376d84f") },
                    { 13, "Imperdiet praesent urna", 3, new DateTime(2023, 11, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(3775), new DateTime(2023, 11, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(3781), false, "1090621172", new Guid("0087049a-2f95-4946-a34c-1060de4fea30") },
                    { 14, "Duis amet pellentesque", 1, new DateTime(2023, 11, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 11, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(4911), false, "1919717401", new Guid("70e3d594-95f9-4abe-939c-abedf5709b64") },
                    { 15, "At elit quam", 3, new DateTime(2023, 11, 6, 21, 22, 8, 423, DateTimeKind.Local).AddTicks(9434), new DateTime(2023, 11, 6, 21, 22, 8, 423, DateTimeKind.Local).AddTicks(9438), false, "899215205", new Guid("2145a643-6cb0-4c7e-b290-0e3acb8da5a6") },
                    { 16, "Quam dui elit", 5, new DateTime(2023, 11, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 11, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(3081), false, "78777949", new Guid("be5a516d-d293-476f-a7b7-a74d0412e08c") },
                    { 17, "Sem aenean magna", 1, new DateTime(2023, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(6907), new DateTime(2023, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(6937), false, "1825014629", new Guid("de855dc9-d733-43d3-ae86-17f6b328fd74") },
                    { 18, "Aptent elementum ad", 4, new DateTime(2023, 11, 6, 21, 22, 8, 700, DateTimeKind.Local).AddTicks(4071), new DateTime(2023, 11, 6, 21, 22, 8, 700, DateTimeKind.Local).AddTicks(4077), false, "90693589", new Guid("4b1f1494-598c-4700-bd5c-9354fb285afa") },
                    { 19, "Blandit tempor taciti", 1, new DateTime(2023, 11, 6, 21, 22, 8, 783, DateTimeKind.Local).AddTicks(1683), new DateTime(2023, 11, 6, 21, 22, 8, 783, DateTimeKind.Local).AddTicks(1686), false, "1969222177", new Guid("df961f80-b405-4c49-a4b0-5fce24dca41a") },
                    { 20, "Luctus auctor sed", 3, new DateTime(2023, 11, 6, 21, 22, 8, 853, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 11, 6, 21, 22, 8, 853, DateTimeKind.Local).AddTicks(8040), false, "1919337019", new Guid("5ce8361f-e1ac-4599-9845-a0c8bd4ee931") },
                    { 21, "Commodo sagittis primis", 5, new DateTime(2023, 11, 6, 21, 22, 8, 929, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 11, 6, 21, 22, 8, 929, DateTimeKind.Local).AddTicks(6314), false, "1196608294", new Guid("859f3203-5ab4-43a9-bf36-8c03e42f823a") },
                    { 22, "Ex elit donec", 2, new DateTime(2023, 11, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 11, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(7971), false, "1477100460", new Guid("1a0f9b56-1b86-449b-ad96-3e26d3813a5b") },
                    { 23, "Aliquam primis dolor", 5, new DateTime(2023, 11, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(4445), new DateTime(2023, 11, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(4454), false, "924111352", new Guid("dcae5a40-0672-4693-97c5-82323840687e") },
                    { 24, "Luctus dolor ante", 2, new DateTime(2023, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(7321), new DateTime(2023, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(7325), false, "403691170", new Guid("4de850c3-4875-4586-8463-3862c518a9e1") },
                    { 25, "Semper lacus non", 1, new DateTime(2023, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(935), new DateTime(2023, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(943), false, "1887509086", new Guid("2aefee94-7d4e-4b12-b353-f9dd81d7a1ef") },
                    { 26, "In bibendum eget", 4, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(6854), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(6860), false, "644414712", new Guid("e63dc61e-fd94-466f-9b8e-ea18f1430d22") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8197), false, false, 2 },
                    { 2, 2, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8204), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8204), false, false, 1 },
                    { 3, 3, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8209), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8209), false, false, 2 },
                    { 4, 4, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8213), false, false, 1 },
                    { 5, 5, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8217), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8217), false, false, 2 },
                    { 6, 6, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8222), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8222), false, false, 1 },
                    { 7, 7, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8226), false, false, 2 },
                    { 8, 8, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8230), false, false, 1 },
                    { 9, 9, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8234), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8234), false, false, 2 },
                    { 10, 10, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8245), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8245), false, false, 1 },
                    { 11, 11, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8250), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8250), false, false, 2 },
                    { 12, 12, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8253), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8254), false, false, 1 },
                    { 13, 13, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8258), false, false, 2 },
                    { 14, 14, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8261), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8262), false, false, 1 },
                    { 15, 15, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8265), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8266), false, false, 2 },
                    { 16, 16, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8269), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8269), false, false, 1 },
                    { 17, 17, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8273), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8273), false, false, 2 },
                    { 18, 18, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8277), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8278), false, false, 1 },
                    { 19, 19, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8281), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8281), false, false, 2 },
                    { 20, 20, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8285), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8285), false, false, 1 },
                    { 21, 21, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8289), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8289), false, false, 2 },
                    { 22, 22, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8292), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8293), false, false, 1 },
                    { 23, 23, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8296), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8297), false, false, 2 },
                    { 24, 24, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8300), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8300), false, false, 1 },
                    { 25, 25, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8304), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8304), false, false, 2 },
                    { 26, 26, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8308), false, false, 1 },
                    { 27, 27, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8312), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8312), false, false, 2 },
                    { 28, 28, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8316), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8316), false, false, 1 },
                    { 29, 29, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8320), false, false, 2 },
                    { 30, 30, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8324), false, false, 1 },
                    { 31, 31, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8328), false, false, 2 },
                    { 32, 32, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8331), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8331), false, false, 1 },
                    { 33, 33, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8335), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8335), false, false, 2 },
                    { 34, 34, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8340), false, false, 1 },
                    { 35, 35, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8348), false, false, 2 },
                    { 36, 36, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8352), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8353), false, false, 1 },
                    { 37, 37, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8356), false, false, 2 },
                    { 38, 38, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8360), false, false, 1 },
                    { 39, 39, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8365), false, false, 2 },
                    { 40, 40, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8368), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8368), false, false, 1 },
                    { 41, 41, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8372), false, false, 2 },
                    { 42, 42, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8376), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8376), false, false, 1 },
                    { 43, 43, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8380), false, false, 2 },
                    { 44, 44, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8384), false, false, 1 },
                    { 45, 45, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8387), false, false, 2 },
                    { 46, 46, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8391), false, false, 1 },
                    { 47, 47, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8395), false, false, 2 },
                    { 48, 48, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8399), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8399), false, false, 1 },
                    { 49, 49, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8403), false, false, 2 },
                    { 50, 50, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8406), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8407), false, false, 1 },
                    { 51, 51, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8410), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8410), false, false, 2 },
                    { 52, 52, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8414), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8414), false, false, 1 },
                    { 53, 53, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8418), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8418), false, false, 2 },
                    { 54, 54, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8421), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8422), false, false, 1 },
                    { 55, 55, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8425), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8425), false, false, 2 },
                    { 56, 56, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8429), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8429), false, false, 1 },
                    { 57, 57, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8433), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8433), false, false, 2 },
                    { 58, 58, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8436), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8437), false, false, 1 },
                    { 59, 59, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8441), false, false, 2 },
                    { 60, 60, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8444), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8445), false, false, 1 },
                    { 61, 61, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8449), false, false, 2 },
                    { 62, 62, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8452), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8452), false, false, 1 },
                    { 63, 63, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8462), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8462), false, false, 2 },
                    { 64, 64, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8466), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8466), false, false, 1 },
                    { 65, 65, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8469), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8470), false, false, 2 },
                    { 66, 66, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8474), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8474), false, false, 1 },
                    { 67, 67, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8478), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8478), false, false, 2 },
                    { 68, 68, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8481), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8482), false, false, 1 },
                    { 69, 69, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8485), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8486), false, false, 2 },
                    { 70, 70, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8489), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8489), false, false, 1 },
                    { 71, 71, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8493), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8493), false, false, 2 },
                    { 72, 72, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8497), false, false, 1 },
                    { 73, 73, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8500), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8501), false, false, 2 },
                    { 74, 74, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8505), false, false, 1 },
                    { 75, 75, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8508), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8508), false, false, 2 },
                    { 76, 76, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8512), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8512), false, false, 1 },
                    { 77, 77, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8516), false, false, 2 },
                    { 78, 78, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8519), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8519), false, false, 1 },
                    { 79, 79, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8523), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8523), false, false, 2 },
                    { 80, 80, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8527), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8527), false, false, 1 },
                    { 81, 81, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8531), false, false, 2 },
                    { 82, 82, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8535), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8535), false, false, 1 },
                    { 83, 83, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8539), false, false, 2 },
                    { 84, 84, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8543), false, false, 1 },
                    { 85, 85, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8546), false, false, 2 },
                    { 86, 86, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8550), false, false, 1 },
                    { 87, 87, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8559), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8559), false, false, 2 },
                    { 88, 88, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8562), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8563), false, false, 1 },
                    { 89, 89, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8566), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8567), false, false, 2 },
                    { 90, 90, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8570), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8571), false, false, 1 },
                    { 91, 91, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8574), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8574), false, false, 2 },
                    { 92, 92, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8578), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8578), false, false, 1 },
                    { 93, 93, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8582), false, false, 2 },
                    { 94, 94, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8586), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8586), false, false, 1 },
                    { 95, 95, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8590), false, false, 2 },
                    { 96, 96, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8594), false, false, 1 },
                    { 97, 97, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8597), false, false, 2 },
                    { 98, 98, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8601), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8601), false, false, 1 },
                    { 99, 99, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8604), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8605), false, false, 2 },
                    { 100, 100, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8608), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8609), false, false, 1 },
                    { 101, 101, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8612), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8613), false, false, 2 },
                    { 102, 102, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8616), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8616), false, false, 1 },
                    { 103, 103, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8620), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8620), false, false, 2 },
                    { 104, 104, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8624), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8624), false, false, 1 },
                    { 105, 105, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8627), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8628), false, false, 2 },
                    { 106, 106, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8631), false, false, 1 },
                    { 107, 107, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8635), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8635), false, false, 2 },
                    { 108, 108, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8639), false, false, 1 },
                    { 109, 109, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8643), false, false, 2 },
                    { 110, 110, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8647), false, false, 1 },
                    { 111, 111, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8650), false, false, 2 },
                    { 112, 112, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8654), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8654), false, false, 1 },
                    { 113, 113, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8658), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8658), false, false, 2 },
                    { 114, 114, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8661), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8662), false, false, 1 },
                    { 115, 115, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8672), false, false, 2 },
                    { 116, 116, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8676), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8676), false, false, 1 },
                    { 117, 117, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8679), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8680), false, false, 2 },
                    { 118, 118, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8683), false, false, 1 },
                    { 119, 119, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8687), false, false, 2 },
                    { 120, 120, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8690), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8691), false, false, 1 },
                    { 121, 121, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8694), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8695), false, false, 2 },
                    { 122, 122, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8698), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8698), false, false, 1 },
                    { 123, 123, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8702), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8702), false, false, 2 },
                    { 124, 124, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8706), false, false, 1 },
                    { 125, 125, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8710), false, false, 2 },
                    { 126, 126, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8714), false, false, 1 },
                    { 127, 127, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8717), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8717), false, false, 2 },
                    { 128, 128, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8721), false, false, 1 },
                    { 129, 129, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8724), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8725), false, false, 2 },
                    { 130, 130, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8729), false, false, 1 },
                    { 131, 131, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8733), false, false, 2 },
                    { 132, 132, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8737), false, false, 1 },
                    { 133, 133, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8741), false, false, 2 },
                    { 134, 134, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8745), false, false, 1 },
                    { 135, 135, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8754), false, false, 2 },
                    { 136, 136, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8758), false, false, 1 },
                    { 137, 137, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8762), false, false, 2 },
                    { 138, 138, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8765), false, false, 1 },
                    { 139, 139, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8769), false, false, 2 },
                    { 140, 140, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8773), false, false, 1 },
                    { 141, 141, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8777), false, false, 2 },
                    { 142, 142, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8780), false, false, 1 },
                    { 143, 143, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8784), false, false, 2 },
                    { 144, 144, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8788), false, false, 1 },
                    { 145, 145, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8792), false, false, 2 },
                    { 146, 146, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8795), false, false, 1 },
                    { 147, 147, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8799), false, false, 2 },
                    { 148, 148, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8803), false, false, 1 },
                    { 149, 149, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8807), false, false, 2 },
                    { 150, 150, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8810), false, false, 1 },
                    { 151, 151, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8814), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8814), false, false, 2 },
                    { 152, 152, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8818), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8818), false, false, 1 },
                    { 153, 153, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8822), false, false, 2 },
                    { 154, 154, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8826), false, false, 1 },
                    { 155, 155, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8829), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8829), false, false, 2 },
                    { 156, 156, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8833), false, false, 1 },
                    { 157, 157, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8837), false, false, 2 },
                    { 158, 158, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8841), false, false, 1 },
                    { 159, 159, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8844), false, false, 2 },
                    { 160, 160, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8848), false, false, 1 },
                    { 161, 161, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8852), false, false, 2 },
                    { 162, 162, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8856), false, false, 1 },
                    { 163, 163, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8866), false, false, 2 },
                    { 164, 164, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8870), false, false, 1 },
                    { 165, 165, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8874), false, false, 2 },
                    { 166, 166, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8877), false, false, 1 },
                    { 167, 167, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8881), false, false, 2 },
                    { 168, 168, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8885), false, false, 1 },
                    { 169, 169, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8889), false, false, 2 },
                    { 170, 170, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8892), false, false, 1 },
                    { 171, 171, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8896), false, false, 2 },
                    { 172, 172, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8900), false, false, 1 },
                    { 173, 173, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8904), false, false, 2 },
                    { 174, 174, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8908), false, false, 1 },
                    { 175, 175, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8912), false, false, 2 },
                    { 176, 176, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8916), false, false, 1 },
                    { 177, 177, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8919), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8919), false, false, 2 },
                    { 178, 178, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8923), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8923), false, false, 1 },
                    { 179, 179, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8927), false, false, 2 },
                    { 180, 180, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8931), false, false, 1 },
                    { 181, 181, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8934), false, false, 2 },
                    { 182, 182, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8938), false, false, 1 },
                    { 183, 183, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8942), false, false, 2 },
                    { 184, 184, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8946), false, false, 1 },
                    { 185, 185, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8950), false, false, 2 },
                    { 186, 186, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8954), false, false, 1 },
                    { 187, 187, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8958), false, false, 2 },
                    { 188, 188, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8962), false, false, 1 },
                    { 189, 189, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8965), false, false, 2 },
                    { 190, 190, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8974), false, false, 1 },
                    { 191, 191, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8978), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8979), false, false, 2 },
                    { 192, 192, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8982), false, false, 1 },
                    { 193, 193, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8986), false, false, 2 },
                    { 194, 194, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8990), false, false, 1 },
                    { 195, 195, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8994), false, false, 2 },
                    { 196, 196, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8998), false, false, 1 },
                    { 197, 197, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9001), false, false, 2 },
                    { 198, 198, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9005), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9005), false, false, 1 },
                    { 199, 199, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9009), false, false, 2 },
                    { 200, 200, false, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9013), false, false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6732), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6732), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6756), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6757), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6764), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6765), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6773), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6779), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6780), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6795), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6796), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6802), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6803), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6809), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6810), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6747), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6758), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6758), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6766), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6766), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6773), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6774), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6781), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6781), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6797), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6803), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6810), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6810), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6748), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6748), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6759), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6767), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6774), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6774), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6782), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6782), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6797), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6797), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6804), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6804), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6811), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6811), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6750), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6760), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6767), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6768), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6775), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6775), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6783), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6783), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6798), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6798), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6805), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6812), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6752), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6752), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6761), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6761), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6769), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6776), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6776), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6784), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6784), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6799), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6806), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6813), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6753), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6754), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6762), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6762), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6770), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6777), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6777), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6792), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6793), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6800), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6800), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6807), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6813), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6814), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6755), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6762), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6763), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6771), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6778), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6793), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6794), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6801), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6808), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6814), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6815), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6755), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6755), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6763), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6764), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6771), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6771), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6778), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6779), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6794), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6795), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6802), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6809), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6815), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6817), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6817), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6822), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6823), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6827), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6827), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6831), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6836), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6840), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6844), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6844), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6849), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6818), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6819), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6823), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6824), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6828), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6828), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6832), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6832), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6836), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6837), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6841), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6841), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6845), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6845), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6850), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6820), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6824), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6824), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6829), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6833), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6838), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6842), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6846), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6846), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6850), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6851), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6820), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6821), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6825), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6825), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6830), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6834), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6838), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6842), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6843), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6847), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6847), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6851), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6851), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6821), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6822), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6826), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6826), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6830), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6830), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6835), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6839), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6839), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6843), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6843), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6848), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6848), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6852), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(6852), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "SaleApprovals",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "SaleId" },
                values: new object[] { 1, new DateTime(2023, 11, 6, 21, 22, 7, 69, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 11, 6, 21, 22, 7, 69, DateTimeKind.Local).AddTicks(5599), false, new Guid("1abb6e28-793d-460f-8a24-745998356da8") });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9027), 11, false, "Consectetur gravida nibh", 1, "e4839b67-392e-4ce8-bf7f-e4fdf52b4f8e" },
                    { 2, 0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9428), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9428), 12, false, "Libero ultricies quam", 1, "db83116f-d488-4484-a91a-76e0047428cd" },
                    { 3, 0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9663), 13, false, "In per mauris", 1, "e9c34795-82e1-4dd1-aef0-bff74fca397a" },
                    { 4, 0, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9847), 14, false, "Tincidunt aptent mauris", 1, "dfa34990-9d0e-4a09-9d04-295211e662ce" },
                    { 5, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(78), 15, false, "Interdum ante ac", 1, "b2138164-035f-4f72-a000-1f49e6d397f3" },
                    { 6, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(288), 16, false, "Orci quisque non", 1, "48b13aa2-af8e-4ca8-8479-fe0d456f25db" },
                    { 7, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(501), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(502), 17, false, "Dolor est etiam", 1, "1f759758-e792-4a4a-8da0-2b9d0164131c" },
                    { 8, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(700), 18, false, "Morbi odio erat", 1, "44ff70f3-0445-4bcd-b17f-98ab9bcfedeb" },
                    { 9, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(921), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(921), 19, false, "Litora nunc ultrices", 1, "9619d1ff-efb9-40d5-ae89-c43ba0ee325a" },
                    { 10, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1119), 20, false, "Nunc vitae scelerisque", 1, "c3681250-4e8c-49ca-8507-2464da24f61f" },
                    { 11, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1335), 21, false, "Erat etiam lectus", 1, "f765bb3b-4e6f-4edf-8a91-04f871c2e9ad" },
                    { 12, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1524), 22, false, "Commodo interdum nibh", 1, "b35b6924-906b-4218-b3d1-5d07acfedab8" },
                    { 13, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1698), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1699), 23, false, "Ultrices ante porta", 1, "25cf08d5-0524-4440-8dbb-cc4774eb6574" },
                    { 14, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1895), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1895), 24, false, "Elit tortor hac", 1, "0a7ce82e-5916-4043-b942-99a88497ee6d" },
                    { 15, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2100), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2100), 25, false, "Purus magna dignissim", 1, "8030c3cf-6eb3-493e-a806-b770ae907257" },
                    { 16, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2333), 26, false, "Nec dui sapien", 1, "24fea1ac-b987-4d10-aebd-6cc4a6469e71" },
                    { 17, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2555), 27, false, "Gravida neque amet", 1, "28cabdb8-10af-47bf-a3c1-a0a7841d52a8" },
                    { 18, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2746), 28, false, "Velit nec euismod", 1, "0cbf1105-2e6e-41ef-9040-e0c32071365a" },
                    { 19, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2977), 29, false, "At proin amet", 1, "6470e530-10d2-4ce9-a405-d58e3860db6f" },
                    { 20, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3176), 30, false, "Lacinia tincidunt habitasse", 1, "23754186-7828-47ee-8f27-04f42d5ce3dd" },
                    { 21, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3380), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3381), 31, false, "Cursus sed congue", 1, "a434a773-07f7-4031-a475-e48f01f62b64" },
                    { 22, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3556), 32, false, "Rutrum dapibus platea", 1, "6409f829-0395-4469-bb50-d1627293ed22" },
                    { 23, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3767), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3768), 33, false, "Ornare massa interdum", 1, "02bdf5f4-31b6-4ba5-bdf6-a2b268bb3804" },
                    { 24, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3943), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3944), 34, false, "Laoreet quam tortor", 1, "b3e9ff64-f96c-4d1c-8eae-8e278b3affc2" },
                    { 25, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4119), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4120), 35, false, "Hac pellentesque posuere", 1, "85d5ab29-7e3c-4792-a6f5-5ba99c3f24cf" },
                    { 26, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4339), 36, false, "Taciti a pellentesque", 1, "2a9bce0f-51e7-464e-b574-1dc86f6d5132" },
                    { 27, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4545), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4545), 37, false, "Quis integer donec", 1, "d64a245a-5e45-4ec1-aebe-5a1c85a9d44f" },
                    { 28, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4771), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4772), 38, false, "Vestibulum magna enim", 1, "35e18f18-5fa3-4a9c-96df-5e336e5f7c34" },
                    { 29, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4980), 39, false, "Primis dui orci", 1, "efe28c9e-a32f-46a4-939d-0727c33c39e6" },
                    { 30, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5182), 40, false, "Lectus volutpat ligula", 1, "98267638-4c69-4ac7-83fc-79540a429146" },
                    { 31, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5397), 41, true, "Bibendum nibh porttitor", 1, "b8271d9a-474b-4535-81a5-859226dd13df" },
                    { 32, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5600), 42, true, "Ad nibh lacinia", 1, "09b4de3d-161e-4c7b-9ac5-b0e3bd16f859" },
                    { 33, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5779), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5779), 43, false, "Mi est class", 1, "a5d51ab9-8eb0-4c59-a1b7-37e926ddac53" },
                    { 34, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5973), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5973), 44, false, "Semper porta nostra", 1, "98e63776-741f-46e5-aa3b-451a8a942c8a" },
                    { 35, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6169), 45, false, "Nam auctor torquent", 1, "8efa38e7-6c32-4678-80d8-f78ef46abbaa" },
                    { 36, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6352), 46, false, "Turpis condimentum praesent", 1, "930160ce-7a6b-4c02-8699-b169f736a624" },
                    { 37, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6536), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6537), 47, false, "Sed eu porta", 1, "429eb9d1-7e8a-4e38-84cf-dcba6b334d4c" },
                    { 38, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6717), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6717), 48, false, "Egestas fringilla magna", 1, "18c7f1ed-161d-492d-9c4e-356a4aa7f962" },
                    { 39, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6924), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6924), 49, false, "Nisl elit sagittis", 1, "68e0fded-13bd-47d5-b0ac-8021b34f91d2" },
                    { 40, 0, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(7130), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(7131), 50, false, "Malesuada blandit purus", 1, "b8d5a44c-e57e-4ba5-8597-cf4b44bbb1b6" }
                });

            migrationBuilder.InsertData(
                table: "TechExecutions",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "IsDeleted", "TechId" },
                values: new object[] { 1, new DateTime(2023, 11, 6, 21, 22, 6, 990, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 11, 6, 21, 22, 6, 990, DateTimeKind.Local).AddTicks(9915), false, new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsDeleted", "ServerId", "Status", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 6, 14, 22, 6, 739, DateTimeKind.Utc).AddTicks(9417), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9415), null, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9416), 4, false, 1, 2, 0 },
                    { 2, new DateTime(2023, 11, 6, 14, 22, 6, 739, DateTimeKind.Utc).AddTicks(9658), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9657), null, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9657), 5, false, 2, 2, 0 },
                    { 3, new DateTime(2023, 11, 6, 14, 22, 6, 739, DateTimeKind.Utc).AddTicks(9842), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9842), null, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(9842), 6, false, 3, 2, 0 },
                    { 4, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(69), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(68), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(69), 7, false, 4, 2, 0 },
                    { 5, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(283), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(282), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(282), 8, false, 5, 2, 0 },
                    { 6, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(497), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(497), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(497), 9, false, 6, 2, 0 },
                    { 7, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(695), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(694), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(695), 10, false, 7, 2, 0 },
                    { 8, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(916), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(917), 11, false, 8, 2, 0 },
                    { 9, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1114), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1114), 12, false, 9, 2, 0 },
                    { 10, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(1331), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1330), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1331), 13, false, 10, 2, 0 },
                    { 11, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1519), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1519), 14, false, 11, 2, 0 },
                    { 12, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(1695), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1694), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1694), 15, false, 12, 2, 0 },
                    { 13, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(1891), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1890), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(1891), 16, false, 13, 2, 0 },
                    { 14, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(2096), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2095), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2096), 17, false, 14, 2, 0 },
                    { 15, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(2324), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2324), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2324), 18, false, 15, 2, 0 },
                    { 16, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(2551), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2550), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2550), 19, false, 16, 2, 0 },
                    { 17, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(2741), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2740), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2740), 20, false, 17, 2, 0 },
                    { 18, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(2973), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2972), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(2972), 21, false, 18, 2, 0 },
                    { 19, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(3172), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3171), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3171), 22, false, 19, 2, 0 },
                    { 20, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3375), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3376), 23, false, 20, 2, 0 },
                    { 21, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(3552), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3551), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3552), 24, false, 21, 2, 0 },
                    { 22, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(3764), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3763), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3763), 25, false, 22, 2, 0 },
                    { 23, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(3940), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3939), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(3939), 26, false, 23, 2, 0 },
                    { 24, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(4116), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4115), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4115), 27, false, 24, 2, 0 },
                    { 25, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(4335), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4334), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4334), 28, false, 25, 2, 0 },
                    { 26, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(4535), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4534), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4534), 29, false, 26, 2, 0 },
                    { 27, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(4767), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4767), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4767), 30, false, 27, 2, 0 },
                    { 28, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(4976), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4975), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(4975), 31, false, 28, 2, 0 },
                    { 29, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(5177), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5177), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5177), 32, false, 29, 2, 0 },
                    { 30, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(5393), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5392), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5392), 33, false, 30, 2, 0 },
                    { 31, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(5596), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5595), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5595), 34, true, 31, 1, 0 },
                    { 32, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(5775), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5774), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5775), 35, true, 32, 1, 0 },
                    { 33, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(5968), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5967), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(5968), 36, false, 33, 2, 0 },
                    { 34, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(6164), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6164), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6164), 37, false, 34, 2, 0 },
                    { 35, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(6348), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6347), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6347), 38, false, 35, 2, 0 },
                    { 36, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(6532), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6532), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6532), 39, false, 36, 2, 0 },
                    { 37, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(6713), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6712), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6712), 40, false, 37, 2, 0 },
                    { 38, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6919), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(6919), 41, false, 38, 2, 0 },
                    { 39, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(7127), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(7126), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(7126), 42, false, 39, 2, 0 },
                    { 40, new DateTime(2023, 11, 6, 14, 22, 6, 740, DateTimeKind.Utc).AddTicks(7341), new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(7340), null, new DateTime(2023, 11, 6, 21, 22, 6, 740, DateTimeKind.Local).AddTicks(7340), 43, false, 40, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7897), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7897), 1, false, 1, 17 },
                    { 2, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7910), 2, false, 2, 29 },
                    { 3, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7915), 3, false, 3, 18 },
                    { 4, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7920), 4, false, 4, 27 },
                    { 5, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7925), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7925), 5, false, 5, 28 },
                    { 6, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7930), 6, false, 6, 2 },
                    { 7, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7935), 7, false, 7, 22 },
                    { 8, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7940), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7940), 8, false, 8, 2 },
                    { 9, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7945), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7945), 9, false, 9, 7 },
                    { 10, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7950), 10, false, 10, 21 },
                    { 11, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7955), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7955), 11, false, 11, 5 },
                    { 12, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7960), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7960), 12, false, 12, 25 },
                    { 13, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7965), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7965), 13, false, 13, 5 },
                    { 14, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7970), 14, false, 14, 7 },
                    { 15, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7982), 15, false, 15, 10 },
                    { 16, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7987), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7987), 16, false, 16, 11 },
                    { 17, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7992), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7992), 17, false, 17, 25 },
                    { 18, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7997), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(7998), 18, false, 18, 25 },
                    { 19, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8002), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8003), 19, false, 19, 27 },
                    { 20, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8007), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8008), 20, false, 20, 28 },
                    { 21, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8012), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8012), 21, false, 21, 6 },
                    { 22, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8017), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8017), 22, false, 22, 10 },
                    { 23, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8021), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8022), 23, false, 23, 7 },
                    { 24, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8026), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8026), 24, false, 24, 10 },
                    { 25, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8031), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8031), 25, false, 25, 3 },
                    { 26, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8035), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8036), 26, false, 26, 29 },
                    { 27, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8040), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8040), 27, false, 27, 26 },
                    { 28, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8045), 28, false, 28, 21 },
                    { 29, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8049), 29, false, 29, 17 },
                    { 30, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8054), 30, false, 30, 18 },
                    { 31, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8059), 31, false, 31, 12 },
                    { 32, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8064), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8064), 32, false, 32, 3 },
                    { 33, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8069), 33, false, 33, 6 },
                    { 34, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8074), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8074), 34, false, 34, 15 },
                    { 35, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8079), 35, false, 35, 24 },
                    { 36, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8086), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8087), 36, false, 36, 12 },
                    { 37, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8091), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8092), 37, false, 37, 27 },
                    { 38, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8102), 38, false, 38, 27 },
                    { 39, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8106), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8107), 39, false, 39, 10 },
                    { 40, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8111), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8111), 40, false, 40, 14 },
                    { 41, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8116), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8116), 41, false, 41, 13 },
                    { 42, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8120), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8121), 42, false, 42, 28 },
                    { 43, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8125), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8125), 43, false, 43, 24 },
                    { 44, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8130), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8130), 44, false, 44, 13 },
                    { 45, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8134), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8135), 45, false, 45, 10 },
                    { 46, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8139), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8139), 46, false, 46, 6 },
                    { 47, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8144), 47, false, 47, 25 },
                    { 48, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8148), 48, false, 48, 2 },
                    { 49, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8153), 49, false, 49, 12 },
                    { 50, new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8157), new DateTime(2023, 11, 6, 21, 22, 6, 739, DateTimeKind.Local).AddTicks(8158), 50, false, 50, 7 }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "SaleApprovalId", "ServerId", "Status", "TechExecutionId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 4, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 12, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(3649), new DateTime(2026, 11, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(3661), new DateTime(2023, 11, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(2838), 5, new DateTime(2024, 11, 6, 21, 22, 7, 295, DateTimeKind.Local).AddTicks(3659), null, null, false, "A, maecenas pulvinar, enim dolor neque, vivamus ligula primis orci egestas id diam velit fermentum sapien commodo tincidunt pharetra mi. Volutpat commodo, lacinia class vehicula sem pulvinar, habitasse vestibulum, etiam enim, leo elit, porttitor, vulputate egestas eros ipsum nunc venenatis. Non, etiam auctor taciti ut tempor vulputate eu, integer sociosqu consectetur ipsum velit leo, mollis metus auctor, nulla, ligula vitae.", null, null, null, 0, null },
                    { 2, 3, new DateTime(2024, 3, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 1, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(5544), new DateTime(2024, 11, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 11, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(4248), 5, new DateTime(2025, 11, 6, 21, 22, 7, 380, DateTimeKind.Local).AddTicks(5562), null, null, false, "Et fermentum ac lectus, taciti at hac lacus id, odio rhoncus dignissim nulla semper malesuada sodales mi, diam integer tellus. Massa molestie arcu sociosqu vestibulum eu bibendum sit orci tellus magna, finibus auctor id, placerat, varius, eget imperdiet eleifend, ligula. Vitae, ac, nulla amet egestas dui, nunc, auctor, vestibulum, arcu neque, blandit, mi, blandit cras vitae erat ipsum nibh, dolor.", null, null, null, 0, null },
                    { 3, 4, new DateTime(2024, 5, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(4361), new DateTime(2023, 10, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(4340), new DateTime(2025, 11, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(4367), new DateTime(2023, 11, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(3318), 5, new DateTime(2025, 11, 6, 21, 22, 7, 488, DateTimeKind.Local).AddTicks(4365), null, null, false, "Auctor phasellus non, duis quis, proin orci, et, cras nunc amet semper laoreet, faucibus nec lectus elit, massa mattis vehicula. Commodo, ex quam eu, dui cras faucibus consectetur bibendum interdum, ultrices orci, quis, integer fringilla, metus at, facilisis sed, vestibulum. Tortor scelerisque per morbi libero viverra finibus fusce fermentum quis, primis nibh eros posuere, pulvinar sed, duis inceptos eleifend, vitae.", null, null, null, 0, null },
                    { 4, 5, new DateTime(2024, 4, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(7401), new DateTime(2023, 10, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(7393), new DateTime(2024, 11, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(7406), new DateTime(2023, 11, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(6689), 5, new DateTime(2024, 11, 6, 21, 22, 7, 582, DateTimeKind.Local).AddTicks(7404), null, null, false, "Aenean suscipit vehicula nostra, sem consequat mauris, tincidunt vulputate tempus ornare nisi dignissim sodales quisque at etiam molestie mi, est. Arcu a eros, lorem, fringilla, eros ligula, congue, laoreet lobortis volutpat, ipsum rutrum nunc, odio suscipit conubia nisi semper ultrices. Accumsan nec, torquent eleifend, nunc, nunc tellus, fermentum tristique vel hac primis faucibus lorem, elit, ultrices elit proin vehicula amet.", null, null, null, 0, null },
                    { 5, 6, new DateTime(2024, 2, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 9, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(4523), new DateTime(2024, 11, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(4535), new DateTime(2023, 11, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(3612), 5, new DateTime(2025, 11, 6, 21, 22, 7, 682, DateTimeKind.Local).AddTicks(4533), null, null, false, "Quis lectus, integer nulla curabitur amet sem, nunc mattis, ultrices in non ad tellus massa tortor est morbi quam, magna. Scelerisque tellus posuere fames dictumst et, leo consequat aptent gravida curabitur ligula maximus arcu hac a ultrices vitae, class pulvinar. Neque, est sapien laoreet, turpis aliquam tempus mattis, sem, at nisi conubia accumsan interdum varius auctor, sed feugiat, eget massa.", null, null, null, 0, null },
                    { 6, 7, new DateTime(2024, 2, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 9, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(1557), new DateTime(2024, 11, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(1567), new DateTime(2023, 11, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(758), 5, new DateTime(2024, 11, 6, 21, 22, 7, 765, DateTimeKind.Local).AddTicks(1565), null, null, false, "Efficitur viverra nulla, massa finibus, non semper tellus ultrices justo amet, ac, faucibus tellus, lacus tincidunt risus vestibulum, vestibulum quam. Semper sociosqu massa odio ligula, pharetra auctor mi, metus eleifend aptent lectus scelerisque accumsan odio, nunc, vivamus pellentesque orci, varius. Amet sollicitudin eros curabitur mi, convallis ipsum bibendum volutpat urna rhoncus sociosqu faucibus lorem, neque, porta, vel, vitae enim justo.", null, null, null, 1, null },
                    { 7, 8, new DateTime(2024, 6, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(2919), new DateTime(2023, 8, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 11, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(2927), new DateTime(2023, 11, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(1695), 5, new DateTime(2024, 11, 6, 21, 22, 7, 842, DateTimeKind.Local).AddTicks(2923), null, null, false, "Imperdiet velit sit convallis risus at luctus leo maximus quisque congue a, per eros, posuere duis amet, bibendum, massa mauris. Euismod, massa, nec, mi feugiat, nibh, varius, nunc molestie litora dapibus nam a, quisque quam sed, hendrerit maximus odio sem. Rutrum sagittis ut nam pellentesque ex dapibus adipiscing tempus blandit orci taciti sollicitudin ipsum fringilla elit, sagittis, bibendum quisque a.", null, null, null, 1, null },
                    { 8, 9, new DateTime(2023, 12, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 12, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(8926), new DateTime(2026, 11, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 11, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(8108), 5, new DateTime(2026, 11, 6, 21, 22, 7, 912, DateTimeKind.Local).AddTicks(8933), null, null, false, "Dictum mi, in cursus dolor sagittis, massa feugiat, nulla auctor torquent ac enim felis venenatis egestas quis, praesent non, blandit. Egestas tempor cras per morbi aliquet ex vitae pulvinar congue auctor enim, quam tempus donec volutpat dictum urna nunc, rutrum. Cras vulputate venenatis pulvinar, tincidunt laoreet, non, elit, a, ac semper turpis mattis fringilla aenean mi eleifend dictumst at proin.", null, null, null, 1, null },
                    { 9, 10, new DateTime(2024, 6, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(7179), new DateTime(2023, 9, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(7175), new DateTime(2026, 11, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(7184), new DateTime(2023, 11, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(6371), 5, new DateTime(2026, 11, 6, 21, 22, 7, 982, DateTimeKind.Local).AddTicks(7182), null, null, false, "Fermentum orci lorem, laoreet, laoreet mollis fames turpis aptent sem etiam massa, arcu, vehicula interdum, venenatis ligula, vivamus et massa. Inceptos molestie risus mollis arcu vehicula tortor, vel sagittis ultricies aenean a, magna urna sapien varius hac dapibus in arcu. Venenatis orci, nulla eleifend, aptent sem urna dolor, sodales dapibus consectetur lacinia commodo, etiam mauris, interdum, posuere praesent eget urna.", null, null, null, 1, null },
                    { 10, 11, new DateTime(2024, 5, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 11, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 11, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(2222), new DateTime(2023, 11, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(1084), 5, new DateTime(2024, 11, 6, 21, 22, 8, 120, DateTimeKind.Local).AddTicks(2220), null, null, false, "Ullamcorper ex, accumsan rutrum bibendum tincidunt lacinia, eros diam ligula, vehicula efficitur mattis, sem pellentesque finibus nibh hendrerit primis id. Mauris at volutpat dictumst congue, dictum hac duis porta, accumsan magna, efficitur enim a eleifend scelerisque ante, etiam sem sagittis. Blandit, habitasse nec enim, laoreet torquent laoreet, litora nunc placerat, vestibulum non amet, cursus metus amet egestas ultricies aenean convallis.", null, null, null, 1, null },
                    { 11, 12, new DateTime(2023, 11, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(9047), new DateTime(2024, 1, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(9042), new DateTime(2026, 11, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 11, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(8224), 5, new DateTime(2026, 11, 6, 21, 22, 8, 215, DateTimeKind.Local).AddTicks(9050), null, null, false, "Risus mattis in consectetur dolor, nec, fermentum commodo, a, elit, maecenas sociosqu vel, cursus, id venenatis efficitur massa interdum, etiam. Quis finibus quam ad risus nec neque, vitae, pulvinar sit massa nisi, at, eleifend cursus, lacinia, accumsan lobortis mi, a. Dolor, eleifend, fringilla, aliquam et, semper fusce torquent viverra erat molestie etiam eget pretium urna magna tellus duis sodales euismod.", null, 1, 1, 2, null },
                    { 12, 13, new DateTime(2024, 5, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(5261), new DateTime(2023, 9, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 11, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(5267), new DateTime(2023, 11, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(4091), 5, new DateTime(2025, 11, 6, 21, 22, 8, 285, DateTimeKind.Local).AddTicks(5265), null, null, false, "Rhoncus nisi, fringilla rutrum urna, eros sagittis adipiscing ad ex interdum, euismod, in, sollicitudin nibh scelerisque eros, sodales at, lacinia. Tortor, et non viverra accumsan placerat, feugiat tempor, ultricies vivamus etiam amet, adipiscing laoreet, mi, imperdiet conubia magna, commodo, dolor. Rhoncus iaculis tempus in maximus vestibulum, leo magna auctor, eget malesuada ante, justo quis, mattis, auctor venenatis tempor, id suspendisse.", null, 1, 2, 2, null },
                    { 13, 14, new DateTime(2023, 12, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(6118), new DateTime(2023, 11, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 11, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(6122), new DateTime(2023, 11, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(5295), 5, new DateTime(2026, 11, 6, 21, 22, 8, 354, DateTimeKind.Local).AddTicks(6120), null, null, false, "Orci eleifend ante sodales augue volutpat congue erat, eu nisl at tellus, ac, nulla varius nulla, dictum volutpat, odio odio. Bibendum inceptos imperdiet mi, blandit, vitae mattis nec, laoreet, risus blandit id, nisl nulla, pellentesque euismod, id nullam aptent rhoncus. Habitasse sapien accumsan congue, phasellus nostra, lacinia vestibulum, tempor, enim ultrices, iaculis inceptos nunc, mi, gravida et dignissim pulvinar luctus.", null, 1, 3, 2, null },
                    { 14, 15, new DateTime(2024, 3, 6, 21, 22, 8, 424, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 2, 6, 21, 22, 8, 424, DateTimeKind.Local).AddTicks(1372), new DateTime(2026, 11, 6, 21, 22, 8, 424, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 11, 6, 21, 22, 8, 423, DateTimeKind.Local).AddTicks(9980), 5, new DateTime(2024, 11, 6, 21, 22, 8, 424, DateTimeKind.Local).AddTicks(1383), null, null, false, "Lorem, ornare tempor neque, venenatis commodo, nec condimentum elit, ac, mi eleifend, efficitur eu, blandit litora nunc, placerat, scelerisque pulvinar. Sit aenean aliquam dictum eleifend nunc faucibus non, arcu, nulla volutpat, suscipit justo quam fringilla finibus, mauris, consequat nulla, magna. Nulla et fusce sit semper quisque ac, feugiat nisl in, gravida adipiscing condimentum ad molestie varius, tristique commodo ante himenaeos.", null, 1, 4, 2, null },
                    { 15, 16, new DateTime(2024, 2, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 9, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(5275), new DateTime(2025, 11, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(5293), new DateTime(2023, 11, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(3728), 5, new DateTime(2024, 11, 6, 21, 22, 8, 501, DateTimeKind.Local).AddTicks(5290), null, null, false, "Donec non laoreet, tellus, venenatis posuere, placerat habitasse efficitur quam, fermentum elit magna, luctus nisi, at rutrum euismod sociosqu elementum. Sodales semper pharetra porttitor, urna, tristique rutrum placerat, laoreet morbi praesent nisl ante, lectus mollis accumsan placerat sollicitudin proin himenaeos. Ullamcorper accumsan nulla venenatis nunc, ad a, interdum, elit, blandit pretium laoreet, fermentum nisi, conubia at, varius phasellus nec nec.", null, 1, 5, 2, null },
                    { 16, 20, new DateTime(2024, 3, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(9381), new DateTime(2023, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(9373), new DateTime(2026, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(9386), new DateTime(2023, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(8070), 5, new DateTime(2024, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(9384), null, null, false, "Justo venenatis feugiat duis maecenas ullamcorper pulvinar, at, sagittis porta, hendrerit massa, eu, posuere condimentum vulputate massa amet eu commodo. Amet, nibh, enim, ornare mauris accumsan rhoncus, nisl aliquam purus fermentum lacus neque, eleifend, et, efficitur mollis mi pulvinar dapibus. Magna sapien nulla, lacinia, luctus eu quis platea dapibus ac, vulputate sed, rutrum integer volutpat class cursus euismod ad primis.", null, 1, 6, 4, 1 },
                    { 17, 19, new DateTime(2024, 1, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 1, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(308), new DateTime(2025, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 11, 6, 21, 22, 8, 590, DateTimeKind.Local).AddTicks(9425), 5, new DateTime(2026, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(314), null, null, false, "Orci enim, sit finibus ligula, curabitur scelerisque auctor tortor, laoreet, himenaeos sed, leo per dictum elit ex a accumsan lacinia. Lobortis nec sollicitudin leo, neque, laoreet libero imperdiet bibendum aptent suspendisse vulputate dignissim etiam donec consequat ligula egestas quis, augue. Eros quam porttitor fringilla lacinia malesuada lectus cras posuere massa, felis enim, justo tortor rutrum nisi arcu, vulputate placerat, massa.", null, 1, 7, 4, 1 },
                    { 18, 16, new DateTime(2023, 12, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 1, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(1314), new DateTime(2026, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(352), 5, new DateTime(2025, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(1321), null, null, false, "Congue suspendisse maximus venenatis est vestibulum eu, habitasse tortor, mi, placerat ultrices pretium nec, arcu luctus, mauris semper nostra, sagittis. Ultrices ligula nunc aenean enim, mi, ex cras nam quis, tortor pretium platea ac nibh dui, tempor odio, at, euismod. Cursus, massa nostra, enim dui congue augue nam quis ex ante curabitur tempor, mauris, luctus pulvinar odio luctus, nulla amet.", null, 1, 8, 4, 1 },
                    { 19, 18, new DateTime(2024, 1, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 9, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(2194), new DateTime(2026, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(1373), 5, new DateTime(2024, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(2203), null, null, false, "Taciti cras conubia ultricies nibh proin maximus eu lacinia, et, volutpat elit, rhoncus dui aptent bibendum, blandit, urna, cursus, porttitor. Aenean tellus finibus, id, massa, morbi commodo eu fusce nulla, imperdiet nunc, nec, vestibulum, eleifend at cras leo mi, nibh. Elit, pellentesque lacinia elementum cursus, donec sodales mattis maximus aliquet bibendum, hac ante vestibulum, commodo, placerat sagittis sed finibus sapien.", null, 1, 9, 4, 1 },
                    { 20, 18, new DateTime(2024, 2, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(3543), new DateTime(2023, 9, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(3537), new DateTime(2026, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(3549), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(2257), 5, new DateTime(2024, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(3546), null, null, false, "Sem varius arcu quam dolor, pharetra enim, pulvinar sapien facilisis dictum fusce sem, nulla ex bibendum, primis auctor interdum, adipiscing. Hac pharetra placerat, nibh, leo, ornare phasellus nisi risus non suspendisse volutpat ac aenean accumsan at, pulvinar lectus, nisi, malesuada. Eleifend, sociosqu quis commodo pulvinar lacinia malesuada sodales nullam mauris porta, nam sem, arcu, euismod, felis posuere, praesent maximus aliquam.", null, 1, 10, 4, 1 },
                    { 21, 17, new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 9, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(4590), new DateTime(2026, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(3624), 5, new DateTime(2025, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(4599), null, null, false, "Lorem pellentesque torquent eros praesent a odio, justo eleifend amet tempor suspendisse urna velit hendrerit class duis etiam risus diam. Tempus nisi, placerat, blandit, in, viverra condimentum vulputate ipsum donec at neque, laoreet mattis lorem eleifend, adipiscing magna, lobortis est. Et, hac tempor vel, erat neque, tellus, phasellus proin nam nibh lacinia maximus tincidunt imperdiet pellentesque fusce ac eleifend feugiat.", null, 1, 11, 4, 1 },
                    { 22, 20, new DateTime(2024, 1, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(5920), new DateTime(2025, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(4645), 5, new DateTime(2025, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(5931), null, null, false, "Consectetur rhoncus, conubia nisi laoreet, sodales tellus neque placerat lorem scelerisque dignissim blandit, vehicula per gravida mollis ex himenaeos lorem. Eget porta sem class lectus tempor curabitur integer maximus congue, risus duis ex finibus luctus justo faucibus ligula, elit, tempus. Quam vestibulum leo congue, mi eu, interdum, taciti mollis metus libero in tempor donec efficitur quis justo nullam mauris in.", null, 1, 12, 4, 1 },
                    { 23, 20, new DateTime(2024, 2, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(8066), new DateTime(2024, 2, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(8057), new DateTime(2026, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(5995), 5, new DateTime(2024, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(8069), null, null, false, "Nunc, donec sociosqu commodo sapien ullamcorper sit lacinia arcu consequat tempus luctus maximus diam blandit sagittis, in, dolor, iaculis velit. Nisi, neque metus tincidunt fermentum adipiscing faucibus orci, finibus tempor, id, ac, euismod, donec tortor, efficitur at imperdiet ut pharetra. Taciti feugiat, ultricies a, id bibendum convallis nunc consequat dignissim ex justo in, finibus tempor cursus, ultrices lobortis congue nulla.", null, 1, 13, 4, 1 },
                    { 24, 18, new DateTime(2024, 2, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 2, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(9895), new DateTime(2024, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(9904), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(8156), 5, new DateTime(2025, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(9901), null, null, false, "Porta neque inceptos porta, malesuada vehicula maecenas mi nostra, suspendisse feugiat bibendum, posuere, fringilla enim, nisl massa, aenean dictumst non. Rutrum lobortis fusce lorem, mauris, laoreet sagittis, orci, aliquet diam tellus finibus, justo tempor nibh facilisis iaculis felis condimentum vel. Rutrum et molestie dolor, diam in fringilla, rhoncus, nisi tempus per porta, laoreet, fringilla facilisis risus fermentum taciti vel, quam.", null, 1, 14, 4, 1 },
                    { 25, 20, new DateTime(2024, 3, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 2, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(1072), new DateTime(2023, 11, 6, 21, 22, 8, 591, DateTimeKind.Local).AddTicks(9951), 5, new DateTime(2025, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(1070), null, null, false, "Proin taciti convallis varius fermentum interdum, tellus, commodo integer pretium aliquam efficitur eros, bibendum, dolor ipsum sociosqu mi volutpat, nibh. A pharetra in porta placerat, rhoncus felis ornare mattis proin sed, molestie elit id, nam et, convallis aliquam pellentesque maecenas. Eget ullamcorper adipiscing porta, placerat, auctor, ac a, tristique magna, mollis dolor, neque lectus curabitur hac magna in, semper posuere.", null, 1, 15, 4, 1 },
                    { 26, 19, new DateTime(2024, 2, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 12, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(1098), 5, new DateTime(2026, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(2165), null, null, false, "Nec ad massa, gravida mollis eleifend pharetra accumsan fringilla, in, convallis sed volutpat sit consequat in dapibus ipsum elit rhoncus. Id, quisque augue est lectus, lorem congue, bibendum non rutrum sem, quis interdum, dapibus nisi, libero odio, vel semper sem. Augue arcu molestie ullamcorper laoreet, accumsan luctus, lacinia aliquam in adipiscing egestas non arcu, interdum, placerat, ad lacus amet, sagittis.", null, 1, 16, 4, 1 },
                    { 27, 16, new DateTime(2024, 5, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 12, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(3598), new DateTime(2026, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(2202), 5, new DateTime(2026, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(3611), null, null, false, "Bibendum, scelerisque mi metus eu ad odio, feugiat lectus blandit, quis nam ligula mattis, ligula, vivamus phasellus velit a, imperdiet. Porttitor pretium quam, imperdiet id turpis amet leo eu, eu molestie elit per interdum, justo eget inceptos proin lectus urna. Dolor, odio mauris, sem, erat, viverra himenaeos fermentum nisi, arcu, velit vitae, et, consequat leo, vel, etiam mi cursus, neque.", null, 1, 17, 4, 1 },
                    { 28, 18, new DateTime(2024, 3, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 9, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(5219), new DateTime(2025, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(3707), 5, new DateTime(2024, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(5225), null, null, false, "Amet gravida lorem ut pulvinar, euismod egestas posuere, vestibulum hac turpis enim varius odio diam litora nullam imperdiet bibendum, volutpat. Nostra, imperdiet vivamus ac donec vitae rhoncus quisque bibendum lectus, suscipit cursus fringilla, platea dolor eros aenean bibendum, nec varius. Eu, tempor, viverra efficitur morbi nulla proin convallis at, risus ac, dui vehicula fusce per nostra, quis taciti aliquam metus.", null, 1, 18, 4, 1 },
                    { 29, 20, new DateTime(2024, 6, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 2, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6089), new DateTime(2026, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6094), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(5261), 5, new DateTime(2024, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6092), null, null, false, "Ornare integer inceptos ipsum tortor fringilla quis nisi suspendisse pharetra varius quis, eleifend, lacinia, mollis phasellus orci, ligula felis aptent. Lacinia volutpat proin aenean molestie porta cras urna, sapien sollicitudin lorem, primis elementum accumsan quis sed, sodales id, blandit phasellus. Pellentesque lectus vitae, dui, per semper litora enim, dictumst et nostra, blandit, sed cursus fringilla, arcu, leo, lorem at, augue.", null, 1, 19, 4, 1 },
                    { 30, 17, new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6971), new DateTime(2023, 10, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6973), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6109), 5, new DateTime(2025, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6972), null, null, false, "Iaculis at, dictum nec aliquet varius, pulvinar, tempor conubia maximus semper commodo ac, vel, ad consectetur vestibulum, leo bibendum luctus. Pulvinar praesent lacinia pretium dui non efficitur venenatis mattis quam, vehicula ante, cursus accumsan nostra, vel, fermentum laoreet, turpis quisque. Commodo diam odio himenaeos tincidunt conubia consequat augue in tristique phasellus primis pharetra lectus ante morbi nulla, laoreet, platea euismod.", null, 1, 20, 4, 1 },
                    { 31, 16, new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(8179), new DateTime(2024, 1, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(8185), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(6991), 5, new DateTime(2026, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(8182), null, null, false, "Odio bibendum facilisis nisl aliquet nisi leo, massa, commodo, quam luctus nibh dignissim cursus, faucibus diam lectus, dictum lacinia ultrices. Dui ipsum a, egestas lobortis nibh, dui, purus torquent sodales venenatis at, justo nunc, odio, quam pulvinar phasellus iaculis eros. Placerat, tortor, ad orci, elit inceptos dapibus metus diam quam, mattis, tempus eros interdum risus fringilla ante nec lacinia feugiat.", null, 1, 21, 4, 1 },
                    { 32, 20, new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(9552), new DateTime(2023, 8, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(9536), new DateTime(2026, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(9558), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(8246), 5, new DateTime(2025, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(9554), null, null, false, "Sodales sed convallis aenean odio scelerisque magna mattis dolor, varius aliquet quam leo morbi feugiat cursus ante, integer nibh non. Feugiat arcu purus id, porta eget fermentum litora dui duis placerat, quis porttitor etiam suspendisse posuere, neque, per nisi, tempor. Auctor, non, malesuada porta, libero elit, ultricies nec, convallis posuere, et sollicitudin fringilla, lorem at, tortor, magna pharetra neque, nulla.", null, 1, 22, 4, 1 },
                    { 33, 16, new DateTime(2024, 6, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 9, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(677), new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 11, 6, 21, 22, 8, 592, DateTimeKind.Local).AddTicks(9629), 5, new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(682), null, null, false, "Platea scelerisque quisque vitae, ante, nostra, hendrerit laoreet primis enim aptent facilisis morbi blandit, adipiscing vel, leo, pulvinar, molestie eu. Odio, pellentesque velit rhoncus, ex tellus porta, finibus, placerat, pharetra amet, feugiat, dui urna, ante conubia at fringilla erat odio. Nibh habitasse magna, risus proin dignissim adipiscing lorem, auctor, ipsum fringilla duis egestas mauris nisi, ac, orci placerat mollis placerat.", null, 1, 23, 4, 1 },
                    { 34, 20, new DateTime(2024, 2, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(1899), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(1895), new DateTime(2024, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(1902), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(725), 5, new DateTime(2025, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(1900), null, null, false, "Risus ullamcorper vel pretium lorem mauris, eros, himenaeos sagittis, aenean sem neque, primis commodo, vestibulum venenatis ex nunc, quis sollicitudin. Amet feugiat quis, ac vehicula arcu himenaeos ex, lorem mollis pretium enim laoreet nullam nec eleifend tellus, elit, lacinia, auctor. Eleifend, non, lorem purus laoreet, varius congue, elit pretium odio tempor id tellus sem nibh, vitae, platea auctor ligula vitae.", null, 1, 24, 4, 1 },
                    { 35, 17, new DateTime(2024, 4, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(3279), new DateTime(2023, 9, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(3269), new DateTime(2024, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(1958), 5, new DateTime(2025, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(3280), null, null, false, "Ante neque, volutpat, fames fringilla, sed, aliquet quisque arcu, nisi erat elit elit, litora urna accumsan malesuada luctus vestibulum odio. Aenean vel tempor lacinia phasellus nibh, mi, sociosqu nulla primis quis lorem, ligula, in etiam conubia tellus ipsum lectus, erat. Neque, tortor, malesuada congue, habitasse convallis nunc, tempor integer quis, suspendisse purus scelerisque tempor, non dictumst ultrices rhoncus nostra, mauris.", null, 1, 25, 4, 1 },
                    { 36, 19, new DateTime(2024, 5, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(5569), new DateTime(2023, 10, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(5534), new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(3332), 5, new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(5571), null, null, false, "Vulputate finibus blandit fames purus amet, hac molestie arcu, nulla, neque eros rutrum mi a primis interdum, etiam feugiat leo. Neque, nec fusce massa, eget ornare justo nunc, quam pretium dolor quis rutrum interdum eleifend efficitur id nulla nunc leo. Primis ut cursus elit iaculis risus ac ultrices semper conubia gravida fringilla, integer luctus orci nec, habitasse ante, per lacinia.", null, 1, 26, 4, 1 },
                    { 37, 16, new DateTime(2024, 6, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 1, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(7116), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(5844), 5, new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(7113), null, null, false, "Porttitor, tincidunt justo lectus, nulla, ante, tortor, nam facilisis tellus nunc porttitor quisque vel euismod dapibus congue ac, erat elementum. Phasellus conubia inceptos volutpat, lorem, vel risus nulla, tempor sollicitudin nibh neque enim porttitor, ipsum aenean eleifend, viverra tortor congue. Dapibus sed porta lacinia, vivamus quisque nisi, sagittis vulputate est semper eros, vel nunc vel, amet, in, suscipit torquent maecenas.", null, 1, 27, 4, 1 },
                    { 38, 20, new DateTime(2024, 3, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8013), new DateTime(2023, 9, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8011), new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8016), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(7154), 5, new DateTime(2024, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8014), null, null, false, "Eros non, rhoncus elit erat auctor, tempor, morbi litora luctus sagittis, viverra laoreet amet, non ad arcu, tortor, nec donec. Nibh, ornare dolor, eros, id, lacinia curabitur lorem nunc, neque, gravida vel finibus ultricies massa, libero nec varius morbi volutpat. Mi, pulvinar in, nunc viverra venenatis nisi, arcu inceptos nibh praesent varius, pellentesque ad sem proin iaculis luctus, turpis urna.", null, 1, 28, 4, 1 },
                    { 39, 20, new DateTime(2024, 5, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 9, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8884), new DateTime(2025, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8088), 5, new DateTime(2025, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8888), null, null, false, "Id bibendum vulputate maecenas faucibus orci non, posuere, nostra, lobortis nullam in dui rhoncus, elit porttitor, finibus eget non urna. Vehicula tristique vitae, vel ac, orci, fusce malesuada tellus, lectus, mauris cras cursus lobortis sed velit imperdiet blandit urna, rhoncus. Pharetra varius, dolor, sagittis fermentum faucibus sodales tristique adipiscing scelerisque cras dictumst sed, erat arcu non, dolor quam bibendum mi.", null, 1, 29, 4, 1 },
                    { 40, 18, new DateTime(2023, 12, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 10, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(8903), 5, new DateTime(2026, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(9837), null, null, false, "Pulvinar, tortor eros erat, facilisis faucibus sit vel, mauris, nisi, magna, egestas curabitur et arcu, sed nostra, purus non, a. Eget litora erat, urna consectetur pellentesque elementum sem, nam adipiscing sagittis, arcu, vel feugiat orci, eros, vulputate metus sagittis massa. Euismod, vehicula orci torquent ornare auctor interdum dui, maximus bibendum, dictum hac mauris gravida integer porttitor, tempor, ac odio dolor.", null, 1, 30, 4, 1 },
                    { 41, 17, new DateTime(2024, 6, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(670), new DateTime(2023, 12, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 11, 6, 21, 22, 8, 593, DateTimeKind.Local).AddTicks(9859), 5, new DateTime(2024, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(672), null, null, false, "Ex, aenean odio, nec, mollis condimentum sapien donec eu eleifend, ad nisi, dolor ultricies quisque posuere facilisis libero volutpat, varius. Feugiat maximus porta at vehicula ac gravida eleifend praesent interdum viverra et auctor, congue sagittis enim tellus, phasellus pulvinar, faucibus. Tempor, neque praesent congue, nibh diam lorem, et dignissim sodales sagittis pharetra class bibendum varius egestas eleifend, orci, porta, mattis.", null, 1, 31, 4, 1 },
                    { 42, 19, new DateTime(2024, 1, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(1816), new DateTime(2024, 1, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(1813), new DateTime(2026, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(689), 5, new DateTime(2025, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(1818), null, null, false, "Sagittis libero ex suspendisse posuere enim etiam dignissim nibh, laoreet, magna ligula, primis sed dictum metus egestas neque, torquent vivamus. Vivamus nec, nam ex, ullamcorper orci consequat lacinia mauris maximus aliquet sem dapibus malesuada nisi, pellentesque laoreet, luctus, volutpat, quis. Neque, nisi porta, aptent purus posuere, eu, nec, elit, aenean sollicitudin eros feugiat, maximus lacinia, interdum integer risus vitae, amet.", null, 1, 32, 4, 1 },
                    { 43, 19, new DateTime(2023, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(3154), new DateTime(2023, 12, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(3150), new DateTime(2025, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(1896), 5, new DateTime(2024, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(3156), null, null, false, "Tempor interdum, orci, cras viverra congue cursus quis quisque velit lobortis quis, auctor eros interdum sed lacinia egestas arcu ante. Ullamcorper quam nisl sagittis, felis mauris lorem sem, condimentum fringilla, vitae, tempor odio nisi, libero donec tempor, ac, torquent mattis. Vitae, rhoncus, praesent amet, ultrices, phasellus in sagittis, nec, ac, integer laoreet ligula, massa, aenean ex lectus auctor habitasse nec.", null, 1, 33, 4, 1 },
                    { 44, 18, new DateTime(2024, 6, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(4452), new DateTime(2023, 8, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(4447), new DateTime(2026, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(4457), new DateTime(2023, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(3212), 5, new DateTime(2025, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(4454), null, null, false, "Augue pulvinar, laoreet luctus porta, commodo, cursus ornare pellentesque platea nostra, condimentum euismod, metus gravida enim, viverra morbi purus odio. Sagittis et aliquam nibh tortor, cras nostra, fermentum laoreet tincidunt ac, commodo, at per platea inceptos fringilla amet, porta non. Scelerisque nisl leo libero blandit, luctus etiam maximus ex ad a, curabitur vestibulum, aenean euismod, varius, auctor eros, eget commodo.", null, 1, 34, 4, 1 },
                    { 45, 17, new DateTime(2024, 1, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(5794), new DateTime(2023, 10, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(5799), new DateTime(2023, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(4491), 5, new DateTime(2024, 11, 6, 21, 22, 8, 594, DateTimeKind.Local).AddTicks(5796), null, null, false, "Nisi commodo non vel, nec, mauris rhoncus, aptent dictum magna tempor, eleifend ex nibh quis, adipiscing himenaeos tortor congue ex. Non, conubia accumsan integer arcu sociosqu orci, ex tortor porta class condimentum non scelerisque urna posuere, inceptos a pretium tempor. Ligula, sollicitudin id, congue posuere, mi tellus blandit, bibendum cursus primis inceptos varius, arcu, mattis, bibendum, nisi adipiscing nulla, enim.", null, 1, 35, 4, 1 },
                    { 46, 22, new DateTime(2024, 5, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 12, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(9767), new DateTime(2025, 11, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 11, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(8434), 5, new DateTime(2024, 11, 6, 21, 22, 9, 9, DateTimeKind.Local).AddTicks(9783), null, null, false, "Cursus commodo, rutrum ligula efficitur urna, porttitor, lacinia, adipiscing consequat litora nunc sollicitudin nisi, vestibulum, massa, vestibulum posuere in, eleifend. Ac curabitur elit, cursus, arcu, nibh quisque ligula, erat, at proin aenean a leo nullam consequat duis luctus quis, luctus. Cursus feugiat maximus vivamus finibus, ex, fusce elit, fringilla nibh scelerisque turpis purus dictumst ante gravida eros, tincidunt aenean sodales.", null, null, 36, 3, null },
                    { 47, 23, new DateTime(2024, 3, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(5983), new DateTime(2023, 11, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 11, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(5987), new DateTime(2023, 11, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(4912), 5, new DateTime(2024, 11, 6, 21, 22, 9, 87, DateTimeKind.Local).AddTicks(5985), null, null, false, "Ante quam, urna, eleifend, amet suspendisse neque donec commodo rutrum ipsum ligula feugiat, cras finibus erat, sed, adipiscing torquent convallis. Nulla pulvinar nec, proin nullam gravida mi ex, lacus lorem, interdum, dictum laoreet commodo, sodales vitae, et, feugiat, massa, condimentum. Quisque nec sem, fermentum sollicitudin taciti auctor erat, sagittis porta porttitor nunc luctus sit fringilla, magna, nam nisi, praesent egestas.", null, null, 37, 3, null },
                    { 48, 24, new DateTime(2021, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(8541), new DateTime(2018, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(8545), new DateTime(2023, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(7651), 5, new DateTime(2023, 11, 6, 21, 22, 9, 172, DateTimeKind.Local).AddTicks(8543), null, null, false, "Platea scelerisque fermentum ut elementum nullam ligula, convallis felis pharetra consequat bibendum nisl lacus quam velit sollicitudin laoreet tortor faucibus. Elit, finibus bibendum, sapien lobortis ultrices ad dapibus lacinia, rhoncus ac, ligula vivamus tempus eros quis leo, ex eleifend, integer. Turpis auctor, mauris sem, sociosqu luctus, eu a nulla, fringilla felis nibh etiam porttitor nisi laoreet phasellus sed, mauris, maecenas.", null, 1, 38, 6, 1 },
                    { 49, 25, new DateTime(2020, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(2469), new DateTime(2019, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(1405), 5, new DateTime(2023, 11, 6, 21, 22, 9, 327, DateTimeKind.Local).AddTicks(2474), null, null, false, "Cursus, integer quam massa, mi, placerat magna, pharetra sagittis iaculis malesuada viverra lectus nam est congue aliquet feugiat, dolor vestibulum. Neque purus amet, donec orci mi, vitae, euismod, maximus mollis aliquet justo platea dui scelerisque orci, dolor inceptos metus class. Vitae enim, praesent placerat tellus, commodo, ante volutpat, sollicitudin metus eu sagittis, finibus, faucibus imperdiet nunc, taciti nec, id in.", null, 1, 39, 6, 1 },
                    { 50, 26, new DateTime(2021, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8864), new DateTime(2019, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8856), new DateTime(2022, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(7145), 5, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8868), null, null, false, "Maximus pellentesque aliquet tortor, mi elit, condimentum tellus, inceptos nunc, vel porta, dui, risus placerat, aptent libero iaculis nisi, quam. Ornare litora lobortis convallis et viverra suscipit lorem ut erat, vulputate eros condimentum volutpat nec, maecenas eleifend sed luctus enim. Purus aenean auctor, vel in lacus metus commodo, pulvinar, turpis dolor, erat, quis, mauris, eros, nulla, varius, vulputate nisl viverra.", null, 1, 40, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "ServiceRequests",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "InspectionRecordFilePath", "IpId", "IsDelegated", "IsDeleted", "Quantity", "RequestId", "SaleApprovalId", "ServiceId", "Status", "TechExecutionId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8956), null, null, false, false, 4, 6, null, 3, 0, null, null, null },
                    { 2, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8979), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8979), null, null, false, false, 2, 6, null, 2, 0, null, null, null },
                    { 3, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8991), null, null, false, false, 3, 7, null, 2, 0, null, null, null },
                    { 4, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9000), null, null, false, false, 2, 7, null, 3, 0, null, null, null },
                    { 5, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9008), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9009), null, null, false, false, 3, 7, null, 1, 0, null, null, null },
                    { 6, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9021), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9021), null, null, false, false, 2, 8, null, 3, 0, null, null, null },
                    { 7, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9030), null, null, false, false, 3, 8, null, 3, 0, null, null, null },
                    { 8, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9039), null, null, false, false, 4, 8, null, 3, 0, null, null, null },
                    { 9, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9049), null, null, false, false, 5, 9, null, 1, 0, null, null, null },
                    { 10, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9058), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9059), null, null, false, false, 4, 9, null, 1, 0, null, null, null },
                    { 11, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9067), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9068), null, null, false, false, 1, 9, null, 2, 0, null, null, null },
                    { 12, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9078), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9078), null, null, false, false, 5, 10, null, 1, 0, null, null, null },
                    { 13, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9087), null, null, false, false, 3, 10, null, 2, 0, null, null, null },
                    { 14, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9101), null, null, false, false, 1, 11, null, 3, 0, null, null, null },
                    { 15, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9254), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9255), null, null, false, false, 1, 11, null, 1, 2, null, null, null },
                    { 16, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9298), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9298), null, null, false, false, 5, 11, null, 1, 2, null, null, null },
                    { 17, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9309), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9309), null, null, false, false, 2, 12, 1, 3, 1, null, null, null },
                    { 18, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9325), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9325), null, null, false, false, 4, 13, null, 2, 0, null, null, null },
                    { 19, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9333), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9334), null, null, false, false, 2, 14, 1, 3, 1, null, null, null },
                    { 20, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9341), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9341), null, null, false, false, 5, 14, 1, 2, 1, null, null, null },
                    { 21, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9349), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9349), null, null, false, false, 5, 15, null, 2, 0, null, null, null },
                    { 22, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9357), null, null, false, false, 2, 15, 1, 2, 1, null, null, null },
                    { 23, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9364), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9364), null, null, false, false, 1, 15, 1, 2, 1, null, null, null },
                    { 24, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9371), null, null, false, false, 4, 15, null, 2, 0, null, null, null },
                    { 25, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9378), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9378), null, null, false, false, 4, 15, null, 1, 2, null, null, null },
                    { 26, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9390), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9391), null, null, false, false, 4, 16, 1, 3, 3, 1, null, null },
                    { 27, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9405), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9405), null, null, false, false, 4, 16, 1, 2, 1, null, null, null },
                    { 28, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9416), null, null, false, false, 4, 16, null, 1, 0, null, null, null },
                    { 29, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9426), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9427), null, null, false, false, 2, 16, null, 3, 0, null, null, null },
                    { 30, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9450), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9451), null, null, false, false, 5, 17, 1, 3, 3, 1, null, null },
                    { 31, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9543), null, null, false, false, 1, 17, 1, 3, 3, 1, null, null },
                    { 32, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9577), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9578), null, null, false, false, 2, 17, 1, 2, 3, 1, null, null },
                    { 33, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9611), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9611), null, null, false, false, 3, 18, 1, 3, 1, null, null, null },
                    { 34, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9627), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9627), null, null, false, false, 5, 19, null, 3, 2, null, null, null },
                    { 35, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9637), null, null, false, false, 1, 19, 1, 1, 3, 1, null, null },
                    { 36, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9647), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9647), null, null, false, false, 4, 19, null, 1, 2, null, null, null },
                    { 37, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9660), null, null, false, false, 3, 20, 1, 2, 3, 1, null, null },
                    { 38, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9685), null, null, false, false, 5, 20, 1, 1, 1, null, null, null },
                    { 39, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9717), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9717), null, null, false, false, 3, 21, 1, 1, 1, null, null, null },
                    { 40, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9747), null, null, false, false, 5, 21, null, 2, 2, null, null, null },
                    { 41, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9768), null, null, false, false, 4, 22, null, 3, 2, null, null, null },
                    { 42, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9811), null, null, false, false, 3, 22, 1, 1, 3, 1, null, null },
                    { 43, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9829), null, null, false, false, 4, 23, null, 2, 0, null, null, null },
                    { 44, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9838), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9838), null, null, false, false, 5, 24, null, 1, 0, null, null, null },
                    { 45, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9846), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9846), null, null, false, false, 5, 24, null, 3, 2, null, null, null },
                    { 46, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9902), null, null, false, false, 5, 24, 1, 3, 3, 1, null, null },
                    { 47, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9912), null, null, false, false, 2, 24, 1, 1, 3, 1, null, null },
                    { 48, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9920), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9920), null, null, false, false, 5, 25, 1, 1, 3, 1, null, null },
                    { 49, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9927), null, null, false, false, 1, 25, null, 1, 2, null, null, null },
                    { 50, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9934), null, null, false, false, 3, 25, 1, 3, 1, null, null, null },
                    { 51, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9942), null, null, false, false, 1, 25, 1, 2, 3, 1, null, null },
                    { 52, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9950), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9950), null, null, false, false, 1, 26, 1, 2, 1, null, null, null },
                    { 53, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9957), null, null, false, false, 5, 26, null, 2, 0, null, null, null },
                    { 54, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9965), null, null, false, false, 3, 26, 1, 1, 1, null, null, null },
                    { 55, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9972), null, null, false, false, 3, 26, 1, 2, 1, null, null, null },
                    { 56, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9981), null, null, false, false, 2, 27, 1, 2, 1, null, null, null },
                    { 57, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9988), null, null, false, false, 4, 27, null, 2, 0, null, null, null },
                    { 58, new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 11, 6, 21, 22, 9, 423, DateTimeKind.Local).AddTicks(9996), null, null, false, false, 3, 27, null, 1, 0, null, null, null },
                    { 59, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(3), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(3), null, null, false, false, 1, 27, 1, 2, 1, null, null, null },
                    { 60, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(12), null, null, false, false, 2, 28, 1, 2, 3, 1, null, null },
                    { 61, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(19), null, null, false, false, 5, 28, 1, 1, 3, 1, null, null },
                    { 62, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(28), null, null, false, false, 2, 29, null, 2, 2, null, null, null },
                    { 63, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(98), null, null, false, false, 2, 29, null, 2, 2, null, null, null },
                    { 64, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(106), null, null, false, false, 5, 29, null, 1, 0, null, null, null },
                    { 65, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(113), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(113), null, null, false, false, 3, 29, 1, 2, 1, null, null, null },
                    { 66, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(123), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(124), null, null, false, false, 3, 30, null, 1, 0, null, null, null },
                    { 67, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(131), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(131), null, null, false, false, 3, 30, null, 1, 2, null, null, null },
                    { 68, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(139), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(139), null, null, false, false, 4, 31, null, 1, 2, null, null, null },
                    { 69, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(146), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(147), null, null, false, false, 1, 31, null, 3, 2, null, null, null },
                    { 70, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(155), null, null, false, false, 5, 32, 1, 3, 3, 1, null, null },
                    { 71, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(164), null, null, false, false, 2, 33, null, 2, 2, null, null, null },
                    { 72, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(170), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(171), null, null, false, false, 1, 33, null, 3, 2, null, null, null },
                    { 73, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(178), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(178), null, null, false, false, 1, 33, 1, 1, 3, 1, null, null },
                    { 74, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(185), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(185), null, null, false, false, 5, 33, null, 2, 0, null, null, null },
                    { 75, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(194), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(194), null, null, false, false, 3, 34, 1, 3, 3, 1, null, null },
                    { 76, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(201), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(201), null, null, false, false, 3, 34, null, 2, 0, null, null, null },
                    { 77, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(248), null, null, false, false, 5, 34, null, 2, 0, null, null, null },
                    { 78, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(256), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(257), null, null, false, false, 2, 35, null, 3, 0, null, null, null },
                    { 79, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(265), null, null, false, false, 2, 36, null, 1, 0, null, null, null },
                    { 80, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(272), null, null, false, false, 3, 36, 1, 2, 3, 1, null, null },
                    { 81, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(280), null, null, false, false, 1, 36, 1, 3, 1, null, null, null },
                    { 82, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(288), null, null, false, false, 4, 37, 1, 2, 3, 1, null, null },
                    { 83, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(295), null, null, false, false, 1, 37, null, 2, 2, null, null, null },
                    { 84, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(302), null, null, false, false, 1, 37, 1, 3, 1, null, null, null },
                    { 85, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(310), null, null, false, false, 5, 37, 1, 3, 1, null, null, null },
                    { 86, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(318), null, null, false, false, 4, 37, 1, 3, 3, 1, null, null },
                    { 87, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(327), null, null, false, false, 1, 38, null, 1, 2, null, null, null },
                    { 88, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(333), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(333), null, null, false, false, 3, 38, 1, 3, 1, null, null, null },
                    { 89, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(341), null, null, false, false, 1, 38, null, 3, 2, null, null, null },
                    { 90, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(348), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(348), null, null, false, false, 4, 38, 1, 2, 1, null, null, null },
                    { 91, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(356), null, null, false, false, 2, 39, null, 1, 0, null, null, null },
                    { 92, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(363), null, null, false, false, 1, 39, 1, 2, 1, null, null, null },
                    { 93, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(419), null, null, false, false, 4, 39, null, 3, 2, null, null, null },
                    { 94, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(434), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(435), null, null, false, false, 3, 40, 1, 1, 1, null, null, null },
                    { 95, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(445), null, null, false, false, 2, 40, 1, 1, 1, null, null, null },
                    { 96, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(479), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(479), null, null, false, false, 4, 41, 1, 3, 1, null, null, null },
                    { 97, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(495), null, null, false, false, 2, 41, null, 1, 0, null, null, null },
                    { 98, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(515), null, null, false, false, 3, 41, 1, 2, 1, null, null, null },
                    { 99, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(527), null, null, false, false, 5, 42, null, 1, 2, null, null, null },
                    { 100, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(537), null, null, false, false, 4, 42, 1, 3, 3, 1, null, null },
                    { 101, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(560), null, null, false, false, 4, 42, null, 1, 0, null, null, null },
                    { 102, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(592), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(592), null, null, false, false, 5, 43, 1, 2, 3, 1, null, null },
                    { 103, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(635), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(635), null, null, false, false, 1, 43, 1, 1, 3, 1, null, null },
                    { 104, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(650), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(650), null, null, false, false, 1, 43, null, 1, 2, null, null, null },
                    { 105, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(659), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(659), null, null, false, false, 5, 44, 1, 3, 3, 1, null, null },
                    { 106, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(667), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(667), null, null, false, false, 5, 44, 1, 2, 1, null, null, null },
                    { 107, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(675), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(675), null, null, false, false, 2, 45, null, 3, 2, null, null, null },
                    { 108, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(682), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(683), null, null, false, false, 2, 45, null, 2, 0, null, null, null },
                    { 109, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(690), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(690), null, null, false, false, 4, 45, 1, 2, 1, null, null, null },
                    { 110, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(744), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(745), null, null, false, false, 3, 45, 1, 3, 1, null, null, null },
                    { 111, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(755), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(756), null, null, false, false, 1, 46, null, 2, 2, null, null, null },
                    { 112, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(762), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(762), null, null, false, false, 1, 46, null, 1, 2, null, null, null },
                    { 113, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(769), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(769), null, null, false, false, 4, 46, null, 2, 2, null, null, null },
                    { 114, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(775), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(775), null, null, false, false, 4, 46, null, 3, 2, null, null, null },
                    { 115, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(782), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(782), null, null, false, false, 5, 47, null, 1, 2, null, null, null },
                    { 116, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(788), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(789), null, null, false, false, 5, 47, null, 1, 2, null, null, null },
                    { 117, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(794), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(795), null, null, false, false, 1, 47, null, 2, 2, null, null, null },
                    { 118, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(800), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(801), null, null, false, false, 2, 47, null, 1, 2, null, null, null },
                    { 119, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(807), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(807), null, null, false, false, 5, 47, null, 2, 2, null, null, null },
                    { 120, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(817), null, null, false, false, 5, 48, 1, 1, 3, 1, null, null },
                    { 121, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(826), null, null, false, false, 3, 48, 1, 1, 3, 1, null, null },
                    { 122, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(833), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(833), null, null, false, false, 5, 48, 1, 1, 3, 1, null, null },
                    { 123, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(843), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(844), null, null, false, false, 4, 49, null, 3, 2, null, null, null },
                    { 124, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(853), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(854), null, null, false, false, 3, 49, 1, 3, 3, 1, null, null },
                    { 125, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(861), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(861), null, null, false, false, 4, 49, null, 3, 2, null, null, null },
                    { 126, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(870), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(870), null, null, false, false, 1, 50, 1, 1, 1, null, null, null },
                    { 127, new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(967), new DateTime(2023, 11, 6, 21, 22, 9, 424, DateTimeKind.Local).AddTicks(968), null, null, false, false, 5, 50, 1, 1, 1, null, null, null }
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
