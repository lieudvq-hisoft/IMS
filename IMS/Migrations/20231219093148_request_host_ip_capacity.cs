using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class request_host_ip_capacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpgradeCapacity",
                table: "RequestHosts");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "RequestHostIps",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1186), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1200), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "4f9287f9-90c8-417c-b4cb-7e6ba58b780b", new DateTime(2023, 12, 19, 16, 31, 47, 82, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 12, 19, 16, 31, 47, 82, DateTimeKind.Local).AddTicks(2868), new List<string>(), "AQAAAAIAAYagAAAAEGrL4zvCIh+ooIXYwU7JkcTT0u+n/A9GwfK/wKJ2fokS0avtKh7k/9omn5xfO1I4Ig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "39c89ac0-7888-4c98-8dda-f719deb18920", new DateTime(2023, 12, 19, 16, 31, 47, 150, DateTimeKind.Local).AddTicks(4122), new DateTime(2023, 12, 19, 16, 31, 47, 150, DateTimeKind.Local).AddTicks(4135), new List<string>(), "AQAAAAIAAYagAAAAEJPu+xhWUH4JrpqBk6Imevo/uKltCGkqac9risutE0rHRTarkzmK6ApzjaeM1PTxfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "51f7872f-eab7-425b-bace-14fa78b4e0ea", new DateTime(2023, 12, 19, 16, 31, 47, 13, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 12, 19, 16, 31, 47, 13, DateTimeKind.Local).AddTicks(6043), new List<string>(), "AQAAAAIAAYagAAAAEE+uvhITVs/m0KQxkhZWRcySa/ywwTGzeDKKQxnpEBKlkfB9cAkSMKuSXFo3NlHnqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "c90e4fd3-f4bf-4906-8c0d-aec515f50f45", new DateTime(2023, 12, 19, 16, 31, 46, 943, DateTimeKind.Local).AddTicks(3934), new DateTime(2023, 12, 19, 16, 31, 46, 943, DateTimeKind.Local).AddTicks(3949), new List<string>(), "AQAAAAIAAYagAAAAEKd36a0nvYia5nYYbujAUyllhaxzoV3e7oAekAnaHdf2eoc/KVQiAvAZiw7w27i0kw==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1022), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1205), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1220), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1236), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1244), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1252), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1307), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1211), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1230), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1237), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1300), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1307), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1238), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1246), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1308), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1213), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1223), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1232), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1239), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1294), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1302), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1309), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1214), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1224), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1240), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1248), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1303), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1310), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1216), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1225), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1233), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1241), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1249), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1296), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1217), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1226), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1234), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1242), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1250), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1297), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1305), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1312), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1218), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1235), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1251), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1298), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1306), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1317), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1324), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1329), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1338), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1343), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1347), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1352), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1325), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1334), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1339), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1343), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1348), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1353), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1321), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1326), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1331), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1335), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1340), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1344), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1349), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1354), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1322), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1327), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1336), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1341), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1345), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1350), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1355), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1328), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1332), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1337), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1342), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1346), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1351), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1356), new DateTime(2023, 12, 19, 16, 31, 46, 939, DateTimeKind.Local).AddTicks(1356) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "RequestHostIps");

            migrationBuilder.AddColumn<int>(
                name: "UpgradeCapacity",
                table: "RequestHosts",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9531), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9549), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3529f71f-f148-4d92-a1e5-22dc32dcd7d2", new DateTime(2023, 12, 19, 14, 48, 27, 786, DateTimeKind.Local).AddTicks(9726), new DateTime(2023, 12, 19, 14, 48, 27, 786, DateTimeKind.Local).AddTicks(9740), new List<string>(), "AQAAAAIAAYagAAAAEMBPoVldmBLmqpqGDOmzIP604u4xA3ncSFR7SOt1xcO1E9U5zSFiA3hqkjdLC5y1dw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "817e3a70-ae98-4f23-a623-96146fd053ea", new DateTime(2023, 12, 19, 14, 48, 27, 862, DateTimeKind.Local).AddTicks(8598), new DateTime(2023, 12, 19, 14, 48, 27, 862, DateTimeKind.Local).AddTicks(8608), new List<string>(), "AQAAAAIAAYagAAAAEJTC/wyrDSELLY9WhQ+wW6ECYo2dEnrwfu8VMA5oeAIX0s0eunARkIu5fFU9jiw2Mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "19aa8d28-8e2e-46a9-98a1-3e85b5ba3c28", new DateTime(2023, 12, 19, 14, 48, 27, 709, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 12, 19, 14, 48, 27, 709, DateTimeKind.Local).AddTicks(3596), new List<string>(), "AQAAAAIAAYagAAAAEE2LspvCXnU/4fkp4B55kMFSnKkbA5bIGsT3WdmduWqwlnsUfA4nCzlDoP5DN+ouOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "9d476daa-0cf5-479a-b05b-0ecd6ab27c30", new DateTime(2023, 12, 19, 14, 48, 27, 641, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 12, 19, 14, 48, 27, 641, DateTimeKind.Local).AddTicks(9768), new List<string>(), "AQAAAAIAAYagAAAAELLonY1NMhf3VblqbQ5qxtktTxm7XmVfC0yI76JWY8AuLTSnxvzeh8BzdHgQnIOyBg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9302), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9466), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9481), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9494), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9506), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9640), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9649), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9667), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9561), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9642), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9651), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9669), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9677), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9562), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9643), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9653), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9661), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9687), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9610), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9654), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9662), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9696), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9612), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9645), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9655), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9680), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9689), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9697), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9614), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9646), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9664), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9690), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9698), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9623), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9647), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9657), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9665), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9674), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9683), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9699), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9624), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9658), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9666), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9709), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9715), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9754), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9759), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9769), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9705), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9716), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9760), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9770), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9706), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9712), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9717), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9756), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9761), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9777), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9707), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9718), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9757), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9762), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9714), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9719), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9758), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9763), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9774), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 12, 19, 14, 48, 27, 636, DateTimeKind.Local).AddTicks(9779) });
        }
    }
}
