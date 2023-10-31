using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class minor_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "IpAssignments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2860), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2eb445ca-cb3a-4ab7-b02c-b9a1809c909a", "AQAAAAIAAYagAAAAEPU1aEjvwkdFJBUVYwFdlxi1E72t6EnUiBBzis6PQKbio0GGIu8aQMwsj4aW22dDgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c603f5c5-5302-47ad-b08b-16866aa9bae4", "AQAAAAIAAYagAAAAEP/lDssnACWaLJhg1y11vz+fBgAEA+0UGDxpa74ncQR+yYa5WHI4vMBMZbqbVz/5QA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae39c346-d9e0-4ad6-890a-f4a6b3d5ee73", "AQAAAAIAAYagAAAAEMj7c+d9XGqCBkwQBGwZ0AdXr/8FvDpywxb5QtYyS9DrE9+oW0JSUS3RwKoMPUtI3A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "43b2e460-aa40-410d-a19e-1d1c5e76cdb9", "AQAAAAIAAYagAAAAEKtmBoqyZU2pRBf7PF3lIbZBjkdcaS8Xw3KyIWE1zruVyzu42NgNU0pkBl6usaCy8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9475cbca-cdde-46d4-9e23-a4429c0f8af1", "AQAAAAIAAYagAAAAEA7tiwWL50rMPlNh/5AzjNDmVtxKuxT+QnJLvS9PlNRSsxnUd1a12EwZmy6OGyMZFQ==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8005), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8107), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1082), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1093), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1252), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1259), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1265), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1272), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1279), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1286), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1292), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1307), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1348), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1354), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1361), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1375), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1395), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1402), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1464), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1472), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1479), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1486), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1493), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1500), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1739), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1775), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1783), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1790), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1795), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1799), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1816), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1820), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1825), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1828), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1833), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1853), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1903), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1907), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1911), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1915), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1919), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1923), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1931), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1935), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1939), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1942), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1946), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2054), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2058), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2069), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2077), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2081), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2088), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2092), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2100), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2115), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2126), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2134), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2145), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2153), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2168), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2187), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2220), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2227), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2257), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2272), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2288), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2296), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2314), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2330), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2338), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2364), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2372), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2380), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2387), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2391), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2398), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2402), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2409), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2418), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2422), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2427), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2432), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2438), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2443), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2454), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2460), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2465), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2482), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2487), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2493), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2503), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2780), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2822), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2841), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2887), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2909), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2916), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2930), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2943), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2955), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2968), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(723), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(783), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(809), new DateTime(2023, 10, 30, 20, 12, 19, 386, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2981), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3011), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3019), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3172), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3179), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3191), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3198), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3206), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2998), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3021), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3173), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3192), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3199), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3207), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3000), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3174), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3185), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3200), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3208), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3001), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3014), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3023), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3175), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3193), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3015), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3176), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3202), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3209), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3025), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3195), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3026), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3196), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3204), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3211), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3018), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3170), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3178), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3189), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3205), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3212), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3214), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3225), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3235), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3239), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3244), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3288), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3216), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3221), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3226), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3231), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3236), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3245), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3217), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3222), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3227), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3241), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3246), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3290), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3218), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3223), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3228), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3242), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3285), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3291), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3219), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3224), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3229), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3234), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3243), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3287), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3292), new DateTime(2023, 10, 30, 20, 12, 19, 385, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8144), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8171), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8184), new DateTime(2023, 10, 30, 20, 12, 18, 636, DateTimeKind.Local).AddTicks(8185) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "IpAssignments");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8197), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8205), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80ef2914-3bdb-4d62-8110-5d95e089ac62", "AQAAAAIAAYagAAAAECZs0ZHd460idxU/xMQ4TRKcHUgPFuKN8/MRjCedTtkF5o5HlMjo145BKfA/pWF7EQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("285135ab-c67d-4285-b689-7e88e7f610f9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd0e687f-4276-42a0-a2d4-5e4b22d99126", "AQAAAAIAAYagAAAAEJ0ZjEcGxHuKZdXT0AOlKHt2JiuYSdNRBO5TvzD+g/TlHnZyj8UUQrIrMLPNC5GwKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a39e1d4-0f52-4e76-a817-03652adf2a54", "AQAAAAIAAYagAAAAEMcf06U1WFDCj0IbWk6LgNFx6wEGTrCbCp9ZpIWt+lBlo1h0CJggcKfMIRxvc4tPHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7b6db85-c667-482c-9e1d-41a008a0c4cc", "AQAAAAIAAYagAAAAECPSjB/c7zZEMfFSeMYbiDz5WYGFRQDqNkjMIOrTEy0xt+JNoqJLMvJmHvlFCAYMyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "556b32e5-ae29-4463-9f71-91660d00e6b4", "AQAAAAIAAYagAAAAEDuIe3LsL67MT4i21SAHU8kdOhOfJuHrae0Je0skR+a2gOvVFEP8l+bZ2DrUi3FYtg==" });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5102), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9542), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9550), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9559), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9567), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9571), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9575), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9579), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9583), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9587), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9591), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9595), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9599), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9603), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9606), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9626), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9629), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9633), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9641), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9653), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9703), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9710), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9714), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9722), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9731), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9735), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9743), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9750), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9769), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9784), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9787), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9791), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9798), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9806), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9813), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9817), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9836), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9839), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9843), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9847), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9851), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9854), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9858), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9862), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9865), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9869), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9873), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9876), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9880), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9884), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9888), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9891), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9895), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9899), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9902), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9906), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9910), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9953), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9971), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9975), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9979), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9983), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9987), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9991), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9995), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9998), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(2), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(6), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(10), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(17), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(21), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(25), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(29), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(37), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(40), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(44), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(48), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(63), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(67), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(70), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(94), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(98), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(101), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(105), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(113), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(117), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(121), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(125), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(129), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(132), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(136), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(140), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(144), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(147), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(151), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(169), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(180), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(184), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(196), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(200), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(203), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(207), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(211), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(219), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(222), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(245), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(249), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(253), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(278), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(282), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(286), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(290), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(293), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(336), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(358), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(369), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(373), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(373) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(378), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(383), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(399), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Ips",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 10, 30, 14, 31, 40, 475, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9483), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9513), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Networks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9522), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8213), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8310), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8318), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8325), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8333), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8341), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8220), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8231), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8311), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8334), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8222), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8312), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8320), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8328), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8335), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8233), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8321), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8344), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8362), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8224), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8234), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8314), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8329), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8226), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8236), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8315), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8322), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8330), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8338), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8227), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8307), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8316), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8331), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8339), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8228), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8308), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8324), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8332), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8378), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8392), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8396), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8401), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8397), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8402), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8398), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8376), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8381), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8399), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8403), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8391), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8400), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8404), new DateTime(2023, 10, 30, 14, 31, 40, 474, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5134), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5158), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 10, 30, 14, 31, 40, 47, DateTimeKind.Local).AddTicks(5176) });
        }
    }
}
