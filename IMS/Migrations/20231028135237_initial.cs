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
                name: "Approver",
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
                    table.PrimaryKey("PK_Approver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Approver_AspNetUsers_UserId1",
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
                name: "Executer",
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
                    table.PrimaryKey("PK_Executer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Executer_AspNetUsers_UserId1",
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
                    ExecuterId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_AdditionalServices_Approver_ApproverId",
                        column: x => x.ApproverId,
                        principalTable: "Approver",
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
                        name: "FK_AdditionalServices_Executer_ExecuterId",
                        column: x => x.ExecuterId,
                        principalTable: "Executer",
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
                    DateExtended = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    { 1, 8, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9038), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9045), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9045), false, "B", 5 }
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
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), 0, "Address3", "342aae49-4786-45a8-84c9-acf24de20cbd", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEMAGor9hrRfmIai1oT04kXh0ugEL1IjgNKSJlreI9JJ8lXl6Rq3Lx/Q0lCvPiF+HwA==", "0000000003", false, "", false, "sale" },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), 0, "Address5", "a48456e3-c975-4639-9dc3-ff4b51ad7e09", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAENh4YEb2CpmSNPHAINv/NX6auIshJWBhqY1BBZEBRXj6NnCGP0W7NzIiv2d6jCvqrQ==", "0000000005", false, "", false, "admin" },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), 0, "Address4", "40755d8d-7d3d-411d-91a1-f3b1e8e43a6b", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEKH5O7WYHQVOuYPwPF2fbjGvFdSsZGeQWifWYF2T6vrmPi6W/O5D5VcmKh1IuoekRw==", "0000000004", false, "", false, "manager" },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), 0, "Address2", "4f21e836-e056-48f7-a8ad-a53cf2c41f62", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEPOtUvWfxC8C7AKIuesj6iwx5m9XJUq/nawJ2yX2qQzQYv7QfhTxBdepUc0/yZGePQ==", "0000000002", false, "", false, "tech" },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), 0, "Address1", "16b6b675-d889-4b26-9feb-2fe382e9b772", 0, "super@gmail.com", true, "Fullname1", false, false, null, "super@gmail.com", "super", "AQAAAAIAAYagAAAAEIHDbMyfTF4RGxUfGnvHgdViZ0ZXV3clPBDyEFc7awGmbX9UnV+PXALGE7BRON8uhA==", "0000000001", false, "", false, "super" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7008), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7023), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7133), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7159), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7203), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7204), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7235), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7237), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "AdditionalPower", "AdditionalSize", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "Size", "Type" },
                values: new object[] { 1, 0, 0, 200, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9018), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9018), false, 2, "Mock" });

            migrationBuilder.InsertData(
                table: "Networks",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstOctet", "IsDeleted", "SecondOctet", "SubnetMask", "ThirdOctet" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9842), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9842), 192, false, 112, 24, 121 },
                    { 2, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9850), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9851), 193, false, 122, 25, 111 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7300), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7336), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7336), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 10, 28, 20, 52, 36, 368, DateTimeKind.Local).AddTicks(7357), "Công suất 100", false, "Công suất 100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("1abb6e28-793d-460f-8a24-745998356da8") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("285135ab-c67d-4285-b689-7e88e7f610f9") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab") },
                    { new Guid("1abb6e28-793d-460f-8a24-745998356da8"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") },
                    { new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"), new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "CompanyTypeId", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[] { 1, "super", 1, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(8979), false, "0000000000", new Guid("57ffb575-7c79-4133-8433-aebbcd71f824") });

            migrationBuilder.InsertData(
                table: "Ips",
                columns: new[] { "Id", "Address", "Blocked", "DateCreated", "DateUpdated", "IsDeleted", "IsReserved", "NetworkId", "Type" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9863), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9863), false, false, 2, 0 },
                    { 2, 2, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9871), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9872), false, false, 1, 0 },
                    { 3, 3, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9875), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9875), false, false, 2, 0 },
                    { 4, 4, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9878), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9879), false, false, 1, 0 },
                    { 5, 5, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9882), false, false, 2, 0 },
                    { 6, 6, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9886), false, false, 1, 0 },
                    { 7, 7, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9889), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9889), false, false, 2, 0 },
                    { 8, 8, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9892), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9892), false, false, 1, 0 },
                    { 9, 9, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9895), false, false, 2, 0 },
                    { 10, 10, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9899), false, false, 1, 0 },
                    { 11, 11, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9902), false, false, 2, 0 },
                    { 12, 12, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9905), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9905), false, false, 1, 0 },
                    { 13, 13, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9908), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9909), false, false, 2, 0 },
                    { 14, 14, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9911), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9912), false, false, 1, 0 },
                    { 15, 15, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9915), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9915), false, false, 2, 0 },
                    { 16, 16, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9918), false, false, 1, 0 },
                    { 17, 17, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9921), false, false, 2, 0 },
                    { 18, 18, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9925), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9925), false, false, 1, 0 },
                    { 19, 19, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9928), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9928), false, false, 2, 0 },
                    { 20, 20, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9931), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9931), false, false, 1, 0 },
                    { 21, 21, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9940), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9940), false, false, 2, 0 },
                    { 22, 22, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9943), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9944), false, false, 1, 0 },
                    { 23, 23, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9946), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9947), false, false, 2, 0 },
                    { 24, 24, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9950), false, false, 1, 0 },
                    { 25, 25, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9952), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9953), false, false, 2, 0 },
                    { 26, 26, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9956), false, false, 1, 0 },
                    { 27, 27, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9959), false, false, 2, 0 },
                    { 28, 28, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9962), false, false, 1, 0 },
                    { 29, 29, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9965), false, false, 2, 0 },
                    { 30, 30, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9968), false, false, 1, 0 },
                    { 31, 31, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9971), false, false, 2, 0 },
                    { 32, 32, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9975), false, false, 1, 0 },
                    { 33, 33, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9978), false, false, 2, 0 },
                    { 34, 34, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9981), false, false, 1, 0 },
                    { 35, 35, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9984), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9984), false, false, 2, 0 },
                    { 36, 36, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9987), false, false, 1, 0 },
                    { 37, 37, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9990), false, false, 2, 0 },
                    { 38, 38, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9993), false, false, 1, 0 },
                    { 39, 39, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9996), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9996), false, false, 2, 0 },
                    { 40, 40, false, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9999), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9999), false, false, 1, 0 },
                    { 41, 41, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(2), false, false, 2, 0 },
                    { 42, 42, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(6), false, false, 1, 0 },
                    { 43, 43, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(8), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(9), false, false, 2, 0 },
                    { 44, 44, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(11), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(12), false, false, 1, 0 },
                    { 45, 45, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(14), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(15), false, false, 2, 0 },
                    { 46, 46, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(18), false, false, 1, 0 },
                    { 47, 47, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(26), false, false, 2, 0 },
                    { 48, 48, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(29), false, false, 1, 0 },
                    { 49, 49, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(32), false, false, 2, 0 },
                    { 50, 50, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(35), false, false, 1, 0 },
                    { 51, 51, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(39), false, false, 2, 0 },
                    { 52, 52, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(42), false, false, 1, 0 },
                    { 53, 53, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(45), false, false, 2, 0 },
                    { 54, 54, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(47), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(48), false, false, 1, 0 },
                    { 55, 55, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(51), false, false, 2, 0 },
                    { 56, 56, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(54), false, false, 1, 0 },
                    { 57, 57, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(57), false, false, 2, 0 },
                    { 58, 58, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(60), false, false, 1, 0 },
                    { 59, 59, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(63), false, false, 2, 0 },
                    { 60, 60, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(66), false, false, 1, 0 },
                    { 61, 61, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(69), false, false, 2, 0 },
                    { 62, 62, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(72), false, false, 1, 0 },
                    { 63, 63, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(75), false, false, 2, 0 },
                    { 64, 64, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(78), false, false, 1, 0 },
                    { 65, 65, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(81), false, false, 2, 0 },
                    { 66, 66, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(85), false, false, 1, 0 },
                    { 67, 67, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(88), false, false, 2, 0 },
                    { 68, 68, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(91), false, false, 1, 0 },
                    { 69, 69, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(94), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(94), false, false, 2, 0 },
                    { 70, 70, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(97), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(97), false, false, 1, 0 },
                    { 71, 71, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(105), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(105), false, false, 2, 0 },
                    { 72, 72, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(109), false, false, 1, 0 },
                    { 73, 73, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(112), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(112), false, false, 2, 0 },
                    { 74, 74, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(115), false, false, 1, 0 },
                    { 75, 75, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(118), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(118), false, false, 2, 0 },
                    { 76, 76, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(121), false, false, 1, 0 },
                    { 77, 77, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(124), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(124), false, false, 2, 0 },
                    { 78, 78, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(127), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(127), false, false, 1, 0 },
                    { 79, 79, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(130), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(130), false, false, 2, 0 },
                    { 80, 80, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(133), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(133), false, false, 1, 0 },
                    { 81, 81, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(136), false, false, 2, 0 },
                    { 82, 82, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(139), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(139), false, false, 1, 0 },
                    { 83, 83, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(142), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(142), false, false, 2, 0 },
                    { 84, 84, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(145), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(146), false, false, 1, 0 },
                    { 85, 85, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(149), false, false, 2, 0 },
                    { 86, 86, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(152), false, false, 1, 0 },
                    { 87, 87, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(154), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(155), false, false, 2, 0 },
                    { 88, 88, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(158), false, false, 1, 0 },
                    { 89, 89, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(185), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(185), false, false, 2, 0 },
                    { 90, 90, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(189), false, false, 1, 0 },
                    { 91, 91, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(192), false, false, 2, 0 },
                    { 92, 92, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(195), false, false, 1, 0 },
                    { 93, 93, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(198), false, false, 2, 0 },
                    { 94, 94, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(201), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(201), false, false, 1, 0 },
                    { 95, 95, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(204), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(204), false, false, 2, 0 },
                    { 96, 96, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(207), false, false, 1, 0 },
                    { 97, 97, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(210), false, false, 2, 0 },
                    { 98, 98, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(214), false, false, 1, 0 },
                    { 99, 99, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(222), false, false, 2, 0 },
                    { 100, 100, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(225), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(225), false, false, 1, 0 },
                    { 101, 101, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(228), false, false, 2, 0 },
                    { 102, 102, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(231), false, false, 1, 0 },
                    { 103, 103, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(235), false, false, 2, 0 },
                    { 104, 104, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(237), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(238), false, false, 1, 0 },
                    { 105, 105, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(240), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(241), false, false, 2, 0 },
                    { 106, 106, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(244), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(244), false, false, 1, 0 },
                    { 107, 107, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(247), false, false, 2, 0 },
                    { 108, 108, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(250), false, false, 1, 0 },
                    { 109, 109, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(253), false, false, 2, 0 },
                    { 110, 110, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(256), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(256), false, false, 1, 0 },
                    { 111, 111, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(259), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(259), false, false, 2, 0 },
                    { 112, 112, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(262), false, false, 1, 0 },
                    { 113, 113, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(266), false, false, 2, 0 },
                    { 114, 114, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(269), false, false, 1, 0 },
                    { 115, 115, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(272), false, false, 2, 0 },
                    { 116, 116, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(275), false, false, 1, 0 },
                    { 117, 117, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(278), false, false, 2, 0 },
                    { 118, 118, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(281), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(281), false, false, 1, 0 },
                    { 119, 119, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(284), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(284), false, false, 2, 0 },
                    { 120, 120, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(287), false, false, 1, 0 },
                    { 121, 121, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(290), false, false, 2, 0 },
                    { 122, 122, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(293), false, false, 1, 0 },
                    { 123, 123, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(296), false, false, 2, 0 },
                    { 124, 124, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(299), false, false, 1, 0 },
                    { 125, 125, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(302), false, false, 2, 0 },
                    { 126, 126, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(310), false, false, 1, 0 },
                    { 127, 127, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(313), false, false, 2, 0 },
                    { 128, 128, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(317), false, false, 1, 0 },
                    { 129, 129, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(320), false, false, 2, 0 },
                    { 130, 130, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(324), false, false, 1, 0 },
                    { 131, 131, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(327), false, false, 2, 0 },
                    { 132, 132, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(329), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(330), false, false, 1, 0 },
                    { 133, 133, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(333), false, false, 2, 0 },
                    { 134, 134, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(336), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(336), false, false, 1, 0 },
                    { 135, 135, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(339), false, false, 2, 0 },
                    { 136, 136, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(342), false, false, 1, 0 },
                    { 137, 137, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(345), false, false, 2, 0 },
                    { 138, 138, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(348), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(348), false, false, 1, 0 },
                    { 139, 139, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(351), false, false, 2, 0 },
                    { 140, 140, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(354), false, false, 1, 0 },
                    { 141, 141, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(357), false, false, 2, 0 },
                    { 142, 142, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(360), false, false, 1, 0 },
                    { 143, 143, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(363), false, false, 2, 0 },
                    { 144, 144, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(366), false, false, 1, 0 },
                    { 145, 145, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(370), false, false, 2, 0 },
                    { 146, 146, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(373), false, false, 1, 0 },
                    { 147, 147, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(381), false, false, 2, 0 },
                    { 148, 148, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(384), false, false, 1, 0 },
                    { 149, 149, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(387), false, false, 2, 0 },
                    { 150, 150, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(390), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(390), false, false, 1, 0 },
                    { 151, 151, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(393), false, false, 2, 0 },
                    { 152, 152, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(396), false, false, 1, 0 },
                    { 153, 153, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(399), false, false, 2, 0 },
                    { 154, 154, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(402), false, false, 1, 0 },
                    { 155, 155, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(406), false, false, 2, 0 },
                    { 156, 156, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(409), false, false, 1, 0 },
                    { 157, 157, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(411), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(412), false, false, 2, 0 },
                    { 158, 158, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(415), false, false, 1, 0 },
                    { 159, 159, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(418), false, false, 2, 0 },
                    { 160, 160, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(421), false, false, 1, 0 },
                    { 161, 161, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(424), false, false, 2, 0 },
                    { 162, 162, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(427), false, false, 1, 0 },
                    { 163, 163, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(430), false, false, 2, 0 },
                    { 164, 164, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(433), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(433), false, false, 1, 0 },
                    { 165, 165, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(436), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(436), false, false, 2, 0 },
                    { 166, 166, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(439), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(440), false, false, 1, 0 },
                    { 167, 167, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(443), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(443), false, false, 2, 0 },
                    { 168, 168, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(446), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(446), false, false, 1, 0 },
                    { 169, 169, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(449), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(449), false, false, 2, 0 },
                    { 170, 170, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(452), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(452), false, false, 1, 0 },
                    { 171, 171, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(455), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(455), false, false, 2, 0 },
                    { 172, 172, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(458), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(458), false, false, 1, 0 },
                    { 173, 173, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(461), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(461), false, false, 2, 0 },
                    { 174, 174, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(464), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(464), false, false, 1, 0 },
                    { 175, 175, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(472), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(472), false, false, 2, 0 },
                    { 176, 176, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(475), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(475), false, false, 1, 0 },
                    { 177, 177, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(478), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(478), false, false, 2, 0 },
                    { 178, 178, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(481), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(481), false, false, 1, 0 },
                    { 179, 179, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(484), false, false, 2, 0 },
                    { 180, 180, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(487), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(488), false, false, 1, 0 },
                    { 181, 181, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(490), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(491), false, false, 2, 0 },
                    { 182, 182, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(493), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(494), false, false, 1, 0 },
                    { 183, 183, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(497), false, false, 2, 0 },
                    { 184, 184, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(500), false, false, 1, 0 },
                    { 185, 185, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(503), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(503), false, false, 2, 0 },
                    { 186, 186, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(506), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(506), false, false, 1, 0 },
                    { 187, 187, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(509), false, false, 2, 0 },
                    { 188, 188, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(512), false, false, 1, 0 },
                    { 189, 189, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(515), false, false, 2, 0 },
                    { 190, 190, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(518), false, false, 1, 0 },
                    { 191, 191, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(521), false, false, 2, 0 },
                    { 192, 192, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(524), false, false, 1, 0 },
                    { 193, 193, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(528), false, false, 2, 0 },
                    { 194, 194, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(531), false, false, 1, 0 },
                    { 195, 195, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(534), false, false, 2, 0 },
                    { 196, 196, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(537), false, false, 1, 0 },
                    { 197, 197, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(540), false, false, 2, 0 },
                    { 198, 198, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(543), false, false, 1, 0 },
                    { 199, 199, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(546), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(546), false, false, 2, 0 },
                    { 200, 200, false, new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(549), new DateTime(2023, 10, 28, 20, 52, 36, 897, DateTimeKind.Local).AddTicks(549), false, false, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9068), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9091), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9099), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9107), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9107), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9115), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9122), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9123), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9129), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9130), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9137), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9082), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9092), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9100), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9108), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9116), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9123), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9124), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9131), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9137), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9138), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9083), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9083), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9093), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9093), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9101), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9101), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9109), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9109), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9117), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9124), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9124), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9131), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9132), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9138), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9139), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9084), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9094), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9102), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9110), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9117), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9118), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9125), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9125), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9132), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9132), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9139), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9140), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9085), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9085), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9095), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9095), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9103), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9111), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9119), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9126), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9133), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9133), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9140), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9087), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9087), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9096), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9104), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9112), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9119), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9120), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9127), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9134), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9141), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9141), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9088), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9097), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9105), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9113), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9120), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9121), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9128), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9135), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9135), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9142), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9142), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9089), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9090), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9097), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9098), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9106), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9113), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9114), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9122), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9128), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9129), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9136), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9136), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9143), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9143), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9144), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9144), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9157), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9158), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9162), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9162), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9167), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9167), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9171), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9171), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9175), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9176), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9180), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9184), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9185), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9154), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9159), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9163), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9163), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9167), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9168), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9172), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9172), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9176), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9177), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9181), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9181), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9185), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9186), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9154), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9155), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9159), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9160), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9164), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9164), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9169), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9173), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9177), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9177), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9182), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9186), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9155), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9156), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9161), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9165), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9165), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9169), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9169), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9174), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9178), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9183), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9187), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9187), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9156), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9157), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9161), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9166), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9170), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9170), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9174), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9175), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9179), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9179), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9184), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9188), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9188), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[] { 1, new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 10, 28, 20, 52, 36, 896, DateTimeKind.Local).AddTicks(9823), 1, false, false, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ApproverId",
                table: "AdditionalServices",
                column: "ApproverId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ColocationId",
                table: "AdditionalServices",
                column: "ColocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ExecuterId",
                table: "AdditionalServices",
                column: "ExecuterId");

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
                name: "IX_Approver_UserId1",
                table: "Approver",
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
                name: "IX_Executer_UserId1",
                table: "Executer",
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
                name: "Approver");

            migrationBuilder.DropTable(
                name: "Executer");

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
