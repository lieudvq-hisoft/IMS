using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class remove_doc_confirm_Server_allocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentConfirm",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DocumentConfirm",
                table: "ServerAllocations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8698), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8716), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "f865150f-189b-4d38-9fb3-5b4914fc6999", new DateTime(2023, 12, 9, 16, 28, 44, 418, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 12, 9, 16, 28, 44, 419, DateTimeKind.Local).AddTicks(10), "AQAAAAIAAYagAAAAEAi0gVr6C/Ggj6/eQKktnbvBDuvTnT5nhz2rwfyxYjzkO/cOmjSXa7+d+r45YFbkQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "1a094106-f932-4308-8bae-ffc0ad824ce4", new DateTime(2023, 12, 9, 16, 28, 44, 539, DateTimeKind.Local).AddTicks(9747), new DateTime(2023, 12, 9, 16, 28, 44, 539, DateTimeKind.Local).AddTicks(9763), "AQAAAAIAAYagAAAAECBV5KDnWJQ1POiVhVfln551+4BeeVls1kdHnulTJIWv+nBKeM9NC7cA6K8sdiVNqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "2cca3852-2051-40bf-9d53-4262512d6993", new DateTime(2023, 12, 9, 16, 28, 44, 321, DateTimeKind.Local).AddTicks(1919), new DateTime(2023, 12, 9, 16, 28, 44, 321, DateTimeKind.Local).AddTicks(1932), "AQAAAAIAAYagAAAAEG/eLgm98Kqcybr64tKhz96MOWOf5V7EdLFvWIlFNFJ1W6lsL039UBad1h4Kda+Tow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "ee7de20f-1cf8-463d-b334-4446ca0e9b56", new DateTime(2023, 12, 9, 16, 28, 44, 250, DateTimeKind.Local).AddTicks(2104), new DateTime(2023, 12, 9, 16, 28, 44, 250, DateTimeKind.Local).AddTicks(2114), "AQAAAAIAAYagAAAAECA+/5mnKkLWCgspTLk00JVKr45BlKmRc5Ffhmy0IZLbbmO7bsh5Qg1oLL9ALyZ5tA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8630), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8655), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8667), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8780), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8788), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8797), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8843), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8851), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8773), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8790), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8852), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8727), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8774), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8782), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8845), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8853), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8766), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8775), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8783), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8792), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8846), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8784), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8793), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8801), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8855), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8731), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8777), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8785), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8848), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8856), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8739), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8769), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8778), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8803), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8857), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8740), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8770), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8779), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8787), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8796), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8841), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8859), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8866), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8872), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8877), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8882), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8893), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8898), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8862), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8867), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8873), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8883), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8863), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8868), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8874), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8879), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8884), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8889), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8895), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8870), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8875), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8880), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8885), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8890), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8896), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8901), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8865), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8871), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8876), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8881), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8886), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8891), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8897), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8902), new DateTime(2023, 12, 9, 16, 28, 44, 244, DateTimeKind.Local).AddTicks(8902) });
        }
    }
}
