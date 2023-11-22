using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class fourth_octet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FourthOctet",
                table: "IpSubnets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1476), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "77e25688-5af2-44d8-b884-4d212aff8e84", new DateTime(2023, 11, 21, 20, 53, 17, 594, DateTimeKind.Local).AddTicks(3902), new DateTime(2023, 11, 21, 20, 53, 17, 594, DateTimeKind.Local).AddTicks(3921), "AQAAAAIAAYagAAAAEOJ2g5qwXCouIctf8SlrHKZmgyUa4wKZPJCf17dfNgRSDSmgtgFO0Vi3c89rVkuGqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "3a2908ca-54d8-4e05-b6a2-3abf31c1761b", new DateTime(2023, 11, 21, 20, 53, 17, 316, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 11, 21, 20, 53, 17, 316, DateTimeKind.Local).AddTicks(224), "AQAAAAIAAYagAAAAEBK4Wu12dxl/DjKHbJcaTQCT0JJypwLELMJA+FLoewy3EIOLa2mOg3kA+U81aG9bew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1738ea2e-6ea6-4e0f-869f-92a2aad6dc47", new DateTime(2023, 11, 21, 20, 53, 17, 387, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 11, 21, 20, 53, 17, 387, DateTimeKind.Local).AddTicks(8042), "AQAAAAIAAYagAAAAEJXCEuvwVly58bE52mELrNxEheewOUuFTBTko/fkw3f2mF6wvcoPGiuGEwYciDqrOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "18899372-41ec-43fe-afce-32fc565ea91f", new DateTime(2023, 11, 21, 20, 53, 17, 241, DateTimeKind.Local).AddTicks(784), new DateTime(2023, 11, 21, 20, 53, 17, 241, DateTimeKind.Local).AddTicks(796), "AQAAAAIAAYagAAAAEIivG/LzPlpIwsnE5OKG0l9iuvfS40jAiZbCu3ZSm4ZNM3yisn0QEpPB/CmWEzuNDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ed1d7b48-40b4-462a-b676-dd876eeb711c", new DateTime(2023, 11, 21, 20, 53, 17, 169, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 11, 21, 20, 53, 17, 169, DateTimeKind.Local).AddTicks(9405), "AQAAAAIAAYagAAAAEP4b0fgK1QZmoU29f7GN8p8MegCyoMxo6ar5bGaXN4GgmngiuLpmIG8+YwtmoZtJww==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1282), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1353), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1362), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1399), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1409), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1417), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1423), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1519), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1547), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1579), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1511), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1557), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1573), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1530), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1549), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1558), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1574), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1581), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1513), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1523), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1550), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1559), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1567), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1514), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1532), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1551), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1516), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1525), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1533), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1552), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1576), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1562), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1570), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1518), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1578), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1586), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1588), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1595), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1610), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1615), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1619), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1624), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1625), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1592), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1597), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1607), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1621), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1622), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1627), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1594), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1609), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1618), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1623), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 11, 21, 20, 53, 17, 167, DateTimeKind.Local).AddTicks(1628) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FourthOctet",
                table: "IpSubnets");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6171), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6183), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a53d014f-6dbd-41ec-833d-4085a24190a7", new DateTime(2023, 11, 21, 20, 46, 19, 893, DateTimeKind.Local).AddTicks(7827), new DateTime(2023, 11, 21, 20, 46, 19, 893, DateTimeKind.Local).AddTicks(7840), "AQAAAAIAAYagAAAAEGbH1wtySJBF28VoTC0Zl096ecJ/OGJGDYZ1BAHh8nFVHnEBGlD4/9IWGHSD42xlxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "a90c7060-78d3-43f3-87b7-8e82f6cdde5c", new DateTime(2023, 11, 21, 20, 46, 19, 735, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 11, 21, 20, 46, 19, 735, DateTimeKind.Local).AddTicks(2509), "AQAAAAIAAYagAAAAEGYzSc3ZkD5PcgSOHObL7dB1g05lDoBZpgBjChvMIr30bxYywDSl5o/Y2PuTfR2Ydw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "5c95140f-090b-4f0f-923b-ce91355bfc65", new DateTime(2023, 11, 21, 20, 46, 19, 808, DateTimeKind.Local).AddTicks(4742), new DateTime(2023, 11, 21, 20, 46, 19, 808, DateTimeKind.Local).AddTicks(4757), "AQAAAAIAAYagAAAAEKIXIzs8fLShoDTEUk5ttI7jVUL4aaWG6tvErlCm/aM8js7OiEXj5OdNahIgXs89tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "fde01a94-b490-4916-a122-6da898bfced0", new DateTime(2023, 11, 21, 20, 46, 19, 649, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 11, 21, 20, 46, 19, 649, DateTimeKind.Local).AddTicks(227), "AQAAAAIAAYagAAAAELuStNSApWkoA3Xs/mjJBywQ4O4J3reB94S5BPWjq/z31EYRDINme9pbHAfmspbi3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "59b120e6-ff9f-4d0d-947f-2de7891ac5bc", new DateTime(2023, 11, 21, 20, 46, 19, 570, DateTimeKind.Local).AddTicks(5574), new DateTime(2023, 11, 21, 20, 46, 19, 570, DateTimeKind.Local).AddTicks(5583), "AQAAAAIAAYagAAAAEEfC9g7DBvzgOGnVKNrfioiz1Fqe9EJlypnlbCNvpMQL0fRoLbNID9d70osSga3w1w==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(5942), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6020), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6053), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6111), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6119), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6142), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6127), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6201), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6234), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6251), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6268), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6206), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6217), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6227), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6244), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6252), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6269), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6218), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6236), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6245), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6253), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6261), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6305), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6208), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6219), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6229), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6246), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6254), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6262), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6307), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6230), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6255), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6263), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6308), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6221), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6231), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6239), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6248), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6256), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6264), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6309), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6213), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6222), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6232), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6240), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6249), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6265), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6310), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6214), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6233), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6241), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6250), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6266), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6311), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6313), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6321), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6326), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6332), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6316), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6322), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6333), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6338), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6354), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6318), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6323), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6328), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6344), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6319), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6324), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6329), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6335), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6340), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6350), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6320), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6325), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6330), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 11, 21, 20, 46, 19, 567, DateTimeKind.Local).AddTicks(6357) });
        }
    }
}
