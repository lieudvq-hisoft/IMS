using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_expand_and_related : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_ServerAllocations_ServerAllocationId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "Power",
                table: "ServerAllocations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RequestExpands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Power = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    TechNote = table.Column<string>(type: "text", nullable: true),
                    ServerAllocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExpands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestExpands_ServerAllocations_ServerAllocationId",
                        column: x => x.ServerAllocationId,
                        principalTable: "ServerAllocations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestExpandLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestExpandId = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExpandLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestExpandLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestExpandLocations_RequestExpands_RequestExpandId",
                        column: x => x.RequestExpandId,
                        principalTable: "RequestExpands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestExpandUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestExpandId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExpandUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestExpandUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestExpandUsers_RequestExpands_RequestExpandId",
                        column: x => x.RequestExpandId,
                        principalTable: "RequestExpands",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a2ba184c-78be-4a79-976f-15cdb3e48e85", new DateTime(2023, 11, 16, 20, 41, 46, 712, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 11, 16, 20, 41, 46, 712, DateTimeKind.Local).AddTicks(9671), "AQAAAAIAAYagAAAAEPGPfAXMKBalYReCHjVbPEZVQMXkw+GN6Ykg6p/TSZMZaoMOQSv9PelzgyjQBKsftA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "d07d056d-8069-4385-8197-42385f4a7420", new DateTime(2023, 11, 16, 20, 41, 46, 552, DateTimeKind.Local).AddTicks(1892), new DateTime(2023, 11, 16, 20, 41, 46, 552, DateTimeKind.Local).AddTicks(1903), "AQAAAAIAAYagAAAAEK2crh8AFLtKgX8o7PjBA0fVJS3sjpW9TIxWOCa0++27Ht1GP1ClkOuCeo20zH1lbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4d05c668-58f2-4784-b708-d44038a54b1b", new DateTime(2023, 11, 16, 20, 41, 46, 632, DateTimeKind.Local).AddTicks(8180), new DateTime(2023, 11, 16, 20, 41, 46, 632, DateTimeKind.Local).AddTicks(8192), "AQAAAAIAAYagAAAAELgF0ESWJ3VrTW8/zjEt+2+iT3Z8V3sovaQponk6eudwT5t7qNQ+fppwWcoGV8jwrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1dfcb4c2-606d-471f-b599-f1d0c06a962c", new DateTime(2023, 11, 16, 20, 41, 46, 481, DateTimeKind.Local).AddTicks(186), new DateTime(2023, 11, 16, 20, 41, 46, 481, DateTimeKind.Local).AddTicks(198), "AQAAAAIAAYagAAAAEIdaLxGkSA1FqF96D58uEaULVFnZ6sdtdVh/6u93GTXr0YEbmuIor47MOwC7ifYuSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f3338fb3-a012-4970-81cf-c0a5b9b854f7", new DateTime(2023, 11, 16, 20, 41, 46, 413, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 11, 16, 20, 41, 46, 413, DateTimeKind.Local).AddTicks(1105), "AQAAAAIAAYagAAAAENMMn/uldWggFyZEhttycI2vCfL5cZo4CxkV0oy0FyL6OPYSPxeGaoW/rsBec8wsCQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4822), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4848), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4985), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4973), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5102), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5111), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5127), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5078), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5095), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5069), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5105), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5129), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5089), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5106), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5122), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5123), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5099), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5124), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5117), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5125), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5110), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5172), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5174), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5181), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5186), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5196), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5201), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5211), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5192), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5197), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5202), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5212), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5188), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5193), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5213), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5178), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5189), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5199), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5204), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5208), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5214), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5179), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5190), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5195), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5205), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5210), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5215), new DateTime(2023, 11, 16, 20, 41, 46, 408, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.CreateIndex(
                name: "IX_RequestExpandLocations_LocationId",
                table: "RequestExpandLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExpandLocations_RequestExpandId",
                table: "RequestExpandLocations",
                column: "RequestExpandId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExpands_ServerAllocationId",
                table: "RequestExpands",
                column: "ServerAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExpandUsers_RequestExpandId",
                table: "RequestExpandUsers",
                column: "RequestExpandId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestExpandUsers_UserId",
                table: "RequestExpandUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_ServerAllocations_ServerAllocationId",
                table: "Appointments",
                column: "ServerAllocationId",
                principalTable: "ServerAllocations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_ServerAllocations_ServerAllocationId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "RequestExpandLocations");

            migrationBuilder.DropTable(
                name: "RequestExpandUsers");

            migrationBuilder.DropTable(
                name: "RequestExpands");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "ServerAllocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0dc57749-0573-4252-942f-b85920bfeb1f", new DateTime(2023, 11, 16, 14, 44, 37, 405, DateTimeKind.Local).AddTicks(8622), new DateTime(2023, 11, 16, 14, 44, 37, 405, DateTimeKind.Local).AddTicks(8636), "AQAAAAIAAYagAAAAEHslU3x3l0lElOvB7y6pYJHFfFRE/mbRQmSG3QyDNHNbQG7sye8bRvHr+7m4uaXtaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "adffe3f0-dd1d-4dc7-8e25-a75c25bfacee", new DateTime(2023, 11, 16, 14, 44, 37, 179, DateTimeKind.Local).AddTicks(6702), new DateTime(2023, 11, 16, 14, 44, 37, 179, DateTimeKind.Local).AddTicks(6713), "AQAAAAIAAYagAAAAEMaOKefeloJUpfaIAz19lwGuostZNV0/3QNNuCR8yBLjPYOru9P/I1WVQjX8DOr6dA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ae7b81a7-93f3-4827-9e41-075768807c7a", new DateTime(2023, 11, 16, 14, 44, 37, 267, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 11, 16, 14, 44, 37, 267, DateTimeKind.Local).AddTicks(8875), "AQAAAAIAAYagAAAAEPxH48onMmxmKT4bosdC9xZ0AAOC1iBnHjjDD0EuAdleDTeQj3LUwzj6t5OnKo0JyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "42c3df9b-a2aa-45c8-bc9e-8981d1f764a4", new DateTime(2023, 11, 16, 14, 44, 37, 95, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 11, 16, 14, 44, 37, 95, DateTimeKind.Local).AddTicks(5170), "AQAAAAIAAYagAAAAEM71kEndpJi2evPDDNPNun+VIN6us9sbMZBICsvaGkfHKFPVkwnlK1vKJ/IeorNpjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "41265a58-2f5c-4912-be93-4acdb47da957", new DateTime(2023, 11, 16, 14, 44, 37, 23, DateTimeKind.Local).AddTicks(6711), new DateTime(2023, 11, 16, 14, 44, 37, 23, DateTimeKind.Local).AddTicks(6722), "AQAAAAIAAYagAAAAEApVH2qDyQOp8OLgmk+AKG15BxzSwb2jBN9ZFHLl8RuCjEGx93dppE50asy/fmLJEg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2417), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2600), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2626), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2640), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2613), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2754), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2762), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2779), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2787), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2731), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2764), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2772), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2773), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2781), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2789), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2733), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2766), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2782), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2790), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2775), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2783), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2768), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2776), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2784), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2792), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2744), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2777), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2753), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2761), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2786), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2794), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2795), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2804), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2814), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2829), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2834), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2805), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2810), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2800), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2821), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2812), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2817), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2831), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 11, 16, 14, 44, 37, 18, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_ServerAllocations_ServerAllocationId",
                table: "Appointments",
                column: "ServerAllocationId",
                principalTable: "ServerAllocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
