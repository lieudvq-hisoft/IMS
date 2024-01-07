using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class ip_history_current_server : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentServerId",
                table: "IpHistories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5509), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2806c0d7-569f-4532-81c4-ce77e7d2c68f", new DateTime(2024, 1, 7, 13, 39, 45, 65, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 1, 7, 13, 39, 45, 65, DateTimeKind.Local).AddTicks(880), new List<string>(), "AQAAAAIAAYagAAAAEFR4OqB06Lj5LfU44B9kjEDid6EmOeOTx+bkQWASUznlmS/wmKSJLFoJe9UJqE7tDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "936cab50-de2b-4e7f-b315-069a1cd94a2e", new DateTime(2024, 1, 7, 13, 39, 45, 154, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 1, 7, 13, 39, 45, 154, DateTimeKind.Local).AddTicks(6958), new List<string>(), "AQAAAAIAAYagAAAAENdEWBqsCB5oPu8c2FlsWXwiwaEwig7Aak72DIn//QGtt7Podf2jZ725p64PESqGPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7d43fb12-34ba-4788-8ee4-1f1511f75ac6", new DateTime(2024, 1, 7, 13, 39, 44, 978, DateTimeKind.Local).AddTicks(9901), new DateTime(2024, 1, 7, 13, 39, 44, 978, DateTimeKind.Local).AddTicks(9918), new List<string>(), "AQAAAAIAAYagAAAAEFocXL6/kMibifINJruyFuNlisenGbP+tUtwlKUkOoyuvJRCZ7OQGX/RWvNuJdTRog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a1ae7c68-8962-49a3-a755-bf18155767ec", new DateTime(2024, 1, 7, 13, 39, 44, 874, DateTimeKind.Local).AddTicks(4420), new DateTime(2024, 1, 7, 13, 39, 44, 874, DateTimeKind.Local).AddTicks(4426), new List<string>(), "AQAAAAIAAYagAAAAEJ5BSHVBdOTT4n64NcpiFXEa8v9oOMBPrIunv4hlBGqyxTSEObFpsDHv3GwfRC6VCg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5462), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5516), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5627), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5635), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5643), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5651), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5585), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5620), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5644), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5652), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5563), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5621), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5629), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5645), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5622), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5654), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5566), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5623), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5655), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5569), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5607), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5632), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5648), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5571), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5608), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5633), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5641), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5625), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5660), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5706), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5711), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5726), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5662), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5667), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5708), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5717), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5663), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5673), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5708), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5728), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5674), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5709), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5714), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5719), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5729), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5665), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5725), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 1, 7, 13, 39, 44, 869, DateTimeKind.Local).AddTicks(5730) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentServerId",
                table: "IpHistories");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "85f2b6a1-09e7-484f-a33f-aad130d05a30", new DateTime(2024, 1, 7, 12, 11, 58, 641, DateTimeKind.Local).AddTicks(359), new DateTime(2024, 1, 7, 12, 11, 58, 641, DateTimeKind.Local).AddTicks(377), new List<string>(), "AQAAAAIAAYagAAAAEIkOaLpF4tQKc3N9nqEfOEzlV65yxuqojdRkt8nOLQYLdAFcz2ofErU+6UUZ6CbdjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "26b99cbe-6678-49fc-b248-310b176ce6dd", new DateTime(2024, 1, 7, 12, 11, 58, 708, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 1, 7, 12, 11, 58, 708, DateTimeKind.Local).AddTicks(4520), new List<string>(), "AQAAAAIAAYagAAAAEMUt8D3RIpK5q3l80JHXsnkGi/4eIb1oHYV9LZeGahmFdKTNRGGZHQsbU/NcyNimig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b368917d-af9d-4f88-9e72-4d3c5aa9ac21", new DateTime(2024, 1, 7, 12, 11, 58, 573, DateTimeKind.Local).AddTicks(372), new DateTime(2024, 1, 7, 12, 11, 58, 573, DateTimeKind.Local).AddTicks(387), new List<string>(), "AQAAAAIAAYagAAAAED/KZYhDFBpXg2NTpyrr1GDZi7U3DyU92VdHV3QV/FTSHujA6k1E2Eb4tO81/FXveQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "51712f64-6a82-4f12-b947-4b639c33eace", new DateTime(2024, 1, 7, 12, 11, 58, 500, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 1, 7, 12, 11, 58, 500, DateTimeKind.Local).AddTicks(309), new List<string>(), "AQAAAAIAAYagAAAAEFRt2XknGhp2mqRElEpWBpyTAlpxg/BF0YB/v527l4ROuW9oPQL1DdxjAPLVOQu4Fw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8716), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8616), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8726), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8742), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8718), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8619), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8654), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8719), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8620), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8745), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8656), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8624), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8722), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8658), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8667), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8768), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8773), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8783), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8759), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8779), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8789), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8765), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8780), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8785), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8761), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8781), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8767), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8772), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8777), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8797), new DateTime(2024, 1, 7, 12, 11, 58, 497, DateTimeKind.Local).AddTicks(8797) });
        }
    }
}
