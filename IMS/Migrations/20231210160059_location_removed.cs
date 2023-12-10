using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class location_removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LocationRemoved",
                table: "ServerAllocations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "0302d5e0-e0d4-40fe-a692-1ab89724236b", new DateTime(2023, 12, 10, 23, 0, 57, 423, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 12, 10, 23, 0, 57, 423, DateTimeKind.Local).AddTicks(6039), "AQAAAAIAAYagAAAAEMTkWzkszP11lqHC1r4s5xsu3JaRM4Z/ryK4zT2c5at3MqMAAw0IH5p7jZIM503e1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "cc1cd818-856d-4956-ad02-4dd1fd3e3703", new DateTime(2023, 12, 10, 23, 0, 57, 530, DateTimeKind.Local).AddTicks(4317), new DateTime(2023, 12, 10, 23, 0, 57, 530, DateTimeKind.Local).AddTicks(4339), "AQAAAAIAAYagAAAAEL5SG5mzApzghb1Qg58LBnB/ELMPCzAyd4TAatVUoH1GsLH0eeZVBTPRFdNOALVaig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "11c11153-bb8e-4efc-92db-911858329668", new DateTime(2023, 12, 10, 23, 0, 57, 340, DateTimeKind.Local).AddTicks(3052), new DateTime(2023, 12, 10, 23, 0, 57, 340, DateTimeKind.Local).AddTicks(3069), "AQAAAAIAAYagAAAAEGaVw8g8RzAbdHTbip5CM0bvMivXbuzpgCjOd9couIP7I2UM3lz+iy6tJJcDwq+VBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "bcd359f5-ea8c-4c3c-af46-c8c273df790e", new DateTime(2023, 12, 10, 23, 0, 57, 225, DateTimeKind.Local).AddTicks(4294), new DateTime(2023, 12, 10, 23, 0, 57, 225, DateTimeKind.Local).AddTicks(4305), "AQAAAAIAAYagAAAAEJA4j2pEhzXdZ8frXcbs1sYWwa0d0npQoVDW/N5c+u9itlxkzL7CzuljgoiGUWCqTA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9430), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9701), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9785), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 12, 10, 23, 0, 57, 219, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(5), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(106), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(198), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(14), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(84), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(179), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(199), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(135), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(19), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(206), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(227), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(247), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(92), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(163), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(187), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(27), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(96), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(143), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(166), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(49), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(99), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(168), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(191), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(102), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(148), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(171), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(285), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(300), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(376), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(303), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(353), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(289), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(381), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(292), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(342), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(359), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(386), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(296), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(387), new DateTime(2023, 12, 10, 23, 0, 57, 220, DateTimeKind.Local).AddTicks(389) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationRemoved",
                table: "ServerAllocations");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1516), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "85abc6a3-d02a-4f0d-9f6e-27b0117a0bc6", new DateTime(2023, 12, 10, 22, 44, 5, 722, DateTimeKind.Local).AddTicks(2095), new DateTime(2023, 12, 10, 22, 44, 5, 722, DateTimeKind.Local).AddTicks(2108), "AQAAAAIAAYagAAAAEPclAEDoXExWXyt/7VZCGscsilGHrIzhHXzE3YdfrVmYFmDhbaUWf8Tcv33iojzH5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1b2cdd5d-22f1-422e-847c-7b1d7ed1e62e", new DateTime(2023, 12, 10, 22, 44, 5, 795, DateTimeKind.Local).AddTicks(785), new DateTime(2023, 12, 10, 22, 44, 5, 795, DateTimeKind.Local).AddTicks(798), "AQAAAAIAAYagAAAAEFLfCqwwOY3NHYqHxkK+FGGaRLkzzx6xnOBoxXVZ2ltWYy7I6qxt1FKas5D9T96nzQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4d2ccddb-8040-4fc0-82c5-68e683f6c088", new DateTime(2023, 12, 10, 22, 44, 5, 649, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 12, 10, 22, 44, 5, 649, DateTimeKind.Local).AddTicks(6247), "AQAAAAIAAYagAAAAEBpOLomy7hvdT7KSf5Hi9sBRaVb4it5Pf1RXKYQDdOCIlQZdPqxAVPMMbMV1+UHZQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "4e42ea41-1688-4f43-ae7a-72cd3a88337f", new DateTime(2023, 12, 10, 22, 44, 5, 579, DateTimeKind.Local).AddTicks(7902), new DateTime(2023, 12, 10, 22, 44, 5, 579, DateTimeKind.Local).AddTicks(7914), "AQAAAAIAAYagAAAAEJ5TLdU2zamUSS8fDYg8fUYkGVCm3nSI/G+f7YpBRjw3ooaD++F+ikpufxmBxIX+Ag==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1075), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1379), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1473), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1597), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1691), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1698), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1707), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1715), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1607), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1692), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1700), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1708), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1723), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1701), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1709), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1686), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1702), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1710), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1725), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1694), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1703), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1711), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1726), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1567), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1688), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1695), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1704), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1712), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1719), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1727), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1689), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1696), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1705), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1720), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1728), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1697), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1706), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1714), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1721), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1729), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1733), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1740), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1749), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1754), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1763), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1736), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1741), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1746), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1750), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1755), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1764), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1742), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1746), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1751), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1756), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1760), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1765), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1743), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1747), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1757), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1761), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1807), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1738), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1744), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1748), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1753), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1758), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1762), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1767), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 12, 10, 22, 44, 5, 575, DateTimeKind.Local).AddTicks(1808) });
        }
    }
}
