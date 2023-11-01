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
                name: "Approvers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approvers_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
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
                name: "Executors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executors_AspNetUsers_UserId1",
                        column: x => x.UserId1,
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
                        name: "FK_Requests_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
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
                    ApproverId = table.Column<int>(type: "integer", nullable: true),
                    ExecutorId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_ServiceRequests_Approvers_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "Approvers",
                        principalColumn: "Id");
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
                        name: "FK_ServiceRequests_Executors_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "Executors",
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
                        name: "FK_ServiceRequests_Services_ServiceId",
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
                    { 1, 8, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3568), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3568), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3574), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3575), false, "B", 5 }
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
                    { new Guid("099334f8-c60b-4d77-bdf7-ff1f1bbfc8e5"), 0, "Urna/Eleifend, Porta at phasellus", "a3574cac-e9c2-412f-8c0e-8b838be6f619", 0, "ex@sapien.com", true, "Litora aenean fames", false, false, null, "pellentesque@malesuada.com", "customer7", "AQAAAAIAAYagAAAAEKgeQ0kMgSYlMe7Kti6eTct9XwNT6huIrt2SiWTTqeTWZZ8anihsD+HnMtxkr6S4gg==", "3607513780", false, "", false, "customer7" },
                    { new Guid("0f9646cd-04d7-47aa-b6b9-de345ecbb92b"), 0, "Vel/Facilisis, Nulla magna non", "1057fd74-1b42-4632-9c46-e8cdf59fa0e0", 0, "pulvinar@nibh.com", true, "Massa at varius", false, false, null, "tortor@et.com", "customer10", "AQAAAAIAAYagAAAAEEDhgDVUo18ZKwX3Cuu5CT0o+0LAWVUuBr6j5kj8NkCMpog6lw6jEE1eJqnuc+FVSg==", "6644571124", false, "", false, "customer10" },
                    { new Guid("1341cc95-2cdf-4ef9-b3de-37a0dfb4cb4e"), 0, "Ac/Ipsum, Dictumst risus ex", "cf155ce2-4080-475b-9fb6-8e5cb394e3a3", 0, "lacinia@sociosqu.com", true, "Porttitor nostra enim", false, false, null, "mauris@vitae.com", "customer3", "AQAAAAIAAYagAAAAEHLwJ1y8U1QgDimQ+ZncSVsSkn/kG0kgq2SpYqLn29cNtubeWGGxQPX5pPVBs8F8Nw==", "2510372380", false, "", false, "customer3" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "b61406ee-2bef-431d-9d43-caf083d052b3", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAENY0RWY4yROOfBdv9pMWeKpdYyDbXKtajduGmOYjpxtdnAjIDBpmoTBNtoUvUwOm8A==", "0000000003", false, "", false, "sale" },
                    { new Guid("23b4f335-f1ec-45ee-915a-b27231799895"), 0, "Ante/Felis, Fringilla fringilla vel", "58010533-e60a-4dff-a85b-cc9bd2ed1c6f", 0, "accumsan@tempor.com", true, "Sed et inceptos", false, false, null, "luctus@porta.com", "customer9", "AQAAAAIAAYagAAAAENWUfk4+WQX0mlI03045nLJGNX6s7r+7GNNQI53VEHAmfMzoR798jSungry/llQ89Q==", "8808705314", false, "", false, "customer9" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "667b33c2-3a7f-4806-b356-5bb3e9906510", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEEb3MJI5qVDuOllycOLrO/AGfICFNPCPeHpZBCQKjtplSUAJ5rUsxpwx4jKOBysApg==", "0000000005", false, "", false, "admin" },
                    { new Guid("2d2c5a92-f790-4544-bf09-f0c24dfbace8"), 0, "Cursus/Luctus, Molestie sagittis tristique", "9f5621ea-eb40-4485-bde1-e6104231c901", 0, "faucibus@sed.com", true, "In justo porttitor", false, false, null, "facilisis@in.com", "customer8", "AQAAAAIAAYagAAAAECj6j57f5Yzp3D5Km7hXTUpIlC5mBppKXGPdUaRni+O7pvf/QJRJAxBAXmcm+OIqpw==", "2025135381", false, "", false, "customer8" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "fa2995e9-d59b-44af-a9f5-e35533cdb6ea", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEOviL5t4WnhDvBe1Qi0DH1IMGgnTNRMHAdH02qfv0rtuxsqVpX+1v7HXA/NaI2TjqQ==", "0000000004", false, "", false, "manager" },
                    { new Guid("3948197e-8d58-4b35-af06-429c33220b66"), 0, "Per/Ante, Eu nec rhoncus", "b697f7e1-5465-4004-9ca2-733a52d0d908", 0, "gravida@etiam.com", true, "Maecenas dignissim suspendisse", false, false, null, "laoreet@facilisis.com", "customer4", "AQAAAAIAAYagAAAAEDKDwxLrl2NnG/Eg+Qyu9Q/kKRaUzwgYJIgOtpwVJqjvePt1SvrRRCqqGDggKkbgyQ==", "2674066712", false, "", false, "customer4" },
                    { new Guid("467b2911-3925-4e8a-bd22-2cb286cd7f2f"), 0, "Consectetur/Nisl, Hendrerit ultrices platea", "b8d4c95f-984c-4b34-95b7-7310a35fd608", 0, "felis@neque.com", true, "Semper curabitur morbi", false, false, null, "malesuada@laoreet.com", "customer21", "AQAAAAIAAYagAAAAENaXMZmp+06/bhdzNsLjKxOkAEhLZyUP3zyxMPzn9IsZ6gKmi+mf0ulxIKSGTIYoHA==", "1631069635", false, "", false, "customer21" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "01337867-3602-4c89-8df4-2d70a5baeaa5", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEEX3UliigHkX1phn5o9CAesM6/icAa/uZ0huqwOco0FXjPCRv5R375XzP0w9NEeIYQ==", "0000000002", false, "", false, "tech" },
                    { new Guid("51a291cf-5f13-4e58-96c7-65f3037857de"), 0, "Sapien/Varius, Gravida aliquet velit", "9191d962-6426-494e-acd4-c18a6a7f587c", 0, "a@magna.com", true, "Vitae bibendum nisi", false, false, null, "laoreet@odio.com", "customer25", "AQAAAAIAAYagAAAAEPMl7pwK7AVKmmSodbs8zdYTEnVvrdPm/wqPBxy5XRfeARewTXY6opqIcrLtA0LgCw==", "2366278906", false, "", false, "customer25" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "bfa64fcb-7b62-4f76-bcd9-05083652e8e0", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEP361aMC89MGdZ9X641RbYn0EucyRlLZhxUY+iFZSrcokczbyKQM6athqJTm1xz2Lw==", "0000000001", false, "", false, "super" },
                    { new Guid("652a35fe-6880-4a51-8f78-e15164ded4c7"), 0, "Fusce/Leo, Varius commodo vel", "d205dff9-2838-4332-a60c-048ac2c64f72", 0, "inceptos@mollis.com", true, "Nulla porttitor nisl", false, false, null, "donec@pretium.com", "customer18", "AQAAAAIAAYagAAAAEC1/J7Iom3v+x1gJ81FOgfrBofgnMRl+cjWb7MKAxh7hQeIH8rDT7XRNfAcMYF60qw==", "3665157351", false, "", false, "customer18" },
                    { new Guid("71b5d52d-eb5f-429a-9258-3f5b9b6e5557"), 0, "Habitasse/Feugiat, Dapibus nostra sit", "ac8a29c6-e3a7-4d1d-b7fc-217bd8885a57", 0, "sem@eros.com", true, "Ut odio fusce", false, false, null, "sapien@aliquet.com", "customer13", "AQAAAAIAAYagAAAAEC06ubtM3wwXi54wWnmFMFcDIj67AkqXWulK51ZEORKROFxMLc8X2U4uCWviNtahJg==", "6310576212", false, "", false, "customer13" },
                    { new Guid("7ae22d25-777d-4261-86b5-44bd86cb7606"), 0, "Maecenas/Sagittis, Magna lacinia sociosqu", "59669b36-505d-41de-bc64-ba9c0e45b133", 0, "aptent@elit.com", true, "Conubia elit non", false, false, null, "mattis@rutrum.com", "customer24", "AQAAAAIAAYagAAAAEDnC9ES6m7SkMjQGAPsg9NojG33G0PdwOpQCKnp4/jQEy1rEIFnHiCWsfLtFB8bI6w==", "4163637944", false, "", false, "customer24" },
                    { new Guid("9772d541-7b45-43ed-8f19-bfafa6f29d72"), 0, "Fusce/Dictum, Vitae tellus vel", "a6987bae-8380-475b-b50e-abecbd42a545", 0, "sociosqu@tellus.com", true, "Amet vivamus vulputate", false, false, null, "gravida@suspendisse.com", "customer6", "AQAAAAIAAYagAAAAEJ/YH7KRRfHx1xGD/zGk0sO0MjhQpRcYmdM2B0i474zD83gwy5Lh+9OR6FhdnVMK7g==", "5666562209", false, "", false, "customer6" },
                    { new Guid("9f27f2ac-06a6-4874-89ed-95449b099687"), 0, "Sem/Amet, Id commodo aenean", "a1d4e844-7907-4b7d-99c9-32f452aed338", 0, "velit@aliquet.com", true, "Lacus placerat himenaeos", false, false, null, "orci@tortor.com", "customer15", "AQAAAAIAAYagAAAAELkGbG3sEpSk07us9qZls3PAQx7IBCH+dmtMHdxtAoqAoW+H4r90Vrpb3+umVQ37tQ==", "3345054780", false, "", false, "customer15" },
                    { new Guid("b675b77f-06e3-458b-893e-b30b7dbe087e"), 0, "Vehicula/Sagittis, Quis tortor ex", "6a3459e7-ae6b-4b10-9274-0c5cf498961c", 0, "sagittis@ante.com", true, "Nec nibh morbi", false, false, null, "tortor@libero.com", "customer2", "AQAAAAIAAYagAAAAECDjV9F4U5MbENPnzh8hZfB9K2ZEdT+pQxOONA8EJvw5AniH8DYnDw4iz35jHHj0xQ==", "3421865931", false, "", false, "customer2" },
                    { new Guid("ba5c8c59-73f9-459c-a363-936c8362d019"), 0, "Praesent/Aptent, Fusce sit ligula", "0ebbe8a9-7732-4d82-bd49-f937f935320a", 0, "eu@etiam.com", true, "Blandit commodo purus", false, false, null, "vestibulum@sem.com", "customer19", "AQAAAAIAAYagAAAAEMxif4QR1TljEeF3yu0oO3qacLvPNL+ahA1ajpuziDLzTO91d5pj5SKsnK7H6cCh3g==", "3155402286", false, "", false, "customer19" },
                    { new Guid("cd32920a-9ff2-43f6-8556-8ceae856a353"), 0, "Dapibus/Rutrum, Sagittis donec maecenas", "cdf4a97e-b15c-49d2-851c-15103063e45e", 0, "porta@sociosqu.com", true, "Consequat varius sociosqu", false, false, null, "molestie@vel.com", "customer12", "AQAAAAIAAYagAAAAEGWoUSZTg5P1HQIkwduyu/ovTKLRe6ig3g/G/GJZgsW2vRI6499PDb4HZnvZQZPR9g==", "7925920177", false, "", false, "customer12" },
                    { new Guid("cf7f8838-ef36-4d6a-b41a-18f80f1cdaa0"), 0, "Lacinia/Eros, Sociosqu tortor ultrices", "e80e129b-41fb-4b53-be1c-34451a4bdd78", 0, "magna@lacinia.com", true, "Elementum pellentesque auctor", false, false, null, "etiam@molestie.com", "customer22", "AQAAAAIAAYagAAAAELF+gorCWaby5cGf3Nh1UhT5yVVe64KJ4XlHLT41Dyw8fvRe83rgB+HaQPybe1qxsQ==", "5893986112", false, "", false, "customer22" },
                    { new Guid("d0e1714d-e851-4a43-8a4b-37e587bf59a9"), 0, "Varius/Feugiat, Auctor tincidunt quisque", "c5e9fd3a-94ec-4c7c-ab35-57ab6caeade7", 0, "eu@leo.com", true, "Scelerisque per habitasse", false, false, null, "donec@cras.com", "customer23", "AQAAAAIAAYagAAAAEO+8ayor1d+Q20UHZDAbGlmGECcYbiIflpnRaZP9eMlTeWhcfSgP3MzLcftBXhAZNg==", "4448600232", false, "", false, "customer23" },
                    { new Guid("d0fd7328-b65e-451d-80fc-dc216c4e47e0"), 0, "Mi/Tellus, Morbi molestie et", "bd3c8ebc-daad-4f43-992d-b57a9e73e0e5", 0, "arcu@id.com", true, "In ante bibendum", false, false, null, "eget@congue.com", "customer16", "AQAAAAIAAYagAAAAEKkSggPaeTR4+MCXw1ZWjOQEWeDtdrCO5cUYdSuRBFpXBQy3s9n66kmMWONlTZwp1A==", "7450418309", false, "", false, "customer16" },
                    { new Guid("d2a913c3-31ed-402f-9c81-b7803be7cf36"), 0, "Orci/Massa, Fringilla lacinia lobortis", "66408dd8-2513-4d40-b9f1-3fb37eac853b", 0, "dictumst@semper.com", true, "Posuere luctus duis", false, false, null, "neque@erat.com", "customer5", "AQAAAAIAAYagAAAAEM8EknjYqoeTbSJNZgV4UmkcjysckWmLgRHWav9QV9cwKbWxhifb628O2BY3RPafOA==", "8720928276", false, "", false, "customer5" },
                    { new Guid("dd08f99e-73ea-4626-b3a7-c4fa81f6fc67"), 0, "Finibus/Varius, Vivamus pellentesque volutpat", "9d1210e0-db93-4bf5-aacb-c4edbb8f4d7a", 0, "ornare@scelerisque.com", true, "Aliquam ante leo", false, false, null, "pulvinar@lectus.com", "customer11", "AQAAAAIAAYagAAAAEGQrJ/sVrKd0eXuZmofbv4FozlFu2shuHQxuN1C55Sn9NnKTn0aJbew6wX1MzzDPbw==", "5196335823", false, "", false, "customer11" },
                    { new Guid("dfbc882b-111b-4256-af44-312aa0b2a336"), 0, "Amet/Consequat, Facilisis torquent fringilla", "38283bd3-b2db-44e0-805b-0fc48a56a206", 0, "arcu@interdum.com", true, "Consequat ultrices ante", false, false, null, "purus@felis.com", "customer1", "AQAAAAIAAYagAAAAEA6dE+Qezlf94xWeIENzyBJsngzTUBy/nV8YRuEKI0mh9c1s2lh7SHXOt3ir7kSEIQ==", "9973951434", false, "", false, "customer1" },
                    { new Guid("e3f76b61-d7d0-48d2-bed8-b508530cc1e8"), 0, "Laoreet/Primis, Porta pretium nisl", "40b7e39a-77ed-4548-a42f-b58e7b7f58c4", 0, "a@maecenas.com", true, "Rhoncus vestibulum risus", false, false, null, "non@lectus.com", "customer17", "AQAAAAIAAYagAAAAEOpRskm8OsnMRruHIJARw6rmyN9i6tYRbkaGQorJWVNAwGLq+2GVHJjdzmgVr1tOiw==", "3871292449", false, "", false, "customer17" },
                    { new Guid("ef88630f-6f5f-4f3c-827c-0a250cb819b9"), 0, "Feugiat/Porta, Vehicula ultrices aliquam", "6d33f63b-30fc-4e24-b936-ad109f1fa1f4", 0, "aliquam@tempor.com", true, "Eget vehicula morbi", false, false, null, "leo@elementum.com", "customer14", "AQAAAAIAAYagAAAAEG1YWhtMth1lc1Doyx62Jq7dh2mE9ODU3EAhlgAUEBfmCmyQNDMFNtkts07C3sWbRw==", "6308077558", false, "", false, "customer14" },
                    { new Guid("fec2dd2c-314e-4d17-9e58-fc4ba859492b"), 0, "At/Venenatis, Facilisis nullam eleifend", "e7bec86d-b295-4f6c-a3d1-8b3adaf0848c", 0, "viverra@vivamus.com", true, "Sociosqu varius malesuada", false, false, null, "pulvinar@interdum.com", "customer20", "AQAAAAIAAYagAAAAEJ3CQ57b96SlDMK5CQmP/lk1nNHvK8WwgRRZw/4NXlP0rTvRKrS5EyorAtHmHu248A==", "6365540307", false, "", false, "customer20" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3026), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3084), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3085), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3090), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3090), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3094), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3094), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3098), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3098), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 316, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3145), false, 8, "Hub" },
                    { 2, 0, 0, 236, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3163), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3163), false, 10, "Hub" },
                    { 3, 0, 0, 486, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3169), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3169), false, 5, "Hub" },
                    { 4, 0, 0, 479, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3185), false, 10, "Hub" },
                    { 5, 0, 0, 418, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3190), false, 7, "Hub" },
                    { 6, 0, 0, 452, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3197), false, 5, "Hub" },
                    { 7, 0, 0, 397, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3202), false, 3, "Hub" },
                    { 8, 0, 0, 416, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3207), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3207), false, 4, "Hub" },
                    { 9, 0, 0, 271, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3213), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3213), false, 9, "Hub" },
                    { 10, 0, 0, 312, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3220), false, 2, "Hub" },
                    { 11, 0, 0, 232, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3225), false, 2, "Server" },
                    { 12, 0, 0, 416, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3231), false, 7, "Server" },
                    { 13, 0, 0, 465, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3343), false, 3, "Server" },
                    { 14, 0, 0, 483, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3349), false, 9, "Server" },
                    { 15, 0, 0, 368, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3355), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3355), false, 8, "Server" },
                    { 16, 0, 0, 497, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3360), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3360), false, 10, "Server" },
                    { 17, 0, 0, 340, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3365), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3366), false, 7, "Server" },
                    { 18, 0, 0, 286, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3372), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3373), false, 5, "Server" },
                    { 19, 0, 0, 236, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3378), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3378), false, 9, "Server" },
                    { 20, 0, 0, 454, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3383), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3383), false, 4, "Server" },
                    { 21, 0, 0, 239, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3389), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3389), false, 3, "Server" },
                    { 22, 0, 0, 434, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3394), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3394), false, 4, "Server" },
                    { 23, 0, 0, 415, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3398), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3399), false, 4, "Server" },
                    { 24, 0, 0, 448, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3413), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3414), false, 6, "Server" },
                    { 25, 0, 0, 477, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3420), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3420), false, 7, "Server" },
                    { 26, 0, 0, 404, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3425), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3425), false, 2, "Server" },
                    { 27, 0, 0, 443, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3431), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3431), false, 9, "Server" },
                    { 28, 0, 0, 417, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3436), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3436), false, 7, "Server" },
                    { 29, 0, 0, 281, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3441), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3441), false, 4, "Server" },
                    { 30, 0, 0, 433, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3446), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3446), false, 4, "Server" },
                    { 31, 0, 0, 200, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3451), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3452), false, 2, "Server" },
                    { 32, 0, 0, 310, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3457), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3457), false, 4, "Server" },
                    { 33, 0, 0, 320, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3462), false, 4, "Server" },
                    { 34, 0, 0, 391, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3468), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3469), false, 4, "Server" },
                    { 35, 0, 0, 309, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3474), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3474), false, 2, "Server" },
                    { 36, 0, 0, 437, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3479), false, 3, "Server" },
                    { 37, 0, 0, 434, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3484), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3484), false, 6, "Server" },
                    { 38, 0, 0, 234, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3489), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3490), false, 4, "Server" },
                    { 39, 0, 0, 333, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3494), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3495), false, 8, "Server" },
                    { 40, 0, 0, 257, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3500), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3500), false, 7, "Server" },
                    { 41, 0, 0, 367, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3505), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3506), false, 4, "Server" },
                    { 42, 0, 0, 418, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3511), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3511), false, 9, "Server" },
                    { 43, 0, 0, 398, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3516), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3517), false, 10, "Server" },
                    { 44, 0, 0, 484, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3521), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3522), false, 4, "Server" },
                    { 45, 0, 0, 375, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3532), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3532), false, 10, "Server" },
                    { 46, 0, 0, 324, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3537), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3538), false, 3, "Server" },
                    { 47, 0, 0, 443, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3543), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3543), false, 3, "Server" },
                    { 48, 0, 0, 324, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3548), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3548), false, 10, "Server" },
                    { 49, 0, 0, 323, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3553), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3553), false, 3, "Server" },
                    { 50, 0, 0, 337, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3558), false, 9, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4505), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4512), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4512), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3116), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3116), "Thuê Chỗ", false, "Cấp bổ sung U", "Size" },
                    { 2, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3125), "Thêm 1U", false, "Bổ sung IP", "Ip" },
                    { 3, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3130), "Công suất 100", false, "Thêm Port", "Port" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("099334f8-c60b-4d77-bdf7-ff1f1bbfc8e5") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("0f9646cd-04d7-47aa-b6b9-de345ecbb92b") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("1341cc95-2cdf-4ef9-b3de-37a0dfb4cb4e") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("23b4f335-f1ec-45ee-915a-b27231799895") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("2d2c5a92-f790-4544-bf09-f0c24dfbace8") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("3948197e-8d58-4b35-af06-429c33220b66") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("467b2911-3925-4e8a-bd22-2cb286cd7f2f") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("51a291cf-5f13-4e58-96c7-65f3037857de") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("652a35fe-6880-4a51-8f78-e15164ded4c7") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("71b5d52d-eb5f-429a-9258-3f5b9b6e5557") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("7ae22d25-777d-4261-86b5-44bd86cb7606") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9772d541-7b45-43ed-8f19-bfafa6f29d72") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9f27f2ac-06a6-4874-89ed-95449b099687") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("b675b77f-06e3-458b-893e-b30b7dbe087e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ba5c8c59-73f9-459c-a363-936c8362d019") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("cd32920a-9ff2-43f6-8556-8ceae856a353") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("cf7f8838-ef36-4d6a-b41a-18f80f1cdaa0") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("d0e1714d-e851-4a43-8a4b-37e587bf59a9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("d0fd7328-b65e-451d-80fc-dc216c4e47e0") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("d2a913c3-31ed-402f-9c81-b7803be7cf36") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("dd08f99e-73ea-4626-b3a7-c4fa81f6fc67") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("dfbc882b-111b-4256-af44-312aa0b2a336") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("e3f76b61-d7d0-48d2-bed8-b508530cc1e8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ef88630f-6f5f-4f3c-827c-0a250cb819b9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("fec2dd2c-314e-4d17-9e58-fc4ba859492b") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(5529), new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(5530), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Feugiat rhoncus rutrum", 2, new DateTime(2023, 11, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(943), new DateTime(2023, 11, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(947), false, "575855174", new Guid("dfbc882b-111b-4256-af44-312aa0b2a336") },
                    { 3, "Velit finibus pulvinar", 2, new DateTime(2023, 11, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 11, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(2491), false, "2108567425", new Guid("b675b77f-06e3-458b-893e-b30b7dbe087e") },
                    { 4, "Sollicitudin risus dolor", 4, new DateTime(2023, 11, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 11, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(1329), false, "1013064257", new Guid("1341cc95-2cdf-4ef9-b3de-37a0dfb4cb4e") },
                    { 5, "Sed dui fames", 5, new DateTime(2023, 11, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(674), new DateTime(2023, 11, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(679), false, "1386382996", new Guid("3948197e-8d58-4b35-af06-429c33220b66") },
                    { 6, "Pulvinar quis euismod", 1, new DateTime(2023, 11, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(6585), new DateTime(2023, 11, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(6588), false, "202227295", new Guid("d2a913c3-31ed-402f-9c81-b7803be7cf36") },
                    { 7, "Ipsum egestas bibendum", 4, new DateTime(2023, 11, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 11, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(2119), false, "1193948395", new Guid("9772d541-7b45-43ed-8f19-bfafa6f29d72") },
                    { 8, "Eget aliquet nibh", 5, new DateTime(2023, 11, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 11, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(3244), false, "947184882", new Guid("099334f8-c60b-4d77-bdf7-ff1f1bbfc8e5") },
                    { 9, "Sem vel purus", 1, new DateTime(2023, 11, 1, 20, 50, 56, 172, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 11, 1, 20, 50, 56, 172, DateTimeKind.Local).AddTicks(9780), false, "1317159117", new Guid("2d2c5a92-f790-4544-bf09-f0c24dfbace8") },
                    { 10, "Et id torquent", 5, new DateTime(2023, 11, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(7359), new DateTime(2023, 11, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(7363), false, "1661479776", new Guid("23b4f335-f1ec-45ee-915a-b27231799895") },
                    { 11, "Eu vulputate quam", 5, new DateTime(2023, 11, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 11, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(4856), false, "495769570", new Guid("0f9646cd-04d7-47aa-b6b9-de345ecbb92b") },
                    { 12, "Eros feugiat nibh", 3, new DateTime(2023, 11, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(1620), false, "1585786238", new Guid("dd08f99e-73ea-4626-b3a7-c4fa81f6fc67") },
                    { 13, "Eget maximus id", 3, new DateTime(2023, 11, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 11, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(5426), false, "658943013", new Guid("cd32920a-9ff2-43f6-8556-8ceae856a353") },
                    { 14, "Pulvinar semper morbi", 2, new DateTime(2023, 11, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(3690), new DateTime(2023, 11, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(3693), false, "206047579", new Guid("71b5d52d-eb5f-429a-9258-3f5b9b6e5557") },
                    { 15, "Volutpat per viverra", 3, new DateTime(2023, 11, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 11, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(4391), false, "1999594355", new Guid("ef88630f-6f5f-4f3c-827c-0a250cb819b9") },
                    { 16, "Sapien tortor sagittis", 3, new DateTime(2023, 11, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(5578), new DateTime(2023, 11, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(5581), false, "1985792238", new Guid("9f27f2ac-06a6-4874-89ed-95449b099687") },
                    { 17, "Vitae a non", 2, new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(1760), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(1764), false, "1208843793", new Guid("d0fd7328-b65e-451d-80fc-dc216c4e47e0") },
                    { 18, "Ligula placerat neque", 1, new DateTime(2023, 11, 1, 20, 50, 57, 447, DateTimeKind.Local).AddTicks(6667), new DateTime(2023, 11, 1, 20, 50, 57, 447, DateTimeKind.Local).AddTicks(6669), false, "433523527", new Guid("e3f76b61-d7d0-48d2-bed8-b508530cc1e8") },
                    { 19, "Ligula rutrum laoreet", 2, new DateTime(2023, 11, 1, 20, 50, 57, 515, DateTimeKind.Local).AddTicks(2074), new DateTime(2023, 11, 1, 20, 50, 57, 515, DateTimeKind.Local).AddTicks(2076), false, "655434944", new Guid("652a35fe-6880-4a51-8f78-e15164ded4c7") },
                    { 20, "Porta vivamus id", 1, new DateTime(2023, 11, 1, 20, 50, 57, 582, DateTimeKind.Local).AddTicks(6358), new DateTime(2023, 11, 1, 20, 50, 57, 582, DateTimeKind.Local).AddTicks(6364), false, "862257987", new Guid("ba5c8c59-73f9-459c-a363-936c8362d019") },
                    { 21, "Eros finibus consequat", 3, new DateTime(2023, 11, 1, 20, 50, 57, 652, DateTimeKind.Local).AddTicks(4721), new DateTime(2023, 11, 1, 20, 50, 57, 652, DateTimeKind.Local).AddTicks(4724), false, "600601669", new Guid("fec2dd2c-314e-4d17-9e58-fc4ba859492b") },
                    { 22, "Rhoncus neque elit", 2, new DateTime(2023, 11, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 11, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(6752), false, "152101254", new Guid("467b2911-3925-4e8a-bd22-2cb286cd7f2f") },
                    { 23, "Vel nec quam", 5, new DateTime(2023, 11, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(889), new DateTime(2023, 11, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(891), false, "1605731159", new Guid("cf7f8838-ef36-4d6a-b41a-18f80f1cdaa0") },
                    { 24, "Cursus litora lectus", 2, new DateTime(2023, 11, 1, 20, 50, 57, 858, DateTimeKind.Local).AddTicks(9594), new DateTime(2023, 11, 1, 20, 50, 57, 858, DateTimeKind.Local).AddTicks(9596), false, "1458440801", new Guid("d0e1714d-e851-4a43-8a4b-37e587bf59a9") },
                    { 25, "Amet efficitur at", 4, new DateTime(2023, 11, 1, 20, 50, 57, 930, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 11, 1, 20, 50, 57, 930, DateTimeKind.Local).AddTicks(8810), false, "550156295", new Guid("7ae22d25-777d-4261-86b5-44bd86cb7606") },
                    { 26, "Odio lectus id", 3, new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(4538), new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(4540), false, "1092502906", new Guid("51a291cf-5f13-4e58-96c7-65f3037857de") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4522), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4529), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4529), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4533), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4533), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4536), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4536), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4540), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4544), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4544), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4547), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4548), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4551), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4554), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4555), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4564), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4565), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4568), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4568), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4571), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4572), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4575), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4579), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4582), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4585), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4588), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4589), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4593), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4596), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4600), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4603), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4607), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4610), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4610), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4613), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4613), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4617), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4620), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4623), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4623), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4627), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4630), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4630), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4633), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4636), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4637), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4640), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4640), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4643), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4644), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4647), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4648), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4656), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4656), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4659), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4660), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4663), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4666), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4666), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4670), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4670), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4673), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4673), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4676), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4676), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4679), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4680), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4683), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4683), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4686), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4687), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4690), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4693), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4693), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4696), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4697), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4700), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4703), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4703), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4707), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4707), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4710), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4714), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4717), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4717), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4721), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4721), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4724), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4724), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4727), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4728), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4731), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4731), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4734), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4737), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4738), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4741), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4745), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4748), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4757), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4757), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4761), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4761), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4764), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4764), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4768), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4769), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4772), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4775), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4775), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4779), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4782), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4782), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4785), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4786), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4789), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4789), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4792), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4796), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4799), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4799), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4802), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4806), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4809), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4812), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4812), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4815), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4816), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4819), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4822), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4823), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4826), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4829), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4832), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4833), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4836), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4844), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4848), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4848), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4851), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4851), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4854), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4855), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4858), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4861), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4865), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4868), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4872), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4872), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4875), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4875), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4879), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4882), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4886), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4889), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4892), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4892), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4896), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4899), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4902), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4902), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4906), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4909), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4909), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4913), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4916), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4916), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4919), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4922), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4923), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4926), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4926), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4929), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4929), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4932), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4940), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4941), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4944), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4947), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4948), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4951), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4951), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4954), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4955), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4958), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4961), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4964), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4965), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4968), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4971), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4971), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4975), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4975), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4978), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4978), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4981), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4982), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4985), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4985), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4988), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4991), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4992), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4996), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5000), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5003), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5003), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5007), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5010), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5010), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5019), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5019), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5022), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5023), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5026), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5026), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5029), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5033), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5036), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5036), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5039), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5039), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5042), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5043), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5046), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5046), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5049), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5053), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5056), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5056), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5060), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5063), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5066), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5070), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5073), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5076), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5080), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5083), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5087), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5090), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5093), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5097), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5100), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5103), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5103), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5106), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5107), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5116), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5120), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5123), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5123), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5127), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5130), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5134), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5137), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5140), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5143), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5144), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5147), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5150), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5154), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5157), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5161), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5164), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5167), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5171), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5174), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5178), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5181), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5184), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5188), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5191), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5195), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5198), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5201), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5205), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5208), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5217), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5217), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5220), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5224), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5224), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5227), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5231), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5234), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5237), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5241), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5244), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5244), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5247), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5247), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5250), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5251), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3580), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3580), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3596), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3596), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3604), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3612), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3619), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3619), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3627), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3639), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3639), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3646), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3646), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3587), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3598), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3606), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3612), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3613), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3621), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3628), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3640), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3640), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3647), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3647), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3589), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3598), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3599), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3606), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3607), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3613), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3614), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3622), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3628), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3629), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3641), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3648), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3648), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3590), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3590), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3599), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3600), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3608), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3614), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3614), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3623), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3629), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3642), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3649), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3649), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3591), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3591), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3600), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3608), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3608), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3615), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3616), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3623), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3623), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3630), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3630), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3642), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3643), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3649), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3650), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3593), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3601), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3609), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3609), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3616), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3624), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3624), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3631), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3631), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3643), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3644), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3650), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3651), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3594), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3594), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3602), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3602), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3610), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3610), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3617), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3617), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3625), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3625), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3632), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3644), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3644), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3651), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3651), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3595), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3595), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3603), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3603), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3611), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3611), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3618), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3618), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3626), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3626), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3632), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3633), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3645), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3645), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3652), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3652), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3653), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3654), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3659), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3660), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3664), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3664), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3668), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3669), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3673), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3673), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3677), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3677), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3681), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3682), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3686), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3686), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3655), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3656), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3660), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3660), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3665), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3665), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3669), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3670), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3674), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3674), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3678), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3678), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3682), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3683), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3687), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3656), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3657), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3661), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3661), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3666), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3670), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3674), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3675), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3679), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3679), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3683), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3683), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3688), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3688), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3657), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3658), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3662), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3662), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3667), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3671), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3671), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3675), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3676), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3680), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3680), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3684), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3684), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3689), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3689), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3658), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3659), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3663), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3667), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3668), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3672), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3672), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3676), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3676), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3681), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3681), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3685), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3685), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3689), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(3690), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5260), 11, false, "Molestie vestibulum quisque", 1, "88eee711-1091-4799-824a-66b38ff3584b" },
                    { 2, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5615), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5616), 12, false, "Cursus ultrices quisque", 1, "bda2e03b-19fe-44ee-bd96-13d34a3d9e2b" },
                    { 3, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5861), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5861), 13, false, "Euismod proin tempor", 1, "6beeb113-0f57-43c9-9c14-9f4d65fbbe7a" },
                    { 4, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6095), 14, false, "Est laoreet mi", 1, "f873c0c3-e0f6-4c61-9e29-04b8543fe72f" },
                    { 5, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6320), 15, false, "Massa porttitor ex", 1, "f9b82911-a905-4009-8677-48a3848b9c33" },
                    { 6, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6543), 16, false, "Nulla facilisis turpis", 1, "8e977fa0-42f4-41a2-abd2-59f04b5cd2f5" },
                    { 7, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6749), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6749), 17, false, "Aptent porta felis", 1, "59ee759c-384f-4d31-bbee-e2e8f1b4ccb6" },
                    { 8, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6978), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6978), 18, false, "Nostra nullam vivamus", 1, "08616d7c-823e-4fb1-801c-113e764c1a5c" },
                    { 9, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7189), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7190), 19, false, "Non vel facilisis", 1, "7820ce37-2ce0-44e0-b9a4-7e6cf431df33" },
                    { 10, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7404), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7405), 20, false, "Ullamcorper arcu primis", 1, "578843e7-7ba8-4c40-a091-b1ec1a56ad8a" },
                    { 11, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7587), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7587), 21, false, "Erat litora elementum", 1, "aa6d02a2-0e5a-432c-9151-deaf111a7688" },
                    { 12, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7805), 22, false, "Placerat sed leo", 1, "b7512ade-de3e-4a99-81b8-6eed1cbe8319" },
                    { 13, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8020), 23, false, "Accumsan congue magna", 1, "a9111cf8-bc71-4a0c-98c0-c2694c040f3a" },
                    { 14, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8244), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8244), 24, false, "Nulla risus auctor", 1, "257c0f1e-652f-4c69-b8c8-8e92b099b683" },
                    { 15, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8422), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8423), 25, false, "At vestibulum pellentesque", 1, "141bdcc0-bbbc-490c-b7f3-aff91edb8661" },
                    { 16, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8625), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8625), 26, false, "Suspendisse nec ultrices", 1, "b0aeebad-b6b5-4911-9efc-673adfedbb2d" },
                    { 17, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8819), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8820), 27, false, "Nam imperdiet justo", 1, "915e9fed-ad24-4ef1-bc0a-17b70245ba96" },
                    { 18, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9024), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9024), 28, false, "Imperdiet varius sagittis", 1, "f20cfc4b-3d56-43db-b11d-cfac72b094e5" },
                    { 19, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9222), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9223), 29, false, "Consequat dictumst interdum", 1, "f888d573-f1e3-4c7d-9c03-b4dd91171374" },
                    { 20, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9433), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9433), 30, false, "Sed eleifend maecenas", 1, "e346cecd-5a63-4f0e-aff9-d787f8b2d913" },
                    { 21, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9616), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9617), 31, false, "Sem volutpat at", 1, "01cf445c-d822-4c6b-817c-8e7da77337fe" },
                    { 22, 0, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9840), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9840), 32, false, "Magna porttitor aliquet", 1, "822f0e4a-dae1-496f-8733-94c40e4cf380" },
                    { 23, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(52), 33, false, "Vel per ligula", 1, "a4b3e141-093a-4483-a057-a09deaa8905a" },
                    { 24, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(251), 34, false, "Tristique scelerisque viverra", 1, "1fb59e59-06d9-4a10-b404-dedc81e93532" },
                    { 25, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(479), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(480), 35, false, "Eros molestie aliquet", 1, "cbb7339b-39e7-495d-8410-ef1fb018ec52" },
                    { 26, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(672), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(672), 36, false, "Feugiat in morbi", 1, "69402b4c-8fb4-48a4-8cb9-843f748906c5" },
                    { 27, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(869), 37, false, "Blandit tristique dui", 1, "bedbd6c7-86a1-47dd-99bc-0c584891ee57" },
                    { 28, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1062), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1062), 38, false, "Eleifend id nec", 1, "44184fae-1fc0-4674-a55f-e8a410bcd426" },
                    { 29, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1251), 39, false, "Nam efficitur mauris", 1, "7143fab0-8812-4bba-832f-007a1b45c09e" },
                    { 30, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1490), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1490), 40, false, "Gravida ad mauris", 1, "360730d8-57c7-491f-8a99-8e1e928e4632" },
                    { 31, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1681), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1681), 41, true, "Luctus eu rhoncus", 1, "a3862a72-bef1-4984-96f0-ecf24eb42b67" },
                    { 32, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1870), 42, true, "Sem sapien himenaeos", 1, "145ed36f-8863-44fb-b152-b9027dba7d41" },
                    { 33, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2072), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2073), 43, false, "Nostra platea ante", 1, "7cfbebaa-567b-4a05-bf52-f056d9a03911" },
                    { 34, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2260), 44, false, "Et mauris scelerisque", 1, "4f55890b-f55d-418e-a593-072773104594" },
                    { 35, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2444), 45, false, "Turpis vitae tristique", 1, "6ba9c0b7-3d24-4443-b595-8f5b283758fb" },
                    { 36, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2642), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2642), 46, false, "Turpis etiam leo", 1, "3f02077c-3e2c-40e2-9a2c-74d712c2143e" },
                    { 37, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2828), 47, false, "Ex egestas dictum", 1, "9d548b9a-782c-4455-8b24-c0410570e30f" },
                    { 38, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3037), 48, false, "Scelerisque lectus accumsan", 1, "a5fd5734-fbd8-40c4-94f9-a4bb83fb00a6" },
                    { 39, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3226), 49, false, "Finibus pharetra pellentesque", 1, "10dbae26-54bc-4e2d-8a42-4e28374c26cc" },
                    { 40, 0, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3455), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3455), 50, false, "Egestas nibh interdum", 1, "666ebacd-27ea-4d16-9d4e-88ac8d99d068" }
                });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsActive", "IsDeleted", "ServerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(5608), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5606), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5606), 4, true, false, 1 },
                    { 2, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5856), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(5857), 5, true, false, 2 },
                    { 3, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6090), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6091), 6, true, false, 3 },
                    { 4, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(6311), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6310), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6310), 7, true, false, 4 },
                    { 5, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(6538), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6537), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6537), 8, true, false, 5 },
                    { 6, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(6746), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6745), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6745), 9, true, false, 6 },
                    { 7, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(6974), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6973), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(6974), 10, true, false, 7 },
                    { 8, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(7186), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7185), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7185), 11, true, false, 8 },
                    { 9, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(7400), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7399), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7399), 12, true, false, 9 },
                    { 10, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7582), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7583), 13, true, false, 10 },
                    { 11, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(7802), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7801), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(7801), 14, true, false, 11 },
                    { 12, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8016), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8016), 15, true, false, 12 },
                    { 13, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(8240), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8239), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8240), 16, true, false, 13 },
                    { 14, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(8419), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8418), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8419), 17, true, false, 14 },
                    { 15, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(8615), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8614), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8614), 18, true, false, 15 },
                    { 16, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(8815), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8815), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(8815), 19, true, false, 16 },
                    { 17, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(9020), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9019), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9019), 20, true, false, 17 },
                    { 18, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(9219), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9218), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9218), 21, true, false, 18 },
                    { 19, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(9429), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9429), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9429), 22, true, false, 19 },
                    { 20, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(9613), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9612), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9612), 23, true, false, 20 },
                    { 21, new DateTime(2023, 11, 1, 13, 50, 54, 279, DateTimeKind.Utc).AddTicks(9836), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9836), null, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(9836), 24, true, false, 21 },
                    { 22, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(49), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(48), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(48), 25, true, false, 22 },
                    { 23, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(247), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(247), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(247), 26, true, false, 23 },
                    { 24, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(476), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(475), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(475), 27, true, false, 24 },
                    { 25, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(668), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(667), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(668), 28, true, false, 25 },
                    { 26, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(863), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(862), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(862), 29, true, false, 26 },
                    { 27, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1058), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1058), 30, true, false, 27 },
                    { 28, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(1247), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1247), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1247), 31, true, false, 28 },
                    { 29, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1485), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1486), 32, true, false, 29 },
                    { 30, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(1678), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1677), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1677), 33, true, false, 30 },
                    { 31, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(1866), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1865), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(1866), 34, false, true, 31 },
                    { 32, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2068), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2068), 35, false, true, 32 },
                    { 33, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(2256), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2255), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2255), 36, true, false, 33 },
                    { 34, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2440), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2440), 37, true, false, 34 },
                    { 35, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(2639), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2638), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2638), 38, true, false, 35 },
                    { 36, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(2824), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2823), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(2823), 39, true, false, 36 },
                    { 37, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(3033), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3033), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3033), 40, true, false, 37 },
                    { 38, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(3222), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3221), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3222), 41, true, false, 38 },
                    { 39, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(3451), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3450), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3451), 42, true, false, 39 },
                    { 40, new DateTime(2023, 11, 1, 13, 50, 54, 280, DateTimeKind.Utc).AddTicks(3663), new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3662), null, new DateTime(2023, 11, 1, 20, 50, 54, 280, DateTimeKind.Local).AddTicks(3663), 43, true, false, 40 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4352), 1, false, false, 1, 20 },
                    { 2, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4364), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4365), 2, false, false, 2, 13 },
                    { 3, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4370), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4370), 3, false, false, 3, 14 },
                    { 4, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4374), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4375), 4, false, false, 4, 26 },
                    { 5, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4379), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4379), 5, false, false, 5, 8 },
                    { 6, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4384), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4384), 6, false, false, 6, 16 },
                    { 7, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4388), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4388), 7, false, false, 7, 27 },
                    { 8, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4392), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4393), 8, false, false, 8, 25 },
                    { 9, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4396), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4397), 9, false, false, 9, 18 },
                    { 10, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4402), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4402), 10, false, false, 10, 30 },
                    { 11, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4406), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4406), 11, false, false, 11, 26 },
                    { 12, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4411), 12, false, false, 12, 22 },
                    { 13, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4414), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4415), 13, false, false, 13, 9 },
                    { 14, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4419), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4419), 14, false, false, 14, 11 },
                    { 15, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4423), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4423), 15, false, false, 15, 9 },
                    { 16, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4427), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4428), 16, false, false, 16, 27 },
                    { 17, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4432), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4432), 17, false, false, 17, 7 },
                    { 18, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4443), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4443), 18, false, false, 18, 25 },
                    { 19, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4447), 19, false, false, 19, 1 },
                    { 20, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4451), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4452), 20, false, false, 20, 11 },
                    { 21, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4456), 21, false, false, 21, 26 },
                    { 22, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4460), 22, false, false, 22, 11 },
                    { 23, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4464), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4465), 23, false, false, 23, 30 },
                    { 24, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4469), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4469), 24, false, false, 24, 25 },
                    { 25, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4473), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4473), 25, false, false, 25, 30 },
                    { 26, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4477), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4477), 26, false, false, 26, 20 },
                    { 27, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4481), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4482), 27, false, false, 27, 11 },
                    { 28, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4486), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4486), 28, false, false, 28, 26 },
                    { 29, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4490), 29, false, false, 29, 6 },
                    { 30, new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 11, 1, 20, 50, 54, 279, DateTimeKind.Local).AddTicks(4495), 30, false, false, 30, 29 }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "ServerId", "Status" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 5, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 8, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 11, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(1814), new DateTime(2023, 11, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(1192), 5, new DateTime(2026, 11, 1, 20, 50, 54, 980, DateTimeKind.Local).AddTicks(1812), null, null, false, "Est scelerisque eu interdum leo, ullamcorper cras non, velit iaculis nunc, himenaeos libero et aenean hendrerit efficitur fusce euismod, vivamus. In, euismod volutpat, commodo, lorem, iaculis fringilla, pulvinar, fermentum urna, sed, fringilla vitae placerat, laoreet, mauris, bibendum, donec odio convallis. Bibendum dolor orci ultrices, ligula lacus vitae, proin cursus finibus, euismod, suspendisse aliquam venenatis nulla adipiscing integer et dolor, amet.", null, null, 0 },
                    { 2, 3, new DateTime(2024, 5, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 2, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(3309), new DateTime(2026, 11, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 11, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(2711), 5, new DateTime(2025, 11, 1, 20, 50, 55, 69, DateTimeKind.Local).AddTicks(3316), null, null, false, "Eleifend, aliquet vitae a, placerat vehicula interdum at fringilla, morbi accumsan feugiat, sem molestie dictum mi lacus nostra, lacinia conubia. Auctor lorem fringilla lorem, ex ornare id, commodo laoreet nullam sem quam, a, blandit, vestibulum mattis, sit rhoncus pulvinar augue. Viverra hac efficitur neque lorem nostra, ac, ligula, ultricies nunc, hendrerit quam feugiat leo dui nibh nibh, tortor, enim, vestibulum.", null, null, 0 },
                    { 3, 4, new DateTime(2024, 1, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(2718), new DateTime(2023, 11, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 11, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(2724), new DateTime(2023, 11, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(1632), 5, new DateTime(2025, 11, 1, 20, 50, 55, 159, DateTimeKind.Local).AddTicks(2721), null, null, false, "Auctor, fusce vestibulum blandit primis proin euismod torquent vehicula luctus ultricies laoreet, eu, aliquam et, condimentum aptent arcu, porta fermentum. Phasellus vitae placerat, nulla tempus bibendum, per enim, torquent primis odio auctor, nisl cursus, placerat enim at, platea tincidunt dignissim. Pulvinar himenaeos vel, class imperdiet laoreet, cursus sagittis, elementum amet cursus, quis, interdum, hendrerit arcu arcu, varius, tempus euismod quis.", null, null, 0 },
                    { 4, 5, new DateTime(2024, 6, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(1762), new DateTime(2024, 1, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(1757), new DateTime(2024, 11, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(1767), new DateTime(2023, 11, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(919), 5, new DateTime(2025, 11, 1, 20, 50, 55, 276, DateTimeKind.Local).AddTicks(1765), null, null, false, "Vitae tellus mi blandit cras nullam tempus ac, suspendisse nisi, fringilla per sit ligula, orci, eros, ex ut semper fermentum. Egestas etiam pretium sagittis, tempor, tempor et, ex a leo, commodo, et porta arcu est lobortis tortor auctor, dui, per. Sagittis neque, auctor, per gravida consequat suspendisse dui, quam, nostra, aliquam fringilla sem, erat neque eleifend, ullamcorper a, porttitor odio.", null, null, 0 },
                    { 5, 6, new DateTime(2024, 4, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 8, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(8149), new DateTime(2024, 11, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(8163), new DateTime(2023, 11, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(7037), 5, new DateTime(2026, 11, 1, 20, 50, 55, 438, DateTimeKind.Local).AddTicks(8160), null, null, false, "Mattis, nunc ligula mauris in class interdum, arcu, porttitor eros, enim, aliquam posuere, maximus dui viverra egestas etiam feugiat, bibendum. Proin enim nulla interdum hendrerit praesent molestie quis nec dolor, turpis ac, et, mauris ad nunc, sociosqu congue, quam, torquent. Euismod nec, egestas dui donec posuere auctor, tellus, pretium nisl libero scelerisque dui, sagittis tempus conubia imperdiet duis finibus, blandit.", null, null, 0 },
                    { 6, 7, new DateTime(2023, 11, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(3440), new DateTime(2023, 8, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(3434), new DateTime(2025, 11, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(3445), new DateTime(2023, 11, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(2510), 5, new DateTime(2025, 11, 1, 20, 50, 55, 617, DateTimeKind.Local).AddTicks(3443), null, null, false, "Vehicula interdum sagittis, lobortis vitae convallis suscipit porta, duis eros, nisl nisi, volutpat, faucibus tellus, per id, leo fusce enim. Adipiscing sed auctor, mollis ornare leo vitae phasellus sem porttitor, suspendisse feugiat bibendum, aliquam hac blandit, urna, congue ad tristique. Dictum a, blandit, erat molestie conubia ligula rhoncus fermentum fusce porttitor lectus, lorem porta congue, ante, id class purus elementum.", null, null, 1 },
                    { 7, 8, new DateTime(2023, 11, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(5115), new DateTime(2024, 1, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(5105), new DateTime(2024, 11, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 11, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(3703), 5, new DateTime(2025, 11, 1, 20, 50, 55, 950, DateTimeKind.Local).AddTicks(5125), null, null, false, "Lectus ullamcorper tincidunt sit enim, nostra, justo ad finibus, per hac a lectus, massa gravida tristique elit, ornare sed, torquent. Nam condimentum vel sed, consequat quam, consectetur ante, pretium convallis purus ligula, quis, porta, nisl ut lectus sit pulvinar, tincidunt. Aliquam laoreet, pulvinar lectus, neque, orci, eu, sapien quis molestie primis ligula sodales id, commodo augue bibendum luctus, lacus ullamcorper.", null, null, 1 },
                    { 8, 9, new DateTime(2024, 5, 1, 20, 50, 56, 173, DateTimeKind.Local).AddTicks(817), new DateTime(2023, 11, 1, 20, 50, 56, 173, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 11, 1, 20, 50, 56, 173, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 11, 1, 20, 50, 56, 173, DateTimeKind.Local).AddTicks(31), 5, new DateTime(2024, 11, 1, 20, 50, 56, 173, DateTimeKind.Local).AddTicks(820), null, null, false, "Fames varius a, laoreet fringilla, lacinia, vitae dapibus integer porttitor venenatis vel, lectus a varius, rutrum nostra, tempus eros suspendisse. Gravida sagittis, turpis iaculis ligula, magna, lorem, odio malesuada tortor habitasse vivamus lectus, euismod, efficitur eleifend, quis, fusce odio, laoreet. Pharetra nisi, eleifend tortor quis, imperdiet blandit, sed rutrum urna leo, maecenas interdum egestas tellus, morbi consequat magna, ante posuere.", null, null, 1 },
                    { 9, 10, new DateTime(2024, 1, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 10, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(8498), new DateTime(2025, 11, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(8508), new DateTime(2023, 11, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(7779), 5, new DateTime(2026, 11, 1, 20, 50, 56, 272, DateTimeKind.Local).AddTicks(8507), null, null, false, "Eros ultricies est urna mi, sed, conubia iaculis nec, donec luctus inceptos placerat, quis, vel, cursus, elit rhoncus, dolor, nulla. Nam amet, rutrum vel vel, feugiat, nec adipiscing proin tortor, luctus ligula interdum bibendum blandit, quam vestibulum, eros, posuere, lorem. Odio, habitasse ligula elit, molestie nulla suscipit feugiat eget eleifend ac, tortor, massa, taciti ornare leo sit elit mattis in.", null, null, 1 },
                    { 10, 11, new DateTime(2024, 5, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(6666), new DateTime(2024, 2, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(6659), new DateTime(2024, 11, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(6674), new DateTime(2023, 11, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(5338), 5, new DateTime(2024, 11, 1, 20, 50, 56, 436, DateTimeKind.Local).AddTicks(6670), null, null, false, "Elit, non, fringilla, at ante, dignissim amet vitae proin luctus, rhoncus, ultrices tempor, himenaeos malesuada tellus dapibus augue torquent nec. Ante, vulputate fringilla vitae odio, magna, magna nunc lacus mollis volutpat, sem urna, orci ante feugiat, dolor, id, consectetur hac. Eros, dictumst vivamus neque pellentesque posuere, rhoncus dui, integer ullamcorper morbi dui semper convallis vel, mauris, congue, sagittis luctus aptent.", null, null, 1 },
                    { 11, 12, new DateTime(2024, 4, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(4392), new DateTime(2024, 1, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 11, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(4401), new DateTime(2023, 11, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(2264), 5, new DateTime(2025, 11, 1, 20, 50, 56, 574, DateTimeKind.Local).AddTicks(4396), null, null, false, "Nibh vulputate fringilla, pharetra quis finibus neque, molestie curabitur per nulla turpis eu, porttitor, fusce mi lectus, amet tristique congue. Nec purus lectus, lacinia, litora ac, libero phasellus amet nunc, primis ornare leo convallis tortor ex, amet, orci, eu, pulvinar. Habitasse efficitur ad nec sem, eleifend, nisi, mauris, aliquam magna posuere, placerat luctus, quisque himenaeos arcu vel, at, pharetra platea.", null, 1, 2 },
                    { 12, 13, new DateTime(2024, 2, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(6334), new DateTime(2024, 2, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(6326), new DateTime(2026, 11, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 11, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(5677), 5, new DateTime(2025, 11, 1, 20, 50, 56, 755, DateTimeKind.Local).AddTicks(6336), null, null, false, "Scelerisque lacinia nunc, magna libero nec a ultrices cras dolor varius, id congue maecenas fusce orci, semper ante pellentesque ornare. Vestibulum tincidunt libero mi, lobortis odio, amet lectus, auctor sagittis feugiat, quam, conubia ex ultrices rutrum commodo, rhoncus, porttitor, duis. Fusce enim, a, ac luctus, eleifend, at, justo per odio neque, lobortis iaculis sapien id, nec enim blandit, luctus placerat.", null, 2, 2 },
                    { 13, 14, new DateTime(2024, 5, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(5506), new DateTime(2023, 10, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 11, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 11, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(4150), 5, new DateTime(2026, 11, 1, 20, 50, 57, 21, DateTimeKind.Local).AddTicks(5513), null, null, false, "Congue platea interdum, euismod, urna consequat blandit tempor taciti vitae, id volutpat maximus fringilla tortor nec himenaeos metus at leo. Inceptos metus ac commodo, nibh ac, in sed nisi commodo blandit, ligula, felis congue, class tincidunt sapien suspendisse libero placerat. Congue accumsan ullamcorper arcu, euismod justo neque, sociosqu dolor pharetra eu, fermentum nisi velit pulvinar purus eleifend diam tempus a.", null, 3, 2 },
                    { 14, 15, new DateTime(2024, 3, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 8, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(5435), new DateTime(2025, 11, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(5445), new DateTime(2023, 11, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(4702), 5, new DateTime(2024, 11, 1, 20, 50, 57, 180, DateTimeKind.Local).AddTicks(5442), null, null, false, "Convallis suscipit porta, erat, habitasse scelerisque at dui eros ultricies pretium tempus vestibulum, eros, leo, cras aliquam risus ligula dolor. Tortor, arcu, ullamcorper pulvinar, efficitur vel sem vestibulum, vel, eros, iaculis turpis conubia nec nunc, eu, sit dignissim sed luctus. Convallis ex, tempus magna vitae, fermentum sodales suscipit vel, ante turpis dui scelerisque elit elementum gravida id, class dolor enim.", null, 4, 2 },
                    { 15, 16, new DateTime(2024, 6, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(6514), new DateTime(2023, 9, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(6510), new DateTime(2026, 11, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(6519), new DateTime(2023, 11, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(5834), 5, new DateTime(2025, 11, 1, 20, 50, 57, 281, DateTimeKind.Local).AddTicks(6517), null, null, false, "Enim, sem, duis proin auctor, habitasse amet pulvinar, vivamus nunc, aenean justo porta ut eros, nisl venenatis commodo ac donec. Lacinia metus lectus, posuere ligula, finibus euismod, nulla lorem, proin sed, condimentum aenean fringilla quis, ultrices habitasse ad semper non. Ac, lorem, quis mauris per tristique fames elit phasellus nisl dui feugiat eros eleifend sed cursus maximus odio, egestas aptent.", null, 5, 2 },
                    { 16, 20, new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(2654), new DateTime(2023, 10, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(2649), new DateTime(2024, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(2662), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(2002), 5, new DateTime(2024, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(2660), null, null, false, "Ligula massa, sed id, lacinia, placerat, posuere, quisque mattis, nullam tortor, vivamus porta, laoreet, justo pharetra habitasse a turpis commodo. Eleifend, curabitur varius, in, enim, finibus, massa eros porta, elit, elit odio id dui laoreet, blandit, nisl maecenas pharetra lacinia. Pretium libero vel, diam nisi, nulla, cras gravida elit, non elit lectus ligula, aliquam nullam mattis, urna, at, erat, iaculis.", null, 6, 4 },
                    { 17, 17, new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3258), new DateTime(2023, 9, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3256), new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3261), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(2673), 5, new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3260), null, null, false, "Eu, cras quam, lectus at maecenas non, facilisis posuere, fringilla praesent porttitor, quis, commodo nam nibh ut nostra, mi, ipsum. Felis justo sem velit tortor, class quam inceptos fusce vitae egestas quis, pulvinar, rhoncus, primis enim, eu, fringilla, adipiscing maecenas. Leo, sagittis sit elit per quam, urna, pulvinar, laoreet, accumsan interdum lectus, dictumst mauris, magna ac, urna congue enim lacinia.", null, 7, 4 },
                    { 18, 17, new DateTime(2023, 12, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3908), new DateTime(2023, 10, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3906), new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3910), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3276), 5, new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3909), null, null, false, "Mi, vitae hendrerit etiam aliquam tempus porta platea dolor varius ligula, lobortis euismod consectetur placerat, magna, libero sagittis, id dignissim. Inceptos euismod integer duis ultricies ante urna odio, primis congue vestibulum, eleifend dignissim interdum, rutrum sed, dui, fames mattis, vestibulum. Odio, nisl aenean nostra, morbi scelerisque ex, lectus est pellentesque magna, eros laoreet viverra suscipit tellus, diam vehicula lacus dapibus.", null, 8, 4 },
                    { 19, 16, new DateTime(2024, 5, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(4536), new DateTime(2023, 9, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(4535), new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(4539), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(3917), 5, new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(4538), null, null, false, "Tempor malesuada magna primis pulvinar, et fermentum odio, in, nostra, vivamus amet gravida suspendisse semper auctor, eleifend interdum, felis pretium. Porttitor, tortor nullam sollicitudin fringilla, faucibus ante nulla felis feugiat sapien sodales ipsum morbi leo quam aliquet feugiat, adipiscing diam. Ac, risus lorem est dictum luctus consequat et ipsum consectetur maximus ultrices fringilla rhoncus suscipit vivamus porttitor eros auctor nisi.", null, 9, 4 },
                    { 20, 16, new DateTime(2024, 4, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 10, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5156), new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5160), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(4546), 5, new DateTime(2024, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5159), null, null, false, "Sit tincidunt vestibulum, dolor, imperdiet pulvinar, leo, nunc, commodo himenaeos finibus quisque magna volutpat quis, facilisis duis condimentum habitasse porttitor. Mollis metus malesuada enim euismod, nibh diam laoreet gravida pulvinar tempus enim, elementum fusce lacus odio, est nisl rhoncus, ligula. Tellus, dui tristique condimentum sit lacinia tempor, phasellus quis, nibh ex ornare nunc, taciti laoreet, morbi suspendisse fames tortor, bibendum.", null, 10, 4 },
                    { 21, 18, new DateTime(2024, 5, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5743), new DateTime(2023, 12, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5742), new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5746), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5167), 5, new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5745), null, null, false, "Porta efficitur quis himenaeos nulla dolor, accumsan egestas sapien suspendisse nisi quis, dui lectus, lectus odio mollis aenean tempor lacus. In tortor, at phasellus taciti et, nisl dolor duis luctus, non, massa fringilla, mi, cursus, euismod orci, tempor curabitur interdum. Nibh nibh, vestibulum, sem, risus posuere, tempus convallis blandit tellus, elementum sagittis bibendum, placerat interdum, lacus volutpat, lacinia consectetur nam.", null, 11, 4 },
                    { 22, 18, new DateTime(2024, 4, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 10, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(5753), 5, new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6345), null, null, false, "Porttitor, massa curabitur posuere, eu, placerat, tempus mi at porta, finibus, metus hendrerit pellentesque lacinia, mauris auctor rhoncus, aliquet nullam. Enim, pellentesque fames ex accumsan erat, eleifend curabitur dui, egestas fringilla, eleifend, mi, non, tortor nostra, taciti feugiat, pharetra phasellus. Donec lobortis rhoncus pulvinar, neque laoreet, dolor, risus mattis pretium pellentesque nisi, eleifend, at efficitur feugiat, sagittis, tempus ex leo.", null, 12, 4 },
                    { 23, 19, new DateTime(2024, 2, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6939), new DateTime(2023, 12, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6942), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6353), 5, new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6940), null, null, false, "Eros ut tortor, lectus, est ligula pulvinar enim proin magna eu, tellus vel, in himenaeos fames felis id auctor, vitae. Vel aenean dictum sagittis nisi, feugiat scelerisque posuere, semper lectus congue lectus, volutpat eget rhoncus, praesent ornare sed a consectetur. Mi lobortis suspendisse primis pulvinar, vel viverra placerat mattis orci pulvinar lectus duis enim, mauris varius, phasellus interdum, nisi, sagittis.", null, 13, 4 },
                    { 24, 16, new DateTime(2024, 4, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 10, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(6948), 5, new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(7517), null, null, false, "Justo id, rhoncus enim, tortor sed, dapibus iaculis nullam elit nulla, consequat dictumst erat at volutpat augue at, leo, maecenas. Enim, sociosqu cras phasellus aliquam lorem, scelerisque tristique ultrices lorem quam, donec fermentum est nunc efficitur laoreet morbi tortor posuere. Id, litora posuere, consequat molestie scelerisque tristique commodo, ipsum vestibulum, aenean varius, ligula ex, tincidunt bibendum quisque pulvinar, eros laoreet.", null, 14, 4 },
                    { 25, 17, new DateTime(2024, 2, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 9, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8100), new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(7526), 5, new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8103), null, null, false, "Libero auctor, placerat, sem molestie platea laoreet, lacinia, adipiscing tempor urna, velit metus fringilla massa, vulputate tortor maecenas mollis convallis. Suspendisse bibendum, sollicitudin integer dui, fringilla, ullamcorper luctus, arcu quis, lorem, adipiscing sem, vel, vel fringilla interdum elementum mauris, tempus. Nec, neque lorem, efficitur conubia mauris pharetra viverra arcu eros dui ut odio, varius sem, feugiat, mi, vitae ipsum commodo.", null, 15, 4 },
                    { 26, 16, new DateTime(2024, 4, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 8, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8112), 5, new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8683), null, null, false, "Quis tellus, convallis laoreet, ante, fermentum ligula a, ad eleifend, mauris non, nisi, luctus, tincidunt nisi elit sollicitudin conubia commodo. Ultrices, lacinia mollis class suscipit tempor, fermentum non nam congue nunc, turpis fringilla praesent litora maecenas finibus orci, ultrices cursus. Lacus lacinia, dignissim tempus nec pellentesque nibh amet, nostra, lorem ut magna, fusce convallis ultrices, volutpat, ante, dapibus vel lectus.", null, 16, 4 },
                    { 27, 19, new DateTime(2024, 5, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 2, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9296), new DateTime(2026, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9301), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(8691), 5, new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9300), null, null, false, "Leo hac at, felis interdum, dapibus ligula, elit, blandit, vulputate leo, etiam porta rhoncus lacinia, dolor, orci molestie laoreet a. Eget commodo, id praesent ullamcorper lectus nulla orci, dui, egestas rutrum ornare ultrices dapibus duis accumsan dignissim vestibulum, laoreet proin. Fringilla, vulputate enim, dictumst sodales id, pulvinar eros hac suspendisse dui praesent posuere nulla sem tempus mi, integer venenatis vitae.", null, 17, 4 },
                    { 28, 16, new DateTime(2024, 3, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 10, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9930), new DateTime(2025, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9934), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9307), 5, new DateTime(2024, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9933), null, null, false, "Pulvinar, hac fringilla, ex pretium ornare himenaeos taciti nam scelerisque ante, elementum vulputate mauris nec, mi, nullam ipsum dictumst enim. Interdum dui, laoreet, eget quis litora dictum taciti imperdiet et, magna tempor massa, primis aptent in, neque at nisi, condimentum. Risus quis, phasellus aptent condimentum in sed, ullamcorper pulvinar, sagittis, commodo, ac quam faucibus pulvinar purus scelerisque tempor nunc vitae.", null, 18, 4 },
                    { 29, 16, new DateTime(2024, 2, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 2, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(516), new DateTime(2026, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 11, 1, 20, 50, 57, 371, DateTimeKind.Local).AddTicks(9941), 5, new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(519), null, null, false, "Fermentum sollicitudin commodo, risus ligula vestibulum hendrerit pellentesque primis efficitur fringilla finibus sagittis duis amet, vel porta, mauris praesent porta. Commodo, placerat, efficitur sodales tempor imperdiet tempor, nisl pretium quam, nec nisi, et mi, nec, maximus duis posuere, adipiscing risus. Maximus nisl sem, nunc, ut viverra mattis, nullam dolor suscipit laoreet id, mattis quam, nulla dui luctus, odio, tellus, maecenas.", null, 19, 4 },
                    { 30, 19, new DateTime(2024, 1, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1118), new DateTime(2024, 2, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1116), new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(527), 5, new DateTime(2026, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1119), null, null, false, "Quisque sociosqu congue, eleifend, sem ut metus duis class nisi, faucibus pharetra aliquam tellus orci, condimentum taciti orci vehicula sit. Pretium purus vivamus hac tellus, amet dolor viverra leo in placerat, adipiscing id integer dignissim conubia curabitur mi maximus morbi. Himenaeos morbi elementum nisi, in, eleifend neque, est viverra pretium amet luctus, dolor eu, rhoncus sed ex, libero nisl suscipit.", null, 20, 4 },
                    { 31, 17, new DateTime(2024, 3, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1748), new DateTime(2024, 1, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1746), new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1750), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1128), 5, new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1749), null, null, false, "Commodo pretium tristique nunc vel, imperdiet maecenas platea urna, mollis ac inceptos sagittis dictum a, consequat nisi neque mauris ligula. Turpis ornare ad elit dolor tincidunt cursus quam, lectus lorem quis hac et egestas odio tortor dui euismod erat, a. Placerat, bibendum nunc massa erat efficitur placerat aliquam cras tempus venenatis in, tellus, arcu, cursus elit, nisi, aliquet sit vehicula.", null, 21, 4 },
                    { 32, 17, new DateTime(2024, 4, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 2, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2291), new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(1757), 5, new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2294), null, null, false, "Dictum curabitur posuere, nibh, pellentesque euismod hendrerit libero tellus, aliquet blandit placerat ipsum urna arcu purus lorem, maecenas nisi quam. Elit, semper libero eleifend ultrices, dictum enim, lorem conubia magna curabitur erat sagittis, vivamus luctus, ultricies at a, tellus morbi. Tempus erat habitasse lorem, sodales urna, facilisis faucibus bibendum vulputate sapien tristique cras massa auctor nullam inceptos blandit nulla vestibulum.", null, 22, 4 },
                    { 33, 16, new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2880), new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2303), 5, new DateTime(2026, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2883), null, null, false, "Torquent auctor arcu non, placerat, volutpat turpis faucibus quis, iaculis ligula augue vitae, vel consectetur convallis magna, dui aliquet vulputate. Quisque iaculis porta elementum nec lectus, euismod, congue scelerisque lectus volutpat, maximus aliquet fames leo, enim, faucibus augue elit duis. Ornare interdum, bibendum mattis, a, eget sociosqu conubia mauris, posuere dui, auctor a sed neque efficitur aliquam vivamus convallis condimentum.", null, 23, 4 },
                    { 34, 19, new DateTime(2024, 3, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(3501), new DateTime(2023, 9, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(3500), new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(2899), 5, new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(3503), null, null, false, "Sapien egestas porta, enim hac phasellus eros, mi, dolor, sodales rutrum ligula adipiscing ac, gravida nunc, at, in, nunc per. Tempor suspendisse nisi blandit mollis congue vitae dui ipsum fames lobortis urna pellentesque commodo pretium sociosqu at, felis lorem, imperdiet. Felis dictum aenean nisi, tempus purus finibus id, nibh auctor, arcu, porta phasellus tortor pellentesque cras erat, ac, dictumst a.", null, 24, 4 },
                    { 35, 18, new DateTime(2024, 2, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4118), new DateTime(2023, 8, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4117), new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4121), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(3511), 5, new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4120), null, null, false, "Porttitor, diam magna, dolor, duis platea nisi, tortor, amet mi, aptent vivamus lobortis libero massa, cursus, proin dui, eleifend est. Scelerisque duis ac, nibh, porta laoreet sollicitudin laoreet, nec, non, efficitur vitae auctor tellus faucibus vel, leo, fusce id, in. Suspendisse ex commodo dictum laoreet, porttitor pulvinar, eros, amet, nec, quis vitae, maximus dui, nulla, quisque sed dignissim nostra, posuere.", null, 25, 4 },
                    { 36, 18, new DateTime(2023, 12, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4881), new DateTime(2023, 12, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4879), new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4128), 5, new DateTime(2026, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4883), null, null, false, "Euismod, ipsum sollicitudin sit vehicula eros class ultrices, sodales orci per lectus, mauris, neque, elit leo rutrum commodo, lorem mi. Suspendisse pellentesque laoreet sagittis fames per rhoncus risus a placerat, sagittis, commodo, porta nisi primis sapien feugiat lacinia, blandit nisl. Etiam consequat porta, magna magna, vel velit nisi rhoncus, lacinia fringilla vitae donec tellus, congue quis cursus, lorem malesuada ac.", null, 26, 4 },
                    { 37, 16, new DateTime(2024, 6, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(5504), new DateTime(2023, 9, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(5506), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(4894), 5, new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(5505), null, null, false, "Maximus elit, lacinia volutpat amet, leo, porta, elit pretium quisque duis interdum, ornare vitae, auctor class nec, etiam vel, eu. Condimentum nisi vel eleifend, placerat eu, aliquam a enim, nostra, vitae, erat, torquent leo, sagittis, euismod, mi elementum accumsan aliquet. Fusce proin enim congue litora et, leo, faucibus in cras eu, cursus, porta varius dictum enim, nec inceptos pulvinar, tortor.", null, 27, 4 },
                    { 38, 16, new DateTime(2024, 6, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(6298), new DateTime(2024, 1, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(6296), new DateTime(2026, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(6301), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(5513), 5, new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(6300), null, null, false, "Interdum, arcu morbi mauris, finibus, blandit, sem habitasse fringilla, urna, purus massa, lorem facilisis semper inceptos vel auctor, sociosqu amet. At arcu vitae eu lorem, lobortis congue, morbi porttitor placerat, bibendum, lacus ultrices non, quam ante, fames mi, aliquet ac. Nisi, blandit mattis, semper porta, praesent interdum sagittis arcu, lobortis condimentum congue, class euismod, quis posuere fusce donec taciti vulputate.", null, 28, 4 },
                    { 39, 19, new DateTime(2024, 6, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 2, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7040), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(6311), 5, new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7039), null, null, false, "Arcu, elit, finibus, fusce a, lectus vehicula viverra ornare tortor conubia accumsan ad aliquam bibendum, litora amet auctor, efficitur et. Purus lectus posuere sagittis, fames vulputate lectus, vestibulum, ornare phasellus conubia morbi facilisis dui consequat nec urna duis blandit, egestas. Nulla proin purus placerat sollicitudin rhoncus imperdiet risus amet, ornare tempor, tempor hac fringilla tellus, ante elementum suspendisse vitae interdum.", null, 29, 4 },
                    { 40, 16, new DateTime(2023, 12, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7847), new DateTime(2024, 1, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7845), new DateTime(2026, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7849), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7048), 5, new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7848), null, null, false, "Sed, neque tempor auctor, elit fermentum ad suspendisse maecenas sem, dui, libero class ultricies nisl fusce nec, integer ultrices phasellus. Mattis enim, purus dolor ligula, eros, vel justo vestibulum aliquam ultricies sagittis, sed fusce accumsan lobortis interdum, proin volutpat odio. Vestibulum, euismod ullamcorper turpis velit vestibulum vehicula consectetur sem congue urna nunc sit aliquet id, duis est luctus magna, molestie.", null, 30, 4 },
                    { 41, 16, new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 9, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(8603), new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(8608), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(7857), 5, new DateTime(2024, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(8607), null, null, false, "Iaculis magna, ligula suscipit commodo, adipiscing aenean varius quis, neque aptent nec, et, in vestibulum vitae sem, erat, tristique cursus. Neque tincidunt consequat mi, cras commodo eget porta nibh himenaeos maecenas fringilla, sem tempor, interdum luctus, in aptent condimentum quam. Mauris, nisi, mattis, urna quis, ad varius nec ornare bibendum condimentum vitae, posuere, nibh, eu nostra, erat, euismod, nisi elementum.", null, 31, 4 },
                    { 42, 19, new DateTime(2024, 6, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(9393), new DateTime(2023, 10, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(9391), new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(9396), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(8616), 5, new DateTime(2025, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(9395), null, null, false, "Nulla, fringilla praesent aenean ex, cras pulvinar, conubia mattis, fames orci, amet, dui in tortor, cursus, interdum sed, eleifend, nulla. Condimentum aenean posuere ultrices, lobortis fringilla, iaculis a nec, ultricies leo fermentum tempor, dolor curabitur faucibus vestibulum pharetra euismod, feugiat. Felis quisque venenatis bibendum nibh, risus conubia porta et, ac enim, nostra, mauris, aptent fringilla, primis iaculis mi fusce aliquet.", null, 32, 4 },
                    { 43, 17, new DateTime(2024, 6, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(164), new DateTime(2023, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(168), new DateTime(2023, 11, 1, 20, 50, 57, 372, DateTimeKind.Local).AddTicks(9403), 5, new DateTime(2024, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(166), null, null, false, "Eget odio nibh, varius sed, pretium bibendum, nisi rutrum maximus ultrices, aliquet mattis vitae, molestie luctus laoreet elit, sociosqu tellus. Orci scelerisque magna morbi donec sodales in, pharetra volutpat at, rutrum vulputate eros tempor, proin commodo eleifend cursus, torquent massa. Platea bibendum, quam, donec cursus, et, nec, eu sagittis, tempor, in eleifend vitae fringilla, libero felis feugiat vulputate volutpat lorem.", null, 33, 4 },
                    { 44, 16, new DateTime(2024, 6, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(930), new DateTime(2023, 9, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(928), new DateTime(2025, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(932), new DateTime(2023, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(176), 5, new DateTime(2025, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(931), null, null, false, "Velit ultricies id, tempor tortor tincidunt vel non, id tellus mauris fringilla, suscipit varius, mollis placerat tempor, maecenas leo hendrerit. Leo habitasse nisi, nec odio velit in, et platea ante interdum, cursus, quis, urna, volutpat dictum venenatis pretium placerat, finibus. Eu, mattis, tincidunt hac dictumst non, mauris, id posuere dolor nibh at, posuere, vestibulum, ultrices sapien quisque pulvinar, porta, ante.", null, 34, 4 },
                    { 45, 16, new DateTime(2024, 4, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(1716), new DateTime(2025, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(1720), new DateTime(2023, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(940), 5, new DateTime(2024, 11, 1, 20, 50, 57, 373, DateTimeKind.Local).AddTicks(1719), null, null, false, "Accumsan at, vulputate in, hac torquent nulla inceptos rhoncus feugiat, eros lorem, mollis gravida facilisis nec neque enim suscipit rhoncus. Volutpat et curabitur ultricies non, odio etiam adipiscing pulvinar cras sem, bibendum, efficitur vitae fermentum cursus duis quam, nisl lorem. Eleifend, dapibus non erat molestie elit leo, maecenas morbi commodo, sapien vestibulum, dignissim purus torquent massa bibendum, integer tempor, fermentum.", null, 35, 4 },
                    { 46, 22, new DateTime(2024, 1, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(7598), new DateTime(2023, 9, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(7591), new DateTime(2024, 11, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(7601), new DateTime(2023, 11, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(6957), 5, new DateTime(2026, 11, 1, 20, 50, 57, 720, DateTimeKind.Local).AddTicks(7600), null, null, false, "Dolor mauris, porttitor tempor sodales euismod duis nibh neque, tortor vel mattis rhoncus luctus, dignissim orci tellus pharetra ligula nullam. Sociosqu quam lorem lacus scelerisque enim, sapien semper et consectetur velit elit, ligula, tempor sit ipsum vel, donec ut porttitor. Ullamcorper a, risus semper quam, dictumst sollicitudin mi, varius bibendum, nibh, dapibus mi elit, blandit, erat, magna eros, pulvinar urna.", null, 36, 3 },
                    { 47, 23, new DateTime(2024, 2, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(1883), new DateTime(2023, 10, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(1879), new DateTime(2024, 11, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 11, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(1182), 5, new DateTime(2024, 11, 1, 20, 50, 57, 791, DateTimeKind.Local).AddTicks(1886), null, null, false, "Mollis nunc, hendrerit magna, quam pulvinar odio, tempor elementum ac, donec conubia enim, scelerisque mattis dolor ex, vulputate in tempor. Conubia ex, auctor efficitur mauris turpis amet et convallis inceptos cras purus luctus, interdum, nibh torquent eget laoreet nisi, sit. Quis, sed, mollis quisque nibh lacinia, luctus, sed at, tempus elementum scelerisque amet ac ultricies auctor class vehicula leo, ut.", null, 37, 3 },
                    { 48, 24, new DateTime(2021, 11, 1, 20, 50, 57, 859, DateTimeKind.Local).AddTicks(478), new DateTime(2019, 11, 1, 20, 50, 57, 859, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 11, 1, 20, 50, 57, 859, DateTimeKind.Local).AddTicks(482), new DateTime(2023, 11, 1, 20, 50, 57, 858, DateTimeKind.Local).AddTicks(9822), 5, new DateTime(2022, 11, 1, 20, 50, 57, 859, DateTimeKind.Local).AddTicks(480), null, null, false, "Maecenas dolor posuere ante, luctus proin metus ligula feugiat tristique aenean in ad fringilla, at, nibh odio fermentum nisi, torquent. Eros enim, nisi vitae, vel, suscipit mauris sagittis aenean elementum nam pretium ipsum hendrerit ex, posuere, mattis sapien tincidunt iaculis. Bibendum tortor, placerat, lorem, nam nulla rhoncus auctor mattis, vitae magna, viverra habitasse cras rhoncus, id consequat vel, adipiscing integer.", null, 38, 6 },
                    { 49, 25, new DateTime(2020, 11, 1, 20, 50, 57, 931, DateTimeKind.Local).AddTicks(345), new DateTime(2018, 11, 1, 20, 50, 57, 931, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 11, 1, 20, 50, 57, 931, DateTimeKind.Local).AddTicks(353), new DateTime(2023, 11, 1, 20, 50, 57, 930, DateTimeKind.Local).AddTicks(9273), 5, new DateTime(2022, 11, 1, 20, 50, 57, 931, DateTimeKind.Local).AddTicks(348), null, null, false, "Rutrum lacinia, a, lectus, malesuada vel, mauris, iaculis cursus, condimentum turpis ultrices, arcu ex quam hac ligula nostra, sit bibendum. Arcu, lorem ipsum vitae himenaeos justo pretium suspendisse turpis duis phasellus nisi, est enim odio, fringilla aliquet hac nisl arcu. Ac luctus mattis ex vel consequat fermentum non nam lacinia, orci, sapien consectetur lorem, interdum, hendrerit id, neque, donec tristique.", null, 39, 6 },
                    { 50, 26, new DateTime(2021, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(5513), new DateTime(2018, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(5508), new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(4761), 5, new DateTime(2023, 11, 1, 20, 50, 58, 10, DateTimeKind.Local).AddTicks(5515), null, null, false, "A, facilisis nibh finibus porta lacinia accumsan lectus sem, consectetur mi ex, enim tempor mattis, fusce blandit, mattis risus in. Integer nam congue, leo, egestas a, massa quis tellus iaculis congue est euismod, id finibus, ex, id, enim vitae, nunc. Pretium fames cursus, porta aenean et cursus proin dictum tristique sem, conubia a nec, pulvinar urna, luctus, egestas cras laoreet.", null, 40, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approvers_UserId1",
                table: "Approvers",
                column: "UserId1");

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
                name: "IX_Executors_UserId1",
                table: "Executors",
                column: "UserId1");

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
                name: "IX_Requests_ServerId",
                table: "Requests",
                column: "ServerId",
                unique: true);

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
                name: "IX_ServiceRequests_ApproverId",
                table: "ServiceRequests",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ExecutorId",
                table: "ServiceRequests",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_IpId",
                table: "ServiceRequests",
                column: "IpId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_RequestId",
                table: "ServiceRequests",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ServiceId",
                table: "ServiceRequests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId",
                table: "ServiceRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId1",
                table: "ServiceRequests",
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
                name: "Approvers");

            migrationBuilder.DropTable(
                name: "Executors");

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
                name: "Servers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
