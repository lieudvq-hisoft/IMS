using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class removal_request_document : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RemovalRequestDocument",
                table: "RequestHosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RemovalRequestDocument",
                table: "RequestExpands",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1188), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1201), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "8e027145-4c84-46e6-8565-bc7de9b92189", new DateTime(2024, 1, 12, 21, 50, 55, 813, DateTimeKind.Local).AddTicks(2944), new DateTime(2024, 1, 12, 21, 50, 55, 813, DateTimeKind.Local).AddTicks(2956), new List<string>(), "AQAAAAIAAYagAAAAEH4fLqhjed1+YaK6dg97EU2rLMUWbaOeOP6b6ApfRW1Ga3npgpSHxjGfADGqyC3Fcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "22a2512c-ced4-44e6-8aa9-b36d81c5d734", new DateTime(2024, 1, 12, 21, 50, 55, 884, DateTimeKind.Local).AddTicks(3046), new DateTime(2024, 1, 12, 21, 50, 55, 884, DateTimeKind.Local).AddTicks(3063), new List<string>(), "AQAAAAIAAYagAAAAEDwhN1B4bxjHJ58hUJt7uMPxy1EPc4ejH2CxKjx8gq7KIrz1q8t5++BY5umWc1M/nA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "7c94a3fa-e297-4377-ac4e-3e74ce27acc3", new DateTime(2024, 1, 12, 21, 50, 55, 741, DateTimeKind.Local).AddTicks(5426), new DateTime(2024, 1, 12, 21, 50, 55, 741, DateTimeKind.Local).AddTicks(5440), new List<string>(), "AQAAAAIAAYagAAAAEDkI+Bbo0i/O+HyFDPzSIIBhXwMKm1lBU4cFfxLXdx0E6et84DTgmAiwDuxW84MOsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "b6e27b65-2404-4ac3-b11c-f1808da7db21", new DateTime(2024, 1, 12, 21, 50, 55, 662, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 1, 12, 21, 50, 55, 662, DateTimeKind.Local).AddTicks(2819), new List<string>(), "AQAAAAIAAYagAAAAEAiE4cXFpT+KHENzB0qGfUjhY16BbPax+P8c0fUd8dF+Qxu1b0qsqoaxyQZNotHhyg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1044), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1367), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1375), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1265), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1361), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1368), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1376), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1384), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1392), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1280), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1362), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1378), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1386), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1283), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1363), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1379), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1387), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1394), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1283), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1364), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1388), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1403), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1381), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1389), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1382), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1390), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1397), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1405), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1432), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1509), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1413), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1433), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1505), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1414), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1424), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1434), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1506), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1511), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1415), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1425), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1430), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1411), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1426), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1436), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1508), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1513), new DateTime(2024, 1, 12, 21, 50, 55, 656, DateTimeKind.Local).AddTicks(1513) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemovalRequestDocument",
                table: "RequestHosts");

            migrationBuilder.DropColumn(
                name: "RemovalRequestDocument",
                table: "RequestExpands");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6828), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6845), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "079cad21-a4ee-4af6-ab14-2c8ef39a02fe", new DateTime(2024, 1, 11, 21, 19, 12, 416, DateTimeKind.Local).AddTicks(6893), new DateTime(2024, 1, 11, 21, 19, 12, 416, DateTimeKind.Local).AddTicks(6905), new List<string>(), "AQAAAAIAAYagAAAAEGFPa8FjU9grDzb2Eh/QrYV/vB1W1GL8PLvz77ZCbDNcxiYaH2+60hVpbqqxkmmRlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "a6a9d68f-b95b-4421-9bae-34d9aadf50ad", new DateTime(2024, 1, 11, 21, 19, 12, 499, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 1, 11, 21, 19, 12, 499, DateTimeKind.Local).AddTicks(7745), new List<string>(), "AQAAAAIAAYagAAAAEGclwXimZN1rNk6tqtbBYmC4DYC9CocYmbYEaTuXTQx5YTBR1ecZu8H4mZtm2jpSAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "bda5aeb9-f398-4602-9ab3-af7687ff673f", new DateTime(2024, 1, 11, 21, 19, 12, 346, DateTimeKind.Local).AddTicks(725), new DateTime(2024, 1, 11, 21, 19, 12, 346, DateTimeKind.Local).AddTicks(740), new List<string>(), "AQAAAAIAAYagAAAAEOysyAIOKhiETHeZ7WtAZdNLa2llKR5C2+x85MJXWsZZJK9VXwpw4vkWbhPEriZm/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f3528c63-9d29-4a59-8afd-2c5132ce86e0", new DateTime(2024, 1, 11, 21, 19, 12, 276, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 1, 11, 21, 19, 12, 276, DateTimeKind.Local).AddTicks(4310), new List<string>(), "AQAAAAIAAYagAAAAEIX/lHvL6rKNXxqg6HpyVtUcCmPAuKJ+z3CyFgb2sj3RuT7LMEHKxZKYT1E8bFM5rg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6693), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6852), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6879), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6905), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6913), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6881), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6914), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6969), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6907), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6915), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6971), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6986), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6900), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6916), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6901), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6917), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6973), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6863), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6974), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6989), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6997), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6919), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6982), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6878), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6912), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7006), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7026), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7007), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7012), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7022), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7003), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7013), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7033), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7004), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7014), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7038), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7010), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7025), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7035), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 1, 11, 21, 19, 12, 271, DateTimeKind.Local).AddTicks(7040) });
        }
    }
}
