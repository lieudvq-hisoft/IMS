using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class capacity_int_to_double : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<List<double>>(
                name: "Capacities",
                table: "RequestHosts",
                type: "double precision[]",
                nullable: true,
                oldClrType: typeof(List<int>),
                oldType: "integer[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Capacity",
                table: "RequestHostIps",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Capacity",
                table: "IpAssignments",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8271), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8287), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "3911d798-38a8-4224-be7f-65940bc8a4d4", new DateTime(2023, 12, 23, 11, 52, 16, 692, DateTimeKind.Local).AddTicks(5985), new DateTime(2023, 12, 23, 11, 52, 16, 692, DateTimeKind.Local).AddTicks(6033), new List<string>(), "AQAAAAIAAYagAAAAEMRjkAUZGZR5fDyXq95m8IJwXV6F2djlQIfnXhXx6Jtz/DWRGI+dNDoX17SVfoVffQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "f42e610f-a4ad-47a9-8e5f-1794f911a6d3", new DateTime(2023, 12, 23, 11, 52, 16, 776, DateTimeKind.Local).AddTicks(3469), new DateTime(2023, 12, 23, 11, 52, 16, 776, DateTimeKind.Local).AddTicks(3489), new List<string>(), "AQAAAAIAAYagAAAAEAtGkW9V2JYmNWcdRlaBbTH7apntAnq7XKR6H82au4Bo7gMdBz02A1US62ZZ/TnPlQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "46b37898-022c-4d75-b9b9-7f7c3fbabdaf", new DateTime(2023, 12, 23, 11, 52, 16, 610, DateTimeKind.Local).AddTicks(6039), new DateTime(2023, 12, 23, 11, 52, 16, 610, DateTimeKind.Local).AddTicks(6052), new List<string>(), "AQAAAAIAAYagAAAAEGTwpGbBPJtn73EiBNJBBt3UKv98Df0kFp1hwJGPrjlnJAyyk0GUouOmtHC6ZxDH5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "6dbd7864-d36b-4439-b0b7-8339ad677db0", new DateTime(2023, 12, 23, 11, 52, 16, 522, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 12, 23, 11, 52, 16, 522, DateTimeKind.Local).AddTicks(3997), new List<string>(), "AQAAAAIAAYagAAAAEBojjxbmmr0lbHJ/gD/h8q6vAIsfkGuD6RPa+qXtwvr8/MKDlp09K2kyCHQmipo6Qg==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8177), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8230), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8247), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8292), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8333), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8342), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8350), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8358), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8366), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8381), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8297), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8334), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8343), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8351), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8367), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8374), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8382), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8298), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8336), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8344), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8352), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8360), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8368), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8375), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8383), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8299), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8345), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8353), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8361), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8369), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8376), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8384), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8300), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8337), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8346), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8354), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8362), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8377), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8303), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8338), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8347), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8363), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8370), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8378), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8312), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8339), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8364), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8371), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8379), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8387), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8313), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8340), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8349), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8365), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8372), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8380), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8389), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8429), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8439), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8444), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8449), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8454), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8458), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8424), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8430), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8435), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8445), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8454), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8459), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8426), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8431), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8436), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8446), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8455), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8427), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8432), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8437), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8441), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8447), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8456), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8428), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8433), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8438), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8448), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8453), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8457), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8462), new DateTime(2023, 12, 23, 11, 52, 16, 518, DateTimeKind.Local).AddTicks(8462) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<List<int>>(
                name: "Capacities",
                table: "RequestHosts",
                type: "integer[]",
                nullable: true,
                oldClrType: typeof(List<double>),
                oldType: "double precision[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "RequestHostIps",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "IpAssignments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(960), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(974), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1abb6e28-793d-460f-8a24-745998356da8"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "31ed333b-5922-437f-85f1-f0926614869e", new DateTime(2023, 12, 20, 13, 50, 11, 266, DateTimeKind.Local).AddTicks(692), new DateTime(2023, 12, 20, 13, 50, 11, 266, DateTimeKind.Local).AddTicks(704), new List<string>(), "AQAAAAIAAYagAAAAEKN1t8eexSH/WCKGWKWU5jFlRMreLo9cD6NoY8s3kRVe1R7+QqZkKKxKHGlamfaBFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e3566a9-02b1-4ec4-a2d4-b3bb3c4f2b45"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "e93ebf50-a41c-4386-b79a-39ceb3865468", new DateTime(2023, 12, 20, 13, 50, 11, 339, DateTimeKind.Local).AddTicks(6909), new DateTime(2023, 12, 20, 13, 50, 11, 339, DateTimeKind.Local).AddTicks(6922), new List<string>(), "AQAAAAIAAYagAAAAENpyw7gfCMRHBTv7hwL0gehF8XHOhWYwpr7X8rnTpAoQS18dM6eMNlKpYSqlmO02kw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4716f673-cef5-4edd-b67d-9c71599b9fab"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "0a3a6ca8-0652-4289-9b5f-dce128543ffe", new DateTime(2023, 12, 20, 13, 50, 11, 167, DateTimeKind.Local).AddTicks(6952), new DateTime(2023, 12, 20, 13, 50, 11, 167, DateTimeKind.Local).AddTicks(6965), new List<string>(), "AQAAAAIAAYagAAAAEJKgi3JnGXxtdBhKjkKd3vUcNYOGpm9Q9r8DzXG7bA/Wa1iMV+E/JS3riTqRmzqHNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("57ffb575-7c79-4133-8433-aebbcd71f824"),
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "FcmTokens", "PasswordHash" },
                values: new object[] { "757f3b7a-29d9-4534-8993-e8fed11b8d12", new DateTime(2023, 12, 20, 13, 50, 11, 99, DateTimeKind.Local).AddTicks(1653), new DateTime(2023, 12, 20, 13, 50, 11, 99, DateTimeKind.Local).AddTicks(1666), new List<string>(), "AQAAAAIAAYagAAAAEMTCg2r3dL5jVgSjv9fX4OOzD1lrgbnkdG8YraRunTRLvFErGethSh/I4koFB6szvA==" });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(832), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(906), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(919), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(930), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Components",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(940), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1032), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1050), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1058), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1103), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1111), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1006), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1051), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1059), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1104), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1111), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1119), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1008), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1035), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1052), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1096), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1105), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1112), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1120), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1009), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1036), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1045), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1053), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1098), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1106), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1113), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1121), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1010), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1037), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1046), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1054), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1099), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1107), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1114), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1122), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1017), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1100), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1115), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1123), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1018), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1039), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1048), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1101), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1124), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1040), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1049), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1056), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1102), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1109), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1125), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1126), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1138), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1143), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1148), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1162), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1139), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1144), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1149), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1154), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1130), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1135), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1140), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1145), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1150), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1155), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1164), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1160), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1137), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1142), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1147), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1152), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Racks",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1166), new DateTime(2023, 12, 20, 13, 50, 11, 95, DateTimeKind.Local).AddTicks(1166) });
        }
    }
}
