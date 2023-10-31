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
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    InspectionRecordFilePath = table.Column<string>(type: "text", nullable: true),
                    ApproverId = table.Column<int>(type: "integer", nullable: true),
                    ExecutorId = table.Column<int>(type: "integer", nullable: true),
                    ColocationId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Approvers_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "Approvers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalServices_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalServices_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Colocations_ColocationId",
                        column: x => x.ColocationId,
                        principalTable: "Colocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Executors_ExecutorId",
                        column: x => x.ExecutorId,
                        principalTable: "Executors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColocationHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Time = table.Column<int>(type: "integer", nullable: false),
                    DateExtended = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ProposedDateStop = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsAccepted = table.Column<bool>(type: "boolean", nullable: false),
                    ColocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColocationHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColocationHistories_Colocations_ColocationId",
                        column: x => x.ColocationId,
                        principalTable: "Colocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "ColumnCount", "DateCreated", "DateUpdated", "IsDeleted", "Name", "RowCount" },
                values: new object[,]
                {
                    { 1, 8, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(459), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(459), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(469), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(470), false, "B", 5 }
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
                    { new Guid("02b4f422-c8f6-4c13-a09e-67a030ecf697"), 0, "Habitasse/Facilisis, Sapien maecenas rhoncus", "c73ec526-942e-48ac-beb8-3dd90f7fdef5", 0, "molestie@ligula.com", true, "Nunc sagittis convallis", false, false, null, "pretium@eu.com", "customer17", "AQAAAAIAAYagAAAAEJ7ZXRRE01wSCQOqpHEMTEWT9mB2L5TPlGet3HfpRTXyepwjW1i2nosIh/atDuqj8g==", "3267324609", false, "", false, "customer17" },
                    { new Guid("04eace72-2049-47e7-bb4e-0e51c98811cf"), 0, "Nibh/Maecenas, Nisi mi dolor", "bc4fab38-76c5-43cd-ba12-81406c626518", 0, "fermentum@facilisis.com", true, "Sagittis orci proin", false, false, null, "libero@amet.com", "customer24", "AQAAAAIAAYagAAAAEK5fMwkB35uicX+vnvPwu680Kjs4oux+EzO3ZAOZR25dWu8uvkjcuegRYA7vzezlrA==", "1961268789", false, "", false, "customer24" },
                    { new Guid("05a1d4dd-32d6-4b52-b7bf-3a72596017b8"), 0, "Dui/Nec, Vel tempor orci", "5b640d18-e06a-4bb7-9070-c44ffd789e6f", 0, "nulla@ex.com", true, "Diam sollicitudin dolor", false, false, null, "congue@lectus.com", "customer1", "AQAAAAIAAYagAAAAENJ0sXTGjX0PD/lodN7K5hIpjJCQsidYpnoYAk4JKkBU77Ak3bufJr1DVKD2EwP/pg==", "4159083937", false, "", false, "customer1" },
                    { new Guid("0cb57c89-99c8-421b-8ba9-bf3cc3a5246d"), 0, "Mi/Etiam, Vestibulum mi commodo", "35859e5c-7194-44d4-8763-e3798561f6f4", 0, "amet@neque.com", true, "Odio posuere hac", false, false, null, "proin@praesent.com", "customer8", "AQAAAAIAAYagAAAAEHlW+6wePOaCZaS2mlZ4YCpgtPoQyz9M1IWpDm6HNXdkc4Imu5sp5VPDuTrjYQCuZw==", "5423877293", false, "", false, "customer8" },
                    { new Guid("14afab90-b733-4214-8c46-84743d518e01"), 0, "Auctor/Vulputate, Aptent ut metus", "acd56f2d-4fd1-4c9f-99d5-deb58ee37c0a", 0, "diam@amet.com", true, "Dui urna ex", false, false, null, "enim@non.com", "customer2", "AQAAAAIAAYagAAAAENdMEsxkr9ipCHEgHKDk4h2dreFC6UMnrziCO30Fp1tjkskErybSAtG5m83irp4TLQ==", "4229102770", false, "", false, "customer2" },
                    { new Guid("15b83662-4efa-4ad8-9e7e-46766ec7d369"), 0, "Cras/Proin, Volutpat in tellus", "fa4f4ab8-8e4d-4f59-a50c-f7d17c64aa3d", 0, "class@egestas.com", true, "Praesent enim lorem", false, false, null, "dui@sed.com", "customer19", "AQAAAAIAAYagAAAAEESRj1qacLbqIKIv5FggyZA4pNTTqQWTXMIg5Xc0g+TYtqVknUn3EqraJ9uUm5xC4g==", "3663161822", false, "", false, "customer19" },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "420c9ac2-a253-4d9d-b514-fad0444df0d6", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEHHE/oWQCvpaTJoprbo2X/aZ78PlzwsjFqL+kOLsk58Mqbxptvqu5du7fQ9eGtUEpA==", "0000000003", false, "", false, "sale" },
                    { new Guid("22108749-da1d-4152-9a95-37e30ca7bcc2"), 0, "In/Ex, Lectus dui lacinia", "652d79ef-c424-4b98-935e-f5f9631a0751", 0, "lectus@id.com", true, "Convallis molestie rutrum", false, false, null, "fringilla@sapien.com", "customer18", "AQAAAAIAAYagAAAAEK/8ymM468UoXo6PL5FHIOLqXd1GviiTs0BjJafOZXpp6+d2gfO5Hf8NbE9Rn/V0VQ==", "1108228242", false, "", false, "customer18" },
                    { new Guid("25500904-c5d9-4b50-93e6-d8f75ffab0b3"), 0, "Primis/Inceptos, Tellus tempus ut", "119f23fe-aee2-4834-bc17-4860def9336a", 0, "leo@luctus.com", true, "Commodo mattis ante", false, false, null, "dui@et.com", "customer21", "AQAAAAIAAYagAAAAED8nMVSTQtfu0Nd1k4kxPfgYbhOw8ipPartKq9VpUVI8p2MAowK0zSJlp7BD6g95oQ==", "9592727338", false, "", false, "customer21" },
                    { new Guid("279f18de-e04c-4060-9137-8214cd9556ee"), 0, "Donec/Himenaeos, Nisl condimentum curabitur", "18cc3da8-e0a0-4833-8277-4176b647ec88", 0, "torquent@finibus.com", true, "Nisi rhoncus sed", false, false, null, "luctus@luctus.com", "customer25", "AQAAAAIAAYagAAAAEFYVHq6dhtAlM2lBGTP4emBqRipCU+J89QK6dytVUjyuPXzDwBLavHplXWDKrKMR6A==", "9850587718", false, "", false, "customer25" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "777355f4-4fa9-439e-84c4-9221e694f7bd", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAENtzt+vfrGJdpjtgB7NFdKcfFWELLX8GDsevE3M4jjq2hhE2TrKMb9qzkaCM7DJ+dw==", "0000000005", false, "", false, "admin" },
                    { new Guid("289006cf-e8db-4f3d-aad7-16bbce45b0e1"), 0, "Hendrerit/Nostra, Arcu commodo est", "8adf36b0-6187-4e7a-adc0-a6fcd8b85b07", 0, "lacinia@mi.com", true, "Id varius aptent", false, false, null, "torquent@aptent.com", "customer23", "AQAAAAIAAYagAAAAEHptrl5v5AG3ObYoR0VfSjvAQHkS0g23vWletqwKVVtjTrVx1ZSti47t3DhhzvmBug==", "9633933000", false, "", false, "customer23" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "02e0f43a-9229-4ef5-a2ce-6aebd0e0a39a", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAELp3i/cdHcyxXY+7qts8zrtdNYoVT1hbte8qUqLaCKvjoauFQQ4fUsfWF12xPQsJGA==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "4b39c6b1-b383-4c42-bd2a-da20c0d267be", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEJyjUbXMnQ3fEwR60ECwMgoZsWjomsRXRJ6E0NApNv7A4P1L6yOSMP/mOYXtBATVQw==", "0000000002", false, "", false, "tech" },
                    { new Guid("4da1dd71-1c48-4ffc-85bb-e11907279778"), 0, "Pellentesque/Suspendisse, Duis turpis vulputate", "faac5f0d-1de5-483c-bfb5-297dec8610ab", 0, "leo@ultrices.com", true, "Feugiat duis in", false, false, null, "mollis@curabitur.com", "customer20", "AQAAAAIAAYagAAAAEKC5umPZfMZIbhh3wa7HGxbmHAvAf+rqJt4P1oZIV4coHFLNAdBO207NoDtzLnqntA==", "4896541675", false, "", false, "customer20" },
                    { new Guid("4da39ebb-39d6-46aa-9eb2-7db0bf26d9a5"), 0, "Curabitur/Id, Conubia nunc iaculis", "ade5a673-a792-4614-8483-b4b84d2b4b99", 0, "vel@eleifend.com", true, "Primis ex justo", false, false, null, "diam@faucibus.com", "customer10", "AQAAAAIAAYagAAAAEGx7w7qxmMCZ++OCY/VfxRLf1CJIPn24xnaYf37HZutctCH3SVrt9WDonM4LsFmccw==", "6920920895", false, "", false, "customer10" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "a305b789-7010-4662-8fa7-b78f611314c2", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEBcOFTqZfRi4KsQQB6YP2vjDEvFtzJ0b06KHa78KmOWS9qHN7nPrw5njCCcGvIV5hg==", "0000000001", false, "", false, "super" },
                    { new Guid("592eb5cf-a50d-4fc2-a40a-818b8394243a"), 0, "Aliquam/Massa, Purus semper porta", "937346c4-1369-4f72-a5db-6ddfa304422b", 0, "nunc@massa.com", true, "Rutrum tempor non", false, false, null, "fermentum@arcu.com", "customer22", "AQAAAAIAAYagAAAAENFDUqZQEShjs7SnML5yXNJIswOm/Tusn8uZu3R0BAnoTeZlEe5ijJzzs9I75IeMUg==", "1891514702", false, "", false, "customer22" },
                    { new Guid("685ada11-6ac5-4a0a-a301-954bf86ee57e"), 0, "Augue/Nam, Posuere ultrices dolor", "a7a9d1f9-1d1c-4f13-858a-5aed18412d72", 0, "quis@velit.com", true, "Odio lacinia integer", false, false, null, "primis@amet.com", "customer9", "AQAAAAIAAYagAAAAEGu0jtNtqMloZUPbj6t6golOayRTDa039IlmjM8zY9brmNVSmAspiyjMC4CQJcTlZQ==", "8184921998", false, "", false, "customer9" },
                    { new Guid("6beb3622-befa-44cc-be7f-33e1957596b0"), 0, "Nulla/Id, Tellus libero maximus", "48a268ee-8d4f-45ba-bfb8-9baa54f2466e", 0, "nibh@ac.com", true, "Pulvinar nisl class", false, false, null, "dolor@urna.com", "customer4", "AQAAAAIAAYagAAAAEGuCCvC/fi7aiPl/I4P+rkhCc1oANqkFHAVjDDAzIDQmtFU2ykI8tRQJs77WjI0YlQ==", "5982079432", false, "", false, "customer4" },
                    { new Guid("6dd9ec2f-026a-4c1b-a343-07d853dd3042"), 0, "Finibus/Quis, Et in fringilla", "002385b3-b0a8-46bb-9502-ed1126ce3319", 0, "mauris@neque.com", true, "Sed neque euismod", false, false, null, "erat@sit.com", "customer15", "AQAAAAIAAYagAAAAENHlkkx8VaHR7FASlYROwGAKlv9QZ732bh6WFV8JiLwa7Pu4Tmjgzg1fLezgWb/8Cw==", "7341268917", false, "", false, "customer15" },
                    { new Guid("72c79673-9869-43f7-b1e6-4000185b3c5c"), 0, "Arcu/Massa, Ut mollis quis", "9a6a7316-6fce-417a-a776-de8a5e79ea73", 0, "felis@vehicula.com", true, "Adipiscing a in", false, false, null, "himenaeos@volutpat.com", "customer3", "AQAAAAIAAYagAAAAEF8Px/TDx/39r53xSSg+Ah6rZry22hY9kYAHo7wt4wjIx0F/IUlCF6BKu/JSXUP6FA==", "5062376662", false, "", false, "customer3" },
                    { new Guid("7ebb7994-43ac-47dc-8af9-272b6806ac6e"), 0, "Cursus/Eu, Imperdiet vitae orci", "146c9d86-e43e-4a80-8440-44fa733bd2cf", 0, "auctor@eros.com", true, "Vivamus sed ac", false, false, null, "molestie@volutpat.com", "customer14", "AQAAAAIAAYagAAAAEJgz/EqjZRpy300zAzMOP8q2Bwst8MR9oBkCmWzUvzfudYKohaJd0IvTtZh/55G/ow==", "6588429885", false, "", false, "customer14" },
                    { new Guid("8a7a5997-d307-4846-9866-fe3e6626aadf"), 0, "Adipiscing/Justo, Litora venenatis sem", "d085f59e-8b5b-4986-aca7-2ca35e675ebb", 0, "blandit@condimentum.com", true, "Consectetur pharetra magna", false, false, null, "vitae@non.com", "customer11", "AQAAAAIAAYagAAAAEPuD8EuUCV19cAzysxGO3xIQjWAfVX8xIdAbI/R367NK8OthLk1GFmiOiJ1tkKXSkg==", "8632338067", false, "", false, "customer11" },
                    { new Guid("8babf4c3-8dda-486e-badd-d0ef140986c3"), 0, "Nunc/Nostra, Cursus vitae et", "42083ab5-6c3a-4cb4-88b4-e459b3864caa", 0, "mauris@venenatis.com", true, "Metus auctor dictum", false, false, null, "tortor@sagittis.com", "customer7", "AQAAAAIAAYagAAAAECXShzZnhfnQUOGQcAcjmJM/LUJ92w+XvawHMNrQrEUXAeKH7wj/PeTInovCK55r0A==", "6050114747", false, "", false, "customer7" },
                    { new Guid("9126f89e-bcdb-4dab-8064-96ac9e2e3779"), 0, "Mollis/Tellus, Ac torquent nam", "375e73ad-a836-46e8-9238-23923e41169f", 0, "et@at.com", true, "Commodo purus tellus", false, false, null, "luctus@non.com", "customer16", "AQAAAAIAAYagAAAAENLmDs+PrHVHMGvIw9sWx0Zba91iEGxaptoziw88MViXSpBAq33gB1LbHAwfTX3L4g==", "9078328477", false, "", false, "customer16" },
                    { new Guid("94bd967a-1a63-4915-909f-a37f9d8f1ef0"), 0, "Non/Himenaeos, Consequat platea lobortis", "6193174c-0191-443c-9160-3afbece2eb82", 0, "aliquet@mollis.com", true, "Tortor platea morbi", false, false, null, "diam@dictumst.com", "customer12", "AQAAAAIAAYagAAAAEL3Jv0arVgONJOq6hTmF0l0/jfHmcESLIXY3kFX2xqmb4GO6rpmeEU8TtxKVEZBRgA==", "5281038152", false, "", false, "customer12" },
                    { new Guid("ba1ad067-4938-48f1-aad4-229a4a5bd6f8"), 0, "Aliquet/Sagittis, Metus nibh lectus", "f554e8c0-927e-41fb-941d-f105b570ba8e", 0, "neque@cursus.com", true, "Mauris posuere integer", false, false, null, "dolor@arcu.com", "customer6", "AQAAAAIAAYagAAAAEMxTmVF43yHOSeILzCA4lvPuxH3pWBA2YOX5W7eta4NEIsqF2PgCEOkwY/M9p+FAqQ==", "1905480996", false, "", false, "customer6" },
                    { new Guid("eb7335e2-2342-472a-84a3-8855d11992a9"), 0, "Consectetur/Mauris, Posuere molestie litora", "e0100647-b951-41ef-b759-038ea851315b", 0, "purus@per.com", true, "Interdum justo suscipit", false, false, null, "id@pulvinar.com", "customer13", "AQAAAAIAAYagAAAAEIgfUEkC/N/Xa7X0xsLK0mwquGWi164SE9YSx2twa5lh7++X9uFcmFaI/wtWE5SEvw==", "6590621659", false, "", false, "customer13" },
                    { new Guid("eb91f6d5-dea2-4f1c-910f-304ec9be95c3"), 0, "At/Massa, Convallis fames luctus", "c43ccd19-406b-423d-bb4f-f01f4197b672", 0, "sodales@efficitur.com", true, "Vivamus rhoncus sem", false, false, null, "massa@platea.com", "customer5", "AQAAAAIAAYagAAAAELMtWHBFMG1V4AqknyYvpNWDkUUAWfNCDs5fulTA9x5RGxZmg2ToKDGv8Ly67fGEYg==", "2977835807", false, "", false, "customer5" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 22, 59, 50, 0, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 10, 31, 22, 59, 50, 0, DateTimeKind.Local).AddTicks(9977), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(32), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(37), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(42), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(46), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(46), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Type" },
                values: new object[,]
                {
                    { 1, 0, 0, 326, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(86), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(86), false, 6, "Hub" },
                    { 2, 0, 0, 216, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(106), false, 6, "Hub" },
                    { 3, 0, 0, 294, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(110), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(111), false, 5, "Hub" },
                    { 4, 0, 0, 347, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(116), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(116), false, 5, "Hub" },
                    { 5, 0, 0, 247, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(122), false, 7, "Hub" },
                    { 6, 0, 0, 427, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(128), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(128), false, 10, "Hub" },
                    { 7, 0, 0, 356, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(133), false, 8, "Hub" },
                    { 8, 0, 0, 452, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(138), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(139), false, 7, "Hub" },
                    { 9, 0, 0, 292, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(144), false, 10, "Hub" },
                    { 10, 0, 0, 271, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(150), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(150), false, 8, "Hub" },
                    { 11, 0, 0, 342, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(161), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(161), false, 8, "Server" },
                    { 12, 0, 0, 311, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(166), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(167), false, 5, "Server" },
                    { 13, 0, 0, 241, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(172), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(172), false, 7, "Server" },
                    { 14, 0, 0, 342, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(177), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(177), false, 10, "Server" },
                    { 15, 0, 0, 415, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(182), false, 5, "Server" },
                    { 16, 0, 0, 443, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(187), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(187), false, 9, "Server" },
                    { 17, 0, 0, 357, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(192), false, 4, "Server" },
                    { 18, 0, 0, 486, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(198), false, 3, "Server" },
                    { 19, 0, 0, 472, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(203), false, 6, "Server" },
                    { 20, 0, 0, 326, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(208), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(208), false, 2, "Server" },
                    { 21, 0, 0, 445, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(213), false, 4, "Server" },
                    { 22, 0, 0, 207, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(217), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(218), false, 8, "Server" },
                    { 23, 0, 0, 414, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(222), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(223), false, 6, "Server" },
                    { 24, 0, 0, 369, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(228), false, 4, "Server" },
                    { 25, 0, 0, 213, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(233), false, 10, "Server" },
                    { 26, 0, 0, 243, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(238), false, 3, "Server" },
                    { 27, 0, 0, 416, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(243), false, 7, "Server" },
                    { 28, 0, 0, 378, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(330), false, 5, "Server" },
                    { 29, 0, 0, 280, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(335), false, 6, "Server" },
                    { 30, 0, 0, 289, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(341), false, 4, "Server" },
                    { 31, 0, 0, 453, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(345), false, 4, "Server" },
                    { 32, 0, 0, 424, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(350), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(351), false, 10, "Server" },
                    { 33, 0, 0, 392, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(362), false, 10, "Server" },
                    { 34, 0, 0, 449, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(368), false, 4, "Server" },
                    { 35, 0, 0, 270, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(374), false, 3, "Server" },
                    { 36, 0, 0, 216, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(379), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(379), false, 6, "Server" },
                    { 37, 0, 0, 414, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(384), false, 5, "Server" },
                    { 38, 0, 0, 422, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(389), false, 2, "Server" },
                    { 39, 0, 0, 203, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(394), false, 6, "Server" },
                    { 40, 0, 0, 308, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(399), false, 6, "Server" },
                    { 41, 0, 0, 391, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(405), false, 4, "Server" },
                    { 42, 0, 0, 205, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(409), false, 9, "Server" },
                    { 43, 0, 0, 341, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(414), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(415), false, 8, "Server" },
                    { 44, 0, 0, 299, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(419), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(419), false, 3, "Server" },
                    { 45, 0, 0, 457, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(425), false, 10, "Server" },
                    { 46, 0, 0, 349, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(430), false, 5, "Server" },
                    { 47, 0, 0, 238, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(435), false, 2, "Server" },
                    { 48, 0, 0, 226, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(440), false, 8, "Server" },
                    { 49, 0, 0, 431, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(445), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(445), false, 4, "Server" },
                    { 50, 0, 0, 339, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(450), false, 10, "Server" }
                });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1466), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1467), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1474), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(63), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(70), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(75), "Công suất 100", false, "Công suất 100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("02b4f422-c8f6-4c13-a09e-67a030ecf697") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("04eace72-2049-47e7-bb4e-0e51c98811cf") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("05a1d4dd-32d6-4b52-b7bf-3a72596017b8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("0cb57c89-99c8-421b-8ba9-bf3cc3a5246d") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("14afab90-b733-4214-8c46-84743d518e01") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("15b83662-4efa-4ad8-9e7e-46766ec7d369") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("22108749-da1d-4152-9a95-37e30ca7bcc2") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("25500904-c5d9-4b50-93e6-d8f75ffab0b3") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("279f18de-e04c-4060-9137-8214cd9556ee") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("289006cf-e8db-4f3d-aad7-16bbce45b0e1") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4da1dd71-1c48-4ffc-85bb-e11907279778") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("4da39ebb-39d6-46aa-9eb2-7db0bf26d9a5") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("592eb5cf-a50d-4fc2-a40a-818b8394243a") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("685ada11-6ac5-4a0a-a301-954bf86ee57e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("6beb3622-befa-44cc-be7f-33e1957596b0") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("6dd9ec2f-026a-4c1b-a343-07d853dd3042") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("72c79673-9869-43f7-b1e6-4000185b3c5c") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("7ebb7994-43ac-47dc-8af9-272b6806ac6e") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("8a7a5997-d307-4846-9866-fe3e6626aadf") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("8babf4c3-8dda-486e-badd-d0ef140986c3") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("9126f89e-bcdb-4dab-8064-96ac9e2e3779") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("94bd967a-1a63-4915-909f-a37f9d8f1ef0") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("ba1ad067-4938-48f1-aad4-229a4a5bd6f8") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("eb7335e2-2342-472a-84a3-8855d11992a9") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("eb91f6d5-dea2-4f1c-910f-304ec9be95c3") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "super", 1, new DateTime(2023, 10, 31, 22, 59, 52, 151, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 10, 31, 22, 59, 52, 151, DateTimeKind.Local).AddTicks(307), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { 2, "Sem dictum tempus", 3, new DateTime(2023, 10, 31, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(2459), new DateTime(2023, 10, 31, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(2461), false, "1579322124", new Guid("05a1d4dd-32d6-4b52-b7bf-3a72596017b8") },
                    { 3, "Eget nunc aliquam", 4, new DateTime(2023, 10, 31, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(4461), new DateTime(2023, 10, 31, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(4463), false, "1971561453", new Guid("14afab90-b733-4214-8c46-84743d518e01") },
                    { 4, "Fringilla class erat", 2, new DateTime(2023, 10, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(6427), new DateTime(2023, 10, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(6430), false, "2100113135", new Guid("72c79673-9869-43f7-b1e6-4000185b3c5c") },
                    { 5, "Ut commodo sodales", 5, new DateTime(2023, 10, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 10, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(6317), false, "1647352035", new Guid("6beb3622-befa-44cc-be7f-33e1957596b0") },
                    { 6, "Et hac cras", 2, new DateTime(2023, 10, 31, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 10, 31, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(7876), false, "1165416595", new Guid("eb91f6d5-dea2-4f1c-910f-304ec9be95c3") },
                    { 7, "Non curabitur taciti", 4, new DateTime(2023, 10, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(5616), new DateTime(2023, 10, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(5619), false, "347565071", new Guid("ba1ad067-4938-48f1-aad4-229a4a5bd6f8") },
                    { 8, "Class in urna", 3, new DateTime(2023, 10, 31, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(909), new DateTime(2023, 10, 31, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(913), false, "1284691391", new Guid("8babf4c3-8dda-486e-badd-d0ef140986c3") },
                    { 9, "Porttitor mi diam", 4, new DateTime(2023, 10, 31, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 10, 31, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(5024), false, "926005618", new Guid("0cb57c89-99c8-421b-8ba9-bf3cc3a5246d") },
                    { 10, "Ut efficitur vestibulum", 3, new DateTime(2023, 10, 31, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 10, 31, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(6315), false, "1161971219", new Guid("685ada11-6ac5-4a0a-a301-954bf86ee57e") },
                    { 11, "Convallis finibus non", 4, new DateTime(2023, 10, 31, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(5853), new DateTime(2023, 10, 31, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(5856), false, "727290114", new Guid("4da39ebb-39d6-46aa-9eb2-7db0bf26d9a5") },
                    { 12, "Lacinia commodo ut", 4, new DateTime(2023, 10, 31, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 10, 31, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(1601), false, "1649026582", new Guid("8a7a5997-d307-4846-9866-fe3e6626aadf") },
                    { 13, "Placerat eros leo", 5, new DateTime(2023, 10, 31, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 10, 31, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(5068), false, "342905086", new Guid("94bd967a-1a63-4915-909f-a37f9d8f1ef0") },
                    { 14, "Gravida velit ac", 5, new DateTime(2023, 10, 31, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(7869), new DateTime(2023, 10, 31, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(7872), false, "1311474935", new Guid("eb7335e2-2342-472a-84a3-8855d11992a9") },
                    { 15, "Etiam blandit lacinia", 4, new DateTime(2023, 10, 31, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 10, 31, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(3891), false, "155055749", new Guid("7ebb7994-43ac-47dc-8af9-272b6806ac6e") },
                    { 16, "Placerat semper cras", 5, new DateTime(2023, 10, 31, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(4776), new DateTime(2023, 10, 31, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(4779), false, "2003188130", new Guid("6dd9ec2f-026a-4c1b-a343-07d853dd3042") },
                    { 17, "In blandit maecenas", 2, new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(4158), false, "888490490", new Guid("9126f89e-bcdb-4dab-8064-96ac9e2e3779") },
                    { 18, "Placerat euismod lectus", 1, new DateTime(2023, 10, 31, 22, 59, 51, 605, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 10, 31, 22, 59, 51, 605, DateTimeKind.Local).AddTicks(6837), false, "392305649", new Guid("02b4f422-c8f6-4c13-a09e-67a030ecf697") },
                    { 19, "Non hendrerit luctus", 1, new DateTime(2023, 10, 31, 22, 59, 51, 673, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 10, 31, 22, 59, 51, 673, DateTimeKind.Local).AddTicks(6050), false, "1491716908", new Guid("22108749-da1d-4152-9a95-37e30ca7bcc2") },
                    { 20, "Erat porta vel", 2, new DateTime(2023, 10, 31, 22, 59, 51, 741, DateTimeKind.Local).AddTicks(8669), new DateTime(2023, 10, 31, 22, 59, 51, 741, DateTimeKind.Local).AddTicks(8672), false, "1770208946", new Guid("15b83662-4efa-4ad8-9e7e-46766ec7d369") },
                    { 21, "Feugiat fringilla eu", 3, new DateTime(2023, 10, 31, 22, 59, 51, 809, DateTimeKind.Local).AddTicks(9344), new DateTime(2023, 10, 31, 22, 59, 51, 809, DateTimeKind.Local).AddTicks(9347), false, "102800586", new Guid("4da1dd71-1c48-4ffc-85bb-e11907279778") },
                    { 22, "Ipsum mauris tempus", 1, new DateTime(2023, 10, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(4391), new DateTime(2023, 10, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(4393), false, "314559239", new Guid("25500904-c5d9-4b50-93e6-d8f75ffab0b3") },
                    { 23, "Blandit vel ligula", 4, new DateTime(2023, 10, 31, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 10, 31, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(3790), false, "1149113903", new Guid("592eb5cf-a50d-4fc2-a40a-818b8394243a") },
                    { 24, "Fringilla purus posuere", 2, new DateTime(2023, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(7376), false, "104364385", new Guid("289006cf-e8db-4f3d-aad7-16bbce45b0e1") },
                    { 25, "Nullam feugiat vestibulum", 4, new DateTime(2023, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(6437), new DateTime(2023, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(6439), false, "1951920014", new Guid("04eace72-2049-47e7-bb4e-0e51c98811cf") },
                    { 26, "Litora lectus risus", 5, new DateTime(2023, 10, 31, 22, 59, 52, 150, DateTimeKind.Local).AddTicks(9382), new DateTime(2023, 10, 31, 22, 59, 52, 150, DateTimeKind.Local).AddTicks(9385), false, "1158455121", new Guid("279f18de-e04c-4060-9137-8214cd9556ee") }
                });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1483), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1490), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1490), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1495), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1498), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1499), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1502), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1502), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1507), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1507), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1510), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1513), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1514), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1517), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1522), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1525), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1528), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1532), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1535), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1539), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1542), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1545), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1550), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1562), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1565), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1569), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1572), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1576), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1579), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1579), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1582), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1586), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1589), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1592), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1596), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1599), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1603), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1606), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1609), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1614), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1617), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1621), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1624), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1624), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1627), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1627), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1630), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1631), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1634), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1638), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1641), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1641), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1644), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1644), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1648), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1657), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1660), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1663), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1664), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1667), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1667), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1670), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1674), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1677), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1678), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1681), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1681), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1684), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1688), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1691), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1694), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1695), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1700), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1700), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1704), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1704), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1708), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1708), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1711), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1711), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1714), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1715), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1718), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1722), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1725), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1725), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1728), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1728), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1733), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1736), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1736), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1739), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1739), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1748), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1748), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1751), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1752), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1755), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1756), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1759), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1762), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1762), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1765), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1766), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1769), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1769), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1772), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1772), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1776), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1776), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1779), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1779), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1783), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1786), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1786), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1790), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1793), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1793), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1796), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1797), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1800), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1800), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1803), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1807), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1810), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1813), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1814), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1817), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1820), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1824), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1827), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1827), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1830), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1831), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1834), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1834), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1837), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1841), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1850), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1853), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1853), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1857), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1860), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1860), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1863), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1867), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1870), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1873), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1874), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1877), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1877), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1880), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1881), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1884), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1884), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1887), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1887), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1890), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1891), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1894), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1897), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1897), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1901), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1904), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1908), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1911), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1914), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1917), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1918), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1921), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1921), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1924), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1925), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1928), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1928), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1931), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1931), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1935), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1938), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1938), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1950), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1953), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1953), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1957), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1960), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1963), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1966), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1967), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1972), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1972), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1975), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1975), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1978), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1979), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1982), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1985), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1986), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1989), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1989), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1992), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1992), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1995), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1996), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1999), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1999), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2002), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2003), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2006), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2006), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2009), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2009), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2013), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2016), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2016), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2019), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2020), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2032), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2033), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2036), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2040), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2043), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2046), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2046), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2049), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2050), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2053), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2053), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2056), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2056), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2059), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2060), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2063), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2067), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2070), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2073), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2076), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2077), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2080), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2083), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2083), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2087), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2090), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2090), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2093), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2097), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2100), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2100), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2103), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2104), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2107), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2110), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2114), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2117), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2120), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2124), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2132), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2132), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2135), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2135), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2139), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2139), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2142), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2145), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2146), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2149), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2152), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2156), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2156), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2159), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2163), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2166), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2169), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2173), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2176), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2179), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2183), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2186), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2189), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2193), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2196), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2199), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2203), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2206), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2209), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2212), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2213), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2216), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2216), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2219), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2219), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2227), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(474), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(474), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(492), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(500), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(509), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(515), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(523), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(523), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(530), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(537), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(483), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(484), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(494), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(502), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(509), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(517), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(524), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(531), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(531), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(538), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(538), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(485), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(485), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(495), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(495), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(503), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(510), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(518), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(525), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(525), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(532), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(532), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(539), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(486), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(486), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(496), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(496), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(504), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(511), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(519), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(526), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(526), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(533), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(539), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(540), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(487), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(497), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(505), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(505), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(512), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(520), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(527), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(534), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(541), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(489), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(489), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(498), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(506), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(513), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(520), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(521), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(528), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(534), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(534), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(541), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(541), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(490), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(498), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(499), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(507), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(513), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(514), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(521), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(528), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(529), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(535), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(535), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(542), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(542), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(491), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(500), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(507), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(508), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(514), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(514), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(522), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(522), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(529), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(529), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(536), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(536), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(543), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(544), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(544), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(551), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(551), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(560), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(560), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(564), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(565), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(569), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(569), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(573), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(573), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(577), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(582), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(547), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(557), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(561), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(566), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(569), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(570), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(574), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(578), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(582), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(583), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(548), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(548), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(557), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(557), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(562), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(566), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(566), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(570), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(571), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(575), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(579), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(579), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(583), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(583), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(549), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(558), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(558), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(563), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(567), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(567), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(571), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(575), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(576), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(580), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(580), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(584), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(584), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(550), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(559), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(563), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(564), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(568), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(572), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(572), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(576), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(577), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(581), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(585), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(585), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Servers",
                columns: new[] { "Id", "AdditionalNumberOfPort", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "Model", "NumberOfPort", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2235), 11, false, "Pharetra magna tincidunt", 1, "aa11777a-0e00-4eca-a338-5eaf88b556db" },
                    { 2, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2594), 12, false, "Enim cras ante", 1, "3b11010b-c7b9-410b-87ac-795dc3040b50" },
                    { 3, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2847), 13, false, "Duis porttitor consectetur", 1, "a7959cc4-d5a0-4fc0-ba3e-d90bdfad16be" },
                    { 4, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3066), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3067), 14, false, "Sollicitudin fermentum nisl", 1, "45c8bc81-89ed-4232-81dd-c27f6192314e" },
                    { 5, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3311), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3311), 15, false, "Ac risus dictumst", 1, "3fcbdfec-a638-4da5-93f9-020322a66a21" },
                    { 6, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3509), 16, false, "Varius interdum feugiat", 1, "681b8a3e-efd2-42f2-9e8a-38debd933a84" },
                    { 7, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3735), 17, false, "Elementum laoreet nisi", 1, "81bd4e40-aac6-42f5-8003-d6682624986b" },
                    { 8, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3915), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3916), 18, false, "Feugiat posuere bibendum", 1, "f9f6d76b-7278-4e9d-812f-a21b71f37152" },
                    { 9, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4161), 19, false, "Ultrices magna vestibulum", 1, "5e54c042-1283-4954-a7fe-d9195d8de83e" },
                    { 10, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4349), 20, false, "Cras dolor magna", 1, "e9f726bf-2b58-4ed5-9cdb-76cf42c9e804" },
                    { 11, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4532), 21, false, "Amet nostra nibh", 1, "5dca95c7-4280-4a6e-bb10-8b72c9a2d5f2" },
                    { 12, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4745), 22, false, "Class sed semper", 1, "deef40c3-71b2-4308-aeae-2360080e6b74" },
                    { 13, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4931), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4931), 23, false, "Dictumst euismod vitae", 1, "e1aae4d0-1cff-45bc-8a50-0daeb8a934c6" },
                    { 14, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5108), 24, false, "Torquent cras risus", 1, "be5b608f-f882-4412-81c3-2bef35319a10" },
                    { 15, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5315), 25, false, "Ac non arcu", 1, "9bffa297-5ee9-46ff-bd53-3e0d6018e9e6" },
                    { 16, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5511), 26, false, "Ante mauris et", 1, "dd0432a3-0587-41a3-8d17-80bc4b9b5cff" },
                    { 17, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5706), 27, false, "Magna viverra convallis", 1, "7b0c3492-a32e-437f-9c60-b94db79ccd58" },
                    { 18, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5902), 28, false, "Maximus neque porta", 1, "6605b1f1-f079-4ab4-836a-e21f1fb0b4f4" },
                    { 19, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6103), 29, false, "Habitasse sagittis rhoncus", 1, "828ef34e-d8c2-4247-bb71-2ce7ae2de92a" },
                    { 20, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6284), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6284), 30, false, "Tellus viverra orci", 1, "f81973d4-fbfb-4b73-b52a-01e95d3de495" },
                    { 21, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6490), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6490), 31, false, "Tristique tortor enim", 1, "3cb1309b-d2e8-40dd-a727-766d45f05e2c" },
                    { 22, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6663), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6663), 32, false, "Ut orci non", 1, "6f93d8f4-df2e-4973-a284-8a83db1e14be" },
                    { 23, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6863), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6863), 33, false, "Mollis gravida dignissim", 1, "68b0add4-dd9e-4df9-b810-34ed735b2ac3" },
                    { 24, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7073), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7074), 34, false, "Ante lectus mattis", 1, "cbc93601-18f9-4c70-ac8a-c7d6b0a64bbd" },
                    { 25, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7319), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7320), 35, false, "Blandit ornare tempor", 1, "a3712761-5be0-4c97-9ee6-31b9d74c3f14" },
                    { 26, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7514), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7515), 36, false, "Hac dictum velit", 1, "4f50f0cf-1b36-4a83-9ecb-f126129b18c3" },
                    { 27, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7722), 37, false, "Sem est luctus", 1, "bd50df4e-cfca-4821-a420-ea11179da6ef" },
                    { 28, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7950), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7951), 38, false, "Iaculis interdum aliquet", 1, "080e93cc-8963-4fa5-a545-d9a49c598006" },
                    { 29, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8162), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8162), 39, false, "Id quam vel", 1, "eb1f2c6d-71b0-4842-a129-04a96860d488" },
                    { 30, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8367), 40, false, "Ipsum vel sed", 1, "d9a4dd04-5b4a-4e54-999b-0896b11f53bf" },
                    { 31, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8583), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8584), 41, true, "Nisi pellentesque ex", 1, "54535d68-543b-47b5-8290-b0d63f369365" },
                    { 32, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8789), 42, true, "Libero tortor rutrum", 1, "589cad2a-369a-4439-a8f7-0db50707e1c2" },
                    { 33, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9013), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9013), 43, false, "Massa erat leo", 1, "8e1818bd-552a-4910-8458-8119dfecb11f" },
                    { 34, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9268), 44, false, "Phasellus commodo ad", 1, "0ee660e1-a8ec-48ef-8273-52f8faaf0910" },
                    { 35, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9489), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9489), 45, false, "Fermentum et litora", 1, "891b715c-3255-4406-9183-257653f67119" },
                    { 36, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9669), 46, false, "Commodo posuere porttitor", 1, "7433e9ef-5c76-4189-9305-b6219173bede" },
                    { 37, 0, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9867), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9868), 47, false, "Semper viverra hac", 1, "d99c3997-d917-4f7a-aadc-373380e96f9e" },
                    { 38, 0, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(57), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(57), 48, false, "Erat convallis rutrum", 1, "f77f89ae-b8e6-4499-b5c4-fc363d4aa3b8" },
                    { 39, 0, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(320), 49, false, "Est pulvinar sociosqu", 1, "647c8bc1-a4b4-45c7-8c55-54e390570d10" },
                    { 40, 0, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(525), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(525), 50, false, "Dui lacus leo", 1, "b3a6d429-2a34-4bf8-b37b-de9aa96f2f78" }
                });

            migrationBuilder.InsertData(
                table: "Colocations",
                columns: new[] { "Id", "CustomerId", "DateAllocate", "DateCreated", "DateStop", "DateUpdated", "ExpectedSize", "InitialDateStop", "InspectionRecordFilePath", "InspectorNote", "IsDeleted", "Note", "ReceiptOfRecipientFilePath", "ServerId", "Status" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 4, 30, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(3399), new DateTime(2023, 7, 31, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(3395), new DateTime(2025, 10, 31, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(3403), new DateTime(2023, 10, 31, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(2686), 5, new DateTime(2026, 10, 31, 22, 59, 50, 465, DateTimeKind.Local).AddTicks(3401), null, null, false, "Suspendisse pellentesque class magna, ligula sodales phasellus efficitur nibh, dolor praesent sit diam aliquam ante nunc ut aenean neque dapibus. Massa eu nostra, imperdiet ipsum nisi lectus, cursus arcu, in, porttitor, nec sem, justo odio, felis ex, sociosqu integer enim. Volutpat habitasse vitae, orci, ad tellus, luctus, fringilla, eu ex, at et commodo, accumsan dolor, aliquam litora augue rhoncus torquent.", null, null, 0 },
                    { 2, 3, new DateTime(2024, 4, 30, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 11, 30, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(5390), new DateTime(2025, 10, 31, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(5399), new DateTime(2023, 10, 31, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(4667), 5, new DateTime(2026, 10, 31, 22, 59, 50, 539, DateTimeKind.Local).AddTicks(5397), null, null, false, "Ante porttitor a, nisi nibh orci, ac non, aliquet neque, congue himenaeos donec ultrices, tincidunt ligula taciti finibus, maximus lorem. Viverra sociosqu porttitor ligula, ultrices, sed maecenas augue tellus purus tempus duis conubia accumsan dui ullamcorper justo semper quam, felis. Magna, nam rutrum lorem, phasellus lobortis amet molestie dapibus lacinia lorem ligula donec elit arcu, ac congue, sapien lectus nisi.", null, null, 0 },
                    { 3, 4, new DateTime(2024, 3, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 7, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(7925), new DateTime(2026, 10, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 10, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(6643), 5, new DateTime(2026, 10, 31, 22, 59, 50, 617, DateTimeKind.Local).AddTicks(7940), null, null, false, "Odio, a auctor blandit eu tortor, metus integer vel ex blandit, scelerisque habitasse tristique mauris, eleifend ante, luctus gravida ad. Leo, laoreet, vitae, felis mattis vitae efficitur bibendum ex, nostra, ultrices varius sit conubia lectus platea consectetur sapien porttitor ullamcorper. Nulla, a enim, tincidunt non urna, iaculis aptent litora nec, eu, mattis ac odio nullam laoreet mauris ornare egestas euismod.", null, null, 0 },
                    { 4, 5, new DateTime(2024, 5, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(7292), new DateTime(2023, 8, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(7287), new DateTime(2025, 10, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 10, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(6539), 5, new DateTime(2026, 10, 31, 22, 59, 50, 687, DateTimeKind.Local).AddTicks(7294), null, null, false, "Quam, porttitor, sodales odio, vulputate justo aliquam mi semper dolor, ultricies gravida ullamcorper leo pretium massa, interdum, lorem, class tortor. Odio, ornare eu, ultrices facilisis quam orci leo justo nibh, suscipit velit luctus commodo, dui eros mauris tellus non, curabitur. Volutpat urna ante tempor, scelerisque erat urna, sem, magna est ex nisi, nostra, blandit, sed, purus elit, consectetur vestibulum aliquam.", null, null, 0 },
                    { 5, 6, new DateTime(2024, 2, 29, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 9, 30, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 10, 31, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 10, 31, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(8114), 5, new DateTime(2024, 10, 31, 22, 59, 50, 771, DateTimeKind.Local).AddTicks(8795), null, null, false, "Ante sapien quis, odio quisque tempus eros, primis vestibulum ultrices, urna, commodo luctus, enim nam mi, porttitor tincidunt dolor, auctor. Ultrices eu laoreet, arcu mauris praesent diam egestas mattis, tempus arcu, scelerisque id sed, blandit lobortis dictum enim pulvinar, morbi. Lacinia pretium ante sollicitudin massa libero tellus lacinia, eu quam placerat, nulla varius, laoreet platea neque, nisi nunc, integer sagittis.", null, null, 0 },
                    { 6, 7, new DateTime(2023, 12, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(6517), new DateTime(2024, 1, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(6512), new DateTime(2025, 10, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(6522), new DateTime(2023, 10, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(5847), 5, new DateTime(2024, 10, 31, 22, 59, 50, 840, DateTimeKind.Local).AddTicks(6520), null, null, false, "Neque hac fusce interdum, convallis phasellus malesuada eget elit, ultricies auctor, nibh, dolor, amet, in euismod, adipiscing odio, ultrices, vehicula. Maximus leo sed, lacus elit ornare placerat, curabitur nunc, tortor aenean praesent sagittis laoreet neque, euismod, tellus volutpat ultrices hac. Quam nisi massa nam auctor, dui, fermentum scelerisque auctor nibh blandit laoreet, sed nec, euismod dui rhoncus, velit aenean sapien.", null, null, 1 },
                    { 7, 8, new DateTime(2023, 11, 30, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(1926), new DateTime(2023, 7, 31, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(1921), new DateTime(2025, 10, 31, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(1931), new DateTime(2023, 10, 31, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(1127), 5, new DateTime(2026, 10, 31, 22, 59, 50, 910, DateTimeKind.Local).AddTicks(1929), null, null, false, "Sagittis etiam enim eros fames sodales laoreet massa urna magna, sapien consequat ligula, viverra litora augue mattis pellentesque mi, est. Erat dictumst finibus bibendum, sed eu, ultricies lacus turpis pulvinar ligula ante, elementum ac placerat ornare amet, urna, rhoncus orci. Id interdum tellus, cursus, volutpat orci pulvinar primis lacinia praesent venenatis nibh fringilla, diam facilisis nunc, ultrices, taciti sit massa.", null, null, 1 },
                    { 8, 9, new DateTime(2024, 4, 30, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(6010), new DateTime(2023, 8, 31, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(6006), new DateTime(2025, 10, 31, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(6015), new DateTime(2023, 10, 31, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(5242), 5, new DateTime(2025, 10, 31, 22, 59, 50, 978, DateTimeKind.Local).AddTicks(6013), null, null, false, "Rutrum porta, dictum tempus arcu duis dui elit, nulla aliquet sollicitudin iaculis imperdiet dapibus vel, lorem, luctus interdum, enim consequat. Faucibus ligula, libero feugiat cras duis feugiat, porta tempor lectus, fusce neque orci integer urna, lacus elementum congue, placerat dui. Eget hendrerit nec, mauris, curabitur massa, torquent mattis luctus, sagittis praesent pulvinar porttitor volutpat, adipiscing eros, congue blandit, ullamcorper porta.", null, null, 1 },
                    { 9, 10, new DateTime(2024, 5, 31, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(7402), new DateTime(2023, 11, 30, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(7397), new DateTime(2025, 10, 31, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(7407), new DateTime(2023, 10, 31, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(6595), 5, new DateTime(2024, 10, 31, 22, 59, 51, 49, DateTimeKind.Local).AddTicks(7405), null, null, false, "Tellus, ut viverra donec id facilisis imperdiet tortor, in, neque, ante amet torquent leo, lacinia aptent nam quam, non dapibus. Ultrices, magna fringilla enim, dui, lectus, ex, ornare eu adipiscing magna, tempus arcu erat varius fames ac placerat pretium ipsum. Vitae, finibus, nullam hac cras id sit consectetur auctor vehicula accumsan mauris eleifend arcu, leo enim condimentum vulputate blandit posuere.", null, null, 1 },
                    { 10, 11, new DateTime(2024, 4, 30, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(6714), new DateTime(2023, 9, 30, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 10, 31, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(6718), new DateTime(2023, 10, 31, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(6075), 5, new DateTime(2025, 10, 31, 22, 59, 51, 126, DateTimeKind.Local).AddTicks(6716), null, null, false, "Sem, finibus, nec, aliquet et, pharetra proin feugiat, nisi, sodales morbi orci, aliquam dictum orci nisl semper habitasse euismod, euismod. Placerat, congue amet quis, commodo, erat interdum lectus, dignissim volutpat nulla, elit non, per pulvinar, luctus, rutrum nunc platea ullamcorper. Elementum suspendisse vitae, congue, at, tortor in placerat, mattis enim, ad tellus, ligula, laoreet lorem, vivamus primis ac, massa, odio.", null, null, 1 },
                    { 11, 12, new DateTime(2023, 12, 31, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 9, 30, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(2644), new DateTime(2025, 10, 31, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 10, 31, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(1829), 5, new DateTime(2026, 10, 31, 22, 59, 51, 195, DateTimeKind.Local).AddTicks(2651), null, null, false, "Cras cursus, eu euismod, congue, in nibh finibus, sem justo sociosqu fringilla, purus vestibulum, quam, in, a, donec curabitur orci. Feugiat eu ad sem commodo, efficitur amet, quisque faucibus nibh iaculis imperdiet massa, odio, ex, quis mauris rhoncus, dui, porta. Morbi tempor quis vulputate magna accumsan tincidunt eu, litora varius, non suscipit in per vel, torquent suspendisse platea eros facilisis.", null, 11, 2 },
                    { 12, 13, new DateTime(2023, 11, 30, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 11, 30, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(6278), new DateTime(2026, 10, 31, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(6287), new DateTime(2023, 10, 31, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(5374), 5, new DateTime(2025, 10, 31, 22, 59, 51, 263, DateTimeKind.Local).AddTicks(6285), null, null, false, "Vitae, vitae diam placerat, interdum nisi congue, sagittis ligula mi porta dictumst torquent eleifend, felis mollis orci nisl lacus volutpat. Duis tristique vel auctor, ultricies ante lacinia at sem, dui, eleifend ex, tempus cursus, placerat venenatis integer urna, enim, taciti. Magna, bibendum, mi, curabitur ante in purus commodo, semper rhoncus, at, metus nullam iaculis placerat tortor, nam venenatis pretium placerat.", null, 12, 2 },
                    { 13, 14, new DateTime(2023, 12, 31, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(9059), new DateTime(2023, 11, 30, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(9055), new DateTime(2025, 10, 31, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(9063), new DateTime(2023, 10, 31, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(8215), 5, new DateTime(2025, 10, 31, 22, 59, 51, 331, DateTimeKind.Local).AddTicks(9062), null, null, false, "Ad cursus, massa, ornare nisl metus porta, quisque egestas fames dapibus interdum ultricies mattis vitae, in, ante vel, at, pellentesque. A, elit, ultrices bibendum, placerat, ante curabitur lacus augue primis ligula platea venenatis lorem, vestibulum pharetra nunc nec, per placerat. Arcu, finibus, purus lacinia, vulputate volutpat neque, sollicitudin quisque elit, elementum pretium congue, tellus, orci dolor fringilla, mi, auctor, est.", null, 13, 2 },
                    { 14, 15, new DateTime(2023, 11, 30, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(4775), new DateTime(2023, 11, 30, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 10, 31, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 10, 31, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(4119), 5, new DateTime(2024, 10, 31, 22, 59, 51, 400, DateTimeKind.Local).AddTicks(4777), null, null, false, "Nulla, nam vel, mattis, massa a, varius nunc lacinia porttitor, nec, fermentum dui eros, purus vivamus erat, sodales ultrices vestibulum. Blandit ligula dictum mauris class elit donec venenatis aliquam metus posuere, quisque diam vivamus accumsan leo, sollicitudin himenaeos praesent fusce. Rutrum mauris hac urna, laoreet, at, nam dignissim sollicitudin luctus blandit, tempor posuere, interdum bibendum ullamcorper ultricies ante bibendum, non.", null, 14, 2 },
                    { 15, 16, new DateTime(2024, 2, 29, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 1, 31, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(5761), new DateTime(2026, 10, 31, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(5770), new DateTime(2023, 10, 31, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(5008), 5, new DateTime(2026, 10, 31, 22, 59, 51, 468, DateTimeKind.Local).AddTicks(5768), null, null, false, "Tellus diam vehicula finibus, platea dictumst quam hac commodo vulputate convallis facilisis class massa massa, neque, ligula odio pellentesque mauris. Fringilla posuere, aliquam praesent eu, integer malesuada vulputate euismod, finibus bibendum quisque nullam pharetra turpis ad torquent a, volutpat sed. Condimentum fringilla, pellentesque feugiat, in sapien felis nisi aenean aliquet dictumst molestie congue blandit, magna sollicitudin cursus, eros, luctus, feugiat.", null, 15, 2 },
                    { 16, 16, new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 1, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5156), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(4362), 5, new DateTime(2026, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5154), null, null, false, "Sem viverra tellus, mauris ac, pulvinar, bibendum, efficitur semper libero cursus enim dictum ut nec luctus, condimentum interdum fusce rutrum. Sagittis, finibus, nisl nunc, praesent nibh urna, ante, convallis eleifend fermentum interdum suspendisse varius, finibus bibendum at auctor, integer nullam. Ac a, nisi bibendum pharetra etiam ad vestibulum vulputate ante iaculis proin donec efficitur finibus neque, maximus pulvinar, blandit, ligula.", null, 16, 4 },
                    { 17, 16, new DateTime(2024, 5, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 12, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5819), new DateTime(2025, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5171), 5, new DateTime(2025, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5823), null, null, false, "Euismod litora dolor ultrices, hendrerit torquent varius auctor, ut ex vivamus odio elementum himenaeos gravida dapibus ex, nunc taciti id. Eros, sagittis auctor, in, convallis massa, sociosqu lectus, massa quis tellus, risus rhoncus, conubia neque luctus magna sem gravida nec. Vel condimentum nullam augue erat eget vulputate est mauris, bibendum eu, commodo vel, posuere, eros sem, tempor, elit cursus, ligula.", null, 17, 4 },
                    { 18, 20, new DateTime(2024, 2, 29, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(6419), new DateTime(2023, 7, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(6417), new DateTime(2025, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(6422), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(5837), 5, new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(6420), null, null, false, "Enim, taciti ultrices cras non erat est odio, lectus, himenaeos tempor, mattis a ligula, auctor, aliquet blandit tincidunt neque ante. Mi erat, taciti sit a auctor massa ligula est nec, nullam cras fermentum laoreet sem, dui turpis mattis, vel, ultrices. Himenaeos rhoncus, sed, tristique massa nisi curabitur nostra, rutrum fermentum suspendisse porta, sit lacinia, ultrices, tempus mattis erat quam mauris.", null, 18, 4 },
                    { 19, 20, new DateTime(2024, 3, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 1, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7093), new DateTime(2025, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7098), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(6429), 5, new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7096), null, null, false, "Non, ante, donec tempor, diam purus sociosqu placerat lectus sem quis torquent lorem amet, faucibus vitae lectus, ultrices, vestibulum et. Mi, viverra himenaeos porta, egestas risus congue, enim, magna neque mi ex, semper elit torquent tellus euismod volutpat ullamcorper litora. Tellus, maecenas consequat tortor feugiat eu semper non, dictumst sapien pulvinar nibh vel, porta, aptent elit dapibus justo nisi sociosqu.", null, 19, 4 },
                    { 20, 18, new DateTime(2024, 3, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7832), new DateTime(2023, 8, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7830), new DateTime(2026, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7835), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7114), 5, new DateTime(2025, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7834), null, null, false, "Egestas lorem, magna, tortor, elit blandit, quam urna, accumsan rutrum orci, congue, rhoncus in cursus posuere, purus porttitor, ultrices et. Vitae luctus, elementum feugiat aliquet ex, nam ultricies in id, magna, porttitor fringilla, vivamus a, lacus quam inceptos eu, volutpat. Nisl finibus vitae neque, eu a, lorem nam porta, curabitur rutrum congue porttitor rhoncus, mi aenean nec, turpis ac arcu.", null, 20, 4 },
                    { 21, 19, new DateTime(2024, 4, 30, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(8413), new DateTime(2023, 7, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(8411), new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(8416), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(7844), 5, new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(8414), null, null, false, "Dictum felis a, risus aenean ad neque, libero porttitor sapien egestas sociosqu enim mi primis bibendum, auctor dignissim rhoncus, lorem. Nostra, quam, placerat lacinia lorem, tellus, sollicitudin bibendum lectus sagittis, commodo, pretium diam rutrum volutpat quis dignissim velit tortor, torquent. Efficitur consequat rhoncus, volutpat, tellus, laoreet iaculis interdum faucibus tristique quam, lobortis adipiscing amet egestas bibendum himenaeos sem, elit, eu.", null, 21, 4 },
                    { 22, 17, new DateTime(2023, 12, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 9, 30, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9067), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(8422), 5, new DateTime(2026, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9066), null, null, false, "Risus sed, vivamus neque mollis augue tristique dui, velit vestibulum, sollicitudin curabitur vitae, dui volutpat congue, fermentum nec, magna quis. Pretium mattis, dui feugiat sagittis, vestibulum leo dui, et, elit molestie rhoncus et orci, maecenas neque urna lorem libero elit. Pulvinar congue, nisl cras metus donec bibendum, odio, molestie et at, enim, morbi euismod, vel nibh sagittis, hendrerit risus augue.", null, 22, 4 },
                    { 23, 16, new DateTime(2024, 5, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 1, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9644), new DateTime(2025, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9074), 5, new DateTime(2024, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9647), null, null, false, "Nulla, nec sem, elit fusce tempor, arcu, risus nec, metus urna efficitur odio, sagittis eros, interdum, erat eget condimentum egestas. Ipsum orci quam dictum est erat, nisi vitae, quis, porttitor nisi, quam, vitae feugiat ultrices posuere, mi sodales sem, pulvinar. Placerat, lorem suscipit eros auctor condimentum elit eu praesent conubia enim, sapien luctus, quis, sagittis, non aliquet ultrices nibh proin.", null, 23, 4 },
                    { 24, 20, new DateTime(2024, 1, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 8, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 10, 31, 22, 59, 51, 536, DateTimeKind.Local).AddTicks(9655), 5, new DateTime(2025, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(278), null, null, false, "Feugiat, luctus ac hac cursus pulvinar velit vivamus iaculis phasellus elit, condimentum eros sed, scelerisque taciti dictum commodo tempus justo. Ultrices, quam, platea eleifend, rhoncus vitae, pellentesque luctus venenatis vivamus varius, lobortis in, imperdiet auctor lectus finibus, ex, orci, mollis. Feugiat, iaculis dapibus quam orci, nostra, vitae, sagittis, nisi, ex, consequat neque nec egestas nulla, ultrices, eu, arcu, interdum mauris.", null, 24, 4 },
                    { 25, 20, new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(919), new DateTime(2023, 12, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(918), new DateTime(2026, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(923), new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(286), 5, new DateTime(2026, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(921), null, null, false, "Lacinia, vivamus nisi, et elit, non, varius, ipsum leo erat feugiat, id pharetra class enim, mi, porttitor, vestibulum nec, quis. Nulla, sagittis, ex, eleifend, luctus hac phasellus volutpat neque, inceptos tristique odio mattis arcu justo lacinia, primis tempor rhoncus condimentum. Interdum nam auctor, posuere, tellus, finibus, mauris vivamus pulvinar eros euismod, ante, volutpat, conubia pulvinar, maximus congue amet dolor libero.", null, 25, 4 },
                    { 26, 19, new DateTime(2024, 3, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 7, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(1573), new DateTime(2025, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(931), 5, new DateTime(2024, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(1576), null, null, false, "Ipsum finibus varius, congue, odio, lectus metus elit integer praesent tempor, quis, nullam est consectetur tincidunt mauris, nostra, aliquet malesuada. Est eleifend, eros eleifend at ligula aptent eros, et placerat, gravida arcu dolor, eget mi tempor, magna nibh, arcu, ante. Vivamus in torquent viverra urna eget class orci a rhoncus, fringilla, nibh enim cursus, massa, curabitur fames ornare vitae, lectus.", null, 26, 4 },
                    { 27, 17, new DateTime(2024, 5, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(2437), new DateTime(2023, 7, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(2435), new DateTime(2026, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(2440), new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(1584), 5, new DateTime(2024, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(2438), null, null, false, "Mi, mollis arcu dictum torquent tempor, viverra pharetra posuere suspendisse metus blandit id tristique sed morbi nisi imperdiet enim elit. Posuere, fringilla a justo ligula ligula, laoreet, sed egestas lacinia leo, sem, et mauris sapien placerat, etiam consequat urna per. Suscipit est lorem, vestibulum porttitor mauris, ac, facilisis nibh tortor, accumsan morbi curabitur auctor, ex conubia maecenas nibh, tempor, amet.", null, 27, 4 },
                    { 28, 20, new DateTime(2024, 3, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 8, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(2449), 5, new DateTime(2025, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3196), null, null, false, "Blandit arcu, nisl aenean ultrices, class integer phasellus vitae, proin auctor, vitae per non, lobortis maximus finibus, fusce neque fringilla. Risus at aenean finibus vitae, dignissim purus congue commodo laoreet hac et mollis dolor cursus, amet porta bibendum tempor, nec. Eu, ultrices, phasellus amet, ligula, suspendisse maecenas auctor risus habitasse gravida curabitur nostra, enim porttitor, erat, mauris, imperdiet tempor finibus.", null, 28, 4 },
                    { 29, 16, new DateTime(2024, 3, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 9, 30, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3948), new DateTime(2026, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3205), 5, new DateTime(2025, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3951), null, null, false, "Ut placerat, mauris, pretium id, nunc, sagittis proin dui volutpat sollicitudin molestie vulputate arcu inceptos neque, efficitur metus habitasse eros. Sit finibus, curabitur ante, sed, id, ultrices vestibulum, feugiat, varius malesuada quisque libero pulvinar metus orci, eu, orci sagittis enim. Nam facilisis fringilla leo blandit aenean mauris torquent varius dictumst euismod nisl sapien phasellus ante libero pulvinar, neque, per hendrerit.", null, 29, 4 },
                    { 30, 18, new DateTime(2024, 4, 30, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 7, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(4815), new DateTime(2026, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(3961), 5, new DateTime(2025, 10, 31, 22, 59, 51, 537, DateTimeKind.Local).AddTicks(4819), null, null, false, "Ac, consequat et blandit, varius, litora nulla odio, amet vestibulum vivamus luctus, rhoncus eu placerat, sagittis, nunc, adipiscing commodo, donec. Porta a aliquam neque adipiscing auctor ipsum felis accumsan in, rhoncus conubia metus inceptos fringilla, ex nullam quisque fermentum in. Cursus, id, nibh habitasse euismod, platea aenean finibus, lectus, nibh, nisi, lacus neque, euismod consequat odio, elit, blandit arcu eleifend.", null, 30, 4 },
                    { 31, 22, new DateTime(2024, 1, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(5242), new DateTime(2023, 8, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(5238), new DateTime(2025, 10, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 10, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(4603), 5, new DateTime(2026, 10, 31, 22, 59, 51, 878, DateTimeKind.Local).AddTicks(5244), null, null, false, "Massa, et, ligula, volutpat eros himenaeos dapibus volutpat, lacus mauris interdum luctus, hendrerit nec donec sapien vitae, eleifend, odio, arcu. Curabitur sit mattis finibus, ligula praesent neque mauris, augue euismod, pulvinar, eros nisl vel, faucibus eleifend enim molestie risus sapien. Finibus posuere leo sollicitudin volutpat adipiscing finibus, fames ex, eu cursus orci, laoreet malesuada dui sem, himenaeos fringilla magna, ligula.", null, 31, 3 },
                    { 32, 23, new DateTime(2023, 11, 30, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(4680), new DateTime(2023, 11, 30, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(4673), new DateTime(2025, 10, 31, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(4685), new DateTime(2023, 10, 31, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(4000), 5, new DateTime(2026, 10, 31, 22, 59, 51, 946, DateTimeKind.Local).AddTicks(4683), null, null, false, "Interdum rhoncus lobortis vel mauris posuere, vel, venenatis hendrerit faucibus rhoncus, imperdiet ex eleifend, turpis sagittis, egestas ligula, tortor, et. Efficitur integer imperdiet ullamcorper molestie neque auctor orci curabitur lorem bibendum, dictum massa, suscipit dolor, et, facilisis congue libero nisl. Luctus, feugiat, vitae, semper amet, fusce est risus inceptos placerat, urna pharetra ad volutpat, metus a, bibendum, fames ornare ante.", null, 32, 3 },
                    { 33, 24, new DateTime(2021, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(8236), new DateTime(2018, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(8231), new DateTime(2022, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(7567), 5, new DateTime(2023, 10, 31, 22, 59, 52, 14, DateTimeKind.Local).AddTicks(8238), null, null, false, "Auctor ultrices, diam tellus, arcu nec metus scelerisque quam bibendum urna, vivamus rhoncus, maximus eros, ligula, ad nunc non, cursus. Urna, fusce finibus, dictum dignissim volutpat bibendum quisque quam, nostra, bibendum, egestas congue, ex, ornare lacinia, nisi fermentum euismod, dictumst. Vestibulum, non, suspendisse placerat non himenaeos vel et, egestas enim, pulvinar fringilla volutpat cras sollicitudin suscipit ultrices dui, tempor, mauris.", null, 33, 6 },
                    { 34, 25, new DateTime(2020, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(7286), new DateTime(2018, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(7282), new DateTime(2022, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(7290), new DateTime(2023, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(6655), 5, new DateTime(2023, 10, 31, 22, 59, 52, 82, DateTimeKind.Local).AddTicks(7288), null, null, false, "Venenatis non, quis, porta elit, vulputate inceptos vitae lacinia, est pretium consectetur etiam neque odio, aliquam primis molestie placerat, nec. Donec morbi commodo, odio ac, congue purus a, convallis ultrices porttitor, facilisis nullam enim, sit tortor, varius feugiat, tristique consectetur. Imperdiet phasellus nibh, turpis aliquam condimentum cras volutpat, luctus sodales eu, iaculis blandit etiam at, finibus, quam, pulvinar, rhoncus, porttitor.", null, 34, 6 },
                    { 35, 26, new DateTime(2020, 10, 31, 22, 59, 52, 151, DateTimeKind.Local).AddTicks(287), new DateTime(2019, 10, 31, 22, 59, 52, 151, DateTimeKind.Local).AddTicks(283), new DateTime(2023, 10, 31, 22, 59, 52, 151, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 10, 31, 22, 59, 52, 150, DateTimeKind.Local).AddTicks(9607), 5, new DateTime(2023, 10, 31, 22, 59, 52, 151, DateTimeKind.Local).AddTicks(289), null, null, false, "Ultrices, mi, nam eu, ac, posuere, nulla porta sodales accumsan finibus, conubia odio sociosqu convallis augue proin a, pellentesque sagittis. Ultrices scelerisque rhoncus lectus dui, nulla, dictum lacus vestibulum leo, erat, vitae, ornare semper mattis, vel duis commodo, blandit platea. Pulvinar tristique a euismod, sociosqu inceptos rutrum libero vestibulum consequat venenatis pretium nostra, aliquam placerat risus torquent fringilla tempor, maecenas.", null, 35, 6 }
                });

            migrationBuilder.InsertData(
                table: "IpAssignments",
                columns: new[] { "Id", "DateAssign", "DateCreated", "DateUnassign", "DateUpdated", "IpId", "IsActive", "IsDeleted", "ServerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(2585), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2584), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2584), 4, true, false, 1 },
                    { 2, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(2843), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2842), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(2842), 5, true, false, 2 },
                    { 3, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(3063), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3062), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3063), 6, true, false, 3 },
                    { 4, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(3307), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3306), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3307), 7, true, false, 4 },
                    { 5, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(3497), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3497), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3497), 8, true, false, 5 },
                    { 6, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(3731), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3730), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3731), 9, true, false, 6 },
                    { 7, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(3912), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3911), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(3911), 10, true, false, 7 },
                    { 8, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(4157), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4156), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4156), 11, true, false, 8 },
                    { 9, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(4344), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4343), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4344), 12, true, false, 9 },
                    { 10, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(4528), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4528), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4528), 13, true, false, 10 },
                    { 11, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(4741), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4740), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4740), 14, true, false, 11 },
                    { 12, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(4927), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4926), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(4927), 15, true, false, 12 },
                    { 13, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(5104), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5103), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5103), 16, true, false, 13 },
                    { 14, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5310), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5310), 17, true, false, 14 },
                    { 15, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(5507), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5506), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5506), 18, true, false, 15 },
                    { 16, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(5697), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5697), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5697), 19, true, false, 16 },
                    { 17, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5896), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(5896), 20, true, false, 17 },
                    { 18, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(6099), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6098), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6099), 21, true, false, 18 },
                    { 19, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(6281), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6280), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6280), 22, true, false, 19 },
                    { 20, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(6486), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6485), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6486), 23, true, false, 20 },
                    { 21, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6659), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6659), 24, true, false, 21 },
                    { 22, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(6860), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6859), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(6859), 25, true, false, 22 },
                    { 23, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(7070), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7069), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7070), 26, true, false, 23 },
                    { 24, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(7316), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7315), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7315), 27, true, false, 24 },
                    { 25, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(7511), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7510), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7510), 28, true, false, 25 },
                    { 26, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(7718), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7718), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7718), 29, true, false, 26 },
                    { 27, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7941), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(7941), 30, true, false, 27 },
                    { 28, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(8158), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8157), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8158), 31, true, false, 28 },
                    { 29, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(8364), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8363), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8363), 32, true, false, 29 },
                    { 30, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8580), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8580), 33, true, false, 30 },
                    { 31, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(8785), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8784), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(8785), 34, false, true, 31 },
                    { 32, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(9009), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9009), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9009), 35, false, true, 32 },
                    { 33, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(9263), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9262), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9262), 36, true, false, 33 },
                    { 34, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(9485), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9484), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9484), 37, true, false, 34 },
                    { 35, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(9665), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9664), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9665), 38, true, false, 35 },
                    { 36, new DateTime(2023, 10, 31, 15, 59, 50, 1, DateTimeKind.Utc).AddTicks(9864), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9863), null, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(9863), 39, true, false, 36 },
                    { 37, new DateTime(2023, 10, 31, 15, 59, 50, 2, DateTimeKind.Utc).AddTicks(53), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(53), null, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(53), 40, true, false, 37 },
                    { 38, new DateTime(2023, 10, 31, 15, 59, 50, 2, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(316), null, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(316), 41, true, false, 38 },
                    { 39, new DateTime(2023, 10, 31, 15, 59, 50, 2, DateTimeKind.Utc).AddTicks(522), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(521), null, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(521), 42, true, false, 39 },
                    { 40, new DateTime(2023, 10, 31, 15, 59, 50, 2, DateTimeKind.Utc).AddTicks(745), new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(744), null, new DateTime(2023, 10, 31, 22, 59, 50, 2, DateTimeKind.Local).AddTicks(744), 43, true, false, 40 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1299), 1, false, false, 1, 17 },
                    { 2, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1311), 2, false, false, 2, 26 },
                    { 3, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1327), 3, false, false, 3, 23 },
                    { 4, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1332), 4, false, false, 4, 14 },
                    { 5, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1336), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1337), 5, false, false, 5, 22 },
                    { 6, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1342), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1342), 6, false, false, 6, 17 },
                    { 7, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1346), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1346), 7, false, false, 7, 24 },
                    { 8, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1351), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1351), 8, false, false, 8, 22 },
                    { 9, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1356), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1356), 9, false, false, 9, 6 },
                    { 10, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1361), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1361), 10, false, false, 10, 9 },
                    { 11, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1365), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1365), 11, false, false, 11, 25 },
                    { 12, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1370), 12, false, false, 12, 22 },
                    { 13, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1374), 13, false, false, 13, 2 },
                    { 14, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1378), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1378), 14, false, false, 14, 24 },
                    { 15, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1382), 15, false, false, 15, 15 },
                    { 16, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1386), 16, false, false, 16, 30 },
                    { 17, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1390), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1390), 17, false, false, 17, 15 },
                    { 18, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1396), 18, false, false, 18, 24 },
                    { 19, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1400), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1400), 19, false, false, 19, 20 },
                    { 20, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1404), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1404), 20, false, false, 20, 17 },
                    { 21, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1409), 21, false, false, 21, 10 },
                    { 22, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1413), 22, false, false, 22, 19 },
                    { 23, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1417), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1417), 23, false, false, 23, 12 },
                    { 24, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1421), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1421), 24, false, false, 24, 20 },
                    { 25, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1425), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1426), 25, false, false, 25, 14 },
                    { 26, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1430), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1430), 26, false, false, 26, 18 },
                    { 27, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1440), 27, false, false, 27, 12 },
                    { 28, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1444), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1444), 28, false, false, 28, 15 },
                    { 29, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1448), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1448), 29, false, false, 29, 13 },
                    { 30, new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 10, 31, 22, 59, 50, 1, DateTimeKind.Local).AddTicks(1453), 30, false, false, 30, 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ApproverId",
                table: "AdditionalServices",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ColocationId",
                table: "AdditionalServices",
                column: "ColocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ExecutorId",
                table: "AdditionalServices",
                column: "ExecutorId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ServiceId",
                table: "AdditionalServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_UserId",
                table: "AdditionalServices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_UserId1",
                table: "AdditionalServices",
                column: "UserId1");

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
                name: "IX_ColocationHistories_ColocationId",
                table: "ColocationHistories",
                column: "ColocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_CustomerId",
                table: "Colocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations",
                column: "ServerId",
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
                name: "IX_Servers_DeviceId",
                table: "Servers",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servers_SerialNumber",
                table: "Servers",
                column: "SerialNumber",
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
                name: "ColocationHistories");

            migrationBuilder.DropTable(
                name: "IpAssignments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Approvers");

            migrationBuilder.DropTable(
                name: "Executors");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Colocations");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Networks");

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
