using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    NumberOfPort = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    BasePower = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
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
                    DNS = table.Column<int>(type: "integer", nullable: false),
                    Model = table.Column<string>(type: "text", nullable: false),
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
                name: "AdditionalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ColocationId = table.Column<int>(type: "integer", nullable: false),
                    ServiceId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Colocations_ColocationId",
                        column: x => x.ColocationId,
                        principalTable: "Colocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdditionalServices_Services_ServiceId",
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
                    { 1, 8, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(384), false, "A", 8 },
                    { 2, 8, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(394), false, "B", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName", "isDeactive" },
                values: new object[,]
                {
                    { new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"), null, "Customer", "Customer", null, false },
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), null, "IT Staff", "Tech", null, false },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), null, "Sale", "Sale", null, false },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), null, "Manager", "Manager", null, false },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), null, "Admin", "Admin", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CurrenNoticeCount", "Email", "EmailConfirmed", "Fullname", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), 0, "Address2", "59846580-963e-4079-865f-36f70323d175", 0, "tech@gmail.com", true, "Fullname2", false, false, null, "tech@gmail.com", "tech", "AQAAAAIAAYagAAAAEE+wBwF5z9vPAjOp3FHlFSRdJ45D+GM8YuN1TmABMBkO+XWsfWo1K9+PnEz8gmaVLw==", "0000000002", false, "", false, "tech" },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), 0, "Address3", "e9d16509-6beb-43d2-a3a6-af943aded8ff", 0, "sale@gmail.com", true, "Fullname3", false, false, null, "sale@gmail.com", "sale", "AQAAAAIAAYagAAAAEEALZGxH8T4jb9xiCd7cnslNQgjOzOzpCqXlXWUPURbjFo+SL6ayce6/0eWI8yAKGA==", "0000000003", false, "", false, "sale" },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), 0, "Address4", "06d8dbb8-2c75-4449-9323-91534bc13859", 0, "manager@gmail.com", true, "Fullname4", false, false, null, "manager@gmail.com", "manager", "AQAAAAIAAYagAAAAEIASPAZnDH95B6bJO2fYUaS37wFyqlCCzvMAaKQ8BDUJJO3hD7YND/PclNQrMuMZqw==", "0000000004", false, "", false, "manager" },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), 0, "Address5", "fcc9d238-370d-4648-9158-0d4084911012", 0, "admin@gmail.com", true, "Fullname5", false, false, null, "admin@gmail.com", "admin", "AQAAAAIAAYagAAAAEHoJJ3VDBfU6NMhr8I76fBK0rGBI5/5JLmrsSCyIYAhnqXzQ6xjQ8cnFTCM27IhepA==", "0000000005", false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7339), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7351), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7396), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7396), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7405), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7413), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7420), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "BasePower", "DateCreated", "DateUpdated", "IsDeleted", "NumberOfPort", "Size", "Status", "Type" },
                values: new object[] { 1, 200, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(330), false, 3, 2, 0, "Mock" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7439), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7439), "Thuê Chỗ", false, "Thuê Chỗ" },
                    { 2, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7451), "Thêm 1U", false, "Thêm 1U" },
                    { 3, new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 10, 17, 17, 55, 26, 372, DateTimeKind.Local).AddTicks(7460), "Công suất 100", false, "Công suất 100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"), new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") },
                    { new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"), new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd") },
                    { new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"), new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba") },
                    { new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"), new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7") }
                });

            migrationBuilder.InsertData(
                table: "Racks",
                columns: new[] { "Id", "AreaId", "Column", "CurrentPower", "DateCreated", "DateUpdated", "IsDeleted", "MaxPower", "Row", "Size" },
                values: new object[,]
                {
                    { 1, 1, 1, 200.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(408), false, 3000.0, 1, 42 },
                    { 2, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(511), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(511), false, 3000.0, 1, 42 },
                    { 3, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(537), false, 3000.0, 1, 42 },
                    { 4, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(562), false, 3000.0, 1, 42 },
                    { 5, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(621), false, 3000.0, 1, 42 },
                    { 6, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(646), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(646), false, 3000.0, 1, 42 },
                    { 7, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(809), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(809), false, 3000.0, 1, 42 },
                    { 8, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(868), false, 3000.0, 1, 42 },
                    { 9, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(417), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(417), false, 3000.0, 2, 42 },
                    { 10, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(515), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(515), false, 3000.0, 2, 42 },
                    { 11, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(540), false, 3000.0, 2, 42 },
                    { 12, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(565), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(565), false, 3000.0, 2, 42 },
                    { 13, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(624), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(624), false, 3000.0, 2, 42 },
                    { 14, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(786), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(786), false, 3000.0, 2, 42 },
                    { 15, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(812), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(813), false, 3000.0, 2, 42 },
                    { 16, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(871), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(872), false, 3000.0, 2, 42 },
                    { 17, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(421), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(421), false, 3000.0, 3, 42 },
                    { 18, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(518), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(518), false, 3000.0, 3, 42 },
                    { 19, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(543), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(544), false, 3000.0, 3, 42 },
                    { 20, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(568), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(568), false, 3000.0, 3, 42 },
                    { 21, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(627), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(627), false, 3000.0, 3, 42 },
                    { 22, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(790), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(790), false, 3000.0, 3, 42 },
                    { 23, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(816), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(816), false, 3000.0, 3, 42 },
                    { 24, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(874), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(875), false, 3000.0, 3, 42 },
                    { 25, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(424), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(424), false, 3000.0, 4, 42 },
                    { 26, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(521), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(521), false, 3000.0, 4, 42 },
                    { 27, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(547), false, 3000.0, 4, 42 },
                    { 28, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(571), false, 3000.0, 4, 42 },
                    { 29, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(630), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(631), false, 3000.0, 4, 42 },
                    { 30, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(793), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(793), false, 3000.0, 4, 42 },
                    { 31, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(819), false, 3000.0, 4, 42 },
                    { 32, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(878), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(878), false, 3000.0, 4, 42 },
                    { 33, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(428), false, 3000.0, 5, 42 },
                    { 34, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(524), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(525), false, 3000.0, 5, 42 },
                    { 35, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(550), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(550), false, 3000.0, 5, 42 },
                    { 36, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(574), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(575), false, 3000.0, 5, 42 },
                    { 37, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(633), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(634), false, 3000.0, 5, 42 },
                    { 38, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(796), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(796), false, 3000.0, 5, 42 },
                    { 39, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(822), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(822), false, 3000.0, 5, 42 },
                    { 40, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(881), false, 3000.0, 5, 42 },
                    { 41, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(500), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(500), false, 3000.0, 6, 42 },
                    { 42, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(527), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(528), false, 3000.0, 6, 42 },
                    { 43, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(553), false, 3000.0, 6, 42 },
                    { 44, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(577), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(578), false, 3000.0, 6, 42 },
                    { 45, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(636), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(637), false, 3000.0, 6, 42 },
                    { 46, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(799), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(800), false, 3000.0, 6, 42 },
                    { 47, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(826), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(826), false, 3000.0, 6, 42 },
                    { 48, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(884), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(885), false, 3000.0, 6, 42 },
                    { 49, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(504), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(505), false, 3000.0, 7, 42 },
                    { 50, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(531), false, 3000.0, 7, 42 },
                    { 51, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(556), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(556), false, 3000.0, 7, 42 },
                    { 52, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(614), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(614), false, 3000.0, 7, 42 },
                    { 53, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(639), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(640), false, 3000.0, 7, 42 },
                    { 54, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(802), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(803), false, 3000.0, 7, 42 },
                    { 55, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(861), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(861), false, 3000.0, 7, 42 },
                    { 56, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(888), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(888), false, 3000.0, 7, 42 },
                    { 57, 1, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(508), false, 3000.0, 8, 42 },
                    { 58, 1, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(533), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(534), false, 3000.0, 8, 42 },
                    { 59, 1, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(559), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(559), false, 3000.0, 8, 42 },
                    { 60, 1, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(617), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(618), false, 3000.0, 8, 42 },
                    { 61, 1, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(642), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(643), false, 3000.0, 8, 42 },
                    { 62, 1, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(806), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(806), false, 3000.0, 8, 42 },
                    { 63, 1, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(865), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(865), false, 3000.0, 8, 42 },
                    { 64, 1, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(891), false, 3000.0, 8, 42 },
                    { 65, 2, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(895), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(895), false, 3500.0, 1, 42 },
                    { 66, 2, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(913), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(913), false, 3500.0, 1, 42 },
                    { 67, 2, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(929), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(930), false, 3500.0, 1, 42 },
                    { 68, 2, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(978), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(978), false, 3500.0, 1, 42 },
                    { 69, 2, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(994), false, 3500.0, 1, 42 },
                    { 70, 2, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1010), false, 3500.0, 1, 42 },
                    { 71, 2, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1026), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1027), false, 3500.0, 1, 42 },
                    { 72, 2, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1178), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1179), false, 3500.0, 1, 42 },
                    { 73, 2, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(900), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(900), false, 3500.0, 2, 42 },
                    { 74, 2, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(916), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(917), false, 3500.0, 2, 42 },
                    { 75, 2, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(933), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(933), false, 3500.0, 2, 42 },
                    { 76, 2, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(981), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(981), false, 3500.0, 2, 42 },
                    { 77, 2, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(997), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(997), false, 3500.0, 2, 42 },
                    { 78, 2, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1013), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1013), false, 3500.0, 2, 42 },
                    { 79, 2, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1165), false, 3500.0, 2, 42 },
                    { 80, 2, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1182), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1182), false, 3500.0, 2, 42 },
                    { 81, 2, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(903), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(904), false, 3500.0, 3, 42 },
                    { 82, 2, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(920), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(920), false, 3500.0, 3, 42 },
                    { 83, 2, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(936), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(936), false, 3500.0, 3, 42 },
                    { 84, 2, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(984), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(984), false, 3500.0, 3, 42 },
                    { 85, 2, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1000), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1000), false, 3500.0, 3, 42 },
                    { 86, 2, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1016), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1017), false, 3500.0, 3, 42 },
                    { 87, 2, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1169), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1169), false, 3500.0, 3, 42 },
                    { 88, 2, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1185), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1185), false, 3500.0, 3, 42 },
                    { 89, 2, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(907), false, 3500.0, 4, 42 },
                    { 90, 2, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(923), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(923), false, 3500.0, 4, 42 },
                    { 91, 2, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(970), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(971), false, 3500.0, 4, 42 },
                    { 92, 2, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(987), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(987), false, 3500.0, 4, 42 },
                    { 93, 2, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1003), false, 3500.0, 4, 42 },
                    { 94, 2, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1020), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1020), false, 3500.0, 4, 42 },
                    { 95, 2, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1172), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1172), false, 3500.0, 4, 42 },
                    { 96, 2, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1188), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1188), false, 3500.0, 4, 42 },
                    { 97, 2, 1, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(910), false, 3500.0, 5, 42 },
                    { 98, 2, 2, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(926), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(926), false, 3500.0, 5, 42 },
                    { 99, 2, 3, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(975), false, 3500.0, 5, 42 },
                    { 100, 2, 4, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(990), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(991), false, 3500.0, 5, 42 },
                    { 101, 2, 5, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1007), false, 3500.0, 5, 42 },
                    { 102, 2, 6, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1023), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1023), false, 3500.0, 5, 42 },
                    { 103, 2, 7, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1175), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1175), false, 3500.0, 5, 42 },
                    { 104, 2, 8, 0.0, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1223), false, 3500.0, 5, 42 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "DeviceId", "IsDeleted", "IsMoveout", "RackId", "StartPosition" },
                values: new object[] { 1, new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 10, 17, 17, 55, 26, 656, DateTimeKind.Local).AddTicks(1238), 1, false, false, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ColocationId",
                table: "AdditionalServices",
                column: "ColocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalServices_ServiceId",
                table: "AdditionalServices",
                column: "ServiceId");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_CustomerId",
                table: "Colocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Colocations_ServerId",
                table: "Colocations",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyTypeId",
                table: "Customers",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

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
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Colocations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Racks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Servers");

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
