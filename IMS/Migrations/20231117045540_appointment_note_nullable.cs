using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class appointment_note_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TechNote",
                table: "Appointments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Appointments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6170), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6192), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1c8de3c7-b03e-4e1d-afb7-436bae5b7a9d", new DateTime(2023, 11, 17, 11, 55, 39, 327, DateTimeKind.Local).AddTicks(1914), new DateTime(2023, 11, 17, 11, 55, 39, 327, DateTimeKind.Local).AddTicks(1927), "AQAAAAIAAYagAAAAEDZTuEFfpesuqSCnn2av/d0BPNiYV2ZX48ivsFb9tT77FxBJqB3VIhs7PSFUBc7CsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "33a1a31c-9072-4eab-afa6-190099614f3a", new DateTime(2023, 11, 17, 11, 55, 39, 161, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 11, 17, 11, 55, 39, 161, DateTimeKind.Local).AddTicks(8950), "AQAAAAIAAYagAAAAEEORdDtQtYeBQo0gy3w+Dkm0oAT9jgseSG4SyCv1COYnMKSR0DVVidfVe7z3YQ4HAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "06ef5204-dea1-452f-ad34-27e7c37a486d", new DateTime(2023, 11, 17, 11, 55, 39, 247, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 11, 17, 11, 55, 39, 247, DateTimeKind.Local).AddTicks(1877), "AQAAAAIAAYagAAAAEIghqF0VNKsRKAlX7LV5GewSIE8pKEdGP+IPkHgJkCNyEEaYVPyVp7ZJOFjbJm1E4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "24618be1-7206-438e-9a70-466a8b64d45e", new DateTime(2023, 11, 17, 11, 55, 39, 93, DateTimeKind.Local).AddTicks(448), new DateTime(2023, 11, 17, 11, 55, 39, 93, DateTimeKind.Local).AddTicks(464), "AQAAAAIAAYagAAAAEB1Jb/6XWecE5WX0mtlyqH/Dsk6iadoJao9DAk+RKM61hZ1fu/VkqCYqddagiocmTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ef5ef27a-4ded-45ad-9531-9834c6095ece", new DateTime(2023, 11, 17, 11, 55, 39, 25, DateTimeKind.Local).AddTicks(5429), new DateTime(2023, 11, 17, 11, 55, 39, 25, DateTimeKind.Local).AddTicks(5441), "AQAAAAIAAYagAAAAEMsvjF8vb7Xa4LY+/nvD7sB8aDV5oxtuyZOJNpmOnn0ilkfM8JNLBFRiZzildlrLew==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(5988), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6004), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6018), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6056), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6074), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6089), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6125), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6103), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6199), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6243), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6216), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6270), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6278), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6271), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6279), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6272), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6280), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6273), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6281), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6231), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6282), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6275), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6224), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6267), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6283), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6285), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6297), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6303), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6293), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6304), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6314), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6294), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6299), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6315), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6295), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6300), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6306), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6296), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6302), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6312), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6317), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 11, 17, 11, 55, 39, 20, DateTimeKind.Local).AddTicks(6332) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TechNote",
                table: "Appointments",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Appointments",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9901), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9923), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "01bb02e6-c497-43e4-af80-aeb8484ec913", new DateTime(2023, 11, 17, 10, 54, 30, 329, DateTimeKind.Local).AddTicks(3461), new DateTime(2023, 11, 17, 10, 54, 30, 329, DateTimeKind.Local).AddTicks(3473), "AQAAAAIAAYagAAAAEEz639QW4kTeurpI72J/l3TTtmYg6Yp2mslqupawY47Cw1leyVXhV+QNJHi+oQjpzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8d2b49b2-2537-405f-ac6c-9ab97901de23", new DateTime(2023, 11, 17, 10, 54, 30, 178, DateTimeKind.Local).AddTicks(1029), new DateTime(2023, 11, 17, 10, 54, 30, 178, DateTimeKind.Local).AddTicks(1041), "AQAAAAIAAYagAAAAEBcOy8UgwYXJgUp73x3w6Ho6SoVW+n2ZtLomSx2go/CRHGt+X+vgQg0e1PikMqr97w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "caef2d7d-1857-4de3-85c4-6ec9acce8b36", new DateTime(2023, 11, 17, 10, 54, 30, 255, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 11, 17, 10, 54, 30, 255, DateTimeKind.Local).AddTicks(2496), "AQAAAAIAAYagAAAAEDJvirc5SM9x93RqR8l3++yGSmdGNlL5Pksdf65GmFolPIs7LUb0eeYcAxQFzuQ9eQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ac17d013-a4f8-4bbf-ba80-2efaaf6517a4", new DateTime(2023, 11, 17, 10, 54, 30, 105, DateTimeKind.Local).AddTicks(9647), new DateTime(2023, 11, 17, 10, 54, 30, 105, DateTimeKind.Local).AddTicks(9660), "AQAAAAIAAYagAAAAEIsGrtB4rvhHgusVbpiEmHf001IW/KUbcatAkFcHCa9r+xD8zUq6TTrzP4mpxeLiMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e5b66bcc-5e0f-4465-ba66-a378c27bda15", new DateTime(2023, 11, 17, 10, 54, 30, 34, DateTimeKind.Local).AddTicks(2361), new DateTime(2023, 11, 17, 10, 54, 30, 34, DateTimeKind.Local).AddTicks(2378), "AQAAAAIAAYagAAAAEGMWjQRmDi4wj1ycuD0toGjAnRaqkt3P7Ph34N73LCaKP+HjpVX/w/8mus2y5ABzLw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9642), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9872), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9845), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9933), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9965), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9974), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9982), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(41), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(49), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9958), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9967), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(34), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(42), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9948), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(43), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(51), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9960), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9969), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9977), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(36), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9951), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9970), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9978), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(45), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9953), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9962), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(30), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(38), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(46), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(54), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9954), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9963), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9972), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9980), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(39), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(47), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9973), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9981), new DateTime(2023, 11, 17, 10, 54, 30, 28, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(32), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(40), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(48), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(56), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(58), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(65), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(86), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(96), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(60), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(66), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(82), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(92), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(97), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(62), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(72), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(93), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(68), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(73), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(84), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(89), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(94), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(64), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(95), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(100), new DateTime(2023, 11, 17, 10, 54, 30, 29, DateTimeKind.Local).AddTicks(101) });
        }
    }
}
