using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class note_to_reason : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Note",
                table: "IpAddresses",
                newName: "Reason");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(167), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "61815159-1bd2-4ae2-8108-768bafffa4db", new DateTime(2023, 12, 3, 0, 6, 40, 331, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 12, 3, 0, 6, 40, 331, DateTimeKind.Local).AddTicks(2802), "AQAAAAIAAYagAAAAEGrIbYRGoW5cajB3iKYT3ICP6CT+yvgVOLx4lTabLg3ShVTxNQ7nxYsGPijQjlDZGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "112a994a-dd46-423e-a366-c4b75ea724f7", new DateTime(2023, 12, 3, 0, 6, 39, 982, DateTimeKind.Local).AddTicks(1095), new DateTime(2023, 12, 3, 0, 6, 39, 982, DateTimeKind.Local).AddTicks(1112), "AQAAAAIAAYagAAAAEI/esZ+Uy1G68Cuq4DhfuoeQQZrpgM+pnm/ICEMKWM9xKD8QKGBnEvu2mgss822dBg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "6f0bc564-0684-44d8-9cef-ed5c98b174b1", new DateTime(2023, 12, 3, 0, 6, 40, 126, DateTimeKind.Local).AddTicks(942), new DateTime(2023, 12, 3, 0, 6, 40, 126, DateTimeKind.Local).AddTicks(954), "AQAAAAIAAYagAAAAEIX47AjEK7Uu/m1htgxW4FrFstipye0jgFW+7OcoUOPflHPp5ctGgwEJdcgPi6DzXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fca3c1a4-0bfb-460d-bee2-736103bfbf48", new DateTime(2023, 12, 3, 0, 6, 39, 896, DateTimeKind.Local).AddTicks(3504), new DateTime(2023, 12, 3, 0, 6, 39, 896, DateTimeKind.Local).AddTicks(3522), "AQAAAAIAAYagAAAAECZfAXdhfSizyvQLtwmbOYpxGwM8qZWX42SXWDi4KZY1qfyn1C1avo85r4ryJwK/Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fde2dc7e-56c6-4976-bd48-ebd666fed147", new DateTime(2023, 12, 3, 0, 6, 39, 792, DateTimeKind.Local).AddTicks(7062), new DateTime(2023, 12, 3, 0, 6, 39, 792, DateTimeKind.Local).AddTicks(7079), "AQAAAAIAAYagAAAAEAVfLHlaOLrKLPSu1i4RPQuhhkRNvajJPfDshqCqSmmNP2Db34RiUCHosOPSRhXGWA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 782, DateTimeKind.Local).AddTicks(9882), new DateTime(2023, 12, 3, 0, 6, 39, 782, DateTimeKind.Local).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(51), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(115), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(220), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(266), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(275), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(295), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(303), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(278), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(287), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(236), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(288), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(298), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(272), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(281), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(315), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(264), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(283), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(292), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(325), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(375), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(380), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(385), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(390), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(396), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(401), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(406), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(370), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(397), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(402), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(407), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(377), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(382), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(398), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(403), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(408), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(388), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(404), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(409), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(374), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(379), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(384), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(389), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(395), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 12, 3, 0, 6, 39, 783, DateTimeKind.Local).AddTicks(410) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "IpAddresses",
                newName: "Note");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8732), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3889c68e-0745-429e-818f-95749094a297", new DateTime(2023, 12, 2, 22, 12, 31, 823, DateTimeKind.Local).AddTicks(8154), new DateTime(2023, 12, 2, 22, 12, 31, 823, DateTimeKind.Local).AddTicks(8167), "AQAAAAIAAYagAAAAEGSrJOnqM9tDgH41t4RYv5tgTSN0WqbHk7h5u9GVGYOACV4b5hcCZ4Y1mlYhJ6n6LQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "79d35c75-6c48-407d-8aee-22a5ef61fde7", new DateTime(2023, 12, 2, 22, 12, 31, 550, DateTimeKind.Local).AddTicks(7806), new DateTime(2023, 12, 2, 22, 12, 31, 550, DateTimeKind.Local).AddTicks(7820), "AQAAAAIAAYagAAAAEKJSO1IqQhsXkgPsItGSddmVXJewMlLiCg+vBJNCrAurv5KbbFLIN0+olnVUCn6JsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fc68af79-4b0c-44e8-875b-3bf204d66297", new DateTime(2023, 12, 2, 22, 12, 31, 696, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 12, 2, 22, 12, 31, 696, DateTimeKind.Local).AddTicks(5622), "AQAAAAIAAYagAAAAEJbvc9CEf4wFlZaPOwfdPwp2FV2e5FsvzuFFpceBGgNk6om/k+49G8wQ1qB3Ec1z5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3fb043a7-2f1f-4c11-93b2-07e0b45329ee", new DateTime(2023, 12, 2, 22, 12, 31, 392, DateTimeKind.Local).AddTicks(3306), new DateTime(2023, 12, 2, 22, 12, 31, 392, DateTimeKind.Local).AddTicks(3326), "AQAAAAIAAYagAAAAED8qirbotkFuddIXi29oBsLzmoFFb8wAPtTjwCm8b71NZhqU/bOYJ2Q1ccgr8hzxRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "484bf6a5-ea8a-47b2-a701-622ff9ffa15f", new DateTime(2023, 12, 2, 22, 12, 31, 249, DateTimeKind.Local).AddTicks(3264), new DateTime(2023, 12, 2, 22, 12, 31, 249, DateTimeKind.Local).AddTicks(3277), "AQAAAAIAAYagAAAAEAgQt6qGsuXWzCXkBewqAQ+oVIzq/S4LD//FYK+ZBGviEIFILNsbZMhP4icFtbthxQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8517), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8662), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8687), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8674), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8917), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9023), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8820), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8904), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8920), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8947), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8823), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8906), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8922), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8935), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8948), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9027), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8837), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8908), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8840), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8910), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8926), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8938), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8952), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9030), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8911), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8928), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8953), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9032), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8913), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8929), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8942), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8955), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9034), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8915), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8931), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9035), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9081), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9090), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9100), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9110), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9052), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9062), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9072), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9082), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9092), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9101), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9044), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9054), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9074), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9084), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9103), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9046), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9056), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9066), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9076), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9105), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9116), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9048), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9058), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9078), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9088), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9098), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 12, 2, 22, 12, 31, 243, DateTimeKind.Local).AddTicks(9119) });
        }
    }
}
