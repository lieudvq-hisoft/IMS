using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class unique_cccd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(348), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f01e6e64-6cad-4afa-914a-5faa2ff8e0f6", new DateTime(2024, 1, 4, 21, 23, 15, 352, DateTimeKind.Local).AddTicks(4818), new DateTime(2024, 1, 4, 21, 23, 15, 352, DateTimeKind.Local).AddTicks(4832), new List<string>(), "AQAAAAIAAYagAAAAEL2P1Z63/ougHJhJ3+MQ9KdaDnhF7kd2uW5v+Bn1V3q1DIjJ5TW37zV9k5qrPk6vvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c7bbc44b-55e6-474a-9780-c1793e4d6318", new DateTime(2024, 1, 4, 21, 23, 15, 630, DateTimeKind.Local).AddTicks(5597), new DateTime(2024, 1, 4, 21, 23, 15, 630, DateTimeKind.Local).AddTicks(5611), new List<string>(), "AQAAAAIAAYagAAAAEHkIqRk10Gc9sWemLYB9RIx7ZLC0jx3HtBbc3kNEW18WzBgA1ZqvAfb6+2ss/ldbhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "957509f7-9938-4498-920f-0918e9c37798", new DateTime(2024, 1, 4, 21, 23, 15, 245, DateTimeKind.Local).AddTicks(9394), new DateTime(2024, 1, 4, 21, 23, 15, 245, DateTimeKind.Local).AddTicks(9408), new List<string>(), "AQAAAAIAAYagAAAAEKF5EB4eNu5gnc1OcIi3hczSaqw/5+kJhYOZZszAVpIxjlyFz9Lle0H/qMKR8baJUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "2e23a4cb-332a-4bf7-ba3b-f51f2eb76dc6", new DateTime(2024, 1, 4, 21, 23, 15, 156, DateTimeKind.Local).AddTicks(8838), new DateTime(2024, 1, 4, 21, 23, 15, 156, DateTimeKind.Local).AddTicks(8859), new List<string>(), "AQAAAAIAAYagAAAAEJKU3Ky9tN//KtPTxF5TL9rPs7dPclKKUjaHPVlUXJ5clCrYb1m2u07WT/E8yhlSug==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(281), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(295), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(356), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(396), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(514), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(534), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(544), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(536), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(555), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(366), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(506), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(527), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(537), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(556), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(367), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(418), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(528), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(548), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(496), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(529), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(539), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(549), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(558), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(373), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(531), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(541), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(375), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(499), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(511), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(521), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(532), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(551), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(561), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(376), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(500), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(522), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(533), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(543), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(562), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(564), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(567), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(581), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(587), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(593), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(598), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(569), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(575), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(582), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(588), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(653), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(660), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(570), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(577), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(595), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(648), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(571), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(578), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(585), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(590), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(596), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(656), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 1, 4, 21, 23, 15, 152, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CCCD",
                table: "Contacts",
                column: "CCCD",
                unique: true,
                filter: "\"IsDeleted\" = false");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_CCCD",
                table: "Contacts");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3867), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3880), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3fcabf7b-9d9d-4f68-bbf3-568c0fe8b641", new DateTime(2024, 1, 2, 22, 30, 44, 953, DateTimeKind.Local).AddTicks(3437), new DateTime(2024, 1, 2, 22, 30, 44, 953, DateTimeKind.Local).AddTicks(3450), new List<string>(), "AQAAAAIAAYagAAAAEGcCc8BkFAeaCBJ7SDko1dC/DSpaUtT1U+hwRlCS4F7CBmfl90IppuxhWpb1Vhltag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "046ec74c-5284-49ff-bd12-7f41909dc9ee", new DateTime(2024, 1, 2, 22, 30, 45, 22, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 1, 2, 22, 30, 45, 22, DateTimeKind.Local).AddTicks(7926), new List<string>(), "AQAAAAIAAYagAAAAEF4Q7Q+0EFP4XRPRDGh7gJqoMQJDWxFILOiM3obSBjU8gnw6NCNinwUR/LHhRVmWSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b0c9566f-ee8d-4d1b-9357-13aed6453dba", new DateTime(2024, 1, 2, 22, 30, 44, 881, DateTimeKind.Local).AddTicks(7738), new DateTime(2024, 1, 2, 22, 30, 44, 881, DateTimeKind.Local).AddTicks(7750), new List<string>(), "AQAAAAIAAYagAAAAEBDLZqSevTAJ7iP3ZMY4GdN8WDAG/fSwKlUxfHvWw+5BvoRWdb5bzKRdmV6FJqQ9Yg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "743bba43-b62c-4e2b-a3eb-685e58d6c4b1", new DateTime(2024, 1, 2, 22, 30, 44, 814, DateTimeKind.Local).AddTicks(3865), new DateTime(2024, 1, 2, 22, 30, 44, 814, DateTimeKind.Local).AddTicks(3869), new List<string>(), "AQAAAAIAAYagAAAAEDwJTAIr5iVKR9xDryL1L/UaV1m7YHgVuqsFr1IFdcJ+1vV9F+j2lbcyPinvqck4fQ==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3847), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3904), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3929), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3989), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4004), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3891), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3906), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3939), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4013), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3991), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4006), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4014), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3924), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3992), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4015), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4001), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3896), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3935), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3942), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3994), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4002), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4009), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3898), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3995), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4002), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4010), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4017), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3928), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3944), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3996), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4003), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4018), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4020), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4036), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4022), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4046), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4051), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4029), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4034), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4043), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4053), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4025), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4030), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4044), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4054), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 1, 2, 22, 30, 44, 810, DateTimeKind.Local).AddTicks(4059) });
        }
    }
}
