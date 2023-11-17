using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class inspection_report_request_expand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InspectionReportFilePath",
                table: "RequestExpands",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsServer",
                table: "LocationAssignments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8254), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8275), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7d2f7519-87b8-464d-86e9-3e9f10683499", new DateTime(2023, 11, 17, 14, 25, 12, 756, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 11, 17, 14, 25, 12, 756, DateTimeKind.Local).AddTicks(2756), "AQAAAAIAAYagAAAAEOqY6NVhFm63Sp+zsLNWVyl8tVKlHKvzSLr8aqNK18J30Nim1YnuWwLu/x4lOfnVRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f815cef0-cfa8-45f3-a5ad-f99f49a1a242", new DateTime(2023, 11, 17, 14, 25, 12, 598, DateTimeKind.Local).AddTicks(917), new DateTime(2023, 11, 17, 14, 25, 12, 598, DateTimeKind.Local).AddTicks(931), "AQAAAAIAAYagAAAAEPNMElgVjjhRv/MrGWPHUbXhO5uANDbIL+bFFYy4XoWpYOYXmUq97G4rgPjhn2NSZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "86ffd7ac-d3a7-4ab9-aa75-f871e0626a09", new DateTime(2023, 11, 17, 14, 25, 12, 681, DateTimeKind.Local).AddTicks(640), new DateTime(2023, 11, 17, 14, 25, 12, 681, DateTimeKind.Local).AddTicks(650), "AQAAAAIAAYagAAAAEJHwElmY1gQraFr6t2u0tA1L+MX/H122xQQhmYjVKSLP5aT4Rr0adqYZ9qTvGyylLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3e984d5c-928c-4494-8508-0b00087bf8c2", new DateTime(2023, 11, 17, 14, 25, 12, 528, DateTimeKind.Local).AddTicks(6091), new DateTime(2023, 11, 17, 14, 25, 12, 528, DateTimeKind.Local).AddTicks(6103), "AQAAAAIAAYagAAAAEDF3r6qSPzbkp8BFbOEyrUCNswwuW/KT8L9kYKEpRENlKUuBjv6zWLG+unXFM83Ddg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "21ccd8ad-a665-43a7-96e9-25b82ecd4433", new DateTime(2023, 11, 17, 14, 25, 12, 459, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 11, 17, 14, 25, 12, 459, DateTimeKind.Local).AddTicks(5008), "AQAAAAIAAYagAAAAEHbSQvOyAFChVuLv9tdRQ1ClULnn5V1fOY5rjCCytD93S5TwfBH3Y4vnsvLyJDVI9A==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8079), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8108), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8156), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8172), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8207), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8224), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8186), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8330), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8339), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8346), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8302), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8304), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8333), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8349), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8373), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8305), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8325), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8334), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8350), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8326), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8335), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8351), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8352), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8368), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8376), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8344), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8353), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8369), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8338), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8345), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8354), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8362), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8378), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8396), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8536), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8551), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8392), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8537), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8542), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8547), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8532), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8553), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8534), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8549), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8535), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8540), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8545), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 11, 17, 14, 25, 12, 454, DateTimeKind.Local).AddTicks(8555) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionReportFilePath",
                table: "RequestExpands");

            migrationBuilder.DropColumn(
                name: "IsServer",
                table: "LocationAssignments");

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
    }
}
