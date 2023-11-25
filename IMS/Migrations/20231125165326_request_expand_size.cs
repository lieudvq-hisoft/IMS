using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_expand_size : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "RequestExpands",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9625), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "d55361c0-03e9-4966-b810-06b1727e583d", new DateTime(2023, 11, 25, 23, 53, 25, 631, DateTimeKind.Local).AddTicks(7057), new DateTime(2023, 11, 25, 23, 53, 25, 631, DateTimeKind.Local).AddTicks(7068), "AQAAAAIAAYagAAAAEEkZu2HrR+GnYuB3O9AGJt4dlW/gSFhix3T9MOrZIx30c7VhUmYLhqP3eNZNYOh4tA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ee735ecf-b9ec-4f87-91ff-8faf7fa1e00a", new DateTime(2023, 11, 25, 23, 53, 25, 475, DateTimeKind.Local).AddTicks(7549), new DateTime(2023, 11, 25, 23, 53, 25, 475, DateTimeKind.Local).AddTicks(7560), "AQAAAAIAAYagAAAAEGxaD09AVBSGfuVd69nv7LEcPjuB/s9K8loZuCKQ3HQVSBA3bfYEIy5ExJWmgcreGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "dec23a1e-f9ec-498d-9b8a-844e3bb4337d", new DateTime(2023, 11, 25, 23, 53, 25, 555, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 11, 25, 23, 53, 25, 555, DateTimeKind.Local).AddTicks(6266), "AQAAAAIAAYagAAAAEKnKXUTSKwg/TiSD/SVuq3GN8/fA0R295HqJp10eS876dZdp+pSfZeu/8DNZd5+pTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "aa7605da-5bc8-461d-b543-6470b56e3a5f", new DateTime(2023, 11, 25, 23, 53, 25, 404, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 11, 25, 23, 53, 25, 404, DateTimeKind.Local).AddTicks(7933), "AQAAAAIAAYagAAAAEJWF4uvv+/QmIDUul/ZW+6oZMN7gXcgX268gcgeKiukd7RiekuN+PQIZ/XtyECcGmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a504fdab-48bf-49fb-8989-b6088459d043", new DateTime(2023, 11, 25, 23, 53, 25, 330, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 11, 25, 23, 53, 25, 330, DateTimeKind.Local).AddTicks(404), "AQAAAAIAAYagAAAAEGB5neZuzkrFhJhrXl4wlzJpACzf+a6Dl+B7fvxivFtdRfwmvkjafu0Tf/tThix9AQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9196), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9383), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9409), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9423), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9435), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9467), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9487), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9500), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9575), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9589), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9560), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9738), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9689), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9706), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9716), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9724), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9732), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9717), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9725), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9733), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9741), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9682), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9734), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9727), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9720), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9736), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9721), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9729), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9737), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9744), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9789), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9795), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9801), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9811), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9816), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9792), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9817), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9783), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9788), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9803), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9808), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 11, 25, 23, 53, 25, 324, DateTimeKind.Local).AddTicks(9818) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "RequestExpands");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5756), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6eab4ab2-a8f5-4cf9-8d92-af92e39f1e1d", new DateTime(2023, 11, 25, 23, 50, 41, 824, DateTimeKind.Local).AddTicks(6292), new DateTime(2023, 11, 25, 23, 50, 41, 824, DateTimeKind.Local).AddTicks(6350), "AQAAAAIAAYagAAAAEAuEsLcozzKG1QVpslbncU4ABXU23YxaQn1kM9XznsX3jz/A0RUYdyuGxiVbsQ22Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "7cd90252-e9fd-4343-9b32-e874ffffa9e8", new DateTime(2023, 11, 25, 23, 50, 41, 676, DateTimeKind.Local).AddTicks(7002), new DateTime(2023, 11, 25, 23, 50, 41, 676, DateTimeKind.Local).AddTicks(7014), "AQAAAAIAAYagAAAAEKHi2tB6ohLG24QkKOiUIpm+ZV6ErB5KdZfLywXAZJr6Y1snG1Oyc2yGR9sVI7cAEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "277f64e6-ca75-4e63-abc6-77556118d61d", new DateTime(2023, 11, 25, 23, 50, 41, 753, DateTimeKind.Local).AddTicks(9281), new DateTime(2023, 11, 25, 23, 50, 41, 753, DateTimeKind.Local).AddTicks(9292), "AQAAAAIAAYagAAAAEPrGRGWn1MIK8LpPF7IMSbESPPUutti6oU4jOyFzg94g0zfgGLx2+XlMbjMRNGqB7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "b4976463-96e6-4dec-8f01-df41787de6d5", new DateTime(2023, 11, 25, 23, 50, 41, 579, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 11, 25, 23, 50, 41, 579, DateTimeKind.Local).AddTicks(8650), "AQAAAAIAAYagAAAAEKcZUwzPAjST0MPVOMC6eBiWGF60yHzKnRzbcOXD0Su0loO2y8+M8ys+eO4FgOtspg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "8de6f636-a8ab-4eda-b8db-893a0e7398ff", new DateTime(2023, 11, 25, 23, 50, 41, 502, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 11, 25, 23, 50, 41, 502, DateTimeKind.Local).AddTicks(1139), "AQAAAAIAAYagAAAAEPu7QHRgrT893NP5I35mKwvHBzqJcQiO9F4n2x5AUhj2+KECH6NB5fZyQSl24j59uw==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5478), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5590), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5604), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5617), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5646), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5666), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5680), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5709), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5725), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5788), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5817), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5864), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5873), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5896), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5808), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5866), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5874), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5889), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5897), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5905), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5820), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5867), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5875), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5883), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5891), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5898), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5906), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5821), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5868), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5884), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5892), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5869), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5876), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5885), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5908), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5814), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5870), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5886), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5893), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5901), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5909), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5862), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5871), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5878), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5894), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5902), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5910), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5863), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5879), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5887), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5895), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5911), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5912), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5919), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5924), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5928), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5933), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5938), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5971), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5976), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5915), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5925), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5929), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5934), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5939), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5972), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5977), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5916), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5921), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5930), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5940), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5973), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5978), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5917), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5922), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5931), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5936), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5941), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5974), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5978), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5918), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5923), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5927), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5932), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5937), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5970), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5975), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5979), new DateTime(2023, 11, 25, 23, 50, 41, 496, DateTimeKind.Local).AddTicks(5980) });
        }
    }
}
