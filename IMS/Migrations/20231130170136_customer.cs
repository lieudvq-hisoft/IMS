using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CompanyTypes_CompanyTypeId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CompanyTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CompanyTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5958), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "c85c1d21-7286-440c-8d2e-b8fa2f70f9d8", new DateTime(2023, 12, 1, 0, 1, 35, 474, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 12, 1, 0, 1, 35, 474, DateTimeKind.Local).AddTicks(7321), "AQAAAAIAAYagAAAAELtOerEUjqXcRGqBSQBT6tgme593xkYIUXrfSvpj8/EygMtS8muuQj9Szj+iRiKttQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "393752a2-6523-4fad-a378-29156930148f", new DateTime(2023, 12, 1, 0, 1, 35, 217, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 12, 1, 0, 1, 35, 217, DateTimeKind.Local).AddTicks(1435), "AQAAAAIAAYagAAAAEHvhV6Ho7kyvwlLckCaXRg7YVP88I3pByHuczGl7rSDobWE7sZ3KhKRNsPXMykuGBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a5d71fa2-7004-49e7-a854-c69dfba0ee2f", new DateTime(2023, 12, 1, 0, 1, 35, 361, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 12, 1, 0, 1, 35, 361, DateTimeKind.Local).AddTicks(7487), "AQAAAAIAAYagAAAAELRcFnjEsRvcqchNyYqEIe1chDJToUlc7CQjsPyQ1AbetmRdPxrcueE9IcQknKtKAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4c77f8d5-0db7-4fdb-bece-a84936c49b2a", new DateTime(2023, 12, 1, 0, 1, 35, 133, DateTimeKind.Local).AddTicks(872), new DateTime(2023, 12, 1, 0, 1, 35, 133, DateTimeKind.Local).AddTicks(887), "AQAAAAIAAYagAAAAECTikpfMo7848oGPjZ5a9Z9enm0KgVHjReJEVGjXJ5snVrQ1wFxbmfMpFnPDbLKTBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "be67ad1c-7a25-4008-ba73-70f02b043ce4", new DateTime(2023, 12, 1, 0, 1, 35, 49, DateTimeKind.Local).AddTicks(2129), new DateTime(2023, 12, 1, 0, 1, 35, 49, DateTimeKind.Local).AddTicks(2142), "AQAAAAIAAYagAAAAELHzM1Ez+6qPAOIfD3qG0G+JNvDkxs9k/3WMNbi/6EaNPB1dW+1yJRGdm2cXO46yjw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5787), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5913), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5997), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6052), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6061), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6069), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6077), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6129), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6137), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6012), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6044), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6054), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6078), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6130), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6138), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6013), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6046), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6055), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6063), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6071), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6079), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6131), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6139), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6064), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6072), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6080), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6048), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6057), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6065), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6073), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6081), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6133), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6141), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6058), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6066), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6082), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6134), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6059), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6083), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6135), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6051), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6068), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6076), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6127), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6136), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6144), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6145), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6152), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6157), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6167), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6172), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6177), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6147), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6158), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6163), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6173), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6184), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6154), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6164), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6169), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6174), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6180), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6185), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6149), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6155), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6160), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6165), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6175), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6181), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6150), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6161), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6166), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6176), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6182), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 12, 1, 0, 1, 35, 44, DateTimeKind.Local).AddTicks(6187) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyTypeId",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3157), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "26a663db-c79b-489b-ba2c-7d172d38fb87", new DateTime(2023, 11, 28, 21, 48, 5, 652, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 11, 28, 21, 48, 5, 652, DateTimeKind.Local).AddTicks(7312), "AQAAAAIAAYagAAAAEO57kf2Rdb4tRh9akQjQLgwB0AzjKRw2nDMTN4vrzAO8+iLcNvXTPz1zAn14ZRzuBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "53f3eaf9-1f0a-47ae-8150-ce952445ec63", new DateTime(2023, 11, 28, 21, 48, 5, 502, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 11, 28, 21, 48, 5, 502, DateTimeKind.Local).AddTicks(5669), "AQAAAAIAAYagAAAAEO0okzklQdOhHrtmExcGw5R/KurMm3sEHnspC2nMqfJsblPTEb5Bal/LkBaMzADe+g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "380a99a8-cbb2-4390-84c0-e447793b3770", new DateTime(2023, 11, 28, 21, 48, 5, 581, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 11, 28, 21, 48, 5, 581, DateTimeKind.Local).AddTicks(5900), "AQAAAAIAAYagAAAAELwd/00He2cA0qCgbgitnqskYdwUkDjl8HnCBrQj6O4LVXotRhBiyx2hm/zL0qGzMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e47897fa-2697-497a-ab81-9ce965bd1b5d", new DateTime(2023, 11, 28, 21, 48, 5, 419, DateTimeKind.Local).AddTicks(1067), new DateTime(2023, 11, 28, 21, 48, 5, 419, DateTimeKind.Local).AddTicks(1077), "AQAAAAIAAYagAAAAEEaH3GGIb5FdZy2JNjWGfHg7AcseBK1WVankr0KMCkl7Iop2zdz+GPwQSegkw53M0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bc54ef13-dc7a-44b0-991f-d2fa5d3d27e9", new DateTime(2023, 11, 28, 21, 48, 5, 350, DateTimeKind.Local).AddTicks(2152), new DateTime(2023, 11, 28, 21, 48, 5, 350, DateTimeKind.Local).AddTicks(2162), "AQAAAAIAAYagAAAAENjankEPXTPCoffGrMFLLbF+8DgModAsdvKZK7hPDVaqQPGDwJa3/TCAM63ZEwd9Pw==" });

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2807), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2818), "Doanh nghiệp tư nhân", false, "Doanh nghiệp tư nhân" },
                    { 2, new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2900), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2901), "Công ty trách nhiệm hữu hạn một thành viên", false, "Công ty trách nhiệm hữu hạn một thành viên" },
                    { 3, new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2917), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2917), "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên", false, "Công ty trách nhiệm hữu hạn từ hai thành viên trở lên" },
                    { 4, new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2931), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2932), "Công ty cổ phần", false, "Công ty cổ phần" },
                    { 5, new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(2945), "Công ty hợp danh", false, "Công ty hợp danh" }
                });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3088), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3104), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3074), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3166), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3206), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3208), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3217), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3300), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3190), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3301), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3302), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3211), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3294), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3213), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3295), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3296), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3305), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3205), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3298), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3308), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3315), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3320), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3331), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3336), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3346), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3310), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3316), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3326), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3332), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3337), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3342), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3347), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3312), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3317), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3322), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3327), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3338), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3343), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3348), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3313), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3318), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3328), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3334), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3344), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3314), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3324), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3329), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3335), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3340), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3345), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3350), new DateTime(2023, 11, 28, 21, 48, 5, 344, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyTypeId",
                table: "Customers",
                column: "CompanyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CompanyTypes_CompanyTypeId",
                table: "Customers",
                column: "CompanyTypeId",
                principalTable: "CompanyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
