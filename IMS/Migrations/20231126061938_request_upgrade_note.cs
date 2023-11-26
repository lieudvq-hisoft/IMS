using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_upgrade_note : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "RequestUpgrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaleNote",
                table: "RequestUpgrades",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechNote",
                table: "RequestUpgrades",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1452), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("01fc684c-d9d0-4fcc-b0a7-56fea6945928"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "33077cf5-cdcb-41fa-a8f7-4089b2f3179d", new DateTime(2023, 11, 26, 13, 19, 37, 19, DateTimeKind.Local).AddTicks(3533), new DateTime(2023, 11, 26, 13, 19, 37, 19, DateTimeKind.Local).AddTicks(3572), "AQAAAAIAAYagAAAAEHnsonxNsImSVw09LCVzMCBQ/cyF1R6kNhTeRal5KLyea0h0CTJ5ouFZMY51JGdotA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "341e2f62-7c66-45aa-8306-14e26af9a073", new DateTime(2023, 11, 26, 13, 19, 36, 821, DateTimeKind.Local).AddTicks(6457), new DateTime(2023, 11, 26, 13, 19, 36, 821, DateTimeKind.Local).AddTicks(6472), "AQAAAAIAAYagAAAAEDOHbtfEtsk/wjMD5aOa9R3eQpws+AaLGGZPfKyc/W/JBSAkIKic7Z7WAp4qvZgiHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "617d4822-436b-461c-a313-170a2a873400", new DateTime(2023, 11, 26, 13, 19, 36, 920, DateTimeKind.Local).AddTicks(5796), new DateTime(2023, 11, 26, 13, 19, 36, 920, DateTimeKind.Local).AddTicks(5811), "AQAAAAIAAYagAAAAEG8IrTislH4o1hLDxw8ukN6yqILhFNn1WqVJMzAtIPVOfp25DM11DZRalj19lmMOwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "aa218638-5d7b-40d4-bb4e-b38031482caa", new DateTime(2023, 11, 26, 13, 19, 36, 741, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 11, 26, 13, 19, 36, 741, DateTimeKind.Local).AddTicks(8895), "AQAAAAIAAYagAAAAEMj9TmDsVS4fdh+hxbnBZ4bo95Glrllexo2ojnZuiItoSP4YSPG2klwdIrrotL/9zA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash" },
                values: new object[] { "04ec62a0-f6ed-4c3d-8f53-124b4a6509e8", new DateTime(2023, 11, 26, 13, 19, 36, 652, DateTimeKind.Local).AddTicks(6616), new DateTime(2023, 11, 26, 13, 19, 36, 652, DateTimeKind.Local).AddTicks(6633), "AQAAAAIAAYagAAAAEEPT11OJlx7YHlEukwAXtC94afiH0ScuMtWozZumqtWyvcdU5OKCkaGAhdJtMAgjDA==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1087), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1246), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1259), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1314), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1346), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1367), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1378), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1357), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1528), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1540), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1580), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1502), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1515), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1543), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1595), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1503), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1545), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1571), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1583), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1489), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1505), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1520), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1532), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1585), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1506), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1522), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1534), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1574), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1586), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1508), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1523), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1535), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1588), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1509), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1537), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1603), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1498), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1510), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1566), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1578), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1618), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1626), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1635), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1658), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1666), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1620), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1644), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1651), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1667), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1621), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1630), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1638), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1645), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1669), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1614), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1622), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1632), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1662), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1670), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1624), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1634), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1641), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1656), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1672), new DateTime(2023, 11, 26, 13, 19, 36, 648, DateTimeKind.Local).AddTicks(1672) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "SaleNote",
                table: "RequestUpgrades");

            migrationBuilder.DropColumn(
                name: "TechNote",
                table: "RequestUpgrades");

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
    }
}
