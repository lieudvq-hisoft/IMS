using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class add_server_device_collocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_UserId",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_UserId",
                table: "Customers",
                newName: "IX_Customers_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false),
                    NumberOfPort = table.Column<string>(type: "text", nullable: false),
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
                name: "Collocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ServerId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collocations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Collocations_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63fedae9-f6d9-4493-8b30-9edb431eecf3", "AQAAAAIAAYagAAAAECgdmGbshm8UOiUl+00lfYO1mau6qW1YMuVBKdjMAoxXu9V+bzV9wfyDZrjZaTtPCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5098293a-3c1c-46f0-ace1-395936aeada7", "AQAAAAIAAYagAAAAEGefrsWmBhpr278J5s8hgImXf/uKuEHeD9sTQoJsrzv3Gqt92XxYB6w5XbkpO1vnRQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af01b317-034d-45f3-b32f-f7d817be2777", "AQAAAAIAAYagAAAAEBZDxyq78ZNWlaK5FUlcqM1GgdjYDNoK2eoTKbkondC5TW1hGf142c3OKFszm72AxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0e26c08-91e1-4d79-8cb6-ccc32de751ea", "AQAAAAIAAYagAAAAEKi7BZjeWOWAlbf8fIPqsf/lX/RjXwyASGasY/sJYRih6kRLsyEbvxp7Ak1UwsgUqA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Collocations_CustomerId",
                table: "Collocations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Collocations_ServerId",
                table: "Collocations",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_DeviceId",
                table: "Servers",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UserId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Collocations");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_UserId",
                table: "Customer",
                newName: "IX_Customer_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "349205f1-69f6-4661-a945-bf5b6242eebe", "AQAAAAIAAYagAAAAEAz0XcxPx9RjviSiWO7Up3djkCShwTd3wxDjddJ46Ca1M6apk4IsF+6ZvntbxwPg7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "609b5546-3d32-4c17-8126-ebdfd8aa196d", "AQAAAAIAAYagAAAAELPA/VneXTqkO28QpApw3GrlOgM2TYnVmmlRqsEUxqh5Twdp0caQXXvt1F9DucpZvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbc65bce-47b0-40a9-ba06-fe2e5ae4b0f1", "AQAAAAIAAYagAAAAEBMTuQhgx9fR71UnODX0b1fHPCzO3OVpnqKts6SdqbxYdzc0IcJLcsthcNPc4Dy1oQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f938ab94-9cd2-4351-92b2-61f20239504e", "AQAAAAIAAYagAAAAEDPP5lHza3HxQvmdTj5EkGrWLydgImuTV2uJxDldbZqPXVTDgQ1/ZSDgNl2FV3g6Vg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_UserId",
                table: "Customer",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
