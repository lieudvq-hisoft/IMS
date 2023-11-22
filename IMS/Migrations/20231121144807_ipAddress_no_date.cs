using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ipAddress_no_date : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "IpAddresses");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "IpAddresses");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7647), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0943e718-2645-4bb8-bd48-c3749f6a7b25", new DateTime(2023, 11, 21, 21, 48, 5, 809, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 11, 21, 21, 48, 5, 809, DateTimeKind.Local).AddTicks(1145), "AQAAAAIAAYagAAAAEJSx30QCutvtEnPqQQQ4Fw47DxPuPzc7OUwNFYVsD+PC4lm9Ck6PIFRb5x5cSr7SuA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e976b57c-5d4b-4fe7-8041-75ed374954e4", new DateTime(2023, 11, 21, 21, 48, 5, 278, DateTimeKind.Local).AddTicks(1440), new DateTime(2023, 11, 21, 21, 48, 5, 278, DateTimeKind.Local).AddTicks(1454), "AQAAAAIAAYagAAAAECkaqEK0Pvw3LtQ8aYWXZd05Fy1DipQYxMmAFBKLJYeJaUl2+SV0dFFE6e4IzJfR9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "e39cdb5f-fa6b-426d-82c8-93c23359093b", new DateTime(2023, 11, 21, 21, 48, 5, 410, DateTimeKind.Local).AddTicks(1263), new DateTime(2023, 11, 21, 21, 48, 5, 410, DateTimeKind.Local).AddTicks(1278), "AQAAAAIAAYagAAAAEIIj6LlpSmXIEV7dd6F1GevNDGTHadjGuvsrxShb63WLsA/i2JtXjdlUcGcUdX+wwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dfd057da-12b7-4955-b95d-7092711261a4", new DateTime(2023, 11, 21, 21, 48, 5, 158, DateTimeKind.Local).AddTicks(8211), new DateTime(2023, 11, 21, 21, 48, 5, 158, DateTimeKind.Local).AddTicks(8226), "AQAAAAIAAYagAAAAEItf3YNHS7i22tBIHFOnXmn3B0PwBKatZXPXyLPFLAQwKgVmh+kcTBts1Xfj/YkUFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bfd87dc8-b09e-4778-ab5c-8a4061e010a6", new DateTime(2023, 11, 21, 21, 48, 5, 73, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 11, 21, 21, 48, 5, 73, DateTimeKind.Local).AddTicks(4774), "AQAAAAIAAYagAAAAEFtoV8iQQj8dj4YBoJvUgOkcmTkz289TeLFbuoqx7pVPwTb2tnxUJwZZNYOxvn70Sw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7513), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7523), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7531), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7564), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7578), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7588), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7613), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7624), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7695), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7705), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7684), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7696), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7707), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7716), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7752), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7686), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7698), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7708), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7717), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7735), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7744), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7687), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7699), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7710), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7719), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7736), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7754), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7764), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7688), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7700), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7711), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7755), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7691), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7702), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7712), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7721), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7738), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7757), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7766), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7692), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7703), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7713), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7740), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7693), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7704), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7714), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7759), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7778), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7796), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7801), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7807), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7813), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7773), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7785), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7802), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7808), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7814), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7781), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7786), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7792), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7798), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7804), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7809), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7815), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7776), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7793), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7799), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7805), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7816), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7783), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7789), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7806), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7811), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7817), new DateTime(2023, 11, 21, 21, 48, 5, 70, DateTimeKind.Local).AddTicks(7818) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "IpAddresses",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "IpAddresses",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4130), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4164), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "851e3323-af5c-4eca-809a-aa49c6fa82f9", new DateTime(2023, 11, 21, 21, 19, 32, 968, DateTimeKind.Local).AddTicks(598), new DateTime(2023, 11, 21, 21, 19, 32, 968, DateTimeKind.Local).AddTicks(615), "AQAAAAIAAYagAAAAEEBbeXO5gSJ9pwIZrXik+R3z7q5TsRuuOthD7WdF0OoX7/S7UGEy1XqGvn7KBSzfKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "92b1a83f-c24c-4908-aa21-ae1347e5b70e", new DateTime(2023, 11, 21, 21, 19, 32, 742, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 11, 21, 21, 19, 32, 742, DateTimeKind.Local).AddTicks(4108), "AQAAAAIAAYagAAAAECNfT2eBOp/hWUg2nE4V8+tT8aAraChhJwtdnnYy+B7OngNMGWS3GoSjX+IOAgjOjQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3479100a-9f56-47d6-aa9d-1b5dcee75307", new DateTime(2023, 11, 21, 21, 19, 32, 875, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 11, 21, 21, 19, 32, 875, DateTimeKind.Local).AddTicks(2210), "AQAAAAIAAYagAAAAEIOrcv3qt6TX0TYQuQFt3zF+0oitmHul4RKgF0elxxJC1UW8fRi5jp0Bghmzvl85wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8e068c1b-447f-4c73-b953-b2c24333fa03", new DateTime(2023, 11, 21, 21, 19, 32, 651, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 11, 21, 21, 19, 32, 651, DateTimeKind.Local).AddTicks(1168), "AQAAAAIAAYagAAAAEG0Lj6qSzAM4whnSrobokBn5fK74LyOVDSVQT1WnA+fs/D7/4kqfHMAdnAQpq8FJ6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "40880607-26f8-4f34-9a4b-1204bf4badc6", new DateTime(2023, 11, 21, 21, 19, 32, 568, DateTimeKind.Local).AddTicks(3330), new DateTime(2023, 11, 21, 21, 19, 32, 568, DateTimeKind.Local).AddTicks(3342), "AQAAAAIAAYagAAAAEKrbrYiNkuKN1C+h5TBvRi/GFlDOXHDKcXbkRi8PT+fNOAJlhVb2JpVJRQT+U9LakQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3891), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3981), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4058), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4077), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4095), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4110), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4086), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4186), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4207), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4226), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4236), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4252), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4175), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4199), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4218), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4228), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4253), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4177), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4189), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4220), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4229), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4244), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4254), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4190), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4201), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4211), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4221), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4230), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4246), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4255), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4192), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4222), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4231), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4247), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4256), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4182), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4193), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4213), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4223), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4232), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4248), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4257), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4183), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4205), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4224), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4233), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4249), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4258), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4184), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4195), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4225), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4234), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4250), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4259), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4261), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4268), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4274), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4280), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4286), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4292), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4298), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4304), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4264), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4276), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4282), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4287), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4293), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4299), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4305), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4265), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4271), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4277), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4283), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4289), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4300), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4306), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4266), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4278), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4284), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4290), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4295), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4301), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4307), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4267), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4273), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4279), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4285), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4291), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4296), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4302), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4308), new DateTime(2023, 11, 21, 21, 19, 32, 564, DateTimeKind.Local).AddTicks(4308) });
        }
    }
}
