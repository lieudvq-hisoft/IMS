using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class add_and_seed_customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserAva",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    CompanyRepresentative = table.Column<string>(type: "text", nullable: false),
                    TaxNumber = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b5837b6f-1666-49a1-8786-edb8371605e8", "AQAAAAIAAYagAAAAEErRI5CK7VIzGmcB716uttKgp6yEFY7a2ndbO+Syzl8Yob+tRLSIEB7aLBS6m+3Uxw==", "0000000001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "288ec5da-4893-491b-a510-7d18d8b1f880", "AQAAAAIAAYagAAAAEGqe9EWHHhvKfDv7HReFyW1gPNnWvLyFBf9tZgqvuWhH4EDeRQlrchTyptyUZIxB6A==", "0000000002" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1b45bf0d-e553-4b53-a0c9-f16926ba5e4d", "AQAAAAIAAYagAAAAEPDh/SJATdIpFYKdcJ862CIlUgMrdTNZzMo6Vh3bK/XKxnM+Sun/7jYG96NBvJmiiw==", "0000000003" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "0bf22c75-ce4a-431a-8802-624b183c9590", "AQAAAAIAAYagAAAAEDdoSBTeS3aogN8JNwbNtl/FPx5yr3LB987Xc9ZA53rJVBlVok/qGDdyzAN/xBoBRw==", "0000000004" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b362f201-ac02-4e2c-9218-a55ebdf624d9", "AQAAAAIAAYagAAAAEM92jm9HOXdwQ7PUucL5a9renYmpSimMYf0Vs02Mv0fCCCtGcDMldU5db0jw+fZdhg==", "0000000005" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CompanyName", "CompanyRepresentative", "DateCreated", "DateUpdated", "IsDeleted", "TaxNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "Company 1", "Representative 1", new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5761), new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5772), false, "taxnumber1", new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4") },
                    { 2, "Company 2", "Representative 2", new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 10, 2, 23, 41, 54, 74, DateTimeKind.Local).AddTicks(5821), false, "taxnumber2", new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserId",
                table: "Customer",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserAva",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8286d046-9740-a3e4-95cf-ff46699c73c4"),
                columns: new[] { "Age", "ConcurrencyStamp", "Gender", "PasswordHash", "PhoneNumber", "UserAva" },
                values: new object[] { "21", "5fd4bd5e-a2eb-4d67-a651-8007e8d7ff12", false, "AQAAAAIAAYagAAAAEOgvmD9SMN1iSWn0hq3HppVUxZu0KVqvtQzjthfFTbgpR75Q6qyuvdCn9pxtVIWSOQ==", null, "Avatar1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95c69371-b924-6fe3-7c38-98b7dd200bc1"),
                columns: new[] { "Age", "ConcurrencyStamp", "Gender", "PasswordHash", "PhoneNumber", "UserAva" },
                values: new object[] { "22", "78fab7eb-987a-45b1-8514-43d0a5366421", true, "AQAAAAIAAYagAAAAEILXRvlHgT1k+kH7RQf2m9msyb4JamN6UJ0CqFq/pSoRcJven7qtmdzlDpdZoOIWRQ==", null, "Avatar2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a905569d-db07-3ae3-63a0-322750a4a3bd"),
                columns: new[] { "Age", "ConcurrencyStamp", "Gender", "PasswordHash", "PhoneNumber", "UserAva" },
                values: new object[] { "23", "9ac8c526-d3e0-4bff-8205-830860994d50", false, "AQAAAAIAAYagAAAAEFC7OmboX8roYX/mwnT3rL3VggyTUR+E/dwH/KEvRpSWGu672O95rBW74+nofQgS9A==", null, "Avatar3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc4519c8-fdeb-06e2-4a08-cc98c4273aba"),
                columns: new[] { "Age", "ConcurrencyStamp", "Gender", "PasswordHash", "PhoneNumber", "UserAva" },
                values: new object[] { "24", "3dc335a2-7988-4c99-92a6-ee50e6423f7d", true, "AQAAAAIAAYagAAAAEI9yQL7+69r0x12jUtYmFynGfwowEBOQF135UeNpigJPoWuCgsLDV11h7F/RVPyLIA==", null, "Avatar4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf85ddf4-1ece-d1e2-3171-650938abd2b7"),
                columns: new[] { "Age", "ConcurrencyStamp", "Gender", "PasswordHash", "PhoneNumber", "UserAva" },
                values: new object[] { "25", "8c3e34c4-7b8e-4dbf-b85f-118afb242587", false, "AQAAAAIAAYagAAAAEJzun7bk+ei4RcVltKdIfTH3uiqM4TdO8JSyte+Y693u2BkItzO5a90wp+Z9FmL0nQ==", null, "Avatar5" });
        }
    }
}
