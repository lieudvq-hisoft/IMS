using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class incident_resolved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsResolved",
                table: "Incidents",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "937d1739-5fbb-4bb5-b019-39e0580e14d4", new DateTime(2023, 12, 19, 23, 56, 3, 635, DateTimeKind.Local).AddTicks(1852), new DateTime(2023, 12, 19, 23, 56, 3, 635, DateTimeKind.Local).AddTicks(1865), new List<string>(), "AQAAAAIAAYagAAAAEHBphBfEQEv7p+bcdFZUjBo9l7Jp4PxFLqXvf8U5K9NX9oKyk+g1C+j+GlVrktyISg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9517c0d1-b5d7-4e0a-940a-3130a98d8633", new DateTime(2023, 12, 19, 23, 56, 3, 715, DateTimeKind.Local).AddTicks(3664), new DateTime(2023, 12, 19, 23, 56, 3, 715, DateTimeKind.Local).AddTicks(3680), new List<string>(), "AQAAAAIAAYagAAAAEL/CGYuwCGS6jT5wtFMfLPGutggn1Lpai2+k1MLawh3NU1eqNcx5mYzYvQGtCZJZ+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "66100859-21ad-4629-a3d1-a4036171e38b", new DateTime(2023, 12, 19, 23, 56, 3, 562, DateTimeKind.Local).AddTicks(586), new DateTime(2023, 12, 19, 23, 56, 3, 562, DateTimeKind.Local).AddTicks(598), new List<string>(), "AQAAAAIAAYagAAAAEFSve4l5+ucSkCKAGauI7OIGrwT0NA9kRy+G9plLgJFMJLbjU5OFrE0jSwGMUrU8KQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b50e71c7-38b5-4472-89c4-225269d87002", new DateTime(2023, 12, 19, 23, 56, 3, 480, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 12, 19, 23, 56, 3, 480, DateTimeKind.Local).AddTicks(9697), new List<string>(), "AQAAAAIAAYagAAAAEFLaN96PaeIY+gjvchTYlg6f0tVRfcI5Imebv0OxGasPR8/dHBMTKh6NPuAvizppEg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8544), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8657), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8665), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8672), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8745), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8754), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8827), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8828), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8829), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8717), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8789), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8830), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8759), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8822), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8831), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8720), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8824), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8832), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8730), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8825), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8833), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8826), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8834), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8836), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8839), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 19, 23, 56, 3, 477, DateTimeKind.Local).AddTicks(8877) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsResolved",
                table: "Incidents");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c9c3b707-eb17-4c95-9bb6-683e77f44371", new DateTime(2023, 12, 19, 23, 27, 55, 261, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 12, 19, 23, 27, 55, 261, DateTimeKind.Local).AddTicks(2238), new List<string>(), "AQAAAAIAAYagAAAAEGwUAAx1Eac+iDoEl7ANzuH5LcV/c0Scer+u3aOnoxAeZQzCSANtzy9kWsqMvvDldg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f371dceb-6c82-4e0d-adc1-e94e16d6f590", new DateTime(2023, 12, 19, 23, 27, 55, 351, DateTimeKind.Local).AddTicks(6867), new DateTime(2023, 12, 19, 23, 27, 55, 351, DateTimeKind.Local).AddTicks(6880), new List<string>(), "AQAAAAIAAYagAAAAEBakZRZZHoEa9c49B8lW9Nx8h9dgPh8JY1FeeLtWiFnwXr4y/I2O8e805J1mG8edXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "36dc96c2-d5d4-4250-82c8-eb3b81478e33", new DateTime(2023, 12, 19, 23, 27, 55, 175, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 12, 19, 23, 27, 55, 175, DateTimeKind.Local).AddTicks(4991), new List<string>(), "AQAAAAIAAYagAAAAEGLKgSS1X6dtq3eolhBho0unrTQC+id1bHZI6T9mRdv4gE2uxG6eYmwb7fWJyEj/XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c19ee94a-53fb-4c21-a23e-1f2118bf31aa", new DateTime(2023, 12, 19, 23, 27, 55, 103, DateTimeKind.Local).AddTicks(2758), new DateTime(2023, 12, 19, 23, 27, 55, 103, DateTimeKind.Local).AddTicks(2768), new List<string>(), "AQAAAAIAAYagAAAAEJovTcBYjNpwWIz0vUxMOSXe+kzkVslHWaa4kVPyFODV8ZacJj8f7Ln2vdjdTnFQVw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8631), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8735), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8746), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8885), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8806), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8860), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8936), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8944), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8807), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8861), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8869), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8946), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8809), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8939), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8883), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8892), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8941), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8949), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8933), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8959), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8965), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8981), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8986), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8991), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8954), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8971), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8992), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8967), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8972), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8988), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8968), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8973), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8979), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8994), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8985), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 12, 19, 23, 27, 55, 98, DateTimeKind.Local).AddTicks(8996) });
        }
    }
}
